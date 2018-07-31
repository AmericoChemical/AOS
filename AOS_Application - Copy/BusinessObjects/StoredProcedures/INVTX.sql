
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_INVTXLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVTXLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVTXLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_INVTXLoadByPrimaryKey]
(
	@TXID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[TXID], 
		[TXTIME], 
		[TXWHO], 
		[TXTYPE], 
		[TXDOCID], 
		[INVITEMNUMBER], 
		[UNITSUSED]
	FROM [dbo].[INVTX]
	WHERE
		([TXID] = @TXID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVTXLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVTXLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVTXLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVTXLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVTXLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_INVTXLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[TXID], 
		[TXTIME], 
		[TXWHO], 
		[TXTYPE], 
		[TXDOCID], 
		[INVITEMNUMBER], 
		[UNITSUSED]
	FROM [dbo].[INVTX]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVTXLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVTXLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVTXUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVTXUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVTXUpdate];
GO

CREATE PROCEDURE [dbo].[proc_INVTXUpdate]
(
	@TXID int, 
	@TXTIME datetime = NULL, 
	@TXWHO varchar(50) = NULL, 
	@TXTYPE varchar(50) = NULL, 
	@TXDOCID int = NULL, 
	@INVITEMNUMBER int = NULL, 
	@UNITSUSED decimal(18,4) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [INVTX]
	SET
		[TXTIME] = @TXTIME, 
		[TXWHO] = @TXWHO, 
		[TXTYPE] = @TXTYPE, 
		[TXDOCID] = @TXDOCID, 
		[INVITEMNUMBER] = @INVITEMNUMBER, 
		[UNITSUSED] = @UNITSUSED
	WHERE
		([TXID] = @TXID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVTXUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVTXUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVTXInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVTXInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVTXInsert];
GO

CREATE PROCEDURE [dbo].[proc_INVTXInsert]
(
	@TXID int = NULL OUTPUT, 
	@TXTIME datetime = NULL, 
	@TXWHO varchar(50) = NULL, 
	@TXTYPE varchar(50) = NULL, 
	@TXDOCID int = NULL, 
	@INVITEMNUMBER int = NULL, 
	@UNITSUSED decimal(18,4) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [INVTX]
	(
		[TXTIME], 
		[TXWHO], 
		[TXTYPE], 
		[TXDOCID], 
		[INVITEMNUMBER], 
		[UNITSUSED]
	)
	
	VALUES
	(
		@TXTIME, 
		@TXWHO, 
		@TXTYPE, 
		@TXDOCID, 
		@INVITEMNUMBER, 
		@UNITSUSED
	)

	SET @Err = @@Error

		
	SELECT @TXID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVTXInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVTXInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVTXDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVTXDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVTXDelete];
GO

CREATE PROCEDURE [dbo].[proc_INVTXDelete]
(
	@TXID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[INVTX]
	WHERE
		([TXID] = @TXID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVTXDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVTXDelete Error on Creation'
GO 

