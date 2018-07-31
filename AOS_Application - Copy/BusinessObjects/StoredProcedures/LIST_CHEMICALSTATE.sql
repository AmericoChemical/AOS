
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMICALSTATELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMICALSTATELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMICALSTATELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMICALSTATELoadByPrimaryKey]
(
	@CHEMICALSTATE varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMICALSTATE]
	FROM [dbo].[LIST_CHEMICALSTATE]
	WHERE
		([CHEMICALSTATE] = @CHEMICALSTATE)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMICALSTATELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMICALSTATELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMICALSTATELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMICALSTATELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMICALSTATE]
	FROM [dbo].[LIST_CHEMICALSTATE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATELoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMICALSTATEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMICALSTATEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMICALSTATEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMICALSTATEInsert]
(
	@CHEMICALSTATE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_CHEMICALSTATE]
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
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMICALSTATEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMICALSTATEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMICALSTATEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMICALSTATEDelete]
(
	@CHEMICALSTATE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_CHEMICALSTATE]
	WHERE
		([CHEMICALSTATE] = @CHEMICALSTATE)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATEDelete Error on Creation'
GO 

