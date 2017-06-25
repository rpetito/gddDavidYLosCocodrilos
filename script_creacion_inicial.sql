--#####--###########################################################################
--###########################################################################
-- SCRIPT DE MIGRACION Y CREACION DE OBJETOS NECESARIOS
-- GRUPO: DAVID_Y_LOS_COCODRILOS
--###########################################################################
--###########################################################################

USE [GD1C2017]
GO

--###########################################################################
--###########################################################################
---------------------VERIFICACION EXISTENCIA DE OBJETOS----------------------
--###########################################################################
--###########################################################################

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.ITEM_FACTURA') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.ITEM_FACTURA

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.ITEM_RENDICION') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.ITEM_RENDICION

--TABLAS
IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.VIAJE') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.VIAJE

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.FACTURA') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.FACTURA

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.RENDICION') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.RENDICION

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.AUTOMOVIL') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.AUTOMOVIL

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.CLIENTE') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.CLIENTE

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.CHOFER') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.CHOFER

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.ADMINISTRADOR') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.ADMINISTRADOR

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.ROL_USUARIO') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.ROL_USUARIO

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.USUARIO') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.USUARIO

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD_ROL') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD_ROL

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.ROL') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.ROL

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.TURNO') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.TURNO

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MODELO') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.MODELO

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MARCA') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.MARCA

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MODELO') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.MODELO

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MARCA') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.MARCA

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.PERIODO') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.PERIODO


--PROCEDURES
IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_USUARIO_CLIENTE') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_USUARIO_CLIENTE

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_USUARIO_CHOFER') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_USUARIO_CHOFER

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_AUTOMOVIL') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_AUTOMOVIL

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_TURNO') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_TURNO

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_VIAJE') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_VIAJE

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.UPDATE_RENDICION') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.UPDATE_RENDICION

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_RENDICION') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_RENDICION

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_ITEM_RENDICION') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_ITEM_RENDICION

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.UPDATE_FACTURA') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.UPDATE_FACTURA

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_FACTURA') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_FACTURA

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_ITEM_FACTURA') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_ITEM_FACTURA

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_MODELO') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_MODELO

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_MARCA') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_MARCA

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.CARGA_DATOS_INICIALES') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.CARGA_DATOS_INICIALES

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_ROLxUSUARIO_CLIENTE') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_ROLxUSUARIO_CLIENTE

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_ROLxUSUARIO_CHOFER') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_ROLxUSUARIO_CHOFER

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_CLIENTE') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_CLIENTE

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_CHOFER') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_CHOFER

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_PERIODO') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_PERIODO

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.INGRESAR_USUARIO') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.INGRESAR_USUARIO

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.AGREGAR_FUNCIONALIDAD_A_ROL') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.AGREGAR_FUNCIONALIDAD_A_ROL

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.REMOVER_FUNCIONALIDAD_A_ROL') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.REMOVER_FUNCIONALIDAD_A_ROL

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.INHABILITAR_ROL') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.INHABILITAR_ROL

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.HABILITAR_ROL') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.HABILITAR_ROL

IF OBJECT_ID(' DAVID_Y_LOS_COCODRILOS.MODIFICAR_NOMBRE_ROL') IS NOT NULL
DROP PROCEDURE  DAVID_Y_LOS_COCODRILOS.MODIFICAR_NOMBRE_ROL

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.OBTENER_ROLES') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.OBTENER_ROLES


--FUNCTIONS
IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.fGetTurno') IS NOT NULL
DROP FUNCTION DAVID_Y_LOS_COCODRILOS.fGetTurno

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.fGenRandomViajeID') IS NOT NULL
DROP FUNCTION DAVID_Y_LOS_COCODRILOS.fGenRandomViajeID



--TRIGGERS
IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.tVerificarTurno') IS NOT NULL
DROP TRIGGER DAVID_Y_LOS_COCODRILOS.tVerificarTurno

GO


--SCHEMA
IF EXISTS (	SELECT  *
            FROM sys.schemas
            WHERE name = 'DAVID_Y_LOS_COCODRILOS' ) 
EXEC('DROP SCHEMA [DAVID_Y_LOS_COCODRILOS]');


IF NOT EXISTS ( SELECT  *
                FROM    sys.schemas
                WHERE   name = 'DAVID_Y_LOS_COCODRILOS' ) 
