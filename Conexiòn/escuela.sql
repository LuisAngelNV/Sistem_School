-- --------------------------------------------------------
-- Host:                         PC-ELITE\SERVER
-- Versión del servidor:         Microsoft SQL Server 2019 (RTM) - 15.0.2000.5
-- SO del servidor:              Windows 10 Pro 10.0 <X64> (Build 19042: )
-- HeidiSQL Versión:             12.3.0.6589
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES  */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- Volcando estructura de base de datos para Colegio
CREATE DATABASE IF NOT EXISTS "Colegio";
USE "Colegio";

-- Volcando estructura para procedimiento Colegio.actualizar_serializacion_mas_uno
DELIMITER //
create proc actualizar_serializacion_mas_uno
@idserie as int,
@numerofin as numeric(18,0)  
as 
update Serializacion set  Numero_fin=@numerofin            
where Id_serializacion=@idserie 
//
DELIMITER ;

-- Volcando estructura para tabla Colegio.alumnos
CREATE TABLE IF NOT EXISTS "alumnos" (
	"id_alumno" INT NOT NULL,
	"Ap_Paterno" VARCHAR(50) NULL DEFAULT NULL COLLATE 'Modern_Spanish_CI_AS',
	"Ap_Materno" VARCHAR(50) NULL DEFAULT NULL COLLATE 'Modern_Spanish_CI_AS',
	"Nombre" VARCHAR(50) NULL DEFAULT NULL COLLATE 'Modern_Spanish_CI_AS',
	"Curp" VARCHAR(50) NULL DEFAULT NULL COLLATE 'Modern_Spanish_CI_AS',
	"Email" VARCHAR(50) NULL DEFAULT NULL COLLATE 'Modern_Spanish_CI_AS',
	"Estado" VARCHAR(50) NULL DEFAULT NULL COLLATE 'Modern_Spanish_CI_AS',
	PRIMARY KEY ("id_alumno")
);

