CREATE PROCEDURE [dbo].[CreateBakeShop]
	@Owner NVARCHAR = NULL,
	@ProductName NVARCHAR(50) = NULL,
	@Price NVARCHAR(50) = NULL,
	@Quantity NVARCHAR(50) = NULL,
	@Baker NVARCHAR(50) = NULL
AS
BEGIN
	INSERT INTO [dbo].[BakeShop] ([Owner], [ProductName], [Price], [Quantity], [Baker])
	VALUES (@Owner, @ProductName, @Price, @Quantity, @Baker)
	END
