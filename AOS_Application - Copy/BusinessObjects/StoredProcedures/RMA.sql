
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_RMALoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RMALoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RMALoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_RMALoadByPrimaryKey]
(
	@RMAID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RMAID], 
		[RMADate]
	FROM [dbo].[RMA]
	WHERE
		([RMAID] = @RMAID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RMALoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_RMALoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RMALoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RMALoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RMALoadAll];
GO

CREATE PROCEDURE [dbo].[proc_RMALoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RMAID], 
		[RMADate]
	FROM [dbo].[RMA]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RMALoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_RMALoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RMAUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RMAUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RMAUpdate];
GO

CREATE PROCEDURE [dbo].[proc_RMAUpdate]
(
	@RMAID int, 
	@RMADate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [RMA]
	SET
		[RMADate] = @RMADate
	WHERE
		([RMAID] = @RMAID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RMAUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_RMAUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RMAInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RMAInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RMAInsert];
GO

CREATE PROCEDURE [dbo].[proc_RMAInsert]
(
	@RMAID int = NULL OUTPUT, 
	@RMADate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [RMA]
	(
		[RMADate]
	)
	
	VALUES
	(
		@RMADate
	)

	SET @Err = @@Error

		
	SELECT @RMAID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RMAInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_RMAInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RMADelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RMADelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RMADelete];
GO

CREATE PROCEDURE [dbo].[proc_RMADelete]
(
	@RMAID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[RMA]
	WHERE
		([RMAID] = @RMAID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RMADelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_RMADelete Error on Creation'
GO 

