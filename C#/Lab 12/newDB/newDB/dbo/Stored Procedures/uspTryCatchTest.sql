﻿create procedure [dbo].[uspTryCatchTest]
AS
Begin Try
	SELECT 1/0
END TRY
BEGIN CATCH
	SELECT ERROR_NUMBER() AS ErrorNumber,
		ERROR_SEVERITY() AS ErrorSeverity,
		ERROR_STATE() as ErrorState,
		ERROR_PROCEDURE() as ErrorProcedure,
		ERROR_LINE() as ErrorLine,
		ERROR_MESSAGE() as ErrorMessage;
END CATCH