-- Volcando datos para la tabla Colegio.alumnos: -1 rows
/*!40000 ALTER TABLE "alumnos" DISABLE KEYS */;
INSERT INTO "alumnos" ("id_alumno", "Ap_Paterno", "Ap_Materno", "Nombre", "Curp", "Email", "Estado") VALUES
	(1, 'Neyra', 'Vazquez', 'Luis Angel', 'AANL981107HMCNYS07', 'deanda.1998@gmail.com', 'ACTIVO'),
	(2, 'qkvkhv knv', 'hvhkvkhv', 'hkvknjkvjh ', 'kjvkhvkvmn', 'khkhv', 'ACTIVO'),
	(3, 'gnfnfngd', ',g', 'kh hm', 'MODIFICADO', 'cv,j', 'ACTIVO'),
	(4, ',gkc,gc', 'hjv.y', 'ghc.cv', 'hjv.', 'cv.ug', 'ACTIVO'),
	(5, 'jbñhv.hbHV KHB.', '.BUJVB-JB-', 'HVKJB', '.UV.BJG', 'JJB-', 'ACTIVO'),
	(6, 'Laurie', 'Laurène', 'Espinay', 'Programmable attitude-oriented benchmark', 'lespinay0@mayoclinic.com', 'ACTIVO'),
	(7, 'Klarrisa', 'Lén', 'Skyram', 'Distributed hybrid hub', 'kskyram1@wordpress.com', 'ACTIVO'),
	(8, 'Helli', 'Salomé', 'Gaize', 'Visionary regional array', 'hgaize2@geocities.com', 'ACTIVO'),
	(9, 'Tove', 'Célestine', 'Ingerman', 'Up-sized didactic success', 'tingerman3@dropbox.com', 'ACTIVO'),
	(10, 'Cody', 'Mélanie', 'Nisard', 'Quality-focused eco-centric capacity', 'cnisard4@uiuc.edu', 'ACTIVO'),
	(11, 'Ennis', 'Mélia', 'Medcalfe', 'Focused discrete structure', 'emedcalfe5@google.it', 'ACTIVO'),
	(12, 'Shanna', 'Mà', 'Lander', 'Balanced holistic algorithm', 'slander6@plala.or.jp', 'ACTIVO'),
	(13, 'Nerta', 'Réservés', 'Brunotti', 'Synergistic solution-oriented intranet', 'nbrunotti7@marketwatch.com', 'ACTIVO'),
	(14, 'Ferrell', 'Léone', 'Bridgwater', 'Proactive secondary internet solution', 'fbridgwater8@cmu.edu', 'ACTIVO'),
	(15, 'Loree', 'Måns', 'Durham', 'Digitized neutral alliance', 'ldurham9@uiuc.edu', 'ACTIVO'),
	(16, 'Milena', 'Görel', 'Bothwell', 'Profit-focused upward-trending productivity', 'mbothwella@house.gov', 'ACTIVO'),
	(17, 'Trumann', 'Thérèsa', 'McGuckin', 'Future-proofed multi-state approach', 'tmcguckinb@telegraph.co.uk', 'ACTIVO'),
	(18, 'Cordelia', 'Eléa', 'Wooster', 'Ergonomic mission-critical benchmark', 'cwoosterc@cbslocal.com', 'ACTIVO'),
	(19, 'Drucy', 'Personnalisée', 'Prestner', 'Public-key multi-state array', 'dprestnerd@livejournal.com', 'ACTIVO'),
	(20, 'Robin', 'Agnès', 'Dack', 'De-engineered directional knowledge base', 'rdacke@tiny.cc', 'ACTIVO'),
	(21, 'Gibby', 'Mylène', 'McCutcheon', 'Decentralized fresh-thinking framework', 'gmccutcheonf@opera.com', 'ACTIVO'),
	(22, 'Vinny', 'Léonore', 'Methuen', 'Compatible reciprocal algorithm', 'vmethueng@jiathis.com', 'ACTIVO'),
	(23, 'Francene', 'Anaël', 'Putland', 'Open-architected non-volatile conglomeration', 'fputlandh@parallels.com', 'ACTIVO'),
	(24, 'Gannon', 'Léone', 'Rannald', 'Future-proofed regional data-warehouse', 'grannaldi@cornell.edu', 'ACTIVO'),
	(25, 'Tamas', 'Anaé', 'Quilleash', 'Team-oriented explicit emulation', 'tquilleashj@earthlink.net', 'ACTIVO'),
	(26, 'Sonny', 'Gérald', 'Michael', 'Fully-configurable local algorithm', 'smichaelk@w3.org', 'ACTIVO'),
	(27, 'Hermione', 'Méng', 'Raitt', 'Adaptive client-driven firmware', 'hraittl@tamu.edu', 'ACTIVO'),
	(28, 'Izzy', 'Léa', 'Cooksey', 'Visionary 24/7 firmware', 'icookseym@epa.gov', 'ACTIVO'),
	(29, 'Adrea', 'Léa', 'Dubble', 'Automated radical website', 'adubblen@google.co.jp', 'ACTIVO'),
	(30, 'Cornela', 'Régine', 'Whatsize', 'Right-sized 4th generation capability', 'cwhatsizeo@yandex.ru', 'ACTIVO'),
	(31, 'Dion', 'Ráo', 'Stud', 'Enterprise-wide motivating support', 'dstudp@studiopress.com', 'ACTIVO'),
	(32, 'Rocky', 'Médiamass', 'Harwell', 'Persevering optimal product', 'rharwellq@blog.com', 'ACTIVO'),
	(33, 'Andrey', 'Félicie', 'Cerro', 'Business-focused grid-enabled approach', 'acerror@w3.org', 'ACTIVO'),
	(34, 'Sibylla', 'Laurène', 'Hovee', 'Organized system-worthy Graphic Interface', 'shovees@google.pl', 'ACTIVO'),
	(35, 'Brena', 'Marie-noël', 'Helmke', 'Reverse-engineered local time-frame', 'bhelmket@ow.ly', 'ACTIVO'),
	(36, 'Cristine', 'Östen', 'Rhodes', 'Front-line motivating projection', 'crhodesu@friendfeed.com', 'ACTIVO'),
	(37, 'Tamera', 'Mégane', 'Bandey', 'Customer-focused disintermediate focus group', 'tbandeyv@forbes.com', 'ACTIVO'),
	(38, 'Viki', 'Marie-ève', 'Goullee', 'Cross-platform asymmetric instruction set', 'vgoulleew@nasa.gov', 'ACTIVO'),
	(39, 'Ashley', 'Miléna', 'Humes', 'Re-engineered interactive task-force', 'ahumesx@biblegateway.com', 'ACTIVO'),
	(40, 'Marjorie', 'Anaïs', 'Sword', 'Grass-roots regional structure', 'mswordy@wordpress.com', 'ACTIVO'),
	(41, 'Steffi', 'Loïs', 'Dowker', 'Polarised systemic ability', 'sdowkerz@symantec.com', 'ACTIVO'),
	(42, 'Dolly', 'Anaëlle', 'Simioli', 'Front-line disintermediate firmware', 'dsimioli10@creativecommons.org', 'ACTIVO'),
	(43, 'Kaspar', 'Léane', 'Le Blanc', 'Seamless hybrid internet solution', 'kleblanc11@usda.gov', 'ACTIVO'),
	(44, 'Lorrayne', 'Kuí', 'Padley', 'Exclusive systemic product', 'lpadley12@elegantthemes.com', 'ACTIVO'),
	(45, 'Ashia', 'André', 'Osgordby', 'Progressive logistical time-frame', 'aosgordby13@patch.com', 'ACTIVO'),
	(46, 'Nappy', 'Andrée', 'Bartlosz', 'Mandatory eco-centric access', 'nbartlosz14@discovery.com', 'ACTIVO'),
	(47, 'Gae', 'Ruì', 'Schenfisch', 'Proactive object-oriented concept', 'gschenfisch15@liveinternet.ru', 'ACTIVO'),
	(48, 'Wilow', 'Gwenaëlle', 'Johantges', 'Ergonomic bottom-line core', 'wjohantges16@xrea.com', 'ACTIVO'),
	(49, 'Arabelle', 'Maéna', 'Ruseworth', 'Polarised stable adapter', 'aruseworth17@noaa.gov', 'ACTIVO'),
	(50, 'Carlita', 'Alizée', 'McQuillen', 'Intuitive dynamic solution', 'cmcquillen18@redcross.org', 'ACTIVO'),
	(51, 'Perceval', 'Maïly', 'Bresland', 'Quality-focused coherent archive', 'pbresland19@microsoft.com', 'ACTIVO'),
	(52, 'Gustave', 'Mahélie', 'Gotter', 'Fundamental stable matrices', 'ggotter1a@networkadvertising.org', 'ACTIVO'),
	(53, 'Michaella', 'Véronique', 'De Robertis', 'Exclusive incremental architecture', 'mderobertis1b@topsy.com', 'ACTIVO'),
	(54, 'Archambault', 'Ruò', 'McIntee', 'Centralized discrete utilisation', 'amcintee1c@taobao.com', 'ACTIVO'),
	(55, 'Abeu', 'Maëly', 'Laurenceau', 'Fully-configurable impactful support', 'alaurenceau1d@cloudflare.com', 'ACTIVO');
