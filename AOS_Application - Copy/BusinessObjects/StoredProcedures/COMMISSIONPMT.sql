
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONPMTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONPMTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONPMTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONPMTLoadByPrimaryKey]
(
	@COMMISSIONPMTID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONPMTID], 
		[COMMISSIONPMTDATE], 
		[COMMISSIONPMTAMT], 
		[SALESPERSONID], 
		[COMMISSIONPMTTYPE], 
		[COMMISSIONPMTNOTE]
	FROM [dbo].[COMMISSIONPMT]
	WHERE
		([COMMISSIONPMTID] = @COMMISSIONPMTID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONPMTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONPMTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONPMTLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONPMTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONPMTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONPMTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONPMTID], 
		[COMMISSIONPMTDATE], 
		[COMMISSIONPMTAMT], 
		[SALESPERSONID], 
		[COMMISSIONPMTTYPE], 
		[COMMISSIONPMTNOTE]
	FROM [dbo].[COMMISSIONPMT]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONPMTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONPMTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONPMTUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONPMTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONPMTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONPMTUpdate]
(
	@COMMISSIONPMTID int, 
	@COMMISSIONPMTDATE datetime = NULL, 
	@COMMISSIONPMTAMT money = NULL, 
	@SALESPERSONID int = NULL, 
	@COMMISSIONPMTTYPE varchar(50) = NULL, 
	@COMMISSIONPMTNOTE varchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [COMMISSIONPMT]
	SET
		[COMMISSIONPMTDATE] = @COMMISSIONPMTDATE, 
		[COMMISSIONPMTAMT] = @COMMISSIONPMTAMT, 
		[SALESPERSONID] = @SALESPERSONID, 
		[COMMISSIONPMTTYPE] = @COMMISSIONPMTTYPE, 
		[COMMISSIONPMTNOTE] = @COMMISSIONPMTNOTE
	WHERE
		([COMMISSIONPMTID] = @COMMISSIONPMTID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONPMTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONPMTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONPMTInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONPMTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONPMTInsert];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONPMTInsert]
(
	@COMMISSIONPMTID int = NULL OUTPUT, 
	@COMMISSIONPMTDATE datetime = NULL, 
	@COMMISSIONPMTAMT money = NULL, 
	@SALESPERSONID int = NULL, 
	@COMMISSIONPMTTYPE varchar(50) = NULL, 
	@COMMISSIONPMTNOTE varchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [COMMISSIONPMT]
	(
		[COMMISSIONPMTDATE], 
		[COMMISSIONPMTAMT], 
		[SALESPERSONID], 
		[COMMISSIONPMTTYPE], 
		[COMMISSIONPMTNOTE]
	)
	
	VALUES
	(
		@COMMISSIONPMTDATE, 
		@COMMISSIONPMTAMT, 
		@SALESPERSONID, 
		@COMMISSIONPMTTYPE, 
		@COMMISSIONPMTNOTE
	)

	SET @Err = @@Error

		
	SELECT @COMMISSIONPMTID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONPMTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONPMTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONPMTDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONPMTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONPMTDelete];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONPMTDelete]
(
	@COMMISSIONPMTID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[COMMISSIONPMT]
	WHERE
		([COMMISSIONPMTID] = @COMMISSIONPMTID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONPMTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONPMTDelete Error on Creation'
GO 

