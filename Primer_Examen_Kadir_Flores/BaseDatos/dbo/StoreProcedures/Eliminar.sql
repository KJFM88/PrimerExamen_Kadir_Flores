﻿CREATE PROCEDURE [dbo].[Eliminar]
	@Id_Intitucion INT

AS
 BEGIN
  SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

  BEGIN TRY

 DELETE FROM dbo.Institucion
  WHERE Id_Intitucion = @Id_Intitucion

  COMMIT TRANSACTION TRASA
  SELECT 0 AS CodError,'' AS MsgError

  END TRY

 BEGIN CATCH
   SELECT
		ERROR_NUMBER() AS CodError,
		ERROR_MESSAGE() AS MsgError

 ROLLBACK TRANSACTION TRASA

 END CATCH

 END

