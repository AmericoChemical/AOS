
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_FOBLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_FOBLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_FOBLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_FOBLoadByPrimaryKey]
(
	@FOBOption varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[FOBOption]
	FROM [dbo].[LIST_FOB]
	WHERE
		([FOBOption] = @FOBOption)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_FOBLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_FOBLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_FOBLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_FOBLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_FOBLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_FOBLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[FOBOption]
	FROM [dbo].[LIST_FOB]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_FOBLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_FOBLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_FOBUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_FOBUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_FOBInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_FOBInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_FOBInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_FOBInsert]
(
	@FOBOption varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_FOB]
	(
		[FOBOption]
	)
	
	VALUES
	(
		@FOBOption
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_FOBInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_FOBInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_FOBDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_FOBDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_FOBDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_FOBDelete]
(
	@FOBOption varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_FOB]
	WHERE
		([FOBOption] = @FOBOption)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_FOBDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_FOBDelete Error on Creation'
GO 

