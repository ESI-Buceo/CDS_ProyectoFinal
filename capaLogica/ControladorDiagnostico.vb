Imports capaDatos
Public Module ControladorDiagnostico
    Public PonderacionDiagnostico As Integer
    Public CantidadDeSintomasFiltrados As Integer
    Public ListaSintomasSeleccionados As New List(Of ModeloSintoma)
    Public ListaRelacionPatologiaSintoma As New List(Of ModeloAsociados)
    Public ListaFiltradaPatologiasXSintomas As New List(Of ModeloAsociados)
    Public ListaDePatologiasParaDiagnostico As New List(Of ModeloPatologia)


    Public Sub CrearInformeDiagnostico()
        Dim a As New ModeloAsociados
        a.CargarListaAsociadosBD()
        ListaRelacionPatologiaSintoma.Clear()
        ListaRelacionPatologiaSintoma = a.ListaRelacionPatologiaSintoma
        FiltrarPatologiasXSintomas()
    End Sub

    Public Sub cargarSintomaAListaSintomasSeleccionados(ByVal idSintoma As Integer, sintomaNombre As String)
        ListaSintomasSeleccionados.Add(New ModeloSintoma With {.ID = idSintoma, .Nombre = sintomaNombre})
    End Sub

    Public Sub FiltrarPatologiasXSintomas()
        ' realiza el primer filtro de la relacion patologia sintomas para obtener las primeras patologias que coinciden con el primer sintoma
        ListaFiltradaPatologiasXSintomas.Clear()
        For index = 0 To ListaRelacionPatologiaSintoma.Count - 1
            If ListaRelacionPatologiaSintoma.Item(index).IdSintoma = ListaSintomasSeleccionados.Item(0).ID Then
                ListaFiltradaPatologiasXSintomas.Add(New ModeloAsociados With {.IdPatologia = ListaRelacionPatologiaSintoma.Item(index).IdPatologia, .IdSintoma = ListaRelacionPatologiaSintoma.Item(index).IdSintoma, .IdSigno = ListaRelacionPatologiaSintoma.Item(index).IdSigno, .incluida = False})
            End If
        Next
        filtroFinalPatologiaXSintomas()
    End Sub

    Private Sub filtroFinalPatologiaXsintomas()
        'filtra ListaFiltradaPatologiasXSintomas por los otros sintomas ingrsados por el paciente
        For Each patologiasSelecionadas In ListaFiltradaPatologiasXSintomas
            For Each listaPrimariaPatologias In ListaRelacionPatologiaSintoma
                If listaPrimariaPatologias.IdPatologia = patologiasSelecionadas.IdPatologia Then
                    For s = 1 To ListaSintomasSeleccionados.Count - 1
                        If listaPrimariaPatologias.IdSintoma = ListaSintomasSeleccionados(s).ID Then
                            patologiasSelecionadas.incluida = True
                            Exit For
                        End If
                    Next
                End If
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

    Public Function DevolverListaPatologiasDiagnostico()
        'devuelve la lista de patologias del diagnostico
        Return ListaDePatologiasParaDiagnostico
    End Function

    Private Sub ponderarDiagnostico()
        PonderacionDiagnostico = 0
        For Each patologias In ListaDePatologiasParaDiagnostico
            PonderacionDiagnostico = PonderacionDiagnostico + patologias.Ponderacion
        Next
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
