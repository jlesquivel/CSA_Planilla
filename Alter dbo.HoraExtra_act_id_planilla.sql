USE [planilla]
GO

/****** Objeto: SqlProcedure [dbo].[HoraExtra_act_id_planilla] Fecha del script: 01/08/2016 11:23:06 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		JOSE LUIS ESQUIVEL
-- Create date: 27/6/2016
-- Description:	Actualizar en la planilla que se pago llas horas extras
-- =============================================
ALTER PROCEDURE [dbo].[HoraExtra_act_id_planilla] 
	@id_planilla numeric(18,0) = 0
AS
BEGIN

SET NOCOUNT ON;
declare @fini date, @ffin as date
declare @id_emp numeric(18,0)

SELECT @fini = fecha_ini
	,@ffin = fecha_fin
FROM Planillas
WHERE id_planilla = @id_planilla

DECLARE empleados CURSOR 
FOR

SELECT dbo.fid_empXid_contrato(id_contrato) as id_emp
  FROM [planilla].[dbo].[pagos]
where id_planilla = @id_planilla

OPEN empleados 
FETCH empleados INTO @id_emp

 WHILE (@@FETCH_STATUS = 0) BEGIN	

		UPDATE  horas_extras
		SET  id_planilla = @id_planilla
		WHERE (fecha BETWEEN @fini AND @ffin) AND (id_emp = @id_emp)

		FETCH empleados INTO @id_emp
END -- Fin del bucle WHILE

CLOSE empleados
DEALLOCATE empleados

END
