
CREATE PROCEDURE SalesByCategories
AS
BEGIN
SELECT Categories.CategoryName,SUM([Order Details].UnitPrice*[Order Details].Quantity*(1-[Order Details].Discount))
FROM Categories
inner join Products on Categories.CategoryID=Products.CategoryID
inner join [Order Details] on Products.ProductID=[Order Details].ProductID
group by Categories.CategoryName
END
GO


EXECUTE SalesByCategories
GO