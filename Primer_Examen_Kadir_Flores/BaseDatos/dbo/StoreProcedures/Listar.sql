CREATE PROCEDURE [dbo].[Listar]
	@Id_Intitucion INT = NULL
AS
BEGIN
	SET NOCOUNT ON

	SELECT
			Id_Intitucion,
			Codigo,
			Nombre,
			Telefono,
			Estado
	FROM
		dbo.Institucion
	WHERE
		(@Id_Intitucion IS NULL OR Id_Intitucion=@Id_Intitucion)

END