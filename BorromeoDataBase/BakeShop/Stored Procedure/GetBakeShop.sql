CREATE PROCEDURE [dbo].[GetBakeShopOwner]
	@Owner NVARCHAR(50) = NULL
AS
BEGIN
	SELECT * FROM [dbo].[BakeShop] AS a WHERE a.[Owner] = @Owner;
END