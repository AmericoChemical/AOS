
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_CHEMICALBOMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALBOMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALBOMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALBOMLoadByPrimaryKey]
(
	@CHEMBOMID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMBOMID], 
		[CHEMICALID1], 
		[CHEMICALID2], 
		[UNITS], 
		[UOM], 
		[PERCBYWGT]
	FROM [dbo].[CHEMICALBOM]
	WHERE
		([CHEMBOMID] = @CHEMBOMID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALBOMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALBOMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALBOMLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALBOMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALBOMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALBOMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMBOMID], 
		[CHEMICALID1], 
		[CHEMICALID2], 
		[UNITS], 
		[UOM], 
		[PERCBYWGT]
	FROM [dbo].[CHEMICALBOM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALBOMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALBOMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALBOMUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALBOMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALBOMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALBOMUpdate]
(
	@CHEMBOMID int, 
	@CHEMICALID1 int = NULL, 
	@CHEMICALID2 int = NULL, 
	@UNITS decimal(18,4) = NULL, 
	@UOM varchar(50) = NULL, 
	@PERCBYWGT decimal(18,4) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CHEMICALBOM]
	SET
		[CHEMICALID1] = @CHEMICALID1, 
		[CHEMICALID2] = @CHEMICALID2, 
		[UNITS] = @UNITS, 
		[UOM] = @UOM, 
		[PERCBYWGT] = @PERCBYWGT
	WHERE
		([CHEMBOMID] = @CHEMBOMID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALBOMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALBOMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALBOMInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALBOMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALBOMInsert];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALBOMInsert]
(
	@CHEMBOMID int = NULL OUTPUT, 
	@CHEMICALID1 int = NULL, 
	@CHEMICALID2 int = NULL, 
	@UNITS decimal(18,4) = NULL, 
	@UOM varchar(50) = NULL, 
	@PERCBYWGT decimal(18,4) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [CHEMICALBOM]
	(
		[CHEMICALID1], 
		[CHEMICALID2], 
		[UNITS], 
		[UOM], 
		[PERCBYWGT]
	)
	
	VALUES
	(
		@CHEMICALID1, 
		@CHEMICALID2, 
		@UNITS, 
		@UOM, 
		@PERCBYWGT
	)

	SET @Err = @@Error

		
	SELECT @CHEMBOMID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALBOMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALBOMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALBOMDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALBOMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALBOMDelete];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALBOMDelete]
(
	@CHEMBOMID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[CHEMICALBOM]
	WHERE
		([CHEMBOMID] = @CHEMBOMID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALBOMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALBOMDelete Error on Creation'
GO 

