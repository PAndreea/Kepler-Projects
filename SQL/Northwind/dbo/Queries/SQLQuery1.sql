--selects only the DISTINCT values from the "Country" column in the "Customers" table
SELECT DISTINCT Country 
FROM Customers;

--lists the number of different (distinct) customer countries
SELECT COUNT(DISTINCT Country)
FROM Customers;--

--selects all the customers from the country "Mexico", in the "Customers" table
SELECT * FROM Customers
WHERE Country='Mexico';---

--selects all fields from "Customers" where country is "Germany" AND city is "Berlin"
SELECT * FROM Customers
WHERE Country='Germany' AND City='Berlin';--

--selects all fields from "Customers" where city is "Berlin" OR "München"
SELECT * FROM Customers
WHERE City='Berlin' OR City='München';

--selects all fields from "Customers" where country is NOT "Germany"
SELECT * FROM Customers
WHERE NOT Country='Germany';

--selects all fields from "Customers" where country is "Germany" AND city must be "Berlin" OR "München"
SELECT * FROM Customers
WHERE Country='Germany' AND (City='Berlin' OR City='München');

--selects all customers from the "Customers" table, sorted DESCENDING by the "Country" column
SELECT * FROM Customers
ORDER BY Country DESC;

--selects all customers from the "Customers" table, sorted by the "Country" and the "CustomerName" column
SELECT * FROM Customers
ORDER BY Country, CompanyName;

--selects all customers from the "Customers" table, sorted ascending by the "Country" and descending by the "CustomerName" column
SELECT * FROM Customers
ORDER BY Country ASC, CompanyName DESC;

--insert a new record, but only insert data in the "CustomerName", "City", and "Country" columns
INSERT INTO Customers (CompanyName, City, Country)
VALUES ('Cardinal', 'Stavanger', 'Norway');

--updates the first customer (CustomerID = 1) with a new contact person and a new city
UPDATE Customers
SET ContactName = 'Alfred Schmidt', City= 'Frankfurt'
WHERE CustomerID = 'ALFKI';

--update the contactname to "Juan" for all records where country is "Mexico"
UPDATE Customers
SET ContactName='Juan'
WHERE Country='Mexico';

--deletes the customer "Alfreds Futterkiste" from the "Customers" table
DELETE FROM Customers
WHERE CompanyName='Alfreds Futterkiste';

--selects the first three records from the "Customers" table
SELECT TOP 3 * FROM Customers;

--selects the first 50% of the records from the "Customers" table
SELECT TOP 50 PERCENT * FROM Customers;

--selects the first three records from the "Customers" table, where the country is "Germany"
SELECT TOP 3 * FROM Customers
WHERE Country='Germany';

--statement finds the price of the cheapest product
SELECT MIN(UnitPrice) AS SmallestPrice
FROM Products;

--finds the price of the most expensive product
SELECT MAX(UnitPrice) AS LargestPrice
FROM Products;

--finds the number of products
SELECT COUNT(ProductID)
FROM Products;

--finds the average price of all products
SELECT AVG(UnitPrice)
FROM Products;

--finds the sum of the "Quantity" fields in the "OrderDetails" table
SELECT SUM(Quantity)
FROM [Order Details];

--selects all customers with a CompanyName starting with "a"
SELECT * FROM Customers
WHERE CompanyName LIKE 'a%';

--selects all customers with a CompanyName ending with "a"
SELECT * FROM Customers
WHERE CompanyName LIKE '%a';

--selects all customers with a CompanyName that have "or" in any position
SELECT * FROM Customers
WHERE CompanyName LIKE '%or%';

--selects all customers with a CompanyName that have "r" in the second position
SELECT * FROM Customers
WHERE CompanyName LIKE '_r%';

--selects all customers with a CompanyName that starts with "a" and are at least 3 characters in length
SELECT * FROM Customers
WHERE CompanyName LIKE 'a_%_%';

--selects all customers with a CompanyName that starts with "a" and ends with "o"
SELECT * FROM Customers
WHERE ContactName LIKE 'a%o';

--selects all customers with a CompanyName that NOT starts with "a"
SELECT * FROM Customers
WHERE CompanyName NOT LIKE 'a%';

