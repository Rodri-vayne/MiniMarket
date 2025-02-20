USE [master]
GO
/****** Object:  Database [DB_MINIMARKET]    Script Date: 23/07/2024 14:34:02 ******/
CREATE DATABASE [DB_MINIMARKET]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_MINIMARKET', FILENAME = N'/var/opt/mssql/data/DB_MINIMARKET.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DB_MINIMARKET_log', FILENAME = N'/var/opt/mssql/data/DB_MINIMARKET_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [DB_MINIMARKET] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_MINIMARKET].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_MINIMARKET] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_MINIMARKET] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_MINIMARKET] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET  DISABLE_BROKER 
GO
ALTER DATABASE [DB_MINIMARKET] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_MINIMARKET] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET RECOVERY FULL 
GO
ALTER DATABASE [DB_MINIMARKET] SET  MULTI_USER 
GO
ALTER DATABASE [DB_MINIMARKET] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_MINIMARKET] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_MINIMARKET] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_MINIMARKET] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [DB_MINIMARKET] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [DB_MINIMARKET] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'DB_MINIMARKET', N'ON'
GO
ALTER DATABASE [DB_MINIMARKET] SET QUERY_STORE = ON
GO
ALTER DATABASE [DB_MINIMARKET] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [DB_MINIMARKET]
GO
/****** Object:  Table [dbo].[almacenes]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[almacenes](
	[id_almacen] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_almacenes] PRIMARY KEY CLUSTERED 
(
	[id_almacen] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[categoria]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[categoria](
	[id_categoria] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_categoria] PRIMARY KEY CLUSTERED 
(
	[id_categoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[marca]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[marca](
	[id_marca] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_marca] PRIMARY KEY CLUSTERED 
(
	[id_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[producto]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[producto](
	[id_producto] [int] IDENTITY(1,1) NOT NULL,
	[descripcion] [nvarchar](255) NULL,
	[id_marca] [int] NULL,
	[id_medida] [int] NULL,
	[id_categoria] [int] NULL,
	[stock_minimo] [numeric](18, 2) NULL,
	[stock_maximo] [numeric](18, 2) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_producto] PRIMARY KEY CLUSTERED 
(
	[id_producto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[stock_productos]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[stock_productos](
	[id_producto] [int] NULL,
	[id_almacen] [int] NULL,
	[stock_minimo] [decimal](18, 2) NULL,
	[costo_actual_compra] [decimal](18, 2) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[unidades_medida]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[unidades_medida](
	[id_medida] [int] IDENTITY(1,1) NOT NULL,
	[abreviatura] [nvarchar](6) NULL,
	[descripcion] [nvarchar](50) NULL,
	[estado] [bit] NULL,
 CONSTRAINT [PK_unidades_medida] PRIMARY KEY CLUSTERED 
(
	[id_medida] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_categoria] FOREIGN KEY([id_categoria])
REFERENCES [dbo].[categoria] ([id_categoria])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_categoria]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_marca] FOREIGN KEY([id_marca])
REFERENCES [dbo].[marca] ([id_marca])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_marca]
GO
ALTER TABLE [dbo].[producto]  WITH CHECK ADD  CONSTRAINT [FK_producto_unidades_medida] FOREIGN KEY([id_medida])
REFERENCES [dbo].[unidades_medida] ([id_medida])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[producto] CHECK CONSTRAINT [FK_producto_unidades_medida]
GO
ALTER TABLE [dbo].[stock_productos]  WITH CHECK ADD  CONSTRAINT [FK_stock_productos_almacenes] FOREIGN KEY([id_almacen])
REFERENCES [dbo].[almacenes] ([id_almacen])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[stock_productos] CHECK CONSTRAINT [FK_stock_productos_almacenes]
GO
ALTER TABLE [dbo].[stock_productos]  WITH CHECK ADD  CONSTRAINT [FK_stock_productos_producto] FOREIGN KEY([id_producto])
REFERENCES [dbo].[producto] ([id_producto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[stock_productos] CHECK CONSTRAINT [FK_stock_productos_producto]
GO
/****** Object:  StoredProcedure [dbo].[actualizar_almacen]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[actualizar_almacen]
@id_almacen int,
@descripcion nvarchar(255)
as
if exists(Select descripcion From almacenes Where descripcion=@descripcion and id_almacen<>@id_almacen)
raiserror('Ya Existe Un Almacen Con Ese Nombre, Ingresa Otro', 16,1)
else
Update almacenes set descripcion=@descripcion Where id_almacen=@id_almacen
GO
/****** Object:  StoredProcedure [dbo].[actualizar_categoria]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[actualizar_categoria]
@id_categoria int,
@descripcion nvarchar(255)
as
if exists(Select id_categoria, descripcion From categoria Where descripcion=@descripcion and id_categoria<>@id_categoria)
raiserror('Ya Existe La Categoria Con Ese Nombre, Ingresa Otro', 16,1)
else
Update categoria set descripcion=@descripcion Where id_categoria=@id_categoria
GO
/****** Object:  StoredProcedure [dbo].[actualizar_marca]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[actualizar_marca]
@id_marca int,
@descripcion nvarchar(255)
as
if exists(Select descripcion From marca where descripcion=@descripcion and id_marca<>@id_marca)
raiserror('Ya Existe La Marca Con Ese Nombre, Ingresa Otro', 16,1)
else
Update marca set descripcion=@descripcion where id_marca=@id_marca
GO
/****** Object:  StoredProcedure [dbo].[actualizar_medida]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_medida]
@id_medida int,
@abreviatura nvarchar(6),
@descripcion nvarchar(255)
as
if exists(Select abreviatura From unidades_medida where abreviatura=@abreviatura and id_medida<>@id_medida)
raiserror('Ya Existe La Abreviatura Con Ese Nombre, Ingresa Otro', 16,1)
else
Update unidades_medida set descripcion=@descripcion, abreviatura=@abreviatura where id_medida=@id_medida
GO
/****** Object:  StoredProcedure [dbo].[actualizar_producto]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[actualizar_producto]
@id_producto int,
@descripcion nvarchar(255),
@id_marca int,
@id_medida int,
@id_categoria int,
@stock_minimo numeric(18,2),
@stock_maximo numeric(18,2)
as
If exists(Select descripcion From producto Where descripcion=@descripcion and id_producto<>@id_producto)
raiserror('Ya Existe un Producto Con Ese Nombre, Ingresa Otro',16,1)
else
Update producto set descripcion=@descripcion,
					id_marca=@id_marca,
					id_medida=@id_medida,
					id_categoria=@id_categoria,
					stock_minimo=@stock_minimo,
					stock_maximo=@stock_maximo
Where id_producto=@id_producto
Insert Into stock_productos(id_producto, id_almacen, stock_minimo, costo_actual_compra)
							Select 
							@id_producto,
							id_almacen,
							0.00,
							0.00
							From almacenes
							Where id_almacen not in(Select id_almacen From stock_productos Where id_producto=@id_producto)
GO
/****** Object:  StoredProcedure [dbo].[buscar_almacen]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscar_almacen]
@buscar nvarchar(255)
as
Select descripcion, id_almacen From almacenes
Where estado = 1 and UPPER(TRIM(descripcion)) Like '%'+UPPER(TRIM(@buscar))+'%'
GO
/****** Object:  StoredProcedure [dbo].[buscar_categoria]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscar_categoria]
@buscar nvarchar(255)
as
Select id_categoria, descripcion From categoria 
Where estado=1 and UPPER(TRIM(descripcion)) Like '%'+UPPER(TRIM(@buscar))+'%'
GO
/****** Object:  StoredProcedure [dbo].[buscar_marca]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[buscar_marca]
@buscar nvarchar(255)
as
Select id_marca, descripcion From marca
Where estado = 1 and UPPER(TRIM(descripcion)) Like '%'+UPPER(TRIM(@buscar))+'%'
GO
/****** Object:  StoredProcedure [dbo].[buscar_medida]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[buscar_medida]
@buscar nvarchar(255)
as
Select id_medida,abreviatura, descripcion From unidades_medida
Where estado=1 and UPPER(TRIM(descripcion)) Like '%'+UPPER(TRIM(@buscar))+'%'
GO
/****** Object:  StoredProcedure [dbo].[delete_almacen]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[delete_almacen]
@id_almacen int
as
Delete From almacenes Where id_almacen=@id_almacen
GO
/****** Object:  StoredProcedure [dbo].[eliminar_categoria]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[eliminar_categoria]
@id_categoria int
as
Delete From categoria where id_categoria=@id_categoria
GO
/****** Object:  StoredProcedure [dbo].[eliminar_marca]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_marca]
@id_marca int
as
Delete From marca where id_marca=@id_marca
GO
/****** Object:  StoredProcedure [dbo].[eliminar_medida]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_medida]
@id_medida int
as
Delete From unidades_medida where id_medida=@id_medida
GO
/****** Object:  StoredProcedure [dbo].[eliminar_producto]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[eliminar_producto]
@id_producto int
as
Delete From producto Where id_producto=@id_producto
GO
/****** Object:  StoredProcedure [dbo].[insertar_almacen]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_almacen]
@descripcion nvarchar(255)
as
if exists(Select descripcion From almacenes where descripcion=@descripcion)
raiserror('Ya Existe Un Almacen Con Ese Nombre, Ingresa Otro', 16,1)
else
Insert Into almacenes(descripcion, estado) Values(@descripcion, 1)
GO
/****** Object:  StoredProcedure [dbo].[insertar_categoria]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_categoria]
@descripcion nvarchar(255)
as
if exists(Select descripcion From categoria where descripcion=@descripcion)
raiserror('Ya Existe La Categoria Con Ese Nombre, Ingresa Otro', 16,1)
else
Insert Into categoria(descripcion, estado) Values(@descripcion, 1)
GO
/****** Object:  StoredProcedure [dbo].[insertar_marca]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_marca]
@descripcion nvarchar(255)
as
if exists(Select descripcion From marca where descripcion=@descripcion)
raiserror('Ya Existe La Marca Con Ese Nombre, Ingresa Otro', 16,1)
else
Insert Into marca(descripcion, estado) Values(@descripcion, 1)
GO
/****** Object:  StoredProcedure [dbo].[insertar_medida]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[insertar_medida]
@abreviatura nvarchar(6),
@descripcion nvarchar(255)
as
if exists(Select abreviatura From unidades_medida where abreviatura=@abreviatura)
raiserror('Ya Existe La Abreviatura Con Ese Nombre, Ingresa Otro', 16,1)
else
Insert Into unidades_medida(abreviatura, descripcion, estado)Values(@abreviatura, @descripcion, 1)
GO
/****** Object:  StoredProcedure [dbo].[insertar_producto]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[insertar_producto]
@descripcion nvarchar(255),
@id_marca int,
@id_medida int,
@id_categoria int,
@stock_minimo numeric(18,2),
@stock_maximo numeric(18,2)
as
declare @xcodigo int 

If exists(Select descripcion From producto Where descripcion=@descripcion)
raiserror('Ya Existe un Producto Con Ese Nombre, Ingresa Otro',16,1)
else
Insert Into producto(descripcion, id_marca, id_medida, id_categoria, stock_minimo, stock_maximo, estado)
			  Values(@descripcion, @id_marca, @id_medida, @id_categoria, @stock_minimo, @stock_maximo, 1)
set @xcodigo = @@IDENTITY
Insert Into stock_productos(id_producto, id_almacen, stock_minimo, costo_actual_compra)
							Select 
							@xcodigo,
							id_almacen,
							0.00,
							0.00
							From almacenes
GO
/****** Object:  StoredProcedure [dbo].[mostrar_categoria_producto]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_categoria_producto]
@buscar nvarchar(255)
as
Select id_categoria, descripcion From categoria
Where estado = 1 and
UPPER(TRIM(descripcion)) Like '%'+UPPER(TRIM(@buscar))+'%'
GO
/****** Object:  StoredProcedure [dbo].[mostrar_marca_producto]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_marca_producto]
@buscar nvarchar(255)
as
Select id_marca, descripcion From marca
Where estado = 1 and
UPPER(TRIM(descripcion)) Like '%'+UPPER(TRIM(@buscar))+'%'
GO
/****** Object:  StoredProcedure [dbo].[mostrar_producto]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[mostrar_producto]
@buscar nvarchar(255)
as
Select 
	p.id_producto,
	p.descripcion,
	m.descripcion,
	u.descripcion,
	c.descripcion,
	p.stock_minimo,
	p.stock_maximo,
	p.id_marca,
	p.id_medida,
	p.id_categoria
From producto p
inner join marca m on p.id_marca = m.id_marca
inner join unidades_medida u on p.id_medida = u.id_medida
inner join categoria c on p.id_categoria = c.id_categoria
Where p.estado = 1 and
UPPER(TRIM(p.descripcion)+
      TRIM(m.descripcion)+
	  TRIM(u.descripcion)+
	  TRIM(c.descripcion)) Like '%'+UPPER(TRIM(@buscar))+'%'
order by p.id_categoria
GO
/****** Object:  StoredProcedure [dbo].[mostrar_unidad_medida_producto]    Script Date: 23/07/2024 14:34:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[mostrar_unidad_medida_producto]
@buscar nvarchar(255)
as
Select id_medida, abreviatura From unidades_medida
Where estado = 1 and
UPPER(TRIM(descripcion)) Like '%'+UPPER(TRIM(@buscar))+'%'
GO
USE [master]
GO
ALTER DATABASE [DB_MINIMARKET] SET  READ_WRITE 
GO
