Imports capaDatos
Public Class ModeloSintoma

    Public ID As Integer
    Public Nombre As String
    Public Estado As Boolean
    Public listaSintomas As New List(Of ModeloSintoma)
    Public ListaFiltradaSintomas As New List(Of ModeloSintoma)
    Public SintomasSeleccionados As New List(Of ModeloSintoma)

    Public Function guardarSintoma() As Boolean
        'envia solicitud de guardar
        Return True
    End Function

    Public Function eliminarSintoma(ByVal id As Integer) As Boolean
        'elimina sintoma o lo marca como 0 - inhabilitado
        Return True
    End Function

    Public Function listarSintomas() As List(Of ModeloSintoma)
        Return listaSintomas
    End Function

    Public Function listarSintomas(nombre As String) As List(Of ModeloSintoma)
        'busca y retorna lista con los sintomas resultantes de la busqueda
        cargarListaSintomas()
        ListaFiltradaSintomas.Clear()
        For Each sintoma In listaSintomas
            If sintoma.Nombre.Contains(nombre) Then
                ListaFiltradaSintomas.Add(sintoma)
            End If
        Next
        Return ListaFiltradaSintomas
    End Function

    'hay que borrar estas lineas, se crearon para cargar sintomas de prueba
    Public Sub cargarListaSintomas()
        listaSintomas.Clear()
        listaSintomas.Add(New ModeloSintoma With
                          {
                          .ID = 1,
                          .Nombre = "Fiebre",
                          .Estado = True
                          })
        listaSintomas.Add(New ModeloSintoma With
                  {
                  .ID = 2,
                  .Nombre = "Fiebre alta",
                  .Estado = True
                  })
        listaSintomas.Add(New ModeloSintoma With
                  {
                  .ID = 3,
                  .Nombre = "Fiebre baja",
                  .Estado = True
                  })
        listaSintomas.Add(New ModeloSintoma With
                  {
                  .ID = 4,
                  .Nombre = "Dolor de pierna",
                  .Estado = True
                  })
        listaSintomas.Add(New ModeloSintoma With
                  {
                  .ID = 5,
                  .Nombre = "Dolor abdomen",
                  .Estado = True
                  })
        listaSintomas.Add(New ModeloSintoma With
                  {
                  .ID = 6,
                  .Nombre = "Dolor de cabeza",
                  .Estado = True
                  })
        listaSintomas.Add(New ModeloSintoma With
                  {
                  .ID = 7,
                  .Nombre = "Tos",
                  .Estado = True
                  })
        listaSintomas.Add(New ModeloSintoma With
                  {
                  .ID = 8,
                  .Nombre = "Vomito",
                  .Estado = True
                  })
        listaSintomas.Add(New ModeloSintoma With
                  {
                  .ID = 9,
                  .Nombre = "Diarrea",
                  .Estado = True
                  })
        listaSintomas.Add(New ModeloSintoma With
                  {
                  .ID = 10,
                  .Nombre = "Tos con catarro",
                  .Estado = True
                  })
        listaSintomas.Add(New ModeloSintoma With
                  {
                  .ID = 11,
                  .Nombre = "Colicos",
                  .Estado = True
                  })
    End Sub
End Class
