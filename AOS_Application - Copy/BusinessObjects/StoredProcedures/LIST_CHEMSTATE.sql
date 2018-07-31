
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMSTATELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMSTATELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMSTATELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMSTATELoadByPrimaryKey]
(
	@CHEMICALSTATE varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMICALSTATE]
	FROM [dbo].[LIST_CHEMSTATE]
	WHERE
		([CHEMICALSTATE] = @CHEMICALSTATE)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMSTATELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMSTATELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMSTATELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMSTATELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMSTATELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMSTATELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMICALSTATE]
	FROM [dbo].[LIST_CHEMSTATE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMSTATELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMSTATELoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMSTATEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMSTATEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMSTATEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMSTATEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMSTATEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMSTATEInsert]
(
	@CHEMICALSTATE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_CHEMSTATE]
	(
		[CHEMICALSTATE]
	)
	
	VALUES
	(
		@CHEMICALSTATE
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMSTATEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMSTATEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMSTATEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMSTATEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMSTATEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMSTATEDelete]
(
	@CHEMICALSTATE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_CHEMSTATE]
	WHERE
		([CHEMICALSTATE] = @CHEMICALSTATE)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMSTATEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMSTATEDelete Error on Creation'
GO 

