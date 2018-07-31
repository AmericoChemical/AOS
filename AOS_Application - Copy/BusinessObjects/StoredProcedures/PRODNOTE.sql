
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PRODNOTELoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODNOTELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODNOTELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PRODNOTELoadByPrimaryKey]
(
	@PRODNOTENUM int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODNOTENUM], 
		[PRODORDERNUM], 
		[SEQUENCE], 
		[PRODNOTE]
	FROM [dbo].[PRODNOTE]
	WHERE
		([PRODNOTENUM] = @PRODNOTENUM)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODNOTELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODNOTELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODNOTELoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODNOTELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODNOTELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PRODNOTELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODNOTENUM], 
		[PRODORDERNUM], 
		[SEQUENCE], 
		[PRODNOTE]
	FROM [dbo].[PRODNOTE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODNOTELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODNOTELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODNOTEUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODNOTEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODNOTEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PRODNOTEUpdate]
(
	@PRODNOTENUM int, 
	@PRODORDERNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@PRODNOTE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PRODNOTE]
	SET
		[PRODORDERNUM] = @PRODORDERNUM, 
		[SEQUENCE] = @SEQUENCE, 
		[PRODNOTE] = @PRODNOTE
	WHERE
		([PRODNOTENUM] = @PRODNOTENUM)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODNOTEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODNOTEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODNOTEInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODNOTEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODNOTEInsert];
GO

CREATE PROCEDURE [dbo].[proc_PRODNOTEInsert]
(
	@PRODNOTENUM int = NULL OUTPUT, 
	@PRODORDERNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@PRODNOTE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PRODNOTE]
	(
		[PRODORDERNUM], 
		[SEQUENCE], 
		[PRODNOTE]
	)
	
	VALUES
	(
		@PRODORDERNUM, 
		@SEQUENCE, 
		@PRODNOTE
	)

	SET @Err = @@Error

		
	SELECT @PRODNOTENUM = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODNOTEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODNOTEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODNOTEDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODNOTEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODNOTEDelete];
GO

CREATE PROCEDURE [dbo].[proc_PRODNOTEDelete]
(
	@PRODNOTENUM int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PRODNOTE]
	WHERE
		([PRODNOTENUM] = @PRODNOTENUM)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODNOTEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODNOTEDelete Error on Creation'
GO 