--selects all customers with a City starting with "ber"
SELECT * FROM Customers
WHERE City LIKE 'ber%';

--selects all customers with a City containing the pattern "es"
SELECT * FROM Customers
WHERE City LIKE '%es%';

--selects all customers with a City starting with "L", followed by any character, followed by "n", followed by any character, followed by "on"
SELECT * FROM Customers
WHERE City LIKE 'L_n_on';

--selects all customers with a City starting with "b", "s", or "p"
SELECT * FROM Customers
WHERE City LIKE '[bsp]%';

--selects all customers with a City starting with "a", "b", or "c"
SELECT * FROM Customers
WHERE City LIKE '[a-c]%';

--selects all customers with a City NOT starting with "b", "s", or "p"
SELECT * FROM Customers
WHERE City LIKE '[!bsp]%';

--selects all customers with a City NOT starting with "b", "s", or "p"
SELECT * FROM Customers
WHERE City NOT LIKE '[bsp]%';

--selects all customers that are located in "Germany", "France" and "UK"
SELECT * FROM Customers
WHERE Country IN ('Germany', 'France', 'UK');

--selects all customers that are NOT located in "Germany", "France" or "UK"
SELECT * FROM Customers
WHERE Country NOT IN ('Germany', 'France', 'UK');

--selects all customers that are from the same countries as the suppliers
SELECT * FROM Customers
WHERE Country IN (SELECT Country FROM Suppliers);

--selects all products with a price BETWEEN 10 and 20
SELECT * FROM Products
WHERE UnitPrice BETWEEN 10 AND 20;

--selects all products with a price BETWEEN 10 and 20. In addition; do not show products with a CategoryID of 1,2, or 3
SELECT * FROM Products
WHERE (UnitPrice BETWEEN 10 AND 20)
AND NOT CategoryID IN (1,2,3);

--selects all products with a ProductName BETWEEN 'Carnarvon Tigers' and 'Mozzarella di Giovanni'
SELECT * FROM Products
WHERE ProductName BETWEEN 'Carnarvon Tigers' AND 'Mozzarella di Giovanni'
ORDER BY ProductName;

--selects all products with a ProductName NOT BETWEEN 'Carnarvon Tigers' and 'Mozzarella di Giovanni'
SELECT * FROM Products
WHERE ProductName NOT BETWEEN 'Carnarvon Tigers' AND 'Mozzarella di Giovanni'
ORDER BY ProductName;

--selects all orders with an OrderDate BETWEEN '04-July-1996' and '09-July-1996'
SELECT * FROM Orders
WHERE OrderDate BETWEEN '07/04/1996' AND '07/09/1996';

--creates two aliases, one for the CustomerID column and one for the CompanyName column
SELECT CustomerID as ID, CompanyName AS Customer
FROM Customers;

--creates two aliases, one for the CompanyName column and one for the ContactName column. Note: It requires double quotation marks or
-- square brackets if the alias name contains spaces
SELECT CompanyName AS Customer, ContactName AS [Contact Person]
FROM Customers;

--creates an alias named "Address" that combine four columns
SELECT CompanyName, Address + ', ' + PostalCode + ' ' + City + ', ' + Country AS Address
FROM Customers;

--selects all the orders from the customer with CustomerID=4 (Around the Horn). We use the "Customers" and "Orders" tables, 
--and give them the table aliases of "c" and "o" respectively
SELECT o.OrderID, o.OrderDate, c.CompanyName
FROM Customers AS c, Orders AS o
WHERE c.CompanyName='Around the Horn' AND c.CustomerID=o.CustomerID;

--without aliases
SELECT Orders.OrderID, Orders.OrderDate, Customers.CompanyName
FROM Customers, Orders
WHERE Customers.CompanyName='Around the Horn' AND Customers.CustomerID=Orders.CustomerID;

--selects all orders with customer information
SELECT Orders.OrderID, Customers.CompanyName, Orders.OrderDate
FROM Orders
INNER JOIN Customers ON Orders.CustomerID=Customers.CustomerID;

--selects all orders with customer and shipper information
SELECT Orders.OrderID, Customers.CompanyName, Shippers.CompanyName
FROM ((Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID)
INNER JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID);