EXEC('CREATE SCHEMA [DAVID_Y_LOS_COCODRILOS] AUTHORIZATION [gd]');
 

GO


--###########################################################################
--###########################################################################
----------------------------CREACION DE FUNCIONES----------------------------
--###########################################################################
--###########################################################################


--DADO UNA FECHA DE INICIO Y FIN DE UN TURNO, DEVUELVE SU EQUIVALENTE EN CHAR
CREATE FUNCTION DAVID_Y_LOS_COCODRILOS.fGetTurno(@horaInicioTurno numeric(18,0), @horaFinTurno numeric(18,0))
RETURNS char(1)
AS
BEGIN

	DECLARE @turno char(1);

	SET @turno = CASE
					WHEN (@horaInicioTurno = 0 AND @horaFinTurno = 8) THEN '1'
					WHEN (@horaInicioTurno = 8 AND @horaFinTurno = 16) THEN '2'
					WHEN (@horaInicioTurno = 16 AND @horaFinTurno = 24) THEN '3'
				 END

	RETURN @turno

END
GO


--###########################################################################
--###########################################################################
----------------------------CREACION DE TABLAS--------------------------------
--###########################################################################
--###########################################################################

--------------------------------------
-------------TABLA PERIODO------------
--------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.PERIODO (
	PERIODO_ANIO  	int,
	PERIODO_MES 	int,
	PERIODO_INICIO  datetime,
	PERIODO_FIN datetime,
	primary key (PERIODO_ANIO, PERIODO_MES)
);

--------------------------------------
-------------TABLA ROL----------------
--------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.ROL (
	ROL_ID  		char(1),
	ROL_DETALLE 	varchar(255),
	ROL_HABILITADO  integer DEFAULT 1,
	primary key (ROL_ID)
);

--------------------------------------
----------TABLA FUNCIONALIDAD---------
--------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD (
	FUNCIONALIDAD_ID 			int identity(1,1),
	FUNCIONALIDAD_DETALLE		varchar(255),
	FUNCIONALIDAD_HABILITADO	integer DEFAULT 1,
	primary key (FUNCIONALIDAD_ID)
);


------------------------------------------------------
---------------TABLA FUNCIONALIDAD_ROL----------------
------------------------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD_ROL (
	ROLFUN_FUNCIONALIDAD		int,
	ROLFUN_ROL					char(1),
	foreign key (ROLFUN_FUNCIONALIDAD) 	references DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD,
	foreign key (ROLFUN_ROL) 			references DAVID_Y_LOS_COCODRILOS.ROL,
	primary key (ROLFUN_FUNCIONALIDAD, ROLFUN_ROL)
);


--------------------------------------
-------------TABLA USUARIO------------
--------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.USUARIO (
	USUARIO_NOMBRE		varchar(255),
	USUARIO_APELLIDO	varchar(255),
	USUARIO_DNI			numeric(18,0),
	USUARIO_MAIL		varchar(50),
	USUARIO_TEL			char(18),
	USUARIO_DIR			varchar(255),
	USUARIO_LOCALIDAD	varchar(50),
	USUARIO_CODPOS		varchar(10),
	USUARIO_FNAC		datetime,
	USUARIO_HABILITADO	integer DEFAULT 1
	primary key (USUARIO_DNI)
);


--------------------------------------
-------------TABLA ROL_USUARIO--------
--------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.ROL_USUARIO (
	USROL_USUARIO			numeric(18,0),
	USROL_ROL				char(1),
	USROL_USERNAME	char(35),
	USROL_PASSWORD    char(10),
	foreign key (USROL_USUARIO) 		references DAVID_Y_LOS_COCODRILOS.USUARIO,
	foreign key (USROL_ROL) 			references DAVID_Y_LOS_COCODRILOS.ROL,
	primary key (USROL_USUARIO, USROL_ROL)
);




----------------------------------------
-------------TABLA MODELO---------------
----------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.MODELO (
	MODELO_ID Int IDENTITY(1,1),
	MODELO_DETALLE varchar(255),
	primary key (MODELO_ID)
);


----------------------------------------
-------------TABLA MARCA----------------
----------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.MARCA (
	MARCA_ID Int IDENTITY(1,1),
	MARCA_DETALLE varchar(255),
	primary key (MARCA_ID)
)


