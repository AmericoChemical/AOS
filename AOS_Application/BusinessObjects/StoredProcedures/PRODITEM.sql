
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PRODITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PRODITEMLoadByPrimaryKey]
(
	@PRODITEMNUM int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODITEMNUM], 
		[PRODORDERNUM], 
		[MATERIALID], 
		[APISNUM], 
		[UOM], 
		[QTY], 
		[ISCOMPLETE]
	FROM [dbo].[PRODITEM]
	WHERE
		([PRODITEMNUM] = @PRODITEMNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODITEMLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PRODITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODITEMNUM], 
		[PRODORDERNUM], 
		[MATERIALID], 
		[APISNUM], 
		[UOM], 
		[QTY], 
		[ISCOMPLETE]
	FROM [dbo].[PRODITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODITEMUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PRODITEMUpdate]
(
	@PRODITEMNUM int, 
	@PRODORDERNUM int = NULL, 
	@MATERIALID int = NULL, 
	@APISNUM int = NULL, 
	@UOM varchar(50) = NULL, 
	@QTY float = NULL, 
	@ISCOMPLETE bit
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PRODITEM]
	SET
		[PRODORDERNUM] = @PRODORDERNUM, 
		[MATERIALID] = @MATERIALID, 
		[APISNUM] = @APISNUM, 
		[UOM] = @UOM, 
		[QTY] = @QTY, 
		[ISCOMPLETE] = @ISCOMPLETE
	WHERE
		([PRODITEMNUM] = @PRODITEMNUM)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODITEMInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_PRODITEMInsert]
(
	@PRODITEMNUM int = NULL OUTPUT, 
	@PRODORDERNUM int = NULL, 
	@MATERIALID int = NULL, 
	@APISNUM int = NULL, 
	@UOM varchar(50) = NULL, 
	@QTY float = NULL, 
	@ISCOMPLETE bit
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PRODITEM]
	(
		[PRODORDERNUM], 
		[MATERIALID], 
		[APISNUM], 
		[UOM], 
		[QTY], 
		[ISCOMPLETE]
	)
	
	VALUES
	(
		@PRODORDERNUM, 
		@MATERIALID, 
		@APISNUM, 
		@UOM, 
		@QTY, 
		@ISCOMPLETE
	)

	SET @Err = @@Error

		
	SELECT @PRODITEMNUM = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODITEMDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_PRODITEMDelete]
(
	@PRODITEMNUM int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PRODITEM]
	WHERE
		([PRODITEMNUM] = @PRODITEMNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODITEMDelete Error on Creation'
GO 

