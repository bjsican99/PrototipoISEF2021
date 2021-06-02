CREATE DATABASE IF NOT EXISTS HRM;
USE HRM;
#--------------- Mantenimientos de Modulo HRM-----------------

CREATE TABLE IF NOT EXISTS COMPETENCIA(
idCompetencia INT,
nombreCompetencia VARCHAR(150),
descripcion VARCHAR(250),
estado TINYINT
);
ALTER TABLE COMPETENCIA ADD PRIMARY KEY(idCompetencia);

create table if not exists CURSO
(
	idCurso int(10),
    nombreCurso varchar(50),
    descripcion varchar(250),
    idCompetencia INT,
    estado boolean
);
alter table CURSO add primary key(idCurso);
ALTER TABLE CURSO ADD CONSTRAINT fk_cursoCompentencia FOREIGN KEY (idCompetencia) REFERENCES COMPETENCIA(idCompetencia); 

CREATE TABLE CAPACITADOREXTERNO(
idCapacitadorExterno INT,
nombreCompleto VARCHAR(175),
dpi INT,
genero TINYINT,
email VARCHAR(150),
telefono INT,
fechaInscripcion VARCHAR(150),
estado TINYINT
);
ALTER TABLE CAPACITADOREXTERNO ADD PRIMARY KEY(idCapacitadorExterno);

create table if not exists DIFICULTAD
(
	idDificultad int(10),
	nombre varchar(50),
    estado boolean
);
alter table DIFICULTAD add primary key(idDificultad);

create table if not exists PUESTO
(
	idPuesto int(10),
    nombrePuesto varchar(50),
    descripcion varchar(250),
	salario double(12,2),
    estado boolean
);
alter table PUESTO add primary key(idPuesto);

create table if not exists DEPARTAMENTOEMPRESA
(
	idDepartamentoEmpresa int(10),
    nombreDepartamento varchar(50),
    descripcion varchar(250),
    estado boolean
);
alter table DEPARTAMENTOEMPRESA add primary key(idDepartamentoEmpresa);

create table if not exists LICENCIACONDUCIR
(
	idLicencia int(10),
    tipoLicencia varchar(50),
    descripcion varchar(250),
    estado boolean
);
alter table LICENCIACONDUCIR add primary key(idLicencia);

create table if not exists FORMACIONACADEMICA
(
	idFormacionAcademica int(10),
	nombreFormacionAcademica varchar(50),
	descripcion varchar(250),
    estado boolean
);
alter table FORMACIONACADEMICA add primary key(idFormacionAcademica);

create table if not exists TIPOHORARIO
(
	idTipoHorario int(10),
	tipoHorario varchar(50),
	descripcion varchar(250),
    estado boolean
);
alter table TIPOHORARIO add primary key(idTipoHorario);

create table if not exists TIPOMONEDA
(
	idTipoMoneda int(10),
	tipoMoneda varchar(50),
	descripcion varchar(250),
    valor double(12,3),
    estado boolean
);
alter table TIPOMONEDA add primary key(idTipoMoneda);

create table if not exists TIPOPERCEPCIONDEDUCCION
(
	idTipoPercepcionDeduccion int(10),
	tipoPercepcionDeduccion varchar(50),
	descripcion varchar(250),
    formula varchar(100),
    valor varchar(10),
    signo varchar(2),
	tipo tinyint,
    estado boolean
);
alter table TIPOPERCEPCIONDEDUCCION add primary key(idTipoPercepcionDeduccion);

create table if not exists TIPOFALTA
(
	idTipoFalta int(10),
	tipoFalta varchar(50),
	descripcion varchar(250),
    valor double(8,2),
    estado boolean
);
alter table TIPOFALTA add primary key(idTipoFalta);

create table if not exists TIPOCONTRATO
(
	idTipoContrato int(10),
	tipoContrato varchar(50),
	descripcion varchar(250),
    estado boolean
);
alter table TIPOCONTRATO add primary key(idTipoContrato);

create table if not exists TIPOENTREVISTA
(
	idTipoEntrevista int(10),
	tipoEntrevista varchar(50),
	descripcion varchar(250),
    estado boolean
);
alter table TIPOENTREVISTA add primary key(idTipoEntrevista);

CREATE TABLE IF NOT EXISTS ENTREVISTA(
    idEntrevista 			 		INT(10) NOT NULL,
    idTipoEntrevista 				INT(10),
    punteo							INT(3),
    resultadoentrevista             varchar(50),
    comentarios					    varchar(250)
);

alter table ENTREVISTA add primary key(idEntrevista);
alter table ENTREVISTA add Constraint fkidTipoEntrevista foreign key(idTipoEntrevista) references TIPOENTREVISTA (idTipoEntrevista);

CREATE TABLE IF NOT EXISTS TIPOEVALUACION (
    IdTipoEvaluacion			 		INT(10) NOT NULL ,
    TipoEvaluacion				 		varchar(50),
    Descripcion							varchar(250),
    Estado								tinyint(1)
);
alter table TIPOEVALUACION add primary key(IdTipoEvaluacion);

