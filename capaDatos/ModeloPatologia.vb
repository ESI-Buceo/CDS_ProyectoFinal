Public Class ModeloPatologia
    Public Id As Integer
    Public Nombre As String
    Public Ponderacion As Integer
    Public Descripcion As String
    Public Estado As Integer

    Public ListaSintomasPatologia As New List(Of ModeloSintoma)
    Public ListaSignosPatologia As New List(Of ModeloSignos)
    Public ListaPatologias As New List(Of ModeloPatologia)


    Public Function GuaradrPatologia() As Boolean
        ' guarda nueva patologia
        Return True
    End Function

    Public Function eliminarPatologia(id As Integer)
        'elimina la patologa con el id
        Return True
    End Function

    Public Function ListarPatologias() As List(Of ModeloPatologia)
        'lista todas las patologias
        Return ListaPatologias
    End Function

    Public Function buscarPatologia(nombre As String) As List(Of ModeloPatologia)
        'busca y retorna lista con los patologias resultantes de la busqueda
        Return ListarPatologias()
    End Function

    Private Function validarNombre() As Boolean
        'valida que el nombre no tenga caracteres raros
        Return True
    End Function

    Private Function validarDescripcion() As Boolean
        'valida que la descripcion no tenga codigos raros
        Return True
    End Function

    Private Function validarPonderacion() As Boolean
        'valida que la ponderacion sea numerica
        Return True
    End Function

    Private Function validarEstado() As Boolean
        'valida que el esado true o false
        Return True
    End Function

    'hay que borrar estas lineas, fueron creadas para cargar patologias de pruebas
    Public Sub cargarListaPatologias()

    End Sub
End Class
