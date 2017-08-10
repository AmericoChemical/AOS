
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_WAREHOUSELOCATIONLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WAREHOUSELOCATIONLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONLoadByPrimaryKey]
(
	@WHLOCID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[WHLOCID], 
		[WAREHOUSEID], 
		[WAREHOUSELOCATION]
	FROM [dbo].[LIST_WAREHOUSELOCATION]
	WHERE
		([WHLOCID] = @WHLOCID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WAREHOUSELOCATIONLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WAREHOUSELOCATIONLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[WHLOCID], 
		[WAREHOUSEID], 
		[WAREHOUSELOCATION]
	FROM [dbo].[LIST_WAREHOUSELOCATION]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WAREHOUSELOCATIONUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WAREHOUSELOCATIONUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONUpdate]
(
	@WHLOCID int, 
	@WAREHOUSEID int = NULL, 
	@WAREHOUSELOCATION varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_WAREHOUSELOCATION]
	SET
		[WAREHOUSEID] = @WAREHOUSEID, 
		[WAREHOUSELOCATION] = @WAREHOUSELOCATION
	WHERE
		([WHLOCID] = @WHLOCID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WAREHOUSELOCATIONInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WAREHOUSELOCATIONInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONInsert]
(
	@WHLOCID int = NULL OUTPUT, 
	@WAREHOUSEID int = NULL, 
	@WAREHOUSELOCATION varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_WAREHOUSELOCATION]
	(
		[WAREHOUSEID], 
		[WAREHOUSELOCATION]
	)
	
	VALUES
	(
		@WAREHOUSEID, 
		@WAREHOUSELOCATION
	)

	SET @Err = @@Error

		
	SELECT @WHLOCID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WAREHOUSELOCATIONDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WAREHOUSELOCATIONDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONDelete]
(
	@WHLOCID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_WAREHOUSELOCATION]
	WHERE
		([WHLOCID] = @WHLOCID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONDelete Error on Creation'
GO 