-----------------------------------------
-------------TABLA AUTOMOVIL-------------
-----------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.AUTOMOVIL (
	AUTOMOVIL_PATENTE varchar(10),
	AUTOMOVIL_MARCA Int,
	AUTOMOVIL_MODELO Int,
	AUTOMOVIL_TURNO char(1),
	AUTOMOVIL_CHOFER numeric(18,0),
	AUTOMOVIL_HABILITADO bit,
	primary key (AUTOMOVIL_PATENTE, AUTOMOVIL_CHOFER, AUTOMOVIL_TURNO),
	foreign key (AUTOMOVIL_CHOFER) references DAVID_Y_LOS_COCODRILOS.USUARIO,
	foreign key (AUTOMOVIL_MARCA) references DAVID_Y_LOS_COCODRILOS.MARCA,
	foreign key (AUTOMOVIL_MODELO) references DAVID_Y_LOS_COCODRILOS.MODELO
);


----------------------------------------
-------------TABLA TURNO----------------
----------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.TURNO (
	TURNO_ID char(1),
	TURNO_HORA_INICIO numeric(18,0),
	TURNO_HORA_FIN numeric(18,0),
	TURNO_DESCRIPCION varchar(255),
	TURNO_VALOR_KILOMETRO numeric(18,2),
	TURNO_PRECIO_BASE numeric(18,2),
	TURNO_HABILITADO bit,
	primary key (TURNO_ID)
);


----------------------------------------
-------------TABLA VIAJE----------------
----------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.VIAJE (
	VIAJE_ID Int IDENTITY(1,1),
	VIAJE_CHOFER numeric(18,0),
	VIAJE_CLIENTE numeric(18,0),
	VIAJE_AUTOMOVIL_PATENTE varchar(10),
	VIAJE_TURNO char(1),
	VIAJE_CANTIDAD_KM numeric(18,0),
	VIAJE_FECHA_INICIO datetime,
	VIAJE_FECHA_FIN datetime,
	primary key (VIAJE_CHOFER, VIAJE_FECHA_INICIO, VIAJE_CLIENTE),
	foreign key (VIAJE_CHOFER) references DAVID_Y_LOS_COCODRILOS.USUARIO,
	foreign key (VIAJE_CLIENTE) references DAVID_Y_LOS_COCODRILOS.USUARIO,
	foreign key (VIAJE_AUTOMOVIL_PATENTE, VIAJE_CHOFER ,VIAJE_TURNO) references DAVID_Y_LOS_COCODRILOS.AUTOMOVIL,
	foreign key (VIAJE_TURNO) references DAVID_Y_LOS_COCODRILOS.TURNO
);



----------------------------------------
-------------TABLA RENDICION------------
----------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.RENDICION (
	RENDICION_ID int IDENTITY(1,1),
	RENDICION_FECHA datetime,
	RENDICION_CHOFER numeric(18,0),
	RENDICION_TURNO char(1),
	RENDICION_IMPORTE numeric(18,2),
	primary key (RENDICION_CHOFER, RENDICION_FECHA, RENDICION_TURNO),
	foreign key (RENDICION_TURNO) references DAVID_Y_LOS_COCODRILOS.TURNO,
	foreign key (RENDICION_CHOFER) references  DAVID_Y_LOS_COCODRILOS.USUARIO
);


----------------------------------------
----------TABLA ITEM RENDICION----------
----------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.ITEM_RENDICION (
	ITEMR_IMPORTE numeric(18,2),
	ITEMR_CHOFER numeric(18,0),
	ITEMR_CLIENTE numeric(18,0),
	ITEMR_FECHA datetime,
	ITEMR_TURNO char(1),
	ITEMR_FECHA_VIAJE datetime,
	primary key(ITEMR_CHOFER, ITEMR_CLIENTE, ITEMR_FECHA, ITEMR_TURNO, ITEMR_FECHA_VIAJE),
	foreign key (ITEMR_CHOFER, ITEMR_FECHA, ITEMR_TURNO) references DAVID_Y_LOS_COCODRILOS.RENDICION,
	foreign key (ITEMR_CHOFER, ITEMR_FECHA_VIAJE, ITEMR_CLIENTE) references DAVID_Y_LOS_COCODRILOS.VIAJE,
);


