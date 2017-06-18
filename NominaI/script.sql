USE [master]
GO
/****** Object:  Database [nomina]    Script Date: 6/18/2017 4:50:25 AM ******/
CREATE DATABASE [nomina] ON  PRIMARY 
( NAME = N'nomina', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\nomina.mdf' , SIZE = 2304KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'nomina_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\nomina_log.LDF' , SIZE = 768KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [nomina] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [nomina].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [nomina] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [nomina] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [nomina] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [nomina] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [nomina] SET ARITHABORT OFF 
GO
ALTER DATABASE [nomina] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [nomina] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [nomina] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [nomina] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [nomina] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [nomina] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [nomina] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [nomina] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [nomina] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [nomina] SET  ENABLE_BROKER 
GO
ALTER DATABASE [nomina] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [nomina] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [nomina] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [nomina] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [nomina] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [nomina] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [nomina] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [nomina] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [nomina] SET  MULTI_USER 
GO
ALTER DATABASE [nomina] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [nomina] SET DB_CHAINING OFF 
GO
USE [nomina]
GO
/****** Object:  Table [dbo].[accesos]    Script Date: 6/18/2017 4:50:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[accesos](
	[Id_acceso] [int] IDENTITY(1,1) NOT NULL,
	[Id_menu] [int] NOT NULL,
	[Id_usuario] [int] NOT NULL,
	[estado] [bit] NULL,
	[menu_padre] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_acceso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Departamentos]    Script Date: 6/18/2017 4:50:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Departamentos](
	[Id_departamento] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
 CONSTRAINT [PK_Departamentos] PRIMARY KEY CLUSTERED 
(
	[Id_departamento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleado_nomina]    Script Date: 6/18/2017 4:50:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleado_nomina](
	[id_nomina] [int] IDENTITY(1,1) NOT NULL,
	[id_empleado] [int] NOT NULL,
 CONSTRAINT [PK_Empleado_nomina] PRIMARY KEY CLUSTERED 
(
	[id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 6/18/2017 4:50:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Id_empleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombres] [nvarchar](50) NULL,
	[Cedula] [nchar](13) NULL,
	[Id_departamento] [int] NULL,
	[Id_puesto] [int] NULL,
	[Salario_mensual] [money] NULL,
	[Responsable] [bit] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[Id_empleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Horas_extras]    Script Date: 6/18/2017 4:50:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Horas_extras](
	[Id_Horas_extras] [int] IDENTITY(1,1) NOT NULL,
	[Cantidad_horas_extras] [int] NULL,
	[Fecha] [smalldatetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_Horas_extras] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[menu]    Script Date: 6/18/2017 4:50:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[menu](
	[Id_menu] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [varchar](30) NOT NULL,
	[nivel] [int] NULL,
	[estado] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_menu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nomina]    Script Date: 6/18/2017 4:50:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nomina](
	[Id_nomina] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [smalldatetime] NULL,
 CONSTRAINT [PK_Nomina] PRIMARY KEY CLUSTERED 
(
	[Id_nomina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Puestos]    Script Date: 6/18/2017 4:50:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puestos](
	[Id_puesto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Salario_minimo] [money] NULL,
	[Salario_maximo] [money] NULL,
	[Id_departamento] [int] NULL,
 CONSTRAINT [PK_Puestos] PRIMARY KEY CLUSTERED 
(
	[Id_puesto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registro_de_transacciones]    Script Date: 6/18/2017 4:50:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registro_de_transacciones](
	[Id_transaccion] [int] IDENTITY(1,1) NOT NULL,
	[Id_empleado] [int] NULL,
	[Id_ingreso] [int] NULL,
	[Tipo_de_transaccion] [nvarchar](50) NULL,
	[Fecha] [smalldatetime] NULL,
	[Monto] [money] NULL,
	[Estado] [nvarchar](50) NULL,
	[Id_deducciones] [int] NULL,
 CONSTRAINT [PK_Registro_de_transacciones] PRIMARY KEY CLUSTERED 
(
	[Id_transaccion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos_de_deducciones]    Script Date: 6/18/2017 4:50:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_de_deducciones](
	[Id_tipos_de_deducciones] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Estado] [nvarchar](50) NULL,
	[Porcentaje] [decimal](2, 2) NULL,
	[Id_puestos] [int] NULL,
 CONSTRAINT [PK_Tipos_de_deducciones] PRIMARY KEY CLUSTERED 
(
	[Id_tipos_de_deducciones] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tipos_de_ingresos]    Script Date: 6/18/2017 4:50:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tipos_de_ingresos](
	[Id_tipos_de_ingresos] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NULL,
	[Estado] [nvarchar](50) NULL,
	[Porcentaje] [decimal](2, 2) NULL,
 CONSTRAINT [PK_Tipos_de_ingresos] PRIMARY KEY CLUSTERED 
(
	[Id_tipos_de_ingresos] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 6/18/2017 4:50:25 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id_usuario] [int] IDENTITY(1,1) NOT NULL,
	[usuario] [varchar](50) NOT NULL,
	[contrasena] [varchar](50) NOT NULL,
	[Id_empleado] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[accesos] ON 
GO
INSERT [dbo].[accesos] ([Id_acceso], [Id_menu], [Id_usuario], [estado], [menu_padre]) VALUES (1, 1, 1, 1, NULL)
GO
INSERT [dbo].[accesos] ([Id_acceso], [Id_menu], [Id_usuario], [estado], [menu_padre]) VALUES (3, 2, 1, 1, 1)
GO
INSERT [dbo].[accesos] ([Id_acceso], [Id_menu], [Id_usuario], [estado], [menu_padre]) VALUES (4, 3, 1, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[accesos] OFF
GO
SET IDENTITY_INSERT [dbo].[Departamentos] ON 
GO
INSERT [dbo].[Departamentos] ([Id_departamento], [Nombre]) VALUES (1, N'Informatica')
GO
SET IDENTITY_INSERT [dbo].[Departamentos] OFF
GO
SET IDENTITY_INSERT [dbo].[Empleados] ON 
GO
INSERT [dbo].[Empleados] ([Id_empleado], [Nombres], [Cedula], [Id_departamento], [Id_puesto], [Salario_mensual], [Responsable]) VALUES (1, N'Emry Rosario', N'40100377055  ', 1, 1, 30000.0000, 0)
GO
SET IDENTITY_INSERT [dbo].[Empleados] OFF
GO
SET IDENTITY_INSERT [dbo].[menu] ON 
GO
INSERT [dbo].[menu] ([Id_menu], [descripcion], [nivel], [estado]) VALUES (1, N'Gestion Tipos Ingresos', 1, 1)
GO
INSERT [dbo].[menu] ([Id_menu], [descripcion], [nivel], [estado]) VALUES (2, N'Crear Tipo de Ingresos', 2, 1)
GO
INSERT [dbo].[menu] ([Id_menu], [descripcion], [nivel], [estado]) VALUES (3, N'Ver Tipo de Ingresos', 2, 1)
GO
INSERT [dbo].[menu] ([Id_menu], [descripcion], [nivel], [estado]) VALUES (8, N'Modificar Tipo Usuario', 2, NULL)
GO
SET IDENTITY_INSERT [dbo].[menu] OFF
GO
SET IDENTITY_INSERT [dbo].[Puestos] ON 
GO
INSERT [dbo].[Puestos] ([Id_puesto], [Nombre], [Salario_minimo], [Salario_maximo], [Id_departamento]) VALUES (1, N'Programador', 30000.0000, 45000.0000, 1)
GO
SET IDENTITY_INSERT [dbo].[Puestos] OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 
GO
INSERT [dbo].[Usuarios] ([Id_usuario], [usuario], [contrasena], [Id_empleado]) VALUES (1, N'erosario', N'123456', 1)
GO
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
ALTER TABLE [dbo].[accesos] ADD  DEFAULT ((1)) FOR [estado]
GO
ALTER TABLE [dbo].[Empleados] ADD  DEFAULT ((0)) FOR [Responsable]
GO
ALTER TABLE [dbo].[accesos]  WITH CHECK ADD FOREIGN KEY([Id_menu])
REFERENCES [dbo].[menu] ([Id_menu])
GO
ALTER TABLE [dbo].[accesos]  WITH CHECK ADD FOREIGN KEY([Id_usuario])
REFERENCES [dbo].[Usuarios] ([Id_usuario])
GO
ALTER TABLE [dbo].[accesos]  WITH CHECK ADD FOREIGN KEY([menu_padre])
REFERENCES [dbo].[menu] ([Id_menu])
GO
ALTER TABLE [dbo].[Empleado_nomina]  WITH CHECK ADD FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleados] ([Id_empleado])
GO
ALTER TABLE [dbo].[Empleado_nomina]  WITH CHECK ADD FOREIGN KEY([id_nomina])
REFERENCES [dbo].[Nomina] ([Id_nomina])
GO
ALTER TABLE [dbo].[Empleado_nomina]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_nomina_Empleados] FOREIGN KEY([id_empleado])
REFERENCES [dbo].[Empleados] ([Id_empleado])
GO
ALTER TABLE [dbo].[Empleado_nomina] CHECK CONSTRAINT [FK_Empleado_nomina_Empleados]
GO
ALTER TABLE [dbo].[Empleado_nomina]  WITH CHECK ADD  CONSTRAINT [FK_Empleado_nomina_Nomina] FOREIGN KEY([id_nomina])
REFERENCES [dbo].[Nomina] ([Id_nomina])
GO
ALTER TABLE [dbo].[Empleado_nomina] CHECK CONSTRAINT [FK_Empleado_nomina_Nomina]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Departamentos] FOREIGN KEY([Id_departamento])
REFERENCES [dbo].[Departamentos] ([Id_departamento])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Departamentos]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Puestos] FOREIGN KEY([Id_puesto])
REFERENCES [dbo].[Puestos] ([Id_puesto])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Puestos]
GO
ALTER TABLE [dbo].[Puestos]  WITH CHECK ADD FOREIGN KEY([Id_departamento])
REFERENCES [dbo].[Departamentos] ([Id_departamento])
GO
ALTER TABLE [dbo].[Puestos]  WITH CHECK ADD FOREIGN KEY([Id_departamento])
REFERENCES [dbo].[Departamentos] ([Id_departamento])
GO
ALTER TABLE [dbo].[Puestos]  WITH CHECK ADD FOREIGN KEY([Id_departamento])
REFERENCES [dbo].[Departamentos] ([Id_departamento])
GO
ALTER TABLE [dbo].[Puestos]  WITH CHECK ADD FOREIGN KEY([Id_departamento])
REFERENCES [dbo].[Departamentos] ([Id_departamento])
GO
ALTER TABLE [dbo].[Registro_de_transacciones]  WITH CHECK ADD  CONSTRAINT [FK_Registro_de_transacciones_Empleados] FOREIGN KEY([Id_empleado])
REFERENCES [dbo].[Empleados] ([Id_empleado])
GO
ALTER TABLE [dbo].[Registro_de_transacciones] CHECK CONSTRAINT [FK_Registro_de_transacciones_Empleados]
GO
ALTER TABLE [dbo].[Registro_de_transacciones]  WITH CHECK ADD  CONSTRAINT [FK_Registro_de_transacciones_Tipos_de_deducciones] FOREIGN KEY([Id_deducciones])
REFERENCES [dbo].[Tipos_de_deducciones] ([Id_tipos_de_deducciones])
GO
ALTER TABLE [dbo].[Registro_de_transacciones] CHECK CONSTRAINT [FK_Registro_de_transacciones_Tipos_de_deducciones]
GO
ALTER TABLE [dbo].[Registro_de_transacciones]  WITH CHECK ADD  CONSTRAINT [FK_Registro_de_transacciones_Tipos_de_ingresos] FOREIGN KEY([Id_ingreso])
REFERENCES [dbo].[Tipos_de_ingresos] ([Id_tipos_de_ingresos])
GO
ALTER TABLE [dbo].[Registro_de_transacciones] CHECK CONSTRAINT [FK_Registro_de_transacciones_Tipos_de_ingresos]
GO
ALTER TABLE [dbo].[Tipos_de_deducciones]  WITH CHECK ADD FOREIGN KEY([Id_puestos])
REFERENCES [dbo].[Puestos] ([Id_puesto])
GO
ALTER TABLE [dbo].[Tipos_de_deducciones]  WITH CHECK ADD FOREIGN KEY([Id_puestos])
REFERENCES [dbo].[Puestos] ([Id_puesto])
GO
ALTER TABLE [dbo].[Tipos_de_deducciones]  WITH CHECK ADD FOREIGN KEY([Id_puestos])
REFERENCES [dbo].[Puestos] ([Id_puesto])
GO
ALTER TABLE [dbo].[Tipos_de_deducciones]  WITH CHECK ADD FOREIGN KEY([Id_puestos])
REFERENCES [dbo].[Puestos] ([Id_puesto])
GO
ALTER TABLE [dbo].[Usuarios]  WITH CHECK ADD FOREIGN KEY([Id_empleado])
REFERENCES [dbo].[Empleados] ([Id_empleado])
GO
USE [master]
GO
ALTER DATABASE [nomina] SET  READ_WRITE 
GO
