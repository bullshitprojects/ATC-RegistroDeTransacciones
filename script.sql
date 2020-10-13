USE [master]
GO
/****** Object:  Database [RegistroDeTransacciones]    Script Date: 12/10/2020 22:18:29 ******/
CREATE DATABASE [RegistroDeTransacciones]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'RegistroDeTransacciones', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RegistroDeTransacciones.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'RegistroDeTransacciones_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\RegistroDeTransacciones_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [RegistroDeTransacciones] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [RegistroDeTransacciones].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [RegistroDeTransacciones] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET ARITHABORT OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [RegistroDeTransacciones] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [RegistroDeTransacciones] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [RegistroDeTransacciones] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET  ENABLE_BROKER 
GO
ALTER DATABASE [RegistroDeTransacciones] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [RegistroDeTransacciones] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [RegistroDeTransacciones] SET  MULTI_USER 
GO
ALTER DATABASE [RegistroDeTransacciones] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [RegistroDeTransacciones] SET DB_CHAINING OFF 
GO
ALTER DATABASE [RegistroDeTransacciones] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [RegistroDeTransacciones] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [RegistroDeTransacciones] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [RegistroDeTransacciones] SET QUERY_STORE = OFF
GO
USE [RegistroDeTransacciones]
GO
/****** Object:  Table [dbo].[catalogo_cuenta]    Script Date: 12/10/2020 22:18:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[catalogo_cuenta](
	[id_catalogo_cuenta] [int] IDENTITY(1,1) NOT NULL,
	[naturaleza] [varchar](8) NOT NULL,
	[codigo] [varchar](10) NOT NULL,
	[cuenta] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[empresa]    Script Date: 12/10/2020 22:18:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[empresa](
	[id_empresa] [int] IDENTITY(1,1) NOT NULL,
	[nEmpresa] [varchar](25) NOT NULL,
	[nitEmpresa] [varchar](20) NOT NULL,
	[razonSocial] [varchar](30) NOT NULL,
	[email] [varchar](50) NOT NULL,
	[usuario] [varchar](20) NOT NULL,
	[contra] [varchar](50) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LibroDiario]    Script Date: 12/10/2020 22:18:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LibroDiario](
	[id_libro_diario] [int] IDENTITY(1,1) NOT NULL,
	[fecha] [varchar](255) NULL,
	[asiento] [varchar](20) NULL,
	[orden] [varchar](20) NULL,
	[codigo] [varchar](20) NULL,
	[cuenta] [varchar](100) NULL,
	[concepto] [varchar](100) NULL,
	[parcial] [real] NULL,
	[debe] [real] NULL,
	[haber] [real] NULL,
PRIMARY KEY CLUSTERED 
(
	[id_libro_diario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [RegistroDeTransacciones] SET  READ_WRITE 
GO
