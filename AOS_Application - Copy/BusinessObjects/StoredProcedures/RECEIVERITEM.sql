
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_RECEIVERITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RECEIVERITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RECEIVERITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_RECEIVERITEMLoadByPrimaryKey]
(
	@RECEIVERITEMNUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECEIVERITEMNUMBER], 
		[RECEIVERNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYRECEIVED], 
		[CONTAINER], 
		[LOTNUMBER], 
		[WAREHOUSENUMBER], 
		[WAREHOUSELOCATION], 
		[POSTED], 
		[UNITCOST], 
		[UNITORCONTAINER], 
		[UNITS], 
		[UOM], 
		[INVENTORYCLASS]
	FROM [dbo].[RECEIVERITEM]
	WHERE
		([RECEIVERITEMNUMBER] = @RECEIVERITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RECEIVERITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_RECEIVERITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RECEIVERITEMLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RECEIVERITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RECEIVERITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_RECEIVERITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECEIVERITEMNUMBER], 
		[RECEIVERNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYRECEIVED], 
		[CONTAINER], 
		[LOTNUMBER], 
		[WAREHOUSENUMBER], 
		[WAREHOUSELOCATION], 
		[POSTED], 
		[UNITCOST], 
		[UNITORCONTAINER], 
		[UNITS], 
		[UOM], 
		[INVENTORYCLASS]
	FROM [dbo].[RECEIVERITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RECEIVERITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_RECEIVERITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RECEIVERITEMUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RECEIVERITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RECEIVERITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_RECEIVERITEMUpdate]
(
	@RECEIVERITEMNUMBER int, 
	@RECEIVERNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QTYRECEIVED numeric(18,4) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@WAREHOUSENUMBER int = NULL, 
	@WAREHOUSELOCATION varchar(50) = NULL, 
	@POSTED varchar(1) = NULL, 
	@UNITCOST decimal(18,4) = NULL, 
	@UNITORCONTAINER varchar(1) = NULL, 
	@UNITS int = NULL, 
	@UOM varchar(24) = NULL, 
	@INVENTORYCLASS int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [RECEIVERITEM]
	SET
		[RECEIVERNUMBER] = @RECEIVERNUMBER, 
		[PRODUCTID] = @PRODUCTID, 
		[PRODUCTDESC] = @PRODUCTDESC, 
		[QTYRECEIVED] = @QTYRECEIVED, 
		[CONTAINER] = @CONTAINER, 
		[LOTNUMBER] = @LOTNUMBER, 
		[WAREHOUSENUMBER] = @WAREHOUSENUMBER, 
		[WAREHOUSELOCATION] = @WAREHOUSELOCATION, 
		[POSTED] = @POSTED, 
		[UNITCOST] = @UNITCOST, 
		[UNITORCONTAINER] = @UNITORCONTAINER, 
		[UNITS] = @UNITS, 
		[UOM] = @UOM, 
		[INVENTORYCLASS] = @INVENTORYCLASS
	WHERE
		([RECEIVERITEMNUMBER] = @RECEIVERITEMNUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RECEIVERITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_RECEIVERITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RECEIVERITEMInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RECEIVERITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RECEIVERITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_RECEIVERITEMInsert]
(
	@RECEIVERITEMNUMBER int = NULL OUTPUT, 
	@RECEIVERNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QTYRECEIVED numeric(18,4) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@WAREHOUSENUMBER int = NULL, 
	@WAREHOUSELOCATION varchar(50) = NULL, 
	@POSTED varchar(1) = NULL, 
	@UNITCOST decimal(18,4) = NULL, 
	@UNITORCONTAINER varchar(1) = NULL, 
	@UNITS int = NULL, 
	@UOM varchar(24) = NULL, 
	@INVENTORYCLASS int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [RECEIVERITEM]
	(
		[RECEIVERNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYRECEIVED], 
		[CONTAINER], 
		[LOTNUMBER], 
		[WAREHOUSENUMBER], 
		[WAREHOUSELOCATION], 
		[POSTED], 
		[UNITCOST], 
		[UNITORCONTAINER], 
		[UNITS], 
		[UOM], 
		[INVENTORYCLASS]
	)
	
	VALUES
	(
		@RECEIVERNUMBER, 
		@PRODUCTID, 
		@PRODUCTDESC, 
		@QTYRECEIVED, 
		@CONTAINER, 
		@LOTNUMBER, 
		@WAREHOUSENUMBER, 
		@WAREHOUSELOCATION, 
		@POSTED, 
		@UNITCOST, 
		@UNITORCONTAINER, 
		@UNITS, 
		@UOM, 
		@INVENTORYCLASS
	)

	SET @Err = @@Error

		
	SELECT @RECEIVERITEMNUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RECEIVERITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_RECEIVERITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RECEIVERITEMDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RECEIVERITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RECEIVERITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_RECEIVERITEMDelete]
(
	@RECEIVERITEMNUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[RECEIVERITEM]
	WHERE
		([RECEIVERITEMNUMBER] = @RECEIVERITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RECEIVERITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_RECEIVERITEMDelete Error on Creation'
GO 