---------------------------------------
-------------TABLA FACTURA-------------
---------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.FACTURA (
	FACTURA_CLIENTE numeric(18,0),
	FACTURA_ID int IDENTITY(1,1),
	FACTURA_ANIO int,
	FACTURA_PERIODO int,
	FACTURA_IMPORTE numeric(18,2)
	primary key (FACTURA_CLIENTE, FACTURA_ANIO, FACTURA_PERIODO),
	foreign key (FACTURA_CLIENTE) references DAVID_Y_LOS_COCODRILOS.USUARIO
);


-----------------------------------------------------
----------------TABLA ITEM FACTURA-------------------
-----------------------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.ITEM_FACTURA (
	ITEMF_CHOFER numeric(18,0),
	ITEMF_FECHA_VIAJE datetime,
	ITEMF_CLIENTE numeric(18,0),
	ITEMF_ANIO int,
	ITEMF_PERIODO int,
	ITEMF_IMPORTE numeric(18,2)
	primary key (ITEMF_CHOFER, ITEMF_FECHA_VIAJE, ITEMF_CLIENTE, ITEMF_ANIO, ITEMF_PERIODO),
	foreign key (ITEMF_CLIENTE, ITEMF_ANIO, ITEMF_PERIODO) references DAVID_Y_LOS_COCODRILOS.FACTURA,
	foreign key (ITEMF_CHOFER, ITEMF_FECHA_VIAJE, ITEMF_CLIENTE) references DAVID_Y_LOS_COCODRILOS.VIAJE
);



GO




--###########################################################################
--###########################################################################
----------------------------MIGRACIONES DE DATOS-----------------------------
--###########################################################################
--###########################################################################


-----------------------------------------------------
--------------CARGA DATOS INICIALES------------------
-----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.CARGA_DATOS_INICIALES
AS
BEGIN


	------------------------------------
	------------CARGA ROLES-------------
	------------------------------------
	INSERT	INTO DAVID_Y_LOS_COCODRILOS.ROL(ROL_ID, ROL_DETALLE) 
			VALUES ('1', 'admin');
	INSERT	INTO DAVID_Y_LOS_COCODRILOS.ROL(ROL_ID, ROL_DETALLE) 
			VALUES ('2', 'cliente');
	INSERT	INTO DAVID_Y_LOS_COCODRILOS.ROL(ROL_ID, ROL_DETALLE) 
			VALUES ('3', 'chofer');
			

	------------------------------------
	--------CARGA USUARIO ADMIN --------
	------------------------------------
	INSERT	INTO DAVID_Y_LOS_COCODRILOS.USUARIO (USUARIO_DNI)
			VALUES(0);
	INSERT INTO DAVID_Y_LOS_COCODRILOS.ROL_USUARIO (USROL_USUARIO, USROL_ROL, USROL_USERNAME, USROL_PASSWORD)
			VALUES(0, '1','admin', 'q23w');


	------------------------------------
	--------CARGA FUNCIONALIDADES-------
	------------------------------------
	INSERT INTO DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD(
	FUNCIONALIDAD_DETALLE,
	FUNCIONALIDAD_HABILITADO)
	VALUES (
		'FUNCIONALIDAD 1',
		1
	);

	INSERT INTO DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD(
	FUNCIONALIDAD_DETALLE,
	FUNCIONALIDAD_HABILITADO)
	VALUES (
		'FUNCIONALIDAD 2',
		1
	);

	INSERT INTO DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD(
	FUNCIONALIDAD_DETALLE,
	FUNCIONALIDAD_HABILITADO)
	VALUES (
		'FUNCIONALIDAD 3',
		1
	);

	INSERT INTO DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD(
	FUNCIONALIDAD_DETALLE,
	FUNCIONALIDAD_HABILITADO)
	VALUES (
		'FUNCIONALIDAD 4',
		1
	);

	INSERT INTO DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD(
	FUNCIONALIDAD_DETALLE,
	FUNCIONALIDAD_HABILITADO)
	VALUES (
		'FUNCIONALIDAD 5',
		1
	);


	------------------------------------------
	--------CARGA FUNCIONALIDADES ADMIN-------
	------------------------------------------
	INSERT INTO DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD_ROL(
	ROLFUN_FUNCIONALIDAD,
	ROLFUN_ROL
	) VALUES (1, '1'), 
			 (2, '1'), 
			 (3, '1'), 
			 (4, '1'), 
			 (5, '1');


	------------------------------------------
	------CARGA FUNCIONALIDADES CLIENTE-------
	------------------------------------------
	INSERT INTO DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD_ROL(
	ROLFUN_FUNCIONALIDAD,
	ROLFUN_ROL
	) VALUES (1, '2'), 
			 (2, '2'), 
			 (3, '2');


	------------------------------------------
	-------CARGA FUNCIONALIDADES CHOFER-------
	------------------------------------------
	INSERT INTO DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD_ROL(
	ROLFUN_FUNCIONALIDAD,
	ROLFUN_ROL
	) VALUES (1, '3'), 
			 (2, '3');



