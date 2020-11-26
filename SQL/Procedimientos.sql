CREATE  PROCEDURE  CategoriasReporteP (@ID INTEGER)AS
SELECT  P.id , P.descripcion , P.precioVenta  
FROM Productos as P Where p.idCategoria=@ID order by P.precioVenta ASC
GO


CREATE  PROCEDURE  CategoriasReporteI (@ID INTEGER) AS
SELECT  P.id  , P.descripcion , P.existencias
FROM Productos as P Where p.idCategoria=@ID order by P.existencias ASC
GO

CREATE  PROCEDURE ClientesReporte AS
SELECT  c.id , c.nombre, c.domicilio, c.ciudad, c.codigoPostal ,c.telefono,c.email  
FROM Cliente as C order by C.nombre ASC
GO

CREATE  PROCEDURE ProveedoresReportes AS
SELECT  p.id , p.nombre, p.domicilio, p.ciudad, p.codigoPostal,p.telefono,p.email   
FROM Proveedor as P order by p.nombre ASC
GO

CREATE  PROCEDURE  VentasReporte (@FI	DATE,  @FF  DATE) AS
SELECT    v.id , c.nombre, v.descuento, v.IVA, v.subTotal, v.total,v.status
FROM    Venta as V    JOIN  Cliente as c     ON V.idCliente=C.id   
WHERE   v.fecha   BETWEEN   @FI   AND @FF 
GO

CREATE  PROCEDURE  ComprasReporte (@FI	DATE,  @FF  DATE) AS
SELECT    C.id , P.nombre, c.fecha,c.fechaVencimiento,c.descuento,c.IVA,c.subTotal,c.total
FROM    Compras as C    JOIN  Proveedor as P     ON c.idProvedor=P.id   
WHERE   c.fecha   BETWEEN   @FI   AND @FF  
GO

CREATE PROCEDURE DevolucionesReporte(@FI	DATE,  @FF  DATE) as 
SELECT d.id , v.id , c.nombre , d.motivo , v.total
FROM    Devoluciones as D   JOIN  Venta as V     ON d.idVenta=V.id   JOIN  Cliente as C     ON v.idCliente=c.id 
WHERE   d.fecha   BETWEEN   @FI   AND @FF  
GO

CREATE PROCEDURE PagosReporte(@FI	DATE,  @FF  DATE) as 
SELECT Pa.id, Pa.idCompra,pa.fecha, p.nombre,pa.importe
FROM    Pagos as Pa   JOIN  Compras as C     ON Pa.idCompra=c.id   JOIN  Proveedor as P     ON c.idProvedor=p.id
WHERE   pa.fecha   BETWEEN   @FI   AND @FF  
GO
