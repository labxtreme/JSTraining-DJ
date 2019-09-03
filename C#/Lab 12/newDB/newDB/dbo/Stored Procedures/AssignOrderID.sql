CREATE Procedure [dbo].[AssignOrderID] @OrderID Int
AS 
Begin 
	Begin TRANSACTION;
	SAVE TRANSACTION MYsavepoint;

	Set @OrderID =@OrderID;

	BEGIN TRY
		Update dbo.Orders
		set OrderNumber = 345
		Where OrderID = @OrderID;

		Insert into [dbo].[OrderHistory] ([OrderHistoryDate],OrderID)
		values(GetDate(), @OrderID);
	Commit Transaction
	End TRY
	Begin catch
		IF @@TRANCOUNT>0
			Begin
				ROLLBACK TRANSACTION MYsavepoint;
			END
	END CATCH
END