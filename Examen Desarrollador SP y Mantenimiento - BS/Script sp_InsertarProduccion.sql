USE [hramos_db]
GO

/****** Object:  StoredProcedure [dbo].[sp_InsertarProduccion]    Script Date: 1/8/2023 5:36:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Henry Ramos>
-- Create date: <08/01/2023>
/* Description:	<Almacena la produccion recibiendo como parametro los datos pertenecientes a la tabla [dbo].[Produccion] y 
				 utilizando la funcion [dbo].[fn_BuscarNuevoCodEquivalente] para obtener el nuevo codigo equivalente>
*/
-- =============================================
CREATE PROCEDURE [dbo].[sp_InsertarProduccion] 
	-- Add the parameters for the stored procedure here
	@Fecha datetime,
	@CodSeccion varchar(6),
	@CantidadUnid int,
	@CodSKU varchar(13),
	@Talla varchar(1),
	@Color varchar(15)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @CodItem varchar(13) 
	SET @CodItem = [dbo].[fn_BuscarNuevoCodEquivalente](@CodSKU, @Talla, @Color)

	INSERT INTO Produccion
	(
		[Fecha], [Codigo_Seccion], [Codigo_Item], [Cant_Unidades]
	)
	VALUES
	(
		@Fecha, @CodSeccion, @CodItem, @CantidadUnid
	)
END
GO


