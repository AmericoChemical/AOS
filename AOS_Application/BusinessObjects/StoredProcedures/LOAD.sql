
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LOADLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LOADLoadByPrimaryKey]
(
	@LoadID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadID], 
		[LoadStatus], 
		[LoadType], 
		[PlannedDepartureDate], 
		[PlannedDeliveryDate], 
		[CustID], 
		[OriginType], 
		[OriginID], 
		[OriginName], 
		[OriginAddress1], 
		[OriginAddress2], 
		[OriginCity], 
		[OriginState], 
		[OriginZip], 
		[OriginCountry], 
		[OriginPhone], 
		[OriginContact], 
		[PickupHours], 
		[DestType], 
		[DestID], 
		[DestName], 
		[DestAddress1], 
		[DestAddress2], 
		[DestCity], 
		[DestState], 
		[DestZip], 
		[DestCountry], 
		[DestPhone], 
		[DestContact], 
		[DeliveryHours], 
		[CarrierID], 
		[LogisticsID], 
		[FOB], 
		[BillCustomer], 
		[AddToInvoice], 
		[LoadNotes], 
		[CreatedTime], 
		[CreatedBy], 
		[ModifiedTime], 
		[ModifiedBy], 
		[ScheduledCarrierID], 
		[ScheduledLogisticsID], 
		[ScheduledShipmentDate], 
		[QuoteID], 
		[CarrierProNumber], 
		[ActualShipmentDate], 
		[ActualDeliveryDate]
	FROM [dbo].[LOAD]
	WHERE
		([LoadID] = @LoadID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LOADLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadID], 
		[LoadStatus], 
		[LoadType], 
		[PlannedDepartureDate], 
		[PlannedDeliveryDate], 
		[CustID], 
		[OriginType], 
		[OriginID], 
		[OriginName], 
		[OriginAddress1], 
		[OriginAddress2], 
		[OriginCity], 
		[OriginState], 
		[OriginZip], 
		[OriginCountry], 
		[OriginPhone], 
		[OriginContact], 
		[PickupHours], 
		[DestType], 
		[DestID], 
		[DestName], 
		[DestAddress1], 
		[DestAddress2], 
		[DestCity], 
		[DestState], 
		[DestZip], 
		[DestCountry], 
		[DestPhone], 
		[DestContact], 
		[DeliveryHours], 
		[CarrierID], 
		[LogisticsID], 
		[FOB], 
		[BillCustomer], 
		[AddToInvoice], 
		[LoadNotes], 
		[CreatedTime], 
		[CreatedBy], 
		[ModifiedTime], 
		[ModifiedBy], 
		[ScheduledCarrierID], 
		[ScheduledLogisticsID], 
		[ScheduledShipmentDate], 
		[QuoteID], 
		[CarrierProNumber], 
		[ActualShipmentDate], 
		[ActualDeliveryDate]
	FROM [dbo].[LOAD]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LOADUpdate]
