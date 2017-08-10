
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMAPPEARANCELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMAPPEARANCELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCELoadByPrimaryKey]
(
	@APPEARANCE varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APPEARANCE]
	FROM [dbo].[LIST_CHEMAPPEARANCE]
	WHERE
		([APPEARANCE] = @APPEARANCE)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMAPPEARANCELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMAPPEARANCELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APPEARANCE]
	FROM [dbo].[LIST_CHEMAPPEARANCE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCELoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMAPPEARANCEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMAPPEARANCEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCEInsert]
(
	@APPEARANCE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_CHEMAPPEARANCE]
	(
		[APPEARANCE]
	)
	
	VALUES
	(
		@APPEARANCE
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMAPPEARANCEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMAPPEARANCEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCEDelete]
(
	@APPEARANCE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_CHEMAPPEARANCE]
	WHERE
		([APPEARANCE] = @APPEARANCE)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCEDelete Error on Creation'
GO 

