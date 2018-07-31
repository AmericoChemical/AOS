
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_SHELFLIFELoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_SHELFLIFELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_SHELFLIFELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_SHELFLIFELoadByPrimaryKey]
(
	@RECID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECID], 
		[SHELFLIFE]
	FROM [dbo].[LIST_SHELFLIFE]
	WHERE
		([RECID] = @RECID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_SHELFLIFELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_SHELFLIFELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_SHELFLIFELoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_SHELFLIFELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_SHELFLIFELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_SHELFLIFELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECID], 
		[SHELFLIFE]
	FROM [dbo].[LIST_SHELFLIFE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_SHELFLIFELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_SHELFLIFELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_SHELFLIFEUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_SHELFLIFEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_SHELFLIFEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_SHELFLIFEUpdate]
(
	@RECID int, 
	@SHELFLIFE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_SHELFLIFE]
	SET
		[SHELFLIFE] = @SHELFLIFE
	WHERE
		([RECID] = @RECID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_SHELFLIFEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_SHELFLIFEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_SHELFLIFEInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_SHELFLIFEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_SHELFLIFEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_SHELFLIFEInsert]
(
	@RECID int = NULL OUTPUT, 
	@SHELFLIFE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_SHELFLIFE]
	(
		[SHELFLIFE]
	)
	
	VALUES
	(
		@SHELFLIFE
	)

	SET @Err = @@Error

		
	SELECT @RECID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_SHELFLIFEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_SHELFLIFEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_SHELFLIFEDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_SHELFLIFEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_SHELFLIFEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_SHELFLIFEDelete]
(
	@RECID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_SHELFLIFE]
	WHERE
		([RECID] = @RECID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_SHELFLIFEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_SHELFLIFEDelete Error on Creation'
GO 

