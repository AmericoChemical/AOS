
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTDETAILLoadByPrimaryKey] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTDETAILLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTDETAILLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTDETAILLoadByPrimaryKey]
(
	@SHIPMENTDETAILID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SHIPMENTDETAILID], 
		[SHIPMENTNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYCONTAINERS], 
		[TOTALWEIGHT], 
		[BATCHNUMBER], 
		[STDWEIGHT], 
		[STDGALLONS], 
		[CONTAINER], 
		[DOTDESC], 
		[HAZMATDESC], 
		[UNLINE], 
		[CLASSRATE], 
		[LD1], 
		[LD2], 
		[LD3], 
		[BILLABLE], 
		[WORKORDERITEMNUMBER], 
		[ITEMTYPE]
	FROM [dbo].[SHIPMENTDETAIL]
	WHERE
		([SHIPMENTDETAILID] = @SHIPMENTDETAILID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTDETAILLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTDETAILLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTDETAILLoadAll] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTDETAILLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTDETAILLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTDETAILLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SHIPMENTDETAILID], 
		[SHIPMENTNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYCONTAINERS], 
		[TOTALWEIGHT], 
		[BATCHNUMBER], 
		[STDWEIGHT], 
		[STDGALLONS], 
		[CONTAINER], 
		[DOTDESC], 
		[HAZMATDESC], 
		[UNLINE], 
		[CLASSRATE], 
		[LD1], 
		[LD2], 
		[LD3], 
		[BILLABLE], 
		[WORKORDERITEMNUMBER], 
		[ITEMTYPE]
	FROM [dbo].[SHIPMENTDETAIL]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTDETAILLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTDETAILLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTDETAILUpdate] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTDETAILUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTDETAILUpdate];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTDETAILUpdate]
(
	@SHIPMENTDETAILID int, 
	@SHIPMENTNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QTYCONTAINERS int = NULL, 
	@TOTALWEIGHT int = NULL, 
	@BATCHNUMBER varchar(50) = NULL, 
	@STDWEIGHT int = NULL, 
	@STDGALLONS int = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@DOTDESC varchar(200) = NULL, 
	@HAZMATDESC varchar(200) = NULL, 
	@UNLINE varchar(200) = NULL, 
	@CLASSRATE varchar(50) = NULL, 
	@LD1 varchar(500) = NULL, 
	@LD2 varchar(500) = NULL, 
	@LD3 varchar(500) = NULL, 
	@BILLABLE bit = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@ITEMTYPE nchar(1) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [SHIPMENTDETAIL]
	SET
		[SHIPMENTNUMBER] = @SHIPMENTNUMBER, 
		[PRODUCTID] = @PRODUCTID, 
		[PRODUCTDESC] = @PRODUCTDESC, 
		[QTYCONTAINERS] = @QTYCONTAINERS, 
		[TOTALWEIGHT] = @TOTALWEIGHT, 
		[BATCHNUMBER] = @BATCHNUMBER, 
		[STDWEIGHT] = @STDWEIGHT, 
		[STDGALLONS] = @STDGALLONS, 
		[CONTAINER] = @CONTAINER, 
		[DOTDESC] = @DOTDESC, 
		[HAZMATDESC] = @HAZMATDESC, 
		[UNLINE] = @UNLINE, 
		[CLASSRATE] = @CLASSRATE, 
		[LD1] = @LD1, 
		[LD2] = @LD2, 
		[LD3] = @LD3, 
		[BILLABLE] = @BILLABLE, 
		[WORKORDERITEMNUMBER] = @WORKORDERITEMNUMBER, 
		[ITEMTYPE] = @ITEMTYPE
	WHERE
		([SHIPMENTDETAILID] = @SHIPMENTDETAILID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTDETAILUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTDETAILUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTDETAILInsert] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTDETAILInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTDETAILInsert];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTDETAILInsert]
(
	@SHIPMENTDETAILID int = NULL OUTPUT, 
	@SHIPMENTNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QTYCONTAINERS int = NULL, 
	@TOTALWEIGHT int = NULL, 
	@BATCHNUMBER varchar(50) = NULL, 
	@STDWEIGHT int = NULL, 
	@STDGALLONS int = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@DOTDESC varchar(200) = NULL, 
	@HAZMATDESC varchar(200) = NULL, 
	@UNLINE varchar(200) = NULL, 
	@CLASSRATE varchar(50) = NULL, 
	@LD1 varchar(500) = NULL, 
	@LD2 varchar(500) = NULL, 
	@LD3 varchar(500) = NULL, 
	@BILLABLE bit = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@ITEMTYPE nchar(1) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [SHIPMENTDETAIL]
	(
		[SHIPMENTNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYCONTAINERS], 
		[TOTALWEIGHT], 
		[BATCHNUMBER], 
		[STDWEIGHT], 
		[STDGALLONS], 
		[CONTAINER], 
		[DOTDESC], 
		[HAZMATDESC], 
		[UNLINE], 
		[CLASSRATE], 
		[LD1], 
		[LD2], 
		[LD3], 
		[BILLABLE], 
		[WORKORDERITEMNUMBER], 
		[ITEMTYPE]
	)
	
	VALUES
	(
		@SHIPMENTNUMBER, 
		@PRODUCTID, 
		@PRODUCTDESC, 
		@QTYCONTAINERS, 
		@TOTALWEIGHT, 
		@BATCHNUMBER, 
		@STDWEIGHT, 
		@STDGALLONS, 
		@CONTAINER, 
		@DOTDESC, 
		@HAZMATDESC, 
		@UNLINE, 
		@CLASSRATE, 
		@LD1, 
		@LD2, 
		@LD3, 
		@BILLABLE, 
		@WORKORDERITEMNUMBER, 
		@ITEMTYPE
	)

	SET @Err = @@Error

		
	SELECT @SHIPMENTDETAILID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTDETAILInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTDETAILInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTDETAILDelete] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTDETAILDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTDETAILDelete];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTDETAILDelete]
(
	@SHIPMENTDETAILID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[SHIPMENTDETAIL]
	WHERE
		([SHIPMENTDETAILID] = @SHIPMENTDETAILID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTDETAILDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTDETAILDelete Error on Creation'
GO 

