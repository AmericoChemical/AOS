
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMODORLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMODORLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMODORLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMODORLoadByPrimaryKey]
(
	@ODOR varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ODOR]
	FROM [dbo].[LIST_CHEMODOR]
	WHERE
		([ODOR] = @ODOR)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMODORLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMODORLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMODORLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMODORLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMODORLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMODORLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ODOR]
	FROM [dbo].[LIST_CHEMODOR]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMODORLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMODORLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMODORUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMODORUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMODORInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMODORInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMODORInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMODORInsert]
(
	@ODOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_CHEMODOR]
	(
		[ODOR]
	)
	
	VALUES
	(
		@ODOR
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMODORInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMODORInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMODORDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMODORDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMODORDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMODORDelete]
(
	@ODOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_CHEMODOR]
	WHERE
		([ODOR] = @ODOR)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMODORDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMODORDelete Error on Creation'
GO 