END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.CARGA_DATOS_INICIALES')
GO


-----------------------------------------------------
----------------MIGRACION USUARIO--------------------
-----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_USUARIO_CLIENTE
AS
BEGIN

	INSERT INTO DAVID_Y_LOS_COCODRILOS.USUARIO (
		USUARIO_DNI,
		USUARIO_TEL,
		USUARIO_NOMBRE,
		USUARIO_APELLIDO,
		USUARIO_MAIL,
		USUARIO_DIR,
		USUARIO_LOCALIDAD,
		USUARIO_CODPOS,
		USUARIO_FNAC,
		USUARIO_HABILITADO
	)	SELECT	distinct(m.Cliente_Dni),
				m.Cliente_Telefono,
				m.Cliente_Nombre,
				m.Cliente_Apellido,
				m.Cliente_Mail,
				m.Cliente_Direccion,
				'localidad',
				'codpos',
				m.Cliente_Fecha_Nac,
				1
		FROM gd_esquema.Maestra m
		ORDER BY m.Cliente_Nombre
		

END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_USUARIO_CLIENTE')
GO



CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_USUARIO_CHOFER
AS
BEGIN

	INSERT INTO DAVID_Y_LOS_COCODRILOS.USUARIO (
		USUARIO_DNI,
		USUARIO_TEL,
		USUARIO_NOMBRE,
		USUARIO_APELLIDO,
		USUARIO_MAIL,
		USUARIO_DIR,
		USUARIO_LOCALIDAD,
		USUARIO_CODPOS,
		USUARIO_FNAC,
		USUARIO_HABILITADO
	)	SELECT	distinct(m.Chofer_Dni),
				m.Chofer_Telefono,
				m.Chofer_Nombre,
				m.Chofer_Apellido,
				m.Chofer_Mail,
				m.Chofer_Direccion,
				'localidad',
				'codpos',
				m.Chofer_Fecha_Nac,
				1
		FROM gd_esquema.Maestra m

END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_USUARIO_CHOFER')
GO


----------------------------------------------------
----------MIGRACION ROL_X_USUARIO_CLIENTE-----------
----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_ROLxUSUARIO_CLIENTE
AS
BEGIN

	INSERT INTO DAVID_Y_LOS_COCODRILOS.ROL_USUARIO (
		USROL_USUARIO,
		USROL_ROL,
		USROL_USERNAME,
		USROL_PASSWORD
	)	SELECT	distinct(m.Cliente_Dni),
				'2',
				m.Cliente_Dni,
				m.Cliente_Dni
		FROM gd_esquema.Maestra m

END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_ROLxUSUARIO_CLIENTE')
GO


----------------------------------------------------
-----------MIGRACION ROL_X_USUARIO_CHOFER------------
----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_ROLxUSUARIO_CHOFER
AS
BEGIN

	INSERT INTO DAVID_Y_LOS_COCODRILOS.ROL_USUARIO (
		USROL_USUARIO,
		USROL_ROL,
		USROL_USERNAME,
		USROL_PASSWORD
	)	SELECT	distinct(m.Chofer_Dni),
				'3',
				m.Chofer_Dni,
				m.Chofer_Dni
		FROM gd_esquema.Maestra m

END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_ROLxUSUARIO_CHOFER')
GO


-----------------------------------------------------
----------------MIGRACION MODELO---------------------
-----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_MODELO
AS 
BEGIN

	INSERT INTO DAVID_Y_LOS_COCODRILOS.MODELO (
		MODELO_DETALLE
	)	SELECT distinct(m.Auto_Modelo)
		FROM gd_esquema.Maestra m

