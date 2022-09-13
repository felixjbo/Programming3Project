Create database VENTASAUTOSDB
go

use VENTASAUTOSDB
go

-------------EMPRESA
/*
create table EMPRESA
(
	EMPRESA VARCHAR(30) primary key
)
go
*/

-------------------MARCAS
/*
create table MARCAS
(
	ID_MARCA	INT PRIMARY KEY,
	MARCA		VARCHAR(20) NOT NULL,
	ID_EMPRESA	INT FOREIGN KEY (ID_EMPRESA) REFERENCES EMPRESA(ID_EMPRESA) 
)
go

---------------MODELO

create table MODELO
(
	ID_MODELO	INT PRIMARY KEY,
	MARCA		VARCHAR(50),-- FOREIGN KEY (ID_MARCA) REFERENCES MARCAS(ID_MARCA),
	MODELO		VARCHAR(50) NOT NULL,
	PRECIO		INT		NOT NULL
)
go
*/
------------CLIENTE

create table CLIENTE
(
	IDENTIFICACION	VARCHAR(15) PRIMARY KEY,
	TIPOID			VARCHAR(15),
	NOMBRE		VARCHAR(30)		NOT NULL,
	APELLIDO		VARCHAR(30)	NOT NULL,
	GENERO			VARCHAR(1)		NOT NULL,  ----CABIAR ESO EN EL PROGRAMA PARA QUE SEA UN COMBOBOX
	ESTADO_CIVIL	VARCHAR(15)		NOT NULL, --ESTO TAMBIEN PUEDE SER UN COMBO BOX
	TELEFONO		INT			NOT NULL,
	NOMBRE_EMPRESA VARCHAR(30) NOT NULL,
	FOREIGN KEY (Nombre_Empresa) REFERENCES EMPRESA(EMPRESA)
)
go

insert into CLIENTE values ('3-0123-0123','Costarricense','Fede','Lobo','M','Casado',88888888,'NovaCarShop')
select * from CLIENTE
create procedure insertarCLIENTE

	@cedula	varchar(15),
	@tipo	varchar(15),
	@nombre		VARCHAR(30),
	@apellido		VARCHAR(30),
	@genero			VARCHAR(1), 
	@estado	VARCHAR(15),
	@telefono		INT,
	@empresa VARCHAR(30)
	AS
	insert into CLIENTE
	values (@cedula,@tipo, @nombre, @apellido, @genero, @estado, @telefono, @empresa)
	
	select * from CLIENTE
----------------FACTURA
set dateformat dmy
create table FACTURA
(
	NUM_FACT		INT PRIMARY key,
	ID_CLIENTE		varchar(15),
	NUM_DETALLE		INT,
	tipo_pago		varchar(10),
	PRECIO			INT		NOT NULL,
	IVA				char(4),
	Total			int,
	fecha			datetime not null,
	CONSTRAINT ID_CLIENTE FOREIGN KEY (ID_CLIENTE) REFERENCES CLIENTE(IDENTIFICACION),
	-- foreign NUM_DETALLE
	CONSTRAINT NUM_DETALLE FOREIGN KEY (NUM_DETALLE) REFERENCES DETALLE_FACT(NUM_DETALLE)
)
go 

select* from CLIENTE
create proc insert_factura
	@Num_fact		int,
	@ID_CLIENTE		varchar(15),
	@NUM_DETALLE	INT,
	@tipo_pago		varchar(10),
	@PRECIO			INT,
	@IVA			char(4),
	@total			int,
	@fecha			datetime
	as
	insert into factura values (@Num_fact, @ID_CLIENTE,@NUM_DETALLE,@tipo_pago,@PRECIO,@IVA,@total,@fecha)
	
	insert into factura values (1,'3-0123-0123',1,'Efectivo',20000000,0.13,3213123,GETDATE())
-------------DETALLE_FACT
select * from factura

create table DETALLE_FACT
(
	NUM_DETALLE		INT PRIMARY KEY IDENTITY(1,1),
	--NUM_FACT		INT ,
	MARCA			VARCHAR(20) NOT NULL,
	MODELO			VARCHAR(50) NOT NULL,
	ESTILO			VARCHAR(30) NOT NULL,
	COMBUSTIBLE		VARCHAR(15) NOT NULL,
	TRANSMISION		VARCHAR(15) NOT NULL,
	FINACIADO		VARCHAR(20) NOT NULL,
	NUM_PUERTAS		varchar(10)			NOT NULL,
	AÑO_VEHICULO	INT			NOT NULL,	
	COLOR			VARCHAR(20) NOT NULL
	--CONSTRAINT NUM_FACT FOREIGN KEY (NUM_FACT) REFERENCES FACTURA(NUM_FACT)
)
go

select * from detalle_fact
create proc insert_detalle
	@MARCA			VARCHAR(20),
	@MODELO			VARCHAR(50),
	@ESTILO			VARCHAR(30),
	@COMBUSTIBLE	VARCHAR(15),
	@TRANSMISION	VARCHAR(15),
	@FINACIADO		VARCHAR(20),
	@NUM_PUERTAS	varchar(10),
	@AÑO_VEHICULO	INT,	
	@COLOR			VARCHAR(20)
as
insert into DETALLE_FACT values (@MARCA,@MODELO,@ESTILO,@COMBUSTIBLE,@TRANSMISION,@FINACIADO,@NUM_PUERTAS,@AÑO_VEHICULO,@COLOR)
---------PROCESOS ALMACENADOS----------
create proc Select_clientes
	@Identificacion	varchar(15),
	@nombre			VARCHAR(30),
	@apellido		VARCHAR(30),
	@genero			VARCHAR(1), 
	@estado			VARCHAR(15),
	@telefono		INT
	as
select NOMBRE,APELLIDO,GENERO,ESTADO_CIVIL,TELEFONO from cliente where IDENTIFICACION = @Identificacion

select * from detalle_Fact

create proc factt 
	@Num_detalle int
as
select d.marca,d.modelo,f.precio,f.IVA,f.total from detalle_Fact d, factura f 
where d.Num_detalle = @Num_detalle and f.Num_Detalle = d.Num_Detalle
