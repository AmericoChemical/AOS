
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_INVPHYSLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVPHYSLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVPHYSLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_INVPHYSLoadByPrimaryKey]
(
	@PHYSINVKey int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PHYSINVKey], 
		[TXTIME], 
		[TXWHO], 
		[INVITEMNUMBER], 
		[UNITSENTERED], 
		[UNITSORIGINAL], 
		[TXTYPE], 
		[TXREASON], 
		[ITEMSTATUS]
	FROM [dbo].[INVPHYS]
	WHERE
		([PHYSINVKey] = @PHYSINVKey)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVPHYSLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVPHYSLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVPHYSLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVPHYSLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVPHYSLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_INVPHYSLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PHYSINVKey], 
		[TXTIME], 
		[TXWHO], 
		[INVITEMNUMBER], 
		[UNITSENTERED], 
		[UNITSORIGINAL], 
		[TXTYPE], 
		[TXREASON], 
		[ITEMSTATUS]
	FROM [dbo].[INVPHYS]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVPHYSLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVPHYSLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVPHYSUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVPHYSUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVPHYSUpdate];
GO

CREATE PROCEDURE [dbo].[proc_INVPHYSUpdate]
(
	@PHYSINVKey int, 
	@TXTIME datetime = NULL, 
	@TXWHO varchar(50) = NULL, 
	@INVITEMNUMBER int = NULL, 
	@UNITSENTERED float = NULL, 
	@UNITSORIGINAL float = NULL, 
	@TXTYPE varchar(50) = NULL, 
	@TXREASON varchar(MAX) = NULL, 
	@ITEMSTATUS varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [INVPHYS]
	SET
		[TXTIME] = @TXTIME, 
		[TXWHO] = @TXWHO, 
		[INVITEMNUMBER] = @INVITEMNUMBER, 
		[UNITSENTERED] = @UNITSENTERED, 
		[UNITSORIGINAL] = @UNITSORIGINAL, 
		[TXTYPE] = @TXTYPE, 
		[TXREASON] = @TXREASON, 
		[ITEMSTATUS] = @ITEMSTATUS
	WHERE
		([PHYSINVKey] = @PHYSINVKey)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVPHYSUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVPHYSUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVPHYSInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVPHYSInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVPHYSInsert];
GO

CREATE PROCEDURE [dbo].[proc_INVPHYSInsert]
(
	@PHYSINVKey int = NULL OUTPUT, 
	@TXTIME datetime = NULL, 
	@TXWHO varchar(50) = NULL, 
	@INVITEMNUMBER int = NULL, 
	@UNITSENTERED float = NULL, 
	@UNITSORIGINAL float = NULL, 
	@TXTYPE varchar(50) = NULL, 
	@TXREASON varchar(MAX) = NULL, 
	@ITEMSTATUS varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [INVPHYS]
	(
		[TXTIME], 
		[TXWHO], 
		[INVITEMNUMBER], 
		[UNITSENTERED], 
		[UNITSORIGINAL], 
		[TXTYPE], 
		[TXREASON], 
		[ITEMSTATUS]
	)
	
	VALUES
	(
		@TXTIME, 
		@TXWHO, 
		@INVITEMNUMBER, 
		@UNITSENTERED, 
		@UNITSORIGINAL, 
		@TXTYPE, 
		@TXREASON, 
		@ITEMSTATUS
	)

	SET @Err = @@Error

		
	SELECT @PHYSINVKey = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVPHYSInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVPHYSInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVPHYSDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVPHYSDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVPHYSDelete];
GO

CREATE PROCEDURE [dbo].[proc_INVPHYSDelete]
(
	@PHYSINVKey int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[INVPHYS]
	WHERE
		([PHYSINVKey] = @PHYSINVKey)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVPHYSDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVPHYSDelete Error on Creation'
GO 

