
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_MATERIALLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALLoadByPrimaryKey]
(
	@MATERIALID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[MATERIALID], 
		[MATERIALDESC], 
		[MATERIALUOM], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE], 
		[CHEMICALID]
	FROM [dbo].[MATERIAL]
	WHERE
		([MATERIALID] = @MATERIALID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[MATERIALID], 
		[MATERIALDESC], 
		[MATERIALUOM], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE], 
		[CHEMICALID]
	FROM [dbo].[MATERIAL]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALUpdate];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALUpdate]
(
	@MATERIALID int, 
	@MATERIALDESC varchar(200) = NULL, 
	@MATERIALUOM varchar(50) = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@ISACTIVE bit = NULL, 
	@CHEMICALID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [MATERIAL]
	SET
		[MATERIALDESC] = @MATERIALDESC, 
		[MATERIALUOM] = @MATERIALUOM, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME, 
		[ISACTIVE] = @ISACTIVE, 
		[CHEMICALID] = @CHEMICALID
	WHERE
		([MATERIALID] = @MATERIALID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALInsert];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALInsert]
(
	@MATERIALID int = NULL OUTPUT, 
	@MATERIALDESC varchar(200) = NULL, 
	@MATERIALUOM varchar(50) = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@ISACTIVE bit = NULL, 
	@CHEMICALID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [MATERIAL]
	(
		[MATERIALDESC], 
		[MATERIALUOM], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE], 
		[CHEMICALID]
	)
	
	VALUES
	(
		@MATERIALDESC, 
		@MATERIALUOM, 
		@CREATEDBY, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME, 
		@ISACTIVE, 
		@CHEMICALID
	)

	SET @Err = @@Error

		
	SELECT @MATERIALID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALDelete];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALDelete]
(
	@MATERIALID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[MATERIAL]
	WHERE
		([MATERIALID] = @MATERIALID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALDelete Error on Creation'
GO 

