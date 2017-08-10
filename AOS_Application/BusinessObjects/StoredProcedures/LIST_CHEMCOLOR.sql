
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMCOLORLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMCOLORLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMCOLORLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMCOLORLoadByPrimaryKey]
(
	@COLOR varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COLOR]
	FROM [dbo].[LIST_CHEMCOLOR]
	WHERE
		([COLOR] = @COLOR)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMCOLORLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMCOLORLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMCOLORLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMCOLORLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMCOLORLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMCOLORLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COLOR]
	FROM [dbo].[LIST_CHEMCOLOR]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMCOLORLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMCOLORLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMCOLORUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMCOLORUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMCOLORInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMCOLORInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMCOLORInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMCOLORInsert]
(
	@COLOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_CHEMCOLOR]
	(
		[COLOR]
	)
	
	VALUES
	(
		@COLOR
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMCOLORInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMCOLORInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMCOLORDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMCOLORDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMCOLORDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMCOLORDelete]
(
	@COLOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_CHEMCOLOR]
	WHERE
		([COLOR] = @COLOR)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMCOLORDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMCOLORDelete Error on Creation'
GO 

