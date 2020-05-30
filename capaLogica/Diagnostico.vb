Imports capaDatos
Public Module Diagnostico
    Public PonderacionDiagnostico As Integer
    Public CantidadDeSintomasFiltrados As Integer
    Public listaPatologias As New List(Of ModeloPatologia)
    Public ListaFiltradaPatologias As New List(Of ModeloPatologia)

    Public Sub buscarSintomaEnPatologia(id As Integer)
        'verifica si ya existen patologias filtradas
        If ListaFiltradaPatologias.Count > 0 Then
            BuscarSintomaEnListafitradaDePatologia(id)
        Else
            filtrarPatologia(id)
        End If
    End Sub

    Public Sub filtrarPatologia(id As Integer)
        'filtra las patologias que contienen el sintoma ingresado por el paciente
        Dim existePatologia As Boolean = False
        For Each patologia In listaPatologias
            For Each sintona In patologia.ListaSintomasPatologia
                If buscarSintomaEnPatologia(patologia, id) Then
                    agregaPatologiaAListaFiltrada(patologia)
                    Exit For
                End If
            Next
        Next
    End Sub

    Private Function buscarSintomaEnPatologia(patologia As ModeloPatologia, id As Integer) As Boolean
        'Verifica si la patologia tiene como sintoma el ingresado por el paciente
        Dim existeSintoma As Boolean = False
        For indexSintoma = 0 To patologia.ListaSintomasPatologia.Count - 1
            If patologia.ListaSintomasPatologia(indexSintoma).ID = id Then
                existeSintoma = True
            End If
        Next
        Return existeSintoma
    End Function

    Private Sub agregaPatologiaAListaFiltrada(patologia As ModeloPatologia)
        'Agrega la patologia a la lista de patologias filtradas por sintoma
        ListaFiltradaPatologias.Clear()
        ListaFiltradaPatologias.Add(patologia)
    End Sub

    Public Sub BuscarSintomaEnListafitradaDePatologia(id As Integer)
        'Marca con 0 las patologias que no tienen los sintomas ingresados por el paciente
        For Each patologia In ListaFiltradaPatologias
            For Each sintomas In patologia.ListaSintomasPatologia
                If buscarSintomaEnPatologia(patologia, id) = False Then
                    patologia.Estado = 0
                End If
            Next
        Next
    End Sub

    Public Function DiagnosticoFinal() As Integer
        'arma el diagnostico final que luego sera utilizado para detarminar la prioridad en el chat
        For i = 0 To ListaFiltradaPatologias.Count - 1
            If ListaFiltradaPatologias.Item(i).Estado = 1 Then
                CantidadDeSintomasFiltrados = CantidadDeSintomasFiltrados + 1
                PonderacionDiagnostico = PonderacionDiagnostico + ListaFiltradaPatologias.Item(i).Ponderacion
            End If
        Next
        Return PonderacionDiagnostico
    End Function

    'Mensajes aleatorios que manda el sistema
    Public Function seleccionarMensaje() As String
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
