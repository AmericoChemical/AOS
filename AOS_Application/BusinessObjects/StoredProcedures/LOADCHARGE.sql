
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LOADCHARGELoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADCHARGELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADCHARGELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LOADCHARGELoadByPrimaryKey]
(
	@LoadChargeID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadChargeID], 
		[LoadID], 
		[CarrierID], 
		[LogisticsProviderID], 
		[CarrierCharges], 
		[ChargeType], 
		[ChargeDate], 
		[CreatedBy], 
		[LoadChargeStatus], 
		[ChargeNote]
	FROM [dbo].[LOADCHARGE]
	WHERE
		([LoadChargeID] = @LoadChargeID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADCHARGELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADCHARGELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADCHARGELoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADCHARGELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADCHARGELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LOADCHARGELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadChargeID], 
		[LoadID], 
		[CarrierID], 
		[LogisticsProviderID], 
		[CarrierCharges], 
		[ChargeType], 
		[ChargeDate], 
		[CreatedBy], 
		[LoadChargeStatus], 
		[ChargeNote]
	FROM [dbo].[LOADCHARGE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADCHARGELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADCHARGELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADCHARGEUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADCHARGEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADCHARGEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LOADCHARGEUpdate]
(
	@LoadChargeID int, 
	@LoadID int = NULL, 
	@CarrierID int = NULL, 
	@LogisticsProviderID int = NULL, 
	@CarrierCharges decimal(18,2) = NULL, 
	@ChargeType varchar(24) = NULL, 
	@ChargeDate datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@LoadChargeStatus varchar(50) = NULL, 
	@ChargeNote varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LOADCHARGE]
	SET
		[LoadID] = @LoadID, 
		[CarrierID] = @CarrierID, 
		[LogisticsProviderID] = @LogisticsProviderID, 
		[CarrierCharges] = @CarrierCharges, 
		[ChargeType] = @ChargeType, 
		[ChargeDate] = @ChargeDate, 
		[CreatedBy] = @CreatedBy, 
		[LoadChargeStatus] = @LoadChargeStatus, 
		[ChargeNote] = @ChargeNote
	WHERE
		([LoadChargeID] = @LoadChargeID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADCHARGEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADCHARGEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADCHARGEInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADCHARGEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADCHARGEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LOADCHARGEInsert]
(
	@LoadChargeID int = NULL OUTPUT, 
	@LoadID int = NULL, 
	@CarrierID int = NULL, 
	@LogisticsProviderID int = NULL, 
	@CarrierCharges decimal(18,2) = NULL, 
	@ChargeType varchar(24) = NULL, 
	@ChargeDate datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@LoadChargeStatus varchar(50) = NULL, 
	@ChargeNote varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LOADCHARGE]
	(
		[LoadID], 
		[CarrierID], 
		[LogisticsProviderID], 
		[CarrierCharges], 
		[ChargeType], 
		[ChargeDate], 
		[CreatedBy], 
		[LoadChargeStatus], 
		[ChargeNote]
	)
	
	VALUES
	(
		@LoadID, 
		@CarrierID, 
		@LogisticsProviderID, 
		@CarrierCharges, 
		@ChargeType, 
		@ChargeDate, 
		@CreatedBy, 
		@LoadChargeStatus, 
		@ChargeNote
	)

	SET @Err = @@Error

		
	SELECT @LoadChargeID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADCHARGEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADCHARGEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADCHARGEDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADCHARGEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADCHARGEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LOADCHARGEDelete]
(
	@LoadChargeID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LOADCHARGE]
	WHERE
		([LoadChargeID] = @LoadChargeID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADCHARGEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADCHARGEDelete Error on Creation'
GO 

