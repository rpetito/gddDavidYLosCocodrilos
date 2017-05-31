--###########################################################################
--###########################################################################
-- SCRIPT DE MIGRACION Y CREACION DE OBJETOS NECESARIOS
-- GRUPO: DAVID_Y_LOS_COCODRILOS
--###########################################################################
--###########################################################################

USE [GD1C2017]
GO


-----------------------------------------------------------------
-----------------------------------------------------------------
--CREACION DE SCHEMA
-----------------------------------------------------------------
-----------------------------------------------------------------

IF EXISTS (	SELECT  *
            FROM sys.schemas
            WHERE name = 'DAVID_Y_LOS_COCODRILOS' ) 
    EXEC('DROP SCHEMA [DAVID_Y_LOS_COCODRILOS]');
GO

IF NOT EXISTS ( SELECT  *
                FROM    sys.schemas
                WHERE   name = 'DAVID_Y_LOS_COCODRILOS' ) 
    EXEC('CREATE SCHEMA [DAVID_Y_LOS_COCODRILOS] AUTHORIZATION [gd]');
 GO



--###########################################################################
--###########################################################################
--CREACION DE TABLAS
--###########################################################################
--###########################################################################


-------------------------------------------------------------------
--TABLA CHOFER
-------------------------------------------------------------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.CHOFER (
	USUARIO_ID char(8),
	primary key (USUARIO_ID)
);


-------------
--TABLA AUTOMOVIL
-------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.AUTOMOVIL (
	AUTOMOVIL_PATENTE varchar(10),
	AUTOMOVIL_MARCA varchar(255),
	AUTOMOVIL_MODELO varchar(255),
	AUTOMOVIL_TURNO char(1),
	AUTOMOVIL_CHOFER char(8),
	AUTOMOVIL_HABILITADO boolean,
	primary key (AUTOMOVIL_PATENTE),
	foreign key (AUTOMOVIL_MARCA),
	foreign key (AUTOMOVIL_MODELO)
);


--------------
--TABLA TURNO
--------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.TURNO (
	TURNO_ID char(1),
	TURNO_HORA_INICIO numeric(18,0),
	TURNO_HORA_FIN numeric(18,0),
	TURNO_DESCRIPCION varchar(255),
	TURNO_VALOR_KILOMETRO numeric(18,2),
	TURNO_PRECIO_BASE numeric(18,2),
	TURNO_HABILITADO boolean,
	primary key (TURNO_ID)
);


--------------
--TABLA VIAJE
--------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.VIAJE (
	VIAJE_ID char(8),
	VIAJE_CHOFER_ID char(8),
	VIAJE_CLIENTE_ID char(8),
	VIAJE_AUTOMOVIL_PATENTE varchar(10),
	VIAJE_TURNO_ID char(1),
	VIAJE_CANTIDAD_KM numeric(18,0),
	VIAJE_FECHA_INICIO datetime,
	VIAJE_FECHA_FIN datetime,
	primary key (VIAJE_ID),
	foreign key (VIAJE_USUARIO_ID),
	foreign key (VIAJE_AUTOMOVIL_PATENTE)
);


--------------
--TABLA RENDICION
--------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.RENDICION (
	RENDICION_ID numeric(18,0),
	RENDICION_FECHA datetime,
	RENDICION_CHOFER_ID char(8),
	RENDICION_TURNO_ID char(1),
	RENDICION_IMPORTE numeric(18,2),
	primary key (RENDICIO_ID),
	foreign key (TURNO_ID)
);


--------------
--TABLA ITEM RENDICION
--------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.ITEM_RENDICION (
	RENDICION_ID numeric(18,0),
	RENDICION_VIAJE_ID char(8)
);


-------------
--TABLA FACTURA
-------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.FACTURA (
	FACTURA_CLIENTE_ID char(8),
	FACTURA_ID numeric(18,0),
	FACTURA_TIPO char(8), --no se que es
	FACTURA_FECHA_INICIO datetime,
	FACTURA_FECHA_FIN datetime,
	FACTURA_IMPORTE_TOTAL numeric(18,2)
	primary key (FACTURA_ID),
	foreign key (FACTURA_CLIENTE_ID)
);


--------------
--TABLA ITEM FACTURA
--------------
CREATE TABLE DAVID_Y_LOS_COCODRILOS.ITEM_FACTURA (
	VIAJE_ID char(8),
	CLIENTE_ID char(8),
	FACTURA_ID numeric(18,0),
	FACTURA_TIPO char(8),
	primary key (FACTURA_ID)
);
	


