USE [master]
GO

/****** Object:  Database [AttendanceSystem]    Script Date: 9/14/2023 11:24:42 PM ******/
CREATE DATABASE [AttendanceSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'AttendanceSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AttendanceSystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'AttendanceSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\AttendanceSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [AttendanceSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [AttendanceSystem] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [AttendanceSystem] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [AttendanceSystem] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [AttendanceSystem] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [AttendanceSystem] SET ARITHABORT OFF 
GO

ALTER DATABASE [AttendanceSystem] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [AttendanceSystem] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [AttendanceSystem] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [AttendanceSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [AttendanceSystem] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [AttendanceSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [AttendanceSystem] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [AttendanceSystem] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [AttendanceSystem] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [AttendanceSystem] SET  ENABLE_BROKER 
GO

ALTER DATABASE [AttendanceSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [AttendanceSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [AttendanceSystem] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [AttendanceSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [AttendanceSystem] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [AttendanceSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [AttendanceSystem] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [AttendanceSystem] SET RECOVERY FULL 
GO

ALTER DATABASE [AttendanceSystem] SET  MULTI_USER 
GO

ALTER DATABASE [AttendanceSystem] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [AttendanceSystem] SET DB_CHAINING OFF 
GO

ALTER DATABASE [AttendanceSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [AttendanceSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [AttendanceSystem] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [AttendanceSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [AttendanceSystem] SET QUERY_STORE = OFF
GO

ALTER DATABASE [AttendanceSystem] SET  READ_WRITE 
GO

