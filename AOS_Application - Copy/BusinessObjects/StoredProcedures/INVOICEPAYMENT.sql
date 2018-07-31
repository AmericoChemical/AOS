
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_INVOICEPAYMENTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEPAYMENTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEPAYMENTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEPAYMENTLoadByPrimaryKey]
(
	@INVOICEPMTID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVOICEPMTID], 
		[CUSTOMERPMTID], 
		[INVOICENUMBER], 
		[INVOICEPMTAMOUNT], 
		[INVOICEDISCOUNT], 
		[DISCOUNTREASON]
	FROM [dbo].[INVOICEPAYMENT]
	WHERE
		([INVOICEPMTID] = @INVOICEPMTID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEPAYMENTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEPAYMENTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEPAYMENTLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEPAYMENTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEPAYMENTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEPAYMENTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVOICEPMTID], 
		[CUSTOMERPMTID], 
		[INVOICENUMBER], 
		[INVOICEPMTAMOUNT], 
		[INVOICEDISCOUNT], 
		[DISCOUNTREASON]
	FROM [dbo].[INVOICEPAYMENT]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEPAYMENTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEPAYMENTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEPAYMENTUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEPAYMENTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEPAYMENTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEPAYMENTUpdate]
(
	@INVOICEPMTID int, 
	@CUSTOMERPMTID int = NULL, 
	@INVOICENUMBER int = NULL, 
	@INVOICEPMTAMOUNT money = NULL, 
	@INVOICEDISCOUNT money = NULL, 
	@DISCOUNTREASON varchar(100) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [INVOICEPAYMENT]
	SET
		[CUSTOMERPMTID] = @CUSTOMERPMTID, 
		[INVOICENUMBER] = @INVOICENUMBER, 
		[INVOICEPMTAMOUNT] = @INVOICEPMTAMOUNT, 
		[INVOICEDISCOUNT] = @INVOICEDISCOUNT, 
		[DISCOUNTREASON] = @DISCOUNTREASON
	WHERE
		([INVOICEPMTID] = @INVOICEPMTID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEPAYMENTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEPAYMENTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEPAYMENTInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEPAYMENTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEPAYMENTInsert];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEPAYMENTInsert]
(
	@INVOICEPMTID int = NULL OUTPUT, 
	@CUSTOMERPMTID int = NULL, 
	@INVOICENUMBER int = NULL, 
	@INVOICEPMTAMOUNT money = NULL, 
	@INVOICEDISCOUNT money = NULL, 
	@DISCOUNTREASON varchar(100) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [INVOICEPAYMENT]
	(
		[CUSTOMERPMTID], 
		[INVOICENUMBER], 
		[INVOICEPMTAMOUNT], 
		[INVOICEDISCOUNT], 
		[DISCOUNTREASON]
	)
	
	VALUES
	(
		@CUSTOMERPMTID, 
		@INVOICENUMBER, 
		@INVOICEPMTAMOUNT, 
		@INVOICEDISCOUNT, 
		@DISCOUNTREASON
	)

	SET @Err = @@Error

		
	SELECT @INVOICEPMTID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEPAYMENTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEPAYMENTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEPAYMENTDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEPAYMENTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEPAYMENTDelete];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEPAYMENTDelete]
(
	@INVOICEPMTID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[INVOICEPAYMENT]
	WHERE
		([INVOICEPMTID] = @INVOICEPMTID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEPAYMENTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEPAYMENTDelete Error on Creation'
GO 

