
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_APPUSERLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APPUSERLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APPUSERLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_APPUSERLoadByPrimaryKey]
(
	@USERLOGIN varchar(24)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[USERLOGIN], 
		[USERFULLNAME], 
		[USERPASSWORD], 
		[USERSECURITYLEVEL], 
		[REQUESTSCANNERPASSWORD], 
		[PREVENTSCANNERACCESS], 
		[SCANNERSESSIONTIMEOUT], 
		[SESSIONID], 
		[LOGINDATETIME]
	FROM [dbo].[APPUSER]
	WHERE
		([USERLOGIN] = @USERLOGIN)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APPUSERLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_APPUSERLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APPUSERLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APPUSERLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APPUSERLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_APPUSERLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[USERLOGIN], 
		[USERFULLNAME], 
		[USERPASSWORD], 
		[USERSECURITYLEVEL], 
		[REQUESTSCANNERPASSWORD], 
		[PREVENTSCANNERACCESS], 
		[SCANNERSESSIONTIMEOUT], 
		[SESSIONID], 
		[LOGINDATETIME]
	FROM [dbo].[APPUSER]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APPUSERLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_APPUSERLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APPUSERUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APPUSERUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APPUSERUpdate];
GO

CREATE PROCEDURE [dbo].[proc_APPUSERUpdate]
(
	@USERLOGIN varchar(24), 
	@USERFULLNAME varchar(50) = NULL, 
	@USERPASSWORD varchar(14) = NULL, 
	@USERSECURITYLEVEL int = NULL, 
	@REQUESTSCANNERPASSWORD bit = NULL, 
	@PREVENTSCANNERACCESS bit = NULL, 
	@SCANNERSESSIONTIMEOUT int = NULL, 
	@SESSIONID varchar(100) = NULL, 
	@LOGINDATETIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [APPUSER]
	SET
		[USERFULLNAME] = @USERFULLNAME, 
		[USERPASSWORD] = @USERPASSWORD, 
		[USERSECURITYLEVEL] = @USERSECURITYLEVEL, 
		[REQUESTSCANNERPASSWORD] = @REQUESTSCANNERPASSWORD, 
		[PREVENTSCANNERACCESS] = @PREVENTSCANNERACCESS, 
		[SCANNERSESSIONTIMEOUT] = @SCANNERSESSIONTIMEOUT, 
		[SESSIONID] = @SESSIONID, 
		[LOGINDATETIME] = @LOGINDATETIME
	WHERE
		([USERLOGIN] = @USERLOGIN)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APPUSERUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_APPUSERUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APPUSERInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APPUSERInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APPUSERInsert];
GO

CREATE PROCEDURE [dbo].[proc_APPUSERInsert]
(
	@USERLOGIN varchar(24), 
	@USERFULLNAME varchar(50) = NULL, 
	@USERPASSWORD varchar(14) = NULL, 
	@USERSECURITYLEVEL int = NULL, 
	@REQUESTSCANNERPASSWORD bit = NULL, 
	@PREVENTSCANNERACCESS bit = NULL, 
	@SCANNERSESSIONTIMEOUT int = NULL, 
	@SESSIONID varchar(100) = NULL, 
	@LOGINDATETIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [APPUSER]
	(
		[USERLOGIN], 
		[USERFULLNAME], 
		[USERPASSWORD], 
		[USERSECURITYLEVEL], 
		[REQUESTSCANNERPASSWORD], 
		[PREVENTSCANNERACCESS], 
		[SCANNERSESSIONTIMEOUT], 
		[SESSIONID], 
		[LOGINDATETIME]
	)
	
	VALUES
	(
		@USERLOGIN, 
		@USERFULLNAME, 
		@USERPASSWORD, 
		@USERSECURITYLEVEL, 
		@REQUESTSCANNERPASSWORD, 
		@PREVENTSCANNERACCESS, 
		@SCANNERSESSIONTIMEOUT, 
		@SESSIONID, 
		@LOGINDATETIME
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APPUSERInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_APPUSERInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APPUSERDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APPUSERDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APPUSERDelete];
GO

CREATE PROCEDURE [dbo].[proc_APPUSERDelete]
(
	@USERLOGIN varchar(24)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[APPUSER]
	WHERE
		([USERLOGIN] = @USERLOGIN)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APPUSERDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_APPUSERDelete Error on Creation'
GO 

