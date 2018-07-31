
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_HAZMATSYMBOLLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_HAZMATSYMBOLLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_HAZMATSYMBOLLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_HAZMATSYMBOLLoadByPrimaryKey]
(
	@HazMatID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[HazMatID], 
		[SymbolDesc], 
		[ProductLabel], 
		[ImageFileName], 
		[Precautions], 
		[Warning], 
		[Handling]
	FROM [dbo].[HAZMATSYMBOL]
	WHERE
		([HazMatID] = @HazMatID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_HAZMATSYMBOLLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_HAZMATSYMBOLLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_HAZMATSYMBOLLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_HAZMATSYMBOLLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_HAZMATSYMBOLLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_HAZMATSYMBOLLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[HazMatID], 
		[SymbolDesc], 
		[ProductLabel], 
		[ImageFileName], 
		[Precautions], 
		[Warning], 
		[Handling]
	FROM [dbo].[HAZMATSYMBOL]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_HAZMATSYMBOLLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_HAZMATSYMBOLLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_HAZMATSYMBOLUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_HAZMATSYMBOLUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_HAZMATSYMBOLUpdate];
GO

CREATE PROCEDURE [dbo].[proc_HAZMATSYMBOLUpdate]
(
	@HazMatID int, 
	@SymbolDesc varchar(50) = NULL, 
	@ProductLabel varchar(100) = NULL, 
	@ImageFileName varchar(100) = NULL, 
	@Precautions varchar(MAX) = NULL, 
	@Warning varchar(MAX) = NULL, 
	@Handling varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [HAZMATSYMBOL]
	SET
		[SymbolDesc] = @SymbolDesc, 
		[ProductLabel] = @ProductLabel, 
		[ImageFileName] = @ImageFileName, 
		[Precautions] = @Precautions, 
		[Warning] = @Warning, 
		[Handling] = @Handling
	WHERE
		([HazMatID] = @HazMatID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_HAZMATSYMBOLUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_HAZMATSYMBOLUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_HAZMATSYMBOLInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_HAZMATSYMBOLInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_HAZMATSYMBOLInsert];
GO

CREATE PROCEDURE [dbo].[proc_HAZMATSYMBOLInsert]
(
	@HazMatID int, 
	@SymbolDesc varchar(50) = NULL, 
	@ProductLabel varchar(100) = NULL, 
	@ImageFileName varchar(100) = NULL, 
	@Precautions varchar(MAX) = NULL, 
	@Warning varchar(MAX) = NULL, 
	@Handling varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [HAZMATSYMBOL]
	(
		[HazMatID], 
		[SymbolDesc], 
		[ProductLabel], 
		[ImageFileName], 
		[Precautions], 
		[Warning], 
		[Handling]
	)
	
	VALUES
	(
		@HazMatID, 
		@SymbolDesc, 
		@ProductLabel, 
		@ImageFileName, 
		@Precautions, 
		@Warning, 
		@Handling
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_HAZMATSYMBOLInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_HAZMATSYMBOLInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_HAZMATSYMBOLDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_HAZMATSYMBOLDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_HAZMATSYMBOLDelete];
GO

CREATE PROCEDURE [dbo].[proc_HAZMATSYMBOLDelete]
(
	@HazMatID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[HAZMATSYMBOL]
	WHERE
		([HazMatID] = @HazMatID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_HAZMATSYMBOLDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_HAZMATSYMBOLDelete Error on Creation'
GO 

