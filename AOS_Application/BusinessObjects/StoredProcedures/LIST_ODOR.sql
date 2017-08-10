
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_ODORLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ODORLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ODORLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ODORLoadByPrimaryKey]
(
	@ODOR varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ODOR]
	FROM [dbo].[LIST_ODOR]
	WHERE
		([ODOR] = @ODOR)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ODORLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ODORLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_ODORLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ODORLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ODORLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ODORLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ODOR]
	FROM [dbo].[LIST_ODOR]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ODORLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ODORLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ODORUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ODORUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_ODORInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ODORInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ODORInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ODORInsert]
(
	@ODOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_ODOR]
	(
		[ODOR]
	)
	
	VALUES
	(
		@ODOR
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ODORInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ODORInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_ODORDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ODORDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ODORDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ODORDelete]
(
	@ODOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_ODOR]
	WHERE
		([ODOR] = @ODOR)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ODORDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ODORDelete Error on Creation'
GO 