/*!40000 ALTER TABLE "alumnos" ENABLE KEYS */;

-- Volcando estructura para procedimiento Colegio.alumnos_editar
DELIMITER //
CREATE PROC alumnos_editar
@id_alumno int,
@ap_paterno varchar(50),
@ap_materno varchar(50),
@nombre varchar(50),
@curp varchar(50),
@email varchar(50)
as
IF EXISTS (SELECT Curp from alumnos where (Curp = @curp and id_alumno <> @id_alumno))
RAISERROR ('Ya se cuenta con un usuario con ese CURP!!',16,1)
update alumnos set Ap_Paterno = @ap_paterno, Ap_Materno = @ap_materno, Nombre = @nombre, Curp = @curp, Email = @email
where id_alumno = @id_alumno//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.alumnos_insertar
DELIMITER //
CREATE PROC [dbo].[alumnos_insertar]
@ap_paterno varchar(50),
@ap_materno varchar(50),
@nombre varchar(50),
@curp varchar(50),
@email varchar(50),
@estado varchar(50)
as
IF EXISTS(SELECT Curp FROM alumnos where Curp = @curp)
RAISERROR('Ya se cuenta con un usuario con ese dato!!',16,1)
else
insert into alumnos values(@ap_paterno, @ap_materno, @nombre, @curp, @email, @estado)//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.alumnos_mostrar
DELIMITER //
CREATE proc [dbo].[alumnos_mostrar]
as
select id_alumno, Ap_Paterno, Ap_Materno, Nombre, Email, Curp , Estado from alumnos//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.alumno_buscar
DELIMITER //
CREATE PROC [dbo].[alumno_buscar]
@letra varchar(50)
as
select id_alumno, Ap_Paterno, Ap_Materno, Nombre, Curp, Email, Estado
, Nombre + ' '+ Ap_Paterno + ' '+ Ap_Materno
from alumnos
where Ap_Paterno + Ap_Materno + Nombre + Curp + Email like '%' + @letra + '%'//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.alumno_eliminar
DELIMITER //
CREATE proc alumno_eliminar
@id_alumno int
as
update alumnos set Estado = 'ELIMINADO'
WHERE id_alumno= @id_alumno and Estado = 'ACTIVO'//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.alumno_restaurar
DELIMITER //
create proc alumno_restaurar
@id_alumno int
as
update alumnos set Estado = 'ACTIVO'
WHERE id_alumno= @id_alumno and Estado = 'ELIMINADO'//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.buscar_Usuario
DELIMITER //
create proc buscar_Usuario
@letra as varchar(50)
as 
select id_usuario, Nombre_y_Apellido as Nombre, Usuario as 'Nombre de Usuario', password as Contraseña
from usuarios
where Nombre_y_Apellido + Usuario like '%' + @letra + '%'//
DELIMITER ;

-- Volcando estructura para tabla Colegio.detalle_control_de_cobros
CREATE TABLE IF NOT EXISTS "detalle_control_de_cobros" (
	"Id_dcc" INT NOT NULL,
	"Pago_realizado" NUMERIC(18,2) NULL DEFAULT '''NULL''',
	"Fecha_que_pago" DATETIME NULL DEFAULT '''NULL''',
	"Nro_comprobante" VARCHAR(50) NULL DEFAULT '''NULL''' COLLATE 'Modern_Spanish_CI_AS',
	"Detalle" VARCHAR(max) NULL DEFAULT '''NULL''' COLLATE 'Modern_Spanish_CI_AS',
	"Grado" VARCHAR(50) NULL DEFAULT '''NULL''' COLLATE 'Modern_Spanish_CI_AS',
	"Id_Alumno" INT NULL DEFAULT '''NULL''',
	"Id_usuario" INT NULL DEFAULT '''NULL''',
	PRIMARY KEY ("Id_dcc"),
	FOREIGN KEY INDEX "FK_detalle_control_de_cobros_alumnos" ("Id_Alumno"),
	FOREIGN KEY INDEX "FK_detalle_control_de_cobros_usuarios" ("Id_usuario"),
	CONSTRAINT "FK_detalle_control_de_cobros_usuarios" FOREIGN KEY ("Id_usuario") REFERENCES "usuarios" ("id_usuario") ON UPDATE NO_ACTION ON DELETE NO_ACTION,
	CONSTRAINT "FK_detalle_control_de_cobros_alumnos" FOREIGN KEY ("Id_Alumno") REFERENCES "alumnos" ("id_alumno") ON UPDATE NO_ACTION ON DELETE NO_ACTION
);

