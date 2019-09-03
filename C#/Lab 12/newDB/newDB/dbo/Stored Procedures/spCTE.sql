create procedure [dbo].[spCTE] ( @Quality int, @OrderID INT) AS
Begin 
	with CTE as 
	(select OrderDate from Orders where OrderID=@OrderID)
	Insert Into OrderDetails
	select @Quality, OrderDate From CTE
End