CREATE TABLE IF NOT EXISTS Induccion (
    idInduccion			 				INT(10) NOT NULL ,
    idEmpleado				 			INT(10),
    idtipoInduccion						INT(10),
    FechaInduccion						varchar(250),
    Estado							tinyint(1)	
);

alter table INDUCCION add primary key(idInduccion);

CREATE TABLE IF NOT EXISTS TipoInduccion (
    IdTipoInduccion			 			INT(10) NOT NULL ,
    TipoInduccion				 		varchar(50),
    Descripcion							varchar(250),
    Estado							tinyint(1)
);

alter table TIPOINDUCCION add primary key(IdTipoInduccion);
alter table Induccion add constraint fk_induccion_tipo foreign key (idtipoInduccion) references TipoInduccion (IdTipoInduccion) on delete restrict on update cascade;

#---------------Fin Mantenimientos de Modulo HRM-----------------
#---------------Procesos Mantenimientos de Modulo HRM-----------------

create table if not exists RECLUTAMIENTO
(
	idRecluta int(10),
	nombre  varchar(100),
    apellido  varchar(100),
    DPI varchar(15),
    profesionActual varchar(100),
    fechaNacimiento  varchar(50),
    genero boolean,
	estadoCivil boolean,
    correo varchar(50),
    telefono varchar(50),
	numeroIgss varchar(50),
    fechaReclutamiento  varchar(50),
    idLicencia  int(10),
    idPuesto int(10),
    idHorario int(10),
    idDepatamentoEmpresa int(10),
    idFormacionAcademica int(10),
    idEntrevista int(10),
    estado boolean
);

alter table RECLUTAMIENTO add primary key(idRecluta);
alter table RECLUTAMIENTO add Constraint fkidLicencia foreign key(idLicencia) references LICENCIACONDUCIR (idLicencia);
alter table RECLUTAMIENTO add Constraint fkidPuesto foreign key(idPuesto) references PUESTO (idPuesto);
alter table RECLUTAMIENTO add Constraint fkidHorario foreign key(idHorario) references TIPOHORARIO (idTipoHorario);
alter table RECLUTAMIENTO add Constraint fkidDepatamentoEmpresa foreign key(idDepatamentoEmpresa) references DEPARTAMENTOEMPRESA (idDepartamentoEmpresa);
alter table RECLUTAMIENTO add Constraint fkidFormacionAcademica foreign key(idFormacionAcademica) references FORMACIONACADEMICA (idFormacionAcademica);
alter table RECLUTAMIENTO add Constraint fkidEntrevista foreign key(idEntrevista) references ENTREVISTA (idEntrevista);


CREATE TABLE IF NOT EXISTS EVALUACION (
    idEvaluacion			 			INT(10) NOT NULL ,
    idRecluta				 			INT(10),
    idtipoEvaluacion					INT(10),
    PunteoEvaluacion					INT(3),
    ResultadoEvaluacion                	varchar(50),
    Comentarios							varchar(250)
);
alter table EVALUACION add primary key(idEvaluacion);
alter table EVALUACION add Constraint fkidRecluta foreign key(idRecluta) references RECLUTAMIENTO (idRecluta);
alter table EVALUACION add Constraint fkIdTipoEvaluacion foreign key(IdTipoEvaluacion) references TIPOEVALUACION (IdTipoEvaluacion);

create table if not exists EMPLEADO
(
	idEmpleado int(10),
	idRecluta  int(10),
    cuentaBancaria  int(25),
	idTipoContrato int(10),
    imagenContrato varchar(100),
	fotografiaPerfil varchar(100),
    fechaContratacion varchar(50),
    estado boolean
);

alter table EMPLEADO add primary key (idEmpleado);
alter table EMPLEADO add Constraint fkidReclutaEmpleado foreign key(idRecluta) references RECLUTAMIENTO (idRecluta);
alter table EMPLEADO add Constraint fkidTipoContrato foreign key(idTipoContrato) references TIPOCONTRATO (idTipoContrato);
alter table Induccion add constraint fk_induccion_empleado foreign key (idEmpleado) references EMPLEADO (idEmpleado) on delete restrict on update cascade;

CREATE TABLE IF NOT EXISTS PETICIONCAPACITACION(
idPeticionCapacitacion INT,
tituloCapacitacion VARCHAR(150),
descripcion VARCHAR(240),
idEmpleado INT,
idCurso INT,
estado TINYINT
);
ALTER TABLE PETICIONCAPACITACION ADD PRIMARY KEY(idPeticionCapacitacion);
ALTER TABLE PETICIONCAPACITACION ADD CONSTRAINT fk_petiEmpleado FOREIGN KEY (idEmpleado) REFERENCES EMPLEADO(idEmpleado);
ALTER TABLE PETICIONCAPACITACION ADD CONSTRAINT fk_petCurso FOREIGN KEY (idCurso) REFERENCES CURSO(idCurso); 

create table if not exists COMISION
(
    idComision  int(10),
	idEmpleado int(10),
	cantidad double(12,2),
    fechaComision varchar(50),
    estado boolean
);

