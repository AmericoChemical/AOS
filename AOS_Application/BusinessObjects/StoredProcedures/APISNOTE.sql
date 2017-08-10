
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_APISNOTELoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISNOTELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISNOTELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_APISNOTELoadByPrimaryKey]
(
	@APISNOTEID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISNOTEID], 
		[APISNUM], 
		[SEQUENCE], 
		[APISNOTE]
	FROM [dbo].[APISNOTE]
	WHERE
		([APISNOTEID] = @APISNOTEID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISNOTELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISNOTELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISNOTELoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISNOTELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISNOTELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_APISNOTELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISNOTEID], 
		[APISNUM], 
		[SEQUENCE], 
		[APISNOTE]
	FROM [dbo].[APISNOTE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISNOTELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISNOTELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISNOTEUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISNOTEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISNOTEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_APISNOTEUpdate]
(
	@APISNOTEID int, 
	@APISNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@APISNOTE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [APISNOTE]
	SET
		[APISNUM] = @APISNUM, 
		[SEQUENCE] = @SEQUENCE, 
		[APISNOTE] = @APISNOTE
	WHERE
		([APISNOTEID] = @APISNOTEID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISNOTEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISNOTEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISNOTEInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISNOTEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISNOTEInsert];
GO

CREATE PROCEDURE [dbo].[proc_APISNOTEInsert]
(
	@APISNOTEID int = NULL OUTPUT, 
	@APISNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@APISNOTE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [APISNOTE]
	(
		[APISNUM], 
		[SEQUENCE], 
		[APISNOTE]
	)
	
	VALUES
	(
		@APISNUM, 
		@SEQUENCE, 
		@APISNOTE
	)

	SET @Err = @@Error

		
	SELECT @APISNOTEID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISNOTEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISNOTEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISNOTEDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISNOTEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISNOTEDelete];
GO

CREATE PROCEDURE [dbo].[proc_APISNOTEDelete]
(
	@APISNOTEID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[APISNOTE]
	WHERE
		([APISNOTEID] = @APISNOTEID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISNOTEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISNOTEDelete Error on Creation'
GO 

