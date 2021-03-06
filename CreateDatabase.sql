USE [master]
GO
/****** Object:  Database [Parking]    Script Date: 11/4/2014 2:58:37 PM ******/
CREATE DATABASE [Parking] 
GO
ALTER DATABASE [Parking] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Parking] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Parking] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Parking] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Parking] SET ARITHABORT OFF 
GO
ALTER DATABASE [Parking] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Parking] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [Parking] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Parking] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Parking] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Parking] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Parking] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Parking] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Parking] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Parking] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Parking] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Parking] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Parking] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Parking] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Parking] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Parking] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Parking] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Parking] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Parking] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Parking] SET  MULTI_USER 
GO
ALTER DATABASE [Parking] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Parking] SET DB_CHAINING OFF 
GO
USE [Parking]
GO
/****** Object:  Table [dbo].[CocheraFija]    Script Date: 11/4/2014 2:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CocheraFija](
	[EspacioId] [int] NOT NULL,
	[ValorMes] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_CocheraFija] PRIMARY KEY CLUSTERED 
(
	[EspacioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CocheraMovil]    Script Date: 11/4/2014 2:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CocheraMovil](
	[EspacioId] [int] NOT NULL,
	[HoraEntrada] [datetime] NULL,
	[HoraSalida] [datetime] NULL,
 CONSTRAINT [PK_CocheraMovil] PRIMARY KEY CLUSTERED 
(
	[EspacioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Espacio]    Script Date: 11/4/2014 2:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Espacio](
	[EspacioId] [int] NOT NULL,
	[PlayaId] [int] NOT NULL,
	[Codigo] [varchar](250) NOT NULL,
	[Piso] [int] NOT NULL,
	[Tamano] [varchar](250) NOT NULL,
	[VehiculoId] [int] NULL,
 CONSTRAINT [PK_Espacio] PRIMARY KEY CLUSTERED 
(
	[EspacioId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Playa]    Script Date: 11/4/2014 2:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Playa](
	[PlayaId] [int] NOT NULL,
	[Nombre] [varchar](250) NOT NULL,
	[Direccion] [varchar](250) NOT NULL,
	[HoraApertura] [datetime] NOT NULL,
	[HoraCierre] [datetime] NOT NULL,
 CONSTRAINT [PK_Playa] PRIMARY KEY CLUSTERED 
(
	[PlayaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TipoVehiculo]    Script Date: 11/4/2014 2:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TipoVehiculo](
	[TipoVehiculoId] [int] NOT NULL,
	[Nombre] [varchar](250) NOT NULL,
	[ValorHora] [decimal](18, 2) NOT NULL,
	[ValorEstadia] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_TipoVehiculo] PRIMARY KEY CLUSTERED 
(
	[TipoVehiculoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vehiculo]    Script Date: 11/4/2014 2:58:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehiculo](
	[VehiculoId] [int] NOT NULL,
	[Patente] [varchar](250) NOT NULL,
	[Abono] [bit] NOT NULL,
	[TipoVehiculoId] [int] NOT NULL,
 CONSTRAINT [PK_Vehiculo] PRIMARY KEY CLUSTERED 
(
	[VehiculoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CocheraFija] ([EspacioId], [ValorMes]) VALUES (1, CAST(600.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[CocheraFija] ([EspacioId], [ValorMes]) VALUES (3, CAST(600.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[CocheraFija] ([EspacioId], [ValorMes]) VALUES (5, CAST(400.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[CocheraFija] ([EspacioId], [ValorMes]) VALUES (6, CAST(600.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[CocheraFija] ([EspacioId], [ValorMes]) VALUES (7, CAST(600.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[CocheraFija] ([EspacioId], [ValorMes]) VALUES (11, CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[CocheraFija] ([EspacioId], [ValorMes]) VALUES (12, CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[CocheraFija] ([EspacioId], [ValorMes]) VALUES (13, CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[CocheraFija] ([EspacioId], [ValorMes]) VALUES (14, CAST(100.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[CocheraMovil] ([EspacioId], [HoraEntrada], [HoraSalida]) VALUES (2, NULL, NULL)
GO
INSERT [dbo].[CocheraMovil] ([EspacioId], [HoraEntrada], [HoraSalida]) VALUES (4, CAST(0x0000000000F645B4 AS DateTime), CAST(0x0000000000566274 AS DateTime))
GO
INSERT [dbo].[CocheraMovil] ([EspacioId], [HoraEntrada], [HoraSalida]) VALUES (8, CAST(0x0000000000F1F824 AS DateTime), CAST(0x0000000000541E60 AS DateTime))
GO
INSERT [dbo].[CocheraMovil] ([EspacioId], [HoraEntrada], [HoraSalida]) VALUES (9, NULL, NULL)
GO
INSERT [dbo].[CocheraMovil] ([EspacioId], [HoraEntrada], [HoraSalida]) VALUES (10, NULL, NULL)
GO
INSERT [dbo].[Espacio] ([EspacioId], [PlayaId], [Codigo], [Piso], [Tamano], [VehiculoId]) VALUES (1, 1, N'0001', 0, N'Grande', NULL)
GO
INSERT [dbo].[Espacio] ([EspacioId], [PlayaId], [Codigo], [Piso], [Tamano], [VehiculoId]) VALUES (2, 1, N'0002', 0, N'Grande', NULL)
GO
INSERT [dbo].[Espacio] ([EspacioId], [PlayaId], [Codigo], [Piso], [Tamano], [VehiculoId]) VALUES (3, 1, N'0003', 0, N'Mediano', NULL)
GO
INSERT [dbo].[Espacio] ([EspacioId], [PlayaId], [Codigo], [Piso], [Tamano], [VehiculoId]) VALUES (4, 1, N'0004', 0, N'Mediano', 16)
GO
INSERT [dbo].[Espacio] ([EspacioId], [PlayaId], [Codigo], [Piso], [Tamano], [VehiculoId]) VALUES (5, 1, N'0005', 0, N'Chico', NULL)
GO
INSERT [dbo].[Espacio] ([EspacioId], [PlayaId], [Codigo], [Piso], [Tamano], [VehiculoId]) VALUES (6, 1, N'0006', 1, N'Grande', NULL)
GO
INSERT [dbo].[Espacio] ([EspacioId], [PlayaId], [Codigo], [Piso], [Tamano], [VehiculoId]) VALUES (7, 1, N'0007', 1, N'Grande', 14)
GO
INSERT [dbo].[Espacio] ([EspacioId], [PlayaId], [Codigo], [Piso], [Tamano], [VehiculoId]) VALUES (8, 1, N'0008', 1, N'Mediano', 13)
GO
INSERT [dbo].[Espacio] ([EspacioId], [PlayaId], [Codigo], [Piso], [Tamano], [VehiculoId]) VALUES (9, 1, N'0009', 1, N'Mediano', NULL)
GO
INSERT [dbo].[Espacio] ([EspacioId], [PlayaId], [Codigo], [Piso], [Tamano], [VehiculoId]) VALUES (10, 1, N'0010', 1, N'Chico', NULL)
GO
INSERT [dbo].[Espacio] ([EspacioId], [PlayaId], [Codigo], [Piso], [Tamano], [VehiculoId]) VALUES (11, 3, N'00-01', 0, N'Mediano', NULL)
GO
INSERT [dbo].[Espacio] ([EspacioId], [PlayaId], [Codigo], [Piso], [Tamano], [VehiculoId]) VALUES (12, 3, N'01-01', 1, N'Mediano', NULL)
GO
INSERT [dbo].[Espacio] ([EspacioId], [PlayaId], [Codigo], [Piso], [Tamano], [VehiculoId]) VALUES (13, 3, N'02-01', 2, N'Chico', NULL)
GO
INSERT [dbo].[Espacio] ([EspacioId], [PlayaId], [Codigo], [Piso], [Tamano], [VehiculoId]) VALUES (14, 3, N'03-01', 3, N'Chico', 15)
GO
INSERT [dbo].[Playa] ([PlayaId], [Nombre], [Direccion], [HoraApertura], [HoraCierre]) VALUES (1, N'Estacionamiento UAI', N'San Juan 951', CAST(0x0000A3D10001EC30 AS DateTime), CAST(0x0000A53E018A2270 AS DateTime))
GO
INSERT [dbo].[Playa] ([PlayaId], [Nombre], [Direccion], [HoraApertura], [HoraCierre]) VALUES (2, N'Estacionamiento Hatten', N'San Juan 851', CAST(0x0000A3D1009450C0 AS DateTime), CAST(0x0000A53E017B0740 AS DateTime))
GO
INSERT [dbo].[Playa] ([PlayaId], [Nombre], [Direccion], [HoraApertura], [HoraCierre]) VALUES (3, N'Estacionamiento PISOS', N'Donde quieras 1200', CAST(0x0000000000A4CB80 AS DateTime), CAST(0x00000000017B0740 AS DateTime))
GO
INSERT [dbo].[TipoVehiculo] ([TipoVehiculoId], [Nombre], [ValorHora], [ValorEstadia]) VALUES (1, N'Automovil', CAST(60.00 AS Decimal(18, 2)), CAST(400.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TipoVehiculo] ([TipoVehiculoId], [Nombre], [ValorHora], [ValorEstadia]) VALUES (2, N'Moto', CAST(30.00 AS Decimal(18, 2)), CAST(200.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[TipoVehiculo] ([TipoVehiculoId], [Nombre], [ValorHora], [ValorEstadia]) VALUES (3, N'Camioneta', CAST(80.00 AS Decimal(18, 2)), CAST(500.00 AS Decimal(18, 2)))
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (1, N'ZZZ-666', 0, 1)
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (2, N'ojj-888', 1, 3)
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (3, N'HHH-777', 1, 3)
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (4, N'jjj-999', 1, 1)
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (5, N'JJJ-000', 0, 1)
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (6, N'iii-999', 0, 3)
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (7, N'kkk-555', 0, 1)
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (8, N'JJJ-666', 1, 1)
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (9, N'jjj-888', 0, 1)
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (10, N'jjj-988', 1, 1)
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (11, N'asd-888', 0, 1)
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (12, N'ALK-680', 0, 2)
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (13, N'LLL-222', 1, 1)
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (14, N'LLL-286', 0, 3)
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (15, N'ASD-156', 1, 2)
GO
INSERT [dbo].[Vehiculo] ([VehiculoId], [Patente], [Abono], [TipoVehiculoId]) VALUES (16, N'XXX-123', 0, 1)
GO
ALTER TABLE [dbo].[Espacio]  WITH CHECK ADD  CONSTRAINT [FK_Espacio_Playa] FOREIGN KEY([PlayaId])
REFERENCES [dbo].[Playa] ([PlayaId])
GO
ALTER TABLE [dbo].[Espacio] CHECK CONSTRAINT [FK_Espacio_Playa]
GO
ALTER TABLE [dbo].[Espacio]  WITH CHECK ADD  CONSTRAINT [FK_Espacio_Vehiculo] FOREIGN KEY([VehiculoId])
REFERENCES [dbo].[Vehiculo] ([VehiculoId])
GO
ALTER TABLE [dbo].[Espacio] CHECK CONSTRAINT [FK_Espacio_Vehiculo]
GO
ALTER TABLE [dbo].[Vehiculo]  WITH CHECK ADD  CONSTRAINT [FK_Vehiculo_TipoVehiculo] FOREIGN KEY([TipoVehiculoId])
REFERENCES [dbo].[TipoVehiculo] ([TipoVehiculoId])
GO
ALTER TABLE [dbo].[Vehiculo] CHECK CONSTRAINT [FK_Vehiculo_TipoVehiculo]
GO
USE [master]
GO
ALTER DATABASE [Parking] SET  READ_WRITE 
GO