--select all customers, and any orders they might have
SELECT Customers.CompanyName, Orders.OrderID
FROM Customers
LEFT JOIN Orders ON Customers.CustomerID = Orders.CustomerID
ORDER BY Customers.CompanyName;

--return all employees, and any orders they might have have placed
SELECT Orders.OrderID, Employees.LastName, Employees.FirstName
FROM Orders
RIGHT JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
ORDER BY Orders.OrderID;

--selects all customers, and all orders
SELECT Customers.CompanyName, Orders.OrderID
FROM Customers
FULL OUTER JOIN Orders ON Customers.CustomerID=Orders.CustomerID
ORDER BY Customers.CompanyName;

--matches customers that are from the same city
SELECT A.CompanyName AS CompanyName1, B.CompanyName AS CompanyName2, A.City
FROM Customers A, Customers B
WHERE A.CustomerID <> B.CustomerID
AND A.City = B.City 
ORDER BY A.City;

--selects all the different cities (only distinct values) from "Customers" and "Suppliers"
SELECT City FROM Customers
UNION
SELECT City FROM Suppliers
ORDER BY City;

--selects all cities (duplicate values also) from "Customers" and "Suppliers"
SELECT City FROM Customers
UNION ALL
SELECT City FROM Suppliers
ORDER BY City;

--selects all the different German cities (only distinct values) from "Customers" and "Suppliers"
SELECT City, Country FROM Customers
WHERE Country='Germany'
UNION 
SELECT City, Country FROM Suppliers
WHERE Country='Germany'
ORDER BY City;

--lists all customers and suppliers
SELECT 'Customer' As Type, ContactName, City, Country
FROM Customers
UNION
SELECT 'Supplier', ContactName, City, Country
FROM Suppliers;

--lists the number of customers in each country
SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country;

--lists the number of customers in each country, sorted high to low
SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country
ORDER BY COUNT(CustomerID) DESC;

--lists the number of orders sent by each shipper
SELECT Shippers.CompanyName, COUNT(Orders.OrderID) AS NumberOfOrders FROM Orders
LEFT JOIN Shippers ON Orders.ShipVia = Shippers.ShipperID
GROUP BY CompanyName;

--lists the number of customers in each country. Only include countries with more than 5 customers
SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country
HAVING COUNT(CustomerID) > 5;

--lists the number of customers in each country. Only include countries with more than 1 customers
SELECT COUNT(CustomerID), Country
FROM Customers
GROUP BY Country
HAVING COUNT(CustomerID) > 1
ORDER BY COUNT(CustomerID) DESC;

--lists the employees that have registered more than 70 orders
SELECT Employees.LastName, COUNT(Orders.OrderID) AS NumberOfOrders
FROM (Orders
INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID)
GROUP BY LastName
HAVING COUNT(Orders.OrderID) > 70;

--lists if the employees "Davolio" or "Fuller" have registered more than 25 orders
SELECT Employees.LastName, COUNT(Orders.OrderID) AS NumberOfOrders
FROM Orders
INNER JOIN Employees ON Orders.EmployeeID = Employees.EmployeeID
WHERE LastName = 'Davolio' OR LastName = 'Fuller'
GROUP BY LastName
HAVING COUNT(Orders.OrderID) > 25;

--returns TRUE and lists the suppliers with a product price less than 20
SELECT CompanyName
FROM Suppliers
WHERE EXISTS (SELECT ProductName FROM Products WHERE SupplierId = Suppliers.supplierId AND UnitPrice < 60);

--returns TRUE and lists the suppliers with a product price equal to 22
SELECT CompanyName
FROM Suppliers
WHERE EXISTS (SELECT ProductName FROM Products WHERE SupplierId = Suppliers.supplierId AND UnitPrice = 22);

--returns TRUE and lists the productnames if it finds ANY records in the OrderDetails table that quantity = 20
SELECT ProductName
FROM Products
WHERE ProductID = ANY (SELECT ProductID FROM [Order Details] WHERE Quantity = 20);

--returns TRUE and lists the productnames if it finds ANY records in the OrderDetails table that quantity > 99
SELECT ProductName
FROM Products
WHERE ProductID = ANY (SELECT ProductID FROM [Order Details] WHERE Quantity > 99);

