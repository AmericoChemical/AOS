
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LOADITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LOADITEMLoadByPrimaryKey]
(
	@LoadItemID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadItemID], 
		[LoadID], 
		[SourceType], 
		[SourceID], 
		[ItemType], 
		[ItemID], 
		[ItemDescription], 
		[Container], 
		[QtyContainers], 
		[TotalVolume], 
		[VolumeUOM], 
		[TotalWeight], 
		[WeightUOM], 
		[DOTIDNumber], 
		[HazmatID], 
		[HazmatClass], 
		[HazmatPackageGroup], 
		[ClassRate], 
		[DOTDesc], 
		[HazMatDesc], 
		[UNLine], 
		[IsHazardous], 
		[PalletID], 
		[LoadItemNote], 
		[LD1], 
		[LD2], 
		[LD3], 
		[CreatedTime], 
		[CreatedBy], 
		[ModifiedTime], 
		[ModifiedBy]
	FROM [dbo].[LOADITEM]
	WHERE
		([LoadItemID] = @LoadItemID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADITEMLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LOADITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadItemID], 
		[LoadID], 
		[SourceType], 
		[SourceID], 
		[ItemType], 
		[ItemID], 
		[ItemDescription], 
		[Container], 
		[QtyContainers], 
		[TotalVolume], 
		[VolumeUOM], 
		[TotalWeight], 
		[WeightUOM], 
		[DOTIDNumber], 
		[HazmatID], 
		[HazmatClass], 
		[HazmatPackageGroup], 
		[ClassRate], 
		[DOTDesc], 
		[HazMatDesc], 
		[UNLine], 
		[IsHazardous], 
		[PalletID], 
		[LoadItemNote], 
		[LD1], 
		[LD2], 
		[LD3], 
		[CreatedTime], 
		[CreatedBy], 
		[ModifiedTime], 
		[ModifiedBy]
	FROM [dbo].[LOADITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADITEMUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LOADITEMUpdate]
(
	@LoadItemID int, 
	@LoadID int = NULL, 
	@SourceType varchar(50) = NULL, 
	@SourceID int = NULL, 
	@ItemType varchar(50) = NULL, 
	@ItemID int = NULL, 
	@ItemDescription varchar(200) = NULL, 
	@Container varchar(50) = NULL, 
	@QtyContainers int = NULL, 
	@TotalVolume int = NULL, 
	@VolumeUOM varchar(50) = NULL, 
	@TotalWeight int = NULL, 
	@WeightUOM varchar(50) = NULL, 
	@DOTIDNumber varchar(24) = NULL, 
	@HazmatID int = NULL, 
	@HazmatClass varchar(50) = NULL, 
	@HazmatPackageGroup varchar(50) = NULL, 
	@ClassRate varchar(50) = NULL, 
	@DOTDesc varchar(200) = NULL, 
	@HazMatDesc varchar(200) = NULL, 
	@UNLine varchar(200) = NULL, 
	@IsHazardous bit = NULL, 
	@PalletID int = NULL, 
	@LoadItemNote varchar(MAX) = NULL, 
	@LD1 varchar(500) = NULL, 
	@LD2 varchar(500) = NULL, 
	@LD3 varchar(500) = NULL, 
	@CreatedTime datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@ModifiedTime datetime = NULL, 
	@ModifiedBy varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LOADITEM]
	SET
		[LoadID] = @LoadID, 
		[SourceType] = @SourceType, 
		[SourceID] = @SourceID, 
		[ItemType] = @ItemType, 
		[ItemID] = @ItemID, 
		[ItemDescription] = @ItemDescription, 
		[Container] = @Container, 
		[QtyContainers] = @QtyContainers, 
		[TotalVolume] = @TotalVolume, 
		[VolumeUOM] = @VolumeUOM, 
		[TotalWeight] = @TotalWeight, 
		[WeightUOM] = @WeightUOM, 
		[DOTIDNumber] = @DOTIDNumber, 
		[HazmatID] = @HazmatID, 
		[HazmatClass] = @HazmatClass, 
		[HazmatPackageGroup] = @HazmatPackageGroup, 
		[ClassRate] = @ClassRate, 
		[DOTDesc] = @DOTDesc, 
		[HazMatDesc] = @HazMatDesc, 
		[UNLine] = @UNLine, 
		[IsHazardous] = @IsHazardous, 
		[PalletID] = @PalletID, 
		[LoadItemNote] = @LoadItemNote, 
		[LD1] = @LD1, 
		[LD2] = @LD2, 
		[LD3] = @LD3, 
		[CreatedTime] = @CreatedTime, 
		[CreatedBy] = @CreatedBy, 
		[ModifiedTime] = @ModifiedTime, 
		[ModifiedBy] = @ModifiedBy
	WHERE
		([LoadItemID] = @LoadItemID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADITEMInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_LOADITEMInsert]
