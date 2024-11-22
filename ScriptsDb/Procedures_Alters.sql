

Alter table Vouchers
add Id int not null IDENTITY(1,1)

Alter table Vouchers
add Estado int not null default 1

Alter table Articulos
add Canjeado int not null default 1;



CREATE PROCEDURE EstadoVouchers
 @Id int,	
 @NuevoCliente int,
 @IdArticulo int
as
    update Vouchers
    set
        Estado = 0,
        FechaCanje = GETDATE(),
        IdCliente = @NuevoCliente,
		IdArticulo = @IdArticulo
    where Id = 5;

	update ARTICULOS
	set Canjeado = 0
	where Id = @IdArticulo



create Procedure listaDeArticulos
as
select A.Id as Ids , A.Nombre as Nombre , A.Descripcion as Descripcion , I.ImagenUrl as Urlimagen , M.Descripcion as Mdescrip, C.Descripcion as Cdescrip From ARTICULOS A, IMAGENES  I, MARCAS M, CATEGORIAS C
where A.Id = I.IdArticulo AND A.IdMarca = M.Id AND A.IdCategoria = C.Id	





