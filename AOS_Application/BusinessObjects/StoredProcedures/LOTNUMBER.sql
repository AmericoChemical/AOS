
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LOTNUMBERLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOTNUMBERLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOTNUMBERLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LOTNUMBERLoadByPrimaryKey]
(
	@BATCHKEY int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[BATCHKEY], 
		[CREATEDTIME], 
		[CREATEDBY], 
		[WAREHOUSEID], 
		[RECEIVERNUMBER], 
		[LOTNUMBER]
	FROM [dbo].[LOTNUMBER]
	WHERE
		([BATCHKEY] = @BATCHKEY)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOTNUMBERLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOTNUMBERLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOTNUMBERLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOTNUMBERLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOTNUMBERLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LOTNUMBERLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[BATCHKEY], 
		[CREATEDTIME], 
		[CREATEDBY], 
		[WAREHOUSEID], 
		[RECEIVERNUMBER], 
		[LOTNUMBER]
	FROM [dbo].[LOTNUMBER]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOTNUMBERLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOTNUMBERLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOTNUMBERUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOTNUMBERUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOTNUMBERUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LOTNUMBERUpdate]
(
	@BATCHKEY int, 
	@CREATEDTIME datetime = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@WAREHOUSEID int = NULL, 
	@RECEIVERNUMBER int = NULL, 
	@LOTNUMBER varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LOTNUMBER]
	SET
		[CREATEDTIME] = @CREATEDTIME, 
		[CREATEDBY] = @CREATEDBY, 
		[WAREHOUSEID] = @WAREHOUSEID, 
		[RECEIVERNUMBER] = @RECEIVERNUMBER, 
		[LOTNUMBER] = @LOTNUMBER
	WHERE
		([BATCHKEY] = @BATCHKEY)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOTNUMBERUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOTNUMBERUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOTNUMBERInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOTNUMBERInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOTNUMBERInsert];
GO

CREATE PROCEDURE [dbo].[proc_LOTNUMBERInsert]
(
	@BATCHKEY int = NULL OUTPUT, 
	@CREATEDTIME datetime = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@WAREHOUSEID int = NULL, 
	@RECEIVERNUMBER int = NULL, 
	@LOTNUMBER varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LOTNUMBER]
	(
		[CREATEDTIME], 
		[CREATEDBY], 
		[WAREHOUSEID], 
		[RECEIVERNUMBER], 
		[LOTNUMBER]
	)
	
	VALUES
	(
		@CREATEDTIME, 
		@CREATEDBY, 
		@WAREHOUSEID, 
		@RECEIVERNUMBER, 
		@LOTNUMBER
	)

	SET @Err = @@Error

		
	SELECT @BATCHKEY = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOTNUMBERInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOTNUMBERInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOTNUMBERDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOTNUMBERDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOTNUMBERDelete];
GO

CREATE PROCEDURE [dbo].[proc_LOTNUMBERDelete]
(
	@BATCHKEY int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LOTNUMBER]
	WHERE
		([BATCHKEY] = @BATCHKEY)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOTNUMBERDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOTNUMBERDelete Error on Creation'
GO 

