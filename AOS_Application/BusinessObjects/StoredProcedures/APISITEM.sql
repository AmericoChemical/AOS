
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_APISITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_APISITEMLoadByPrimaryKey]
(
	@APISITEMNUM int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISITEMNUM], 
		[APISNUM], 
		[MATERIALID], 
		[QTYUNITS], 
		[UOM], 
		[APISITEMNOTE], 
		[SOURCEPRODUCTID]
	FROM [dbo].[APISITEM]
	WHERE
		([APISITEMNUM] = @APISITEMNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISITEMLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_APISITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISITEMNUM], 
		[APISNUM], 
		[MATERIALID], 
		[QTYUNITS], 
		[UOM], 
		[APISITEMNOTE], 
		[SOURCEPRODUCTID]
	FROM [dbo].[APISITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISITEMUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_APISITEMUpdate]
(
	@APISITEMNUM int, 
	@APISNUM int = NULL, 
	@MATERIALID int = NULL, 
	@QTYUNITS float = NULL, 
	@UOM varchar(50) = NULL, 
	@APISITEMNOTE varchar(MAX) = NULL, 
	@SOURCEPRODUCTID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [APISITEM]
	SET
		[APISNUM] = @APISNUM, 
		[MATERIALID] = @MATERIALID, 
		[QTYUNITS] = @QTYUNITS, 
		[UOM] = @UOM, 
		[APISITEMNOTE] = @APISITEMNOTE, 
		[SOURCEPRODUCTID] = @SOURCEPRODUCTID
	WHERE
		([APISITEMNUM] = @APISITEMNUM)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISITEMInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_APISITEMInsert]
(
	@APISITEMNUM int = NULL OUTPUT, 
	@APISNUM int = NULL, 
	@MATERIALID int = NULL, 
	@QTYUNITS float = NULL, 
	@UOM varchar(50) = NULL, 
	@APISITEMNOTE varchar(MAX) = NULL, 
	@SOURCEPRODUCTID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [APISITEM]
	(
		[APISNUM], 
		[MATERIALID], 
		[QTYUNITS], 
		[UOM], 
		[APISITEMNOTE], 
		[SOURCEPRODUCTID]
	)
	
	VALUES
	(
		@APISNUM, 
		@MATERIALID, 
		@QTYUNITS, 
		@UOM, 
		@APISITEMNOTE, 
		@SOURCEPRODUCTID
	)

	SET @Err = @@Error

		
	SELECT @APISITEMNUM = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISITEMDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_APISITEMDelete]
(
	@APISITEMNUM int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[APISITEM]
	WHERE
		([APISITEMNUM] = @APISITEMNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISITEMDelete Error on Creation'
GO 

