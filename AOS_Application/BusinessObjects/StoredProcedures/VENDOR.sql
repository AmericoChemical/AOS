
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_VENDORLoadByPrimaryKey] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_VENDORLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_VENDORLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_VENDORLoadByPrimaryKey]
(
	@VENDORID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[VENDORID], 
		[VENDORNAME], 
		[VENDORADDRESS1], 
		[VENDORADDRESS2], 
		[VENDORCITY], 
		[VENDORSTATE], 
		[VENDORZIP], 
		[VENDORPHONE], 
		[VENDORFAX], 
		[VENDORCONTACT], 
		[VENDOREMAIL], 
		[VENDORURL], 
		[VENDORACCTNUMBER], 
		[TERMS], 
		[VENDORNOTES], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE]
	FROM [dbo].[VENDOR]
	WHERE
		([VENDORID] = @VENDORID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_VENDORLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_VENDORLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_VENDORLoadAll] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_VENDORLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_VENDORLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_VENDORLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[VENDORID], 
		[VENDORNAME], 
		[VENDORADDRESS1], 
		[VENDORADDRESS2], 
		[VENDORCITY], 
		[VENDORSTATE], 
		[VENDORZIP], 
		[VENDORPHONE], 
		[VENDORFAX], 
		[VENDORCONTACT], 
		[VENDOREMAIL], 
		[VENDORURL], 
		[VENDORACCTNUMBER], 
		[TERMS], 
		[VENDORNOTES], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE]
	FROM [dbo].[VENDOR]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_VENDORLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_VENDORLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_VENDORUpdate] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_VENDORUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_VENDORUpdate];
GO

CREATE PROCEDURE [dbo].[proc_VENDORUpdate]
(
	@VENDORID int, 
	@VENDORNAME varchar(50) = NULL, 
	@VENDORADDRESS1 varchar(50) = NULL, 
	@VENDORADDRESS2 varchar(50) = NULL, 
	@VENDORCITY varchar(50) = NULL, 
	@VENDORSTATE varchar(2) = NULL, 
	@VENDORZIP varchar(10) = NULL, 
	@VENDORPHONE varchar(20) = NULL, 
	@VENDORFAX varchar(20) = NULL, 
	@VENDORCONTACT varchar(50) = NULL, 
	@VENDOREMAIL varchar(100) = NULL, 
	@VENDORURL varchar(50) = NULL, 
	@VENDORACCTNUMBER varchar(50) = NULL, 
	@TERMS varchar(50) = NULL, 
	@VENDORNOTES varchar(MAX) = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@ISACTIVE bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [VENDOR]
	SET
		[VENDORNAME] = @VENDORNAME, 
		[VENDORADDRESS1] = @VENDORADDRESS1, 
		[VENDORADDRESS2] = @VENDORADDRESS2, 
		[VENDORCITY] = @VENDORCITY, 
		[VENDORSTATE] = @VENDORSTATE, 
		[VENDORZIP] = @VENDORZIP, 
		[VENDORPHONE] = @VENDORPHONE, 
		[VENDORFAX] = @VENDORFAX, 
		[VENDORCONTACT] = @VENDORCONTACT, 
		[VENDOREMAIL] = @VENDOREMAIL, 
		[VENDORURL] = @VENDORURL, 
		[VENDORACCTNUMBER] = @VENDORACCTNUMBER, 
		[TERMS] = @TERMS, 
		[VENDORNOTES] = @VENDORNOTES, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME, 
		[ISACTIVE] = @ISACTIVE
	WHERE
		([VENDORID] = @VENDORID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_VENDORUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_VENDORUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_VENDORInsert] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_VENDORInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_VENDORInsert];
GO

CREATE PROCEDURE [dbo].[proc_VENDORInsert]
(
	@VENDORID int = NULL OUTPUT, 
	@VENDORNAME varchar(50) = NULL, 
	@VENDORADDRESS1 varchar(50) = NULL, 
	@VENDORADDRESS2 varchar(50) = NULL, 
	@VENDORCITY varchar(50) = NULL, 
	@VENDORSTATE varchar(2) = NULL, 
	@VENDORZIP varchar(10) = NULL, 
	@VENDORPHONE varchar(20) = NULL, 
	@VENDORFAX varchar(20) = NULL, 
	@VENDORCONTACT varchar(50) = NULL, 
	@VENDOREMAIL varchar(100) = NULL, 
	@VENDORURL varchar(50) = NULL, 
	@VENDORACCTNUMBER varchar(50) = NULL, 
	@TERMS varchar(50) = NULL, 
	@VENDORNOTES varchar(MAX) = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@ISACTIVE bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [VENDOR]
	(
		[VENDORNAME], 
		[VENDORADDRESS1], 
		[VENDORADDRESS2], 
		[VENDORCITY], 
		[VENDORSTATE], 
		[VENDORZIP], 
		[VENDORPHONE], 
		[VENDORFAX], 
		[VENDORCONTACT], 
		[VENDOREMAIL], 
		[VENDORURL], 
		[VENDORACCTNUMBER], 
		[TERMS], 
		[VENDORNOTES], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE]
	)
	
	VALUES
	(
		@VENDORNAME, 
		@VENDORADDRESS1, 
		@VENDORADDRESS2, 
		@VENDORCITY, 
		@VENDORSTATE, 
		@VENDORZIP, 
		@VENDORPHONE, 
		@VENDORFAX, 
		@VENDORCONTACT, 
		@VENDOREMAIL, 
		@VENDORURL, 
		@VENDORACCTNUMBER, 
		@TERMS, 
		@VENDORNOTES, 
		@CREATEDBY, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME, 
		@ISACTIVE
	)

	SET @Err = @@Error

		
	SELECT @VENDORID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_VENDORInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_VENDORInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_VENDORDelete] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_VENDORDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_VENDORDelete];
GO

CREATE PROCEDURE [dbo].[proc_VENDORDelete]
(
	@VENDORID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[VENDOR]
	WHERE
		([VENDORID] = @VENDORID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_VENDORDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_VENDORDelete Error on Creation'
GO 

