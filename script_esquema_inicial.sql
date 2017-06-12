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


--TABLAS
IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.VIAJE') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.VIAJE

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

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.ITEM_RENDICION') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.ITEM_RENDICION

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.RENDICION') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.RENDICION

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.TURNO') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.TURNO

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.FACTURA') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.FACTURA

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MODELO') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.MODELO

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MARCA') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.MARCA

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.ITEM_FACTURA') IS NOT NULL
DROP TABLE DAVID_Y_LOS_COCODRILOS.ITEM_FACTURA

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

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_RENDICION') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_RENDICION

IF OBJECT_ID('DAVID_Y_LOS_COCODRILOS.MIGRACION_ITEM_RENDICION') IS NOT NULL
DROP PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_ITEM_RENDICION

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
	FUNCIONALIDAD_ID 			char(25),
	FUNCIONALIDAD_DETALLE		varchar(255),
	FUNCIONALIDAD_HABILITADO	integer DEFAULT 1,
	primary key (FUNCIONALIDAD_ID)
);


------------------------------------------------------
---------------TABLA FUNCIONALIDAD_ROL----------------
------------------------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.FUNCIONALIDAD_ROL (
	ROLFUN_FUNCIONALIDAD		char(25),
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
	USUARIO_DNI			char(18),
	USUARIO_MAIL		varchar(50),
	USUARIO_TEL			char(18),
	USUARIO_DIR			varchar(255),
	USUARIO_LOCALIDAD	varchar(50),
	USUARIO_CODPOS		varchar(10),
	USUARIO_FNAC		datetime,
	USUARIO_HABILITADO	integer DEFAULT 1,
	USUARIO_USERNAME	char(35),
	USUARIO_PASSWORD    char(10)
	primary key (USUARIO_DNI)
);


--------------------------------------
-------------TABLA ROL_USUARIO--------
--------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.ROL_USUARIO (
	USROL_USUARIO			char(18),
	USROL_ROL				char(1),
	foreign key (USROL_USUARIO) 		references DAVID_Y_LOS_COCODRILOS.USUARIO,
	foreign key (USROL_ROL) 			references DAVID_Y_LOS_COCODRILOS.ROL,
	primary key (USROL_USUARIO, USROL_ROL)
);


--------------------------------------
-------------TABLA ADMINISTRADOR------
--------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.ADMINISTRADOR (
	ADMIN_USUARIO			char(18),
	foreign key	(ADMIN_USUARIO) references DAVID_Y_LOS_COCODRILOS.USUARIO,
	primary key (ADMIN_USUARIO)
);


--------------------------------------
-------------TABLA CLIENTE------------
--------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.CLIENTE (
	CLIENTE_USUARIO			char(18),
	foreign key	(CLIENTE_USUARIO) references DAVID_Y_LOS_COCODRILOS.USUARIO,
	primary key (CLIENTE_USUARIO)
);


--------------------------------------
-------------TABLA CHOFER-------------
--------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.CHOFER (
	USUARIO_ID char(18),
	primary key (USUARIO_ID),
	foreign key (USUARIO_ID) references DAVID_Y_LOS_COCODRILOS.USUARIO
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
	AUTOMOVIL_CHOFER char(18),
	AUTOMOVIL_HABILITADO bit,
	primary key (AUTOMOVIL_PATENTE, AUTOMOVIL_CHOFER, AUTOMOVIL_TURNO),
	foreign key (AUTOMOVIL_CHOFER) references DAVID_Y_LOS_COCODRILOS.CHOFER,
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
	VIAJE_CHOFER_ID char(18),
	VIAJE_CLIENTE_ID char(8),
	VIAJE_AUTOMOVIL_PATENTE varchar(10),
	VIAJE_TURNO_ID char(1),
	VIAJE_CANTIDAD_KM numeric(18,0),
	VIAJE_FECHA_INICIO datetime,
	VIAJE_FECHA_FIN datetime,
	primary key (VIAJE_ID),
	foreign key (VIAJE_CHOFER_ID) references DAVID_Y_LOS_COCODRILOS.CHOFER,
--	foreign key (VIAJE_CLIENTE_ID) references DAVID_Y_LOS_COCODRILOS.CLIENTE,  (todavia no esta la tabla CLIENTE en el script)
	foreign key (VIAJE_AUTOMOVIL_PATENTE, VIAJE_CHOFER_ID ,VIAJE_TURNO_ID) references DAVID_Y_LOS_COCODRILOS.AUTOMOVIL,
	foreign key (VIAJE_TURNO_ID) references DAVID_Y_LOS_COCODRILOS.TURNO
);

