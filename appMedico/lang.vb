
Public Module lang
    'Variables globales
    Public VIngresoAlSistema As String
    Public VBienvenido As String
    Public VLeyendaLogin As String
    Public VDocumento As String
    Public VPassword As String
    Public VIngresar As String
    Public VErrorDeLogin As String
    Public VErrorAcceso As String
    Public VNombreMedico As String
    Public VOnLine As String
    Public VChatVacio As String
    Public VSintomasIngresados As String
    Public VVerChat As String
    Public VVerDatosPaciente As String
    Public VPonerEspera As String
    Public VFinalizarChat As String
    Public VNombres As String
    Public VApellidos As String
    Public VDocIdentidad As String
    Public VFechaNacimiento As String
    Public VCalle As String
    Public VNumero As String
    Public VApto As String
    Public VBarrio As String
    Public VEsquina As String
    Public VFechaRegistro As String
    Public VEnfermedadesPreExistentes As String
    Public VErrorChequearMensaje As String
    Public VChatActivo As String
    Public VErrorDatosPaciente As String
    Public VError As String
    Public VErrorEnfermedadesPreExixtentes As String
    Public VNoCargaronSintomasPaciente As String
    Public VErrorCargarMensajesRecibidos As String
    Public VErrorIntentarMarcarMensaje As String
    Public VErrorEnviarMensaje As String
    Public VErrorEnviarChatEspera As String
    Public VErrorVerficarSesionesEspera As String
    Public VSeguroFinalizarChat As String
    Public VErrorRegistrarCierreChat As String
    Public VCopiaEmailAPaciente As String
    Public VAvisoAntesDeCierre As String
    Public VErrorVerificarEstadoSesion As String
    Public VPacienteCerroSesionChat As String
    Public VAviso As String
    Public VNoCerrarChatEnProceso As String
    Public VAlertaCierre As String


    'Metodo que seleccione el idioma
    Public Sub SeleccionDeIdioma()
        If My.Settings.lenguaje = "es" Then
            cargarEspanol()
        Else
            cargarIngles()
        End If

    End Sub



    'Metodo que cargue el idioma
    Private Sub cargarEspanol()
        VIngresoAlSistema = My.Resources.es.ingresoalsistema
        VBienvenido = My.Resources.es.bienvenido
        VLeyendaLogin = My.Resources.es.leyendalogin
        VDocumento = My.Resources.es.documento
        VPassword = My.Resources.es.password
        VIngresar = My.Resources.es.ingresar
        VErrorDeLogin = My.Resources.es.errordelogin
        VErrorAcceso = My.Resources.es.errordeacceso
        VNombreMedico = My.Resources.es.nombremedico
        VOnLine = My.Resources.es.online
        VChatVacio = My.Resources.es.chatvacio
        VSintomasIngresados = My.Resources.es.sintomasingresados
        VVerChat = My.Resources.es.verchat
        VVerDatosPaciente = My.Resources.es.verdatospaciente
        VPonerEspera = My.Resources.es.ponerespera
        VFinalizarChat = My.Resources.es.finalizarchat
        VNombres = My.Resources.es.nombres
        VApellidos = My.Resources.es.apellidos
        VDocIdentidad = My.Resources.es.docidentidad
        VFechaNacimiento = My.Resources.es.fechanacimiento
        VCalle = My.Resources.es.calle
        VNumero = My.Resources.es.numero
        VApto = My.Resources.es.apto
        VBarrio = My.Resources.es.barrio
        VEsquina = My.Resources.es.esquina
        VFechaRegistro = My.Resources.es.fecharegistro
        VEnfermedadesPreExistentes = My.Resources.es.enfermedadespreexistentes
        VErrorChequearMensaje = My.Resources.es.errorchequearmensaje
        VChatActivo = My.Resources.es.chatactivo
        VErrorDatosPaciente = My.Resources.es.errordatospaciente
        VError = My.Resources.es.err
        VErrorEnfermedadesPreExixtentes = My.Resources.es.errorcargarenfermedadespreexistentes
        VNoCargaronSintomasPaciente = My.Resources.es.nocargaronsintomaspaciente
        VErrorCargarMensajesRecibidos = My.Resources.es.errorcargarmensajesrecibidos
        VErrorIntentarMarcarMensaje = My.Resources.es.errorintentarmarcarmensaje
        VErrorEnviarMensaje = My.Resources.es.errorenviarmensaje
        VErrorEnviarChatEspera = My.Resources.es.errorenviarchatespera
        VErrorVerficarSesionesEspera = My.Resources.es.errorverificarsesionesespera
        VSeguroFinalizarChat = My.Resources.es.segurofinalizarchat
        VErrorRegistrarCierreChat = My.Resources.es.errorregistrarcierrechat
        VCopiaEmailAPaciente = My.Resources.es.copiaemailapaciente
        VAvisoAntesDeCierre = My.Resources.es.avisoantesdecierre
        VErrorVerificarEstadoSesion = My.Resources.es.errorverificarestadosesion
        VPacienteCerroSesionChat = My.Resources.es.pacientecerrosesion
        VAviso = My.Resources.es.aviso
        VNoCerrarChatEnProceso = My.Resources.es.nocerrarchatenproceso
        VAlertaCierre = My.Resources.es.alertadecierre


    End Sub

    Private Sub cargarIngles()
        VIngresoAlSistema = My.Resources.en.ingresoalsistema
        VBienvenido = My.Resources.en.bienvenido
        VBienvenido = My.Resources.en.leyendalogin
        VDocumento = My.Resources.en.documento
        VPassword = My.Resources.en.password
        VIngresar = My.Resources.en.ingresar
        VErrorDeLogin = My.Resources.en.ingresar
        VErrorAcceso = My.Resources.en.errordeacceso
        VNombreMedico = My.Resources.en.nombremedico
        VOnLine = My.Resources.en.online
        VChatVacio = My.Resources.en.chatvacio
        VSintomasIngresados = My.Resources.en.sintomasingresados
        VVerChat = My.Resources.en.verchat
        VVerDatosPaciente = My.Resources.en.verdatospaciente
        VPonerEspera = My.Resources.en.ponerespera
        VFinalizarChat = My.Resources.en.finalizarchat
        VNombres = My.Resources.en.nombres
        VApellidos = My.Resources.en.apellidos
        VDocIdentidad = My.Resources.en.docidentidad
        VFechaNacimiento = My.Resources.en.fechanacimiento
        VCalle = My.Resources.en.calle
        VNumero = My.Resources.en.numero
        VApto = My.Resources.en.apto
        VBarrio = My.Resources.en.barrio
        VEsquina = My.Resources.en.esquina
        VFechaRegistro = My.Resources.en.fecharegistro
        VEnfermedadesPreExistentes = My.Resources.en.enfermedadespreexistentes
        VErrorChequearMensaje = My.Resources.en.errorchequearmensaje
        VChatActivo = My.Resources.en.chatactivo
        VErrorDatosPaciente = My.Resources.en.errordatospaciente
        VError = My.Resources.en.err
        VErrorEnfermedadesPreExixtentes = My.Resources.en.errorcargarenfermedadespreexistentes
        VNoCargaronSintomasPaciente = My.Resources.en.nocargaronsintomaspaciente
        VErrorCargarMensajesRecibidos = My.Resources.en.errorcargarmensajesrecibidos
        VErrorIntentarMarcarMensaje = My.Resources.en.errorintentarmarcarmensaje
        VErrorEnviarMensaje = My.Resources.en.errorenviarmensaje
        VErrorEnviarChatEspera = My.Resources.en.errorenviarchatespera
        VErrorVerficarSesionesEspera = My.Resources.en.errorverificarsesionesespera
        VSeguroFinalizarChat = My.Resources.en.segurofinalizarchat
        VErrorRegistrarCierreChat = My.Resources.en.errorregistrarcierrechat
        VCopiaEmailAPaciente = My.Resources.en.copiaemailapaciente
        VAvisoAntesDeCierre = My.Resources.en.avisoantesdecierre
        VErrorVerificarEstadoSesion = My.Resources.en.errorverificarestadosesion
        VPacienteCerroSesionChat = My.Resources.en.pacientecerrosesion
        VAviso = My.Resources.en.aviso
        VNoCerrarChatEnProceso = My.Resources.en.nocerrarchatenproceso
        VAlertaCierre = My.Resources.en.alertadecierre


    End Sub

End Module
