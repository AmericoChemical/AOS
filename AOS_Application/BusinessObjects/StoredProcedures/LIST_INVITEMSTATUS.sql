
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_INVITEMSTATUSLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVITEMSTATUSLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSLoadByPrimaryKey]
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
	FROM [dbo].[LIST_INVITEMSTATUS]
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVITEMSTATUSLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVITEMSTATUSLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LookupID], 
		[LookupGroup], 
		[LookupValue], 
		[LookupDesc]
	FROM [dbo].[LIST_INVITEMSTATUS]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVITEMSTATUSUpdate] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVITEMSTATUSUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSUpdate]
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

	UPDATE [LIST_INVITEMSTATUS]
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
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVITEMSTATUSInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVITEMSTATUSInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSInsert]
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
	INTO [LIST_INVITEMSTATUS]
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
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVITEMSTATUSDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVITEMSTATUSDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSDelete]
(
	@LookupID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_INVITEMSTATUS]
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSDelete Error on Creation'
GO 