-- Volcando datos para la tabla Colegio.detalle_control_de_cobros: -1 rows
/*!40000 ALTER TABLE "detalle_control_de_cobros" DISABLE KEYS */;
INSERT INTO "detalle_control_de_cobros" ("Id_dcc", "Pago_realizado", "Fecha_que_pago", "Nro_comprobante", "Detalle", "Grado", "Id_Alumno", "Id_usuario") VALUES
	(1, 400, '2023-02-07 01:53:51.173', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(2, 400, '2023-02-07 01:53:53.970', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(3, 400, '2023-02-07 01:53:54.417', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(4, 400, '2023-02-07 01:53:55.287', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(5, 400, '2023-02-07 01:53:56.140', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(6, 400, '2023-02-07 01:53:58.407', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(7, 400, '2023-02-07 01:53:58.843', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(8, 400, '2023-02-07 01:53:59.270', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(9, 400, '2023-02-07 01:53:59.640', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(10, 400, '2023-02-07 01:54:00.023', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(11, 400, '2023-02-07 01:54:00.407', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(12, 400, '2023-02-07 01:54:00.787', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(13, 400, '2023-02-07 01:54:01.203', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(14, 400, '2023-02-07 01:54:01.827', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(15, 400, '2023-02-07 01:54:02.357', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(16, 800, '2023-02-07 02:10:22.803', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 1, 1),
	(17, 5000, '2023-02-07 02:15:25.500', '00
002 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 7, 1),
	(18, 5000, '2023-02-07 02:15:59.223', '00
002 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 7, 1),
	(19, 5000, '2023-02-07 02:15:59.620', '00
002 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 7, 1),
	(20, 5000, '2023-02-07 02:16:00.080', '00
002 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 7, 1),
	(21, 5000, '2023-02-07 02:16:00.420', '00
002 - 20222023', 'PAGO DE MATRICULA', 'Grado 5', 7, 1),
	(22, 4200, '2023-02-07 02:19:31.407', '0001 - 20222023', 'PAGO DE MATRICULA', 'Grado 8', 1, 1);
/*!40000 ALTER TABLE "detalle_control_de_cobros" ENABLE KEYS */;

-- Volcando estructura para procedimiento Colegio.editar_usuario
DELIMITER //
create PROC editar_usuario
@id_usuario int,
@nombre varchar(50),
@usuario varchar(50),
@password varchar(50)
as
update usuarios set Nombre_y_Apellido =@nombre, Usuario =@usuario, password =@password
where id_usuario = @id_usuario//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.eliminar_usuario
DELIMITER //
create proc eliminar_usuario
@idUsuario int 
as
delete from usuarios where id_usuario = @idUsuario//
DELIMITER ;

-- Volcando estructura para función Colegio.fn_diagramobjects
DELIMITER //

	CREATE FUNCTION dbo.fn_diagramobjects() 
	RETURNS int
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		declare @id_upgraddiagrams		int
		declare @id_sysdiagrams			int
		declare @id_helpdiagrams		int
		declare @id_helpdiagramdefinition	int
		declare @id_creatediagram	int
		declare @id_renamediagram	int
		declare @id_alterdiagram 	int 
		declare @id_dropdiagram		int
		declare @InstalledObjects	int

		select @InstalledObjects = 0

		select 	@id_upgraddiagrams = object_id(N'dbo.sp_upgraddiagrams'),
			@id_sysdiagrams = object_id(N'dbo.sysdiagrams'),
			@id_helpdiagrams = object_id(N'dbo.sp_helpdiagrams'),
			@id_helpdiagramdefinition = object_id(N'dbo.sp_helpdiagramdefinition'),
			@id_creatediagram = object_id(N'dbo.sp_creatediagram'),
			@id_renamediagram = object_id(N'dbo.sp_renamediagram'),
			@id_alterdiagram = object_id(N'dbo.sp_alterdiagram'), 
			@id_dropdiagram = object_id(N'dbo.sp_dropdiagram')

		if @id_upgraddiagrams is not null
			select @InstalledObjects = @InstalledObjects + 1
		if @id_sysdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 2
		if @id_helpdiagrams is not null
			select @InstalledObjects = @InstalledObjects + 4
		if @id_helpdiagramdefinition is not null
			select @InstalledObjects = @InstalledObjects + 8
		if @id_creatediagram is not null
			select @InstalledObjects = @InstalledObjects + 16
		if @id_renamediagram is not null
			select @InstalledObjects = @InstalledObjects + 32
		if @id_alterdiagram  is not null
			select @InstalledObjects = @InstalledObjects + 64
		if @id_dropdiagram is not null
			select @InstalledObjects = @InstalledObjects + 128
		
		return @InstalledObjects 
	END
	//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.insertar_detalles_de_cobro
DELIMITER //
CREATE PROC insertar_detalles_de_cobro
@Pago_realizado numeric(18,2),
@Fecha_que_pago datetime,
@Nro_comprobante varchar(50) ,
@Detalle varchar(max)  ,
@Grado varchar(50),   
@Id_Alumno int,
@Id_usuario int     
as
insert into detalle_control_de_cobros values 
(@Pago_realizado ,
@Fecha_que_pago ,
@Nro_comprobante,
@Detalle 
,@Grado,@Id_Alumno,@Id_usuario);
//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.insertar_matricula
DELIMITER //
CREATE PROC insertar_matricula
@grado varchar(50),
@Descripcion varchar (50),
@Fecha date, 
@N_recibo varchar(50),
@Id_alumno int,
@Saldo numeric(18,2),
@Estado varchar(50),
@Pension numeric(18,2),
@Importe numeric(19,2),
@Seccion varchar(50),
@Numero_de_pension varchar(50),
@Tipo_de_Institucion varchar(50),
@Estado_de_matricula varchar (50),
@Saldo_matricula varchar (50),
@horario varchar(50),
@Observacion varchar(50),
@Prioridad varchar(50)
AS 
INSERT INTO matriculas
VALUES
(@grado,
@Descripcion,
@Fecha , 
@N_recibo,
@Id_alumno ,
@Saldo ,
@Estado ,
@Pension ,
@Importe ,
@Seccion ,
@Numero_de_pension,
@Tipo_de_Institucion ,
@Estado_de_matricula ,
@Saldo_matricula,
@horario ,
@Observacion,
@Prioridad)//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.insertar_usuario
DELIMITER //
CREATE PROC insertar_usuario
@nombre varchar(50),
@usuario varchar(50),
@password varchar(50)
as
if EXISTS(SELECT Usuario from usuarios WHERE Usuario = @usuario)
RAISERROR('Ya se cuenta con un usuario con ese dato!!',16,1)
else
insert into usuarios values(@nombre, @usuario, @password)//
DELIMITER ;

-- Volcando estructura para tabla Colegio.matriculas
CREATE TABLE IF NOT EXISTS "matriculas" (
	"Id_matricula" INT NOT NULL,
	"Grado" VARCHAR(50) NULL DEFAULT '''NULL''' COLLATE 'Modern_Spanish_CI_AS',
	"Descripcion" VARCHAR(50) NULL DEFAULT '''NULL''' COLLATE 'Modern_Spanish_CI_AS',
	"Fecha" DATE NULL DEFAULT '''NULL''',
	"N_recibo" VARCHAR(50) NULL DEFAULT '''NULL''' COLLATE 'Modern_Spanish_CI_AS',
	"Id_alumno" INT NULL DEFAULT '''NULL''',
	"Saldo" NUMERIC(18,2) NULL DEFAULT '''NULL''',
	"Estado" VARCHAR(50) NULL DEFAULT '''NULL''' COLLATE 'Modern_Spanish_CI_AS',
	"Pension" NUMERIC(18,2) NULL DEFAULT '''NULL''',
	"Importe" NUMERIC(19,2) NULL DEFAULT '''NULL''',
	"Seccion" VARCHAR(50) NULL DEFAULT '''NULL''' COLLATE 'Modern_Spanish_CI_AS',
	"Numero_de_pension" VARCHAR(50) NULL DEFAULT '''NULL''' COLLATE 'Modern_Spanish_CI_AS',
	"Tipo_de_Institucion" VARCHAR(50) NULL DEFAULT '''NULL''' COLLATE 'Modern_Spanish_CI_AS',
	"Estado_de_matricula" VARCHAR(50) NULL DEFAULT '''NULL''' COLLATE 'Modern_Spanish_CI_AS',
	"Saldo_matricula" NUMERIC(18,2) NULL DEFAULT '''NULL''',
	"Horario" VARCHAR(50) NULL DEFAULT '''NULL''' COLLATE 'Modern_Spanish_CI_AS',
	"Observacion" VARCHAR(max) NULL DEFAULT '''NULL''' COLLATE 'Modern_Spanish_CI_AS',
	"Prioridad" VARCHAR(50) NULL DEFAULT '''NULL''' COLLATE 'Modern_Spanish_CI_AS',
	PRIMARY KEY ("Id_matricula")
);

-- Volcando datos para la tabla Colegio.matriculas: -1 rows
/*!40000 ALTER TABLE "matriculas" DISABLE KEYS */;
/*!40000 ALTER TABLE "matriculas" ENABLE KEYS */;

-- Volcando estructura para procedimiento Colegio.mostrar_GRADOS
DELIMITER //
CREATE PROC mostrar_GRADOS
as
set NOCOUNT ON;
SELECT DISTINCT Grado
from MATRICULAS
//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.mostrar_HORARIOS
DELIMITER //
CREATE proc [dbo].[mostrar_HORARIOS]
as
set NOCOUNT ON;
SELECT DISTINCT Horario
from MATRICULAS
where Horario <>''//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.mostrar_Precio_de_MATRICULA
DELIMITER //
CREATE   proc mostrar_Precio_de_MATRICULA
@Grado as varchar(50)
AS	
SELECT Pension  
FROM MATRICULAS 
where Grado = @Grado and Descripcion ='MATRICULA' ORDER BY Id_matricula DESC
//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.mostrar_SECCIONES
DELIMITER //
CREATE PROC mostrar_SECCIONES
as
set NOCOUNT ON;
SELECT DISTINCT Seccion
from MATRICULAS//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.mostrar_usuarios
DELIMITER //
CREATE PROC mostrar_usuarios
as
select id_usuario, Nombre_y_Apellido as Nombre, Usuario as 'Nombre de Usuario', password as Contraseña
from usuarios//
DELIMITER ;

-- Volcando estructura para tabla Colegio.serializacion
CREATE TABLE IF NOT EXISTS "serializacion" (
	"id_serializacion" INT NOT NULL,
	"Serie" VARCHAR(50) NULL DEFAULT NULL COLLATE 'Modern_Spanish_CI_AS',
	"Numero_inicio" VARCHAR(50) NULL DEFAULT NULL COLLATE 'Modern_Spanish_CI_AS',
	"Numero_fin" VARCHAR(50) NULL DEFAULT NULL COLLATE 'Modern_Spanish_CI_AS',
	"Tipo_De_comprobante" VARCHAR(50) NULL DEFAULT NULL COLLATE 'Modern_Spanish_CI_AS',
	PRIMARY KEY ("id_serializacion")
);

-- Volcando datos para la tabla Colegio.serializacion: -1 rows
/*!40000 ALTER TABLE "serializacion" DISABLE KEYS */;
INSERT INTO "serializacion" ("id_serializacion", "Serie", "Numero_inicio", "Numero_fin", "Tipo_De_comprobante") VALUES
	(6, '0001', '2022', '2023', 'Factura'),
	(7, '00
002', '2022', '2023', 'Nota'),
	(8, '003', '2022', '2028', 'Factura');
/*!40000 ALTER TABLE "serializacion" ENABLE KEYS */;

-- Volcando estructura para procedimiento Colegio.serializacion_Buscar_tipo_de_documentos_para_insertar_en_matriculas
DELIMITER //
CREATE PROC [dbo].[serializacion_Buscar_tipo_de_documentos_para_insertar_en_matriculas]
@Tipo_De_comprobante VARCHAR(50)
AS
SELECT id_serializacion ,Tipo_De_comprobante AS COMPROBANTE, Numero_inicio, Numero_fin+1 AS Correlativo, 
(Serie + ' - ' + Numero_inicio + Numero_fin) AS serie_completa
FROM serializacion
WHERE Tipo_De_comprobante = @Tipo_De_comprobante//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.serializacion_editar
DELIMITER //
create proc serializacion_editar
@id_serializacion as int,
@serie varchar(50),
@numero_inicio varchar (50),
@numero_fin varchar (50),
@tipo_de_comprobante varchar(50)
as
update serializacion set Serie = @serie, Numero_inicio = @numero_inicio, Numero_fin = @numero_fin, Tipo_De_comprobante = @tipo_de_comprobante
where id_serializacion = @id_serializacion//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.serializacion_eliminar
DELIMITER //
CREATE PROC serializacion_eliminar
@id_serializacion int
as
DELETE from serializacion where id_serializacion = @id_serializacion//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.serializacion_insertar
DELIMITER //
CREATE PROC serializacion_insertar
@Serie varchar(50),
@Numero_inicio varchar(50),
@Numero_fin varchar(50),
@Tipo_De_comprobante varchar(50)
as
insert into serializacion
values (@Serie, @Numero_inicio, @Numero_fin, @Tipo_De_comprobante)//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.serializacion_mostrar_tipo_de_docuemntos_para_insertar_estos_mismos
DELIMITER //
CREATE PROC serializacion_mostrar_tipo_de_docuemntos_para_insertar_estos_mismos
as
SELECT id_serializacion ,Serie, Numero_inicio, Numero_fin, Tipo_De_comprobante as Comprobante, 
(serializacion.Numero_inicio + ' - ' + serializacion.Numero_fin) as Serie_completa
FROM serializacion//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.serializacion_mostrar_tipo_de_documentos_para_insertar_en_matriculas01
DELIMITER //
create proc [dbo].[serializacion_mostrar_tipo_de_documentos_para_insertar_en_matriculas01]
AS
SELECT id_serializacion ,Tipo_De_comprobante AS COMPROBANTE, Numero_inicio, Numero_fin+1 AS Correlativo, 
(Serie + ' - ' + Numero_inicio + Numero_fin) AS serie_completa
FROM serializacion//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.sp_alterdiagram
DELIMITER //

	CREATE PROCEDURE dbo.sp_alterdiagram
	(
		@diagramname 	sysname,
		@owner_id	int	= null,
		@version 	int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId 			int
		declare @retval 		int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @ShouldChangeUID	int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid ARG', 16, 1)
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();	 
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		revert;
	
		select @ShouldChangeUID = 0
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		
		if(@DiagId IS NULL or (@IsDbo = 0 and @theId <> @UIDFound))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end
	
		if(@IsDbo <> 0)
		begin
			if(@UIDFound is null or USER_NAME(@UIDFound) is null) -- invalid principal_id
			begin
				select @ShouldChangeUID = 1 ;
			end
		end

		-- update dds data			
		update dbo.sysdiagrams set definition = @definition where diagram_id = @DiagId ;

		-- change owner
		if(@ShouldChangeUID = 1)
			update dbo.sysdiagrams set principal_id = @theId where diagram_id = @DiagId ;

		-- update dds version
		if(@version is not null)
			update dbo.sysdiagrams set version = @version where diagram_id = @DiagId ;

		return 0
	END
	//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.sp_creatediagram
DELIMITER //

	CREATE PROCEDURE dbo.sp_creatediagram
	(
		@diagramname 	sysname,
		@owner_id		int	= null, 	
		@version 		int,
		@definition 	varbinary(max)
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
	
		declare @theId int
		declare @retval int
		declare @IsDbo	int
		declare @userName sysname
		if(@version is null or @diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID(); 
		select @IsDbo = IS_MEMBER(N'db_owner');
		revert; 
		
		if @owner_id is null
		begin
			select @owner_id = @theId;
		end
		else
		begin
			if @theId <> @owner_id
			begin
				if @IsDbo = 0
				begin
					RAISERROR (N'E_INVALIDARG', 16, 1);
					return -1
				end
				select @theId = @owner_id
			end
		end
		-- next 2 line only for test, will be removed after define name unique
		if EXISTS(select diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @diagramname)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end
	
		insert into dbo.sysdiagrams(name, principal_id , version, definition)
				VALUES(@diagramname, @theId, @version, @definition) ;
		
		select @retval = @@IDENTITY 
		return @retval
	END
	//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.sp_dropdiagram
DELIMITER //

	CREATE PROCEDURE dbo.sp_dropdiagram
	(
		@diagramname 	sysname,
		@owner_id	int	= null
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
	
		if(@diagramname is null)
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT; 
		
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		delete from dbo.sysdiagrams where diagram_id = @DiagId;
	
		return 0;
	END
	//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.sp_helpdiagramdefinition
DELIMITER //

	CREATE PROCEDURE dbo.sp_helpdiagramdefinition
	(
		@diagramname 	sysname,
		@owner_id	int	= null 		
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		set nocount on

		declare @theId 		int
		declare @IsDbo 		int
		declare @DiagId		int
		declare @UIDFound	int
	
		if(@diagramname is null)
		begin
			RAISERROR (N'E_INVALIDARG', 16, 1);
			return -1
		end
	
		execute as caller;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner');
		if(@owner_id is null)
			select @owner_id = @theId;
		revert; 
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname;
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId ))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1);
			return -3
		end

		select version, definition FROM dbo.sysdiagrams where diagram_id = @DiagId ; 
		return 0
	END
	//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.sp_helpdiagrams
DELIMITER //

	CREATE PROCEDURE dbo.sp_helpdiagrams
	(
		@diagramname sysname = NULL,
		@owner_id int = NULL
	)
	WITH EXECUTE AS N'dbo'
	AS
	BEGIN
		DECLARE @user sysname
		DECLARE @dboLogin bit
		EXECUTE AS CALLER;
			SET @user = USER_NAME();
			SET @dboLogin = CONVERT(bit,IS_MEMBER('db_owner'));
		REVERT;
		SELECT
			[Database] = DB_NAME(),
			[Name] = name,
			[ID] = diagram_id,
			[Owner] = USER_NAME(principal_id),
			[OwnerID] = principal_id
		FROM
			sysdiagrams
		WHERE
			(@dboLogin = 1 OR USER_NAME(principal_id) = @user) AND
			(@diagramname IS NULL OR name = @diagramname) AND
			(@owner_id IS NULL OR principal_id = @owner_id)
		ORDER BY
			4, 5, 1
	END
	//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.sp_renamediagram
DELIMITER //

	CREATE PROCEDURE dbo.sp_renamediagram
	(
		@diagramname 		sysname,
		@owner_id		int	= null,
		@new_diagramname	sysname
	
	)
	WITH EXECUTE AS 'dbo'
	AS
	BEGIN
		set nocount on
		declare @theId 			int
		declare @IsDbo 			int
		
		declare @UIDFound 		int
		declare @DiagId			int
		declare @DiagIdTarg		int
		declare @u_name			sysname
		if((@diagramname is null) or (@new_diagramname is null))
		begin
			RAISERROR ('Invalid value', 16, 1);
			return -1
		end
	
		EXECUTE AS CALLER;
		select @theId = DATABASE_PRINCIPAL_ID();
		select @IsDbo = IS_MEMBER(N'db_owner'); 
		if(@owner_id is null)
			select @owner_id = @theId;
		REVERT;
	
		select @u_name = USER_NAME(@owner_id)
	
		select @DiagId = diagram_id, @UIDFound = principal_id from dbo.sysdiagrams where principal_id = @owner_id and name = @diagramname 
		if(@DiagId IS NULL or (@IsDbo = 0 and @UIDFound <> @theId))
		begin
			RAISERROR ('Diagram does not exist or you do not have permission.', 16, 1)
			return -3
		end
	
		-- if((@u_name is not null) and (@new_diagramname = @diagramname))	-- nothing will change
		--	return 0;
	
		if(@u_name is null)
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @theId and name = @new_diagramname
		else
			select @DiagIdTarg = diagram_id from dbo.sysdiagrams where principal_id = @owner_id and name = @new_diagramname
	
		if((@DiagIdTarg is not null) and  @DiagId <> @DiagIdTarg)
		begin
			RAISERROR ('The name is already used.', 16, 1);
			return -2
		end		
	
		if(@u_name is null)
			update dbo.sysdiagrams set [name] = @new_diagramname, principal_id = @theId where diagram_id = @DiagId
		else
			update dbo.sysdiagrams set [name] = @new_diagramname where diagram_id = @DiagId
		return 0
	END
	//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.sp_upgraddiagrams
DELIMITER //

	CREATE PROCEDURE dbo.sp_upgraddiagrams
	AS
	BEGIN
		IF OBJECT_ID(N'dbo.sysdiagrams') IS NOT NULL
			return 0;
	
		CREATE TABLE dbo.sysdiagrams
		(
			name sysname NOT NULL,
			principal_id int NOT NULL,	-- we may change it to varbinary(85)
			diagram_id int PRIMARY KEY IDENTITY,
			version int,
	
			definition varbinary(max)
			CONSTRAINT UK_principal_name UNIQUE
			(
				principal_id,
				name
			)
		);


		/* Add this if we need to have some form of extended properties for diagrams */
		/*
		IF OBJECT_ID(N'dbo.sysdiagram_properties') IS NULL
		BEGIN
			CREATE TABLE dbo.sysdiagram_properties
			(
				diagram_id int,
				name sysname,
				value varbinary(max) NOT NULL
			)
		END
		*/

		IF OBJECT_ID(N'dbo.dtproperties') IS NOT NULL
		begin
			insert into dbo.sysdiagrams
			(
				[name],
				[principal_id],
				[version],
				[definition]
			)
			select	 
				convert(sysname, dgnm.[uvalue]),
				DATABASE_PRINCIPAL_ID(N'dbo'),			-- will change to the sid of sa
				0,							-- zero for old format, dgdef.[version],
				dgdef.[lvalue]
			from dbo.[dtproperties] dgnm
				inner join dbo.[dtproperties] dggd on dggd.[property] = 'DtgSchemaGUID' and dggd.[objectid] = dgnm.[objectid]	
				inner join dbo.[dtproperties] dgdef on dgdef.[property] = 'DtgSchemaDATA' and dgdef.[objectid] = dgnm.[objectid]
				
			where dgnm.[property] = 'DtgSchemaNAME' and dggd.[uvalue] like N'_EA3E6268-D998-11CE-9454-00AA00A3F36E_' 
			return 2;
		end
		return 1;
	END
	//
DELIMITER ;

-- Volcando estructura para tabla Colegio.sysdiagrams
CREATE TABLE IF NOT EXISTS "sysdiagrams" (
	"name" NVARCHAR(128) NOT NULL COLLATE 'Modern_Spanish_CI_AS',
	"principal_id" INT NOT NULL,
	"diagram_id" INT NOT NULL,
	"version" INT NULL DEFAULT NULL,
	"definition" VARBINARY NULL DEFAULT NULL,
	PRIMARY KEY ("diagram_id"),
	UNIQUE INDEX "UK_principal_name" ("name", "principal_id")
);

-- Volcando datos para la tabla Colegio.sysdiagrams: -1 rows
/*!40000 ALTER TABLE "sysdiagrams" DISABLE KEYS */;
/*!40000 ALTER TABLE "sysdiagrams" ENABLE KEYS */;

-- Volcando estructura para tabla Colegio.usuarios
CREATE TABLE IF NOT EXISTS "usuarios" (
	"id_usuario" INT NOT NULL,
	"Nombre_y_Apellido" VARCHAR(50) NULL DEFAULT NULL COLLATE 'Modern_Spanish_CI_AS',
	"Usuario" VARCHAR(50) NULL DEFAULT NULL COLLATE 'Modern_Spanish_CI_AS',
	"password" VARCHAR(50) NULL DEFAULT NULL COLLATE 'Modern_Spanish_CI_AS',
	"Estado" VARBINARY NULL DEFAULT NULL,
	PRIMARY KEY ("id_usuario")
);

-- Volcando datos para la tabla Colegio.usuarios: -1 rows
/*!40000 ALTER TABLE "usuarios" DISABLE KEYS */;
INSERT INTO "usuarios" ("id_usuario", "Nombre_y_Apellido", "Usuario", "password", "Estado") VALUES
	(1, 'José Perez', 'Jose_lopez18', '2017', NULL),
	(2, 'Miguel Juarez', 'miguelJaz', '2018', NULL),
	(3, 'Mario', 'Jose18', '2017lopez', NULL),
	(5, 'Alfredo', 'AlfrdoRosas', 'ContraseñaCambio123', NULL),
	(10, 'Luis Angel De Anda', 'AngelNeyra', '123456', NULL),
	(11, 'Perez Juarez Jose ', 'PerezJose', '2025645', NULL);
/*!40000 ALTER TABLE "usuarios" ENABLE KEYS */;

-- Volcando estructura para procedimiento Colegio.usuario_crear
DELIMITER //
create proc usuario_crear
@ap_paterno varchar(50),
@ap_materno varchar(50),
@nombre varchar(50),
@curp varchar(50),
@email varchar(50)
as
if exists (SELECT Curp from alumnos where curp = @curp)
RAISERROR('Ya se cuenta con un usuario con ese dato!!',16,1)
else
insert into alumnos values(@ap_paterno, @ap_materno, @nombre, @curp, @email)//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.validar_usuario
DELIMITER //
create proc validar_usuario
@usuario varchar(50),
@password varchar(50) 
as
select * from usuarios
where Usuario = @usuario and password = @password//
DELIMITER ;

-- Volcando estructura para procedimiento Colegio.ventas_mostrar_tipo_de_documentos_para_insertar_en_ventas
DELIMITER //
CREATE PROC ventas_mostrar_tipo_de_documentos_para_insertar_en_ventas
as
SELECT id_serializacion, Serie, Numero_inicio, Numero_fin +1, Tipo_De_comprobante as COMPROBANTE,
(Serie + ' - ' + Numero_inicio)
FROM serializacion//
DELIMITER ;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
