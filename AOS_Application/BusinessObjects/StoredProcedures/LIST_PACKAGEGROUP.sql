
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_PACKAGEGROUPLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PACKAGEGROUPLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPLoadByPrimaryKey]
(
	@RecID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[PackageGroup]
	FROM [dbo].[LIST_PACKAGEGROUP]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PACKAGEGROUPLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PACKAGEGROUPLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[PackageGroup]
	FROM [dbo].[LIST_PACKAGEGROUP]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PACKAGEGROUPUpdate] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PACKAGEGROUPUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPUpdate]
(
	@RecID int, 
	@PackageGroup varchar(8) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_PACKAGEGROUP]
	SET
		[PackageGroup] = @PackageGroup
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PACKAGEGROUPInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PACKAGEGROUPInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPInsert]
(
	@RecID int, 
	@PackageGroup varchar(8) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_PACKAGEGROUP]
	(
		[RecID], 
		[PackageGroup]
	)
	
	VALUES
	(
		@RecID, 
		@PackageGroup
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PACKAGEGROUPDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PACKAGEGROUPDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPDelete]
(
	@RecID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_PACKAGEGROUP]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPDelete Error on Creation'
GO 

