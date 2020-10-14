Public Module lang
    Public VIdiomaActivo As String
    Public VIngresoAlSistema As String
    Public VDocumentoIdentidad As String
    Public VPassword As String
    Public VIngresar As String
    Public VErrorDatosAcceso As String
    Public VErrorAcceso As String
    Public VLeyendaInicial As String
    Public VUsuarioRegistrado As String
    Public VPresionaParaVerInforme As String
    Public VAguardaPreparamosInforme As String
    Public VErrorRecuperarDatos As String
    Public VAvisoErrorAccesoDatos As String
    Public VNoExistenPatologias As String
    Public VHemosPreparadoInforme As String
    Public VCualEsTuPrincipalSintoma As String
    Public VErrorGuardarSesionChat As String
    Public VError As String
    Public VElMedicoCerroSesin As String
    Public VAvisoCierreSesion As String
    Public VOnline As String
    Public VErrorAlEnviarMensaje As String
    Public Vtu As String
    Public VDoctor As String
    Public VSeguroDeCerrarSesion As String
    Public VErrorCancelarChat As String
    Public VCambioRequiereReiniciar As String
    Public VCambioDeIdioma As String
    Public VDatosPersonales As String
    Public VHistoricoChat As String
    Public VMensajeInicial As String
    Public VConsulta As String
    Public VChat As String
    Public VHistoria As String
    Public VIniciarConsulta As String
    Public VSiguiente As String
    Public VListaDeSintomas As String
    Public VNombre As String
    Public VElSintomaYaEstaIngresado As String
    Public VSitienesOtroSintoma As String
    Public VTienesOtroSintoma As String
    Public VQueOtroSintomaTienes As String
    Public VSientesOtroSintoma As String
    Public VsaberMas As String
    Public VDeseasIngresarUnNuevoSintomas As String
    Public VSi As String
    Public VNo As String
    Public VVerInforme As String
    Public VNuevaConsulta As String
    Public VIniciarChat As String
    Public VRecordarMisDatos As String
    Public VEsperandoMedico As String
    Public VCancelar As String
    Public VEstado As String
    Public VEnEspera As String
    Public VDatos As String
    Public VDocumento As String
    Public VFechaRegistro As String
    Public VApellidos As String
    Public VDireccion As String
    Public VNro As String
    Public VApto As String
    Public VEsquina As String
    Public VBarrio As String
    Public VEmail As String
    Public VTelefonos As String
    Public VPatologiasPreExistentes As String
    Public VLenguaje As String
    Public VEspanol As String
    Public VIngles As String
    Public VComunicateConNosotros As String
    Public VDiagnosticosRecibidos As String
    Public VPatologiasDiagnosticadas As String
    Public VErrorArchivo As String
    Public VSeguroCerrarAplicacion As String
    Public VAvisoConfirmacion As String
    Public VElPacienteSalioDelChat As String
    Public VAyuda As String

    Public Sub CargarIdioma()
        VIdiomaActivo = My.Settings.lenguaje
        If VIdiomaActivo.Equals("es") Then
            idioma_es()
        Else
            idioma_en()
        End If
    End Sub

    Private Sub idioma_es()
        VIngresoAlSistema = My.Resources.es.ingresoalsistema
        VDocumentoIdentidad = My.Resources.es.docidentidad
        VPassword = My.Resources.es.password
        VIngresar = My.Resources.es.ingresar
        VErrorDatosAcceso = My.Resources.es.errordatosacceso
        VErrorAcceso = My.Resources.es.erroracceso
        VLeyendaInicial = My.Resources.es.leyendainicial
        VUsuarioRegistrado = My.Resources.es.usuarioregistrado
        VPresionaParaVerInforme = My.Resources.es.presionaparaverinforme
        VAguardaPreparamosInforme = My.Resources.es.aguardapreparamosinforme
        VErrorRecuperarDatos = My.Resources.es.errorrecuperardatos
        VAvisoErrorAccesoDatos = My.Resources.es.erroraccesodatos
        VNoExistenPatologias = My.Resources.es.noexistenpatologias
        VHemosPreparadoInforme = My.Resources.es.hemospreparadoinforme
        VCualEsTuPrincipalSintoma = My.Resources.es.cualestuprincipalsintoma
        VErrorGuardarSesionChat = My.Resources.es.errorguardarsesionchat
        VError = My.Resources.es.err
        VElMedicoCerroSesin = My.Resources.es.elmedicocerrosesion
        VAvisoCierreSesion = My.Resources.es.cierredesesion
        VOnline = My.Resources.es.online
        VErrorAlEnviarMensaje = My.Resources.es.errorenviarmensaje
        Vtu = My.Resources.es.tu
        VDoctor = My.Resources.es.doctor
        VSeguroDeCerrarSesion = My.Resources.es.segurocerrarsesion
        VErrorCancelarChat = My.Resources.es.errorcancelarsesionchat
        VCambioRequiereReiniciar = My.Resources.es.cambiorequierereiniciar
        VCambioDeIdioma = My.Resources.es.cambioidoma
        VDatosPersonales = My.Resources.es.verificarinformacionpersonal
        VHistoricoChat = My.Resources.es.historicochat
        VMensajeInicial = My.Resources.es.mensajeinicial
        VConsulta = My.Resources.es.consulta
        VChat = My.Resources.es.chat
        VHistoria = My.Resources.es.historia
        VIniciarConsulta = My.Resources.es.iniciarconsulta
        VSiguiente = My.Resources.es.siguiente
        VListaDeSintomas = My.Resources.es.listadesintomas
        VNombre = My.Resources.es.nombre
        VElSintomaYaEstaIngresado = My.Resources.es.elsistomayaestaingresado
        VSitienesOtroSintoma = My.Resources.es.sitienesotrosintoma
        VTienesOtroSintoma = My.Resources.es.tienesotrosintoma
        VQueOtroSintomaTienes = My.Resources.es.queotrosintomatienes
        VSientesOtroSintoma = My.Resources.es.sientesotrosintoma
        VsaberMas = My.Resources.es.sabermas
        VDeseasIngresarUnNuevoSintomas = My.Resources.es.deseaingresarnuevosintoma
        VSi = My.Resources.es.si
        VNo = My.Resources.es.no
        VVerInforme = My.Resources.es.verinforme
        VNuevaConsulta = My.Resources.es.nuevaconsulta
        VIniciarChat = My.Resources.es.iniciarchat
        VRecordarMisDatos = My.Resources.es.recordarmisdatos
        VEsperandoMedico = My.Resources.es.esperandomedico
        VCancelar = My.Resources.es.cancelar
        VEstado = My.Resources.es.estado
        VEnEspera = My.Resources.es.enespera
        VDatos = My.Resources.es.datos
        VDocumento = My.Resources.es.documento
        VFechaRegistro = My.Resources.es.fecharegistro
        VApellidos = My.Resources.es.apellidos
        VDireccion = My.Resources.es.direccion
        VNro = My.Resources.es.numero
        VApto = My.Resources.es.apto
        VEsquina = My.Resources.es.esquina
        VBarrio = My.Resources.es.barrio
        VEmail = My.Resources.es.email
        VTelefonos = My.Resources.es.telefonos
        VPatologiasPreExistentes = My.Resources.es.patologiaspreexistentes
        VLenguaje = My.Resources.es.lenguaje
        VEspanol = My.Resources.es.espanol
        VIngles = My.Resources.es.ingles
        VcomunicateConNosotros = My.Resources.es.comunicateconnosotros
        VDiagnosticosRecibidos = My.Resources.es.diagnosticosrecibidos
        VPatologiasDiagnosticadas = My.Resources.es.patologiasdiagnosticadas
        VErrorArchivo = My.Resources.es.errorarchivo
        VSeguroCerrarAplicacion = My.Resources.es.segurocerraraplicacion
        VAvisoConfirmacion = My.Resources.es.avisoconfirmacion
        VElPacienteSalioDelChat = My.Resources.es.elpacientehasalidodelchat
        VAyuda = My.Resources.es.ayuda
    End Sub

    Private Sub idioma_en()
        VIngresoAlSistema = My.Resources.en.ingresoalsistema
        VDocumentoIdentidad = My.Resources.en.docidentidad
        VPassword = My.Resources.en.password
        VIngresar = My.Resources.en.ingresar
        VErrorDatosAcceso = My.Resources.en.errordatosacceso
        VErrorAcceso = My.Resources.en.erroracceso
        VLeyendaInicial = My.Resources.en.leyendainicial
        VUsuarioRegistrado = My.Resources.en.usuarioregistrado
        VPresionaParaVerInforme = My.Resources.en.presionaparaverinforme
        VAguardaPreparamosInforme = My.Resources.en.aguardapreparamosinforme
        VErrorRecuperarDatos = My.Resources.en.errorrecuperardatos
        VAvisoErrorAccesoDatos = My.Resources.en.erroraccesodatos
        VNoExistenPatologias = My.Resources.en.noexistenpatologias
        VHemosPreparadoInforme = My.Resources.en.hemospreparadoinforme
        VCualEsTuPrincipalSintoma = My.Resources.en.cualestuprincipalsintoma
        VErrorGuardarSesionChat = My.Resources.en.errorguardarsesionchat
        VError = My.Resources.en.err
        VElMedicoCerroSesin = My.Resources.en.elmedicocerrosesion
        VAvisoCierreSesion = My.Resources.en.cierredesesion
        VOnline = My.Resources.en.online
        VErrorAlEnviarMensaje = My.Resources.en.errorenviarmensaje
        Vtu = My.Resources.en.tu
        VDoctor = My.Resources.en.doctor
        VSeguroDeCerrarSesion = My.Resources.en.segurocerrarsesion
        VErrorCancelarChat = My.Resources.en.errorcancelarsesionchat
        VCambioRequiereReiniciar = My.Resources.en.cambiorequierereiniciar
        VCambioDeIdioma = My.Resources.en.cambioidoma
        VDatosPersonales = My.Resources.en.verificarinformacionpersonal
        VHistoricoChat = My.Resources.en.historicochat
        VMensajeInicial = My.Resources.en.mensajeinicial
        VConsulta = My.Resources.en.consulta
        VChat = My.Resources.en.chat
        VHistoria = My.Resources.en.historia
        VIniciarConsulta = My.Resources.en.iniciarconsulta
        VSiguiente = My.Resources.en.siguiente
        VListaDeSintomas = My.Resources.en.listadesintomas
        VNombre = My.Resources.en.nombre
        VElSintomaYaEstaIngresado = My.Resources.en.elsistomayaestaingresado
        VSitienesOtroSintoma = My.Resources.en.sitienesotrosintoma
        VTienesOtroSintoma = My.Resources.en.tienesotrosintoma
        VQueOtroSintomaTienes = My.Resources.en.queotrosintomatienes
        VSientesOtroSintoma = My.Resources.en.sientesotrosintoma
        VsaberMas = My.Resources.en.sabermas
        VDeseasIngresarUnNuevoSintomas = My.Resources.en.deseaingresarnuevosintoma
        VSi = My.Resources.en.si
        VNo = My.Resources.en.no
        VVerInforme = My.Resources.en.verinforme
        VNuevaConsulta = My.Resources.en.nuevaconsulta
        VIniciarChat = My.Resources.en.iniciarchat
        VRecordarMisDatos = My.Resources.en.recordarmisdatos
        VEsperandoMedico = My.Resources.en.esperandomedico
        VCancelar = My.Resources.en.cancelar
        VEstado = My.Resources.en.estado
        VEnEspera = My.Resources.en.enespera
        VDatos = My.Resources.en.datos
        VDocumento = My.Resources.en.Documento
        VFechaRegistro = My.Resources.en.fecharegistro
        VApellidos = My.Resources.en.apellidos
        VDireccion = My.Resources.en.direccion
        VNro = My.Resources.en.numero
        VApto = My.Resources.en.apto
        VEsquina = My.Resources.en.esquina
        VBarrio = My.Resources.en.barrio
        VEmail = My.Resources.en.email
        VTelefonos = My.Resources.en.telefonos
        VPatologiasPreExistentes = My.Resources.en.patologiaspreexistentes
        VLenguaje = My.Resources.en.lenguaje
        VEspanol = My.Resources.en.espanol
        VIngles = My.Resources.en.ingles
        VComunicateConNosotros = My.Resources.en.comunicateconnosotros
        VDiagnosticosRecibidos = My.Resources.en.diagnosticosrecibidos
        VPatologiasDiagnosticadas = My.Resources.en.patologiasdiagnosticadas
        VErrorArchivo = My.Resources.en.errorarchivo
        VSeguroCerrarAplicacion = My.Resources.en.segurocerraraplicacion
        VAvisoConfirmacion = My.Resources.en.avisoconfirmacion
        VElPacienteSalioDelChat = My.Resources.en.elpacientehasalidodelchat
        VAyuda = My.Resources.en.ayuda
    End Sub

End Module
