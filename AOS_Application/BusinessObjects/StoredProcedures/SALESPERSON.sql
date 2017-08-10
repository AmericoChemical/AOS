
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_SALESPERSONLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SALESPERSONLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SALESPERSONLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_SALESPERSONLoadByPrimaryKey]
(
	@SALESPERSONID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SALESPERSONID], 
		[SALESPERSONFIRSTNAME], 
		[SALESPERSONLASTNAME], 
		[SALESPERSONTITLE], 
		[SALESPERSONFULLNAME]
	FROM [dbo].[SALESPERSON]
	WHERE
		([SALESPERSONID] = @SALESPERSONID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SALESPERSONLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_SALESPERSONLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SALESPERSONLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SALESPERSONLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SALESPERSONLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_SALESPERSONLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SALESPERSONID], 
		[SALESPERSONFIRSTNAME], 
		[SALESPERSONLASTNAME], 
		[SALESPERSONTITLE], 
		[SALESPERSONFULLNAME]
	FROM [dbo].[SALESPERSON]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SALESPERSONLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_SALESPERSONLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SALESPERSONUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SALESPERSONUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SALESPERSONUpdate];
GO

CREATE PROCEDURE [dbo].[proc_SALESPERSONUpdate]
(
	@SALESPERSONID int, 
	@SALESPERSONFIRSTNAME varchar(50) = NULL, 
	@SALESPERSONLASTNAME varchar(50) = NULL, 
	@SALESPERSONTITLE varchar(50) = NULL, 
	@SALESPERSONFULLNAME varchar(101) = NULL OUTPUT
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [SALESPERSON]
	SET
		[SALESPERSONFIRSTNAME] = @SALESPERSONFIRSTNAME, 
		[SALESPERSONLASTNAME] = @SALESPERSONLASTNAME, 
		[SALESPERSONTITLE] = @SALESPERSONTITLE
	WHERE
		([SALESPERSONID] = @SALESPERSONID)

	SET @Err = @@Error

		    SELECT @SALESPERSONFULLNAME = [SALESPERSONFULLNAME]
			  FROM [dbo].[SALESPERSON]
			 WHERE [SALESPERSONID] = @SALESPERSONID
  

	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SALESPERSONUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_SALESPERSONUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SALESPERSONInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SALESPERSONInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SALESPERSONInsert];
GO

CREATE PROCEDURE [dbo].[proc_SALESPERSONInsert]
(
	@SALESPERSONID int = NULL OUTPUT, 
	@SALESPERSONFIRSTNAME varchar(50) = NULL, 
	@SALESPERSONLASTNAME varchar(50) = NULL, 
	@SALESPERSONTITLE varchar(50) = NULL, 
	@SALESPERSONFULLNAME varchar(101) = NULL OUTPUT
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [SALESPERSON]
	(
		[SALESPERSONFIRSTNAME], 
		[SALESPERSONLASTNAME], 
		[SALESPERSONTITLE]
	)
	
	VALUES
	(
		@SALESPERSONFIRSTNAME, 
		@SALESPERSONLASTNAME, 
		@SALESPERSONTITLE
	)

	SET @Err = @@Error

		
	SELECT @SALESPERSONID = SCOPE_IDENTITY()
		    SELECT @SALESPERSONFULLNAME = [SALESPERSONFULLNAME]
			  FROM [dbo].[SALESPERSON]
			 WHERE [SALESPERSONID] = @SALESPERSONID
  

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SALESPERSONInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_SALESPERSONInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SALESPERSONDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SALESPERSONDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SALESPERSONDelete];
GO

CREATE PROCEDURE [dbo].[proc_SALESPERSONDelete]
(
	@SALESPERSONID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[SALESPERSON]
	WHERE
		([SALESPERSONID] = @SALESPERSONID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SALESPERSONDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_SALESPERSONDelete Error on Creation'
GO 