/*

----------------------------------------
-------------TABLA RENDICION------------
----------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.RENDICION (
	RENDICION_ID numeric(18,0),
	RENDICION_FECHA datetime,
	RENDICION_CHOFER_ID char(8),
	RENDICION_TURNO_ID char(1),
	RENDICION_IMPORTE numeric(18,2),
	primary key (RENDICION_ID),
	foreign key (RENDICION_TURNO_ID) references DAVID_Y_LOS_COCODRILOS.TURNO
);


----------------------------------------
----------TABLA ITEM RENDICION----------
----------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.ITEM_RENDICION (
	ITEMR_IMPORTE numeric(18,2),
	ITEMR_RENDICION numeric(18,0),
	ITEMR_VIAJE Int,
	primary key(ITEMR_RENDICION, ITEMR_VIAJE),
	foreign key (ITEMR_RENDICION) references DAVID_Y_LOS_COCODRILOS.RENDICION,
	foreign key (ITEMR_VIAJE) references DAVID_Y_LOS_COCODRILOS.VIAJE,
);


---------------------------------------
-------------TABLA FACTURA-------------
---------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.FACTURA (
	FACTURA_CLIENTE_ID char(18),
	FACTURA_ID numeric(18) IDENTITY(1,1),
	FACTURA_ANIO int,
	FACTURA_PERIODO int,
	FACTURA_IMPORTE_TOTAL numeric(18,2)
	primary key (FACTURA_ID)
	foreign key (FACTURA_CLIENTE_ID) references DAVID_Y_LOS_COCODRILOS.CLIENTE
);


-----------------------------------------------------
----------------TABLA ITEM FACTURA-------------------
-----------------------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.ITEM_FACTURA (
	ITEMF_VIAJE numeric(18,0),
	ITEMF_FACTURA numeric(18,0),
	ITEMF_IMPORTE numeric(18,2)
	primary key (ITEMF_VIAJE, ITEMF_FACTURA)
);

*/

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

	--CARGA ROLES
	INSERT	INTO DAVID_Y_LOS_COCODRILOS.ROL(ROL_ID, ROL_DETALLE) 
			VALUES ('1', 'admin');
	INSERT	INTO DAVID_Y_LOS_COCODRILOS.ROL(ROL_ID, ROL_DETALLE) 
			VALUES ('2', 'cliente');
	INSERT	INTO DAVID_Y_LOS_COCODRILOS.ROL(ROL_ID, ROL_DETALLE) 
			VALUES ('3', 'chofer');
			

	--CARGA USUARIO ADMIN 
	INSERT	INTO DAVID_Y_LOS_COCODRILOS.USUARIO (USUARIO_DNI, USUARIO_USERNAME, USUARIO_PASSWORD)
			VALUES('00000000','admin', 'q23w');
	INSERT INTO DAVID_Y_LOS_COCODRILOS.ROL_USUARIO (USROL_USUARIO, USROL_ROL)
			VALUES('00000000', '1');

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
		USROL_ROL
	)	SELECT	distinct(m.Cliente_Dni),
				'2'
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
		USROL_ROL
	)	SELECT	distinct(m.Chofer_Dni),
				'3'
		FROM gd_esquema.Maestra m

END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_ROLxUSUARIO_CHOFER')
GO


