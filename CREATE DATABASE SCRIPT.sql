USE [master]
GO

/****** Object:  Database [IntrTask]    Script Date: 9/9/2021 11:56:05 AM ******/
CREATE DATABASE [IntrTask]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'IntrTask', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\IntrTask.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'IntrTask_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\IntrTask_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [IntrTask].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [IntrTask] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [IntrTask] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [IntrTask] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [IntrTask] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [IntrTask] SET ARITHABORT OFF 
GO

ALTER DATABASE [IntrTask] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [IntrTask] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [IntrTask] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [IntrTask] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [IntrTask] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [IntrTask] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [IntrTask] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [IntrTask] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [IntrTask] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [IntrTask] SET  DISABLE_BROKER 
GO

ALTER DATABASE [IntrTask] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [IntrTask] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [IntrTask] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [IntrTask] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [IntrTask] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [IntrTask] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [IntrTask] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [IntrTask] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [IntrTask] SET  MULTI_USER 
GO

ALTER DATABASE [IntrTask] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [IntrTask] SET DB_CHAINING OFF 
GO

ALTER DATABASE [IntrTask] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [IntrTask] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [IntrTask] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [IntrTask] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [IntrTask] SET QUERY_STORE = OFF
GO

ALTER DATABASE [IntrTask] SET  READ_WRITE 
GO


