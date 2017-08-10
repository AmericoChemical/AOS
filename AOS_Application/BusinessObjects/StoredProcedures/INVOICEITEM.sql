
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_INVOICEITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEITEMLoadByPrimaryKey]
(
	@INVOICEITEMNUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVOICEITEMNUMBER], 
		[INVOICENUMBER], 
		[SHIPMENTDETAILID], 
		[INVITEMNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QUANTITY], 
		[CONTAINER], 
		[UNITS], 
		[UOM], 
		[ITEMPRICE], 
		[EXTPRICE], 
		[UNITCOST], 
		[EXTCOST], 
		[GROSSPROFIT], 
		[TAXABLE], 
		[WORKORDERITEMNUMBER], 
		[UNITORCONTAINER]
	FROM [dbo].[INVOICEITEM]
	WHERE
		([INVOICEITEMNUMBER] = @INVOICEITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEITEMLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVOICEITEMNUMBER], 
		[INVOICENUMBER], 
		[SHIPMENTDETAILID], 
		[INVITEMNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QUANTITY], 
		[CONTAINER], 
		[UNITS], 
		[UOM], 
		[ITEMPRICE], 
		[EXTPRICE], 
		[UNITCOST], 
		[EXTCOST], 
		[GROSSPROFIT], 
		[TAXABLE], 
		[WORKORDERITEMNUMBER], 
		[UNITORCONTAINER]
	FROM [dbo].[INVOICEITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEITEMUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEITEMUpdate]
(
	@INVOICEITEMNUMBER int, 
	@INVOICENUMBER int = NULL, 
	@SHIPMENTDETAILID int = NULL, 
	@INVITEMNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QUANTITY numeric(18,4) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITS int = NULL, 
	@UOM varchar(50) = NULL, 
	@ITEMPRICE money = NULL, 
	@EXTPRICE money = NULL, 
	@UNITCOST money = NULL, 
	@EXTCOST money = NULL, 
	@GROSSPROFIT money = NULL, 
	@TAXABLE bit = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@UNITORCONTAINER varchar(1) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [INVOICEITEM]
	SET
		[INVOICENUMBER] = @INVOICENUMBER, 
		[SHIPMENTDETAILID] = @SHIPMENTDETAILID, 
		[INVITEMNUMBER] = @INVITEMNUMBER, 
		[PRODUCTID] = @PRODUCTID, 
		[PRODUCTDESC] = @PRODUCTDESC, 
		[QUANTITY] = @QUANTITY, 
		[CONTAINER] = @CONTAINER, 
		[UNITS] = @UNITS, 
		[UOM] = @UOM, 
		[ITEMPRICE] = @ITEMPRICE, 
		[EXTPRICE] = @EXTPRICE, 
		[UNITCOST] = @UNITCOST, 
		[EXTCOST] = @EXTCOST, 
		[GROSSPROFIT] = @GROSSPROFIT, 
		[TAXABLE] = @TAXABLE, 
		[WORKORDERITEMNUMBER] = @WORKORDERITEMNUMBER, 
		[UNITORCONTAINER] = @UNITORCONTAINER
	WHERE
		([INVOICEITEMNUMBER] = @INVOICEITEMNUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEITEMInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEITEMInsert]
(
	@INVOICEITEMNUMBER int = NULL OUTPUT, 
	@INVOICENUMBER int = NULL, 
	@SHIPMENTDETAILID int = NULL, 
	@INVITEMNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QUANTITY numeric(18,4) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITS int = NULL, 
	@UOM varchar(50) = NULL, 
	@ITEMPRICE money = NULL, 
	@EXTPRICE money = NULL, 
	@UNITCOST money = NULL, 
	@EXTCOST money = NULL, 
	@GROSSPROFIT money = NULL, 
	@TAXABLE bit = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@UNITORCONTAINER varchar(1) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [INVOICEITEM]
	(
		[INVOICENUMBER], 
		[SHIPMENTDETAILID], 
		[INVITEMNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QUANTITY], 
		[CONTAINER], 
		[UNITS], 
		[UOM], 
		[ITEMPRICE], 
		[EXTPRICE], 
		[UNITCOST], 
		[EXTCOST], 
		[GROSSPROFIT], 
		[TAXABLE], 
		[WORKORDERITEMNUMBER], 
		[UNITORCONTAINER]
	)
	
	VALUES
	(
		@INVOICENUMBER, 
		@SHIPMENTDETAILID, 
		@INVITEMNUMBER, 
		@PRODUCTID, 
		@PRODUCTDESC, 
		@QUANTITY, 
		@CONTAINER, 
		@UNITS, 
		@UOM, 
		@ITEMPRICE, 
		@EXTPRICE, 
		@UNITCOST, 
		@EXTCOST, 
		@GROSSPROFIT, 
		@TAXABLE, 
		@WORKORDERITEMNUMBER, 
		@UNITORCONTAINER
	)

	SET @Err = @@Error

		
	SELECT @INVOICEITEMNUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEITEMDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEITEMDelete]
(
	@INVOICEITEMNUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[INVOICEITEM]
	WHERE
		([INVOICEITEMNUMBER] = @INVOICEITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEITEMDelete Error on Creation'
GO 