alter table COMISION add primary key (idComision);
alter table COMISION add Constraint fkidEmpleado foreign key(idEmpleado) references EMPLEADO (idEmpleado);

create table if not exists ENCABEZADOCAPACITACION
(
    idEncabezadoCapacitacion  int(10),
    tituloCapacitacion varchar(150),
    descripcionCapacitacion varchar(250),
    externo TINYINT,
    idCapacitador INT,
	fechaInicio varchar(50),
    fechaFin varchar(50),
	idCurso int(10),
    idDificultad int(10),
    estado TINYINT
);
alter table ENCABEZADOCAPACITACION add primary key (idEncabezadoCapacitacion);
alter table ENCABEZADOCAPACITACION add Constraint fkidCurso foreign key(idCurso) references CURSO (idCurso);
alter table ENCABEZADOCAPACITACION add Constraint fkidDificultad foreign key(idDificultad) references DIFICULTAD (idDificultad);



create table if not exists DETALLECAPACITACION
(
    idEncabezadoCapacitacion  int(10),
	idEmpleado int(10),
    Resultado double(12,2),
    estado TINYINT
);

alter table DETALLECAPACITACION add Constraint fkidEncabezadoCapacitacion foreign key(idEncabezadoCapacitacion) references ENCABEZADOCAPACITACION (idEncabezadoCapacitacion);
alter table DETALLECAPACITACION add  Constraint fk_idEmpleado foreign key(idEmpleado) references EMPLEADO (idEmpleado);



create table if not exists DETALLEFALTA
(
    idDetalleFalta int(10),
	idTipoFalta int(10),
	consecuencia varchar(50),
	idEmpleado int(10),
	fechaFalta varchar(50)
);
alter table DETALLEFALTA add primary key(idDetalleFalta);
alter table DETALLEFALTA add Constraint fkidTipoFalta foreign key(idTipoFalta) references TIPOFALTA (idTipoFalta);
alter table DETALLEFALTA add Constraint fkidEmpleadoDetalleFalta foreign key(idEmpleado) references EMPLEADO (idEmpleado);

create table if not exists ENCABEZADONOMINA
(
    idEncabezadoNomina  int(10),
	nombreNomina varchar(50),
	fechaInicio varchar(50),
    fechaFin varchar(50),
    totalNomina double(12,2),
    idTipoMoneda int(10)
);

alter table ENCABEZADONOMINA add primary key (idEncabezadoNomina);
alter table ENCABEZADONOMINA add Constraint fkidTipoMoneda foreign key(idTipoMoneda) references TIPOMONEDA (idTipoMoneda);

create table if not exists DETALLENOMINA
(
    idEncabezadoNomina  int(10),
	idEmpleado int(10),
	idTipoPercepcionDeduccion int(10),
    valor double(12,2)
);
alter table DETALLENOMINA add primary key (idEncabezadoNomina,idEmpleado,idTipoPercepcionDeduccion);
alter table DETALLENOMINA add Constraint fkidEncabezadoDetalleNomina foreign key(idEncabezadoNomina) references ENCABEZADONOMINA (idEncabezadoNomina);
alter table DETALLENOMINA add Constraint fkidEmpleadoDetalleNomina foreign key(idEmpleado) references EMPLEADO (idEmpleado);
alter table DETALLENOMINA add Constraint fkidTipoPercepcionDeduccion foreign key(idTipoPercepcionDeduccion) references TIPOPERCEPCIONDEDUCCION (idTipoPercepcionDeduccion);

create table if not exists BAJAENCABEZADO
(
    idBajaEncabezado  int(10),
	idEmpleado int(10),
    tiempoLaborado varchar(20),
	fechaBaja varchar(20),
    Causa varchar(250),
    fotografiaFirma varchar(100),
    prestacionesTotales  double(12,2),
    tipoBaja boolean
);

alter table BAJAENCABEZADO add primary key (idBajaEncabezado);
alter table BAJAENCABEZADO add  Constraint fkidEmpleadoBajaEncabezado foreign key(idEmpleado) references EMPLEADO (idEmpleado);

create table if not exists DETALLEBAJA
(
    idBajaDetalle  int(10),
	idBajaEncabezado int(10),
    tipoPrestacion varchar(20),
	Cantidad double(12,2)
);
alter table DETALLEBAJA add primary key (idBajaDetalle);
alter table DETALLEBAJA add Constraint fkidBajaEncabezado foreign key(idBajaEncabezado) references BAJAENCABEZADO (idBajaEncabezado);
#---------------Procesos Mantenimientos de Modulo HRM-----------------

#SEGURIDAD-----------------------------------------------------------------------------------------
create table if not exists LOGIN(
	pk_id_login 						int(10) not null primary key auto_increment,
    usuario_login 						varchar(45),
    contraseña_login 					varchar(45),
    nombreCompleto_login				varchar(100),
    estado_login						int(2)
);
create table if not exists MODULO(
	pk_id_modulo 						int(10)not null auto_increment,
    nombre_modulo 						varchar(30)not null,
    descripcion_modulo 					varchar(50)not null,
    estado_modulo 						int(1)not null,
    primary key(pk_id_modulo),
    key(pk_id_modulo)
);
create table if not exists APLICACION(
	pk_id_aplicacion 					int(10)not null auto_increment,
    fk_id_modulo 						int(10)not null,
    nombre_aplicacion 					varchar(40)not null,
    descripcion_aplicacion 				varchar(45)not null,
    estado_aplicacion 					int(1)not null,
    primary key(pk_id_aplicacion),
    key(pk_id_aplicacion)
);
alter table APLICACION add constraint fk_aplicacion_modulo foreign key(fk_id_modulo) references MODULO(pk_id_modulo);

