
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LOADQUOTELoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADQUOTELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADQUOTELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LOADQUOTELoadByPrimaryKey]
(
	@LoadQuoteID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadQuoteID], 
		[LoadID], 
		[CarrierID], 
		[LogisticsProviderID], 
		[QuoteAmount], 
		[QuoteDate], 
		[CarrierQuoteNumber]
	FROM [dbo].[LOADQUOTE]
	WHERE
		([LoadQuoteID] = @LoadQuoteID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADQUOTELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADQUOTELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADQUOTELoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADQUOTELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADQUOTELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LOADQUOTELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadQuoteID], 
		[LoadID], 
		[CarrierID], 
		[LogisticsProviderID], 
		[QuoteAmount], 
		[QuoteDate], 
		[CarrierQuoteNumber]
	FROM [dbo].[LOADQUOTE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADQUOTELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADQUOTELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADQUOTEUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADQUOTEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADQUOTEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LOADQUOTEUpdate]
(
	@LoadQuoteID int, 
	@LoadID int = NULL, 
	@CarrierID int = NULL, 
	@LogisticsProviderID int = NULL, 
	@QuoteAmount decimal(18,2) = NULL, 
	@QuoteDate datetime = NULL, 
	@CarrierQuoteNumber varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LOADQUOTE]
	SET
		[LoadID] = @LoadID, 
		[CarrierID] = @CarrierID, 
		[LogisticsProviderID] = @LogisticsProviderID, 
		[QuoteAmount] = @QuoteAmount, 
		[QuoteDate] = @QuoteDate, 
		[CarrierQuoteNumber] = @CarrierQuoteNumber
	WHERE
		([LoadQuoteID] = @LoadQuoteID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADQUOTEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADQUOTEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADQUOTEInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADQUOTEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADQUOTEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LOADQUOTEInsert]
(
	@LoadQuoteID int = NULL OUTPUT, 
	@LoadID int = NULL, 
	@CarrierID int = NULL, 
	@LogisticsProviderID int = NULL, 
	@QuoteAmount decimal(18,2) = NULL, 
	@QuoteDate datetime = NULL, 
	@CarrierQuoteNumber varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LOADQUOTE]
	(
		[LoadID], 
		[CarrierID], 
		[LogisticsProviderID], 
		[QuoteAmount], 
		[QuoteDate], 
		[CarrierQuoteNumber]
	)
	
	VALUES
	(
		@LoadID, 
		@CarrierID, 
		@LogisticsProviderID, 
		@QuoteAmount, 
		@QuoteDate, 
		@CarrierQuoteNumber
	)

	SET @Err = @@Error

		
	SELECT @LoadQuoteID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADQUOTEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADQUOTEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADQUOTEDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADQUOTEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADQUOTEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LOADQUOTEDelete]
(
	@LoadQuoteID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LOADQUOTE]
	WHERE
		([LoadQuoteID] = @LoadQuoteID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADQUOTEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADQUOTEDelete Error on Creation'
GO 

