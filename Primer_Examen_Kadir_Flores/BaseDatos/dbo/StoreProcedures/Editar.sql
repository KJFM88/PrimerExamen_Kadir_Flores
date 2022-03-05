CREATE PROCEDURE dbo.Editar

	@Id_Intitucion INT,
	@Codigo VARCHAR(250),
	@Nombre VARCHAR(250),
	@Telefono VARCHAR(250),
	@Estado INT
AS
 BEGIN
  SET NOCOUNT ON

  BEGIN TRANSACTION TRASA

  BEGIN TRY

  UPDATE dbo.Institucion SET
  
    Codigo = @Codigo,
	Nombre = @Nombre,
	Telefono = @Telefono,
	Estado = @Estado
WHERE
	Id_Intitucion= @Id_Intitucion

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