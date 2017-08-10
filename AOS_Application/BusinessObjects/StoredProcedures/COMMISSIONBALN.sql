
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONBALNLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONBALNLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONBALNLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONBALNLoadByPrimaryKey]
(
	@COMMISSIONBALNID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONBALNID], 
		[SALESPERSONID], 
		[COMMISSIONTYPE], 
		[COMMISSIONBALNDUE], 
		[COMMISSIONBALNDATE]
	FROM [dbo].[COMMISSIONBALN]
	WHERE
		([COMMISSIONBALNID] = @COMMISSIONBALNID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONBALNLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONBALNLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONBALNLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONBALNLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONBALNLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONBALNLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONBALNID], 
		[SALESPERSONID], 
		[COMMISSIONTYPE], 
		[COMMISSIONBALNDUE], 
		[COMMISSIONBALNDATE]
	FROM [dbo].[COMMISSIONBALN]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONBALNLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONBALNLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONBALNUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONBALNUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONBALNUpdate];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONBALNUpdate]
(
	@COMMISSIONBALNID int, 
	@SALESPERSONID int = NULL, 
	@COMMISSIONTYPE varchar(50) = NULL, 
	@COMMISSIONBALNDUE money = NULL, 
	@COMMISSIONBALNDATE datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [COMMISSIONBALN]
	SET
		[SALESPERSONID] = @SALESPERSONID, 
		[COMMISSIONTYPE] = @COMMISSIONTYPE, 
		[COMMISSIONBALNDUE] = @COMMISSIONBALNDUE, 
		[COMMISSIONBALNDATE] = @COMMISSIONBALNDATE
	WHERE
		([COMMISSIONBALNID] = @COMMISSIONBALNID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONBALNUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONBALNUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONBALNInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONBALNInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONBALNInsert];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONBALNInsert]
(
	@COMMISSIONBALNID int = NULL OUTPUT, 
	@SALESPERSONID int = NULL, 
	@COMMISSIONTYPE varchar(50) = NULL, 
	@COMMISSIONBALNDUE money = NULL, 
	@COMMISSIONBALNDATE datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [COMMISSIONBALN]
	(
		[SALESPERSONID], 
		[COMMISSIONTYPE], 
		[COMMISSIONBALNDUE], 
		[COMMISSIONBALNDATE]
	)
	
	VALUES
	(
		@SALESPERSONID, 
		@COMMISSIONTYPE, 
		@COMMISSIONBALNDUE, 
		@COMMISSIONBALNDATE
	)

	SET @Err = @@Error

		
	SELECT @COMMISSIONBALNID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONBALNInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONBALNInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONBALNDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONBALNDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONBALNDelete];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONBALNDelete]
(
	@COMMISSIONBALNID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[COMMISSIONBALN]
	WHERE
		([COMMISSIONBALNID] = @COMMISSIONBALNID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONBALNDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONBALNDelete Error on Creation'
GO 