create table if not exists PERFIL(
	pk_id_perfil						int(10) not null primary key auto_increment,
    nombre_perfil						varchar(50),
    descripcion_perfil					varchar(100),
    estado_perfil						int(2)
);
create table if not exists PERMISO(
	pk_id_permiso						int(10) not null primary key auto_increment,
    insertar_permiso					boolean,
    modificar_permiso					boolean,
    eliminar_permiso					boolean,
    consultar_permiso					boolean,
    imprimir_permiso					boolean
);
create table if not exists APLICACION_PERFIL(
	pk_id_aplicacion_perfil				int(10) not null primary key auto_increment,
    fk_idaplicacion_aplicacion_perfil	int(10),
    fk_idperfil_aplicacion_perfil		int(10),
    fk_idpermiso_aplicacion_perfil		int(10)
);
alter table APLICACION_PERFIL add constraint fk_aplicacionperfil_aplicacion foreign key (fk_idaplicacion_aplicacion_perfil) references APLICACION(pk_id_aplicacion)on delete restrict on update cascade;
alter table APLICACION_PERFIL add constraint fk_aplicacionperfil_perfil foreign key (fk_idperfil_aplicacion_perfil) references PERFIL(pk_id_perfil)on delete restrict on update cascade;
alter table APLICACION_PERFIL add constraint fk_aplicacionperfil_permiso foreign key (fk_idpermiso_aplicacion_perfil) references PERMISO (pk_id_permiso)on delete restrict on update cascade;

create table if not exists PERFIL_USUARIO(
	pk_id_perfil_usuario				int(10) not null primary key auto_increment,
    fk_idusuario_perfil_usuario			int(10),
    fk_idperfil_perfil_usuario			int(10)
);
alter table PERFIL_USUARIO add constraint fk_perfil_usuario_login foreign key(fk_idusuario_perfil_usuario) references LOGIN(pk_id_login) on delete restrict on update cascade;
alter table PERFIL_USUARIO add constraint fk_perfil_usuario_perfil foreign key (fk_idperfil_perfil_usuario) references PERFIL(pk_id_perfil) on delete restrict on update cascade;

create table if not exists APLICACION_USUARIO(
	pk_id_aplicacion_usuario			int(10) not null primary key auto_increment,
    fk_idlogin_aplicacion_usuario		int(10),
    fk_idaplicacion_aplicacion_usuario	int(10),
    fk_idpermiso_aplicacion_usuario		int(10)
);
alter table APLICACION_USUARIO add constraint fk_aplicacionusuario_login foreign key(fk_idlogin_aplicacion_usuario) references LOGIN(pk_id_login) on delete restrict on update cascade;
alter table APLICACION_USUARIO add constraint fk_aplicacionusuario_aplicacion foreign key (fk_idaplicacion_aplicacion_usuario) references APLICACION(pk_id_aplicacion) on delete restrict on update cascade;
alter table APLICACION_USUARIO add constraint fk_aplicacionusuario_permiso foreign key(fk_idpermiso_aplicacion_usuario) references PERMISO (pk_id_permiso)on delete restrict on update cascade;

create table if not exists BITACORA(
	pk_id_bitacora						int(10) not null primary key auto_increment, #pk
    fk_idusuario_bitacora				int(10),
    fk_idaplicacion_bitacora			int(10),
    fechahora_bitacora					varchar(50),
    direccionhost_bitacora				varchar(20),
    nombrehost_bitacora					varchar(20),
    accion_bitacora						varchar(250)
);
CREATE TABLE IF NOT EXISTS DETALLE_BITACORA (
    pk_id_detalle_bitacora 				INT(10) NOT NULL PRIMARY KEY AUTO_INCREMENT,
    fk_idbitacora_detalle_bitacora 		INT(10),
    querryantigua_detalle_bitacora 		VARCHAR(50),
    querrynueva_detalle_bitacora 		VARCHAR(50)
);
alter table BITACORA add constraint fk_login_bitacora foreign key (fk_idusuario_bitacora) references LOGIN (pk_id_login) on delete restrict on update cascade;
alter table BITACORA add constraint fk_aplicacion_bitacora foreign key (fk_idaplicacion_bitacora) references APLICACION(pk_id_aplicacion) on delete restrict on update cascade;
alter table DETALLE_BITACORA add constraint fk_bitacora_detallebitacora foreign key(fk_idbitacora_detalle_bitacora) references BITACORA(pk_id_bitacora) on delete restrict on update cascade;



