
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_PALLETTYPELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PALLETTYPELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PALLETTYPELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PALLETTYPELoadByPrimaryKey]
(
	@PALLETTYPE varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PALLETTYPE], 
		[PALLETWEIGHT]
	FROM [dbo].[LIST_PALLETTYPE]
	WHERE
		([PALLETTYPE] = @PALLETTYPE)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PALLETTYPELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PALLETTYPELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PALLETTYPELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PALLETTYPELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PALLETTYPELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PALLETTYPELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PALLETTYPE], 
		[PALLETWEIGHT]
	FROM [dbo].[LIST_PALLETTYPE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PALLETTYPELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PALLETTYPELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PALLETTYPEUpdate] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PALLETTYPEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PALLETTYPEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PALLETTYPEUpdate]
(
	@PALLETTYPE varchar(50), 
	@PALLETWEIGHT int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_PALLETTYPE]
	SET
		[PALLETWEIGHT] = @PALLETWEIGHT
	WHERE
		([PALLETTYPE] = @PALLETTYPE)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PALLETTYPEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PALLETTYPEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PALLETTYPEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PALLETTYPEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PALLETTYPEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PALLETTYPEInsert]
(
	@PALLETTYPE varchar(50), 
	@PALLETWEIGHT int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_PALLETTYPE]
	(
		[PALLETTYPE], 
		[PALLETWEIGHT]
	)
	
	VALUES
	(
		@PALLETTYPE, 
		@PALLETWEIGHT
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PALLETTYPEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PALLETTYPEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PALLETTYPEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PALLETTYPEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PALLETTYPEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PALLETTYPEDelete]
(
	@PALLETTYPE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_PALLETTYPE]
	WHERE
		([PALLETTYPE] = @PALLETTYPE)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PALLETTYPEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PALLETTYPEDelete Error on Creation'
GO 

