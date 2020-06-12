Imports capaDatos
Imports System.Data

Public Module ControladorDiagnostico
    Public CodigoDiagnostico As String
    Public PonderacionDiagnostico As Integer
    Public CantidadDeSintomasFiltrados As Integer
    Private ListaSintomasSeleccionados As New List(Of ModeloSintoma)
    Public ListaRelacionPatologiaSintoma As New List(Of ModeloAsociados)
    Public ListaFiltradaPatologiasXSintomas As New List(Of ModeloAsociados)
    Public ListaDePatologiasParaDiagnostico As New List(Of ModeloPatologia)

    Public Sub CrearInformeDiagnostico()
        'Carga la informacion de relacion patologia, signo, sintoma de la base de datos
        Dim a As New ModeloAsociados
        cargarListaRelacionPatologiaSintoma(a.CargarListaAsociadosBD())
        FiltrarPatologiasXSintomas()
    End Sub

    Private Sub cargarListaRelacionPatologiaSintoma(ByRef tablaAsociados As DataTable)
        For patologiasSintomas = 0 To tablaAsociados.Rows.Count - 1
            ListaRelacionPatologiaSintoma.Add(New ModeloAsociados With {
                                            .IdPatologia = tablaAsociados.Rows(patologiasSintomas).Item("idPatologia").ToString,
                                            .IdSintoma = tablaAsociados.Rows(patologiasSintomas).Item("idSintoma").ToString,
                                            .IdSigno = tablaAsociados.Rows(patologiasSintomas).Item("idSigno").ToString
                                              })
        Next
    End Sub

    Public Function ValidarSintomaSeleccionado(ByVal idSintoma As Integer, sintomaNombre As String)
        If ListaSintomasSeleccionados.Count = 0 Then
            ListaSintomasSeleccionados.Add(New ModeloSintoma With {.ID = idSintoma, .Nombre = sintomaNombre})
            Return True
        Else
            Return VerificarSiYaFueIngresado(idSintoma, sintomaNombre)
        End If
    End Function

    Public Function VerificarSiYaFueIngresado(ByVal idSintoma As Integer, sintomaNombre As String)
        For s = 0 To ListaSintomasSeleccionados.Count - 1
            If ListaSintomasSeleccionados.Item(s).ID <> idSintoma Then
                ListaSintomasSeleccionados.Add(New ModeloSintoma With {.ID = idSintoma, .Nombre = sintomaNombre})
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub FiltrarPatologiasXSintomas()
        ' realiza el primer filtro de la relacion patologia sintomas para obtener las primeras patologias que coinciden con el primer sintoma
        ListaFiltradaPatologiasXSintomas.Clear()
        For index = 0 To ListaRelacionPatologiaSintoma.Count - 1
            If ListaRelacionPatologiaSintoma.Item(index).IdSintoma = ListaSintomasSeleccionados.Item(0).ID Then
                ListaFiltradaPatologiasXSintomas.Add(New ModeloAsociados With {.IdPatologia = ListaRelacionPatologiaSintoma.Item(index).IdPatologia, .IdSintoma = ListaRelacionPatologiaSintoma.Item(index).IdSintoma, .IdSigno = ListaRelacionPatologiaSintoma.Item(index).IdSigno})
            End If
        Next
        filtroFinalPatologiaXsintomas()
    End Sub

    Private Sub filtroFinalPatologiaXsintomas()
        'filtra ListaFiltradaPatologiasXSintomas por los otros sintomas ingrsados por el paciente
        For s = 1 To ListaSintomasSeleccionados.Count - 1
            For Each patologiasSeleccionadas In ListaFiltradaPatologiasXSintomas
                For Each listaPrimariaPatologias In ListaRelacionPatologiaSintoma
                    If listaPrimariaPatologias.IdPatologia = patologiasSeleccionadas.IdPatologia Then
                        If listaPrimariaPatologias.IdSintoma = ListaSintomasSeleccionados.Item(s).ID Then
                            patologiasSeleccionadas.incluida = True
                            Exit For
                        Else
                            patologiasSeleccionadas.incluida = False
                        End If
                    End If
                Next
            Next
        Next
        devolverPatologiasParaDiagnostico()
    End Sub

    Private Sub devolverPatologiasParaDiagnostico()
        'prepara el listado de patologias para mostrar al paciente
        ListaDePatologiasParaDiagnostico.Clear()
        For Each patologiasSelecionadas In ListaFiltradaPatologiasXSintomas
            If patologiasSelecionadas.incluida Then
                Dim p As New ModeloPatologia
                ListaDePatologiasParaDiagnostico.Add(p.BuscarPatologiaPorID(patologiasSelecionadas.IdPatologia))
            End If
        Next
        ponderarDiagnostico()
    End Sub

    Public Function DevuelveListaSintomasSeleccionados()
        Return ListaSintomasSeleccionados
    End Function

    Public Function DevolverListaPatologiasDiagnostico()
        'devuelve la lista de patologias del diagnostico
        Return ListaDePatologiasParaDiagnostico
    End Function

    Public Function DevolverlistaListaFiltradaPatologiasXSintomas()
        Return ListaFiltradaPatologiasXSintomas
    End Function

    Private Sub ponderarDiagnostico()
        'calcula la ponderacino del diagnostico que despues se utlizara en el chat
        PonderacionDiagnostico = 0
        For Each patologias In ListaDePatologiasParaDiagnostico
            If patologias.Ponderacion = 40 Then
                PonderacionDiagnostico = 40
                Exit For
            Else
                calcularPonderacionDiagnostico()
            End If
        Next
        guardarDiagnosticoEnBD()
    End Sub

    Private Sub calcularPonderacionDiagnostico()
        'Si no hay ninguna patologia de EMERGENCIA calcula el promedio para ordenar en el chat
        Dim cantidad As Integer = ListaDePatologiasParaDiagnostico.Count
        Dim totalPonderaciones As Integer

        For Each patologias In ListaDePatologiasParaDiagnostico
            totalPonderaciones = totalPonderaciones + patologias.Ponderacion
        Next
        PonderacionDiagnostico = totalPonderaciones / cantidad
    End Sub

    Private Sub guardarDiagnosticoEnBD()
        Dim d As New ModeloDiagnostico
        d.idDiagnostico = generarCodigoDeDiagnostico()
        d.Prioridad = PonderacionDiagnostico
        d.guardarDiagnostico(d)
        guardarRelacionPacienteDiagnostico()
    End Sub

    Private Sub guardarRelacionPacienteDiagnostico()
        Dim pd As New ModeloRecibe
        pd.docIdentidad = "11111111"
        pd.idDiagnostico = CodigoDiagnostico
        pd.guardarRelacionPacienteDiagnostico()
        guardarRelacionDiagnosticoPatologia()
    End Sub

    Private Sub guardarRelacionDiagnosticoPatologia()
        For Each patologiasDeDiagnostico In ListaDePatologiasParaDiagnostico
            Dim guardarTiene As New ModeloTiene
            guardarTiene.idDiagnostico = CodigoDiagnostico
            guardarTiene.idPatologia = patologiasDeDiagnostico.Id
            guardarTiene.guardarRelacionDiagnosticoPatologia()
        Next
    End Sub

    Private Function generarCodigoDeDiagnostico()
        Dim fechaHora As Date = DateTime.Now
        Dim codigo As String
        codigo = fechaHora.ToString("dd yy hh mm ss")
        CodigoDiagnostico = codigo.Replace(" ", "")
        Return CodigoDiagnostico
    End Function

    Public Sub NuevaConsulta()
        ListaRelacionPatologiaSintoma.Clear()
        ListaSintomasSeleccionados.Clear()
        ListaDePatologiasParaDiagnostico.Clear()
        ListaFiltradaPatologiasXSintomas.Clear()
        PonderacionDiagnostico = 0
        CantidadDeSintomasFiltrados = 0
    End Sub

    'Mensajes aleatorios que manda el sistema
    Public Function NuevoMensaje() As String
        Dim Random As New Random()
        Dim numero As Integer = Random.Next(1, 4)
        Return mensaje(numero)
    End Function

    Private Function mensaje(id As Integer) As String
        Dim txtMensaje As String
        Select Case id
            Case 1
                txtMensaje = "Que mas sientes? "
            Case 2
                txtMensaje = "Sientes otro malestar? "
            Case 3
                txtMensaje = "Que otro sintoma tienes? "
            Case 4
                txtMensaje = "Sientes algo mas?"
            Case Else
                txtMensaje = "Mensaje por defecto"
        End Select
        Return txtMensaje
    End Function

End Module
