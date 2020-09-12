/* SENTENCIAS DESDE MYSQL */
/*Sentencia para usuario paciente*/
            CREATE USER '19248371'@'%' IDENTIFIED BY 'Pa.19248371';
            GRANT SELECT ON dbTriage.persona TO '19248371'@'%';
            GRANT SELECT ON dbTriage.medico TO '19248371'@'%';
            GRANT SELECT ON dbTriage.paciente TO '19248371'@'%';
            GRANT SELECT ON dbTriage.telefono TO '19248371'@'%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.sesion TO '19248371'@'%';
            GRANT SELECT ON dbTriage.sintoma TO '19248371'@'%';
            GRANT SELECT ON dbTriage.patologia TO '19248371'@'%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.chat TO '19248371'@'%';
            GRANT SELECT, INSERT ON dbTriage.diagnostico TO '19248371'@'%';
            GRANT INSERT, SELECT ON dbTriage.recibe TO '19248371'@'%';
            GRANT INSERT, SELECT ON dbTriage.tiene TO '19248371'@'%';
            GRANT SELECT ON dbTriage.asociados TO '19248371'@'%';
            FLUSH PRIVILEGES;

            CREATE USER '19248372'@'%' IDENTIFIED BY 'Pa.19248371';
            GRANT SELECT ON dbTriage.persona TO '19248372'@'%';
            GRANT SELECT ON dbTriage.medico TO '19248372'@'%';
            GRANT SELECT ON dbTriage.paciente TO '19248372'@'%';
            GRANT SELECT ON dbTriage.telefono TO '19248372'@'%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.sesion TO '19248372'@'%';
            GRANT SELECT ON dbTriage.sintoma TO '19248372'@'%';
            GRANT SELECT ON dbTriage.patologia TO '19248372'@'%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.chat TO '19248372'@'%';
            GRANT SELECT, INSERT ON dbTriage.diagnostico TO '19248372'@'%';
            GRANT INSERT, SELECT ON dbTriage.recibe TO '19248372'@'%';
            GRANT INSERT, SELECT ON dbTriage.tiene TO '19248372'@'%';
            GRANT SELECT ON dbTriage.asociados TO '19248372'@'%';
            FLUSH PRIVILEGES;

/*Sentencia para usuarios medicos*/
            CREATE USER '19266171'@'192.168.1.%' IDENTIFIED BY 'Me.19266171';
            GRANT SELECT ON dbTriage.persona TO '19266171'@'192.168.1.%';
            GRANT SELECT ON dbTriage.paciente TO '19266171'@'192.168.1.%';
            GRANT SELECT ON dbTriage.preexistentes TO '19266171'@'192.168.1.%';
            GRANT SELECT, UPDATE ON dbTriage.sesion TO '19266171'@'192.168.1.%';
            GRANT SELECT ON dbTriage.sintoma TO '19266171'@'192.168.1.%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.chat TO '19266171'@'192.168.1.%';
            GRANT SELECT ON dbTriage.recibe TO '19266171'@'192.168.1.%';
            GRANT SELECT ON dbTriage.tiene TO '19266171'@'192.168.1.%';
            GRANT SELECT ON dbTriage.medico TO '19266171'@'192.168.1.%';
            GRANT SELECT ON dbTriage.telefono TO '19266171'@'192.168.1.%';
            FLUSH PRIVILEGES;

            CREATE USER '19266173'@'192.168.1.%' IDENTIFIED BY 'Me.19266171';
            GRANT SELECT ON dbTriage.persona TO '19266173'@'192.168.1.%';
            GRANT SELECT ON dbTriage.paciente TO '19266173'@'192.168.1.%';
            GRANT SELECT ON dbTriage.preexistentes TO '19266173'@'192.168.1.%';
            GRANT SELECT, UPDATE ON dbTriage.sesion TO '19266173'@'192.168.1.%';
            GRANT SELECT ON dbTriage.sintoma TO '19266173'@'192.168.1.%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.chat TO '19266173'@'192.168.1.%';
            GRANT SELECT ON dbTriage.recibe TO '19266173'@'192.168.1.%';
            GRANT SELECT ON dbTriage.tiene TO '19266173'@'192.168.1.%';
            GRANT SELECT ON dbTriage.medico TO '19266173'@'192.168.1.%';
            GRANT SELECT ON dbTriage.telefono TO '19266173'@'192.168.1.%';
            FLUSH PRIVILEGES;

            CREATE USER '19266173'@'192.168.56.%' IDENTIFIED BY 'Me.19266171';
            GRANT SELECT ON dbTriage.persona TO '19266173'@'192.168.56.%';
            GRANT SELECT ON dbTriage.paciente TO '19266173'@'192.168.56.%';
            GRANT SELECT ON dbTriage.preexistentes TO '19266173'@'192.168.56.%';
            GRANT SELECT, UPDATE ON dbTriage.sesion TO '19266173'@'192.168.56.%';
            GRANT SELECT ON dbTriage.sintoma TO '19266173'@'192.168.56.%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.chat TO '19266173'@'192.168.56.%';
            GRANT SELECT ON dbTriage.recibe TO '19266173'@'192.168.56.%';
            GRANT SELECT ON dbTriage.tiene TO '19266173'@'192.168.56.%';
            GRANT SELECT ON dbTriage.medico TO '19266173'@'192.168.56.%';
            GRANT SELECT ON dbTriage.telefono TO '19266173'@'192.168.56.%';
            FLUSH PRIVILEGES;


/*Sentencia para usuarios gestores/administrativos*/
/*El administrativo lleva IP de conexion especifica */
            GRANT ALL PRIVILEGES ON *.* TO '11111111'@'192.168.1.%' IDENTIFIED BY 'Ge.11111111' WITH GRANT OPTION;
            GRANT SELECT, INSERT, UPDATE ON dbTriage.persona TO '11111111'@'192.168.1.%';
            GRANT SELECT, INSERT, UPDATE, DELETE ON dbTriage.telefono TO '11111111'@'192.168.1.%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.administrativo TO '11111111'@'192.168.1.%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.medico TO '11111111'@'192.168.1.%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.paciente TO '11111111'@'192.168.1.%';
            GRANT SELECT, INSERT, UPDATE, DELETE ON dbTriage.preexistentes TO '11111111'@'192.168.1.%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.sintoma TO '11111111'@'192.168.1.%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.patologia TO '11111111'@'192.168.1.%';
            GRANT SELECT, INSERT, UPDATE, DELETE ON dbTriage.asociados TO '11111111'@'192.168.1.%';
  	    FLUSH PRIVILEGES;

            GRANT ALL PRIVILEGES ON *.* TO '22222222'@'192.168.56.%' IDENTIFIED BY 'Ge.22222222' WITH GRANT OPTION;
            GRANT SELECT, INSERT, UPDATE ON dbTriage.persona TO '22222222'@'192.168.56.%';
            GRANT SELECT, INSERT, UPDATE, DELETE ON dbTriage.telefono TO '22222222'@'192.168.56.%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.administrativo TO '22222222'@'192.168.56.%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.medico TO '22222222'@'192.168.56.%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.paciente TO '22222222'@'192.168.56.%';
            GRANT SELECT, INSERT, UPDATE, DELETE ON dbTriage.preexistentes TO '22222222'@'192.168.56.%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.sintoma TO '22222222'@'192.168.56.%';
            GRANT SELECT, INSERT, UPDATE ON dbTriage.patologia TO '22222222'@'192.168.56.%';
            GRANT SELECT, INSERT, UPDATE, DELETE ON dbTriage.asociados TO '22222222'@'192.168.56.%';
            FLUSH PRIVILEGES;