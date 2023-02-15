USE [hramos_db]
GO

/****** Object:  UserDefinedFunction [dbo].[fn_BuscarNuevoCodEquivalente]    Script Date: 1/8/2023 6:08:17 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Henry Ramos>
-- Create date: <08/01/2023>
/* Description:	<Recibir 3 parametros (Codigo Antiguo, Talla y Color),
				 Concatenar los parametros en el formato estandar para referencia cruzada,
				 Buscar el valor en la tabla de referencia cruzada y devolver el nuevo codigo equivalente> */
-- =============================================
CREATE FUNCTION [dbo].[fn_BuscarNuevoCodEquivalente] 
(
	@CodAntiguo varchar(13),
	@Talla varchar(1),
	@Color varchar(15)
)
RETURNS varchar(13)
AS
BEGIN
	DECLARE @CodigoItem varchar(13);
	DECLARE @CodSKU varchar(13);

	Select @CodSKU = CONCAT(@CodAntiguo, '.', @Talla, '.', @Color);

	SELECT @CodigoItem = Codigo_Item from CodigosRefCruzada where Codigo_SKULegacy = @CodSKU

	-- Return the result of the function
	RETURN @CodigoItem

END
GO


