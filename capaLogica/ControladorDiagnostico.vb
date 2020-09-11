Imports capaDatos
Imports System.Data

Public Module ControladorDiagnostico

    Public Function CrearInformeDiagnostico(ByVal listaSintomasSeleccionados As List(Of Integer), uid As String, pwd As String) As DataTable
        'Devuelve las patologias que contienen los sintomas ingresados por el paciente
        Dim tablaPatologiasPorSintomas As New DataTable
        Dim stringSQL As String = formarCadenaDeConsulta(listaSintomasSeleccionados)
        Dim a As New ModeloAsociados(uid, pwd)
        tablaPatologiasPorSintomas = a.FiltrarPatologiasPorSintomas(stringSQL, listaSintomasSeleccionados.Count)
        Return evaluarTablaPatologias(tablaPatologiasPorSintomas, listaSintomasSeleccionados, uid, pwd)
    End Function

    Private Function evaluarTablaPatologias(ByRef tablaDePatologias As DataTable, listaSintomasSeleccionados As List(Of Integer), uid As String, pwd As String)
        'Evalua si existen patologias con los sintomas seleccionados por el paciente y hace los registros
        If tablaDePatologias.Rows.Count > 0 Then
            ponderarDiagnostico(tablaDePatologias)
            guardarDiagnosticoEnBD(uid, pwd)
            guardarRelacionPacienteDiagnostico(uid, pwd)
            formatearStringSQL(ModeloDiagnostico.CodigoDiagnostico, tablaDePatologias, listaSintomasSeleccionados, uid, pwd)
        Else
            generarCodigoDeSesionSinDiagnostico(uid, pwd)
            guardarDiagnosticoEnBD(uid, pwd)
            guardarRelacionPacienteDiagnostico(uid, pwd)
        End If
        Return tablaDePatologias
    End Function

    Private Sub generarCodigoDeSesionSinDiagnostico(ByVal uid As String, pwd As String)
        'Si el paciene no obtiene diagnostico, se genera instancia vacia de sesion para chat
        ModeloDiagnostico.Ponderacion = 0
        asignarCodigoDeDiagnostico()
    End Sub

    Private Function formarCadenaDeConsulta(ByVal listaSintomasSeleccionados As List(Of Integer)) As String
        Dim texto As String = ""
        For i = 0 To listaSintomasSeleccionados.Count - 1
            texto = texto & "," & listaSintomasSeleccionados.Item(i).ToString
        Next
        Return texto.Remove(0, 1)
    End Function

    Private Sub ponderarDiagnostico(ByRef ListaDePatologiasParaDiagnostico As DataTable)
        'calcula la ponderacion del diagnostico que despues se utlizara en el chat
        Dim ponderacion As Integer = 0

        For Each patologias As DataRow In ListaDePatologiasParaDiagnostico.Rows
            If patologias("ponderacion").ToString = 40 Then
                ponderacion = 40
                Exit For
            Else
                ponderacion = calcularPonderacionDiagnostico(ListaDePatologiasParaDiagnostico)
            End If
        Next
        ModeloDiagnostico.Ponderacion = ponderacion
    End Sub

    Private Function calcularPonderacionDiagnostico(ByRef ListaDePatologiasParaDiagnostico As DataTable)
        'Si no hay ninguna patologia de EMERGENCIA calcula el promedio para ordenar en el chat
        Dim cantidad As Integer = ListaDePatologiasParaDiagnostico.Rows.Count
        Dim totalPonderaciones As Integer
        For Each patologias As DataRow In ListaDePatologiasParaDiagnostico.Rows
            totalPonderaciones = totalPonderaciones + patologias("ponderacion").ToString
        Next
        Return totalPonderaciones / cantidad
    End Function

    Private Sub guardarDiagnosticoEnBD(ByVal uid As String, pwd As String)
        'Guarda el diagnostico en la bd
        asignarCodigoDeDiagnostico()
        Dim d As New ModeloDiagnostico(uid, pwd)
        d.GuardarDiagnostico()
    End Sub

    Private Sub asignarCodigoDeDiagnostico()
        ModeloDiagnostico.CodigoDiagnostico = generarCodigoDeDiagnostico()
    End Sub

    Private Sub guardarRelacionPacienteDiagnostico(ByVal uid As String, pwd As String)
        'Guarda la relacion paciente recibe diagnostico en la bd
        Dim pd As New ModeloRecibe(uid, pwd)
        pd.DocIdentidad = uid
        pd.GuardarRelacionPacienteDiagnostico()
    End Sub

    Private Sub formatearStringSQL(codigoDiagnostico As String, listaDePatologiasParaDiagnostico As DataTable, listaSintomasSeleccionados As List(Of Integer), uid As String, pwd As String)
        'Da formato a la consulta que se enviara para guardar en la base de datos
        Dim stringSQL As String = ""
        For Each patologiasDeDiagnostico As DataRow In listaDePatologiasParaDiagnostico.Rows
            For Each sintomasSeleccionados In listaSintomasSeleccionados
                stringSQL = stringSQL & "(" & codigoDiagnostico & ", " & patologiasDeDiagnostico("IdPatologia").ToString & ", " & sintomasSeleccionados.ToString & "),"
            Next
        Next
        guardarSintomasIngresados(stringSQL.Remove(stringSQL.Length - 1, 1), uid, pwd)
    End Sub

    Private Sub guardarSintomasIngresados(ByVal stringSQL As String, uid As String, pwd As String)
        'Guarda de un INSERT la relacion diagnostico, patologia y sintoma
        Dim guardarTiene As New ModeloTiene(uid, pwd)
        guardarTiene.GuardarRelacionDiagnosticoPatologia(stringSQL)
    End Sub

    Private Function generarCodigoDeDiagnostico() As String
        'Genera codigo aleatorio de diagnostico
        Dim fechaHora As Date = DateTime.Now
        Dim codigo As String
        codigo = fechaHora.ToString("dd mm ss FFF")
        Return codigo.Replace(" ", "")
    End Function

    Public Function ValidarSintomaSeleccionado(ByVal idSintoma As Integer, ByVal listaSintomasSeleccionados As List(Of Integer)) As Boolean
        'Completa la lista de sintomas seleccionados por el paciente si esta vacia y sino, llama al metodo verifiar para ver si ya no esta ingresado
        If listaSintomasSeleccionados.Count = 0 Then
            Return True
        Else
            Return VerificarSiYaFueIngresado(idSintoma, listaSintomasSeleccionados)
        End If
    End Function

    Public Function VerificarSiYaFueIngresado(ByVal idSintoma As Integer, listaSintomasSeleccionados As List(Of Integer))
        'Valida si el sintoma que selecciono el paciente ya fue seleccionado anteriormente 
        For s = 0 To listaSintomasSeleccionados.Count - 1
            If listaSintomasSeleccionados.Item(s) <> idSintoma Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Function devolverIdSesion()
        Return ModeloDiagnostico.CodigoDiagnostico
    End Function

    Public Function TraerDiagnosticos(ByVal uid As String, pwd As String, documento As String)
        Dim d As New ModeloDiagnostico(uid, pwd)
        Return d.TraerDiagnosticos(documento)
    End Function

    Public Function CantidadDeDiagnosticos(ByVal uid As String, pwd As String, documento As String)
        Dim d As New ModeloDiagnostico(uid, pwd)
        Return d.cantidadDeDiagnosticos(documento)
    End Function

End Module
