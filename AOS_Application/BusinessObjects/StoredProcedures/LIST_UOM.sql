
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_UOMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_UOMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_UOMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_UOMLoadByPrimaryKey]
(
	@RECID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECID], 
		[INVENTORYMETHOD], 
		[SORTORDINAL], 
		[UOM]
	FROM [dbo].[LIST_UOM]
	WHERE
		([RECID] = @RECID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_UOMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_UOMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_UOMLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_UOMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_UOMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_UOMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECID], 
		[INVENTORYMETHOD], 
		[SORTORDINAL], 
		[UOM]
	FROM [dbo].[LIST_UOM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_UOMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_UOMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_UOMUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_UOMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_UOMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_UOMUpdate]
(
	@RECID int, 
	@INVENTORYMETHOD varchar(50) = NULL, 
	@SORTORDINAL int = NULL, 
	@UOM varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_UOM]
	SET
		[INVENTORYMETHOD] = @INVENTORYMETHOD, 
		[SORTORDINAL] = @SORTORDINAL, 
		[UOM] = @UOM
	WHERE
		([RECID] = @RECID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_UOMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_UOMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_UOMInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_UOMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_UOMInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_UOMInsert]
(
	@RECID int = NULL OUTPUT, 
	@INVENTORYMETHOD varchar(50) = NULL, 
	@SORTORDINAL int = NULL, 
	@UOM varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_UOM]
	(
		[INVENTORYMETHOD], 
		[SORTORDINAL], 
		[UOM]
	)
	
	VALUES
	(
		@INVENTORYMETHOD, 
		@SORTORDINAL, 
		@UOM
	)

	SET @Err = @@Error

		
	SELECT @RECID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_UOMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_UOMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_UOMDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_UOMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_UOMDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_UOMDelete]
(
	@RECID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_UOM]
	WHERE
		([RECID] = @RECID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_UOMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_UOMDelete Error on Creation'
GO 