INSERT INTO `modulo` (`pk_id_modulo`, `nombre_modulo`, `descripcion_modulo`, `estado_modulo`) VALUES
(1, 'Seguridad', 'Aplicaciones de seguridad', 1),
(2, 'Consultas', 'Consultas Inteligentes', 1),
(3, 'Reporteador', 'Aplicaciones de Reporteador', 1),
(4, 'HRM', 'Aplicaciones de Recursos Humanos', 1),
(5, 'FRM', 'Aplicaciones de Finanzas', 1),
(6, 'SCM', 'Aplicaciones Control de Inventario', 1),
(7, 'MRP', 'Aplicaciones de Produccion', 1),
(8, 'CRM', 'Aplicaciones de Ventas', 1),
(9, 'PRUEBA', 'PRUEBA', 1),
(10, 'Gestión de Citas', 'En este modulo se pueden gestionar las citas', 1);


INSERT INTO `aplicacion` (`pk_id_aplicacion`, `fk_id_modulo`, `nombre_aplicacion`, `descripcion_aplicacion`, `estado_aplicacion`) VALUES
(1, 1, 'Login', 'Ventana de Ingreso', 1),
(2, 1, 'Mantenimiento Usuario', 'Mantenimientos de usuario', 1),
(3, 1, 'Mantenimiento Aplicacion', 'ABC de las Aplicaciones', 1),
(4, 1, 'Mantenimiento Perfil', 'ABC de perfiles', 1),
(5, 1, 'Asignacion de Aplicaciones a Perfil', 'Asignacion Aplicacion y perfil', 1),
(6, 1, 'Asignacaion de Aplicaciones', 'Asignacion especificas a un usuario', 1),
(7, 1, 'Consulta Aplicacion', 'Mantenimiento de Aplicaciones', 1),
(8, 1, 'Agregar Modulo', 'Mantenimientos de Modulos', 1),
(9, 1, 'Consultar Perfil', 'Consultas de perfiles disponibles', 1),
(10, 1, 'Permisos', 'Asignar permisos a perfiles y aplicaciones', 1),
(11, 1, 'Bitacora', 'Guarda todos los movimientos', 1),
(12, 10, 'Gestión de Citas ', 'Gestionar Citas', 1),
(201, 2, 'Consultas Inteligentes', 'Consultas Inteligentes Usuario Avanzado', 1),
(305, 4, 'Puestos', 'Puestos que se pueden ocupar en la empresa', 1),
(306, 4, 'Cursos', 'Cursos que puede impartir la empresa', 1),
(307, 4, 'Deparamentos', 'Departamentos de la empresa', 1),
(308, 4, 'Faltas', 'Faltas que puede cometer un empleado', 1),
(309, 4, 'Información Personal', 'Datos de los empleados', 1),
(310, 4, 'Contratos', 'Tipos de contratos por los que los empleados ', 1),
(311, 4, 'Tipo Moneda', 'Tipos de monedas que se utilizan.', 1),
(312, 4, 'Tipo de entrevista', 'Tipos de entrevistas que se le pueden hacer a', 1),
(313, 4, 'Dificultad', 'Tipo de dificultad sobre la cual pueden estar', 1),
(314, 4, 'Formación académica', 'Formación académica del recluta', 1),
(315, 4, 'Tipo de horarios ', 'Tipo de horarios en los cuales la empresa tra', 1),
(316, 4, 'Deducciones', 'Tipos de deducciones', 1),
(317, 4, 'Percepciones', 'Tipos de Percepciones', 1),
(1302, 5, 'Tipo Caso', 'Tipo de casos', 1),
(1303, 5, 'Tipo Pasaporte', 'Tipo Pasaporte', 1),
(1304, 5, 'Tipo Tramite', 'Tipo Tramite', 1),
(1305, 5, 'Centro', 'Centro', 1),
(1306, 5, 'PROPIETARIO', 'PROPIETARIO', 1),
(1307, 5, 'TRANSACCIONES', 'TRANSACCIONES', 1),
(1308, 5, 'DISPONIBILIDAD DIARIA', 'REPORTE DE DISPONIBILIDAD DIARIA', 1),
(1309, 5, 'PETICION POLIZA', 'PETICION POLIZA', 1),
(1310, 5, 'CUENTAS CONTABLES', 'AGREGAR CUENTAS CONTABLES', 1),
(1311, 5, 'POLIZAS', 'POLIZAS', 1),
(1312, 5, 'LIBRO DIARIO', 'LIBRO DIARIO', 1),
(1313, 4, 'Capacitador Externo', 'Mantenimiento de capacitores externos', 1);

INSERT INTO `login` (`pk_id_login`, `usuario_login`, `contraseña_login`, `nombreCompleto_login`, `estado_login`) VALUES
(1, 'sistema', 'bi0PL96rbxVRPKJQsLJJAg==', 'Usuario de prueba', 1),
(2, 'bjsican', '0FOYy5u5h0djKjzCYqfvkg==', 'Billy Sican', 1),
(3, 'bmaza', 'xTfsC3/XR/CVyDvNr1Fs+g==', 'Bryan Mazariegos', 1),
(4, 'jsican', 'jsican', 'Jeshua Sican', 0),
(5, 'jmorataya', '123', 'Julio Morataya', 0),
(6, 'JLOPEZ', 'LwUsihMe9Bl//D/5WaIzLA==', 'JOSE LOPEZ', 1),
(7, 'cliente', '21LRuDS2GcjNgOcK8q54Aw==', 'Usuario para clientes', 1);