END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_MODELO')
GO


-----------------------------------------------------
----------------MIGRACION MARCA----------------------
-----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_MARCA
AS
BEGIN

	INSERT INTO DAVID_Y_LOS_COCODRILOS.MARCA (
		MARCA_DETALLE
	)	SELECT distinct(m.Auto_Marca)
		FROM gd_esquema.Maestra m

END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_MARCA')
GO


-----------------------------------------------------
----------------MIGRACION AUTOMOVIL------------------
-----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_AUTOMOVIL 
AS
BEGIN

	INSERT INTO DAVID_Y_LOS_COCODRILOS.AUTOMOVIL (
		AUTOMOVIL_PATENTE,
		AUTOMOVIL_MARCA,
		AUTOMOVIL_MODELO, 
		AUTOMOVIL_TURNO,
		AUTOMOVIL_CHOFER,
		AUTOMOVIL_HABILITADO
	)	SELECT	distinct(m.Auto_Patente), 
				(	SELECT marca.MARCA_ID
					FROM DAVID_Y_LOS_COCODRILOS.MARCA marca
					WHERE m.Auto_Marca = marca.MARCA_DETALLE 
				), 
				(	SELECT modelo.MODELO_ID
					FROM DAVID_Y_LOS_COCODRILOS.MODELO modelo
					WHERE m.Auto_Modelo = modelo.MODELO_DETALLE 
				),
				DAVID_Y_LOS_COCODRILOS.fGetTurno(m.Turno_Hora_Inicio, m.Turno_Hora_Fin),
				m.Chofer_Dni, 
				1
		FROM gd_esquema.Maestra m

END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_AUTOMOVIL')
GO


-----------------------------------------------------
-----------------MIGRACION TURNOS--------------------
-----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_TURNO 
AS 
BEGIN

	INSERT INTO DAVID_Y_LOS_COCODRILOS.TURNO (
		TURNO_HORA_INICIO,
		TURNO_HORA_FIN,
		TURNO_DESCRIPCION,
		TURNO_VALOR_KILOMETRO,
		TURNO_PRECIO_BASE,
		TURNO_HABILITADO,
		TURNO_ID
	)	SELECT	m.Turno_Hora_Inicio,
				m.Turno_Hora_Fin,
				m.Turno_Descripcion,
				m.Turno_Valor_Kilometro,
				m.Turno_Precio_Base,
				1, 
				DAVID_Y_LOS_COCODRILOS.fGetTurno(m.Turno_Hora_Inicio, m.Turno_Hora_Fin) 
		FROM gd_esquema.Maestra m
		GROUP BY m.Turno_Hora_Inicio, m.Turno_Hora_Fin, m.Turno_Descripcion, m.Turno_Valor_Kilometro, m.Turno_Precio_Base
END		
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_TURNO')
GO


-----------------------------------------------------
------------------MIGRACION VIAJE--------------------
-----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_VIAJE
AS
BEGIN

	INSERT INTO DAVID_Y_LOS_COCODRILOS.VIAJE (
		VIAJE_AUTOMOVIL_PATENTE,
		VIAJE_CHOFER,
		VIAJE_TURNO,
		VIAJE_CANTIDAD_KM,
		VIAJE_FECHA_INICIO,
		VIAJE_FECHA_FIN,
		VIAJE_CLIENTE
	)	SELECT	m.Auto_Patente,
				m.Chofer_Dni,
				(	SELECT t.TURNO_ID
					FROM DAVID_Y_LOS_COCODRILOS.TURNO t
					WHERE t.TURNO_HORA_INICIO = m.Turno_Hora_Inicio 
							and t.TURNO_HORA_FIN = m.Turno_Hora_Fin
				),
				max(m.Viaje_Cant_Kilometros),
				m.Viaje_Fecha,
				m.Viaje_Fecha, 
				m.Cliente_Dni
		FROM gd_esquema.Maestra m
		group by m.Chofer_Dni, m.Auto_Patente, m.Viaje_Fecha, m.Cliente_Dni, m.Turno_Hora_Inicio, m.Turno_Hora_Fin
END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_VIAJE')
GO


