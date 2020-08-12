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
        'Evalua si existen patologias con los sintomas seleccionados por el paciente
        Dim tablaDePatologiasPorSintomas As New DataTable
        tablaDePatologiasPorSintomas = tablaDePatologias
        If tablaDePatologiasPorSintomas.Rows.Count > 0 Then
            ponderarDiagnostico(tablaDePatologiasPorSintomas, listaSintomasSeleccionados, uid, pwd)
        End If
        Return tablaDePatologiasPorSintomas
    End Function

    Private Function formarCadenaDeConsulta(ByVal listaSintomasSeleccionados As List(Of Integer)) As String
        Dim texto As String = ""
        For i = 0 To listaSintomasSeleccionados.Count - 1
            texto = texto & "," & listaSintomasSeleccionados.Item(i).ToString
        Next
        Return texto.Remove(0, 1)
    End Function

    Private Sub ponderarDiagnostico(ByRef ListaDePatologiasParaDiagnostico As DataTable, listaSintomasSeleccionados As List(Of Integer), uid As String, pwd As String)
        'calcula la ponderacion del diagnostico que despues se utlizara en el chat
        For Each patologias As DataRow In ListaDePatologiasParaDiagnostico.Rows
            If patologias("ponderacion").ToString = 40 Then
                ModeloDiagnostico.Ponderacion = 40
                Exit For
            Else
                ModeloDiagnostico.Ponderacion = calcularPonderacionDiagnostico(ListaDePatologiasParaDiagnostico)
            End If
        Next
        guardarDiagnosticoEnBD(ModeloDiagnostico.Ponderacion, ListaDePatologiasParaDiagnostico, listaSintomasSeleccionados, uid, pwd)
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

    Private Sub guardarDiagnosticoEnBD(ByVal ponderacionDiagnostico As String, listaDePatologiasParaDiagnostico As DataTable, listaSintomasSeleccionados As List(Of Integer), uid As String, pwd As String)
        'Guarda el diagnostico en la bd
        asignarCodigoDeDiagnostico()
        Dim d As New ModeloDiagnostico(uid, pwd)
        d.GuardarDiagnostico()
        guardarRelacionPacienteDiagnostico(ModeloDiagnostico.CodigoDiagnostico, listaDePatologiasParaDiagnostico, listaSintomasSeleccionados, uid, pwd)
    End Sub

    Private Sub asignarCodigoDeDiagnostico()
        ModeloDiagnostico.CodigoDiagnostico = generarCodigoDeDiagnostico()
    End Sub

    Private Sub guardarRelacionPacienteDiagnostico(ByVal codigoDiagnostico As String, listaDePatologiasParaDiagnostico As DataTable, listaSintomasSeleccionados As List(Of Integer), uid As String, pwd As String)
        'Guarda la relacion paciente recibe diagnostico en la bd
        Dim pd As New ModeloRecibe(uid, pwd)
        pd.DocIdentidad = uid
        pd.IdDiagnostico = codigoDiagnostico
        pd.GuardarRelacionPacienteDiagnostico()
        formatearStringSQL(codigoDiagnostico, listaDePatologiasParaDiagnostico, listaSintomasSeleccionados, uid, pwd)
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

    Public Function NuevoMensaje() As String
        'Genera un numero aleatorio del 1 al 4 para luego mostrar mensajes diferentes.
        Dim Random As New Random()
        Dim numero As Integer = Random.Next(1, 4)
        Return mensaje(numero)
    End Function

    Private Function mensaje(id As Integer) As String
        Dim txtMensaje As String
        Select Case id
            Case 1
                txtMensaje = "Si tienes otro sintoma, ingresado  "
            Case 2
                txtMensaje = "Tienes otro sintoma ? ingresalo "
            Case 3
                txtMensaje = "Que otro sintoma tienes? ingresado"
            Case 4
                txtMensaje = "Sientes otro sintoma ? ingresalo"
            Case Else
                txtMensaje = "Mensaje por defecto"
        End Select
        Return txtMensaje
    End Function

End Module
