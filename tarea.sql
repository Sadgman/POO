CREATE PROCEDURE InsertarProducto
    @Nombre NVARCHAR(100),
    @Descripcion NVARCHAR(250),
    @Precio DECIMAL(10, 2),
    @Cantidad INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Productos (Nombre, Descripcion, Precio, Cantidad)
    VALUES (@Nombre, @Descripcion, @Precio, @Cantidad);
END;
GO

CREATE PROCEDURE ActualizarProducto
    @ProductoID INT,
    @Nombre NVARCHAR(100),
    @Descripcion NVARCHAR(250),
    @Precio DECIMAL(10, 2),
    @Cantidad INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Productos
    SET 
        Nombre = @Nombre,
        Descripcion = @Descripcion,
        Precio = @Precio,
        Cantidad = @Cantidad
    WHERE ProductoID = @ProductoID;
END;
GO

CREATE PROCEDURE EliminarProducto
    @ProductoID INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Productos
    WHERE ProductoID = @ProductoID;
END;
GO
