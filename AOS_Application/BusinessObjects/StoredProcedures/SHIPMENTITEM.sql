
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTITEMLoadByPrimaryKey]
(
	@SHIPMENTITEMNUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SHIPMENTITEMNUMBER], 
		[SHIPMENTNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYCONTAINERS], 
		[TOTALWEIGHT], 
		[LOTNUMBER], 
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
		[WORKORDERNUMBER], 
		[WORKORDERITEMNUMBER], 
		[INVITEMNUMBER], 
		[UNITS], 
		[UOM], 
		[UNITCOST]
	FROM [dbo].[SHIPMENTITEM]
	WHERE
		([SHIPMENTITEMNUMBER] = @SHIPMENTITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTITEMLoadAll] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SHIPMENTITEMNUMBER], 
		[SHIPMENTNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYCONTAINERS], 
		[TOTALWEIGHT], 
		[LOTNUMBER], 
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
		[WORKORDERNUMBER], 
		[WORKORDERITEMNUMBER], 
		[INVITEMNUMBER], 
		[UNITS], 
		[UOM], 
		[UNITCOST]
	FROM [dbo].[SHIPMENTITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTITEMUpdate] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTITEMUpdate]
(
	@SHIPMENTITEMNUMBER int, 
	@SHIPMENTNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QTYCONTAINERS int = NULL, 
	@TOTALWEIGHT int = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
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
	@WORKORDERNUMBER int = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@INVITEMNUMBER int = NULL, 
	@UNITS decimal(18,4) = NULL, 
	@UOM varchar(50) = NULL, 
	@UNITCOST decimal(18,4) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [SHIPMENTITEM]
	SET
		[SHIPMENTNUMBER] = @SHIPMENTNUMBER, 
		[PRODUCTID] = @PRODUCTID, 
		[PRODUCTDESC] = @PRODUCTDESC, 
		[QTYCONTAINERS] = @QTYCONTAINERS, 
		[TOTALWEIGHT] = @TOTALWEIGHT, 
		[LOTNUMBER] = @LOTNUMBER, 
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
		[WORKORDERNUMBER] = @WORKORDERNUMBER, 
		[WORKORDERITEMNUMBER] = @WORKORDERITEMNUMBER, 
		[INVITEMNUMBER] = @INVITEMNUMBER, 
		[UNITS] = @UNITS, 
		[UOM] = @UOM, 
		[UNITCOST] = @UNITCOST
	WHERE
		([SHIPMENTITEMNUMBER] = @SHIPMENTITEMNUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTITEMInsert] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTITEMInsert]
(
	@SHIPMENTITEMNUMBER int = NULL OUTPUT, 
	@SHIPMENTNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QTYCONTAINERS int = NULL, 
	@TOTALWEIGHT int = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
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
	@WORKORDERNUMBER int = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@INVITEMNUMBER int = NULL, 
	@UNITS decimal(18,4) = NULL, 
	@UOM varchar(50) = NULL, 
	@UNITCOST decimal(18,4) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [SHIPMENTITEM]
	(
		[SHIPMENTNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYCONTAINERS], 
		[TOTALWEIGHT], 
		[LOTNUMBER], 
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
		[WORKORDERNUMBER], 
		[WORKORDERITEMNUMBER], 
		[INVITEMNUMBER], 
		[UNITS], 
		[UOM], 
		[UNITCOST]
	)
	
	VALUES
	(
		@SHIPMENTNUMBER, 
		@PRODUCTID, 
		@PRODUCTDESC, 
		@QTYCONTAINERS, 
		@TOTALWEIGHT, 
		@LOTNUMBER, 
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
		@WORKORDERNUMBER, 
		@WORKORDERITEMNUMBER, 
		@INVITEMNUMBER, 
		@UNITS, 
		@UOM, 
		@UNITCOST
	)

	SET @Err = @@Error

		
	SELECT @SHIPMENTITEMNUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTITEMDelete] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTITEMDelete]
(
	@SHIPMENTITEMNUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[SHIPMENTITEM]
	WHERE
		([SHIPMENTITEMNUMBER] = @SHIPMENTITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTITEMDelete Error on Creation'
GO 

