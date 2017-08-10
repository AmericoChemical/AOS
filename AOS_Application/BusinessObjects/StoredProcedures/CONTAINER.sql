
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_CONTAINERLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CONTAINERLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CONTAINERLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_CONTAINERLoadByPrimaryKey]
(
	@Container varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[Container], 
		[UOM], 
		[Units], 
		[TareWeight]
	FROM [dbo].[CONTAINER]
	WHERE
		([Container] = @Container)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CONTAINERLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CONTAINERLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CONTAINERLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CONTAINERLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CONTAINERLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_CONTAINERLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[Container], 
		[UOM], 
		[Units], 
		[TareWeight]
	FROM [dbo].[CONTAINER]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CONTAINERLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CONTAINERLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CONTAINERUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CONTAINERUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CONTAINERUpdate];
GO

CREATE PROCEDURE [dbo].[proc_CONTAINERUpdate]
(
	@Container varchar(50), 
	@UOM varchar(50) = NULL, 
	@Units int = NULL, 
	@TareWeight int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CONTAINER]
	SET
		[UOM] = @UOM, 
		[Units] = @Units, 
		[TareWeight] = @TareWeight
	WHERE
		([Container] = @Container)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CONTAINERUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CONTAINERUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CONTAINERInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CONTAINERInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CONTAINERInsert];
GO

CREATE PROCEDURE [dbo].[proc_CONTAINERInsert]
(
	@Container varchar(50), 
	@UOM varchar(50) = NULL, 
	@Units int = NULL, 
	@TareWeight int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [CONTAINER]
	(
		[Container], 
		[UOM], 
		[Units], 
		[TareWeight]
	)
	
	VALUES
	(
		@Container, 
		@UOM, 
		@Units, 
		@TareWeight
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CONTAINERInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CONTAINERInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CONTAINERDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CONTAINERDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CONTAINERDelete];
GO

CREATE PROCEDURE [dbo].[proc_CONTAINERDelete]
(
	@Container varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[CONTAINER]
	WHERE
		([Container] = @Container)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CONTAINERDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CONTAINERDelete Error on Creation'
GO 