-----------------------------------------------------
----------------MIGRACION PERIODO---------------------
-----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_PERIODO
AS 
BEGIN

	INSERT INTO DAVID_Y_LOS_COCODRILOS.PERIODO (
		PERIODO_ANIO,
		PERIODO_MES,
		PERIODO_INICIO,
		PERIODO_FIN
	)	(SELECT YEAR(Factura_Fecha_Inicio), MONTH(Factura_Fecha_Inicio), Factura_Fecha_Inicio, Factura_Fecha_Fin
		from gd_esquema.Maestra 
		where Factura_Fecha_Inicio is not null and Factura_Fecha_Fin is not null
		group by Factura_Fecha_Inicio, Factura_Fecha_Fin)
END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_PERIODO')
GO




-----------------------------------------------------
---------------------RENDICION-----------------------
-----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_RENDICION 
AS
BEGIN
	INSERT INTO DAVID_Y_LOS_COCODRILOS.RENDICION (
		RENDICION_FECHA,
		RENDICION_CHOFER,
		RENDICION_TURNO
	)	SELECT	m.Rendicion_Fecha,
				m.Chofer_Dni,
				DAVID_Y_LOS_COCODRILOS.fGetTurno(m.Turno_Hora_Inicio, m.Turno_Hora_Fin)
		FROM gd_esquema.Maestra m
		WHERE Rendicion_Nro > 0 
		group by m.Rendicion_Fecha,m.Chofer_Dni,m.Turno_Hora_Inicio, m.Turno_Hora_Fin
END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_RENDICION')
GO



-----------------------------------------------------
----------------------FACTURA------------------------
-----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_FACTURA 
AS
BEGIN

	INSERT INTO DAVID_Y_LOS_COCODRILOS.FACTURA (
		FACTURA_CLIENTE,
		FACTURA_ANIO,
		FACTURA_PERIODO
	)	(SELECT	m.Cliente_Dni,
				YEAR(m.Factura_Fecha),
				MONTH(m.Factura_Fecha)

		FROM gd_esquema.Maestra m
		where m.Factura_Nro >0
		group by m.Cliente_Dni, m.Factura_Fecha
		)

END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_FACTURA')
GO



-----------------------------------------------------
-----------------ITEM RENDICION----------------------
-----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_ITEM_RENDICION 
AS
BEGIN
	INSERT INTO DAVID_Y_LOS_COCODRILOS.ITEM_RENDICION (ITEMR_IMPORTE, ITEMR_CHOFER, ITEMR_CLIENTE, ITEMR_FECHA, ITEMR_TURNO, ITEMR_FECHA_VIAJE)
		(	SELECT	max(m.Rendicion_Importe), 
					m.Chofer_Dni,
					m.Cliente_Dni, 
					Rendicion_Fecha, 
					DAVID_Y_LOS_COCODRILOS.fGetTurno(m.Turno_Hora_Inicio, m.Turno_Hora_Fin), 
					Viaje_Fecha
			FROM gd_esquema.Maestra m
			WHERE Rendicion_Nro > 0
			group by m.Chofer_Dni, m.Cliente_Dni, Rendicion_Fecha, m.Turno_Hora_Inicio, m.Turno_Hora_Fin, Viaje_Fecha
		)
END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_ITEM_RENDICION')
GO



-----------------------------------------------------
-----------------ITEM FACTURA------------------------
-----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_ITEM_FACTURA 
AS
BEGIN
	INSERT INTO DAVID_Y_LOS_COCODRILOS.ITEM_FACTURA (ITEMF_CHOFER, ITEMF_FECHA_VIAJE, ITEMF_CLIENTE, ITEMF_ANIO, ITEMF_PERIODO, ITEMF_IMPORTE)
	(
		SELECT	m.Chofer_Dni, 
				m.Viaje_Fecha, 
				m.Cliente_Dni,
				 YEAR(m.Factura_Fecha),
				  MONTH(m.Factura_Fecha), 
				  max(m.Turno_Precio_Base+(m.Turno_Valor_Kilometro*m.Viaje_Cant_Kilometros))
		FROM gd_esquema.Maestra m
		WHERE m.Factura_Nro>0
		group by m.Chofer_Dni, m.Viaje_Fecha, m.Cliente_Dni ,m.Factura_Fecha
	)

END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_ITEM_FACTURA ')
GO

CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.UPDATE_RENDICION 
AS
BEGIN
	UPDATE DAVID_Y_LOS_COCODRILOS.RENDICION SET RENDICION_IMPORTE = (SELECT COUNT(ITEMR_IMPORTE) FROM DAVID_Y_LOS_COCODRILOS.ITEM_RENDICION WHERE ITEMR_CHOFER = RENDICION_CHOFER AND ITEMR_FECHA = RENDICION_FECHA AND ITEMR_TURNO = RENDICION_TURNO)
END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.UPDATE_RENDICION')
GO


CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.UPDATE_FACTURA
AS
BEGIN
	UPDATE DAVID_Y_LOS_COCODRILOS.FACTURA SET FACTURA_IMPORTE = (SELECT COUNT(ITEMF_IMPORTE) FROM DAVID_Y_LOS_COCODRILOS.ITEM_FACTURA WHERE ITEMF_CLIENTE = FACTURA_CLIENTE AND ITEMF_ANIO = FACTURA_ANIO AND ITEMF_PERIODO = FACTURA_PERIODO)
END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.UPDATE_FACTURA')
GO


--###########################################################################
--###########################################################################
------------------------------FUNCIONALIDADES--------------------------------
--###########################################################################
--###########################################################################


---------------------------------------------------
-------------------LOGIN USUARIO-------------------
---------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.INGRESAR_USUARIO (
	@username char(35),
	@password char(10),
	@rol varchar(255)
) 
AS
BEGIN

	DECLARE @status int = 1;

	IF EXISTS (	SELECT r.USROL_ROL
		FROM DAVID_Y_LOS_COCODRILOS.ROL_USUARIO r
		WHERE r.USROL_ROL = @rol
				and r.USROL_USERNAME = @username 
				and r.USROL_PASSWORD = @password)

		SET @status = 0;

	SELECT @status

END
GO


--###########################################################################
--###########################################################################
------------------------------INTERFAZ DE ABM--------------------------------
--###########################################################################
--###########################################################################


--AGERGAR FUNCIONALIDAD A ROL
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.AGREGAR_FUNCIONALIDAD_A_ROL(@rol char(1), @funcionalidad varchar(255))
AS
BEGIN

	INSERT INTO DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD_ROL(
		ROLFUN_ROL, 
		ROLFUN_FUNCIONALIDAD
	) 
	VALUES (
		@rol, 
		@funcionalidad
	)	

END
GO


--REMOVER FUNCIONALIDAD A ROL
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.REMOVER_FUNCIONALIDAD_A_ROL(@rol char(1), @funcionalidad varchar(255))
AS
BEGIN

	DELETE FROM DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD_ROL 
	WHERE ROLFUN_ROL = (SELECT r.ROL_ID
					FROM DAVID_Y_LOS_COCODRILOS.ROL r
					WHERE r.ROL_DETALLE = @funcionalidad)

END
GO 


--BAJA DE ROL
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.INHABILITAR_ROL(@detalleRol varchar(255))
AS
BEGIN

	UPDATE DAVID_Y_LOS_COCODRILOS.ROL
	SET ROL_HABILITADO = 0
	WHERE ROL_DETALLE = @detalleRol
	

END
GO 
--hacer trigger a rol on update y cuando se cambia el habilitado cambiarlo en los usuarios que lo tengan


--ALTA ROL
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.HABILITAR_ROL(@detalleRol varchar(255))
AS
BEGIN

	UPDATE DAVID_Y_LOS_COCODRILOS.ROL
	SET ROL_HABILITADO = 1
	WHERE ROL_DETALLE = @detalleRol
	

END
GO 


--MODIFICACION NOMBRE DE ROL
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MODIFICAR_NOMBRE_ROL(@detalleRol varchar(255))
AS
BEGIN

	UPDATE DAVID_Y_LOS_COCODRILOS.ROL
	SET ROL_DETALLE = @detalleRol
	WHERE ROL_DETALLE = @detalleRol
	

END
GO 



--OBTENER TODOS LOS ROLES DEL SISTEMA
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.OBTENER_ROLES 
AS
BEGIN

	SELECT r.ROL_DETALLE
	FROM DAVID_Y_LOS_COCODRILOS.ROL r
	WHERE r.ROL_HABILITADO = 1  --SOLO muestra los habilitados, esta bien?

END
GO







