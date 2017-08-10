
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONCATEGORYLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONCATEGORYLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYLoadByPrimaryKey]
(
	@COMMISSIONCATEGORY varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONCATEGORY]
	FROM [dbo].[LIST_COMMISSIONCATEGORY]
	WHERE
		([COMMISSIONCATEGORY] = @COMMISSIONCATEGORY)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONCATEGORYLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONCATEGORYLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONCATEGORY]
	FROM [dbo].[LIST_COMMISSIONCATEGORY]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONCATEGORYInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONCATEGORYInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYInsert]
(
	@COMMISSIONCATEGORY varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_COMMISSIONCATEGORY]
	(
		[COMMISSIONCATEGORY]
	)
	
	VALUES
	(
		@COMMISSIONCATEGORY
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONCATEGORYDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONCATEGORYDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYDelete]
(
	@COMMISSIONCATEGORY varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_COMMISSIONCATEGORY]
	WHERE
		([COMMISSIONCATEGORY] = @COMMISSIONCATEGORY)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYDelete Error on Creation'
GO 

