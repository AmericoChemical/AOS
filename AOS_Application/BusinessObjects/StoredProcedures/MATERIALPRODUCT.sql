
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_MATERIALPRODUCTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:13 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALPRODUCTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALPRODUCTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALPRODUCTLoadByPrimaryKey]
(
	@MPID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[MPID], 
		[MATERIALID], 
		[PRODUCTID], 
		[MPNOTE]
	FROM [dbo].[MATERIALPRODUCT]
	WHERE
		([MPID] = @MPID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALPRODUCTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALPRODUCTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALPRODUCTLoadAll] Script Date: 12/10/2013 4:01:13 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALPRODUCTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALPRODUCTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALPRODUCTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[MPID], 
		[MATERIALID], 
		[PRODUCTID], 
		[MPNOTE]
	FROM [dbo].[MATERIALPRODUCT]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALPRODUCTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALPRODUCTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALPRODUCTUpdate] Script Date: 12/10/2013 4:01:13 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALPRODUCTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALPRODUCTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALPRODUCTUpdate]
(
	@MPID int, 
	@MATERIALID int = NULL, 
	@PRODUCTID int = NULL, 
	@MPNOTE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [MATERIALPRODUCT]
	SET
		[MATERIALID] = @MATERIALID, 
		[PRODUCTID] = @PRODUCTID, 
		[MPNOTE] = @MPNOTE
	WHERE
		([MPID] = @MPID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALPRODUCTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALPRODUCTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALPRODUCTInsert] Script Date: 12/10/2013 4:01:13 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALPRODUCTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALPRODUCTInsert];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALPRODUCTInsert]
(
	@MPID int = NULL OUTPUT, 
	@MATERIALID int = NULL, 
	@PRODUCTID int = NULL, 
	@MPNOTE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [MATERIALPRODUCT]
	(
		[MATERIALID], 
		[PRODUCTID], 
		[MPNOTE]
	)
	
	VALUES
	(
		@MATERIALID, 
		@PRODUCTID, 
		@MPNOTE
	)

	SET @Err = @@Error

		
	SELECT @MPID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALPRODUCTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALPRODUCTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALPRODUCTDelete] Script Date: 12/10/2013 4:01:13 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALPRODUCTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALPRODUCTDelete];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALPRODUCTDelete]
(
	@MPID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[MATERIALPRODUCT]
	WHERE
		([MPID] = @MPID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALPRODUCTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALPRODUCTDelete Error on Creation'
GO 

