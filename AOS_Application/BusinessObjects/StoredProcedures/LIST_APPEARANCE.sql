
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_APPEARANCELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_APPEARANCELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_APPEARANCELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_APPEARANCELoadByPrimaryKey]
(
	@RECIID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECIID], 
		[APPEARANCE]
	FROM [dbo].[LIST_APPEARANCE]
	WHERE
		([RECIID] = @RECIID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_APPEARANCELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_APPEARANCELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_APPEARANCELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_APPEARANCELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_APPEARANCELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_APPEARANCELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECIID], 
		[APPEARANCE]
	FROM [dbo].[LIST_APPEARANCE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_APPEARANCELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_APPEARANCELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_APPEARANCEUpdate] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_APPEARANCEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_APPEARANCEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_APPEARANCEUpdate]
(
	@RECIID int, 
	@APPEARANCE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_APPEARANCE]
	SET
		[APPEARANCE] = @APPEARANCE
	WHERE
		([RECIID] = @RECIID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_APPEARANCEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_APPEARANCEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_APPEARANCEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_APPEARANCEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_APPEARANCEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_APPEARANCEInsert]
(
	@RECIID int = NULL OUTPUT, 
	@APPEARANCE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_APPEARANCE]
	(
		[APPEARANCE]
	)
	
	VALUES
	(
		@APPEARANCE
	)

	SET @Err = @@Error

		
	SELECT @RECIID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_APPEARANCEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_APPEARANCEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_APPEARANCEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_APPEARANCEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_APPEARANCEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_APPEARANCEDelete]
(
	@RECIID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_APPEARANCE]
	WHERE
		([RECIID] = @RECIID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_APPEARANCEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_APPEARANCEDelete Error on Creation'
GO 

