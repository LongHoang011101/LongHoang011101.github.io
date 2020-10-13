USE [master]
GO

/****** Object:  Database [QLNhaHang]    Script Date: 10/13/2020 6:51:29 PM ******/
CREATE DATABASE [QLNhaHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QLNhaHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLNhaHang.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'QLNhaHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\QLNhaHang_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QLNhaHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [QLNhaHang] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [QLNhaHang] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [QLNhaHang] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [QLNhaHang] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [QLNhaHang] SET ARITHABORT OFF 
GO

ALTER DATABASE [QLNhaHang] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [QLNhaHang] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [QLNhaHang] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [QLNhaHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [QLNhaHang] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [QLNhaHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [QLNhaHang] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [QLNhaHang] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [QLNhaHang] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [QLNhaHang] SET  DISABLE_BROKER 
GO

ALTER DATABASE [QLNhaHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [QLNhaHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [QLNhaHang] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [QLNhaHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [QLNhaHang] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [QLNhaHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [QLNhaHang] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [QLNhaHang] SET RECOVERY FULL 
GO

ALTER DATABASE [QLNhaHang] SET  MULTI_USER 
GO

ALTER DATABASE [QLNhaHang] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [QLNhaHang] SET DB_CHAINING OFF 
GO

ALTER DATABASE [QLNhaHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [QLNhaHang] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [QLNhaHang] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [QLNhaHang] SET QUERY_STORE = OFF
GO

ALTER DATABASE [QLNhaHang] SET  READ_WRITE 
GO

