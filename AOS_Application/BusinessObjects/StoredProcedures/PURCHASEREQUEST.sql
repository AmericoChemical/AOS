
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PURCHASEREQUESTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PURCHASEREQUESTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PURCHASEREQUESTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PURCHASEREQUESTLoadByPrimaryKey]
(
	@PurchReqID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PurchReqID], 
		[PurchReqDate], 
		[ProductID], 
		[QtyContainers], 
		[DateNeeded], 
		[PONumber], 
		[IsOrdered], 
		[CustID], 
		[VendorID], 
		[WorkOrderNumber], 
		[WorkOrderItemNumber], 
		[DateReceived], 
		[ReceiverItemNumber], 
		[ProdOrderNum], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	FROM [dbo].[PURCHASEREQUEST]
	WHERE
		([PurchReqID] = @PurchReqID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PURCHASEREQUESTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PURCHASEREQUESTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PURCHASEREQUESTLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PURCHASEREQUESTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PURCHASEREQUESTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PURCHASEREQUESTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PurchReqID], 
		[PurchReqDate], 
		[ProductID], 
		[QtyContainers], 
		[DateNeeded], 
		[PONumber], 
		[IsOrdered], 
		[CustID], 
		[VendorID], 
		[WorkOrderNumber], 
		[WorkOrderItemNumber], 
		[DateReceived], 
		[ReceiverItemNumber], 
		[ProdOrderNum], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	FROM [dbo].[PURCHASEREQUEST]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PURCHASEREQUESTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PURCHASEREQUESTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PURCHASEREQUESTUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PURCHASEREQUESTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PURCHASEREQUESTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PURCHASEREQUESTUpdate]
(
	@PurchReqID int, 
	@PurchReqDate datetime = NULL, 
	@ProductID int = NULL, 
	@QtyContainers int = NULL, 
	@DateNeeded datetime = NULL, 
	@PONumber int = NULL, 
	@IsOrdered int, 
	@CustID int = NULL, 
	@VendorID int = NULL, 
	@WorkOrderNumber int = NULL, 
	@WorkOrderItemNumber int = NULL, 
	@DateReceived datetime = NULL, 
	@ReceiverItemNumber int = NULL, 
	@ProdOrderNum int = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PURCHASEREQUEST]
	SET
		[PurchReqDate] = @PurchReqDate, 
		[ProductID] = @ProductID, 
		[QtyContainers] = @QtyContainers, 
		[DateNeeded] = @DateNeeded, 
		[PONumber] = @PONumber, 
		[IsOrdered] = @IsOrdered, 
		[CustID] = @CustID, 
		[VendorID] = @VendorID, 
		[WorkOrderNumber] = @WorkOrderNumber, 
		[WorkOrderItemNumber] = @WorkOrderItemNumber, 
		[DateReceived] = @DateReceived, 
		[ReceiverItemNumber] = @ReceiverItemNumber, 
		[ProdOrderNum] = @ProdOrderNum, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME
	WHERE
		([PurchReqID] = @PurchReqID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PURCHASEREQUESTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PURCHASEREQUESTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PURCHASEREQUESTInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PURCHASEREQUESTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PURCHASEREQUESTInsert];
GO

CREATE PROCEDURE [dbo].[proc_PURCHASEREQUESTInsert]
(
	@PurchReqID int = NULL OUTPUT, 
	@PurchReqDate datetime = NULL, 
	@ProductID int = NULL, 
	@QtyContainers int = NULL, 
	@DateNeeded datetime = NULL, 
	@PONumber int = NULL, 
	@IsOrdered int, 
	@CustID int = NULL, 
	@VendorID int = NULL, 
	@WorkOrderNumber int = NULL, 
	@WorkOrderItemNumber int = NULL, 
	@DateReceived datetime = NULL, 
	@ReceiverItemNumber int = NULL, 
	@ProdOrderNum int = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PURCHASEREQUEST]
	(
		[PurchReqDate], 
		[ProductID], 
		[QtyContainers], 
		[DateNeeded], 
		[PONumber], 
		[IsOrdered], 
		[CustID], 
		[VendorID], 
		[WorkOrderNumber], 
		[WorkOrderItemNumber], 
		[DateReceived], 
		[ReceiverItemNumber], 
		[ProdOrderNum], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	)
	
	VALUES
	(
		@PurchReqDate, 
		@ProductID, 
		@QtyContainers, 
		@DateNeeded, 
		@PONumber, 
		@IsOrdered, 
		@CustID, 
		@VendorID, 
		@WorkOrderNumber, 
		@WorkOrderItemNumber, 
		@DateReceived, 
		@ReceiverItemNumber, 
		@ProdOrderNum, 
		@CREATEDBY, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME
	)

	SET @Err = @@Error

		
	SELECT @PurchReqID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PURCHASEREQUESTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PURCHASEREQUESTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PURCHASEREQUESTDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PURCHASEREQUESTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PURCHASEREQUESTDelete];
GO

CREATE PROCEDURE [dbo].[proc_PURCHASEREQUESTDelete]
(
	@PurchReqID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PURCHASEREQUEST]
	WHERE
		([PurchReqID] = @PurchReqID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PURCHASEREQUESTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PURCHASEREQUESTDelete Error on Creation'
GO 

