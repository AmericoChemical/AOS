
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LOOKUPLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOOKUPLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOOKUPLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LOOKUPLoadByPrimaryKey]
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
		[LookUpValue], 
		[LookupDesc]
	FROM [dbo].[LOOKUP]
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOOKUPLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOOKUPLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOOKUPLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOOKUPLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOOKUPLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LOOKUPLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LookupID], 
		[LookupGroup], 
		[LookUpValue], 
		[LookupDesc]
	FROM [dbo].[LOOKUP]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOOKUPLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOOKUPLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOOKUPUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOOKUPUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOOKUPUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LOOKUPUpdate]
(
	@LookupID int, 
	@LookupGroup varchar(50) = NULL, 
	@LookUpValue int = NULL, 
	@LookupDesc varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LOOKUP]
	SET
		[LookupGroup] = @LookupGroup, 
		[LookUpValue] = @LookUpValue, 
		[LookupDesc] = @LookupDesc
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOOKUPUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOOKUPUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOOKUPInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOOKUPInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOOKUPInsert];
GO

CREATE PROCEDURE [dbo].[proc_LOOKUPInsert]
(
	@LookupID int = NULL OUTPUT, 
	@LookupGroup varchar(50) = NULL, 
	@LookUpValue int = NULL, 
	@LookupDesc varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LOOKUP]
	(
		[LookupGroup], 
		[LookUpValue], 
		[LookupDesc]
	)
	
	VALUES
	(
		@LookupGroup, 
		@LookUpValue, 
		@LookupDesc
	)

	SET @Err = @@Error

		
	SELECT @LookupID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOOKUPInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOOKUPInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOOKUPDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOOKUPDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOOKUPDelete];
GO

CREATE PROCEDURE [dbo].[proc_LOOKUPDelete]
(
	@LookupID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LOOKUP]
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOOKUPDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOOKUPDelete Error on Creation'
GO 

