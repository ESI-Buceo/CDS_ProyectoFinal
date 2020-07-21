Imports System.Data
Imports System.Windows.Forms
Imports capaDatos
Public Module ControladorMedico

    Public Function verificarDocumento(ByVal docidentidad As String)
        'Verifia si el documento que se va a agregar ya existe
        Dim m As New ModeloMedico
        Return m.VerfificarDocumento(docidentidad)
    End Function

    Public Sub GuardarDatosMedico(ByVal docId As String, email As String, nombres As String, apellidos As String, calle As String,
                                  numero As String, barrio As String, esquina As String, apto As String, fechaNac As String,
                                  activo As String, telefonos As DataGridView, numeroMedico As String, doc As TextBox)
        'Guarda los datos del medico
        Dim m As New ModeloMedico
        m.Documento = docId
        m.Email = email
        m.Nombres = nombres
        m.Apellidos = apellidos
        m.Calle = calle
        m.Numero = numero
        m.Barrio = barrio
        m.Esquina = esquina
        m.Apartamento = apto
        m.FechaNacimiento = fechaNac
        m.NumeroMedico = numeroMedico
        m.Activo = activo
        m.Telefonos = cargarGridTelefonosADataTable(telefonos)
        If doc.ReadOnly Then m.ModificarDatosMedico() Else m.GuardarDatosMedico()
    End Sub

    Private Function cargarGridTelefonosADataTable(ByVal telefonos As DataGridView) As DataTable
        'Carga la lista de telefonos
        Dim listaTelefonos As New DataTable
        listaTelefonos = TryCast(telefonos.DataSource, DataTable)
        Return listaTelefonos
    End Function

    Public Sub EliminiarMedico(ByVal docIdentidad As String)
        'Elimina logicamente a un medico
        Dim m As New ModeloMedico
        m.EliminarMedico(docIdentidad)
    End Sub

    Public Function buscarMedicoPorDocumento(ByVal docIdentidad As String)
        'Busca medico por documento
        Dim m As New ModeloMedico
        Return m.buscarMedicoPorDocumento(docIdentidad)
    End Function

    Public Function validardocIdentidad(ByVal docIdentidad As String)
        'Valida que el documento sea un numero
        If Integer.TryParse(docIdentidad, 1) And docIdentidad.Length > 6 And docIdentidad.Length < 10 Then
            Return True
        End If
        Return False
    End Function

    Public Function crearTablaTelefonos()
        'Crea la tabla que alimenta el datagrid de telefonos
        Dim tablaTel As New DataTable
        tablaTel.Columns.Add("Telefono")
        Return tablaTel
    End Function

    Public Function crearCadenaDeBusqueda(ByVal campoABuscar As String, datoABuscar As String)
        'Crea la cadena de consulta de acuerdo a los datos ingresados para ello
        Select Case campoABuscar
            Case "txtDocIdentidad" : Return "p.docidentidad=" & datoABuscar
            Case "txtNumMedico" : Return "m.ndemedico=" & datoABuscar
            Case "txtNombres" : Return "p.nombres LIKE '%" & datoABuscar & "%'"
            Case "txtApellidos" : Return "p.apellidos LIKE '%" & datoABuscar & "%'"
        End Select
        Return ""
    End Function

    Public Function buscarMedico(ByVal cadenaSql As String)
        'Busca los medicos que coinciden con los criterios de busqueda
        Dim m As New ModeloMedico
        Return m.BuscarMedico(formatearSqlBuscquedaMedico(cadenaSql))
    End Function

    Private Function formatearSqlBuscquedaMedico(ByVal datoString As String)
        'Elimina el ultimo and de la consulta
        If datoString IsNot Nothing Then
            Return datoString.Remove(datoString.Length - 4, 4)
        End If
        Return "p.nombres like '%%'"
    End Function
End Module