INSERT INTO `perfil` (`pk_id_perfil`, `nombre_perfil`, `descripcion_perfil`, `estado_perfil`) VALUES
(1, 'Admin', 'Administracion del programa', 1),
(2, 'Sistema', 'Administrador del sistema', 1),
(3, 'Digitador', 'Digitador para Cuentas', 1),
(4, 'Consultor', 'Unicamente consultas ', 1),
(5, 'Reportes', 'Ingreso y consultas de reportes', 1),
(6, 'Pruebas', 'pruebas', 1);

INSERT INTO `perfil_usuario` (`pk_id_perfil_usuario`, `fk_idusuario_perfil_usuario`, `fk_idperfil_perfil_usuario`) VALUES
(2, 3, 3),
(4, 4, 1),
(5, 5, 5),
(6, 1, 1);

INSERT INTO `permiso` (`pk_id_permiso`, `insertar_permiso`, `modificar_permiso`, `eliminar_permiso`, `consultar_permiso`, `imprimir_permiso`) VALUES
(1, 1, 1, 1, 1, 1),
(2, 1, 0, 0, 1, 1),
(3, 1, 1, 1, 0, 0),
(4, 1, 1, 1, 1, 1),
(5, 1, 1, 1, 1, 1),
(6, 1, 1, 1, 1, 1),
(7, 1, 1, 1, 1, 1),
(8, 1, 0, 1, 0, 0),
(9, 1, 1, 0, 0, 0),
(10, 1, 1, 0, 0, 0),
(11, 1, 1, 1, 1, 1),
(12, 0, 0, 0, 1, 0),
(13, 0, 0, 0, 1, 0),
(14, 0, 0, 0, 0, 0),
(15, 1, 0, 0, 1, 0),
(16, 0, 0, 0, 0, 0),
(17, 1, 1, 0, 0, 0);


INSERT INTO `aplicacion_usuario` (`pk_id_aplicacion_usuario`, `fk_idlogin_aplicacion_usuario`, `fk_idaplicacion_aplicacion_usuario`, `fk_idpermiso_aplicacion_usuario`) VALUES
(1, 6, 317, 1),
(2, 6, 316, 1),
(3, 6, 315, 1),
(4, 6, 314, 1),
(5, 6, 313, 1),
(6, 6, 5, 1),
(7, 6, 312, 1),
(8, 6, 2, 1),
(9, 6, 3, 1),
(10, 6, 4, 1),
(11, 6, 6, 1),
(12, 6, 8, 1),
(13, 6, 305, 1),
(14, 6, 306, 1),
(15, 6, 307, 1),
(16, 6, 308, 1),
(17, 6, 309, 1),
(18, 6, 310, 1),
(19, 6, 311, 1),
(20, 6, 5, 1),
(21, 6, 10, 1),
(27, 6, 1313, 1);


INSERT INTO COMPETENCIA VALUES(1,'Contabilidad Financiera','Todo lo relacionado a contabilidad',1);
INSERT INTO COMPETENCIA VALUES(2,'Inversiones','Todo lo relacionado a inversiones',1);
INSERT INTO COMPETENCIA VALUES(3,'Tesoreria','Programación de gastos, compras, etc.',1);
INSERT INTO COMPETENCIA VALUES(4,'Controlling','Controles de costos y análisis',1);

INSERT INTO `curso` (`idCurso`, `nombreCurso`, `descripcion`,`idCompetencia`,`estado`) VALUES
(1, 'EXCEL', 'CURSO ENFOCADO A ENSEÑAR A LOS EMPLEADOS LAS FUNCIONES DE EXCEL.', 3, 1),
(2, 'INDUCCION A LA EMPRESA', 'INDUCCION A LOS NUEVOS EMPLEADOS A LA EMPRESA, PARA CONOCER LAS INSTALACIONES Y PUESTOS DE TRABAJO', 2, 1),
(3, 'Java Script', 'Curso Intensivo', 2, 1),
(4, '.NET', 'Curso Intensivo', 2, 1);

INSERT INTO `capacitadorexterno` (`idCapacitadorExterno`, `nombreCompleto`, `dpi`, `genero`, `email`, `telefono`, `fechaInscripcion`, `estado`) VALUES
(1, 'Marco Polo Solis', 5161, 1, 'MarcoPolo@gmail.com', 15151232, '15/05/2020', 1);

INSERT INTO `puesto` (`idPuesto`, `nombrePuesto`, `descripcion`, `salario`, `estado`) VALUES
(1, 'Gerente General', 'Gerente General', 5000.00, 1),
(2, 'Gerente Administrativo', 'Gerente General', NULL, 1),
(3, 'Conserje', 'Conserje', NULL, 1),
(4, 'Secretaria', 'Secretaria', NULL, 1),
(5, 'Seguridad', 'Encargado de seguriridad en la empresa', 2900.00, 1);

