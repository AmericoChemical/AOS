
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_ITEMTYPELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ITEMTYPELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ITEMTYPELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ITEMTYPELoadByPrimaryKey]
(
	@RecID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[ITEMTYPE]
	FROM [dbo].[LIST_ITEMTYPE]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ITEMTYPELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ITEMTYPELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_ITEMTYPELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ITEMTYPELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ITEMTYPELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ITEMTYPELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[ITEMTYPE]
	FROM [dbo].[LIST_ITEMTYPE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ITEMTYPELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ITEMTYPELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_ITEMTYPEUpdate] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ITEMTYPEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ITEMTYPEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ITEMTYPEUpdate]
(
	@RecID int, 
	@ITEMTYPE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_ITEMTYPE]
	SET
		[ITEMTYPE] = @ITEMTYPE
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ITEMTYPEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ITEMTYPEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_ITEMTYPEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ITEMTYPEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ITEMTYPEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ITEMTYPEInsert]
(
	@RecID int, 
	@ITEMTYPE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_ITEMTYPE]
	(
		[RecID], 
		[ITEMTYPE]
	)
	
	VALUES
	(
		@RecID, 
		@ITEMTYPE
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ITEMTYPEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ITEMTYPEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_ITEMTYPEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ITEMTYPEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ITEMTYPEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ITEMTYPEDelete]
(
	@RecID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_ITEMTYPE]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ITEMTYPEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ITEMTYPEDelete Error on Creation'
GO 

