

USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_APISLoadByPrimaryKey] Script Date: 12/10/2013 4:01:03 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_APISLoadByPrimaryKey]
(
	@APISNUM int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISNUM], 
		[APISDESC], 
		[PRODUCTID], 
		[CONTAINER], 
		[QTYCONTAINERS], 
		[CUSTID], 
		[APISNOTE], 
		[STDLABORHOURS], 
		[UNITCOST], 
		[UNITS], 
		[UOM], 
		[CREATEDTIME], 
		[CREATEDBY], 
		[ISACTIVE], 
		[REVISION], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[USEAGGREGATELOTNO], 
		[APISSTATUS]
	FROM [dbo].[APIS]
	WHERE
		([APISNUM] = @APISNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISLoadAll] Script Date: 12/10/2013 4:01:03 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_APISLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISNUM], 
		[APISDESC], 
		[PRODUCTID], 
		[CONTAINER], 
		[QTYCONTAINERS], 
		[CUSTID], 
		[APISNOTE], 
		[STDLABORHOURS], 
		[UNITCOST], 
		[UNITS], 
		[UOM], 
		[CREATEDTIME], 
		[CREATEDBY], 
		[ISACTIVE], 
		[REVISION], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[USEAGGREGATELOTNO], 
		[APISSTATUS]
	FROM [dbo].[APIS]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISUpdate] Script Date: 12/10/2013 4:01:03 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISUpdate];
GO

CREATE PROCEDURE [dbo].[proc_APISUpdate]
(
	@APISNUM int, 
	@APISDESC varchar(50) = NULL, 
	@PRODUCTID int = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@QTYCONTAINERS int = NULL, 
	@CUSTID int = NULL, 
	@APISNOTE varchar(MAX) = NULL, 
	@STDLABORHOURS float = NULL, 
	@UNITCOST money = NULL, 
	@UNITS int = NULL, 
	@UOM varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@ISACTIVE bit, 
	@REVISION varchar(24) = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@USEAGGREGATELOTNO bit = NULL, 
	@APISSTATUS varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [APIS]
	SET
		[APISDESC] = @APISDESC, 
		[PRODUCTID] = @PRODUCTID, 
		[CONTAINER] = @CONTAINER, 
		[QTYCONTAINERS] = @QTYCONTAINERS, 
		[CUSTID] = @CUSTID, 
		[APISNOTE] = @APISNOTE, 
		[STDLABORHOURS] = @STDLABORHOURS, 
		[UNITCOST] = @UNITCOST, 
		[UNITS] = @UNITS, 
		[UOM] = @UOM, 
		[CREATEDTIME] = @CREATEDTIME, 
		[CREATEDBY] = @CREATEDBY, 
		[ISACTIVE] = @ISACTIVE, 
		[REVISION] = @REVISION, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME, 
		[USEAGGREGATELOTNO] = @USEAGGREGATELOTNO, 
		[APISSTATUS] = @APISSTATUS
	WHERE
		([APISNUM] = @APISNUM)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISInsert] Script Date: 12/10/2013 4:01:03 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISInsert];
GO

CREATE PROCEDURE [dbo].[proc_APISInsert]
(
	@APISNUM int = NULL OUTPUT, 
	@APISDESC varchar(50) = NULL, 
	@PRODUCTID int = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@QTYCONTAINERS int = NULL, 
	@CUSTID int = NULL, 
	@APISNOTE varchar(MAX) = NULL, 
	@STDLABORHOURS float = NULL, 
	@UNITCOST money = NULL, 
	@UNITS int = NULL, 
	@UOM varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@ISACTIVE bit, 
	@REVISION varchar(24) = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@USEAGGREGATELOTNO bit = NULL, 
	@APISSTATUS varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [APIS]
	(
		[APISDESC], 
		[PRODUCTID], 
		[CONTAINER], 
		[QTYCONTAINERS], 
		[CUSTID], 
		[APISNOTE], 
		[STDLABORHOURS], 
		[UNITCOST], 
		[UNITS], 
		[UOM], 
		[CREATEDTIME], 
		[CREATEDBY], 
		[ISACTIVE], 
		[REVISION], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[USEAGGREGATELOTNO], 
		[APISSTATUS]
	)
	
	VALUES
	(
		@APISDESC, 
		@PRODUCTID, 
		@CONTAINER, 
		@QTYCONTAINERS, 
		@CUSTID, 
		@APISNOTE, 
		@STDLABORHOURS, 
		@UNITCOST, 
		@UNITS, 
		@UOM, 
		@CREATEDTIME, 
		@CREATEDBY, 
		@ISACTIVE, 
		@REVISION, 
		@MODIFYBY, 
		@MODIFYTIME, 
		@USEAGGREGATELOTNO, 
		@APISSTATUS
	)

	SET @Err = @@Error

		
	SELECT @APISNUM = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISDelete] Script Date: 12/10/2013 4:01:03 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISDelete];
GO

CREATE PROCEDURE [dbo].[proc_APISDelete]
(
	@APISNUM int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[APIS]
	WHERE
		([APISNUM] = @APISNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISDelete Error on Creation'
GO 

