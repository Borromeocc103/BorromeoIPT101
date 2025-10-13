CREATE PROCEDURE [dbo].[UpdateMotorShop]
	@Owner NVARCHAR(40) = NULL, 
    @ProductName NVARCHAR(50) = NULL,
	@Price NVARCHAR(50) = NULL,
	@Quantity NVARCHAR(50) = NULL,
	@Baker NVARCHAR(50) = NULL
AS
BEGIN
	UPDATE [dbo].[BakeShop]
	SET [ProductName] = @ProductName,
		[Price] = @Price,
		[Quantity] = @Quantity,
		[Baker] = @Baker
	WHERE [Owner] = @Owner;
END