-----------------------------------------------------
----------------MIGRACION CLIENTE---------------------
-----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_CLIENTE 
AS
BEGIN

	INSERT INTO DAVID_Y_LOS_COCODRILOS.CLIENTE (
		CLIENTE_USUARIO
	)	SELECT	r.USROL_USUARIO
		FROM ROL_USUARIO r
		WHERE r.USROL_ROL = '2'
	

END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_CLIENTE') 
GO


-----------------------------------------------------
----------------MIGRACION CHOFER---------------------
-----------------------------------------------------
CREATE PROCEDURE DAVID_Y_LOS_COCODRILOS.MIGRACION_CHOFER 
AS
BEGIN

	INSERT INTO DAVID_Y_LOS_COCODRILOS.CHOFER (
		USUARIO_ID
	)	SELECT	r.USROL_USUARIO
		FROM ROL_USUARIO r
		WHERE r.USROL_ROL = '3'
	

END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_CHOFER') 
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
				(	SELECT c.USUARIO_ID
					FROM DAVID_Y_LOS_COCODRILOS.CHOFER c join DAVID_Y_LOS_COCODRILOS.USUARIO u
						 on c.USUARIO_ID = u.USUARIO_DNI
					WHERE u.USUARIO_DNI = m.Chofer_Dni
				), 
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
		VIAJE_CHOFER_ID,
		VIAJE_TURNO_ID,
		VIAJE_CANTIDAD_KM,
		VIAJE_FECHA_INICIO,
		VIAJE_FECHA_FIN,
		VIAJE_CLIENTE_ID
	)	SELECT	m.Auto_Patente,
				(	SELECT c.USUARIO_ID
					FROM DAVID_Y_LOS_COCODRILOS.CHOFER c join
						 DAVID_Y_LOS_COCODRILOS.AUTOMOVIL a
							on c.USUARIO_ID = a.AUTOMOVIL_CHOFER
					WHERE m.Auto_Patente = a.AUTOMOVIL_PATENTE
							and DAVID_Y_LOS_COCODRILOS.fGetTurno(m.Turno_Hora_Inicio, m.Turno_Hora_Fin) = a.AUTOMOVIL_TURNO
				),
				(	SELECT t.TURNO_ID
					FROM DAVID_Y_LOS_COCODRILOS.TURNO t
					WHERE t.TURNO_HORA_INICIO = m.Turno_Hora_Inicio 
							and t.TURNO_HORA_FIN = m.Turno_Hora_Fin
				),
				m.Viaje_Cant_Kilometros,
				m.Viaje_Fecha,
				m.Viaje_Fecha, 
				m.Cliente_Dni
		FROM gd_esquema.Maestra m
END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_VIAJE')
GO


