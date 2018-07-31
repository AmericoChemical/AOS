
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_RECEIVERLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RECEIVERLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RECEIVERLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_RECEIVERLoadByPrimaryKey]
(
	@RECEIVERNUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECEIVERNUMBER], 
		[RECEIVEDDATE], 
		[RECEIVERDOCUMENT], 
		[RECEIVERDOCUMENTTYPE], 
		[INBOUNDWAREHOUSE], 
		[POSTED], 
		[VENDORID], 
		[PONUMBER], 
		[PURCHASERELEASENUMBER], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	FROM [dbo].[RECEIVER]
	WHERE
		([RECEIVERNUMBER] = @RECEIVERNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RECEIVERLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_RECEIVERLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RECEIVERLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RECEIVERLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RECEIVERLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_RECEIVERLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECEIVERNUMBER], 
		[RECEIVEDDATE], 
		[RECEIVERDOCUMENT], 
		[RECEIVERDOCUMENTTYPE], 
		[INBOUNDWAREHOUSE], 
		[POSTED], 
		[VENDORID], 
		[PONUMBER], 
		[PURCHASERELEASENUMBER], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	FROM [dbo].[RECEIVER]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RECEIVERLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_RECEIVERLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RECEIVERUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RECEIVERUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RECEIVERUpdate];
GO

CREATE PROCEDURE [dbo].[proc_RECEIVERUpdate]
(
	@RECEIVERNUMBER int, 
	@RECEIVEDDATE datetime = NULL, 
	@RECEIVERDOCUMENT varchar(50) = NULL, 
	@RECEIVERDOCUMENTTYPE varchar(50) = NULL, 
	@INBOUNDWAREHOUSE int = NULL, 
	@POSTED datetime = NULL, 
	@VENDORID int = NULL, 
	@PONUMBER int = NULL, 
	@PURCHASERELEASENUMBER int = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [RECEIVER]
	SET
		[RECEIVEDDATE] = @RECEIVEDDATE, 
		[RECEIVERDOCUMENT] = @RECEIVERDOCUMENT, 
		[RECEIVERDOCUMENTTYPE] = @RECEIVERDOCUMENTTYPE, 
		[INBOUNDWAREHOUSE] = @INBOUNDWAREHOUSE, 
		[POSTED] = @POSTED, 
		[VENDORID] = @VENDORID, 
		[PONUMBER] = @PONUMBER, 
		[PURCHASERELEASENUMBER] = @PURCHASERELEASENUMBER, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME
	WHERE
		([RECEIVERNUMBER] = @RECEIVERNUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RECEIVERUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_RECEIVERUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RECEIVERInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RECEIVERInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RECEIVERInsert];
GO

CREATE PROCEDURE [dbo].[proc_RECEIVERInsert]
(
	@RECEIVERNUMBER int = NULL OUTPUT, 
	@RECEIVEDDATE datetime = NULL, 
	@RECEIVERDOCUMENT varchar(50) = NULL, 
	@RECEIVERDOCUMENTTYPE varchar(50) = NULL, 
	@INBOUNDWAREHOUSE int = NULL, 
	@POSTED datetime = NULL, 
	@VENDORID int = NULL, 
	@PONUMBER int = NULL, 
	@PURCHASERELEASENUMBER int = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [RECEIVER]
	(
		[RECEIVEDDATE], 
		[RECEIVERDOCUMENT], 
		[RECEIVERDOCUMENTTYPE], 
		[INBOUNDWAREHOUSE], 
		[POSTED], 
		[VENDORID], 
		[PONUMBER], 
		[PURCHASERELEASENUMBER], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	)
	
	VALUES
	(
		@RECEIVEDDATE, 
		@RECEIVERDOCUMENT, 
		@RECEIVERDOCUMENTTYPE, 
		@INBOUNDWAREHOUSE, 
		@POSTED, 
		@VENDORID, 
		@PONUMBER, 
		@PURCHASERELEASENUMBER, 
		@CREATEDBY, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME
	)

	SET @Err = @@Error

		
	SELECT @RECEIVERNUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RECEIVERInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_RECEIVERInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RECEIVERDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RECEIVERDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RECEIVERDelete];
GO

CREATE PROCEDURE [dbo].[proc_RECEIVERDelete]
(
	@RECEIVERNUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[RECEIVER]
	WHERE
		([RECEIVERNUMBER] = @RECEIVERNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RECEIVERDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_RECEIVERDelete Error on Creation'
GO 