--returns TRUE and lists the productnames if ALL the records in the OrderDetails table has quantity = 10
SELECT ProductName
FROM Products
WHERE ProductID = ALL (SELECT ProductID FROM [Order Details] WHERE Quantity = 10);

--copies "Suppliers" into "Customers" (the columns that are not filled with data, will contain NULL)
INSERT INTO Customers (CustomerID,CompanyName, City, Country)
SELECT Supplierid,CompanyName, City, Country FROM Suppliers;

SELECT *
FROM Customers;

--view
SELECT * FROM [Current Product List];

--view
SELECT * FROM [Products Above Average Price];

--view
SELECT * FROM [Category Sales For 1997];

--view
SELECT * FROM [Summary of Sales by Year]

--view
SELECT * FROM [Invoices]

--view
SELECT * FROM [Quarterly Orders]

--view
SELECT * FROM [Summary of Sales by Quarter]

--angajatii din fiecare regiune,teritoriu
SELECT COUNT(Employees.EmployeeID) as Numar,Territories.TerritoryDescription, Region.RegionDescription
FROM Region
inner join Territories on Territories.RegionID=Region.RegionID 
inner join EmployeeTerritories on Territories.TerritoryID=EmployeeTerritories.TerritoryID
inner join Employees on EmployeeTerritories.EmployeeID=Employees.EmployeeID
group by Region.RegionDescription,Territories.TerritoryDescription
order by Numar desc

--din ce categorie a cumparat fiecare angajat
select count(Categories.CategoryID) as numar,Categories.CategoryName,Employees.LastName,Employees.FirstName
from Categories
inner join Products on Categories.CategoryID=Products.CategoryID
inner join [Order Details] on Products.ProductID=[Order Details].ProductID
inner join Orders on [Order Details].OrderID=Orders.OrderID
inner join Employees on Orders.EmployeeID=Employees.EmployeeID
group by Categories.CategoryName,Employees.LastName,Employees.FirstName
order by Categories.CategoryName

--din ce categorie a cumparat fiecare angajat
select distinct Categories.CategoryName,Employees.LastName,Employees.FirstName
from Categories
inner join Products on Categories.CategoryID=Products.CategoryID
inner join [Order Details] on Products.ProductID=[Order Details].ProductID
inner join Orders on [Order Details].OrderID=Orders.OrderID
inner join Employees on Orders.EmployeeID=Employees.EmployeeID
order by Employees.LastName

--get Product name and quantity/unit
select ProductName,QuantityPerUnit
from Products

--get current Product list (Product ID and name)
select ProductID,ProductName
from Products

--get discontinued Product list (Product ID and name)
select ProductID,ProductName
from Products
where Discontinued=1

--get most expense and least expensive Product list (name and unit price)
select ProductName,UnitPrice
from Products
order by UnitPrice desc

--get Product list (id, name, unit price) where current products cost less than $20
select ProductID,ProductName,UnitPrice
from Products
where UnitPrice<20

-- get Product list (id, name, unit price) where products cost between $15 and $25  
select ProductID,ProductName,UnitPrice
from Products
where UnitPrice between 15 and 25

--get Product list (name, unit price) of above average price
select ProductID,ProductName,UnitPrice
from Products
where UnitPrice>(select avg(UnitPrice) from Products)

--get Product list (name, unit price) of ten most expensive products
select top 10 ProductID,ProductName,UnitPrice
from Products
order by UnitPrice desc

--get Product list (name, units on order , units in stock) of stock is less than the quantity on order
select ProductName,UnitsOnOrder,UnitsInStock
from Products
where UnitsInStock<UnitsOnOrder


select count(c.CustomerID),c.CompanyName,t.TerritoryDescription
from Territories as t
inner join EmployeeTerritories as et on t.TerritoryID=et.TerritoryID
inner join Employees as e on et.EmployeeID=e.EmployeeID
inner join Orders as o on e.EmployeeID=o.EmployeeID
inner join Customers as c on o.CustomerID=c.CustomerID
group by c.CompanyName,t.TerritoryDescription
having c.CompanyName like 'a%'
