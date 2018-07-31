
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_RMAITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RMAITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RMAITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_RMAITEMLoadByPrimaryKey]
(
	@RMAITEMID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RMAITEMID], 
		[RMAID]
	FROM [dbo].[RMAITEM]
	WHERE
		([RMAITEMID] = @RMAITEMID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RMAITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_RMAITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RMAITEMLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RMAITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RMAITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_RMAITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RMAITEMID], 
		[RMAID]
	FROM [dbo].[RMAITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RMAITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_RMAITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RMAITEMUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RMAITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RMAITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_RMAITEMUpdate]
(
	@RMAITEMID int, 
	@RMAID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [RMAITEM]
	SET
		[RMAID] = @RMAID
	WHERE
		([RMAITEMID] = @RMAITEMID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RMAITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_RMAITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RMAITEMInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RMAITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RMAITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_RMAITEMInsert]
(
	@RMAITEMID int = NULL OUTPUT, 
	@RMAID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [RMAITEM]
	(
		[RMAID]
	)
	
	VALUES
	(
		@RMAID
	)

	SET @Err = @@Error

		
	SELECT @RMAITEMID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RMAITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_RMAITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RMAITEMDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RMAITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RMAITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_RMAITEMDelete]
(
	@RMAITEMID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[RMAITEM]
	WHERE
		([RMAITEMID] = @RMAITEMID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RMAITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_RMAITEMDelete Error on Creation'
GO 

