
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_WAREHOUSELoadByPrimaryKey] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_WAREHOUSELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_WAREHOUSELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_WAREHOUSELoadByPrimaryKey]
(
	@WAREHOUSEID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[WAREHOUSEID], 
		[WAREHOUSENAME], 
		[CONSIGNEENAME], 
		[WAREHOUSEADDRESS], 
		[WAREHOUSECITY], 
		[WAREHOUSESTATE], 
		[WAREHOUSEZIPCODE], 
		[WAREHOUSEPHONE]
	FROM [dbo].[WAREHOUSE]
	WHERE
		([WAREHOUSEID] = @WAREHOUSEID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_WAREHOUSELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_WAREHOUSELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_WAREHOUSELoadAll] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_WAREHOUSELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_WAREHOUSELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_WAREHOUSELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[WAREHOUSEID], 
		[WAREHOUSENAME], 
		[CONSIGNEENAME], 
		[WAREHOUSEADDRESS], 
		[WAREHOUSECITY], 
		[WAREHOUSESTATE], 
		[WAREHOUSEZIPCODE], 
		[WAREHOUSEPHONE]
	FROM [dbo].[WAREHOUSE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_WAREHOUSELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_WAREHOUSELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_WAREHOUSEUpdate] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_WAREHOUSEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_WAREHOUSEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_WAREHOUSEUpdate]
(
	@WAREHOUSEID int, 
	@WAREHOUSENAME varchar(50) = NULL, 
	@CONSIGNEENAME varchar(50) = NULL, 
	@WAREHOUSEADDRESS varchar(50) = NULL, 
	@WAREHOUSECITY varchar(50) = NULL, 
	@WAREHOUSESTATE varchar(2) = NULL, 
	@WAREHOUSEZIPCODE varchar(5) = NULL, 
	@WAREHOUSEPHONE varchar(24) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [WAREHOUSE]
	SET
		[WAREHOUSENAME] = @WAREHOUSENAME, 
		[CONSIGNEENAME] = @CONSIGNEENAME, 
		[WAREHOUSEADDRESS] = @WAREHOUSEADDRESS, 
		[WAREHOUSECITY] = @WAREHOUSECITY, 
		[WAREHOUSESTATE] = @WAREHOUSESTATE, 
		[WAREHOUSEZIPCODE] = @WAREHOUSEZIPCODE, 
		[WAREHOUSEPHONE] = @WAREHOUSEPHONE
	WHERE
		([WAREHOUSEID] = @WAREHOUSEID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_WAREHOUSEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_WAREHOUSEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_WAREHOUSEInsert] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_WAREHOUSEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_WAREHOUSEInsert];
GO

CREATE PROCEDURE [dbo].[proc_WAREHOUSEInsert]
(
	@WAREHOUSEID int = NULL OUTPUT, 
	@WAREHOUSENAME varchar(50) = NULL, 
	@CONSIGNEENAME varchar(50) = NULL, 
	@WAREHOUSEADDRESS varchar(50) = NULL, 
	@WAREHOUSECITY varchar(50) = NULL, 
	@WAREHOUSESTATE varchar(2) = NULL, 
	@WAREHOUSEZIPCODE varchar(5) = NULL, 
	@WAREHOUSEPHONE varchar(24) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [WAREHOUSE]
	(
		[WAREHOUSENAME], 
		[CONSIGNEENAME], 
		[WAREHOUSEADDRESS], 
		[WAREHOUSECITY], 
		[WAREHOUSESTATE], 
		[WAREHOUSEZIPCODE], 
		[WAREHOUSEPHONE]
	)
	
	VALUES
	(
		@WAREHOUSENAME, 
		@CONSIGNEENAME, 
		@WAREHOUSEADDRESS, 
		@WAREHOUSECITY, 
		@WAREHOUSESTATE, 
		@WAREHOUSEZIPCODE, 
		@WAREHOUSEPHONE
	)

	SET @Err = @@Error

		
	SELECT @WAREHOUSEID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_WAREHOUSEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_WAREHOUSEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_WAREHOUSEDelete] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_WAREHOUSEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_WAREHOUSEDelete];
GO

CREATE PROCEDURE [dbo].[proc_WAREHOUSEDelete]
(
	@WAREHOUSEID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[WAREHOUSE]
	WHERE
		([WAREHOUSEID] = @WAREHOUSEID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_WAREHOUSEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_WAREHOUSEDelete Error on Creation'
GO 