/*

--ERROR
--HACE INSERT DE VALORES NULL YA QUE HAY FECHAS DE FACTURAS EN NULL
--NO SE PUEDE HACER INSERT DE FILAS EN NULL Y ROMPE LA EJECUCION
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
		RENDICION_ID,
		RENDICION_FECHA,
		RENDICION_CHOFER_ID,
		RENDICION_TURNO_ID,
		RENDICION_IMPORTE
	)	SELECT	m.Rendicion_Nro,
				m.Rendicion_Fecha,
				m.Chofer_Dni,
				DAVID_Y_LOS_COCODRILOS.fGetTurno(m.Turno_Hora_Inicio, m.Turno_Hora_Fin),
				m.Rendicion_Importe
		FROM gd_esquema.Maestra m
		WHERE Rendicion_Nro > 0
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
		FACTURA_CLIENTE_ID,
		FACTURA_ID,
		FACTURA_ANIO,
		FACTURA_PERIODO,
		FACTURA_IMPORTE_TOTAL
	)	(SELECT	m.Cliente_Dni,
				m.Factura_Nro, --ERROR --en la tabla FACTURA el FACTURA_ID esta delarado como IDENTITY, pero la tabla maestra y ofrece el factura_Nro que es el id unico de la factura, y ademas aca se hace referencia a ese id, por lo tanto el identity no tiene sentido 
--				'B',  --ERROR  que hace? no existe la columna 
				YEAR(m.Factura_Fecha_Inicio),
				MONTH(m.Factura_Fecha_Inicio),
				0
		FROM gd_esquema.Maestra m
		group by m.Cliente_Telefono, m.Factura_Nro, m.Factura_Fecha_Inicio
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
	INSERT INTO DAVID_Y_LOS_COCODRILOS.ITEM_RENDICION (ITEMR_IMPORTE, ITEMR_RENDICION, ITEMR_VIAJE)
		(	SELECT	m.Rendicion_Importe, RENDICION_ID, VIAJE_ID
			FROM gd_esquema.Maestra m
				 JOIN DAVID_Y_LOS_COCODRILOS.RENDICION 
					ON m.Rendicion_Nro = RENDICION_ID 
				 JOIN DAVID_Y_LOS_COCODRILOS.VIAJE 
					ON VIAJE_CHOFER_ID = RENDICION_CHOFER_ID 
--						AND VIAJE_CLIENTE_ID = RENDICION_CLIENTE_ID   el error indica que no existe RENDICION_CLIENTE_ID
						AND VIAJE_TURNO_ID = RENDICION_TURNO_ID       --no entiendo desde donde se quiere hacer referencia a la columna que igualmente no existe en la tabla RENDICION, por eso rompe.
						AND VIAJE_FECHA_INICIO = Viaje_Fecha
			WHERE Rendicion_Nro > 0
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

	DECLARE @importeTotal numeric(18,2)
	DECLARE @importe numeric(18,2)
	DECLARE @factura numeric(18)
	DECLARE @viaje numeric(18)
	DECLARE @facturaAnterior numeric(18)

	DECLARE clineas CURSOR FOR 
	SELECT	((MAX(Viaje_Cant_Kilometros)* Turno_Valor_Kilometro)+ Turno_Precio_Base), FACTURA_ID, VIAJE_ID
		FROM (gd_esquema.Maestra JOIN DAVID_Y_LOS_COCODRILOS.FACTURA ON Factura_Nro = FACTURA_ID) JOIN DAVID_Y_LOS_COCODRILOS.VIAJE ON VIAJE_CLIENTE_ID = FACTURA_CLIENTE_ID AND VIAJE_FECHA_INICIO = Viaje_Fecha
		WHERE Factura_Nro > 0
		GROUP BY Chofer_Dni, Cliente_Dni, Auto_Patente, Turno_Hora_Inicio, Turno_Precio_Base, Turno_Valor_Kilometro, Viaje_Fecha

	OPEN clineas
	FETCH NEXT clineas INTO @importe, @factura, @viajes
	set @facturaAnterior = @factura

	WHILE @@FETCH_STATUS = 0  
	BEGIN  
		IF @factura != @facturaAnterior
		BEGIN --ERROR --COLUMNAS QUE NO EXISTEN  --ACA HACE REFERENCIA A NOMBRES DE COLUMNA DE LA TABLA FACTURA CUANDO HACE UN SET SOBRE LA TABLA ITEM_FACTURA. OTRA VEZ EL ERROR QUE MUESTRA EL IDEA CUANDO SE PASA EL MOUSE POR ARRIBA DEL SUBRAYADO ES QUE NO EXISTE TAL COLUMNA.
			UPDATE DAVID_Y_LOS_COCODRILOS.ITEM_FACTURA SET FACTURA_IMPORTE = @importeTotal WHERE FACTURA_ID = @facturaAnterior 
			set @facturaAnterior = @factura
			set @importeTotal = 0
		END

		set @importeTotal = @importeTotal + @importe
		FETCH NEXT clineas INTO @importe, @factura, @viajes
		INSERT INTO DAVID_Y_LOS_COCODRILOS.ITEM_FACTURA values (@viaje, @factura, @importe)

	END

END
GO

EXEC('DAVID_Y_LOS_COCODRILOS.MIGRACION_ITEM_FACTURA ')
GO



*/