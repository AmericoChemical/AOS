
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_INVENTORYSTATUSLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVENTORYSTATUSLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVENTORYSTATUSLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_INVENTORYSTATUSLoadByPrimaryKey]
(
	@INVENTORYSTATUS varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVENTORYSTATUS]
	FROM [dbo].[INVENTORYSTATUS]
	WHERE
		([INVENTORYSTATUS] = @INVENTORYSTATUS)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVENTORYSTATUSLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVENTORYSTATUSLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVENTORYSTATUSLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVENTORYSTATUSLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVENTORYSTATUSLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_INVENTORYSTATUSLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVENTORYSTATUS]
	FROM [dbo].[INVENTORYSTATUS]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVENTORYSTATUSLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVENTORYSTATUSLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVENTORYSTATUSUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVENTORYSTATUSUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVENTORYSTATUSInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVENTORYSTATUSInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVENTORYSTATUSInsert];
GO

CREATE PROCEDURE [dbo].[proc_INVENTORYSTATUSInsert]
(
	@INVENTORYSTATUS varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [INVENTORYSTATUS]
	(
		[INVENTORYSTATUS]
	)
	
	VALUES
	(
		@INVENTORYSTATUS
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVENTORYSTATUSInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVENTORYSTATUSInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVENTORYSTATUSDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVENTORYSTATUSDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVENTORYSTATUSDelete];
GO

CREATE PROCEDURE [dbo].[proc_INVENTORYSTATUSDelete]
(
	@INVENTORYSTATUS varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[INVENTORYSTATUS]
	WHERE
		([INVENTORYSTATUS] = @INVENTORYSTATUS)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVENTORYSTATUSDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVENTORYSTATUSDelete Error on Creation'
GO 