INSERT INTO `licenciaconducir` (`idLicencia`, `tipoLicencia`, `descripcion`, `estado`) VALUES
(1, 'A', 'Todo tipo de vehiculos', 1),
(2, 'B', NULL, 1),
(3, 'C', 'Para todo vehiculo que pese menos de 1 tonelada sin remuneracion', 1),
(4, 'M', NULL, 1);

INSERT INTO `formacionacademica` (`idFormacionAcademica`, `nombreFormacionAcademica`, `descripcion`, `estado`) VALUES
(1, 'Primaria', 'Grado de 1ro a 6to.', 1),
(2, 'Secundaria', NULL, 1),
(3, 'Basicos', NULL, 1),
(4, 'Diversificado', NULL, 1),
(5, 'Universidad', 'Carrera completa con titulo', 1);

INSERT INTO `tipoentrevista` (`idTipoEntrevista`, `tipoEntrevista`, `descripcion`, `estado`) VALUES
(1, 'Competencia', NULL, 1),
(2, 'Práctica', 'Todo tipo de pruebas tecnicas', 1),
(3, 'Libre', NULL, 1),
(4, 'Estructurada', NULL, 1),
(5, 'En linea', 'Entrevista realizada de manera virtual', 1);

INSERT INTO `tipoevaluacion` (`IdTipoEvaluacion`, `TipoEvaluacion`, `Descripcion`, `Estado`) VALUES
(1, 'C#', NULL, 1),
(2, 'C++', NULL, 1);

INSERT INTO `tipoinduccion` (`IdTipoInduccion`, `TipoInduccion`, `Descripcion`, `Estado`) VALUES
(1, 'General', 'General', 1),
(2, 'Específica', 'específica', 1),
(3, 'Departamento TI', 'Departamento TI', 1);

INSERT INTO `tipofalta` (`idTipoFalta`, `tipoFalta`, `descripcion`, `valor`, `estado`) VALUES
(1, 'Llegar tarde', 'Por llegar tarde a la empresa', 0.00, 1);

INSERT INTO `tipohorario` (`idTipoHorario`, `tipoHorario`, `descripcion`, `estado`) VALUES
(1, 'Matutino', 'Matutino', 1),
(2, 'Vespertino', 'Vespertino', 1),
(3, 'Nocturno', 'Nocturno', 1),
(4, 'Combinado', 'Horario que consta de matutino y vespertino', 1);

INSERT INTO `tipocontrato` (`idTipoContrato`, `tipoContrato`, `descripcion`, `estado`) VALUES
(1, '023', NULL, 1),
(2, '025', NULL, 1);

INSERT INTO `tipomoneda` (`idTipoMoneda`, `tipoMoneda`, `descripcion`, `valor`, `estado`) VALUES
(1, 'Quetzal', NULL, 1.000, 1);

INSERT INTO `departamentoempresa` (`idDepartamentoEmpresa`, `nombreDepartamento`, `descripcion`, `estado`) VALUES
(1, 'Contabilidad', 'Contabilidad', 1),
(2, 'Tesorería', 'Tesorería', 1),
(3, 'Informática', 'Informática', 1),
(4, 'Planificación y Desarrollo', 'Planificación y Desarrollo', 1),
(5, 'HRM', 'Recursos Humanos', 1);

INSERT INTO `entrevista` (`idEntrevista`, `idTipoEntrevista`, `punteo`,`resultadoEntrevista`, `comentarios`) VALUES
(1, 4, 88, 'Primera Opción', 'Comentario'),
(2, 2, 53, 'Segunda Opción', 'Buen Desempeño'),
(3, 3, 100, 'Primera Opcion', 'Buen desempeño'),
(4, 3, 80, 'Primera Opcion', 'Comentario'),
(5, 2, 55, 'Segunda Opción', 'Buen Manejo'),
(6, 2, 56, 'Segunda Opción', 'Buen Desempeño'),
(7, 3, 53, 'Segunda Opción', 'Si muestra conocimientos del tema');

