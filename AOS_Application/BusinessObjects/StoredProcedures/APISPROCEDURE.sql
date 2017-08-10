
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_APISPROCEDURELoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISPROCEDURELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISPROCEDURELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_APISPROCEDURELoadByPrimaryKey]
(
	@APISPROCNUM int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISPROCNUM], 
		[APISNUM], 
		[SEQUENCE], 
		[APISPROCEDURE]
	FROM [dbo].[APISPROCEDURE]
	WHERE
		([APISPROCNUM] = @APISPROCNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISPROCEDURELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISPROCEDURELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISPROCEDURELoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISPROCEDURELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISPROCEDURELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_APISPROCEDURELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISPROCNUM], 
		[APISNUM], 
		[SEQUENCE], 
		[APISPROCEDURE]
	FROM [dbo].[APISPROCEDURE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISPROCEDURELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISPROCEDURELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISPROCEDUREUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISPROCEDUREUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISPROCEDUREUpdate];
GO

CREATE PROCEDURE [dbo].[proc_APISPROCEDUREUpdate]
(
	@APISPROCNUM int, 
	@APISNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@APISPROCEDURE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [APISPROCEDURE]
	SET
		[APISNUM] = @APISNUM, 
		[SEQUENCE] = @SEQUENCE, 
		[APISPROCEDURE] = @APISPROCEDURE
	WHERE
		([APISPROCNUM] = @APISPROCNUM)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISPROCEDUREUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISPROCEDUREUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISPROCEDUREInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISPROCEDUREInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISPROCEDUREInsert];
GO

CREATE PROCEDURE [dbo].[proc_APISPROCEDUREInsert]
(
	@APISPROCNUM int = NULL OUTPUT, 
	@APISNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@APISPROCEDURE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [APISPROCEDURE]
	(
		[APISNUM], 
		[SEQUENCE], 
		[APISPROCEDURE]
	)
	
	VALUES
	(
		@APISNUM, 
		@SEQUENCE, 
		@APISPROCEDURE
	)

	SET @Err = @@Error

		
	SELECT @APISPROCNUM = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISPROCEDUREInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISPROCEDUREInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISPROCEDUREDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISPROCEDUREDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISPROCEDUREDelete];
GO

CREATE PROCEDURE [dbo].[proc_APISPROCEDUREDelete]
(
	@APISPROCNUM int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[APISPROCEDURE]
	WHERE
		([APISPROCNUM] = @APISPROCNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISPROCEDUREDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISPROCEDUREDelete Error on Creation'
GO 

