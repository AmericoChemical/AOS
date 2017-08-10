
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_SUPPLIERCOMPANYLoadByPrimaryKey] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SUPPLIERCOMPANYLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SUPPLIERCOMPANYLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_SUPPLIERCOMPANYLoadByPrimaryKey]
(
	@SUPPLIERCOMPANY varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SUPPLIERCOMPANY]
	FROM [dbo].[SUPPLIERCOMPANY]
	WHERE
		([SUPPLIERCOMPANY] = @SUPPLIERCOMPANY)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SUPPLIERCOMPANYLoadAll] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SUPPLIERCOMPANYLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SUPPLIERCOMPANYLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_SUPPLIERCOMPANYLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SUPPLIERCOMPANY]
	FROM [dbo].[SUPPLIERCOMPANY]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SUPPLIERCOMPANYInsert] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SUPPLIERCOMPANYInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SUPPLIERCOMPANYInsert];
GO

CREATE PROCEDURE [dbo].[proc_SUPPLIERCOMPANYInsert]
(
	@SUPPLIERCOMPANY varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [SUPPLIERCOMPANY]
	(
		[SUPPLIERCOMPANY]
	)
	
	VALUES
	(
		@SUPPLIERCOMPANY
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SUPPLIERCOMPANYDelete] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SUPPLIERCOMPANYDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SUPPLIERCOMPANYDelete];
GO

CREATE PROCEDURE [dbo].[proc_SUPPLIERCOMPANYDelete]
(
	@SUPPLIERCOMPANY varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[SUPPLIERCOMPANY]
	WHERE
		([SUPPLIERCOMPANY] = @SUPPLIERCOMPANY)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYDelete Error on Creation'
GO 

