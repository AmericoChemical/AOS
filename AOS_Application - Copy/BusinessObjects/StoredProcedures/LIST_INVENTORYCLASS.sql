
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_INVENTORYCLASSLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVENTORYCLASSLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSLoadByPrimaryKey]
(
	@LookupID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LookupID], 
		[LookupGroup], 
		[LookupValue], 
		[LookupDesc]
	FROM [dbo].[LIST_INVENTORYCLASS]
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVENTORYCLASSLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVENTORYCLASSLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LookupID], 
		[LookupGroup], 
		[LookupValue], 
		[LookupDesc]
	FROM [dbo].[LIST_INVENTORYCLASS]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVENTORYCLASSUpdate] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVENTORYCLASSUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSUpdate]
(
	@LookupID int, 
	@LookupGroup varchar(50) = NULL, 
	@LookupValue int = NULL, 
	@LookupDesc varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_INVENTORYCLASS]
	SET
		[LookupGroup] = @LookupGroup, 
		[LookupValue] = @LookupValue, 
		[LookupDesc] = @LookupDesc
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVENTORYCLASSInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVENTORYCLASSInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSInsert]
(
	@LookupID int = NULL OUTPUT, 
	@LookupGroup varchar(50) = NULL, 
	@LookupValue int = NULL, 
	@LookupDesc varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_INVENTORYCLASS]
	(
		[LookupGroup], 
		[LookupValue], 
		[LookupDesc]
	)
	
	VALUES
	(
		@LookupGroup, 
		@LookupValue, 
		@LookupDesc
	)

	SET @Err = @@Error

		
	SELECT @LookupID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVENTORYCLASSDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVENTORYCLASSDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSDelete]
(
	@LookupID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_INVENTORYCLASS]
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSDelete Error on Creation'
GO 

