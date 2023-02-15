USE [hramos_db]
GO

/****** Object:  StoredProcedure [dbo].[sp_MostrarProduccion]    Script Date: 1/8/2023 6:06:07 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		<Henry Ramos>
-- Create date: <08/01/2023>
-- Description:	<Mostrar la informacion de la tabla [dbo].[Produccion]>
-- =============================================
CREATE PROCEDURE [dbo].[sp_MostrarProduccion]
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    SELECT Fecha, Codigo_Seccion, Codigo_Item, Cant_Unidades FROM [dbo].[Produccion]
END
GO


