
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PRICELISTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRICELISTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRICELISTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PRICELISTLoadByPrimaryKey]
(
	@PRICELISTID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRICELISTID], 
		[CUSTID], 
		[PRODUCTID], 
		[UNITS], 
		[CONTAINER], 
		[UNITPRICE], 
		[UOM], 
		[UNITORCONTAINER], 
		[EFFECTIVEDATE], 
		[TAXABLE], 
		[CONTAINERPRICE], 
		[CUSTOMERPRODUCTCODE]
	FROM [dbo].[PRICELIST]
	WHERE
		([PRICELISTID] = @PRICELISTID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRICELISTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRICELISTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRICELISTLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRICELISTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRICELISTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PRICELISTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRICELISTID], 
		[CUSTID], 
		[PRODUCTID], 
		[UNITS], 
		[CONTAINER], 
		[UNITPRICE], 
		[UOM], 
		[UNITORCONTAINER], 
		[EFFECTIVEDATE], 
		[TAXABLE], 
		[CONTAINERPRICE], 
		[CUSTOMERPRODUCTCODE]
	FROM [dbo].[PRICELIST]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRICELISTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRICELISTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRICELISTUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRICELISTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRICELISTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PRICELISTUpdate]
(
	@PRICELISTID int, 
	@CUSTID int = NULL, 
	@PRODUCTID int = NULL, 
	@UNITS numeric(18,4) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITPRICE money = NULL, 
	@UOM varchar(50) = NULL, 
	@UNITORCONTAINER varchar(1) = NULL, 
	@EFFECTIVEDATE datetime = NULL, 
	@TAXABLE bit = NULL, 
	@CONTAINERPRICE money = NULL, 
	@CUSTOMERPRODUCTCODE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PRICELIST]
	SET
		[CUSTID] = @CUSTID, 
		[PRODUCTID] = @PRODUCTID, 
		[UNITS] = @UNITS, 
		[CONTAINER] = @CONTAINER, 
		[UNITPRICE] = @UNITPRICE, 
		[UOM] = @UOM, 
		[UNITORCONTAINER] = @UNITORCONTAINER, 
		[EFFECTIVEDATE] = @EFFECTIVEDATE, 
		[TAXABLE] = @TAXABLE, 
		[CONTAINERPRICE] = @CONTAINERPRICE, 
		[CUSTOMERPRODUCTCODE] = @CUSTOMERPRODUCTCODE
	WHERE
		([PRICELISTID] = @PRICELISTID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRICELISTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRICELISTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRICELISTInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRICELISTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRICELISTInsert];
GO

CREATE PROCEDURE [dbo].[proc_PRICELISTInsert]
(
	@PRICELISTID int = NULL OUTPUT, 
	@CUSTID int = NULL, 
	@PRODUCTID int = NULL, 
	@UNITS numeric(18,4) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITPRICE money = NULL, 
	@UOM varchar(50) = NULL, 
	@UNITORCONTAINER varchar(1) = NULL, 
	@EFFECTIVEDATE datetime = NULL, 
	@TAXABLE bit = NULL, 
	@CONTAINERPRICE money = NULL, 
	@CUSTOMERPRODUCTCODE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PRICELIST]
	(
		[CUSTID], 
		[PRODUCTID], 
		[UNITS], 
		[CONTAINER], 
		[UNITPRICE], 
		[UOM], 
		[UNITORCONTAINER], 
		[EFFECTIVEDATE], 
		[TAXABLE], 
		[CONTAINERPRICE], 
		[CUSTOMERPRODUCTCODE]
	)
	
	VALUES
	(
		@CUSTID, 
		@PRODUCTID, 
		@UNITS, 
		@CONTAINER, 
		@UNITPRICE, 
		@UOM, 
		@UNITORCONTAINER, 
		@EFFECTIVEDATE, 
		@TAXABLE, 
		@CONTAINERPRICE, 
		@CUSTOMERPRODUCTCODE
	)

	SET @Err = @@Error

		
	SELECT @PRICELISTID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRICELISTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRICELISTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRICELISTDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRICELISTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRICELISTDelete];
GO

CREATE PROCEDURE [dbo].[proc_PRICELISTDelete]
(
	@PRICELISTID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PRICELIST]
	WHERE
		([PRICELISTID] = @PRICELISTID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRICELISTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRICELISTDelete Error on Creation'
GO 

