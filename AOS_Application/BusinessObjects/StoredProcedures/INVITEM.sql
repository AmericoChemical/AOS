
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_INVITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_INVITEMLoadByPrimaryKey]
(
	@INVITEMNUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVITEMNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[CONTAINER], 
		[UNITCOST], 
		[UOM], 
		[UNITSREMAINING], 
		[LOTNUMBER], 
		[NOTE], 
		[ITEMSTATUS], 
		[RECEIVERNUMBER], 
		[RECEIVEDDATE], 
		[ALLOCATEDDOCUMENT], 
		[ALLOCATEDDATE], 
		[WORKORDERNUMBER], 
		[SHIPMENTNUMBER], 
		[SHIPPEDDATE], 
		[WAREHOUSENUMBER], 
		[WAREHOUSELOCATION], 
		[INVENTORYCLASS], 
		[TESTSAMPLEKEY]
	FROM [dbo].[INVITEM]
	WHERE
		([INVITEMNUMBER] = @INVITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVITEMLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_INVITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVITEMNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[CONTAINER], 
		[UNITCOST], 
		[UOM], 
		[UNITSREMAINING], 
		[LOTNUMBER], 
		[NOTE], 
		[ITEMSTATUS], 
		[RECEIVERNUMBER], 
		[RECEIVEDDATE], 
		[ALLOCATEDDOCUMENT], 
		[ALLOCATEDDATE], 
		[WORKORDERNUMBER], 
		[SHIPMENTNUMBER], 
		[SHIPPEDDATE], 
		[WAREHOUSENUMBER], 
		[WAREHOUSELOCATION], 
		[INVENTORYCLASS], 
		[TESTSAMPLEKEY]
	FROM [dbo].[INVITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVITEMUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_INVITEMUpdate]
(
	@INVITEMNUMBER int, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITCOST money = NULL, 
	@UOM varchar(50) = NULL, 
	@UNITSREMAINING float = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@NOTE varchar(MAX) = NULL, 
	@ITEMSTATUS varchar(50) = NULL, 
	@RECEIVERNUMBER int = NULL, 
	@RECEIVEDDATE datetime = NULL, 
	@ALLOCATEDDOCUMENT varchar(50) = NULL, 
	@ALLOCATEDDATE datetime = NULL, 
	@WORKORDERNUMBER int = NULL, 
	@SHIPMENTNUMBER int = NULL, 
	@SHIPPEDDATE datetime = NULL, 
	@WAREHOUSENUMBER int = NULL, 
	@WAREHOUSELOCATION varchar(50) = NULL, 
	@INVENTORYCLASS int = NULL, 
	@TESTSAMPLEKEY int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [INVITEM]
	SET
		[PRODUCTID] = @PRODUCTID, 
		[PRODUCTDESC] = @PRODUCTDESC, 
		[CONTAINER] = @CONTAINER, 
		[UNITCOST] = @UNITCOST, 
		[UOM] = @UOM, 
		[UNITSREMAINING] = @UNITSREMAINING, 
		[LOTNUMBER] = @LOTNUMBER, 
		[NOTE] = @NOTE, 
		[ITEMSTATUS] = @ITEMSTATUS, 
		[RECEIVERNUMBER] = @RECEIVERNUMBER, 
		[RECEIVEDDATE] = @RECEIVEDDATE, 
		[ALLOCATEDDOCUMENT] = @ALLOCATEDDOCUMENT, 
		[ALLOCATEDDATE] = @ALLOCATEDDATE, 
		[WORKORDERNUMBER] = @WORKORDERNUMBER, 
		[SHIPMENTNUMBER] = @SHIPMENTNUMBER, 
		[SHIPPEDDATE] = @SHIPPEDDATE, 
		[WAREHOUSENUMBER] = @WAREHOUSENUMBER, 
		[WAREHOUSELOCATION] = @WAREHOUSELOCATION, 
		[INVENTORYCLASS] = @INVENTORYCLASS, 
		[TESTSAMPLEKEY] = @TESTSAMPLEKEY
	WHERE
		([INVITEMNUMBER] = @INVITEMNUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVITEMInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_INVITEMInsert]
(
	@INVITEMNUMBER int = NULL OUTPUT, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITCOST money = NULL, 
	@UOM varchar(50) = NULL, 
	@UNITSREMAINING float = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@NOTE varchar(MAX) = NULL, 
	@ITEMSTATUS varchar(50) = NULL, 
	@RECEIVERNUMBER int = NULL, 
	@RECEIVEDDATE datetime = NULL, 
	@ALLOCATEDDOCUMENT varchar(50) = NULL, 
	@ALLOCATEDDATE datetime = NULL, 
	@WORKORDERNUMBER int = NULL, 
	@SHIPMENTNUMBER int = NULL, 
	@SHIPPEDDATE datetime = NULL, 
	@WAREHOUSENUMBER int = NULL, 
	@WAREHOUSELOCATION varchar(50) = NULL, 
	@INVENTORYCLASS int = NULL, 
	@TESTSAMPLEKEY int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [INVITEM]
	(
		[PRODUCTID], 
		[PRODUCTDESC], 
		[CONTAINER], 
		[UNITCOST], 
		[UOM], 
		[UNITSREMAINING], 
		[LOTNUMBER], 
		[NOTE], 
		[ITEMSTATUS], 
		[RECEIVERNUMBER], 
		[RECEIVEDDATE], 
		[ALLOCATEDDOCUMENT], 
		[ALLOCATEDDATE], 
		[WORKORDERNUMBER], 
		[SHIPMENTNUMBER], 
		[SHIPPEDDATE], 
		[WAREHOUSENUMBER], 
		[WAREHOUSELOCATION], 
		[INVENTORYCLASS], 
		[TESTSAMPLEKEY]
	)
	
	VALUES
	(
		@PRODUCTID, 
		@PRODUCTDESC, 
		@CONTAINER, 
		@UNITCOST, 
		@UOM, 
		@UNITSREMAINING, 
		@LOTNUMBER, 
		@NOTE, 
		@ITEMSTATUS, 
		@RECEIVERNUMBER, 
		@RECEIVEDDATE, 
		@ALLOCATEDDOCUMENT, 
		@ALLOCATEDDATE, 
		@WORKORDERNUMBER, 
		@SHIPMENTNUMBER, 
		@SHIPPEDDATE, 
		@WAREHOUSENUMBER, 
		@WAREHOUSELOCATION, 
		@INVENTORYCLASS, 
		@TESTSAMPLEKEY
	)

	SET @Err = @@Error

		
	SELECT @INVITEMNUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVITEMDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_INVITEMDelete]
(
	@INVITEMNUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[INVITEM]
	WHERE
		([INVITEMNUMBER] = @INVITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVITEMDelete Error on Creation'
GO 

