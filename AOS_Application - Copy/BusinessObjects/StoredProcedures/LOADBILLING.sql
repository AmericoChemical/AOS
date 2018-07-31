
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LOADBILLINGLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADBILLINGLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADBILLINGLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LOADBILLINGLoadByPrimaryKey]
(
	@LOADBILLINGID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LOADBILLINGID], 
		[LOADID], 
		[CustomerID], 
		[CustomerPO], 
		[BilledAmount], 
		[BillingDate], 
		[CreatedBy], 
		[BillingEntity], 
		[InvoiceNumber], 
		[Status], 
		[BillingNote]
	FROM [dbo].[LOADBILLING]
	WHERE
		([LOADBILLINGID] = @LOADBILLINGID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADBILLINGLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADBILLINGLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADBILLINGLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADBILLINGLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADBILLINGLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LOADBILLINGLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LOADBILLINGID], 
		[LOADID], 
		[CustomerID], 
		[CustomerPO], 
		[BilledAmount], 
		[BillingDate], 
		[CreatedBy], 
		[BillingEntity], 
		[InvoiceNumber], 
		[Status], 
		[BillingNote]
	FROM [dbo].[LOADBILLING]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADBILLINGLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADBILLINGLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADBILLINGUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADBILLINGUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADBILLINGUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LOADBILLINGUpdate]
(
	@LOADBILLINGID int, 
	@LOADID int = NULL, 
	@CustomerID int = NULL, 
	@CustomerPO varchar(50) = NULL, 
	@BilledAmount decimal(18,2) = NULL, 
	@BillingDate datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@BillingEntity varchar(50) = NULL, 
	@InvoiceNumber int = NULL, 
	@Status varchar(50) = NULL, 
	@BillingNote varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LOADBILLING]
	SET
		[LOADID] = @LOADID, 
		[CustomerID] = @CustomerID, 
		[CustomerPO] = @CustomerPO, 
		[BilledAmount] = @BilledAmount, 
		[BillingDate] = @BillingDate, 
		[CreatedBy] = @CreatedBy, 
		[BillingEntity] = @BillingEntity, 
		[InvoiceNumber] = @InvoiceNumber, 
		[Status] = @Status, 
		[BillingNote] = @BillingNote
	WHERE
		([LOADBILLINGID] = @LOADBILLINGID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADBILLINGUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADBILLINGUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADBILLINGInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADBILLINGInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADBILLINGInsert];
GO

CREATE PROCEDURE [dbo].[proc_LOADBILLINGInsert]
(
	@LOADBILLINGID int = NULL OUTPUT, 
	@LOADID int = NULL, 
	@CustomerID int = NULL, 
	@CustomerPO varchar(50) = NULL, 
	@BilledAmount decimal(18,2) = NULL, 
	@BillingDate datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@BillingEntity varchar(50) = NULL, 
	@InvoiceNumber int = NULL, 
	@Status varchar(50) = NULL, 
	@BillingNote varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LOADBILLING]
	(
		[LOADID], 
		[CustomerID], 
		[CustomerPO], 
		[BilledAmount], 
		[BillingDate], 
		[CreatedBy], 
		[BillingEntity], 
		[InvoiceNumber], 
		[Status], 
		[BillingNote]
	)
	
	VALUES
	(
		@LOADID, 
		@CustomerID, 
		@CustomerPO, 
		@BilledAmount, 
		@BillingDate, 
		@CreatedBy, 
		@BillingEntity, 
		@InvoiceNumber, 
		@Status, 
		@BillingNote
	)

	SET @Err = @@Error

		
	SELECT @LOADBILLINGID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADBILLINGInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADBILLINGInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADBILLINGDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADBILLINGDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADBILLINGDelete];
GO

CREATE PROCEDURE [dbo].[proc_LOADBILLINGDelete]
(
	@LOADBILLINGID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LOADBILLING]
	WHERE
		([LOADBILLINGID] = @LOADBILLINGID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADBILLINGDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADBILLINGDelete Error on Creation'
GO 

