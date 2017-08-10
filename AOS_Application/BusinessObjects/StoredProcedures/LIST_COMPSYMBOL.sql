
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_COMPSYMBOLLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMPSYMBOLLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMPSYMBOLLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMPSYMBOLLoadByPrimaryKey]
(
	@SYMBOL varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SYMBOL]
	FROM [dbo].[LIST_COMPSYMBOL]
	WHERE
		([SYMBOL] = @SYMBOL)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMPSYMBOLLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMPSYMBOLLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMPSYMBOLLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMPSYMBOLLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SYMBOL]
	FROM [dbo].[LIST_COMPSYMBOL]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMPSYMBOLInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMPSYMBOLInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMPSYMBOLInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMPSYMBOLInsert]
(
	@SYMBOL varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_COMPSYMBOL]
	(
		[SYMBOL]
	)
	
	VALUES
	(
		@SYMBOL
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMPSYMBOLDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMPSYMBOLDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMPSYMBOLDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMPSYMBOLDelete]
(
	@SYMBOL varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_COMPSYMBOL]
	WHERE
		([SYMBOL] = @SYMBOL)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLDelete Error on Creation'
GO 

