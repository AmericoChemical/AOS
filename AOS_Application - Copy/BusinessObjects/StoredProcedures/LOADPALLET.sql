
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LOADPALLETLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADPALLETLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADPALLETLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LOADPALLETLoadByPrimaryKey]
(
	@PALLETID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PALLETID], 
		[LOADID], 
		[PALLETTYPE], 
		[PALLETWEIGHT]
	FROM [dbo].[LOADPALLET]
	WHERE
		([PALLETID] = @PALLETID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADPALLETLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADPALLETLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADPALLETLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADPALLETLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADPALLETLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LOADPALLETLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PALLETID], 
		[LOADID], 
		[PALLETTYPE], 
		[PALLETWEIGHT]
	FROM [dbo].[LOADPALLET]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADPALLETLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADPALLETLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADPALLETUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADPALLETUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADPALLETUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LOADPALLETUpdate]
(
	@PALLETID int, 
	@LOADID int = NULL, 
	@PALLETTYPE varchar(50) = NULL, 
	@PALLETWEIGHT int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LOADPALLET]
	SET
		[LOADID] = @LOADID, 
		[PALLETTYPE] = @PALLETTYPE, 
		[PALLETWEIGHT] = @PALLETWEIGHT
	WHERE
		([PALLETID] = @PALLETID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADPALLETUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADPALLETUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADPALLETInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADPALLETInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADPALLETInsert];
GO

CREATE PROCEDURE [dbo].[proc_LOADPALLETInsert]
(
	@PALLETID int = NULL OUTPUT, 
	@LOADID int = NULL, 
	@PALLETTYPE varchar(50) = NULL, 
	@PALLETWEIGHT int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LOADPALLET]
	(
		[LOADID], 
		[PALLETTYPE], 
		[PALLETWEIGHT]
	)
	
	VALUES
	(
		@LOADID, 
		@PALLETTYPE, 
		@PALLETWEIGHT
	)

	SET @Err = @@Error

		
	SELECT @PALLETID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADPALLETInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADPALLETInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADPALLETDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADPALLETDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADPALLETDelete];
GO

CREATE PROCEDURE [dbo].[proc_LOADPALLETDelete]
(
	@PALLETID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LOADPALLET]
	WHERE
		([PALLETID] = @PALLETID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADPALLETDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADPALLETDelete Error on Creation'
GO 