(
	@LoadID int, 
	@LoadStatus varchar(50) = NULL, 
	@LoadType varchar(24) = NULL, 
	@PlannedDepartureDate datetime = NULL, 
	@PlannedDeliveryDate datetime = NULL, 
	@CustID int = NULL, 
	@OriginType varchar(50) = NULL, 
	@OriginID int = NULL, 
	@OriginName varchar(50) = NULL, 
	@OriginAddress1 varchar(50) = NULL, 
	@OriginAddress2 varchar(50) = NULL, 
	@OriginCity varchar(50) = NULL, 
	@OriginState varchar(50) = NULL, 
	@OriginZip varchar(24) = NULL, 
	@OriginCountry varchar(50) = NULL, 
	@OriginPhone varchar(50) = NULL, 
	@OriginContact varchar(50) = NULL, 
	@PickupHours varchar(50) = NULL, 
	@DestType varchar(50) = NULL, 
	@DestID int = NULL, 
	@DestName varchar(50) = NULL, 
	@DestAddress1 varchar(50) = NULL, 
	@DestAddress2 varchar(50) = NULL, 
	@DestCity varchar(50) = NULL, 
	@DestState varchar(50) = NULL, 
	@DestZip varchar(24) = NULL, 
	@DestCountry varchar(50) = NULL, 
	@DestPhone varchar(50) = NULL, 
	@DestContact varchar(50) = NULL, 
	@DeliveryHours varchar(50) = NULL, 
	@CarrierID int = NULL, 
	@LogisticsID int = NULL, 
	@FOB varchar(50) = NULL, 
	@BillCustomer bit = NULL, 
	@AddToInvoice bit = NULL, 
	@LoadNotes varchar(MAX) = NULL, 
	@CreatedTime datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@ModifiedTime datetime = NULL, 
	@ModifiedBy varchar(50) = NULL, 
	@ScheduledCarrierID int = NULL, 
	@ScheduledLogisticsID int = NULL, 
	@ScheduledShipmentDate datetime = NULL, 
	@QuoteID int = NULL, 
	@CarrierProNumber varchar(50) = NULL, 
	@ActualShipmentDate datetime = NULL, 
	@ActualDeliveryDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LOAD]
	SET
		[LoadStatus] = @LoadStatus, 
		[LoadType] = @LoadType, 
		[PlannedDepartureDate] = @PlannedDepartureDate, 
		[PlannedDeliveryDate] = @PlannedDeliveryDate, 
		[CustID] = @CustID, 
		[OriginType] = @OriginType, 
		[OriginID] = @OriginID, 
		[OriginName] = @OriginName, 
		[OriginAddress1] = @OriginAddress1, 
		[OriginAddress2] = @OriginAddress2, 
		[OriginCity] = @OriginCity, 
		[OriginState] = @OriginState, 
		[OriginZip] = @OriginZip, 
		[OriginCountry] = @OriginCountry, 
		[OriginPhone] = @OriginPhone, 
		[OriginContact] = @OriginContact, 
		[PickupHours] = @PickupHours, 
		[DestType] = @DestType, 
		[DestID] = @DestID, 
		[DestName] = @DestName, 
		[DestAddress1] = @DestAddress1, 
		[DestAddress2] = @DestAddress2, 
		[DestCity] = @DestCity, 
		[DestState] = @DestState, 
		[DestZip] = @DestZip, 
		[DestCountry] = @DestCountry, 
		[DestPhone] = @DestPhone, 
		[DestContact] = @DestContact, 
		[DeliveryHours] = @DeliveryHours, 
		[CarrierID] = @CarrierID, 
		[LogisticsID] = @LogisticsID, 
		[FOB] = @FOB, 
		[BillCustomer] = @BillCustomer, 
		[AddToInvoice] = @AddToInvoice, 
		[LoadNotes] = @LoadNotes, 
		[CreatedTime] = @CreatedTime, 
		[CreatedBy] = @CreatedBy, 
		[ModifiedTime] = @ModifiedTime, 
		[ModifiedBy] = @ModifiedBy, 
		[ScheduledCarrierID] = @ScheduledCarrierID, 
		[ScheduledLogisticsID] = @ScheduledLogisticsID, 
		[ScheduledShipmentDate] = @ScheduledShipmentDate, 
		[QuoteID] = @QuoteID, 
		[CarrierProNumber] = @CarrierProNumber, 
		[ActualShipmentDate] = @ActualShipmentDate, 
		[ActualDeliveryDate] = @ActualDeliveryDate
	WHERE
		([LoadID] = @LoadID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADInsert];
GO

