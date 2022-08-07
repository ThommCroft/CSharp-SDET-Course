SELECT Customers.CustomerID, Customers.CompanyName, 
	Customers.Address, Customers.City, Customers.PostalCode, Customers.Country
	FROM Customers WHERE City = 'Paris' OR City = 'London'; -- 1.1

SELECT ProductName, QuantityPerUnit, UnitPrice FROM Products WHERE CategoryID = 1; -- 1.2

SELECT T1.ProductName, T2.CompanyName, T2.Country FROM Suppliers T2	-- 1.3
	INNER JOIN Products T1 ON (T1.SupplierID = T2.SupplierID)
	WHERE T1.CategoryID = 1;

SELECT COUNT(T1.ProductName) AS Total, T2.CategoryName FROM Products T1	-- 1.4
	INNER JOIN Categories T2 ON (T1.CategoryID = T2.CategoryID)
	GROUP BY T2.CategoryName
	ORDER BY Total DESC;

SELECT CONCAT(Employees.TitleOfCourtesy, ' ', Employees.FirstName, ' ', Employees.LastName, ', ', Employees.City) FROM Employees -- 1.5
	WHERE Country = 'UK';

SELECT COUNT(OrderID) FROM Orders WHERE Freight > 100.00 AND ShipCountry = 'UK' OR ShipCountry = 'USA'; -- 1.6

SELECT TOP (1) OrderID, (UnitPrice * Quantity) * Discount as TotalDiscount FROM [Order Details] ORDER BY TotalDiscount DESC; -- 1.7

SELECT T1.EmployeeID, T1.FirstName, T1.LastName, T1.ReportsTo, T2.FirstName, T2.LastName FROM Employees T1 -- 1.8
	INNER JOIN Employees T2 ON (T2.EmployeeID = T1.ReportsTo)

-- Class Exercise
SELECT o.OrderID, o.OrderDate, o.Freight, c.CompanyName, e.FirstName + ' ' + e.LastName AS "Employee Name"
FROM Orders o
Join Customers c ON (o.CustomerID = c.CustomerID)
Join Employees e ON (o.EmployeeID = e.EmployeeID);