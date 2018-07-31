
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_WORKORDERTYPELoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WORKORDERTYPELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WORKORDERTYPELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WORKORDERTYPELoadByPrimaryKey]
(
	@LISTKEY int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LISTKEY], 
		[WORKORDERTYPE]
	FROM [dbo].[LIST_WORKORDERTYPE]
	WHERE
		([LISTKEY] = @LISTKEY)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WORKORDERTYPELoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WORKORDERTYPELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WORKORDERTYPELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WORKORDERTYPELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LISTKEY], 
		[WORKORDERTYPE]
	FROM [dbo].[LIST_WORKORDERTYPE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WORKORDERTYPEUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WORKORDERTYPEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WORKORDERTYPEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WORKORDERTYPEUpdate]
(
	@LISTKEY int, 
	@WORKORDERTYPE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_WORKORDERTYPE]
	SET
		[WORKORDERTYPE] = @WORKORDERTYPE
	WHERE
		([LISTKEY] = @LISTKEY)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WORKORDERTYPEInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WORKORDERTYPEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WORKORDERTYPEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WORKORDERTYPEInsert]
(
	@LISTKEY int, 
	@WORKORDERTYPE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_WORKORDERTYPE]
	(
		[LISTKEY], 
		[WORKORDERTYPE]
	)
	
	VALUES
	(
		@LISTKEY, 
		@WORKORDERTYPE
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WORKORDERTYPEDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WORKORDERTYPEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WORKORDERTYPEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WORKORDERTYPEDelete]
(
	@LISTKEY int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_WORKORDERTYPE]
	WHERE
		([LISTKEY] = @LISTKEY)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPEDelete Error on Creation'
GO 

