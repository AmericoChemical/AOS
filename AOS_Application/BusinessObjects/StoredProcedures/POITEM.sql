
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_POITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_POITEMLoadByPrimaryKey]
(
	@POITEMNUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[POITEMNUMBER], 
		[PONUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYORDERED], 
		[QTYRELEASED], 
		[QTYRECEIVED], 
		[QTYCANCELED], 
		[VENDORITEMNUMBER], 
		[UNITCOST], 
		[EXTCOST], 
		[UOM], 
		[CONTAINER], 
		[UNITORCONTAINER], 
		[UNITS], 
		[EXPECTEDDELIVERY]
	FROM [dbo].[POITEM]
	WHERE
		([POITEMNUMBER] = @POITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_POITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_POITEMLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_POITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[POITEMNUMBER], 
		[PONUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYORDERED], 
		[QTYRELEASED], 
		[QTYRECEIVED], 
		[QTYCANCELED], 
		[VENDORITEMNUMBER], 
		[UNITCOST], 
		[EXTCOST], 
		[UOM], 
		[CONTAINER], 
		[UNITORCONTAINER], 
		[UNITS], 
		[EXPECTEDDELIVERY]
	FROM [dbo].[POITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_POITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_POITEMUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_POITEMUpdate]
(
	@POITEMNUMBER int, 
	@PONUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(150) = NULL, 
	@QTYORDERED numeric(18,4) = NULL, 
	@QTYRELEASED numeric(18,4) = NULL, 
	@QTYRECEIVED numeric(18,4) = NULL, 
	@QTYCANCELED numeric(18,4) = NULL, 
	@VENDORITEMNUMBER varchar(50) = NULL, 
	@UNITCOST money = NULL, 
	@EXTCOST money = NULL, 
	@UOM varchar(8) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITORCONTAINER varchar(1) = NULL, 
	@UNITS int = NULL, 
	@EXPECTEDDELIVERY datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [POITEM]
	SET
		[PONUMBER] = @PONUMBER, 
		[PRODUCTID] = @PRODUCTID, 
		[PRODUCTDESC] = @PRODUCTDESC, 
		[QTYORDERED] = @QTYORDERED, 
		[QTYRELEASED] = @QTYRELEASED, 
		[QTYRECEIVED] = @QTYRECEIVED, 
		[QTYCANCELED] = @QTYCANCELED, 
		[VENDORITEMNUMBER] = @VENDORITEMNUMBER, 
		[UNITCOST] = @UNITCOST, 
		[EXTCOST] = @EXTCOST, 
		[UOM] = @UOM, 
		[CONTAINER] = @CONTAINER, 
		[UNITORCONTAINER] = @UNITORCONTAINER, 
		[UNITS] = @UNITS, 
		[EXPECTEDDELIVERY] = @EXPECTEDDELIVERY
	WHERE
		([POITEMNUMBER] = @POITEMNUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_POITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_POITEMInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_POITEMInsert]
(
	@POITEMNUMBER int = NULL OUTPUT, 
	@PONUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(150) = NULL, 
	@QTYORDERED numeric(18,4) = NULL, 
	@QTYRELEASED numeric(18,4) = NULL, 
	@QTYRECEIVED numeric(18,4) = NULL, 
	@QTYCANCELED numeric(18,4) = NULL, 
	@VENDORITEMNUMBER varchar(50) = NULL, 
	@UNITCOST money = NULL, 
	@EXTCOST money = NULL, 
	@UOM varchar(8) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITORCONTAINER varchar(1) = NULL, 
	@UNITS int = NULL, 
	@EXPECTEDDELIVERY datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [POITEM]
	(
		[PONUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYORDERED], 
		[QTYRELEASED], 
		[QTYRECEIVED], 
		[QTYCANCELED], 
		[VENDORITEMNUMBER], 
		[UNITCOST], 
		[EXTCOST], 
		[UOM], 
		[CONTAINER], 
		[UNITORCONTAINER], 
		[UNITS], 
		[EXPECTEDDELIVERY]
	)
	
	VALUES
	(
		@PONUMBER, 
		@PRODUCTID, 
		@PRODUCTDESC, 
		@QTYORDERED, 
		@QTYRELEASED, 
		@QTYRECEIVED, 
		@QTYCANCELED, 
		@VENDORITEMNUMBER, 
		@UNITCOST, 
		@EXTCOST, 
		@UOM, 
		@CONTAINER, 
		@UNITORCONTAINER, 
		@UNITS, 
		@EXPECTEDDELIVERY
	)

	SET @Err = @@Error

		
	SELECT @POITEMNUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_POITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_POITEMDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_POITEMDelete]
(
	@POITEMNUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[POITEM]
	WHERE
		([POITEMNUMBER] = @POITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_POITEMDelete Error on Creation'
GO 

