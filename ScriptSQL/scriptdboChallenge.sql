USE [master]
GO
/****** Object:  Database [dboChallenge]    Script Date: 26/09/2021 10:00:28 ******/
CREATE DATABASE [dboChallenge]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'dboChallenge', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dboChallenge.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'dboChallenge_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\dboChallenge_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [dboChallenge] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [dboChallenge].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [dboChallenge] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [dboChallenge] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [dboChallenge] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [dboChallenge] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [dboChallenge] SET ARITHABORT OFF 
GO
ALTER DATABASE [dboChallenge] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [dboChallenge] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [dboChallenge] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [dboChallenge] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [dboChallenge] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [dboChallenge] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [dboChallenge] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [dboChallenge] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [dboChallenge] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [dboChallenge] SET  ENABLE_BROKER 
GO
ALTER DATABASE [dboChallenge] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [dboChallenge] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [dboChallenge] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [dboChallenge] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [dboChallenge] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [dboChallenge] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [dboChallenge] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [dboChallenge] SET RECOVERY FULL 
GO
ALTER DATABASE [dboChallenge] SET  MULTI_USER 
GO
ALTER DATABASE [dboChallenge] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [dboChallenge] SET DB_CHAINING OFF 
GO
ALTER DATABASE [dboChallenge] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [dboChallenge] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [dboChallenge] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [dboChallenge] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'dboChallenge', N'ON'
GO
ALTER DATABASE [dboChallenge] SET QUERY_STORE = OFF
GO
USE [dboChallenge]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 26/09/2021 10:00:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[NumeroCategoria] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[NumeroCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Historial]    Script Date: 26/09/2021 10:00:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Historial](
	[IdInicio] [bigint] IDENTITY(1,1) NOT NULL,
	[NombreParticipante] [varchar](50) NOT NULL,
	[RondaAlcanzada] [int] NOT NULL,
	[PremioConseguido] [decimal](18, 3) NOT NULL,
	[RetiroVoluntario] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdInicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Pregunta]    Script Date: 26/09/2021 10:00:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pregunta](
	[IdPregunta] [int] IDENTITY(1,1) NOT NULL,
	[TextoPregunta] [varchar](200) NOT NULL,
	[NumCategoria] [int] NOT NULL,
 CONSTRAINT [PK__Pregunta__754EC09E9EDF9723] PRIMARY KEY CLUSTERED 
(
	[IdPregunta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[premio]    Script Date: 26/09/2021 10:00:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[premio](
	[IdPremio] [int] IDENTITY(1,1) NOT NULL,
	[Puntos] [int] NOT NULL,
	[IdCategotia] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Respuestas]    Script Date: 26/09/2021 10:00:32 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Respuestas](
	[IdRespuesta] [int] IDENTITY(1,1) NOT NULL,
	[TextoRespuesta] [varchar](200) NOT NULL,
	[IdPregunta] [int] NOT NULL,
	[Correcta] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdRespuesta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categoria] ([NumeroCategoria]) VALUES (1)
INSERT [dbo].[Categoria] ([NumeroCategoria]) VALUES (2)
INSERT [dbo].[Categoria] ([NumeroCategoria]) VALUES (3)
INSERT [dbo].[Categoria] ([NumeroCategoria]) VALUES (4)
INSERT [dbo].[Categoria] ([NumeroCategoria]) VALUES (5)
GO
SET IDENTITY_INSERT [dbo].[Historial] ON 

INSERT [dbo].[Historial] ([IdInicio], [NombreParticipante], [RondaAlcanzada], [PremioConseguido], [RetiroVoluntario]) VALUES (1, N'tthdb', 3, CAST(30000.000 AS Decimal(18, 3)), 0)
INSERT [dbo].[Historial] ([IdInicio], [NombreParticipante], [RondaAlcanzada], [PremioConseguido], [RetiroVoluntario]) VALUES (2, N'tntnt', 1, CAST(0.000 AS Decimal(18, 3)), 1)
INSERT [dbo].[Historial] ([IdInicio], [NombreParticipante], [RondaAlcanzada], [PremioConseguido], [RetiroVoluntario]) VALUES (3, N'rwrgerbe', 5, CAST(150000.000 AS Decimal(18, 3)), 0)
INSERT [dbo].[Historial] ([IdInicio], [NombreParticipante], [RondaAlcanzada], [PremioConseguido], [RetiroVoluntario]) VALUES (4, N'Juan ', 5, CAST(100000.000 AS Decimal(18, 3)), 1)
INSERT [dbo].[Historial] ([IdInicio], [NombreParticipante], [RondaAlcanzada], [PremioConseguido], [RetiroVoluntario]) VALUES (5, N'ndhrtbd', 2, CAST(10000.000 AS Decimal(18, 3)), 0)
SET IDENTITY_INSERT [dbo].[Historial] OFF
GO
SET IDENTITY_INSERT [dbo].[Pregunta] ON 

INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (1, N'¿Cual es la capital de Antioquia?', 1)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (2, N'¿Donde naciò Simon Bolivar?', 1)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (3, N'¿Que es claustrofobia?', 1)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (4, N'¿Quien escribió ''La Odisea''?', 1)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (5, N'¿Cómo se llama la Reina del Reino Unido?', 1)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (6, N'¿Cual es el río mas largo del mundo?', 2)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (7, N'¿Cuando Inició la Segunda Guerra Mundial?', 2)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (8, N'¿Cuando terminó la Segunda Guerra Mundial?', 2)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (9, N'¿Cuál es el nombre de la lengua oficial en China?', 2)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (10, N'¿En que país se encuantra el Taj Mahal?', 2)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (11, N'¿Cual fue el primer metal empleado por el Hombre?', 3)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (12, N'¿Cómo se llama la estación espacial Rusa?', 3)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (13, N'¿A qué país pertenece la ciudad de Varsovia?', 3)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (14, N'¿Cuánto duró la Guerra de los Cien Años?', 3)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (15, N'¿En que país queda la casa Rosada?', 3)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (16, N'¿Cómo se llama la protagonista de la saga de videojuegos "The Legend of Zelda"?', 4)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (17, N'¿Cual fue el primer simbionte que conoció Peter Parker (Spiderman)?', 4)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (18, N' ¿De qué estilo arquitectónico es la catedral de Notre Dame?', 4)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (19, N'¿A qué banda de música metal pertenece el disco Master of Puppets?', 4)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (20, N'¿Qué gran artista es conocido por haber pintado la Capilla Sixtina?', 4)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (21, N'¿Cual fue la primera aparicion de Mario en un videojuego de Nintendo?', 5)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (22, N'¿Con que nombre se conoce a la mafia mas conocida de Japón?', 5)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (23, N'¿Cuál es la velocidad de la luz?', 5)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (24, N'¿Cómo se llama el primer país en colonizar el territorio de lo que hoy se conoce como Alaska?', 5)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (25, N'¿Cuál fue la causa de la muerte de Kurt Cobain, líder de la banda Nirvana?', 5)
INSERT [dbo].[Pregunta] ([IdPregunta], [TextoPregunta], [NumCategoria]) VALUES (27, N'erhrhrtergre', 1)
SET IDENTITY_INSERT [dbo].[Pregunta] OFF
GO
SET IDENTITY_INSERT [dbo].[premio] ON 

INSERT [dbo].[premio] ([IdPremio], [Puntos], [IdCategotia]) VALUES (1, 10000, 1)
INSERT [dbo].[premio] ([IdPremio], [Puntos], [IdCategotia]) VALUES (2, 20000, 2)
INSERT [dbo].[premio] ([IdPremio], [Puntos], [IdCategotia]) VALUES (3, 30000, 3)
INSERT [dbo].[premio] ([IdPremio], [Puntos], [IdCategotia]) VALUES (4, 40000, 4)
INSERT [dbo].[premio] ([IdPremio], [Puntos], [IdCategotia]) VALUES (5, 50000, 5)
SET IDENTITY_INSERT [dbo].[premio] OFF
GO
SET IDENTITY_INSERT [dbo].[Respuestas] ON 

INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (5, N'Cali', 1, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (6, N'Bogotà', 1, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (7, N'Medellìn', 1, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (8, N'Barranquilla', 1, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (9, N'Colombia', 2, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (10, N'Venezuela', 2, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (11, N'España', 2, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (12, N'Ecuador', 2, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (13, N'Miedo a las arañas', 3, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (14, N'Miedo a las alturas', 3, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (15, N'Miedo a la oscuridad', 3, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (16, N'Miedo a los espacios pequeños y cerrados', 3, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (17, N'Gabriel Garcia Marquez', 4, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (18, N'Dante', 4, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (19, N'Homero', 4, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (20, N'Miguel De Cervantes', 4, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (21, N'Margarita II', 5, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (22, N'Isabel II', 5, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (23, N'Kersti Kaljulaid', 5, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (24, N'Julia IV', 5, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (25, N'Nilo', 6, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (26, N'Amazonas', 6, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (27, N'Cauca', 6, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (28, N'Mission Mississippi', 6, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (29, N'1943', 7, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (30, N'1944', 7, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (31, N'1939', 7, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (32, N'1945', 7, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (33, N'1939', 8, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (34, N'1945', 8, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (35, N'1946', 8, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (36, N'1944', 8, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (37, N'Mandarín', 9, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (38, N'Chino', 9, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (39, N'Orok', 9, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (40, N'Nivejí', 9, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (41, N'Colombia', 10, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (42, N'Pakistan', 10, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (43, N'India', 10, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (44, N'Marruecos', 10, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (45, N'Cobre', 11, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (46, N'Oro', 11, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (47, N'Hierro', 11, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (48, N'Aluminio', 11, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (49, N'Estación Espacial Internacional', 12, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (50, N'Mir', 12, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (51, N'Tiangong-1', 12, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (52, N'Prostranstvennaya stantsiya', 12, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (53, N'Croacia', 13, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (54, N'Irlanda', 13, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (55, N'Finlandia', 13, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (56, N'Polonia', 13, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (57, N'116', 14, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (58, N'100', 14, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (59, N'104', 14, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (60, N'111', 14, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (61, N'Perú', 15, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (62, N'Chile', 15, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (63, N'Argentina', 15, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (64, N'Mexico', 15, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (65, N'Link', 16, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (66, N'Zelda', 16, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (67, N'Cameron', 16, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (68, N'James', 16, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (69, N'Dr Octopus', 17, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (70, N'Venom', 17, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (71, N'Carnage', 17, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (72, N'Duende Verde', 17, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (73, N'Clásico', 18, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (74, N'Romántico', 18, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (75, N'Gótico', 18, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (76, N'Neoclásico', 18, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (77, N'Queen', 19, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (78, N'Metallica', 19, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (79, N'The Beatles', 19, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (80, N'The Rolling Stones', 19, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (81, N'Da Vinci', 20, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (82, N'Dalí', 20, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (83, N'Picasso', 20, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (84, N'Miguel Angel', 20, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (85, N'Donkey Kong (1981)', 21, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (86, N'Donkey Kong Jr', 21, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (87, N'Wrecking Crew (1985)', 21, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (88, N'Super Mario Bros (1985)', 21, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (89, N'Tríadas', 22, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (90, N'Yakuza', 22, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (91, N'D-Company', 22, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (92, N'Shigeharu Shirai', 22, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (93, N'299.792.458 km/s', 23, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (94, N'300.000.000 km/s', 23, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (95, N'250.000.784 km/s', 23, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (96, N'305.783.150 km/s', 23, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (97, N'Inglaterra', 24, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (98, N'Francia', 24, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (99, N'España', 24, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (100, N'Rusia', 24, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (101, N'Infarto', 25, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (102, N'Incendio', 25, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (103, N'Suicidio', 25, 1)
GO
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (104, N'Homicidio', 25, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (108, N'erhbertg', 27, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (109, N'ebrebr', 27, 0)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (110, N'rgege', 27, 1)
INSERT [dbo].[Respuestas] ([IdRespuesta], [TextoRespuesta], [IdPregunta], [Correcta]) VALUES (111, N'rbrbrb', 27, 1)
SET IDENTITY_INSERT [dbo].[Respuestas] OFF
GO
ALTER TABLE [dbo].[Pregunta]  WITH CHECK ADD  CONSTRAINT [FK__Pregunta__NumCat__3A81B327] FOREIGN KEY([NumCategoria])
REFERENCES [dbo].[Categoria] ([NumeroCategoria])
GO
ALTER TABLE [dbo].[Pregunta] CHECK CONSTRAINT [FK__Pregunta__NumCat__3A81B327]
GO
ALTER TABLE [dbo].[premio]  WITH CHECK ADD FOREIGN KEY([IdCategotia])
REFERENCES [dbo].[Categoria] ([NumeroCategoria])
GO
ALTER TABLE [dbo].[Respuestas]  WITH CHECK ADD  CONSTRAINT [FK__Respuesta__IdPre__3D5E1FD2] FOREIGN KEY([IdPregunta])
REFERENCES [dbo].[Pregunta] ([IdPregunta])
GO
ALTER TABLE [dbo].[Respuestas] CHECK CONSTRAINT [FK__Respuesta__IdPre__3D5E1FD2]
GO
USE [master]
GO
ALTER DATABASE [dboChallenge] SET  READ_WRITE 
GO
