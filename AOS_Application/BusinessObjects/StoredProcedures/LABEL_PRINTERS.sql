
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LABEL_PRINTERSLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LABEL_PRINTERSLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LABEL_PRINTERSLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LABEL_PRINTERSLoadByPrimaryKey]
(
	@PRINTERID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRINTERID], 
		[LABEL_TYPE], 
		[PRINTER_IP], 
		[PRINTER_USERNAME], 
		[PRINTER_PASSWORD], 
		[PRINTER_NAME], 
		[ACTIVE], 
		[DISABLE_SCANNER]
	FROM [dbo].[LABEL_PRINTERS]
	WHERE
		([PRINTERID] = @PRINTERID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LABEL_PRINTERSLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LABEL_PRINTERSLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LABEL_PRINTERSLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LABEL_PRINTERSLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LABEL_PRINTERSLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LABEL_PRINTERSLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRINTERID], 
		[LABEL_TYPE], 
		[PRINTER_IP], 
		[PRINTER_USERNAME], 
		[PRINTER_PASSWORD], 
		[PRINTER_NAME], 
		[ACTIVE], 
		[DISABLE_SCANNER]
	FROM [dbo].[LABEL_PRINTERS]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LABEL_PRINTERSLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LABEL_PRINTERSLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LABEL_PRINTERSUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LABEL_PRINTERSUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LABEL_PRINTERSUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LABEL_PRINTERSUpdate]
(
	@PRINTERID int, 
	@LABEL_TYPE varchar(50), 
	@PRINTER_IP varchar(50), 
	@PRINTER_USERNAME varchar(50), 
	@PRINTER_PASSWORD varchar(50), 
	@PRINTER_NAME varchar(100) = NULL, 
	@ACTIVE bit, 
	@DISABLE_SCANNER bit
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LABEL_PRINTERS]
	SET
		[LABEL_TYPE] = @LABEL_TYPE, 
		[PRINTER_IP] = @PRINTER_IP, 
		[PRINTER_USERNAME] = @PRINTER_USERNAME, 
		[PRINTER_PASSWORD] = @PRINTER_PASSWORD, 
		[PRINTER_NAME] = @PRINTER_NAME, 
		[ACTIVE] = @ACTIVE, 
		[DISABLE_SCANNER] = @DISABLE_SCANNER
	WHERE
		([PRINTERID] = @PRINTERID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LABEL_PRINTERSUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LABEL_PRINTERSUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LABEL_PRINTERSInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LABEL_PRINTERSInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LABEL_PRINTERSInsert];
GO

CREATE PROCEDURE [dbo].[proc_LABEL_PRINTERSInsert]
(
	@PRINTERID int, 
	@LABEL_TYPE varchar(50), 
	@PRINTER_IP varchar(50), 
	@PRINTER_USERNAME varchar(50), 
	@PRINTER_PASSWORD varchar(50), 
	@PRINTER_NAME varchar(100) = NULL, 
	@ACTIVE bit, 
	@DISABLE_SCANNER bit
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LABEL_PRINTERS]
	(
		[PRINTERID], 
		[LABEL_TYPE], 
		[PRINTER_IP], 
		[PRINTER_USERNAME], 
		[PRINTER_PASSWORD], 
		[PRINTER_NAME], 
		[ACTIVE], 
		[DISABLE_SCANNER]
	)
	
	VALUES
	(
		@PRINTERID, 
		@LABEL_TYPE, 
		@PRINTER_IP, 
		@PRINTER_USERNAME, 
		@PRINTER_PASSWORD, 
		@PRINTER_NAME, 
		@ACTIVE, 
		@DISABLE_SCANNER
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LABEL_PRINTERSInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LABEL_PRINTERSInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LABEL_PRINTERSDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LABEL_PRINTERSDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LABEL_PRINTERSDelete];
GO

CREATE PROCEDURE [dbo].[proc_LABEL_PRINTERSDelete]
(
	@PRINTERID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LABEL_PRINTERS]
	WHERE
		([PRINTERID] = @PRINTERID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LABEL_PRINTERSDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LABEL_PRINTERSDelete Error on Creation'
GO 

