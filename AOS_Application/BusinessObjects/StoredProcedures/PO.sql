
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_POLoadByPrimaryKey] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_POLoadByPrimaryKey]
(
	@PONUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PONUMBER], 
		[VENDORID], 
		[PODATE], 
		[POTYPE], 
		[POTERMS], 
		[POSTATUS], 
		[CHANGEABLEPONUMBER], 
		[SHIPNAME], 
		[SHIPADDRESS1], 
		[SHIPADDRESS2], 
		[SHIPCITY], 
		[SHIPSTATE], 
		[SHIPZIP], 
		[SHIPCONTACT], 
		[SHIPPHONE], 
		[POSUBTOTAL], 
		[POSALESTAX], 
		[POFREIGHTIN], 
		[POTOTAL], 
		[INSTRUCTIONS], 
		[CUSTID], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	FROM [dbo].[PO]
	WHERE
		([PONUMBER] = @PONUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_POLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_POLoadAll] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_POLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PONUMBER], 
		[VENDORID], 
		[PODATE], 
		[POTYPE], 
		[POTERMS], 
		[POSTATUS], 
		[CHANGEABLEPONUMBER], 
		[SHIPNAME], 
		[SHIPADDRESS1], 
		[SHIPADDRESS2], 
		[SHIPCITY], 
		[SHIPSTATE], 
		[SHIPZIP], 
		[SHIPCONTACT], 
		[SHIPPHONE], 
		[POSUBTOTAL], 
		[POSALESTAX], 
		[POFREIGHTIN], 
		[POTOTAL], 
		[INSTRUCTIONS], 
		[CUSTID], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	FROM [dbo].[PO]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_POLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_POUpdate] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POUpdate];
GO

CREATE PROCEDURE [dbo].[proc_POUpdate]
(
	@PONUMBER int, 
	@VENDORID int = NULL, 
	@PODATE datetime = NULL, 
	@POTYPE varchar(24) = NULL, 
	@POTERMS varchar(50) = NULL, 
	@POSTATUS varchar(15) = NULL, 
	@CHANGEABLEPONUMBER varchar(50) = NULL, 
	@SHIPNAME varchar(50) = NULL, 
	@SHIPADDRESS1 varchar(50) = NULL, 
	@SHIPADDRESS2 varchar(50) = NULL, 
	@SHIPCITY varchar(50) = NULL, 
	@SHIPSTATE varchar(2) = NULL, 
	@SHIPZIP varchar(10) = NULL, 
	@SHIPCONTACT varchar(50) = NULL, 
	@SHIPPHONE varchar(20) = NULL, 
	@POSUBTOTAL money = NULL, 
	@POSALESTAX money = NULL, 
	@POFREIGHTIN money = NULL, 
	@POTOTAL money = NULL, 
	@INSTRUCTIONS varchar(MAX) = NULL, 
	@CUSTID int = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PO]
	SET
		[VENDORID] = @VENDORID, 
		[PODATE] = @PODATE, 
		[POTYPE] = @POTYPE, 
		[POTERMS] = @POTERMS, 
		[POSTATUS] = @POSTATUS, 
		[CHANGEABLEPONUMBER] = @CHANGEABLEPONUMBER, 
		[SHIPNAME] = @SHIPNAME, 
		[SHIPADDRESS1] = @SHIPADDRESS1, 
		[SHIPADDRESS2] = @SHIPADDRESS2, 
		[SHIPCITY] = @SHIPCITY, 
		[SHIPSTATE] = @SHIPSTATE, 
		[SHIPZIP] = @SHIPZIP, 
		[SHIPCONTACT] = @SHIPCONTACT, 
		[SHIPPHONE] = @SHIPPHONE, 
		[POSUBTOTAL] = @POSUBTOTAL, 
		[POSALESTAX] = @POSALESTAX, 
		[POFREIGHTIN] = @POFREIGHTIN, 
		[POTOTAL] = @POTOTAL, 
		[INSTRUCTIONS] = @INSTRUCTIONS, 
		[CUSTID] = @CUSTID, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME
	WHERE
		([PONUMBER] = @PONUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_POUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_POInsert] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POInsert];
GO

CREATE PROCEDURE [dbo].[proc_POInsert]
(
	@PONUMBER int = NULL OUTPUT, 
	@VENDORID int = NULL, 
	@PODATE datetime = NULL, 
	@POTYPE varchar(24) = NULL, 
	@POTERMS varchar(50) = NULL, 
	@POSTATUS varchar(15) = NULL, 
	@CHANGEABLEPONUMBER varchar(50) = NULL, 
	@SHIPNAME varchar(50) = NULL, 
	@SHIPADDRESS1 varchar(50) = NULL, 
	@SHIPADDRESS2 varchar(50) = NULL, 
	@SHIPCITY varchar(50) = NULL, 
	@SHIPSTATE varchar(2) = NULL, 
	@SHIPZIP varchar(10) = NULL, 
	@SHIPCONTACT varchar(50) = NULL, 
	@SHIPPHONE varchar(20) = NULL, 
	@POSUBTOTAL money = NULL, 
	@POSALESTAX money = NULL, 
	@POFREIGHTIN money = NULL, 
	@POTOTAL money = NULL, 
	@INSTRUCTIONS varchar(MAX) = NULL, 
	@CUSTID int = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PO]
	(
		[VENDORID], 
		[PODATE], 
		[POTYPE], 
		[POTERMS], 
		[POSTATUS], 
		[CHANGEABLEPONUMBER], 
		[SHIPNAME], 
		[SHIPADDRESS1], 
		[SHIPADDRESS2], 
		[SHIPCITY], 
		[SHIPSTATE], 
		[SHIPZIP], 
		[SHIPCONTACT], 
		[SHIPPHONE], 
		[POSUBTOTAL], 
		[POSALESTAX], 
		[POFREIGHTIN], 
		[POTOTAL], 
		[INSTRUCTIONS], 
		[CUSTID], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	)
	
	VALUES
	(
		@VENDORID, 
		@PODATE, 
		@POTYPE, 
		@POTERMS, 
		@POSTATUS, 
		@CHANGEABLEPONUMBER, 
		@SHIPNAME, 
		@SHIPADDRESS1, 
		@SHIPADDRESS2, 
		@SHIPCITY, 
		@SHIPSTATE, 
		@SHIPZIP, 
		@SHIPCONTACT, 
		@SHIPPHONE, 
		@POSUBTOTAL, 
		@POSALESTAX, 
		@POFREIGHTIN, 
		@POTOTAL, 
		@INSTRUCTIONS, 
		@CUSTID, 
		@CREATEDBY, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME
	)

	SET @Err = @@Error

		
	SELECT @PONUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_POInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PODelete] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PODelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PODelete];
GO

CREATE PROCEDURE [dbo].[proc_PODelete]
(
	@PONUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PO]
	WHERE
		([PONUMBER] = @PONUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PODelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PODelete Error on Creation'
GO 

