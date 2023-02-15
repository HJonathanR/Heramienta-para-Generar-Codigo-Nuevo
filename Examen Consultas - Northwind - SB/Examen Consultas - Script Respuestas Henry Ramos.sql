use Northwind
--Henry Ramos
--Ejercicio #1
select	CONCAT(emp.FirstName, ' ', emp.LastName) as [Nombre Completo], 
		sum(od.Quantity * od.UnitPrice) as SubTotal,
		sum(case when DATENAME(quarter, o.OrderDate) = '1'
		then od.Quantity * od.UnitPrice end) as [1er Trimestre],
		sum(case when DATENAME(quarter, o.OrderDate) = '2'
		then od.Quantity * od.UnitPrice end) as [2do Trimestre],
		sum(case when DATENAME(quarter, o.OrderDate) = '3'
		then od.Quantity * od.UnitPrice end) as [3er Trimestre],
		sum(case when DATENAME(quarter, o.OrderDate) = '4'
		then od.Quantity * od.UnitPrice end) as [4to Trimestre] 
from Employees emp
	inner join Orders o
	on emp.EmployeeID = o.EmployeeID
	inner join [Order Details] od
	on o.OrderID = od.OrderID
where o.OrderDate between '1997-01-01' and '1997-12-31'
group by CONCAT(emp.FirstName, ' ', emp.LastName)




--Ejericio #2
Select SUBSTRING(c.CompanyName, 1, 1) as [Inicial de Cliente], 
		cat.CategoryName,
		(
		Select SUM(od2.UnitPrice * od2.Quantity) 
		from [Order Details] od2
			inner join Products p
			on od2.ProductID = p.ProductID
			inner join Categories cat2
			on p.CategoryID = cat2.CategoryID
			inner join Orders o2
			on od2.OrderID = o2.OrderID
			inner join Customers c2
			on o2.CustomerID = c2.CustomerID
		group by SUBSTRING(c2.CompanyName, 1, 1), cat2.CategoryName
		having SUBSTRING(c2.CompanyName, 1, 1) = SUBSTRING(c.CompanyName, 1, 1) and cat.CategoryName = cat2.CategoryName
		) as [Total Categoria]
from Customers c
	inner join Orders o
	on o.CustomerID = c.CustomerID
	inner join [Order Details] od
	on o.OrderID = od.OrderID
	inner join Products p
	on od.ProductID = p.ProductID
	inner join Categories cat
	on p.CategoryID = cat.CategoryID
group by SUBSTRING(c.CompanyName, 1, 1), cat.CategoryName
order by SUBSTRING(c.CompanyName, 1, 1), cat.CategoryName

/* Sub query de Total por Categoria */

--Select SUM(od2.UnitPrice * od2.Quantity) as [Total Categoria]
--from [Order Details] od2
--	inner join Products p
--	on od2.ProductID = p.ProductID
--	inner join Categories cat2
--	on p.CategoryID = cat2.CategoryID
--	inner join Orders o2
--	on od2.OrderID = o2.OrderID
--	inner join Customers c2
--	on o2.CustomerID = c2.CustomerID
--group by SUBSTRING(c2.CompanyName, 1, 1), cat2.CategoryName
--order by SUBSTRING(c2.CompanyName, 1, 1)

/* Sub query de Total por Categoria */