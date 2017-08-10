
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_LOADTYPELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_LOADTYPELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_LOADTYPELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_LOADTYPELoadByPrimaryKey]
(
	@RecID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[LoadType]
	FROM [dbo].[LIST_LOADTYPE]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_LOADTYPELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_LOADTYPELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_LOADTYPELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_LOADTYPELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_LOADTYPELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_LOADTYPELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[LoadType]
	FROM [dbo].[LIST_LOADTYPE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_LOADTYPELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_LOADTYPELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_LOADTYPEUpdate] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_LOADTYPEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_LOADTYPEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_LOADTYPEUpdate]
(
	@RecID int, 
	@LoadType varchar(24) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_LOADTYPE]
	SET
		[LoadType] = @LoadType
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_LOADTYPEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_LOADTYPEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_LOADTYPEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_LOADTYPEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_LOADTYPEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_LOADTYPEInsert]
(
	@RecID int, 
	@LoadType varchar(24) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_LOADTYPE]
	(
		[RecID], 
		[LoadType]
	)
	
	VALUES
	(
		@RecID, 
		@LoadType
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_LOADTYPEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_LOADTYPEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_LOADTYPEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_LOADTYPEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_LOADTYPEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_LOADTYPEDelete]
(
	@RecID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_LOADTYPE]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_LOADTYPEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_LOADTYPEDelete Error on Creation'
GO 

