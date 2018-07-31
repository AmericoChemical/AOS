
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PRODPROCEDURELoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODPROCEDURELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODPROCEDURELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PRODPROCEDURELoadByPrimaryKey]
(
	@PRODPROCNUM int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODPROCNUM], 
		[PRODORDERNUM], 
		[SEQUENCE], 
		[PRODPROCEDURE]
	FROM [dbo].[PRODPROCEDURE]
	WHERE
		([PRODPROCNUM] = @PRODPROCNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODPROCEDURELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODPROCEDURELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODPROCEDURELoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODPROCEDURELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODPROCEDURELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PRODPROCEDURELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODPROCNUM], 
		[PRODORDERNUM], 
		[SEQUENCE], 
		[PRODPROCEDURE]
	FROM [dbo].[PRODPROCEDURE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODPROCEDURELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODPROCEDURELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODPROCEDUREUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODPROCEDUREUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODPROCEDUREUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PRODPROCEDUREUpdate]
(
	@PRODPROCNUM int, 
	@PRODORDERNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@PRODPROCEDURE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PRODPROCEDURE]
	SET
		[PRODORDERNUM] = @PRODORDERNUM, 
		[SEQUENCE] = @SEQUENCE, 
		[PRODPROCEDURE] = @PRODPROCEDURE
	WHERE
		([PRODPROCNUM] = @PRODPROCNUM)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODPROCEDUREUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODPROCEDUREUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODPROCEDUREInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODPROCEDUREInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODPROCEDUREInsert];
GO

CREATE PROCEDURE [dbo].[proc_PRODPROCEDUREInsert]
(
	@PRODPROCNUM int = NULL OUTPUT, 
	@PRODORDERNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@PRODPROCEDURE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PRODPROCEDURE]
	(
		[PRODORDERNUM], 
		[SEQUENCE], 
		[PRODPROCEDURE]
	)
	
	VALUES
	(
		@PRODORDERNUM, 
		@SEQUENCE, 
		@PRODPROCEDURE
	)

	SET @Err = @@Error

		
	SELECT @PRODPROCNUM = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODPROCEDUREInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODPROCEDUREInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODPROCEDUREDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODPROCEDUREDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODPROCEDUREDelete];
GO

CREATE PROCEDURE [dbo].[proc_PRODPROCEDUREDelete]
(
	@PRODPROCNUM int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PRODPROCEDURE]
	WHERE
		([PRODPROCNUM] = @PRODPROCNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODPROCEDUREDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODPROCEDUREDelete Error on Creation'
GO 

