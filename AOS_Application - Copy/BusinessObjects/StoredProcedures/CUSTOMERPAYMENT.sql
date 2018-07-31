
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERPAYMENTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERPAYMENTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERPAYMENTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERPAYMENTLoadByPrimaryKey]
(
	@CUSTOMERPMTID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CUSTOMERPMTID], 
		[CUSTID], 
		[PAYMENTDATE], 
		[PAYMENTAMOUNT], 
		[REMITTANCEADVICE], 
		[BALANCE]
	FROM [dbo].[CUSTOMERPAYMENT]
	WHERE
		([CUSTOMERPMTID] = @CUSTOMERPMTID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERPAYMENTLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERPAYMENTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERPAYMENTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERPAYMENTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CUSTOMERPMTID], 
		[CUSTID], 
		[PAYMENTDATE], 
		[PAYMENTAMOUNT], 
		[REMITTANCEADVICE], 
		[BALANCE]
	FROM [dbo].[CUSTOMERPAYMENT]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERPAYMENTUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERPAYMENTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERPAYMENTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERPAYMENTUpdate]
(
	@CUSTOMERPMTID int, 
	@CUSTID int = NULL, 
	@PAYMENTDATE datetime = NULL, 
	@PAYMENTAMOUNT money = NULL, 
	@REMITTANCEADVICE varchar(50) = NULL, 
	@BALANCE money = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CUSTOMERPAYMENT]
	SET
		[CUSTID] = @CUSTID, 
		[PAYMENTDATE] = @PAYMENTDATE, 
		[PAYMENTAMOUNT] = @PAYMENTAMOUNT, 
		[REMITTANCEADVICE] = @REMITTANCEADVICE, 
		[BALANCE] = @BALANCE
	WHERE
		([CUSTOMERPMTID] = @CUSTOMERPMTID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERPAYMENTInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERPAYMENTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERPAYMENTInsert];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERPAYMENTInsert]
(
	@CUSTOMERPMTID int = NULL OUTPUT, 
	@CUSTID int = NULL, 
	@PAYMENTDATE datetime = NULL, 
	@PAYMENTAMOUNT money = NULL, 
	@REMITTANCEADVICE varchar(50) = NULL, 
	@BALANCE money = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [CUSTOMERPAYMENT]
	(
		[CUSTID], 
		[PAYMENTDATE], 
		[PAYMENTAMOUNT], 
		[REMITTANCEADVICE], 
		[BALANCE]
	)
	
	VALUES
	(
		@CUSTID, 
		@PAYMENTDATE, 
		@PAYMENTAMOUNT, 
		@REMITTANCEADVICE, 
		@BALANCE
	)

	SET @Err = @@Error

		
	SELECT @CUSTOMERPMTID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERPAYMENTDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERPAYMENTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERPAYMENTDelete];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERPAYMENTDelete]
(
	@CUSTOMERPMTID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[CUSTOMERPAYMENT]
	WHERE
		([CUSTOMERPMTID] = @CUSTOMERPMTID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTDelete Error on Creation'
GO 

