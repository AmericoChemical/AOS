
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_COLORLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COLORLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COLORLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COLORLoadByPrimaryKey]
(
	@COLOR varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COLOR]
	FROM [dbo].[LIST_COLOR]
	WHERE
		([COLOR] = @COLOR)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COLORLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COLORLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COLORLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COLORLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COLORLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COLORLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COLOR]
	FROM [dbo].[LIST_COLOR]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COLORLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COLORLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COLORUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COLORUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COLORInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COLORInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COLORInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COLORInsert]
(
	@COLOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_COLOR]
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
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COLORInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COLORInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COLORDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COLORDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COLORDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COLORDelete]
(
	@COLOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_COLOR]
	WHERE
		([COLOR] = @COLOR)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COLORDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COLORDelete Error on Creation'
GO 

