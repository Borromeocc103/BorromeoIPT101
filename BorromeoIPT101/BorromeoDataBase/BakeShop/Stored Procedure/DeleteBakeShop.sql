CREATE PROCEDURE [dbo].[DeleteStore]
	@Owner NVARCHAR (50) = NULL
AS
BEGIN
DELETE FROM [dbo].[BakeShop] WHERE Owner = @Owner;
END