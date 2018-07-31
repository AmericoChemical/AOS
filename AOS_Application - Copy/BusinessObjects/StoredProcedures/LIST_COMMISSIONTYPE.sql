
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONTYPELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONTYPELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPELoadByPrimaryKey]
(
	@COMMISSIONTYPE varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONTYPE]
	FROM [dbo].[LIST_COMMISSIONTYPE]
	WHERE
		([COMMISSIONTYPE] = @COMMISSIONTYPE)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONTYPELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONTYPELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONTYPE]
	FROM [dbo].[LIST_COMMISSIONTYPE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPELoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONTYPEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONTYPEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPEInsert]
(
	@COMMISSIONTYPE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_COMMISSIONTYPE]
	(
		[COMMISSIONTYPE]
	)
	
	VALUES
	(
		@COMMISSIONTYPE
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONTYPEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONTYPEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPEDelete]
(
	@COMMISSIONTYPE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_COMMISSIONTYPE]
	WHERE
		([COMMISSIONTYPE] = @COMMISSIONTYPE)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPEDelete Error on Creation'
GO 