CREATE PROCEDURE [dbo].[proc_LOADInsert]
(
	@LoadID int = NULL OUTPUT, 
	@LoadStatus varchar(50) = NULL, 
	@LoadType varchar(24) = NULL, 
	@PlannedDepartureDate datetime = NULL, 
	@PlannedDeliveryDate datetime = NULL, 
	@CustID int = NULL, 
	@OriginType varchar(50) = NULL, 
	@OriginID int = NULL, 
	@OriginName varchar(50) = NULL, 
	@OriginAddress1 varchar(50) = NULL, 
	@OriginAddress2 varchar(50) = NULL, 
	@OriginCity varchar(50) = NULL, 
	@OriginState varchar(50) = NULL, 
	@OriginZip varchar(24) = NULL, 
	@OriginCountry varchar(50) = NULL, 
	@OriginPhone varchar(50) = NULL, 
	@OriginContact varchar(50) = NULL, 
	@PickupHours varchar(50) = NULL, 
	@DestType varchar(50) = NULL, 
	@DestID int = NULL, 
	@DestName varchar(50) = NULL, 
	@DestAddress1 varchar(50) = NULL, 
	@DestAddress2 varchar(50) = NULL, 
	@DestCity varchar(50) = NULL, 
	@DestState varchar(50) = NULL, 
	@DestZip varchar(24) = NULL, 
	@DestCountry varchar(50) = NULL, 
	@DestPhone varchar(50) = NULL, 
	@DestContact varchar(50) = NULL, 
	@DeliveryHours varchar(50) = NULL, 
	@CarrierID int = NULL, 
	@LogisticsID int = NULL, 
	@FOB varchar(50) = NULL, 
	@BillCustomer bit = NULL, 
	@AddToInvoice bit = NULL, 
	@LoadNotes varchar(MAX) = NULL, 
	@CreatedTime datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@ModifiedTime datetime = NULL, 
	@ModifiedBy varchar(50) = NULL, 
	@ScheduledCarrierID int = NULL, 
	@ScheduledLogisticsID int = NULL, 
	@ScheduledShipmentDate datetime = NULL, 
	@QuoteID int = NULL, 
	@CarrierProNumber varchar(50) = NULL, 
	@ActualShipmentDate datetime = NULL, 
	@ActualDeliveryDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LOAD]
	(
		[LoadStatus], 
		[LoadType], 
		[PlannedDepartureDate], 
		[PlannedDeliveryDate], 
		[CustID], 
		[OriginType], 
		[OriginID], 
		[OriginName], 
		[OriginAddress1], 
		[OriginAddress2], 
		[OriginCity], 
		[OriginState], 
		[OriginZip], 
		[OriginCountry], 
		[OriginPhone], 
		[OriginContact], 
		[PickupHours], 
		[DestType], 
		[DestID], 
		[DestName], 
		[DestAddress1], 
		[DestAddress2], 
		[DestCity], 
		[DestState], 
		[DestZip], 
		[DestCountry], 
		[DestPhone], 
		[DestContact], 
		[DeliveryHours], 
		[CarrierID], 
		[LogisticsID], 
		[FOB], 
		[BillCustomer], 
		[AddToInvoice], 
		[LoadNotes], 
		[CreatedTime], 
		[CreatedBy], 
		[ModifiedTime], 
		[ModifiedBy], 
		[ScheduledCarrierID], 
		[ScheduledLogisticsID], 
		[ScheduledShipmentDate], 
		[QuoteID], 
		[CarrierProNumber], 
		[ActualShipmentDate], 
		[ActualDeliveryDate]
	)
	
	VALUES
	(
		@LoadStatus, 
		@LoadType, 
		@PlannedDepartureDate, 
		@PlannedDeliveryDate, 
		@CustID, 
		@OriginType, 
		@OriginID, 
		@OriginName, 
		@OriginAddress1, 
		@OriginAddress2, 
		@OriginCity, 
		@OriginState, 
		@OriginZip, 
		@OriginCountry, 
		@OriginPhone, 
		@OriginContact, 
		@PickupHours, 
		@DestType, 
		@DestID, 
		@DestName, 
		@DestAddress1, 
		@DestAddress2, 
		@DestCity, 
		@DestState, 
		@DestZip, 
		@DestCountry, 
		@DestPhone, 
		@DestContact, 
		@DeliveryHours, 
		@CarrierID, 
		@LogisticsID, 
		@FOB, 
		@BillCustomer, 
		@AddToInvoice, 
		@LoadNotes, 
		@CreatedTime, 
		@CreatedBy, 
		@ModifiedTime, 
		@ModifiedBy, 
		@ScheduledCarrierID, 
		@ScheduledLogisticsID, 
		@ScheduledShipmentDate, 
		@QuoteID, 
		@CarrierProNumber, 
		@ActualShipmentDate, 
		@ActualDeliveryDate
	)

	SET @Err = @@Error

		
	SELECT @LoadID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADDelete];
GO

CREATE PROCEDURE [dbo].[proc_LOADDelete]
(
	@LoadID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LOAD]
	WHERE
		([LoadID] = @LoadID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADDelete Error on Creation'
GO 