(
	@LoadItemID int = NULL OUTPUT, 
	@LoadID int = NULL, 
	@SourceType varchar(50) = NULL, 
	@SourceID int = NULL, 
	@ItemType varchar(50) = NULL, 
	@ItemID int = NULL, 
	@ItemDescription varchar(200) = NULL, 
	@Container varchar(50) = NULL, 
	@QtyContainers int = NULL, 
	@TotalVolume int = NULL, 
	@VolumeUOM varchar(50) = NULL, 
	@TotalWeight int = NULL, 
	@WeightUOM varchar(50) = NULL, 
	@DOTIDNumber varchar(24) = NULL, 
	@HazmatID int = NULL, 
	@HazmatClass varchar(50) = NULL, 
	@HazmatPackageGroup varchar(50) = NULL, 
	@ClassRate varchar(50) = NULL, 
	@DOTDesc varchar(200) = NULL, 
	@HazMatDesc varchar(200) = NULL, 
	@UNLine varchar(200) = NULL, 
	@IsHazardous bit = NULL, 
	@PalletID int = NULL, 
	@LoadItemNote varchar(MAX) = NULL, 
	@LD1 varchar(500) = NULL, 
	@LD2 varchar(500) = NULL, 
	@LD3 varchar(500) = NULL, 
	@CreatedTime datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@ModifiedTime datetime = NULL, 
	@ModifiedBy varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LOADITEM]
	(
		[LoadID], 
		[SourceType], 
		[SourceID], 
		[ItemType], 
		[ItemID], 
		[ItemDescription], 
		[Container], 
		[QtyContainers], 
		[TotalVolume], 
		[VolumeUOM], 
		[TotalWeight], 
		[WeightUOM], 
		[DOTIDNumber], 
		[HazmatID], 
		[HazmatClass], 
		[HazmatPackageGroup], 
		[ClassRate], 
		[DOTDesc], 
		[HazMatDesc], 
		[UNLine], 
		[IsHazardous], 
		[PalletID], 
		[LoadItemNote], 
		[LD1], 
		[LD2], 
		[LD3], 
		[CreatedTime], 
		[CreatedBy], 
		[ModifiedTime], 
		[ModifiedBy]
	)
	
	VALUES
	(
		@LoadID, 
		@SourceType, 
		@SourceID, 
		@ItemType, 
		@ItemID, 
		@ItemDescription, 
		@Container, 
		@QtyContainers, 
		@TotalVolume, 
		@VolumeUOM, 
		@TotalWeight, 
		@WeightUOM, 
		@DOTIDNumber, 
		@HazmatID, 
		@HazmatClass, 
		@HazmatPackageGroup, 
		@ClassRate, 
		@DOTDesc, 
		@HazMatDesc, 
		@UNLine, 
		@IsHazardous, 
		@PalletID, 
		@LoadItemNote, 
		@LD1, 
		@LD2, 
		@LD3, 
		@CreatedTime, 
		@CreatedBy, 
		@ModifiedTime, 
		@ModifiedBy
	)

	SET @Err = @@Error

		
	SELECT @LoadItemID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADITEMDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_LOADITEMDelete]
(
	@LoadItemID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LOADITEM]
	WHERE
		([LoadItemID] = @LoadItemID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADITEMDelete Error on Creation'
GO 