INSERT INTO `reclutamiento` (`idRecluta`, `nombre`, `apellido`, `DPI`, `profesionActual`, `fechaNacimiento`, `genero`, `estadoCivil`, `correo`, `telefono`, `numeroIgss`, `fechaReclutamiento`, `idLicencia`, `idPuesto`, `idHorario`, `idDepatamentoEmpresa`, `idFormacionAcademica`, `idEntrevista`, `estado`) VALUES
(1, 'Juan Jose', 'Lopez Garcia', '1236547', 'Maestro', '02/08/2020', 1, 1, 'jose@gmail.com', '65476547', '1234', '10/04/2021', 3, 2, 3, 3, 4, 6, 1),
(2, 'Luis Eduardo', 'Noriega Lopez', '1023456789987', 'Doctor', '06/06/1990', 1, 1, 'noriega@gmail.com', '65478951', '31241', '10/04/2021', 3, 2, 2, 3, 4, NULL, 1),
(3, 'Jordi David', 'Lopez Sierra', '123456789', '9876543210213', '06/04/1994', 1, 3, 'david@gmail.com', '65418523', '5003465', '10/04/2021', 2, 2, 1, 3, 4, 1, 6),
(4, 'Jose Gabriel', 'Menchu Mollinedo', '852369741025', 'Estudiante', '12/12/1996', 1, 1, 'mollinedo@gmail.com', '65748520', '840604', '10/04/2021', 2, 1, 3, 4, 4, 2, 6),
(5, 'Luis Manuel', 'Mejía Urrutia', '123123123', 'Ninguna', '8/02/2000', 2, 2, 'luis@gmail.com', '12312312', '12312312', '10/05/2021', 3, 3, 3, 4, 3, NULL, 0),
(6, 'Jose Pablo', 'Montenegro', '123123123', 'Ninguna', '8/02/1989', 0, 1, 'pablo@gmail.com', '12312312', '12312', '10/05/2021', 2, 4, 2, 3, 5, NULL, 0),
(7, 'Armando Gabriel', 'Rodríguez Chavez', '4257547', 'Ninguna', '8/02/2000', 0, 3, 'chavez@gmail.com', '525754', '24457457', '10/05/2021', 1, 3, 3, 4, 4, 3, 2),
(8, 'Carlos Augusto', 'Zapata Perez', '7634645643565', 'Ninguno', '2/02/2000', 0, 2, 'zapata@gmail.com', '12312334', '23453453', '10/05/2021', 3, 4, 2, 3, 3, 4, 1),
(9, 'Hector Augusto', 'Estrada Lopez', '6565465465465', 'Profesor', '1/02/2000', 1, 2, 'rodas@gmail.com', '65465446', '21321343', '13/05/2021', 3, 3, 3, 2, 5, 7, 6);

INSERT INTO `empleado` (`idEmpleado`, `idRecluta`, `cuentaBancaria`, `idTipoContrato`, `imagenContrato`, `fotografiaPerfil`, `fechaContratacion`, `estado`) VALUES
(1, 3, 54465654, 1, NULL, 'https://cdn.discordapp.com/attachments/800213229581107220/842917514798694400/56644.png', '10/04/2021', 1),
(2, 4, 645321132, 2, NULL, 'https://cdn.discordapp.com/attachments/811314051119710208/811406201950175302/perfil2.jpg', '10/04/2021', 0),
(3, 4, 46654654, 2, NULL, 'https://cdn.discordapp.com/attachments/804515217538285619/814144218075234414/images.png', '11/05/2021', 1),
(4, 9, 342132, 2, NULL, 'https://cdn.discordapp.com/attachments/804515217538285619/814144625106747462/images.png', '13/05/2021', 1);

INSERT INTO `evaluacion` (`idEvaluacion`, `idRecluta`, `idtipoEvaluacion`, `PunteoEvaluacion`, `ResultadoEvaluacion`, `Comentarios`) VALUES
(1, 7, 1, 80, 'Segunda Opcion', 'Buen desempeño'),
(2, 7, 2, 66, 'Segunda Opción', 'Buen Desempeño'),
(3, 7, 2, 80, 'Primera Opción', 'Buen Desempeño'),
(4, 9, 2, 88, 'Primera Opción', 'Buen desempeño en la evaluación');

INSERT INTO `induccion` (`idInduccion`, `idEmpleado`, `idtipoInduccion`, `FechaInduccion`, `Estado`) VALUES
(1, 3, 1, '12/05/2021', 1),
(2, 3, 2, '12/05/2021', 1),
(3, 1, 1, '12/05/2021', 1),
(4, 4, 2, '13/05/2021', 1);

INSERT INTO `tipopercepciondeduccion` (`idTipoPercepcionDeduccion`, `tipoPercepcionDeduccion`, `descripcion`, `formula`, `valor`, `signo`, `tipo`, `estado`) VALUES
(1, 'SALARIO BASE 2', 'SALARIO BASE REFERENCIADO AL PUESTO DEL EMPLEADO.', 'Sin Formula Especificada.', '0.0', '+', 1, 1),
(2, 'IGSS', 'IMPUESTO IGSS', ' ( SALARIO BASE * 0.043 ) ', '0.0', '-', 1, 1),
(3, 'DESCUENTO JUDICIAL', 'DESCUENTO JUDICIAL', 'Sin Formula Especificada.', '0.0', '-', 2, 1),
(4, 'BONIFICACION INCENTIVO', 'BONIFICACION INCENTIVO', 'Sin Formula Especificada.', '250', '+', 1, 1),
(5, 'AGUINALDO', 'AGUINALDO', 'Sin Formula Especificada.', '0.0', '+', 1, 1),
(6, 'BONO 14', 'BONO 14', 'Sin Formula Especificada.', '0.0', '+', 1, 1),
(7, 'HORAS EXTRAORDINARIAS', 'HORAS EXTRAORDINARIAS', 'Sin Formula Especificada.', '0.0', '+', 2, 1);

insert into dificultad values(1,'Fácil',1);
insert into dificultad values(2,'Mediano',1);
insert into dificultad values(3,'Difícil',1);
	
