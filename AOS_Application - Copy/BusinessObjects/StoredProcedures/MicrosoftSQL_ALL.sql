

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


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_APISHISTORYLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISHISTORYLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISHISTORYLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_APISHISTORYLoadByPrimaryKey]
(
	@APISCHANGEID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISCHANGEID], 
		[APISNUM], 
		[CHANGEDATE], 
		[WHOCHANGED], 
		[REASONFORCHANGE]
	FROM [dbo].[APISHISTORY]
	WHERE
		([APISCHANGEID] = @APISCHANGEID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISHISTORYLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISHISTORYLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISHISTORYLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISHISTORYLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISHISTORYLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_APISHISTORYLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISCHANGEID], 
		[APISNUM], 
		[CHANGEDATE], 
		[WHOCHANGED], 
		[REASONFORCHANGE]
	FROM [dbo].[APISHISTORY]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISHISTORYLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISHISTORYLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISHISTORYUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISHISTORYUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISHISTORYUpdate];
GO

CREATE PROCEDURE [dbo].[proc_APISHISTORYUpdate]
(
	@APISCHANGEID int, 
	@APISNUM int = NULL, 
	@CHANGEDATE datetime = NULL, 
	@WHOCHANGED varchar(50) = NULL, 
	@REASONFORCHANGE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [APISHISTORY]
	SET
		[APISNUM] = @APISNUM, 
		[CHANGEDATE] = @CHANGEDATE, 
		[WHOCHANGED] = @WHOCHANGED, 
		[REASONFORCHANGE] = @REASONFORCHANGE
	WHERE
		([APISCHANGEID] = @APISCHANGEID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISHISTORYUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISHISTORYUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISHISTORYInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISHISTORYInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISHISTORYInsert];
GO

CREATE PROCEDURE [dbo].[proc_APISHISTORYInsert]
(
	@APISCHANGEID int = NULL OUTPUT, 
	@APISNUM int = NULL, 
	@CHANGEDATE datetime = NULL, 
	@WHOCHANGED varchar(50) = NULL, 
	@REASONFORCHANGE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [APISHISTORY]
	(
		[APISNUM], 
		[CHANGEDATE], 
		[WHOCHANGED], 
		[REASONFORCHANGE]
	)
	
	VALUES
	(
		@APISNUM, 
		@CHANGEDATE, 
		@WHOCHANGED, 
		@REASONFORCHANGE
	)

	SET @Err = @@Error

		
	SELECT @APISCHANGEID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISHISTORYInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISHISTORYInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISHISTORYDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISHISTORYDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISHISTORYDelete];
GO

CREATE PROCEDURE [dbo].[proc_APISHISTORYDelete]
(
	@APISCHANGEID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[APISHISTORY]
	WHERE
		([APISCHANGEID] = @APISCHANGEID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISHISTORYDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISHISTORYDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_APISITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_APISITEMLoadByPrimaryKey]
(
	@APISITEMNUM int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISITEMNUM], 
		[APISNUM], 
		[MATERIALID], 
		[QTYUNITS], 
		[UOM], 
		[APISITEMNOTE], 
		[SOURCEPRODUCTID]
	FROM [dbo].[APISITEM]
	WHERE
		([APISITEMNUM] = @APISITEMNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISITEMLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_APISITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISITEMNUM], 
		[APISNUM], 
		[MATERIALID], 
		[QTYUNITS], 
		[UOM], 
		[APISITEMNOTE], 
		[SOURCEPRODUCTID]
	FROM [dbo].[APISITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISITEMUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_APISITEMUpdate]
(
	@APISITEMNUM int, 
	@APISNUM int = NULL, 
	@MATERIALID int = NULL, 
	@QTYUNITS float = NULL, 
	@UOM varchar(50) = NULL, 
	@APISITEMNOTE varchar(MAX) = NULL, 
	@SOURCEPRODUCTID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [APISITEM]
	SET
		[APISNUM] = @APISNUM, 
		[MATERIALID] = @MATERIALID, 
		[QTYUNITS] = @QTYUNITS, 
		[UOM] = @UOM, 
		[APISITEMNOTE] = @APISITEMNOTE, 
		[SOURCEPRODUCTID] = @SOURCEPRODUCTID
	WHERE
		([APISITEMNUM] = @APISITEMNUM)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISITEMInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_APISITEMInsert]
(
	@APISITEMNUM int = NULL OUTPUT, 
	@APISNUM int = NULL, 
	@MATERIALID int = NULL, 
	@QTYUNITS float = NULL, 
	@UOM varchar(50) = NULL, 
	@APISITEMNOTE varchar(MAX) = NULL, 
	@SOURCEPRODUCTID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [APISITEM]
	(
		[APISNUM], 
		[MATERIALID], 
		[QTYUNITS], 
		[UOM], 
		[APISITEMNOTE], 
		[SOURCEPRODUCTID]
	)
	
	VALUES
	(
		@APISNUM, 
		@MATERIALID, 
		@QTYUNITS, 
		@UOM, 
		@APISITEMNOTE, 
		@SOURCEPRODUCTID
	)

	SET @Err = @@Error

		
	SELECT @APISITEMNUM = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISITEMDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_APISITEMDelete]
(
	@APISITEMNUM int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[APISITEM]
	WHERE
		([APISITEMNUM] = @APISITEMNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISITEMDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_APISNOTELoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISNOTELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISNOTELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_APISNOTELoadByPrimaryKey]
(
	@APISNOTEID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISNOTEID], 
		[APISNUM], 
		[SEQUENCE], 
		[APISNOTE]
	FROM [dbo].[APISNOTE]
	WHERE
		([APISNOTEID] = @APISNOTEID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISNOTELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISNOTELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISNOTELoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISNOTELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISNOTELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_APISNOTELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISNOTEID], 
		[APISNUM], 
		[SEQUENCE], 
		[APISNOTE]
	FROM [dbo].[APISNOTE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISNOTELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISNOTELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISNOTEUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISNOTEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISNOTEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_APISNOTEUpdate]
(
	@APISNOTEID int, 
	@APISNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@APISNOTE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [APISNOTE]
	SET
		[APISNUM] = @APISNUM, 
		[SEQUENCE] = @SEQUENCE, 
		[APISNOTE] = @APISNOTE
	WHERE
		([APISNOTEID] = @APISNOTEID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISNOTEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISNOTEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISNOTEInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISNOTEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISNOTEInsert];
GO

CREATE PROCEDURE [dbo].[proc_APISNOTEInsert]
(
	@APISNOTEID int = NULL OUTPUT, 
	@APISNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@APISNOTE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [APISNOTE]
	(
		[APISNUM], 
		[SEQUENCE], 
		[APISNOTE]
	)
	
	VALUES
	(
		@APISNUM, 
		@SEQUENCE, 
		@APISNOTE
	)

	SET @Err = @@Error

		
	SELECT @APISNOTEID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISNOTEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISNOTEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISNOTEDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISNOTEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISNOTEDelete];
GO

CREATE PROCEDURE [dbo].[proc_APISNOTEDelete]
(
	@APISNOTEID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[APISNOTE]
	WHERE
		([APISNOTEID] = @APISNOTEID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISNOTEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISNOTEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_APISPROCEDURELoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISPROCEDURELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISPROCEDURELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_APISPROCEDURELoadByPrimaryKey]
(
	@APISPROCNUM int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISPROCNUM], 
		[APISNUM], 
		[SEQUENCE], 
		[APISPROCEDURE]
	FROM [dbo].[APISPROCEDURE]
	WHERE
		([APISPROCNUM] = @APISPROCNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISPROCEDURELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISPROCEDURELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISPROCEDURELoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISPROCEDURELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISPROCEDURELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_APISPROCEDURELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISPROCNUM], 
		[APISNUM], 
		[SEQUENCE], 
		[APISPROCEDURE]
	FROM [dbo].[APISPROCEDURE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISPROCEDURELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISPROCEDURELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISPROCEDUREUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISPROCEDUREUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISPROCEDUREUpdate];
GO

CREATE PROCEDURE [dbo].[proc_APISPROCEDUREUpdate]
(
	@APISPROCNUM int, 
	@APISNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@APISPROCEDURE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [APISPROCEDURE]
	SET
		[APISNUM] = @APISNUM, 
		[SEQUENCE] = @SEQUENCE, 
		[APISPROCEDURE] = @APISPROCEDURE
	WHERE
		([APISPROCNUM] = @APISPROCNUM)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISPROCEDUREUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISPROCEDUREUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISPROCEDUREInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISPROCEDUREInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISPROCEDUREInsert];
GO

CREATE PROCEDURE [dbo].[proc_APISPROCEDUREInsert]
(
	@APISPROCNUM int = NULL OUTPUT, 
	@APISNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@APISPROCEDURE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [APISPROCEDURE]
	(
		[APISNUM], 
		[SEQUENCE], 
		[APISPROCEDURE]
	)
	
	VALUES
	(
		@APISNUM, 
		@SEQUENCE, 
		@APISPROCEDURE
	)

	SET @Err = @@Error

		
	SELECT @APISPROCNUM = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISPROCEDUREInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISPROCEDUREInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISPROCEDUREDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISPROCEDUREDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISPROCEDUREDelete];
GO

CREATE PROCEDURE [dbo].[proc_APISPROCEDUREDelete]
(
	@APISPROCNUM int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[APISPROCEDURE]
	WHERE
		([APISPROCNUM] = @APISPROCNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISPROCEDUREDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISPROCEDUREDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_APPUSERLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APPUSERLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APPUSERLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_APPUSERLoadByPrimaryKey]
(
	@USERLOGIN varchar(24)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[USERLOGIN], 
		[USERFULLNAME], 
		[USERPASSWORD], 
		[USERSECURITYLEVEL], 
		[REQUESTSCANNERPASSWORD], 
		[PREVENTSCANNERACCESS], 
		[SCANNERSESSIONTIMEOUT], 
		[SESSIONID], 
		[LOGINDATETIME]
	FROM [dbo].[APPUSER]
	WHERE
		([USERLOGIN] = @USERLOGIN)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APPUSERLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_APPUSERLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APPUSERLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APPUSERLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APPUSERLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_APPUSERLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[USERLOGIN], 
		[USERFULLNAME], 
		[USERPASSWORD], 
		[USERSECURITYLEVEL], 
		[REQUESTSCANNERPASSWORD], 
		[PREVENTSCANNERACCESS], 
		[SCANNERSESSIONTIMEOUT], 
		[SESSIONID], 
		[LOGINDATETIME]
	FROM [dbo].[APPUSER]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APPUSERLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_APPUSERLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APPUSERUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APPUSERUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APPUSERUpdate];
GO

CREATE PROCEDURE [dbo].[proc_APPUSERUpdate]
(
	@USERLOGIN varchar(24), 
	@USERFULLNAME varchar(50) = NULL, 
	@USERPASSWORD varchar(14) = NULL, 
	@USERSECURITYLEVEL int = NULL, 
	@REQUESTSCANNERPASSWORD bit = NULL, 
	@PREVENTSCANNERACCESS bit = NULL, 
	@SCANNERSESSIONTIMEOUT int = NULL, 
	@SESSIONID varchar(100) = NULL, 
	@LOGINDATETIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [APPUSER]
	SET
		[USERFULLNAME] = @USERFULLNAME, 
		[USERPASSWORD] = @USERPASSWORD, 
		[USERSECURITYLEVEL] = @USERSECURITYLEVEL, 
		[REQUESTSCANNERPASSWORD] = @REQUESTSCANNERPASSWORD, 
		[PREVENTSCANNERACCESS] = @PREVENTSCANNERACCESS, 
		[SCANNERSESSIONTIMEOUT] = @SCANNERSESSIONTIMEOUT, 
		[SESSIONID] = @SESSIONID, 
		[LOGINDATETIME] = @LOGINDATETIME
	WHERE
		([USERLOGIN] = @USERLOGIN)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APPUSERUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_APPUSERUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APPUSERInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APPUSERInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APPUSERInsert];
GO

CREATE PROCEDURE [dbo].[proc_APPUSERInsert]
(
	@USERLOGIN varchar(24), 
	@USERFULLNAME varchar(50) = NULL, 
	@USERPASSWORD varchar(14) = NULL, 
	@USERSECURITYLEVEL int = NULL, 
	@REQUESTSCANNERPASSWORD bit = NULL, 
	@PREVENTSCANNERACCESS bit = NULL, 
	@SCANNERSESSIONTIMEOUT int = NULL, 
	@SESSIONID varchar(100) = NULL, 
	@LOGINDATETIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [APPUSER]
	(
		[USERLOGIN], 
		[USERFULLNAME], 
		[USERPASSWORD], 
		[USERSECURITYLEVEL], 
		[REQUESTSCANNERPASSWORD], 
		[PREVENTSCANNERACCESS], 
		[SCANNERSESSIONTIMEOUT], 
		[SESSIONID], 
		[LOGINDATETIME]
	)
	
	VALUES
	(
		@USERLOGIN, 
		@USERFULLNAME, 
		@USERPASSWORD, 
		@USERSECURITYLEVEL, 
		@REQUESTSCANNERPASSWORD, 
		@PREVENTSCANNERACCESS, 
		@SCANNERSESSIONTIMEOUT, 
		@SESSIONID, 
		@LOGINDATETIME
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APPUSERInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_APPUSERInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APPUSERDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APPUSERDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APPUSERDelete];
GO

CREATE PROCEDURE [dbo].[proc_APPUSERDelete]
(
	@USERLOGIN varchar(24)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[APPUSER]
	WHERE
		([USERLOGIN] = @USERLOGIN)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APPUSERDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_APPUSERDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_CARRIERLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CARRIERLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CARRIERLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_CARRIERLoadByPrimaryKey]
(
	@CarrierID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CarrierID], 
		[CarrierName], 
		[CarrierAddress], 
		[CarrierAddress2], 
		[CarrierCity], 
		[CarrierState], 
		[CarrierZipcode], 
		[CarrierPhone], 
		[CarrierFax], 
		[TermsCarrier], 
		[CarrierContactName], 
		[CarrierContactEmail], 
		[CarrierContactURL], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE]
	FROM [dbo].[CARRIER]
	WHERE
		([CarrierID] = @CarrierID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CARRIERLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CARRIERLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CARRIERLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CARRIERLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CARRIERLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_CARRIERLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CarrierID], 
		[CarrierName], 
		[CarrierAddress], 
		[CarrierAddress2], 
		[CarrierCity], 
		[CarrierState], 
		[CarrierZipcode], 
		[CarrierPhone], 
		[CarrierFax], 
		[TermsCarrier], 
		[CarrierContactName], 
		[CarrierContactEmail], 
		[CarrierContactURL], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE]
	FROM [dbo].[CARRIER]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CARRIERLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CARRIERLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CARRIERUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CARRIERUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CARRIERUpdate];
GO

CREATE PROCEDURE [dbo].[proc_CARRIERUpdate]
(
	@CarrierID int, 
	@CarrierName varchar(50) = NULL, 
	@CarrierAddress varchar(50) = NULL, 
	@CarrierAddress2 varchar(50) = NULL, 
	@CarrierCity varchar(50) = NULL, 
	@CarrierState varchar(2) = NULL, 
	@CarrierZipcode varchar(10) = NULL, 
	@CarrierPhone varchar(24) = NULL, 
	@CarrierFax varchar(24) = NULL, 
	@TermsCarrier varchar(24) = NULL, 
	@CarrierContactName varchar(50) = NULL, 
	@CarrierContactEmail varchar(100) = NULL, 
	@CarrierContactURL varchar(50) = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@ISACTIVE bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CARRIER]
	SET
		[CarrierName] = @CarrierName, 
		[CarrierAddress] = @CarrierAddress, 
		[CarrierAddress2] = @CarrierAddress2, 
		[CarrierCity] = @CarrierCity, 
		[CarrierState] = @CarrierState, 
		[CarrierZipcode] = @CarrierZipcode, 
		[CarrierPhone] = @CarrierPhone, 
		[CarrierFax] = @CarrierFax, 
		[TermsCarrier] = @TermsCarrier, 
		[CarrierContactName] = @CarrierContactName, 
		[CarrierContactEmail] = @CarrierContactEmail, 
		[CarrierContactURL] = @CarrierContactURL, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME, 
		[ISACTIVE] = @ISACTIVE
	WHERE
		([CarrierID] = @CarrierID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CARRIERUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CARRIERUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CARRIERInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CARRIERInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CARRIERInsert];
GO

CREATE PROCEDURE [dbo].[proc_CARRIERInsert]
(
	@CarrierID int = NULL OUTPUT, 
	@CarrierName varchar(50) = NULL, 
	@CarrierAddress varchar(50) = NULL, 
	@CarrierAddress2 varchar(50) = NULL, 
	@CarrierCity varchar(50) = NULL, 
	@CarrierState varchar(2) = NULL, 
	@CarrierZipcode varchar(10) = NULL, 
	@CarrierPhone varchar(24) = NULL, 
	@CarrierFax varchar(24) = NULL, 
	@TermsCarrier varchar(24) = NULL, 
	@CarrierContactName varchar(50) = NULL, 
	@CarrierContactEmail varchar(100) = NULL, 
	@CarrierContactURL varchar(50) = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@ISACTIVE bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [CARRIER]
	(
		[CarrierName], 
		[CarrierAddress], 
		[CarrierAddress2], 
		[CarrierCity], 
		[CarrierState], 
		[CarrierZipcode], 
		[CarrierPhone], 
		[CarrierFax], 
		[TermsCarrier], 
		[CarrierContactName], 
		[CarrierContactEmail], 
		[CarrierContactURL], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE]
	)
	
	VALUES
	(
		@CarrierName, 
		@CarrierAddress, 
		@CarrierAddress2, 
		@CarrierCity, 
		@CarrierState, 
		@CarrierZipcode, 
		@CarrierPhone, 
		@CarrierFax, 
		@TermsCarrier, 
		@CarrierContactName, 
		@CarrierContactEmail, 
		@CarrierContactURL, 
		@CREATEDBY, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME, 
		@ISACTIVE
	)

	SET @Err = @@Error

		
	SELECT @CarrierID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CARRIERInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CARRIERInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CARRIERDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CARRIERDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CARRIERDelete];
GO

CREATE PROCEDURE [dbo].[proc_CARRIERDelete]
(
	@CarrierID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[CARRIER]
	WHERE
		([CarrierID] = @CarrierID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CARRIERDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CARRIERDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_CHEMICALLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALLoadByPrimaryKey]
(
	@CHEMICALID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMICALID], 
		[CHEMICALNAME], 
		[CASNUMBER], 
		[pH_LOW], 
		[pH_HIGH], 
		[pH_COMPSYMBOL], 
		[pH_COMPVALUE], 
		[SG_LOW], 
		[SG_HIGH], 
		[SG_COMPSYMBOL], 
		[SG_COMPVALUE], 
		[DOTNAME], 
		[APPEARANCE], 
		[COLOR], 
		[ODOR], 
		[STATE], 
		[DENSITY]
	FROM [dbo].[CHEMICAL]
	WHERE
		([CHEMICALID] = @CHEMICALID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMICALID], 
		[CHEMICALNAME], 
		[CASNUMBER], 
		[pH_LOW], 
		[pH_HIGH], 
		[pH_COMPSYMBOL], 
		[pH_COMPVALUE], 
		[SG_LOW], 
		[SG_HIGH], 
		[SG_COMPSYMBOL], 
		[SG_COMPVALUE], 
		[DOTNAME], 
		[APPEARANCE], 
		[COLOR], 
		[ODOR], 
		[STATE], 
		[DENSITY]
	FROM [dbo].[CHEMICAL]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALUpdate];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALUpdate]
(
	@CHEMICALID int, 
	@CHEMICALNAME varchar(200) = NULL, 
	@CASNUMBER varchar(50) = NULL, 
	@pH_LOW decimal(18,3) = NULL, 
	@pH_HIGH decimal(18,3) = NULL, 
	@pH_COMPSYMBOL varchar(8) = NULL, 
	@pH_COMPVALUE decimal(18,3) = NULL, 
	@SG_LOW decimal(18,3) = NULL, 
	@SG_HIGH decimal(18,3) = NULL, 
	@SG_COMPSYMBOL varchar(8) = NULL, 
	@SG_COMPVALUE decimal(18,3) = NULL, 
	@DOTNAME varchar(200) = NULL, 
	@APPEARANCE varchar(50) = NULL, 
	@COLOR varchar(50) = NULL, 
	@ODOR varchar(50) = NULL, 
	@STATE varchar(50) = NULL, 
	@DENSITY decimal(18,3) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CHEMICAL]
	SET
		[CHEMICALNAME] = @CHEMICALNAME, 
		[CASNUMBER] = @CASNUMBER, 
		[pH_LOW] = @pH_LOW, 
		[pH_HIGH] = @pH_HIGH, 
		[pH_COMPSYMBOL] = @pH_COMPSYMBOL, 
		[pH_COMPVALUE] = @pH_COMPVALUE, 
		[SG_LOW] = @SG_LOW, 
		[SG_HIGH] = @SG_HIGH, 
		[SG_COMPSYMBOL] = @SG_COMPSYMBOL, 
		[SG_COMPVALUE] = @SG_COMPVALUE, 
		[DOTNAME] = @DOTNAME, 
		[APPEARANCE] = @APPEARANCE, 
		[COLOR] = @COLOR, 
		[ODOR] = @ODOR, 
		[STATE] = @STATE, 
		[DENSITY] = @DENSITY
	WHERE
		([CHEMICALID] = @CHEMICALID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALInsert];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALInsert]
(
	@CHEMICALID int = NULL OUTPUT, 
	@CHEMICALNAME varchar(200) = NULL, 
	@CASNUMBER varchar(50) = NULL, 
	@pH_LOW decimal(18,3) = NULL, 
	@pH_HIGH decimal(18,3) = NULL, 
	@pH_COMPSYMBOL varchar(8) = NULL, 
	@pH_COMPVALUE decimal(18,3) = NULL, 
	@SG_LOW decimal(18,3) = NULL, 
	@SG_HIGH decimal(18,3) = NULL, 
	@SG_COMPSYMBOL varchar(8) = NULL, 
	@SG_COMPVALUE decimal(18,3) = NULL, 
	@DOTNAME varchar(200) = NULL, 
	@APPEARANCE varchar(50) = NULL, 
	@COLOR varchar(50) = NULL, 
	@ODOR varchar(50) = NULL, 
	@STATE varchar(50) = NULL, 
	@DENSITY decimal(18,3) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [CHEMICAL]
	(
		[CHEMICALNAME], 
		[CASNUMBER], 
		[pH_LOW], 
		[pH_HIGH], 
		[pH_COMPSYMBOL], 
		[pH_COMPVALUE], 
		[SG_LOW], 
		[SG_HIGH], 
		[SG_COMPSYMBOL], 
		[SG_COMPVALUE], 
		[DOTNAME], 
		[APPEARANCE], 
		[COLOR], 
		[ODOR], 
		[STATE], 
		[DENSITY]
	)
	
	VALUES
	(
		@CHEMICALNAME, 
		@CASNUMBER, 
		@pH_LOW, 
		@pH_HIGH, 
		@pH_COMPSYMBOL, 
		@pH_COMPVALUE, 
		@SG_LOW, 
		@SG_HIGH, 
		@SG_COMPSYMBOL, 
		@SG_COMPVALUE, 
		@DOTNAME, 
		@APPEARANCE, 
		@COLOR, 
		@ODOR, 
		@STATE, 
		@DENSITY
	)

	SET @Err = @@Error

		
	SELECT @CHEMICALID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALDelete];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALDelete]
(
	@CHEMICALID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[CHEMICAL]
	WHERE
		([CHEMICALID] = @CHEMICALID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_CHEMICALBOMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALBOMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALBOMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALBOMLoadByPrimaryKey]
(
	@CHEMBOMID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMBOMID], 
		[CHEMICALID1], 
		[CHEMICALID2], 
		[UNITS], 
		[UOM], 
		[PERCBYWGT]
	FROM [dbo].[CHEMICALBOM]
	WHERE
		([CHEMBOMID] = @CHEMBOMID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALBOMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALBOMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALBOMLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALBOMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALBOMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALBOMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMBOMID], 
		[CHEMICALID1], 
		[CHEMICALID2], 
		[UNITS], 
		[UOM], 
		[PERCBYWGT]
	FROM [dbo].[CHEMICALBOM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALBOMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALBOMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALBOMUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALBOMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALBOMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALBOMUpdate]
(
	@CHEMBOMID int, 
	@CHEMICALID1 int = NULL, 
	@CHEMICALID2 int = NULL, 
	@UNITS decimal(18,4) = NULL, 
	@UOM varchar(50) = NULL, 
	@PERCBYWGT decimal(18,4) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CHEMICALBOM]
	SET
		[CHEMICALID1] = @CHEMICALID1, 
		[CHEMICALID2] = @CHEMICALID2, 
		[UNITS] = @UNITS, 
		[UOM] = @UOM, 
		[PERCBYWGT] = @PERCBYWGT
	WHERE
		([CHEMBOMID] = @CHEMBOMID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALBOMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALBOMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALBOMInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALBOMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALBOMInsert];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALBOMInsert]
(
	@CHEMBOMID int = NULL OUTPUT, 
	@CHEMICALID1 int = NULL, 
	@CHEMICALID2 int = NULL, 
	@UNITS decimal(18,4) = NULL, 
	@UOM varchar(50) = NULL, 
	@PERCBYWGT decimal(18,4) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [CHEMICALBOM]
	(
		[CHEMICALID1], 
		[CHEMICALID2], 
		[UNITS], 
		[UOM], 
		[PERCBYWGT]
	)
	
	VALUES
	(
		@CHEMICALID1, 
		@CHEMICALID2, 
		@UNITS, 
		@UOM, 
		@PERCBYWGT
	)

	SET @Err = @@Error

		
	SELECT @CHEMBOMID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALBOMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALBOMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALBOMDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALBOMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALBOMDelete];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALBOMDelete]
(
	@CHEMBOMID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[CHEMICALBOM]
	WHERE
		([CHEMBOMID] = @CHEMBOMID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALBOMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALBOMDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONLoadByPrimaryKey]
(
	@COMMISSIONID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONID], 
		[COMMISSIONDATE], 
		[SALESPERSONID], 
		[CUSTID], 
		[INVOICENUMBER], 
		[COMMISSIONAMOUNT], 
		[COMMISSIONSTATUS], 
		[COMMISSIONDESC], 
		[COMMISSIONTYPE], 
		[DATECUSTOMERPAID], 
		[DATECOMMISSIONPAID], 
		[COMMISSIONPMTID], 
		[COMMISSIONNOTE], 
		[COMMISSIONCATEGORY]
	FROM [dbo].[COMMISSION]
	WHERE
		([COMMISSIONID] = @COMMISSIONID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONID], 
		[COMMISSIONDATE], 
		[SALESPERSONID], 
		[CUSTID], 
		[INVOICENUMBER], 
		[COMMISSIONAMOUNT], 
		[COMMISSIONSTATUS], 
		[COMMISSIONDESC], 
		[COMMISSIONTYPE], 
		[DATECUSTOMERPAID], 
		[DATECOMMISSIONPAID], 
		[COMMISSIONPMTID], 
		[COMMISSIONNOTE], 
		[COMMISSIONCATEGORY]
	FROM [dbo].[COMMISSION]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONUpdate];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONUpdate]
(
	@COMMISSIONID int, 
	@COMMISSIONDATE datetime = NULL, 
	@SALESPERSONID int = NULL, 
	@CUSTID int = NULL, 
	@INVOICENUMBER int = NULL, 
	@COMMISSIONAMOUNT money = NULL, 
	@COMMISSIONSTATUS varchar(50) = NULL, 
	@COMMISSIONDESC varchar(200) = NULL, 
	@COMMISSIONTYPE varchar(50) = NULL, 
	@DATECUSTOMERPAID datetime = NULL, 
	@DATECOMMISSIONPAID datetime = NULL, 
	@COMMISSIONPMTID int = NULL, 
	@COMMISSIONNOTE varchar(200) = NULL, 
	@COMMISSIONCATEGORY varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [COMMISSION]
	SET
		[COMMISSIONDATE] = @COMMISSIONDATE, 
		[SALESPERSONID] = @SALESPERSONID, 
		[CUSTID] = @CUSTID, 
		[INVOICENUMBER] = @INVOICENUMBER, 
		[COMMISSIONAMOUNT] = @COMMISSIONAMOUNT, 
		[COMMISSIONSTATUS] = @COMMISSIONSTATUS, 
		[COMMISSIONDESC] = @COMMISSIONDESC, 
		[COMMISSIONTYPE] = @COMMISSIONTYPE, 
		[DATECUSTOMERPAID] = @DATECUSTOMERPAID, 
		[DATECOMMISSIONPAID] = @DATECOMMISSIONPAID, 
		[COMMISSIONPMTID] = @COMMISSIONPMTID, 
		[COMMISSIONNOTE] = @COMMISSIONNOTE, 
		[COMMISSIONCATEGORY] = @COMMISSIONCATEGORY
	WHERE
		([COMMISSIONID] = @COMMISSIONID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONInsert];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONInsert]
(
	@COMMISSIONID int = NULL OUTPUT, 
	@COMMISSIONDATE datetime = NULL, 
	@SALESPERSONID int = NULL, 
	@CUSTID int = NULL, 
	@INVOICENUMBER int = NULL, 
	@COMMISSIONAMOUNT money = NULL, 
	@COMMISSIONSTATUS varchar(50) = NULL, 
	@COMMISSIONDESC varchar(200) = NULL, 
	@COMMISSIONTYPE varchar(50) = NULL, 
	@DATECUSTOMERPAID datetime = NULL, 
	@DATECOMMISSIONPAID datetime = NULL, 
	@COMMISSIONPMTID int = NULL, 
	@COMMISSIONNOTE varchar(200) = NULL, 
	@COMMISSIONCATEGORY varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [COMMISSION]
	(
		[COMMISSIONDATE], 
		[SALESPERSONID], 
		[CUSTID], 
		[INVOICENUMBER], 
		[COMMISSIONAMOUNT], 
		[COMMISSIONSTATUS], 
		[COMMISSIONDESC], 
		[COMMISSIONTYPE], 
		[DATECUSTOMERPAID], 
		[DATECOMMISSIONPAID], 
		[COMMISSIONPMTID], 
		[COMMISSIONNOTE], 
		[COMMISSIONCATEGORY]
	)
	
	VALUES
	(
		@COMMISSIONDATE, 
		@SALESPERSONID, 
		@CUSTID, 
		@INVOICENUMBER, 
		@COMMISSIONAMOUNT, 
		@COMMISSIONSTATUS, 
		@COMMISSIONDESC, 
		@COMMISSIONTYPE, 
		@DATECUSTOMERPAID, 
		@DATECOMMISSIONPAID, 
		@COMMISSIONPMTID, 
		@COMMISSIONNOTE, 
		@COMMISSIONCATEGORY
	)

	SET @Err = @@Error

		
	SELECT @COMMISSIONID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONDelete];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONDelete]
(
	@COMMISSIONID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[COMMISSION]
	WHERE
		([COMMISSIONID] = @COMMISSIONID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONBALNLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONBALNLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONBALNLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONBALNLoadByPrimaryKey]
(
	@COMMISSIONBALNID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONBALNID], 
		[SALESPERSONID], 
		[COMMISSIONTYPE], 
		[COMMISSIONBALNDUE], 
		[COMMISSIONBALNDATE]
	FROM [dbo].[COMMISSIONBALN]
	WHERE
		([COMMISSIONBALNID] = @COMMISSIONBALNID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONBALNLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONBALNLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONBALNLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONBALNLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONBALNLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONBALNLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONBALNID], 
		[SALESPERSONID], 
		[COMMISSIONTYPE], 
		[COMMISSIONBALNDUE], 
		[COMMISSIONBALNDATE]
	FROM [dbo].[COMMISSIONBALN]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONBALNLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONBALNLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONBALNUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONBALNUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONBALNUpdate];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONBALNUpdate]
(
	@COMMISSIONBALNID int, 
	@SALESPERSONID int = NULL, 
	@COMMISSIONTYPE varchar(50) = NULL, 
	@COMMISSIONBALNDUE money = NULL, 
	@COMMISSIONBALNDATE datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [COMMISSIONBALN]
	SET
		[SALESPERSONID] = @SALESPERSONID, 
		[COMMISSIONTYPE] = @COMMISSIONTYPE, 
		[COMMISSIONBALNDUE] = @COMMISSIONBALNDUE, 
		[COMMISSIONBALNDATE] = @COMMISSIONBALNDATE
	WHERE
		([COMMISSIONBALNID] = @COMMISSIONBALNID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONBALNUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONBALNUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONBALNInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONBALNInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONBALNInsert];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONBALNInsert]
(
	@COMMISSIONBALNID int = NULL OUTPUT, 
	@SALESPERSONID int = NULL, 
	@COMMISSIONTYPE varchar(50) = NULL, 
	@COMMISSIONBALNDUE money = NULL, 
	@COMMISSIONBALNDATE datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [COMMISSIONBALN]
	(
		[SALESPERSONID], 
		[COMMISSIONTYPE], 
		[COMMISSIONBALNDUE], 
		[COMMISSIONBALNDATE]
	)
	
	VALUES
	(
		@SALESPERSONID, 
		@COMMISSIONTYPE, 
		@COMMISSIONBALNDUE, 
		@COMMISSIONBALNDATE
	)

	SET @Err = @@Error

		
	SELECT @COMMISSIONBALNID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONBALNInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONBALNInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONBALNDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONBALNDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONBALNDelete];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONBALNDelete]
(
	@COMMISSIONBALNID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[COMMISSIONBALN]
	WHERE
		([COMMISSIONBALNID] = @COMMISSIONBALNID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONBALNDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONBALNDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONEXCEPTIONLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONEXCEPTIONLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONEXCEPTIONLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONEXCEPTIONLoadByPrimaryKey]
(
	@ExceptionID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ExceptionID], 
		[CustAssignID], 
		[ProductID], 
		[CommissionRate]
	FROM [dbo].[COMMISSIONEXCEPTION]
	WHERE
		([ExceptionID] = @ExceptionID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONEXCEPTIONLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONEXCEPTIONLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONEXCEPTIONLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONEXCEPTIONLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONEXCEPTIONLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONEXCEPTIONLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ExceptionID], 
		[CustAssignID], 
		[ProductID], 
		[CommissionRate]
	FROM [dbo].[COMMISSIONEXCEPTION]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONEXCEPTIONLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONEXCEPTIONLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONEXCEPTIONUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONEXCEPTIONUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONEXCEPTIONUpdate];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONEXCEPTIONUpdate]
(
	@ExceptionID int, 
	@CustAssignID int = NULL, 
	@ProductID int = NULL, 
	@CommissionRate float = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [COMMISSIONEXCEPTION]
	SET
		[CustAssignID] = @CustAssignID, 
		[ProductID] = @ProductID, 
		[CommissionRate] = @CommissionRate
	WHERE
		([ExceptionID] = @ExceptionID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONEXCEPTIONUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONEXCEPTIONUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONEXCEPTIONInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONEXCEPTIONInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONEXCEPTIONInsert];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONEXCEPTIONInsert]
(
	@ExceptionID int = NULL OUTPUT, 
	@CustAssignID int = NULL, 
	@ProductID int = NULL, 
	@CommissionRate float = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [COMMISSIONEXCEPTION]
	(
		[CustAssignID], 
		[ProductID], 
		[CommissionRate]
	)
	
	VALUES
	(
		@CustAssignID, 
		@ProductID, 
		@CommissionRate
	)

	SET @Err = @@Error

		
	SELECT @ExceptionID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONEXCEPTIONInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONEXCEPTIONInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONEXCEPTIONDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONEXCEPTIONDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONEXCEPTIONDelete];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONEXCEPTIONDelete]
(
	@ExceptionID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[COMMISSIONEXCEPTION]
	WHERE
		([ExceptionID] = @ExceptionID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONEXCEPTIONDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONEXCEPTIONDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONPMTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONPMTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONPMTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONPMTLoadByPrimaryKey]
(
	@COMMISSIONPMTID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONPMTID], 
		[COMMISSIONPMTDATE], 
		[COMMISSIONPMTAMT], 
		[SALESPERSONID], 
		[COMMISSIONPMTTYPE], 
		[COMMISSIONPMTNOTE]
	FROM [dbo].[COMMISSIONPMT]
	WHERE
		([COMMISSIONPMTID] = @COMMISSIONPMTID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONPMTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONPMTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONPMTLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONPMTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONPMTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONPMTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONPMTID], 
		[COMMISSIONPMTDATE], 
		[COMMISSIONPMTAMT], 
		[SALESPERSONID], 
		[COMMISSIONPMTTYPE], 
		[COMMISSIONPMTNOTE]
	FROM [dbo].[COMMISSIONPMT]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONPMTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONPMTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONPMTUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONPMTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONPMTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONPMTUpdate]
(
	@COMMISSIONPMTID int, 
	@COMMISSIONPMTDATE datetime = NULL, 
	@COMMISSIONPMTAMT money = NULL, 
	@SALESPERSONID int = NULL, 
	@COMMISSIONPMTTYPE varchar(50) = NULL, 
	@COMMISSIONPMTNOTE varchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [COMMISSIONPMT]
	SET
		[COMMISSIONPMTDATE] = @COMMISSIONPMTDATE, 
		[COMMISSIONPMTAMT] = @COMMISSIONPMTAMT, 
		[SALESPERSONID] = @SALESPERSONID, 
		[COMMISSIONPMTTYPE] = @COMMISSIONPMTTYPE, 
		[COMMISSIONPMTNOTE] = @COMMISSIONPMTNOTE
	WHERE
		([COMMISSIONPMTID] = @COMMISSIONPMTID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONPMTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONPMTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONPMTInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONPMTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONPMTInsert];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONPMTInsert]
(
	@COMMISSIONPMTID int = NULL OUTPUT, 
	@COMMISSIONPMTDATE datetime = NULL, 
	@COMMISSIONPMTAMT money = NULL, 
	@SALESPERSONID int = NULL, 
	@COMMISSIONPMTTYPE varchar(50) = NULL, 
	@COMMISSIONPMTNOTE varchar(200) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [COMMISSIONPMT]
	(
		[COMMISSIONPMTDATE], 
		[COMMISSIONPMTAMT], 
		[SALESPERSONID], 
		[COMMISSIONPMTTYPE], 
		[COMMISSIONPMTNOTE]
	)
	
	VALUES
	(
		@COMMISSIONPMTDATE, 
		@COMMISSIONPMTAMT, 
		@SALESPERSONID, 
		@COMMISSIONPMTTYPE, 
		@COMMISSIONPMTNOTE
	)

	SET @Err = @@Error

		
	SELECT @COMMISSIONPMTID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONPMTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONPMTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_COMMISSIONPMTDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_COMMISSIONPMTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_COMMISSIONPMTDelete];
GO

CREATE PROCEDURE [dbo].[proc_COMMISSIONPMTDelete]
(
	@COMMISSIONPMTID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[COMMISSIONPMT]
	WHERE
		([COMMISSIONPMTID] = @COMMISSIONPMTID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_COMMISSIONPMTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_COMMISSIONPMTDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_CONTAINERLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CONTAINERLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CONTAINERLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_CONTAINERLoadByPrimaryKey]
(
	@Container varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[Container], 
		[UOM], 
		[Units], 
		[TareWeight]
	FROM [dbo].[CONTAINER]
	WHERE
		([Container] = @Container)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CONTAINERLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CONTAINERLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CONTAINERLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CONTAINERLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CONTAINERLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_CONTAINERLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[Container], 
		[UOM], 
		[Units], 
		[TareWeight]
	FROM [dbo].[CONTAINER]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CONTAINERLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CONTAINERLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CONTAINERUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CONTAINERUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CONTAINERUpdate];
GO

CREATE PROCEDURE [dbo].[proc_CONTAINERUpdate]
(
	@Container varchar(50), 
	@UOM varchar(50) = NULL, 
	@Units int = NULL, 
	@TareWeight int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CONTAINER]
	SET
		[UOM] = @UOM, 
		[Units] = @Units, 
		[TareWeight] = @TareWeight
	WHERE
		([Container] = @Container)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CONTAINERUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CONTAINERUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CONTAINERInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CONTAINERInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CONTAINERInsert];
GO

CREATE PROCEDURE [dbo].[proc_CONTAINERInsert]
(
	@Container varchar(50), 
	@UOM varchar(50) = NULL, 
	@Units int = NULL, 
	@TareWeight int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [CONTAINER]
	(
		[Container], 
		[UOM], 
		[Units], 
		[TareWeight]
	)
	
	VALUES
	(
		@Container, 
		@UOM, 
		@Units, 
		@TareWeight
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CONTAINERInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CONTAINERInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CONTAINERDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CONTAINERDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CONTAINERDelete];
GO

CREATE PROCEDURE [dbo].[proc_CONTAINERDelete]
(
	@Container varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[CONTAINER]
	WHERE
		([Container] = @Container)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CONTAINERDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CONTAINERDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERLoadByPrimaryKey]
(
	@CUSTID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CUSTID], 
		[CUSTNAME], 
		[CUSTBILLADDRESS1], 
		[CUSTBILLADDRESS2], 
		[CUSTBILLCITY], 
		[CUSTBILLSTATEPROV], 
		[CUSTBILLPOSTALCODE], 
		[CUSTBILLCOUNTRY], 
		[CUSTPHONE], 
		[CUSTFAX], 
		[CUSTBILLCONTACT], 
		[CUSTSHIPADDRESS1], 
		[CUSTSHIPADDRESS2], 
		[CUSTSHIPCITY], 
		[CUSTSHIPSTATEPROV], 
		[CUSTSHIPPOSTALCODE], 
		[CUSTSHIPCOUNTRY], 
		[CUSTSHIPCONTACT], 
		[FREIGHTCARRIER1], 
		[FREIGHTCARRIER2], 
		[FOB], 
		[CUSTNOTES], 
		[TAXEXEMPT], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE], 
		[CARRIERID], 
		[LOGISTICSID], 
		[BULKCARRIERID], 
		[SALESPERSONID], 
		[FREIGHTBILLCUSTOMER], 
		[FREIGHTONINVOICE], 
		[ORDERNOTE], 
		[SHIPMENTNOTE], 
		[INVOICENOTE], 
		[CUSTEMAIL], 
		[NEEDPACKINGLIST]
	FROM [dbo].[CUSTOMER]
	WHERE
		([CUSTID] = @CUSTID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CUSTID], 
		[CUSTNAME], 
		[CUSTBILLADDRESS1], 
		[CUSTBILLADDRESS2], 
		[CUSTBILLCITY], 
		[CUSTBILLSTATEPROV], 
		[CUSTBILLPOSTALCODE], 
		[CUSTBILLCOUNTRY], 
		[CUSTPHONE], 
		[CUSTFAX], 
		[CUSTBILLCONTACT], 
		[CUSTSHIPADDRESS1], 
		[CUSTSHIPADDRESS2], 
		[CUSTSHIPCITY], 
		[CUSTSHIPSTATEPROV], 
		[CUSTSHIPPOSTALCODE], 
		[CUSTSHIPCOUNTRY], 
		[CUSTSHIPCONTACT], 
		[FREIGHTCARRIER1], 
		[FREIGHTCARRIER2], 
		[FOB], 
		[CUSTNOTES], 
		[TAXEXEMPT], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE], 
		[CARRIERID], 
		[LOGISTICSID], 
		[BULKCARRIERID], 
		[SALESPERSONID], 
		[FREIGHTBILLCUSTOMER], 
		[FREIGHTONINVOICE], 
		[ORDERNOTE], 
		[SHIPMENTNOTE], 
		[INVOICENOTE], 
		[CUSTEMAIL], 
		[NEEDPACKINGLIST]
	FROM [dbo].[CUSTOMER]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERUpdate];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERUpdate]
(
	@CUSTID int, 
	@CUSTNAME varchar(50) = NULL, 
	@CUSTBILLADDRESS1 varchar(50) = NULL, 
	@CUSTBILLADDRESS2 varchar(50) = NULL, 
	@CUSTBILLCITY varchar(50) = NULL, 
	@CUSTBILLSTATEPROV varchar(50) = NULL, 
	@CUSTBILLPOSTALCODE varchar(24) = NULL, 
	@CUSTBILLCOUNTRY varchar(50) = NULL, 
	@CUSTPHONE varchar(24) = NULL, 
	@CUSTFAX varchar(24) = NULL, 
	@CUSTBILLCONTACT varchar(50) = NULL, 
	@CUSTSHIPADDRESS1 varchar(50) = NULL, 
	@CUSTSHIPADDRESS2 varchar(50) = NULL, 
	@CUSTSHIPCITY varchar(50) = NULL, 
	@CUSTSHIPSTATEPROV varchar(50) = NULL, 
	@CUSTSHIPPOSTALCODE varchar(24) = NULL, 
	@CUSTSHIPCOUNTRY varchar(50) = NULL, 
	@CUSTSHIPCONTACT varchar(50) = NULL, 
	@FREIGHTCARRIER1 varchar(50) = NULL, 
	@FREIGHTCARRIER2 varchar(50) = NULL, 
	@FOB varchar(24) = NULL, 
	@CUSTNOTES varchar(MAX) = NULL, 
	@TAXEXEMPT nvarchar(1) = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@ISACTIVE bit = NULL, 
	@CARRIERID int = NULL, 
	@LOGISTICSID int = NULL, 
	@BULKCARRIERID int = NULL, 
	@SALESPERSONID int = NULL, 
	@FREIGHTBILLCUSTOMER bit = NULL, 
	@FREIGHTONINVOICE bit = NULL, 
	@ORDERNOTE varchar(MAX) = NULL, 
	@SHIPMENTNOTE varchar(MAX) = NULL, 
	@INVOICENOTE varchar(MAX) = NULL, 
	@CUSTEMAIL varchar(200) = NULL, 
	@NEEDPACKINGLIST bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CUSTOMER]
	SET
		[CUSTNAME] = @CUSTNAME, 
		[CUSTBILLADDRESS1] = @CUSTBILLADDRESS1, 
		[CUSTBILLADDRESS2] = @CUSTBILLADDRESS2, 
		[CUSTBILLCITY] = @CUSTBILLCITY, 
		[CUSTBILLSTATEPROV] = @CUSTBILLSTATEPROV, 
		[CUSTBILLPOSTALCODE] = @CUSTBILLPOSTALCODE, 
		[CUSTBILLCOUNTRY] = @CUSTBILLCOUNTRY, 
		[CUSTPHONE] = @CUSTPHONE, 
		[CUSTFAX] = @CUSTFAX, 
		[CUSTBILLCONTACT] = @CUSTBILLCONTACT, 
		[CUSTSHIPADDRESS1] = @CUSTSHIPADDRESS1, 
		[CUSTSHIPADDRESS2] = @CUSTSHIPADDRESS2, 
		[CUSTSHIPCITY] = @CUSTSHIPCITY, 
		[CUSTSHIPSTATEPROV] = @CUSTSHIPSTATEPROV, 
		[CUSTSHIPPOSTALCODE] = @CUSTSHIPPOSTALCODE, 
		[CUSTSHIPCOUNTRY] = @CUSTSHIPCOUNTRY, 
		[CUSTSHIPCONTACT] = @CUSTSHIPCONTACT, 
		[FREIGHTCARRIER1] = @FREIGHTCARRIER1, 
		[FREIGHTCARRIER2] = @FREIGHTCARRIER2, 
		[FOB] = @FOB, 
		[CUSTNOTES] = @CUSTNOTES, 
		[TAXEXEMPT] = @TAXEXEMPT, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME, 
		[ISACTIVE] = @ISACTIVE, 
		[CARRIERID] = @CARRIERID, 
		[LOGISTICSID] = @LOGISTICSID, 
		[BULKCARRIERID] = @BULKCARRIERID, 
		[SALESPERSONID] = @SALESPERSONID, 
		[FREIGHTBILLCUSTOMER] = @FREIGHTBILLCUSTOMER, 
		[FREIGHTONINVOICE] = @FREIGHTONINVOICE, 
		[ORDERNOTE] = @ORDERNOTE, 
		[SHIPMENTNOTE] = @SHIPMENTNOTE, 
		[INVOICENOTE] = @INVOICENOTE, 
		[CUSTEMAIL] = @CUSTEMAIL, 
		[NEEDPACKINGLIST] = @NEEDPACKINGLIST
	WHERE
		([CUSTID] = @CUSTID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERInsert];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERInsert]
(
	@CUSTID int = NULL OUTPUT, 
	@CUSTNAME varchar(50) = NULL, 
	@CUSTBILLADDRESS1 varchar(50) = NULL, 
	@CUSTBILLADDRESS2 varchar(50) = NULL, 
	@CUSTBILLCITY varchar(50) = NULL, 
	@CUSTBILLSTATEPROV varchar(50) = NULL, 
	@CUSTBILLPOSTALCODE varchar(24) = NULL, 
	@CUSTBILLCOUNTRY varchar(50) = NULL, 
	@CUSTPHONE varchar(24) = NULL, 
	@CUSTFAX varchar(24) = NULL, 
	@CUSTBILLCONTACT varchar(50) = NULL, 
	@CUSTSHIPADDRESS1 varchar(50) = NULL, 
	@CUSTSHIPADDRESS2 varchar(50) = NULL, 
	@CUSTSHIPCITY varchar(50) = NULL, 
	@CUSTSHIPSTATEPROV varchar(50) = NULL, 
	@CUSTSHIPPOSTALCODE varchar(24) = NULL, 
	@CUSTSHIPCOUNTRY varchar(50) = NULL, 
	@CUSTSHIPCONTACT varchar(50) = NULL, 
	@FREIGHTCARRIER1 varchar(50) = NULL, 
	@FREIGHTCARRIER2 varchar(50) = NULL, 
	@FOB varchar(24) = NULL, 
	@CUSTNOTES varchar(MAX) = NULL, 
	@TAXEXEMPT nvarchar(1) = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@ISACTIVE bit = NULL, 
	@CARRIERID int = NULL, 
	@LOGISTICSID int = NULL, 
	@BULKCARRIERID int = NULL, 
	@SALESPERSONID int = NULL, 
	@FREIGHTBILLCUSTOMER bit = NULL, 
	@FREIGHTONINVOICE bit = NULL, 
	@ORDERNOTE varchar(MAX) = NULL, 
	@SHIPMENTNOTE varchar(MAX) = NULL, 
	@INVOICENOTE varchar(MAX) = NULL, 
	@CUSTEMAIL varchar(200) = NULL, 
	@NEEDPACKINGLIST bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [CUSTOMER]
	(
		[CUSTNAME], 
		[CUSTBILLADDRESS1], 
		[CUSTBILLADDRESS2], 
		[CUSTBILLCITY], 
		[CUSTBILLSTATEPROV], 
		[CUSTBILLPOSTALCODE], 
		[CUSTBILLCOUNTRY], 
		[CUSTPHONE], 
		[CUSTFAX], 
		[CUSTBILLCONTACT], 
		[CUSTSHIPADDRESS1], 
		[CUSTSHIPADDRESS2], 
		[CUSTSHIPCITY], 
		[CUSTSHIPSTATEPROV], 
		[CUSTSHIPPOSTALCODE], 
		[CUSTSHIPCOUNTRY], 
		[CUSTSHIPCONTACT], 
		[FREIGHTCARRIER1], 
		[FREIGHTCARRIER2], 
		[FOB], 
		[CUSTNOTES], 
		[TAXEXEMPT], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE], 
		[CARRIERID], 
		[LOGISTICSID], 
		[BULKCARRIERID], 
		[SALESPERSONID], 
		[FREIGHTBILLCUSTOMER], 
		[FREIGHTONINVOICE], 
		[ORDERNOTE], 
		[SHIPMENTNOTE], 
		[INVOICENOTE], 
		[CUSTEMAIL], 
		[NEEDPACKINGLIST]
	)
	
	VALUES
	(
		@CUSTNAME, 
		@CUSTBILLADDRESS1, 
		@CUSTBILLADDRESS2, 
		@CUSTBILLCITY, 
		@CUSTBILLSTATEPROV, 
		@CUSTBILLPOSTALCODE, 
		@CUSTBILLCOUNTRY, 
		@CUSTPHONE, 
		@CUSTFAX, 
		@CUSTBILLCONTACT, 
		@CUSTSHIPADDRESS1, 
		@CUSTSHIPADDRESS2, 
		@CUSTSHIPCITY, 
		@CUSTSHIPSTATEPROV, 
		@CUSTSHIPPOSTALCODE, 
		@CUSTSHIPCOUNTRY, 
		@CUSTSHIPCONTACT, 
		@FREIGHTCARRIER1, 
		@FREIGHTCARRIER2, 
		@FOB, 
		@CUSTNOTES, 
		@TAXEXEMPT, 
		@CREATEDBY, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME, 
		@ISACTIVE, 
		@CARRIERID, 
		@LOGISTICSID, 
		@BULKCARRIERID, 
		@SALESPERSONID, 
		@FREIGHTBILLCUSTOMER, 
		@FREIGHTONINVOICE, 
		@ORDERNOTE, 
		@SHIPMENTNOTE, 
		@INVOICENOTE, 
		@CUSTEMAIL, 
		@NEEDPACKINGLIST
	)

	SET @Err = @@Error

		
	SELECT @CUSTID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERDelete];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERDelete]
(
	@CUSTID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[CUSTOMER]
	WHERE
		([CUSTID] = @CUSTID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERASSIGNMENTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERASSIGNMENTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERASSIGNMENTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERASSIGNMENTLoadByPrimaryKey]
(
	@CustAssignID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CustAssignID], 
		[SalespersonID], 
		[CustID], 
		[CommissionRate], 
		[CommissionType]
	FROM [dbo].[CUSTOMERASSIGNMENT]
	WHERE
		([CustAssignID] = @CustAssignID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERASSIGNMENTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERASSIGNMENTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERASSIGNMENTLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERASSIGNMENTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERASSIGNMENTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERASSIGNMENTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CustAssignID], 
		[SalespersonID], 
		[CustID], 
		[CommissionRate], 
		[CommissionType]
	FROM [dbo].[CUSTOMERASSIGNMENT]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERASSIGNMENTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERASSIGNMENTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERASSIGNMENTUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERASSIGNMENTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERASSIGNMENTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERASSIGNMENTUpdate]
(
	@CustAssignID int, 
	@SalespersonID int, 
	@CustID int, 
	@CommissionRate float = NULL, 
	@CommissionType varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CUSTOMERASSIGNMENT]
	SET
		[SalespersonID] = @SalespersonID, 
		[CustID] = @CustID, 
		[CommissionRate] = @CommissionRate, 
		[CommissionType] = @CommissionType
	WHERE
		([CustAssignID] = @CustAssignID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERASSIGNMENTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERASSIGNMENTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERASSIGNMENTInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERASSIGNMENTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERASSIGNMENTInsert];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERASSIGNMENTInsert]
(
	@CustAssignID int = NULL OUTPUT, 
	@SalespersonID int, 
	@CustID int, 
	@CommissionRate float = NULL, 
	@CommissionType varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [CUSTOMERASSIGNMENT]
	(
		[SalespersonID], 
		[CustID], 
		[CommissionRate], 
		[CommissionType]
	)
	
	VALUES
	(
		@SalespersonID, 
		@CustID, 
		@CommissionRate, 
		@CommissionType
	)

	SET @Err = @@Error

		
	SELECT @CustAssignID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERASSIGNMENTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERASSIGNMENTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERASSIGNMENTDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERASSIGNMENTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERASSIGNMENTDelete];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERASSIGNMENTDelete]
(
	@CustAssignID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[CUSTOMERASSIGNMENT]
	WHERE
		([CustAssignID] = @CustAssignID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERASSIGNMENTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERASSIGNMENTDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERPAYMENTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERPAYMENTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERPAYMENTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERPAYMENTLoadByPrimaryKey]
(
	@CUSTOMERPMTID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CUSTOMERPMTID], 
		[CUSTID], 
		[PAYMENTDATE], 
		[PAYMENTAMOUNT], 
		[REMITTANCEADVICE], 
		[BALANCE]
	FROM [dbo].[CUSTOMERPAYMENT]
	WHERE
		([CUSTOMERPMTID] = @CUSTOMERPMTID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERPAYMENTLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERPAYMENTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERPAYMENTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERPAYMENTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CUSTOMERPMTID], 
		[CUSTID], 
		[PAYMENTDATE], 
		[PAYMENTAMOUNT], 
		[REMITTANCEADVICE], 
		[BALANCE]
	FROM [dbo].[CUSTOMERPAYMENT]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERPAYMENTUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERPAYMENTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERPAYMENTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERPAYMENTUpdate]
(
	@CUSTOMERPMTID int, 
	@CUSTID int = NULL, 
	@PAYMENTDATE datetime = NULL, 
	@PAYMENTAMOUNT money = NULL, 
	@REMITTANCEADVICE varchar(50) = NULL, 
	@BALANCE money = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CUSTOMERPAYMENT]
	SET
		[CUSTID] = @CUSTID, 
		[PAYMENTDATE] = @PAYMENTDATE, 
		[PAYMENTAMOUNT] = @PAYMENTAMOUNT, 
		[REMITTANCEADVICE] = @REMITTANCEADVICE, 
		[BALANCE] = @BALANCE
	WHERE
		([CUSTOMERPMTID] = @CUSTOMERPMTID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERPAYMENTInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERPAYMENTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERPAYMENTInsert];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERPAYMENTInsert]
(
	@CUSTOMERPMTID int = NULL OUTPUT, 
	@CUSTID int = NULL, 
	@PAYMENTDATE datetime = NULL, 
	@PAYMENTAMOUNT money = NULL, 
	@REMITTANCEADVICE varchar(50) = NULL, 
	@BALANCE money = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [CUSTOMERPAYMENT]
	(
		[CUSTID], 
		[PAYMENTDATE], 
		[PAYMENTAMOUNT], 
		[REMITTANCEADVICE], 
		[BALANCE]
	)
	
	VALUES
	(
		@CUSTID, 
		@PAYMENTDATE, 
		@PAYMENTAMOUNT, 
		@REMITTANCEADVICE, 
		@BALANCE
	)

	SET @Err = @@Error

		
	SELECT @CUSTOMERPMTID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERPAYMENTDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERPAYMENTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERPAYMENTDelete];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERPAYMENTDelete]
(
	@CUSTOMERPMTID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[CUSTOMERPAYMENT]
	WHERE
		([CUSTOMERPMTID] = @CUSTOMERPMTID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERPAYMENTDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_EMPLOYEELoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_EMPLOYEELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_EMPLOYEELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_EMPLOYEELoadByPrimaryKey]
(
	@EmployeeID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[EmployeeID], 
		[EmployeeName], 
		[IsActive]
	FROM [dbo].[EMPLOYEE]
	WHERE
		([EmployeeID] = @EmployeeID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_EMPLOYEELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_EMPLOYEELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_EMPLOYEELoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_EMPLOYEELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_EMPLOYEELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_EMPLOYEELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[EmployeeID], 
		[EmployeeName], 
		[IsActive]
	FROM [dbo].[EMPLOYEE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_EMPLOYEELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_EMPLOYEELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_EMPLOYEEUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_EMPLOYEEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_EMPLOYEEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_EMPLOYEEUpdate]
(
	@EmployeeID int, 
	@EmployeeName varchar(50), 
	@IsActive bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [EMPLOYEE]
	SET
		[EmployeeName] = @EmployeeName, 
		[IsActive] = @IsActive
	WHERE
		([EmployeeID] = @EmployeeID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_EMPLOYEEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_EMPLOYEEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_EMPLOYEEInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_EMPLOYEEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_EMPLOYEEInsert];
GO

CREATE PROCEDURE [dbo].[proc_EMPLOYEEInsert]
(
	@EmployeeID int = NULL OUTPUT, 
	@EmployeeName varchar(50), 
	@IsActive bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [EMPLOYEE]
	(
		[EmployeeName], 
		[IsActive]
	)
	
	VALUES
	(
		@EmployeeName, 
		@IsActive
	)

	SET @Err = @@Error

		
	SELECT @EmployeeID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_EMPLOYEEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_EMPLOYEEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_EMPLOYEEDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_EMPLOYEEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_EMPLOYEEDelete];
GO

CREATE PROCEDURE [dbo].[proc_EMPLOYEEDelete]
(
	@EmployeeID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[EMPLOYEE]
	WHERE
		([EmployeeID] = @EmployeeID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_EMPLOYEEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_EMPLOYEEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_HAZMATSYMBOLLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_HAZMATSYMBOLLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_HAZMATSYMBOLLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_HAZMATSYMBOLLoadByPrimaryKey]
(
	@HazMatID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[HazMatID], 
		[SymbolDesc], 
		[ProductLabel], 
		[ImageFileName], 
		[Precautions], 
		[Warning], 
		[Handling]
	FROM [dbo].[HAZMATSYMBOL]
	WHERE
		([HazMatID] = @HazMatID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_HAZMATSYMBOLLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_HAZMATSYMBOLLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_HAZMATSYMBOLLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_HAZMATSYMBOLLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_HAZMATSYMBOLLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_HAZMATSYMBOLLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[HazMatID], 
		[SymbolDesc], 
		[ProductLabel], 
		[ImageFileName], 
		[Precautions], 
		[Warning], 
		[Handling]
	FROM [dbo].[HAZMATSYMBOL]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_HAZMATSYMBOLLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_HAZMATSYMBOLLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_HAZMATSYMBOLUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_HAZMATSYMBOLUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_HAZMATSYMBOLUpdate];
GO

CREATE PROCEDURE [dbo].[proc_HAZMATSYMBOLUpdate]
(
	@HazMatID int, 
	@SymbolDesc varchar(50) = NULL, 
	@ProductLabel varchar(100) = NULL, 
	@ImageFileName varchar(100) = NULL, 
	@Precautions varchar(MAX) = NULL, 
	@Warning varchar(MAX) = NULL, 
	@Handling varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [HAZMATSYMBOL]
	SET
		[SymbolDesc] = @SymbolDesc, 
		[ProductLabel] = @ProductLabel, 
		[ImageFileName] = @ImageFileName, 
		[Precautions] = @Precautions, 
		[Warning] = @Warning, 
		[Handling] = @Handling
	WHERE
		([HazMatID] = @HazMatID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_HAZMATSYMBOLUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_HAZMATSYMBOLUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_HAZMATSYMBOLInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_HAZMATSYMBOLInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_HAZMATSYMBOLInsert];
GO

CREATE PROCEDURE [dbo].[proc_HAZMATSYMBOLInsert]
(
	@HazMatID int, 
	@SymbolDesc varchar(50) = NULL, 
	@ProductLabel varchar(100) = NULL, 
	@ImageFileName varchar(100) = NULL, 
	@Precautions varchar(MAX) = NULL, 
	@Warning varchar(MAX) = NULL, 
	@Handling varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [HAZMATSYMBOL]
	(
		[HazMatID], 
		[SymbolDesc], 
		[ProductLabel], 
		[ImageFileName], 
		[Precautions], 
		[Warning], 
		[Handling]
	)
	
	VALUES
	(
		@HazMatID, 
		@SymbolDesc, 
		@ProductLabel, 
		@ImageFileName, 
		@Precautions, 
		@Warning, 
		@Handling
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_HAZMATSYMBOLInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_HAZMATSYMBOLInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_HAZMATSYMBOLDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_HAZMATSYMBOLDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_HAZMATSYMBOLDelete];
GO

CREATE PROCEDURE [dbo].[proc_HAZMATSYMBOLDelete]
(
	@HazMatID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[HAZMATSYMBOL]
	WHERE
		([HazMatID] = @HazMatID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_HAZMATSYMBOLDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_HAZMATSYMBOLDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_INVENTORYSTATUSLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVENTORYSTATUSLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVENTORYSTATUSLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_INVENTORYSTATUSLoadByPrimaryKey]
(
	@INVENTORYSTATUS varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVENTORYSTATUS]
	FROM [dbo].[INVENTORYSTATUS]
	WHERE
		([INVENTORYSTATUS] = @INVENTORYSTATUS)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVENTORYSTATUSLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVENTORYSTATUSLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVENTORYSTATUSLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVENTORYSTATUSLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVENTORYSTATUSLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_INVENTORYSTATUSLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVENTORYSTATUS]
	FROM [dbo].[INVENTORYSTATUS]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVENTORYSTATUSLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVENTORYSTATUSLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVENTORYSTATUSUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVENTORYSTATUSUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVENTORYSTATUSInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVENTORYSTATUSInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVENTORYSTATUSInsert];
GO

CREATE PROCEDURE [dbo].[proc_INVENTORYSTATUSInsert]
(
	@INVENTORYSTATUS varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [INVENTORYSTATUS]
	(
		[INVENTORYSTATUS]
	)
	
	VALUES
	(
		@INVENTORYSTATUS
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVENTORYSTATUSInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVENTORYSTATUSInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVENTORYSTATUSDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVENTORYSTATUSDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVENTORYSTATUSDelete];
GO

CREATE PROCEDURE [dbo].[proc_INVENTORYSTATUSDelete]
(
	@INVENTORYSTATUS varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[INVENTORYSTATUS]
	WHERE
		([INVENTORYSTATUS] = @INVENTORYSTATUS)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVENTORYSTATUSDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVENTORYSTATUSDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_INVITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_INVITEMLoadByPrimaryKey]
(
	@INVITEMNUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVITEMNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[CONTAINER], 
		[UNITCOST], 
		[UOM], 
		[UNITSREMAINING], 
		[LOTNUMBER], 
		[NOTE], 
		[ITEMSTATUS], 
		[RECEIVERNUMBER], 
		[RECEIVEDDATE], 
		[ALLOCATEDDOCUMENT], 
		[ALLOCATEDDATE], 
		[WORKORDERNUMBER], 
		[SHIPMENTNUMBER], 
		[SHIPPEDDATE], 
		[WAREHOUSENUMBER], 
		[WAREHOUSELOCATION], 
		[INVENTORYCLASS], 
		[TESTSAMPLEKEY]
	FROM [dbo].[INVITEM]
	WHERE
		([INVITEMNUMBER] = @INVITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVITEMLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_INVITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVITEMNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[CONTAINER], 
		[UNITCOST], 
		[UOM], 
		[UNITSREMAINING], 
		[LOTNUMBER], 
		[NOTE], 
		[ITEMSTATUS], 
		[RECEIVERNUMBER], 
		[RECEIVEDDATE], 
		[ALLOCATEDDOCUMENT], 
		[ALLOCATEDDATE], 
		[WORKORDERNUMBER], 
		[SHIPMENTNUMBER], 
		[SHIPPEDDATE], 
		[WAREHOUSENUMBER], 
		[WAREHOUSELOCATION], 
		[INVENTORYCLASS], 
		[TESTSAMPLEKEY]
	FROM [dbo].[INVITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVITEMUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_INVITEMUpdate]
(
	@INVITEMNUMBER int, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITCOST money = NULL, 
	@UOM varchar(50) = NULL, 
	@UNITSREMAINING float = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@NOTE varchar(MAX) = NULL, 
	@ITEMSTATUS varchar(50) = NULL, 
	@RECEIVERNUMBER int = NULL, 
	@RECEIVEDDATE datetime = NULL, 
	@ALLOCATEDDOCUMENT varchar(50) = NULL, 
	@ALLOCATEDDATE datetime = NULL, 
	@WORKORDERNUMBER int = NULL, 
	@SHIPMENTNUMBER int = NULL, 
	@SHIPPEDDATE datetime = NULL, 
	@WAREHOUSENUMBER int = NULL, 
	@WAREHOUSELOCATION varchar(50) = NULL, 
	@INVENTORYCLASS int = NULL, 
	@TESTSAMPLEKEY int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [INVITEM]
	SET
		[PRODUCTID] = @PRODUCTID, 
		[PRODUCTDESC] = @PRODUCTDESC, 
		[CONTAINER] = @CONTAINER, 
		[UNITCOST] = @UNITCOST, 
		[UOM] = @UOM, 
		[UNITSREMAINING] = @UNITSREMAINING, 
		[LOTNUMBER] = @LOTNUMBER, 
		[NOTE] = @NOTE, 
		[ITEMSTATUS] = @ITEMSTATUS, 
		[RECEIVERNUMBER] = @RECEIVERNUMBER, 
		[RECEIVEDDATE] = @RECEIVEDDATE, 
		[ALLOCATEDDOCUMENT] = @ALLOCATEDDOCUMENT, 
		[ALLOCATEDDATE] = @ALLOCATEDDATE, 
		[WORKORDERNUMBER] = @WORKORDERNUMBER, 
		[SHIPMENTNUMBER] = @SHIPMENTNUMBER, 
		[SHIPPEDDATE] = @SHIPPEDDATE, 
		[WAREHOUSENUMBER] = @WAREHOUSENUMBER, 
		[WAREHOUSELOCATION] = @WAREHOUSELOCATION, 
		[INVENTORYCLASS] = @INVENTORYCLASS, 
		[TESTSAMPLEKEY] = @TESTSAMPLEKEY
	WHERE
		([INVITEMNUMBER] = @INVITEMNUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVITEMInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_INVITEMInsert]
(
	@INVITEMNUMBER int = NULL OUTPUT, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITCOST money = NULL, 
	@UOM varchar(50) = NULL, 
	@UNITSREMAINING float = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@NOTE varchar(MAX) = NULL, 
	@ITEMSTATUS varchar(50) = NULL, 
	@RECEIVERNUMBER int = NULL, 
	@RECEIVEDDATE datetime = NULL, 
	@ALLOCATEDDOCUMENT varchar(50) = NULL, 
	@ALLOCATEDDATE datetime = NULL, 
	@WORKORDERNUMBER int = NULL, 
	@SHIPMENTNUMBER int = NULL, 
	@SHIPPEDDATE datetime = NULL, 
	@WAREHOUSENUMBER int = NULL, 
	@WAREHOUSELOCATION varchar(50) = NULL, 
	@INVENTORYCLASS int = NULL, 
	@TESTSAMPLEKEY int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [INVITEM]
	(
		[PRODUCTID], 
		[PRODUCTDESC], 
		[CONTAINER], 
		[UNITCOST], 
		[UOM], 
		[UNITSREMAINING], 
		[LOTNUMBER], 
		[NOTE], 
		[ITEMSTATUS], 
		[RECEIVERNUMBER], 
		[RECEIVEDDATE], 
		[ALLOCATEDDOCUMENT], 
		[ALLOCATEDDATE], 
		[WORKORDERNUMBER], 
		[SHIPMENTNUMBER], 
		[SHIPPEDDATE], 
		[WAREHOUSENUMBER], 
		[WAREHOUSELOCATION], 
		[INVENTORYCLASS], 
		[TESTSAMPLEKEY]
	)
	
	VALUES
	(
		@PRODUCTID, 
		@PRODUCTDESC, 
		@CONTAINER, 
		@UNITCOST, 
		@UOM, 
		@UNITSREMAINING, 
		@LOTNUMBER, 
		@NOTE, 
		@ITEMSTATUS, 
		@RECEIVERNUMBER, 
		@RECEIVEDDATE, 
		@ALLOCATEDDOCUMENT, 
		@ALLOCATEDDATE, 
		@WORKORDERNUMBER, 
		@SHIPMENTNUMBER, 
		@SHIPPEDDATE, 
		@WAREHOUSENUMBER, 
		@WAREHOUSELOCATION, 
		@INVENTORYCLASS, 
		@TESTSAMPLEKEY
	)

	SET @Err = @@Error

		
	SELECT @INVITEMNUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVITEMDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_INVITEMDelete]
(
	@INVITEMNUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[INVITEM]
	WHERE
		([INVITEMNUMBER] = @INVITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVITEMDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_INVOICELoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_INVOICELoadByPrimaryKey]
(
	@INVOICENUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVOICENUMBER], 
		[INVOICEDATE], 
		[SHIPMENTNUMBER], 
		[SHIPMENTDATE], 
		[CUSTID], 
		[BILLADDRESS1], 
		[BILLADDRESS2], 
		[BILLCITY], 
		[BILLSTATEPROV], 
		[BILLPOSTALCODE], 
		[BILLCOUNTRY], 
		[BILLPHONE], 
		[BILLFAX], 
		[BILLCONTACT], 
		[SHIPADDRESS1], 
		[SHIPADDRESS2], 
		[SHIPCITY], 
		[SHIPSTATEPROV], 
		[SHIPPOSTALCODE], 
		[SHIPCOUNTRY], 
		[SHIPCONTACT], 
		[FREIGHTCARRIER], 
		[FOB], 
		[CUSTOMERPO], 
		[ORDERTERMS], 
		[DELIVERYDATE], 
		[SHIPPEDDATE], 
		[SUBTOTAL], 
		[SALESTAX], 
		[TOTAL], 
		[INVOICESTATUS], 
		[INVNUMVIEW], 
		[LOGISTICSID], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[CREATEDBY], 
		[CREATEDTIME]
	FROM [dbo].[INVOICE]
	WHERE
		([INVOICENUMBER] = @INVOICENUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICELoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_INVOICELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVOICENUMBER], 
		[INVOICEDATE], 
		[SHIPMENTNUMBER], 
		[SHIPMENTDATE], 
		[CUSTID], 
		[BILLADDRESS1], 
		[BILLADDRESS2], 
		[BILLCITY], 
		[BILLSTATEPROV], 
		[BILLPOSTALCODE], 
		[BILLCOUNTRY], 
		[BILLPHONE], 
		[BILLFAX], 
		[BILLCONTACT], 
		[SHIPADDRESS1], 
		[SHIPADDRESS2], 
		[SHIPCITY], 
		[SHIPSTATEPROV], 
		[SHIPPOSTALCODE], 
		[SHIPCOUNTRY], 
		[SHIPCONTACT], 
		[FREIGHTCARRIER], 
		[FOB], 
		[CUSTOMERPO], 
		[ORDERTERMS], 
		[DELIVERYDATE], 
		[SHIPPEDDATE], 
		[SUBTOTAL], 
		[SALESTAX], 
		[TOTAL], 
		[INVOICESTATUS], 
		[INVNUMVIEW], 
		[LOGISTICSID], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[CREATEDBY], 
		[CREATEDTIME]
	FROM [dbo].[INVOICE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEUpdate]
(
	@INVOICENUMBER int, 
	@INVOICEDATE datetime = NULL, 
	@SHIPMENTNUMBER int = NULL, 
	@SHIPMENTDATE datetime = NULL, 
	@CUSTID int = NULL, 
	@BILLADDRESS1 varchar(50) = NULL, 
	@BILLADDRESS2 varchar(50) = NULL, 
	@BILLCITY varchar(50) = NULL, 
	@BILLSTATEPROV varchar(50) = NULL, 
	@BILLPOSTALCODE varchar(24) = NULL, 
	@BILLCOUNTRY varchar(50) = NULL, 
	@BILLPHONE varchar(50) = NULL, 
	@BILLFAX varchar(50) = NULL, 
	@BILLCONTACT varchar(50) = NULL, 
	@SHIPADDRESS1 varchar(50) = NULL, 
	@SHIPADDRESS2 varchar(50) = NULL, 
	@SHIPCITY varchar(50) = NULL, 
	@SHIPSTATEPROV varchar(50) = NULL, 
	@SHIPPOSTALCODE varchar(24) = NULL, 
	@SHIPCOUNTRY varchar(50) = NULL, 
	@SHIPCONTACT varchar(50) = NULL, 
	@FREIGHTCARRIER varchar(50) = NULL, 
	@FOB varchar(24) = NULL, 
	@CUSTOMERPO varchar(50) = NULL, 
	@ORDERTERMS varchar(50) = NULL, 
	@DELIVERYDATE datetime = NULL, 
	@SHIPPEDDATE datetime = NULL, 
	@SUBTOTAL money = NULL, 
	@SALESTAX money = NULL, 
	@TOTAL money = NULL, 
	@INVOICESTATUS varchar(50) = NULL, 
	@INVNUMVIEW int = NULL, 
	@LOGISTICSID int = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [INVOICE]
	SET
		[INVOICEDATE] = @INVOICEDATE, 
		[SHIPMENTNUMBER] = @SHIPMENTNUMBER, 
		[SHIPMENTDATE] = @SHIPMENTDATE, 
		[CUSTID] = @CUSTID, 
		[BILLADDRESS1] = @BILLADDRESS1, 
		[BILLADDRESS2] = @BILLADDRESS2, 
		[BILLCITY] = @BILLCITY, 
		[BILLSTATEPROV] = @BILLSTATEPROV, 
		[BILLPOSTALCODE] = @BILLPOSTALCODE, 
		[BILLCOUNTRY] = @BILLCOUNTRY, 
		[BILLPHONE] = @BILLPHONE, 
		[BILLFAX] = @BILLFAX, 
		[BILLCONTACT] = @BILLCONTACT, 
		[SHIPADDRESS1] = @SHIPADDRESS1, 
		[SHIPADDRESS2] = @SHIPADDRESS2, 
		[SHIPCITY] = @SHIPCITY, 
		[SHIPSTATEPROV] = @SHIPSTATEPROV, 
		[SHIPPOSTALCODE] = @SHIPPOSTALCODE, 
		[SHIPCOUNTRY] = @SHIPCOUNTRY, 
		[SHIPCONTACT] = @SHIPCONTACT, 
		[FREIGHTCARRIER] = @FREIGHTCARRIER, 
		[FOB] = @FOB, 
		[CUSTOMERPO] = @CUSTOMERPO, 
		[ORDERTERMS] = @ORDERTERMS, 
		[DELIVERYDATE] = @DELIVERYDATE, 
		[SHIPPEDDATE] = @SHIPPEDDATE, 
		[SUBTOTAL] = @SUBTOTAL, 
		[SALESTAX] = @SALESTAX, 
		[TOTAL] = @TOTAL, 
		[INVOICESTATUS] = @INVOICESTATUS, 
		[INVNUMVIEW] = @INVNUMVIEW, 
		[LOGISTICSID] = @LOGISTICSID, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME
	WHERE
		([INVOICENUMBER] = @INVOICENUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEInsert];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEInsert]
(
	@INVOICENUMBER int = NULL OUTPUT, 
	@INVOICEDATE datetime = NULL, 
	@SHIPMENTNUMBER int = NULL, 
	@SHIPMENTDATE datetime = NULL, 
	@CUSTID int = NULL, 
	@BILLADDRESS1 varchar(50) = NULL, 
	@BILLADDRESS2 varchar(50) = NULL, 
	@BILLCITY varchar(50) = NULL, 
	@BILLSTATEPROV varchar(50) = NULL, 
	@BILLPOSTALCODE varchar(24) = NULL, 
	@BILLCOUNTRY varchar(50) = NULL, 
	@BILLPHONE varchar(50) = NULL, 
	@BILLFAX varchar(50) = NULL, 
	@BILLCONTACT varchar(50) = NULL, 
	@SHIPADDRESS1 varchar(50) = NULL, 
	@SHIPADDRESS2 varchar(50) = NULL, 
	@SHIPCITY varchar(50) = NULL, 
	@SHIPSTATEPROV varchar(50) = NULL, 
	@SHIPPOSTALCODE varchar(24) = NULL, 
	@SHIPCOUNTRY varchar(50) = NULL, 
	@SHIPCONTACT varchar(50) = NULL, 
	@FREIGHTCARRIER varchar(50) = NULL, 
	@FOB varchar(24) = NULL, 
	@CUSTOMERPO varchar(50) = NULL, 
	@ORDERTERMS varchar(50) = NULL, 
	@DELIVERYDATE datetime = NULL, 
	@SHIPPEDDATE datetime = NULL, 
	@SUBTOTAL money = NULL, 
	@SALESTAX money = NULL, 
	@TOTAL money = NULL, 
	@INVOICESTATUS varchar(50) = NULL, 
	@INVNUMVIEW int = NULL, 
	@LOGISTICSID int = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [INVOICE]
	(
		[INVOICEDATE], 
		[SHIPMENTNUMBER], 
		[SHIPMENTDATE], 
		[CUSTID], 
		[BILLADDRESS1], 
		[BILLADDRESS2], 
		[BILLCITY], 
		[BILLSTATEPROV], 
		[BILLPOSTALCODE], 
		[BILLCOUNTRY], 
		[BILLPHONE], 
		[BILLFAX], 
		[BILLCONTACT], 
		[SHIPADDRESS1], 
		[SHIPADDRESS2], 
		[SHIPCITY], 
		[SHIPSTATEPROV], 
		[SHIPPOSTALCODE], 
		[SHIPCOUNTRY], 
		[SHIPCONTACT], 
		[FREIGHTCARRIER], 
		[FOB], 
		[CUSTOMERPO], 
		[ORDERTERMS], 
		[DELIVERYDATE], 
		[SHIPPEDDATE], 
		[SUBTOTAL], 
		[SALESTAX], 
		[TOTAL], 
		[INVOICESTATUS], 
		[INVNUMVIEW], 
		[LOGISTICSID], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[CREATEDBY], 
		[CREATEDTIME]
	)
	
	VALUES
	(
		@INVOICEDATE, 
		@SHIPMENTNUMBER, 
		@SHIPMENTDATE, 
		@CUSTID, 
		@BILLADDRESS1, 
		@BILLADDRESS2, 
		@BILLCITY, 
		@BILLSTATEPROV, 
		@BILLPOSTALCODE, 
		@BILLCOUNTRY, 
		@BILLPHONE, 
		@BILLFAX, 
		@BILLCONTACT, 
		@SHIPADDRESS1, 
		@SHIPADDRESS2, 
		@SHIPCITY, 
		@SHIPSTATEPROV, 
		@SHIPPOSTALCODE, 
		@SHIPCOUNTRY, 
		@SHIPCONTACT, 
		@FREIGHTCARRIER, 
		@FOB, 
		@CUSTOMERPO, 
		@ORDERTERMS, 
		@DELIVERYDATE, 
		@SHIPPEDDATE, 
		@SUBTOTAL, 
		@SALESTAX, 
		@TOTAL, 
		@INVOICESTATUS, 
		@INVNUMVIEW, 
		@LOGISTICSID, 
		@MODIFYBY, 
		@MODIFYTIME, 
		@CREATEDBY, 
		@CREATEDTIME
	)

	SET @Err = @@Error

		
	SELECT @INVOICENUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEDelete];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEDelete]
(
	@INVOICENUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[INVOICE]
	WHERE
		([INVOICENUMBER] = @INVOICENUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_INVOICEITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEITEMLoadByPrimaryKey]
(
	@INVOICEITEMNUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVOICEITEMNUMBER], 
		[INVOICENUMBER], 
		[SHIPMENTDETAILID], 
		[INVITEMNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QUANTITY], 
		[CONTAINER], 
		[UNITS], 
		[UOM], 
		[ITEMPRICE], 
		[EXTPRICE], 
		[UNITCOST], 
		[EXTCOST], 
		[GROSSPROFIT], 
		[TAXABLE], 
		[WORKORDERITEMNUMBER], 
		[UNITORCONTAINER]
	FROM [dbo].[INVOICEITEM]
	WHERE
		([INVOICEITEMNUMBER] = @INVOICEITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEITEMLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVOICEITEMNUMBER], 
		[INVOICENUMBER], 
		[SHIPMENTDETAILID], 
		[INVITEMNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QUANTITY], 
		[CONTAINER], 
		[UNITS], 
		[UOM], 
		[ITEMPRICE], 
		[EXTPRICE], 
		[UNITCOST], 
		[EXTCOST], 
		[GROSSPROFIT], 
		[TAXABLE], 
		[WORKORDERITEMNUMBER], 
		[UNITORCONTAINER]
	FROM [dbo].[INVOICEITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEITEMUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEITEMUpdate]
(
	@INVOICEITEMNUMBER int, 
	@INVOICENUMBER int = NULL, 
	@SHIPMENTDETAILID int = NULL, 
	@INVITEMNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QUANTITY numeric(18,4) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITS int = NULL, 
	@UOM varchar(50) = NULL, 
	@ITEMPRICE money = NULL, 
	@EXTPRICE money = NULL, 
	@UNITCOST money = NULL, 
	@EXTCOST money = NULL, 
	@GROSSPROFIT money = NULL, 
	@TAXABLE bit = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@UNITORCONTAINER varchar(1) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [INVOICEITEM]
	SET
		[INVOICENUMBER] = @INVOICENUMBER, 
		[SHIPMENTDETAILID] = @SHIPMENTDETAILID, 
		[INVITEMNUMBER] = @INVITEMNUMBER, 
		[PRODUCTID] = @PRODUCTID, 
		[PRODUCTDESC] = @PRODUCTDESC, 
		[QUANTITY] = @QUANTITY, 
		[CONTAINER] = @CONTAINER, 
		[UNITS] = @UNITS, 
		[UOM] = @UOM, 
		[ITEMPRICE] = @ITEMPRICE, 
		[EXTPRICE] = @EXTPRICE, 
		[UNITCOST] = @UNITCOST, 
		[EXTCOST] = @EXTCOST, 
		[GROSSPROFIT] = @GROSSPROFIT, 
		[TAXABLE] = @TAXABLE, 
		[WORKORDERITEMNUMBER] = @WORKORDERITEMNUMBER, 
		[UNITORCONTAINER] = @UNITORCONTAINER
	WHERE
		([INVOICEITEMNUMBER] = @INVOICEITEMNUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEITEMInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEITEMInsert]
(
	@INVOICEITEMNUMBER int = NULL OUTPUT, 
	@INVOICENUMBER int = NULL, 
	@SHIPMENTDETAILID int = NULL, 
	@INVITEMNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QUANTITY numeric(18,4) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITS int = NULL, 
	@UOM varchar(50) = NULL, 
	@ITEMPRICE money = NULL, 
	@EXTPRICE money = NULL, 
	@UNITCOST money = NULL, 
	@EXTCOST money = NULL, 
	@GROSSPROFIT money = NULL, 
	@TAXABLE bit = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@UNITORCONTAINER varchar(1) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [INVOICEITEM]
	(
		[INVOICENUMBER], 
		[SHIPMENTDETAILID], 
		[INVITEMNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QUANTITY], 
		[CONTAINER], 
		[UNITS], 
		[UOM], 
		[ITEMPRICE], 
		[EXTPRICE], 
		[UNITCOST], 
		[EXTCOST], 
		[GROSSPROFIT], 
		[TAXABLE], 
		[WORKORDERITEMNUMBER], 
		[UNITORCONTAINER]
	)
	
	VALUES
	(
		@INVOICENUMBER, 
		@SHIPMENTDETAILID, 
		@INVITEMNUMBER, 
		@PRODUCTID, 
		@PRODUCTDESC, 
		@QUANTITY, 
		@CONTAINER, 
		@UNITS, 
		@UOM, 
		@ITEMPRICE, 
		@EXTPRICE, 
		@UNITCOST, 
		@EXTCOST, 
		@GROSSPROFIT, 
		@TAXABLE, 
		@WORKORDERITEMNUMBER, 
		@UNITORCONTAINER
	)

	SET @Err = @@Error

		
	SELECT @INVOICEITEMNUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEITEMDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEITEMDelete]
(
	@INVOICEITEMNUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[INVOICEITEM]
	WHERE
		([INVOICEITEMNUMBER] = @INVOICEITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEITEMDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_INVOICEPAYMENTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEPAYMENTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEPAYMENTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEPAYMENTLoadByPrimaryKey]
(
	@INVOICEPMTID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVOICEPMTID], 
		[CUSTOMERPMTID], 
		[INVOICENUMBER], 
		[INVOICEPMTAMOUNT], 
		[INVOICEDISCOUNT], 
		[DISCOUNTREASON]
	FROM [dbo].[INVOICEPAYMENT]
	WHERE
		([INVOICEPMTID] = @INVOICEPMTID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEPAYMENTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEPAYMENTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEPAYMENTLoadAll] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEPAYMENTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEPAYMENTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEPAYMENTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[INVOICEPMTID], 
		[CUSTOMERPMTID], 
		[INVOICENUMBER], 
		[INVOICEPMTAMOUNT], 
		[INVOICEDISCOUNT], 
		[DISCOUNTREASON]
	FROM [dbo].[INVOICEPAYMENT]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEPAYMENTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEPAYMENTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEPAYMENTUpdate] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEPAYMENTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEPAYMENTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEPAYMENTUpdate]
(
	@INVOICEPMTID int, 
	@CUSTOMERPMTID int = NULL, 
	@INVOICENUMBER int = NULL, 
	@INVOICEPMTAMOUNT money = NULL, 
	@INVOICEDISCOUNT money = NULL, 
	@DISCOUNTREASON varchar(100) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [INVOICEPAYMENT]
	SET
		[CUSTOMERPMTID] = @CUSTOMERPMTID, 
		[INVOICENUMBER] = @INVOICENUMBER, 
		[INVOICEPMTAMOUNT] = @INVOICEPMTAMOUNT, 
		[INVOICEDISCOUNT] = @INVOICEDISCOUNT, 
		[DISCOUNTREASON] = @DISCOUNTREASON
	WHERE
		([INVOICEPMTID] = @INVOICEPMTID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEPAYMENTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEPAYMENTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEPAYMENTInsert] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEPAYMENTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEPAYMENTInsert];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEPAYMENTInsert]
(
	@INVOICEPMTID int = NULL OUTPUT, 
	@CUSTOMERPMTID int = NULL, 
	@INVOICENUMBER int = NULL, 
	@INVOICEPMTAMOUNT money = NULL, 
	@INVOICEDISCOUNT money = NULL, 
	@DISCOUNTREASON varchar(100) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [INVOICEPAYMENT]
	(
		[CUSTOMERPMTID], 
		[INVOICENUMBER], 
		[INVOICEPMTAMOUNT], 
		[INVOICEDISCOUNT], 
		[DISCOUNTREASON]
	)
	
	VALUES
	(
		@CUSTOMERPMTID, 
		@INVOICENUMBER, 
		@INVOICEPMTAMOUNT, 
		@INVOICEDISCOUNT, 
		@DISCOUNTREASON
	)

	SET @Err = @@Error

		
	SELECT @INVOICEPMTID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEPAYMENTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEPAYMENTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_INVOICEPAYMENTDelete] Script Date: 12/10/2013 4:01:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_INVOICEPAYMENTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_INVOICEPAYMENTDelete];
GO

CREATE PROCEDURE [dbo].[proc_INVOICEPAYMENTDelete]
(
	@INVOICEPMTID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[INVOICEPAYMENT]
	WHERE
		([INVOICEPMTID] = @INVOICEPMTID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_INVOICEPAYMENTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_INVOICEPAYMENTDelete Error on Creation'
GO 


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


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_APPEARANCELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_APPEARANCELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_APPEARANCELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_APPEARANCELoadByPrimaryKey]
(
	@RECIID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECIID], 
		[APPEARANCE]
	FROM [dbo].[LIST_APPEARANCE]
	WHERE
		([RECIID] = @RECIID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_APPEARANCELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_APPEARANCELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_APPEARANCELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_APPEARANCELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_APPEARANCELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_APPEARANCELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECIID], 
		[APPEARANCE]
	FROM [dbo].[LIST_APPEARANCE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_APPEARANCELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_APPEARANCELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_APPEARANCEUpdate] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_APPEARANCEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_APPEARANCEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_APPEARANCEUpdate]
(
	@RECIID int, 
	@APPEARANCE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_APPEARANCE]
	SET
		[APPEARANCE] = @APPEARANCE
	WHERE
		([RECIID] = @RECIID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_APPEARANCEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_APPEARANCEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_APPEARANCEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_APPEARANCEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_APPEARANCEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_APPEARANCEInsert]
(
	@RECIID int = NULL OUTPUT, 
	@APPEARANCE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_APPEARANCE]
	(
		[APPEARANCE]
	)
	
	VALUES
	(
		@APPEARANCE
	)

	SET @Err = @@Error

		
	SELECT @RECIID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_APPEARANCEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_APPEARANCEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_APPEARANCEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_APPEARANCEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_APPEARANCEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_APPEARANCEDelete]
(
	@RECIID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_APPEARANCE]
	WHERE
		([RECIID] = @RECIID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_APPEARANCEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_APPEARANCEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMAPPEARANCELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMAPPEARANCELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCELoadByPrimaryKey]
(
	@APPEARANCE varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APPEARANCE]
	FROM [dbo].[LIST_CHEMAPPEARANCE]
	WHERE
		([APPEARANCE] = @APPEARANCE)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMAPPEARANCELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMAPPEARANCELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APPEARANCE]
	FROM [dbo].[LIST_CHEMAPPEARANCE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCELoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMAPPEARANCEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMAPPEARANCEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCEInsert]
(
	@APPEARANCE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_CHEMAPPEARANCE]
	(
		[APPEARANCE]
	)
	
	VALUES
	(
		@APPEARANCE
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMAPPEARANCEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMAPPEARANCEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMAPPEARANCEDelete]
(
	@APPEARANCE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_CHEMAPPEARANCE]
	WHERE
		([APPEARANCE] = @APPEARANCE)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMAPPEARANCEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMCOLORLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMCOLORLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMCOLORLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMCOLORLoadByPrimaryKey]
(
	@COLOR varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COLOR]
	FROM [dbo].[LIST_CHEMCOLOR]
	WHERE
		([COLOR] = @COLOR)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMCOLORLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMCOLORLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMCOLORLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMCOLORLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMCOLORLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMCOLORLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COLOR]
	FROM [dbo].[LIST_CHEMCOLOR]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMCOLORLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMCOLORLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMCOLORUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMCOLORUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMCOLORInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMCOLORInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMCOLORInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMCOLORInsert]
(
	@COLOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_CHEMCOLOR]
	(
		[COLOR]
	)
	
	VALUES
	(
		@COLOR
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMCOLORInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMCOLORInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMCOLORDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMCOLORDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMCOLORDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMCOLORDelete]
(
	@COLOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_CHEMCOLOR]
	WHERE
		([COLOR] = @COLOR)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMCOLORDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMCOLORDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMICALSTATELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMICALSTATELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMICALSTATELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMICALSTATELoadByPrimaryKey]
(
	@CHEMICALSTATE varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMICALSTATE]
	FROM [dbo].[LIST_CHEMICALSTATE]
	WHERE
		([CHEMICALSTATE] = @CHEMICALSTATE)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMICALSTATELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMICALSTATELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMICALSTATELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMICALSTATELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMICALSTATE]
	FROM [dbo].[LIST_CHEMICALSTATE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATELoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMICALSTATEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMICALSTATEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMICALSTATEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMICALSTATEInsert]
(
	@CHEMICALSTATE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_CHEMICALSTATE]
	(
		[CHEMICALSTATE]
	)
	
	VALUES
	(
		@CHEMICALSTATE
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMICALSTATEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMICALSTATEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMICALSTATEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMICALSTATEDelete]
(
	@CHEMICALSTATE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_CHEMICALSTATE]
	WHERE
		([CHEMICALSTATE] = @CHEMICALSTATE)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMICALSTATEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMODORLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMODORLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMODORLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMODORLoadByPrimaryKey]
(
	@ODOR varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ODOR]
	FROM [dbo].[LIST_CHEMODOR]
	WHERE
		([ODOR] = @ODOR)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMODORLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMODORLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMODORLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMODORLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMODORLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMODORLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ODOR]
	FROM [dbo].[LIST_CHEMODOR]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMODORLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMODORLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMODORUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMODORUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMODORInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMODORInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMODORInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMODORInsert]
(
	@ODOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_CHEMODOR]
	(
		[ODOR]
	)
	
	VALUES
	(
		@ODOR
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMODORInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMODORInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMODORDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMODORDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMODORDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMODORDelete]
(
	@ODOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_CHEMODOR]
	WHERE
		([ODOR] = @ODOR)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMODORDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMODORDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMSTATELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMSTATELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMSTATELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMSTATELoadByPrimaryKey]
(
	@CHEMICALSTATE varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMICALSTATE]
	FROM [dbo].[LIST_CHEMSTATE]
	WHERE
		([CHEMICALSTATE] = @CHEMICALSTATE)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMSTATELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMSTATELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMSTATELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMSTATELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMSTATELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMSTATELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMICALSTATE]
	FROM [dbo].[LIST_CHEMSTATE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMSTATELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMSTATELoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMSTATEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMSTATEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMSTATEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMSTATEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMSTATEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMSTATEInsert]
(
	@CHEMICALSTATE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_CHEMSTATE]
	(
		[CHEMICALSTATE]
	)
	
	VALUES
	(
		@CHEMICALSTATE
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMSTATEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMSTATEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_CHEMSTATEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_CHEMSTATEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_CHEMSTATEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_CHEMSTATEDelete]
(
	@CHEMICALSTATE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_CHEMSTATE]
	WHERE
		([CHEMICALSTATE] = @CHEMICALSTATE)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_CHEMSTATEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_CHEMSTATEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_COLORLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COLORLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COLORLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COLORLoadByPrimaryKey]
(
	@COLOR varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COLOR]
	FROM [dbo].[LIST_COLOR]
	WHERE
		([COLOR] = @COLOR)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COLORLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COLORLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COLORLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COLORLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COLORLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COLORLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COLOR]
	FROM [dbo].[LIST_COLOR]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COLORLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COLORLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COLORUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COLORUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COLORInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COLORInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COLORInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COLORInsert]
(
	@COLOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_COLOR]
	(
		[COLOR]
	)
	
	VALUES
	(
		@COLOR
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COLORInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COLORInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COLORDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COLORDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COLORDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COLORDelete]
(
	@COLOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_COLOR]
	WHERE
		([COLOR] = @COLOR)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COLORDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COLORDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONCATEGORYLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONCATEGORYLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYLoadByPrimaryKey]
(
	@COMMISSIONCATEGORY varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONCATEGORY]
	FROM [dbo].[LIST_COMMISSIONCATEGORY]
	WHERE
		([COMMISSIONCATEGORY] = @COMMISSIONCATEGORY)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONCATEGORYLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONCATEGORYLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONCATEGORY]
	FROM [dbo].[LIST_COMMISSIONCATEGORY]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONCATEGORYInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONCATEGORYInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYInsert]
(
	@COMMISSIONCATEGORY varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_COMMISSIONCATEGORY]
	(
		[COMMISSIONCATEGORY]
	)
	
	VALUES
	(
		@COMMISSIONCATEGORY
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONCATEGORYDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONCATEGORYDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONCATEGORYDelete]
(
	@COMMISSIONCATEGORY varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_COMMISSIONCATEGORY]
	WHERE
		([COMMISSIONCATEGORY] = @COMMISSIONCATEGORY)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONCATEGORYDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONTYPELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONTYPELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPELoadByPrimaryKey]
(
	@COMMISSIONTYPE varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONTYPE]
	FROM [dbo].[LIST_COMMISSIONTYPE]
	WHERE
		([COMMISSIONTYPE] = @COMMISSIONTYPE)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONTYPELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONTYPELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COMMISSIONTYPE]
	FROM [dbo].[LIST_COMMISSIONTYPE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPELoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONTYPEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONTYPEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPEInsert]
(
	@COMMISSIONTYPE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_COMMISSIONTYPE]
	(
		[COMMISSIONTYPE]
	)
	
	VALUES
	(
		@COMMISSIONTYPE
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMMISSIONTYPEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMMISSIONTYPEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMMISSIONTYPEDelete]
(
	@COMMISSIONTYPE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_COMMISSIONTYPE]
	WHERE
		([COMMISSIONTYPE] = @COMMISSIONTYPE)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMMISSIONTYPEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_COMPSYMBOLLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMPSYMBOLLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMPSYMBOLLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMPSYMBOLLoadByPrimaryKey]
(
	@SYMBOL varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SYMBOL]
	FROM [dbo].[LIST_COMPSYMBOL]
	WHERE
		([SYMBOL] = @SYMBOL)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMPSYMBOLLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMPSYMBOLLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMPSYMBOLLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMPSYMBOLLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SYMBOL]
	FROM [dbo].[LIST_COMPSYMBOL]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMPSYMBOLInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMPSYMBOLInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMPSYMBOLInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMPSYMBOLInsert]
(
	@SYMBOL varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_COMPSYMBOL]
	(
		[SYMBOL]
	)
	
	VALUES
	(
		@SYMBOL
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_COMPSYMBOLDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_COMPSYMBOLDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_COMPSYMBOLDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_COMPSYMBOLDelete]
(
	@SYMBOL varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_COMPSYMBOL]
	WHERE
		([SYMBOL] = @SYMBOL)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_COMPSYMBOLDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_FOBLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_FOBLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_FOBLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_FOBLoadByPrimaryKey]
(
	@FOBOption varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[FOBOption]
	FROM [dbo].[LIST_FOB]
	WHERE
		([FOBOption] = @FOBOption)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_FOBLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_FOBLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_FOBLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_FOBLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_FOBLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_FOBLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[FOBOption]
	FROM [dbo].[LIST_FOB]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_FOBLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_FOBLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_FOBUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_FOBUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_FOBInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_FOBInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_FOBInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_FOBInsert]
(
	@FOBOption varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_FOB]
	(
		[FOBOption]
	)
	
	VALUES
	(
		@FOBOption
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_FOBInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_FOBInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_FOBDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_FOBDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_FOBDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_FOBDelete]
(
	@FOBOption varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_FOB]
	WHERE
		([FOBOption] = @FOBOption)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_FOBDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_FOBDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_INVENTORYCLASSLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVENTORYCLASSLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSLoadByPrimaryKey]
(
	@LookupID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LookupID], 
		[LookupGroup], 
		[LookupValue], 
		[LookupDesc]
	FROM [dbo].[LIST_INVENTORYCLASS]
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVENTORYCLASSLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVENTORYCLASSLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LookupID], 
		[LookupGroup], 
		[LookupValue], 
		[LookupDesc]
	FROM [dbo].[LIST_INVENTORYCLASS]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVENTORYCLASSUpdate] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVENTORYCLASSUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSUpdate]
(
	@LookupID int, 
	@LookupGroup varchar(50) = NULL, 
	@LookupValue int = NULL, 
	@LookupDesc varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_INVENTORYCLASS]
	SET
		[LookupGroup] = @LookupGroup, 
		[LookupValue] = @LookupValue, 
		[LookupDesc] = @LookupDesc
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVENTORYCLASSInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVENTORYCLASSInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSInsert]
(
	@LookupID int = NULL OUTPUT, 
	@LookupGroup varchar(50) = NULL, 
	@LookupValue int = NULL, 
	@LookupDesc varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_INVENTORYCLASS]
	(
		[LookupGroup], 
		[LookupValue], 
		[LookupDesc]
	)
	
	VALUES
	(
		@LookupGroup, 
		@LookupValue, 
		@LookupDesc
	)

	SET @Err = @@Error

		
	SELECT @LookupID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVENTORYCLASSDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVENTORYCLASSDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVENTORYCLASSDelete]
(
	@LookupID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_INVENTORYCLASS]
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVENTORYCLASSDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_INVITEMSTATUSLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVITEMSTATUSLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSLoadByPrimaryKey]
(
	@LookupID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LookupID], 
		[LookupGroup], 
		[LookupValue], 
		[LookupDesc]
	FROM [dbo].[LIST_INVITEMSTATUS]
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVITEMSTATUSLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVITEMSTATUSLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LookupID], 
		[LookupGroup], 
		[LookupValue], 
		[LookupDesc]
	FROM [dbo].[LIST_INVITEMSTATUS]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVITEMSTATUSUpdate] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVITEMSTATUSUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSUpdate]
(
	@LookupID int, 
	@LookupGroup varchar(50) = NULL, 
	@LookupValue int = NULL, 
	@LookupDesc varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_INVITEMSTATUS]
	SET
		[LookupGroup] = @LookupGroup, 
		[LookupValue] = @LookupValue, 
		[LookupDesc] = @LookupDesc
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVITEMSTATUSInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVITEMSTATUSInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSInsert]
(
	@LookupID int = NULL OUTPUT, 
	@LookupGroup varchar(50) = NULL, 
	@LookupValue int = NULL, 
	@LookupDesc varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_INVITEMSTATUS]
	(
		[LookupGroup], 
		[LookupValue], 
		[LookupDesc]
	)
	
	VALUES
	(
		@LookupGroup, 
		@LookupValue, 
		@LookupDesc
	)

	SET @Err = @@Error

		
	SELECT @LookupID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_INVITEMSTATUSDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_INVITEMSTATUSDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_INVITEMSTATUSDelete]
(
	@LookupID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_INVITEMSTATUS]
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_INVITEMSTATUSDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_ITEMTYPELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ITEMTYPELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ITEMTYPELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ITEMTYPELoadByPrimaryKey]
(
	@RecID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[ITEMTYPE]
	FROM [dbo].[LIST_ITEMTYPE]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ITEMTYPELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ITEMTYPELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_ITEMTYPELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ITEMTYPELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ITEMTYPELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ITEMTYPELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[ITEMTYPE]
	FROM [dbo].[LIST_ITEMTYPE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ITEMTYPELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ITEMTYPELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_ITEMTYPEUpdate] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ITEMTYPEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ITEMTYPEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ITEMTYPEUpdate]
(
	@RecID int, 
	@ITEMTYPE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_ITEMTYPE]
	SET
		[ITEMTYPE] = @ITEMTYPE
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ITEMTYPEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ITEMTYPEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_ITEMTYPEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ITEMTYPEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ITEMTYPEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ITEMTYPEInsert]
(
	@RecID int, 
	@ITEMTYPE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_ITEMTYPE]
	(
		[RecID], 
		[ITEMTYPE]
	)
	
	VALUES
	(
		@RecID, 
		@ITEMTYPE
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ITEMTYPEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ITEMTYPEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_ITEMTYPEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ITEMTYPEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ITEMTYPEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ITEMTYPEDelete]
(
	@RecID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_ITEMTYPE]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ITEMTYPEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ITEMTYPEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_LOADTYPELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_LOADTYPELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_LOADTYPELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_LOADTYPELoadByPrimaryKey]
(
	@RecID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[LoadType]
	FROM [dbo].[LIST_LOADTYPE]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_LOADTYPELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_LOADTYPELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_LOADTYPELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_LOADTYPELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_LOADTYPELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_LOADTYPELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[LoadType]
	FROM [dbo].[LIST_LOADTYPE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_LOADTYPELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_LOADTYPELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_LOADTYPEUpdate] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_LOADTYPEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_LOADTYPEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_LOADTYPEUpdate]
(
	@RecID int, 
	@LoadType varchar(24) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_LOADTYPE]
	SET
		[LoadType] = @LoadType
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_LOADTYPEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_LOADTYPEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_LOADTYPEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_LOADTYPEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_LOADTYPEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_LOADTYPEInsert]
(
	@RecID int, 
	@LoadType varchar(24) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_LOADTYPE]
	(
		[RecID], 
		[LoadType]
	)
	
	VALUES
	(
		@RecID, 
		@LoadType
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_LOADTYPEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_LOADTYPEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_LOADTYPEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_LOADTYPEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_LOADTYPEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_LOADTYPEDelete]
(
	@RecID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_LOADTYPE]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_LOADTYPEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_LOADTYPEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_ODORLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ODORLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ODORLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ODORLoadByPrimaryKey]
(
	@ODOR varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ODOR]
	FROM [dbo].[LIST_ODOR]
	WHERE
		([ODOR] = @ODOR)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ODORLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ODORLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_ODORLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ODORLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ODORLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ODORLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ODOR]
	FROM [dbo].[LIST_ODOR]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ODORLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ODORLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ODORUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ODORUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_ODORInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ODORInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ODORInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ODORInsert]
(
	@ODOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_ODOR]
	(
		[ODOR]
	)
	
	VALUES
	(
		@ODOR
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ODORInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ODORInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_ODORDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_ODORDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_ODORDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_ODORDelete]
(
	@ODOR varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_ODOR]
	WHERE
		([ODOR] = @ODOR)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_ODORDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_ODORDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_PACKAGEGROUPLoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PACKAGEGROUPLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPLoadByPrimaryKey]
(
	@RecID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[PackageGroup]
	FROM [dbo].[LIST_PACKAGEGROUP]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PACKAGEGROUPLoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PACKAGEGROUPLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[PackageGroup]
	FROM [dbo].[LIST_PACKAGEGROUP]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PACKAGEGROUPUpdate] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PACKAGEGROUPUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPUpdate]
(
	@RecID int, 
	@PackageGroup varchar(8) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_PACKAGEGROUP]
	SET
		[PackageGroup] = @PackageGroup
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PACKAGEGROUPInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PACKAGEGROUPInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPInsert]
(
	@RecID int, 
	@PackageGroup varchar(8) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_PACKAGEGROUP]
	(
		[RecID], 
		[PackageGroup]
	)
	
	VALUES
	(
		@RecID, 
		@PackageGroup
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PACKAGEGROUPDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PACKAGEGROUPDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PACKAGEGROUPDelete]
(
	@RecID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_PACKAGEGROUP]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PACKAGEGROUPDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_PALLETTYPELoadByPrimaryKey] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PALLETTYPELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PALLETTYPELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PALLETTYPELoadByPrimaryKey]
(
	@PALLETTYPE varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PALLETTYPE], 
		[PALLETWEIGHT]
	FROM [dbo].[LIST_PALLETTYPE]
	WHERE
		([PALLETTYPE] = @PALLETTYPE)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PALLETTYPELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PALLETTYPELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PALLETTYPELoadAll] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PALLETTYPELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PALLETTYPELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PALLETTYPELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PALLETTYPE], 
		[PALLETWEIGHT]
	FROM [dbo].[LIST_PALLETTYPE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PALLETTYPELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PALLETTYPELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PALLETTYPEUpdate] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PALLETTYPEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PALLETTYPEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PALLETTYPEUpdate]
(
	@PALLETTYPE varchar(50), 
	@PALLETWEIGHT int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_PALLETTYPE]
	SET
		[PALLETWEIGHT] = @PALLETWEIGHT
	WHERE
		([PALLETTYPE] = @PALLETTYPE)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PALLETTYPEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PALLETTYPEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PALLETTYPEInsert] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PALLETTYPEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PALLETTYPEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PALLETTYPEInsert]
(
	@PALLETTYPE varchar(50), 
	@PALLETWEIGHT int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_PALLETTYPE]
	(
		[PALLETTYPE], 
		[PALLETWEIGHT]
	)
	
	VALUES
	(
		@PALLETTYPE, 
		@PALLETWEIGHT
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PALLETTYPEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PALLETTYPEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_PALLETTYPEDelete] Script Date: 12/10/2013 4:01:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_PALLETTYPEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_PALLETTYPEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_PALLETTYPEDelete]
(
	@PALLETTYPE varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_PALLETTYPE]
	WHERE
		([PALLETTYPE] = @PALLETTYPE)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_PALLETTYPEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_PALLETTYPEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_SHELFLIFELoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_SHELFLIFELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_SHELFLIFELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_SHELFLIFELoadByPrimaryKey]
(
	@RECID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECID], 
		[SHELFLIFE]
	FROM [dbo].[LIST_SHELFLIFE]
	WHERE
		([RECID] = @RECID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_SHELFLIFELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_SHELFLIFELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_SHELFLIFELoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_SHELFLIFELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_SHELFLIFELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_SHELFLIFELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECID], 
		[SHELFLIFE]
	FROM [dbo].[LIST_SHELFLIFE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_SHELFLIFELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_SHELFLIFELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_SHELFLIFEUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_SHELFLIFEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_SHELFLIFEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_SHELFLIFEUpdate]
(
	@RECID int, 
	@SHELFLIFE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_SHELFLIFE]
	SET
		[SHELFLIFE] = @SHELFLIFE
	WHERE
		([RECID] = @RECID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_SHELFLIFEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_SHELFLIFEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_SHELFLIFEInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_SHELFLIFEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_SHELFLIFEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_SHELFLIFEInsert]
(
	@RECID int = NULL OUTPUT, 
	@SHELFLIFE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_SHELFLIFE]
	(
		[SHELFLIFE]
	)
	
	VALUES
	(
		@SHELFLIFE
	)

	SET @Err = @@Error

		
	SELECT @RECID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_SHELFLIFEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_SHELFLIFEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_SHELFLIFEDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_SHELFLIFEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_SHELFLIFEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_SHELFLIFEDelete]
(
	@RECID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_SHELFLIFE]
	WHERE
		([RECID] = @RECID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_SHELFLIFEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_SHELFLIFEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_UOMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_UOMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_UOMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_UOMLoadByPrimaryKey]
(
	@RECID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECID], 
		[INVENTORYMETHOD], 
		[SORTORDINAL], 
		[UOM]
	FROM [dbo].[LIST_UOM]
	WHERE
		([RECID] = @RECID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_UOMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_UOMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_UOMLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_UOMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_UOMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_UOMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECID], 
		[INVENTORYMETHOD], 
		[SORTORDINAL], 
		[UOM]
	FROM [dbo].[LIST_UOM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_UOMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_UOMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_UOMUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_UOMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_UOMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_UOMUpdate]
(
	@RECID int, 
	@INVENTORYMETHOD varchar(50) = NULL, 
	@SORTORDINAL int = NULL, 
	@UOM varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_UOM]
	SET
		[INVENTORYMETHOD] = @INVENTORYMETHOD, 
		[SORTORDINAL] = @SORTORDINAL, 
		[UOM] = @UOM
	WHERE
		([RECID] = @RECID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_UOMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_UOMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_UOMInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_UOMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_UOMInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_UOMInsert]
(
	@RECID int = NULL OUTPUT, 
	@INVENTORYMETHOD varchar(50) = NULL, 
	@SORTORDINAL int = NULL, 
	@UOM varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_UOM]
	(
		[INVENTORYMETHOD], 
		[SORTORDINAL], 
		[UOM]
	)
	
	VALUES
	(
		@INVENTORYMETHOD, 
		@SORTORDINAL, 
		@UOM
	)

	SET @Err = @@Error

		
	SELECT @RECID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_UOMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_UOMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_UOMDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_UOMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_UOMDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_UOMDelete]
(
	@RECID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_UOM]
	WHERE
		([RECID] = @RECID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_UOMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_UOMDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_WAREHOUSELOCATIONLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WAREHOUSELOCATIONLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONLoadByPrimaryKey]
(
	@WHLOCID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[WHLOCID], 
		[WAREHOUSEID], 
		[WAREHOUSELOCATION]
	FROM [dbo].[LIST_WAREHOUSELOCATION]
	WHERE
		([WHLOCID] = @WHLOCID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WAREHOUSELOCATIONLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WAREHOUSELOCATIONLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[WHLOCID], 
		[WAREHOUSEID], 
		[WAREHOUSELOCATION]
	FROM [dbo].[LIST_WAREHOUSELOCATION]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WAREHOUSELOCATIONUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WAREHOUSELOCATIONUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONUpdate]
(
	@WHLOCID int, 
	@WAREHOUSEID int = NULL, 
	@WAREHOUSELOCATION varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_WAREHOUSELOCATION]
	SET
		[WAREHOUSEID] = @WAREHOUSEID, 
		[WAREHOUSELOCATION] = @WAREHOUSELOCATION
	WHERE
		([WHLOCID] = @WHLOCID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WAREHOUSELOCATIONInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WAREHOUSELOCATIONInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONInsert]
(
	@WHLOCID int = NULL OUTPUT, 
	@WAREHOUSEID int = NULL, 
	@WAREHOUSELOCATION varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_WAREHOUSELOCATION]
	(
		[WAREHOUSEID], 
		[WAREHOUSELOCATION]
	)
	
	VALUES
	(
		@WAREHOUSEID, 
		@WAREHOUSELOCATION
	)

	SET @Err = @@Error

		
	SELECT @WHLOCID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WAREHOUSELOCATIONDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WAREHOUSELOCATIONDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WAREHOUSELOCATIONDelete]
(
	@WHLOCID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_WAREHOUSELOCATION]
	WHERE
		([WHLOCID] = @WHLOCID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WAREHOUSELOCATIONDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LIST_WORKORDERTYPELoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WORKORDERTYPELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WORKORDERTYPELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WORKORDERTYPELoadByPrimaryKey]
(
	@LISTKEY int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LISTKEY], 
		[WORKORDERTYPE]
	FROM [dbo].[LIST_WORKORDERTYPE]
	WHERE
		([LISTKEY] = @LISTKEY)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WORKORDERTYPELoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WORKORDERTYPELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WORKORDERTYPELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WORKORDERTYPELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LISTKEY], 
		[WORKORDERTYPE]
	FROM [dbo].[LIST_WORKORDERTYPE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WORKORDERTYPEUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WORKORDERTYPEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WORKORDERTYPEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WORKORDERTYPEUpdate]
(
	@LISTKEY int, 
	@WORKORDERTYPE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LIST_WORKORDERTYPE]
	SET
		[WORKORDERTYPE] = @WORKORDERTYPE
	WHERE
		([LISTKEY] = @LISTKEY)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WORKORDERTYPEInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WORKORDERTYPEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WORKORDERTYPEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WORKORDERTYPEInsert]
(
	@LISTKEY int, 
	@WORKORDERTYPE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LIST_WORKORDERTYPE]
	(
		[LISTKEY], 
		[WORKORDERTYPE]
	)
	
	VALUES
	(
		@LISTKEY, 
		@WORKORDERTYPE
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LIST_WORKORDERTYPEDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LIST_WORKORDERTYPEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LIST_WORKORDERTYPEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LIST_WORKORDERTYPEDelete]
(
	@LISTKEY int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LIST_WORKORDERTYPE]
	WHERE
		([LISTKEY] = @LISTKEY)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LIST_WORKORDERTYPEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LOADLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LOADLoadByPrimaryKey]
(
	@LoadID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadID], 
		[LoadStatus], 
		[LoadType], 
		[PlannedDepartureDate], 
		[PlannedDeliveryDate], 
		[CustID], 
		[OriginType], 
		[OriginID], 
		[OriginName], 
		[OriginAddress1], 
		[OriginAddress2], 
		[OriginCity], 
		[OriginState], 
		[OriginZip], 
		[OriginCountry], 
		[OriginPhone], 
		[OriginContact], 
		[PickupHours], 
		[DestType], 
		[DestID], 
		[DestName], 
		[DestAddress1], 
		[DestAddress2], 
		[DestCity], 
		[DestState], 
		[DestZip], 
		[DestCountry], 
		[DestPhone], 
		[DestContact], 
		[DeliveryHours], 
		[CarrierID], 
		[LogisticsID], 
		[FOB], 
		[BillCustomer], 
		[AddToInvoice], 
		[LoadNotes], 
		[CreatedTime], 
		[CreatedBy], 
		[ModifiedTime], 
		[ModifiedBy], 
		[ScheduledCarrierID], 
		[ScheduledLogisticsID], 
		[ScheduledShipmentDate], 
		[QuoteID], 
		[CarrierProNumber], 
		[ActualShipmentDate], 
		[ActualDeliveryDate]
	FROM [dbo].[LOAD]
	WHERE
		([LoadID] = @LoadID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LOADLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadID], 
		[LoadStatus], 
		[LoadType], 
		[PlannedDepartureDate], 
		[PlannedDeliveryDate], 
		[CustID], 
		[OriginType], 
		[OriginID], 
		[OriginName], 
		[OriginAddress1], 
		[OriginAddress2], 
		[OriginCity], 
		[OriginState], 
		[OriginZip], 
		[OriginCountry], 
		[OriginPhone], 
		[OriginContact], 
		[PickupHours], 
		[DestType], 
		[DestID], 
		[DestName], 
		[DestAddress1], 
		[DestAddress2], 
		[DestCity], 
		[DestState], 
		[DestZip], 
		[DestCountry], 
		[DestPhone], 
		[DestContact], 
		[DeliveryHours], 
		[CarrierID], 
		[LogisticsID], 
		[FOB], 
		[BillCustomer], 
		[AddToInvoice], 
		[LoadNotes], 
		[CreatedTime], 
		[CreatedBy], 
		[ModifiedTime], 
		[ModifiedBy], 
		[ScheduledCarrierID], 
		[ScheduledLogisticsID], 
		[ScheduledShipmentDate], 
		[QuoteID], 
		[CarrierProNumber], 
		[ActualShipmentDate], 
		[ActualDeliveryDate]
	FROM [dbo].[LOAD]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LOADUpdate]
(
	@LoadID int, 
	@LoadStatus varchar(50) = NULL, 
	@LoadType varchar(24) = NULL, 
	@PlannedDepartureDate datetime = NULL, 
	@PlannedDeliveryDate datetime = NULL, 
	@CustID int = NULL, 
	@OriginType varchar(50) = NULL, 
	@OriginID int = NULL, 
	@OriginName varchar(50) = NULL, 
	@OriginAddress1 varchar(50) = NULL, 
	@OriginAddress2 varchar(50) = NULL, 
	@OriginCity varchar(50) = NULL, 
	@OriginState varchar(50) = NULL, 
	@OriginZip varchar(24) = NULL, 
	@OriginCountry varchar(50) = NULL, 
	@OriginPhone varchar(50) = NULL, 
	@OriginContact varchar(50) = NULL, 
	@PickupHours varchar(50) = NULL, 
	@DestType varchar(50) = NULL, 
	@DestID int = NULL, 
	@DestName varchar(50) = NULL, 
	@DestAddress1 varchar(50) = NULL, 
	@DestAddress2 varchar(50) = NULL, 
	@DestCity varchar(50) = NULL, 
	@DestState varchar(50) = NULL, 
	@DestZip varchar(24) = NULL, 
	@DestCountry varchar(50) = NULL, 
	@DestPhone varchar(50) = NULL, 
	@DestContact varchar(50) = NULL, 
	@DeliveryHours varchar(50) = NULL, 
	@CarrierID int = NULL, 
	@LogisticsID int = NULL, 
	@FOB varchar(50) = NULL, 
	@BillCustomer bit = NULL, 
	@AddToInvoice bit = NULL, 
	@LoadNotes varchar(MAX) = NULL, 
	@CreatedTime datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@ModifiedTime datetime = NULL, 
	@ModifiedBy varchar(50) = NULL, 
	@ScheduledCarrierID int = NULL, 
	@ScheduledLogisticsID int = NULL, 
	@ScheduledShipmentDate datetime = NULL, 
	@QuoteID int = NULL, 
	@CarrierProNumber varchar(50) = NULL, 
	@ActualShipmentDate datetime = NULL, 
	@ActualDeliveryDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LOAD]
	SET
		[LoadStatus] = @LoadStatus, 
		[LoadType] = @LoadType, 
		[PlannedDepartureDate] = @PlannedDepartureDate, 
		[PlannedDeliveryDate] = @PlannedDeliveryDate, 
		[CustID] = @CustID, 
		[OriginType] = @OriginType, 
		[OriginID] = @OriginID, 
		[OriginName] = @OriginName, 
		[OriginAddress1] = @OriginAddress1, 
		[OriginAddress2] = @OriginAddress2, 
		[OriginCity] = @OriginCity, 
		[OriginState] = @OriginState, 
		[OriginZip] = @OriginZip, 
		[OriginCountry] = @OriginCountry, 
		[OriginPhone] = @OriginPhone, 
		[OriginContact] = @OriginContact, 
		[PickupHours] = @PickupHours, 
		[DestType] = @DestType, 
		[DestID] = @DestID, 
		[DestName] = @DestName, 
		[DestAddress1] = @DestAddress1, 
		[DestAddress2] = @DestAddress2, 
		[DestCity] = @DestCity, 
		[DestState] = @DestState, 
		[DestZip] = @DestZip, 
		[DestCountry] = @DestCountry, 
		[DestPhone] = @DestPhone, 
		[DestContact] = @DestContact, 
		[DeliveryHours] = @DeliveryHours, 
		[CarrierID] = @CarrierID, 
		[LogisticsID] = @LogisticsID, 
		[FOB] = @FOB, 
		[BillCustomer] = @BillCustomer, 
		[AddToInvoice] = @AddToInvoice, 
		[LoadNotes] = @LoadNotes, 
		[CreatedTime] = @CreatedTime, 
		[CreatedBy] = @CreatedBy, 
		[ModifiedTime] = @ModifiedTime, 
		[ModifiedBy] = @ModifiedBy, 
		[ScheduledCarrierID] = @ScheduledCarrierID, 
		[ScheduledLogisticsID] = @ScheduledLogisticsID, 
		[ScheduledShipmentDate] = @ScheduledShipmentDate, 
		[QuoteID] = @QuoteID, 
		[CarrierProNumber] = @CarrierProNumber, 
		[ActualShipmentDate] = @ActualShipmentDate, 
		[ActualDeliveryDate] = @ActualDeliveryDate
	WHERE
		([LoadID] = @LoadID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADInsert];
GO

CREATE PROCEDURE [dbo].[proc_LOADInsert]
(
	@LoadID int = NULL OUTPUT, 
	@LoadStatus varchar(50) = NULL, 
	@LoadType varchar(24) = NULL, 
	@PlannedDepartureDate datetime = NULL, 
	@PlannedDeliveryDate datetime = NULL, 
	@CustID int = NULL, 
	@OriginType varchar(50) = NULL, 
	@OriginID int = NULL, 
	@OriginName varchar(50) = NULL, 
	@OriginAddress1 varchar(50) = NULL, 
	@OriginAddress2 varchar(50) = NULL, 
	@OriginCity varchar(50) = NULL, 
	@OriginState varchar(50) = NULL, 
	@OriginZip varchar(24) = NULL, 
	@OriginCountry varchar(50) = NULL, 
	@OriginPhone varchar(50) = NULL, 
	@OriginContact varchar(50) = NULL, 
	@PickupHours varchar(50) = NULL, 
	@DestType varchar(50) = NULL, 
	@DestID int = NULL, 
	@DestName varchar(50) = NULL, 
	@DestAddress1 varchar(50) = NULL, 
	@DestAddress2 varchar(50) = NULL, 
	@DestCity varchar(50) = NULL, 
	@DestState varchar(50) = NULL, 
	@DestZip varchar(24) = NULL, 
	@DestCountry varchar(50) = NULL, 
	@DestPhone varchar(50) = NULL, 
	@DestContact varchar(50) = NULL, 
	@DeliveryHours varchar(50) = NULL, 
	@CarrierID int = NULL, 
	@LogisticsID int = NULL, 
	@FOB varchar(50) = NULL, 
	@BillCustomer bit = NULL, 
	@AddToInvoice bit = NULL, 
	@LoadNotes varchar(MAX) = NULL, 
	@CreatedTime datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@ModifiedTime datetime = NULL, 
	@ModifiedBy varchar(50) = NULL, 
	@ScheduledCarrierID int = NULL, 
	@ScheduledLogisticsID int = NULL, 
	@ScheduledShipmentDate datetime = NULL, 
	@QuoteID int = NULL, 
	@CarrierProNumber varchar(50) = NULL, 
	@ActualShipmentDate datetime = NULL, 
	@ActualDeliveryDate datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LOAD]
	(
		[LoadStatus], 
		[LoadType], 
		[PlannedDepartureDate], 
		[PlannedDeliveryDate], 
		[CustID], 
		[OriginType], 
		[OriginID], 
		[OriginName], 
		[OriginAddress1], 
		[OriginAddress2], 
		[OriginCity], 
		[OriginState], 
		[OriginZip], 
		[OriginCountry], 
		[OriginPhone], 
		[OriginContact], 
		[PickupHours], 
		[DestType], 
		[DestID], 
		[DestName], 
		[DestAddress1], 
		[DestAddress2], 
		[DestCity], 
		[DestState], 
		[DestZip], 
		[DestCountry], 
		[DestPhone], 
		[DestContact], 
		[DeliveryHours], 
		[CarrierID], 
		[LogisticsID], 
		[FOB], 
		[BillCustomer], 
		[AddToInvoice], 
		[LoadNotes], 
		[CreatedTime], 
		[CreatedBy], 
		[ModifiedTime], 
		[ModifiedBy], 
		[ScheduledCarrierID], 
		[ScheduledLogisticsID], 
		[ScheduledShipmentDate], 
		[QuoteID], 
		[CarrierProNumber], 
		[ActualShipmentDate], 
		[ActualDeliveryDate]
	)
	
	VALUES
	(
		@LoadStatus, 
		@LoadType, 
		@PlannedDepartureDate, 
		@PlannedDeliveryDate, 
		@CustID, 
		@OriginType, 
		@OriginID, 
		@OriginName, 
		@OriginAddress1, 
		@OriginAddress2, 
		@OriginCity, 
		@OriginState, 
		@OriginZip, 
		@OriginCountry, 
		@OriginPhone, 
		@OriginContact, 
		@PickupHours, 
		@DestType, 
		@DestID, 
		@DestName, 
		@DestAddress1, 
		@DestAddress2, 
		@DestCity, 
		@DestState, 
		@DestZip, 
		@DestCountry, 
		@DestPhone, 
		@DestContact, 
		@DeliveryHours, 
		@CarrierID, 
		@LogisticsID, 
		@FOB, 
		@BillCustomer, 
		@AddToInvoice, 
		@LoadNotes, 
		@CreatedTime, 
		@CreatedBy, 
		@ModifiedTime, 
		@ModifiedBy, 
		@ScheduledCarrierID, 
		@ScheduledLogisticsID, 
		@ScheduledShipmentDate, 
		@QuoteID, 
		@CarrierProNumber, 
		@ActualShipmentDate, 
		@ActualDeliveryDate
	)

	SET @Err = @@Error

		
	SELECT @LoadID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADDelete];
GO

CREATE PROCEDURE [dbo].[proc_LOADDelete]
(
	@LoadID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LOAD]
	WHERE
		([LoadID] = @LoadID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LOADBILLINGLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADBILLINGLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADBILLINGLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LOADBILLINGLoadByPrimaryKey]
(
	@LOADBILLINGID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LOADBILLINGID], 
		[LOADID], 
		[CustomerID], 
		[CustomerPO], 
		[BilledAmount], 
		[BillingDate], 
		[CreatedBy], 
		[BillingEntity], 
		[InvoiceNumber], 
		[Status], 
		[BillingNote]
	FROM [dbo].[LOADBILLING]
	WHERE
		([LOADBILLINGID] = @LOADBILLINGID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADBILLINGLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADBILLINGLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADBILLINGLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADBILLINGLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADBILLINGLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LOADBILLINGLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LOADBILLINGID], 
		[LOADID], 
		[CustomerID], 
		[CustomerPO], 
		[BilledAmount], 
		[BillingDate], 
		[CreatedBy], 
		[BillingEntity], 
		[InvoiceNumber], 
		[Status], 
		[BillingNote]
	FROM [dbo].[LOADBILLING]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADBILLINGLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADBILLINGLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADBILLINGUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADBILLINGUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADBILLINGUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LOADBILLINGUpdate]
(
	@LOADBILLINGID int, 
	@LOADID int = NULL, 
	@CustomerID int = NULL, 
	@CustomerPO varchar(50) = NULL, 
	@BilledAmount decimal(18,2) = NULL, 
	@BillingDate datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@BillingEntity varchar(50) = NULL, 
	@InvoiceNumber int = NULL, 
	@Status varchar(50) = NULL, 
	@BillingNote varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LOADBILLING]
	SET
		[LOADID] = @LOADID, 
		[CustomerID] = @CustomerID, 
		[CustomerPO] = @CustomerPO, 
		[BilledAmount] = @BilledAmount, 
		[BillingDate] = @BillingDate, 
		[CreatedBy] = @CreatedBy, 
		[BillingEntity] = @BillingEntity, 
		[InvoiceNumber] = @InvoiceNumber, 
		[Status] = @Status, 
		[BillingNote] = @BillingNote
	WHERE
		([LOADBILLINGID] = @LOADBILLINGID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADBILLINGUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADBILLINGUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADBILLINGInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADBILLINGInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADBILLINGInsert];
GO

CREATE PROCEDURE [dbo].[proc_LOADBILLINGInsert]
(
	@LOADBILLINGID int = NULL OUTPUT, 
	@LOADID int = NULL, 
	@CustomerID int = NULL, 
	@CustomerPO varchar(50) = NULL, 
	@BilledAmount decimal(18,2) = NULL, 
	@BillingDate datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@BillingEntity varchar(50) = NULL, 
	@InvoiceNumber int = NULL, 
	@Status varchar(50) = NULL, 
	@BillingNote varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LOADBILLING]
	(
		[LOADID], 
		[CustomerID], 
		[CustomerPO], 
		[BilledAmount], 
		[BillingDate], 
		[CreatedBy], 
		[BillingEntity], 
		[InvoiceNumber], 
		[Status], 
		[BillingNote]
	)
	
	VALUES
	(
		@LOADID, 
		@CustomerID, 
		@CustomerPO, 
		@BilledAmount, 
		@BillingDate, 
		@CreatedBy, 
		@BillingEntity, 
		@InvoiceNumber, 
		@Status, 
		@BillingNote
	)

	SET @Err = @@Error

		
	SELECT @LOADBILLINGID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADBILLINGInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADBILLINGInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADBILLINGDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADBILLINGDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADBILLINGDelete];
GO

CREATE PROCEDURE [dbo].[proc_LOADBILLINGDelete]
(
	@LOADBILLINGID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LOADBILLING]
	WHERE
		([LOADBILLINGID] = @LOADBILLINGID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADBILLINGDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADBILLINGDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LOADCHARGELoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADCHARGELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADCHARGELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LOADCHARGELoadByPrimaryKey]
(
	@LoadChargeID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadChargeID], 
		[LoadID], 
		[CarrierID], 
		[LogisticsProviderID], 
		[CarrierCharges], 
		[ChargeType], 
		[ChargeDate], 
		[CreatedBy], 
		[LoadChargeStatus], 
		[ChargeNote]
	FROM [dbo].[LOADCHARGE]
	WHERE
		([LoadChargeID] = @LoadChargeID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADCHARGELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADCHARGELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADCHARGELoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADCHARGELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADCHARGELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LOADCHARGELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadChargeID], 
		[LoadID], 
		[CarrierID], 
		[LogisticsProviderID], 
		[CarrierCharges], 
		[ChargeType], 
		[ChargeDate], 
		[CreatedBy], 
		[LoadChargeStatus], 
		[ChargeNote]
	FROM [dbo].[LOADCHARGE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADCHARGELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADCHARGELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADCHARGEUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADCHARGEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADCHARGEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LOADCHARGEUpdate]
(
	@LoadChargeID int, 
	@LoadID int = NULL, 
	@CarrierID int = NULL, 
	@LogisticsProviderID int = NULL, 
	@CarrierCharges decimal(18,2) = NULL, 
	@ChargeType varchar(24) = NULL, 
	@ChargeDate datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@LoadChargeStatus varchar(50) = NULL, 
	@ChargeNote varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LOADCHARGE]
	SET
		[LoadID] = @LoadID, 
		[CarrierID] = @CarrierID, 
		[LogisticsProviderID] = @LogisticsProviderID, 
		[CarrierCharges] = @CarrierCharges, 
		[ChargeType] = @ChargeType, 
		[ChargeDate] = @ChargeDate, 
		[CreatedBy] = @CreatedBy, 
		[LoadChargeStatus] = @LoadChargeStatus, 
		[ChargeNote] = @ChargeNote
	WHERE
		([LoadChargeID] = @LoadChargeID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADCHARGEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADCHARGEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADCHARGEInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADCHARGEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADCHARGEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LOADCHARGEInsert]
(
	@LoadChargeID int = NULL OUTPUT, 
	@LoadID int = NULL, 
	@CarrierID int = NULL, 
	@LogisticsProviderID int = NULL, 
	@CarrierCharges decimal(18,2) = NULL, 
	@ChargeType varchar(24) = NULL, 
	@ChargeDate datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@LoadChargeStatus varchar(50) = NULL, 
	@ChargeNote varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LOADCHARGE]
	(
		[LoadID], 
		[CarrierID], 
		[LogisticsProviderID], 
		[CarrierCharges], 
		[ChargeType], 
		[ChargeDate], 
		[CreatedBy], 
		[LoadChargeStatus], 
		[ChargeNote]
	)
	
	VALUES
	(
		@LoadID, 
		@CarrierID, 
		@LogisticsProviderID, 
		@CarrierCharges, 
		@ChargeType, 
		@ChargeDate, 
		@CreatedBy, 
		@LoadChargeStatus, 
		@ChargeNote
	)

	SET @Err = @@Error

		
	SELECT @LoadChargeID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADCHARGEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADCHARGEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADCHARGEDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADCHARGEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADCHARGEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LOADCHARGEDelete]
(
	@LoadChargeID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LOADCHARGE]
	WHERE
		([LoadChargeID] = @LoadChargeID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADCHARGEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADCHARGEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LOADITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LOADITEMLoadByPrimaryKey]
(
	@LoadItemID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadItemID], 
		[LoadID], 
		[SourceType], 
		[SourceID], 
		[ItemType], 
		[ItemID], 
		[ItemDescription], 
		[Container], 
		[QtyContainers], 
		[TotalVolume], 
		[VolumeUOM], 
		[TotalWeight], 
		[WeightUOM], 
		[DOTIDNumber], 
		[HazmatID], 
		[HazmatClass], 
		[HazmatPackageGroup], 
		[ClassRate], 
		[DOTDesc], 
		[HazMatDesc], 
		[UNLine], 
		[IsHazardous], 
		[PalletID], 
		[LoadItemNote], 
		[LD1], 
		[LD2], 
		[LD3], 
		[CreatedTime], 
		[CreatedBy], 
		[ModifiedTime], 
		[ModifiedBy]
	FROM [dbo].[LOADITEM]
	WHERE
		([LoadItemID] = @LoadItemID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADITEMLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LOADITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadItemID], 
		[LoadID], 
		[SourceType], 
		[SourceID], 
		[ItemType], 
		[ItemID], 
		[ItemDescription], 
		[Container], 
		[QtyContainers], 
		[TotalVolume], 
		[VolumeUOM], 
		[TotalWeight], 
		[WeightUOM], 
		[DOTIDNumber], 
		[HazmatID], 
		[HazmatClass], 
		[HazmatPackageGroup], 
		[ClassRate], 
		[DOTDesc], 
		[HazMatDesc], 
		[UNLine], 
		[IsHazardous], 
		[PalletID], 
		[LoadItemNote], 
		[LD1], 
		[LD2], 
		[LD3], 
		[CreatedTime], 
		[CreatedBy], 
		[ModifiedTime], 
		[ModifiedBy]
	FROM [dbo].[LOADITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADITEMUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LOADITEMUpdate]
(
	@LoadItemID int, 
	@LoadID int = NULL, 
	@SourceType varchar(50) = NULL, 
	@SourceID int = NULL, 
	@ItemType varchar(50) = NULL, 
	@ItemID int = NULL, 
	@ItemDescription varchar(200) = NULL, 
	@Container varchar(50) = NULL, 
	@QtyContainers int = NULL, 
	@TotalVolume int = NULL, 
	@VolumeUOM varchar(50) = NULL, 
	@TotalWeight int = NULL, 
	@WeightUOM varchar(50) = NULL, 
	@DOTIDNumber varchar(24) = NULL, 
	@HazmatID int = NULL, 
	@HazmatClass varchar(50) = NULL, 
	@HazmatPackageGroup varchar(50) = NULL, 
	@ClassRate varchar(50) = NULL, 
	@DOTDesc varchar(200) = NULL, 
	@HazMatDesc varchar(200) = NULL, 
	@UNLine varchar(200) = NULL, 
	@IsHazardous bit = NULL, 
	@PalletID int = NULL, 
	@LoadItemNote varchar(MAX) = NULL, 
	@LD1 varchar(500) = NULL, 
	@LD2 varchar(500) = NULL, 
	@LD3 varchar(500) = NULL, 
	@CreatedTime datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@ModifiedTime datetime = NULL, 
	@ModifiedBy varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LOADITEM]
	SET
		[LoadID] = @LoadID, 
		[SourceType] = @SourceType, 
		[SourceID] = @SourceID, 
		[ItemType] = @ItemType, 
		[ItemID] = @ItemID, 
		[ItemDescription] = @ItemDescription, 
		[Container] = @Container, 
		[QtyContainers] = @QtyContainers, 
		[TotalVolume] = @TotalVolume, 
		[VolumeUOM] = @VolumeUOM, 
		[TotalWeight] = @TotalWeight, 
		[WeightUOM] = @WeightUOM, 
		[DOTIDNumber] = @DOTIDNumber, 
		[HazmatID] = @HazmatID, 
		[HazmatClass] = @HazmatClass, 
		[HazmatPackageGroup] = @HazmatPackageGroup, 
		[ClassRate] = @ClassRate, 
		[DOTDesc] = @DOTDesc, 
		[HazMatDesc] = @HazMatDesc, 
		[UNLine] = @UNLine, 
		[IsHazardous] = @IsHazardous, 
		[PalletID] = @PalletID, 
		[LoadItemNote] = @LoadItemNote, 
		[LD1] = @LD1, 
		[LD2] = @LD2, 
		[LD3] = @LD3, 
		[CreatedTime] = @CreatedTime, 
		[CreatedBy] = @CreatedBy, 
		[ModifiedTime] = @ModifiedTime, 
		[ModifiedBy] = @ModifiedBy
	WHERE
		([LoadItemID] = @LoadItemID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADITEMInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_LOADITEMInsert]
(
	@LoadItemID int = NULL OUTPUT, 
	@LoadID int = NULL, 
	@SourceType varchar(50) = NULL, 
	@SourceID int = NULL, 
	@ItemType varchar(50) = NULL, 
	@ItemID int = NULL, 
	@ItemDescription varchar(200) = NULL, 
	@Container varchar(50) = NULL, 
	@QtyContainers int = NULL, 
	@TotalVolume int = NULL, 
	@VolumeUOM varchar(50) = NULL, 
	@TotalWeight int = NULL, 
	@WeightUOM varchar(50) = NULL, 
	@DOTIDNumber varchar(24) = NULL, 
	@HazmatID int = NULL, 
	@HazmatClass varchar(50) = NULL, 
	@HazmatPackageGroup varchar(50) = NULL, 
	@ClassRate varchar(50) = NULL, 
	@DOTDesc varchar(200) = NULL, 
	@HazMatDesc varchar(200) = NULL, 
	@UNLine varchar(200) = NULL, 
	@IsHazardous bit = NULL, 
	@PalletID int = NULL, 
	@LoadItemNote varchar(MAX) = NULL, 
	@LD1 varchar(500) = NULL, 
	@LD2 varchar(500) = NULL, 
	@LD3 varchar(500) = NULL, 
	@CreatedTime datetime = NULL, 
	@CreatedBy varchar(50) = NULL, 
	@ModifiedTime datetime = NULL, 
	@ModifiedBy varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LOADITEM]
	(
		[LoadID], 
		[SourceType], 
		[SourceID], 
		[ItemType], 
		[ItemID], 
		[ItemDescription], 
		[Container], 
		[QtyContainers], 
		[TotalVolume], 
		[VolumeUOM], 
		[TotalWeight], 
		[WeightUOM], 
		[DOTIDNumber], 
		[HazmatID], 
		[HazmatClass], 
		[HazmatPackageGroup], 
		[ClassRate], 
		[DOTDesc], 
		[HazMatDesc], 
		[UNLine], 
		[IsHazardous], 
		[PalletID], 
		[LoadItemNote], 
		[LD1], 
		[LD2], 
		[LD3], 
		[CreatedTime], 
		[CreatedBy], 
		[ModifiedTime], 
		[ModifiedBy]
	)
	
	VALUES
	(
		@LoadID, 
		@SourceType, 
		@SourceID, 
		@ItemType, 
		@ItemID, 
		@ItemDescription, 
		@Container, 
		@QtyContainers, 
		@TotalVolume, 
		@VolumeUOM, 
		@TotalWeight, 
		@WeightUOM, 
		@DOTIDNumber, 
		@HazmatID, 
		@HazmatClass, 
		@HazmatPackageGroup, 
		@ClassRate, 
		@DOTDesc, 
		@HazMatDesc, 
		@UNLine, 
		@IsHazardous, 
		@PalletID, 
		@LoadItemNote, 
		@LD1, 
		@LD2, 
		@LD3, 
		@CreatedTime, 
		@CreatedBy, 
		@ModifiedTime, 
		@ModifiedBy
	)

	SET @Err = @@Error

		
	SELECT @LoadItemID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADITEMDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_LOADITEMDelete]
(
	@LoadItemID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LOADITEM]
	WHERE
		([LoadItemID] = @LoadItemID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADITEMDelete Error on Creation'
GO 


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


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LOADQUOTELoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADQUOTELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADQUOTELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LOADQUOTELoadByPrimaryKey]
(
	@LoadQuoteID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadQuoteID], 
		[LoadID], 
		[CarrierID], 
		[LogisticsProviderID], 
		[QuoteAmount], 
		[QuoteDate], 
		[CarrierQuoteNumber]
	FROM [dbo].[LOADQUOTE]
	WHERE
		([LoadQuoteID] = @LoadQuoteID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADQUOTELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADQUOTELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADQUOTELoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADQUOTELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADQUOTELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LOADQUOTELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LoadQuoteID], 
		[LoadID], 
		[CarrierID], 
		[LogisticsProviderID], 
		[QuoteAmount], 
		[QuoteDate], 
		[CarrierQuoteNumber]
	FROM [dbo].[LOADQUOTE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADQUOTELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADQUOTELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADQUOTEUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADQUOTEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADQUOTEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LOADQUOTEUpdate]
(
	@LoadQuoteID int, 
	@LoadID int = NULL, 
	@CarrierID int = NULL, 
	@LogisticsProviderID int = NULL, 
	@QuoteAmount decimal(18,2) = NULL, 
	@QuoteDate datetime = NULL, 
	@CarrierQuoteNumber varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LOADQUOTE]
	SET
		[LoadID] = @LoadID, 
		[CarrierID] = @CarrierID, 
		[LogisticsProviderID] = @LogisticsProviderID, 
		[QuoteAmount] = @QuoteAmount, 
		[QuoteDate] = @QuoteDate, 
		[CarrierQuoteNumber] = @CarrierQuoteNumber
	WHERE
		([LoadQuoteID] = @LoadQuoteID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADQUOTEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADQUOTEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADQUOTEInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADQUOTEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADQUOTEInsert];
GO

CREATE PROCEDURE [dbo].[proc_LOADQUOTEInsert]
(
	@LoadQuoteID int = NULL OUTPUT, 
	@LoadID int = NULL, 
	@CarrierID int = NULL, 
	@LogisticsProviderID int = NULL, 
	@QuoteAmount decimal(18,2) = NULL, 
	@QuoteDate datetime = NULL, 
	@CarrierQuoteNumber varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LOADQUOTE]
	(
		[LoadID], 
		[CarrierID], 
		[LogisticsProviderID], 
		[QuoteAmount], 
		[QuoteDate], 
		[CarrierQuoteNumber]
	)
	
	VALUES
	(
		@LoadID, 
		@CarrierID, 
		@LogisticsProviderID, 
		@QuoteAmount, 
		@QuoteDate, 
		@CarrierQuoteNumber
	)

	SET @Err = @@Error

		
	SELECT @LoadQuoteID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADQUOTEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADQUOTEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOADQUOTEDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOADQUOTEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOADQUOTEDelete];
GO

CREATE PROCEDURE [dbo].[proc_LOADQUOTEDelete]
(
	@LoadQuoteID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LOADQUOTE]
	WHERE
		([LoadQuoteID] = @LoadQuoteID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOADQUOTEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOADQUOTEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LOGISTICSLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOGISTICSLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOGISTICSLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LOGISTICSLoadByPrimaryKey]
(
	@LOGISTICSID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LOGISTICSID], 
		[LOGISTICSNAME], 
		[LOGISTICSADDR1], 
		[LOGISTICSADDR2], 
		[LOGISTICSCITY], 
		[LOGISTICSSTATE], 
		[LOGISTICSZIP], 
		[LOGISTICSPHONE], 
		[LOGISTICSFAX], 
		[LOGISTICSCONTACT], 
		[LOGISTICSERMAIL], 
		[LOGISTICSWEBURL], 
		[ISACTIVE], 
		[CREATEDBY], 
		[CREATETIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	FROM [dbo].[LOGISTICS]
	WHERE
		([LOGISTICSID] = @LOGISTICSID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOGISTICSLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOGISTICSLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOGISTICSLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOGISTICSLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOGISTICSLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LOGISTICSLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LOGISTICSID], 
		[LOGISTICSNAME], 
		[LOGISTICSADDR1], 
		[LOGISTICSADDR2], 
		[LOGISTICSCITY], 
		[LOGISTICSSTATE], 
		[LOGISTICSZIP], 
		[LOGISTICSPHONE], 
		[LOGISTICSFAX], 
		[LOGISTICSCONTACT], 
		[LOGISTICSERMAIL], 
		[LOGISTICSWEBURL], 
		[ISACTIVE], 
		[CREATEDBY], 
		[CREATETIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	FROM [dbo].[LOGISTICS]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOGISTICSLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOGISTICSLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOGISTICSUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOGISTICSUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOGISTICSUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LOGISTICSUpdate]
(
	@LOGISTICSID int, 
	@LOGISTICSNAME varchar(50) = NULL, 
	@LOGISTICSADDR1 varchar(50) = NULL, 
	@LOGISTICSADDR2 varchar(50) = NULL, 
	@LOGISTICSCITY varchar(50) = NULL, 
	@LOGISTICSSTATE varchar(2) = NULL, 
	@LOGISTICSZIP varchar(10) = NULL, 
	@LOGISTICSPHONE varchar(24) = NULL, 
	@LOGISTICSFAX varchar(24) = NULL, 
	@LOGISTICSCONTACT varchar(50) = NULL, 
	@LOGISTICSERMAIL varchar(100) = NULL, 
	@LOGISTICSWEBURL varchar(50) = NULL, 
	@ISACTIVE bit, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATETIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LOGISTICS]
	SET
		[LOGISTICSNAME] = @LOGISTICSNAME, 
		[LOGISTICSADDR1] = @LOGISTICSADDR1, 
		[LOGISTICSADDR2] = @LOGISTICSADDR2, 
		[LOGISTICSCITY] = @LOGISTICSCITY, 
		[LOGISTICSSTATE] = @LOGISTICSSTATE, 
		[LOGISTICSZIP] = @LOGISTICSZIP, 
		[LOGISTICSPHONE] = @LOGISTICSPHONE, 
		[LOGISTICSFAX] = @LOGISTICSFAX, 
		[LOGISTICSCONTACT] = @LOGISTICSCONTACT, 
		[LOGISTICSERMAIL] = @LOGISTICSERMAIL, 
		[LOGISTICSWEBURL] = @LOGISTICSWEBURL, 
		[ISACTIVE] = @ISACTIVE, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATETIME] = @CREATETIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME
	WHERE
		([LOGISTICSID] = @LOGISTICSID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOGISTICSUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOGISTICSUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOGISTICSInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOGISTICSInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOGISTICSInsert];
GO

CREATE PROCEDURE [dbo].[proc_LOGISTICSInsert]
(
	@LOGISTICSID int = NULL OUTPUT, 
	@LOGISTICSNAME varchar(50) = NULL, 
	@LOGISTICSADDR1 varchar(50) = NULL, 
	@LOGISTICSADDR2 varchar(50) = NULL, 
	@LOGISTICSCITY varchar(50) = NULL, 
	@LOGISTICSSTATE varchar(2) = NULL, 
	@LOGISTICSZIP varchar(10) = NULL, 
	@LOGISTICSPHONE varchar(24) = NULL, 
	@LOGISTICSFAX varchar(24) = NULL, 
	@LOGISTICSCONTACT varchar(50) = NULL, 
	@LOGISTICSERMAIL varchar(100) = NULL, 
	@LOGISTICSWEBURL varchar(50) = NULL, 
	@ISACTIVE bit, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATETIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LOGISTICS]
	(
		[LOGISTICSNAME], 
		[LOGISTICSADDR1], 
		[LOGISTICSADDR2], 
		[LOGISTICSCITY], 
		[LOGISTICSSTATE], 
		[LOGISTICSZIP], 
		[LOGISTICSPHONE], 
		[LOGISTICSFAX], 
		[LOGISTICSCONTACT], 
		[LOGISTICSERMAIL], 
		[LOGISTICSWEBURL], 
		[ISACTIVE], 
		[CREATEDBY], 
		[CREATETIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	)
	
	VALUES
	(
		@LOGISTICSNAME, 
		@LOGISTICSADDR1, 
		@LOGISTICSADDR2, 
		@LOGISTICSCITY, 
		@LOGISTICSSTATE, 
		@LOGISTICSZIP, 
		@LOGISTICSPHONE, 
		@LOGISTICSFAX, 
		@LOGISTICSCONTACT, 
		@LOGISTICSERMAIL, 
		@LOGISTICSWEBURL, 
		@ISACTIVE, 
		@CREATEDBY, 
		@CREATETIME, 
		@MODIFYBY, 
		@MODIFYTIME
	)

	SET @Err = @@Error

		
	SELECT @LOGISTICSID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOGISTICSInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOGISTICSInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOGISTICSDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOGISTICSDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOGISTICSDelete];
GO

CREATE PROCEDURE [dbo].[proc_LOGISTICSDelete]
(
	@LOGISTICSID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LOGISTICS]
	WHERE
		([LOGISTICSID] = @LOGISTICSID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOGISTICSDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOGISTICSDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_LOOKUPLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOOKUPLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOOKUPLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_LOOKUPLoadByPrimaryKey]
(
	@LookupID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LookupID], 
		[LookupGroup], 
		[LookUpValue], 
		[LookupDesc]
	FROM [dbo].[LOOKUP]
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOOKUPLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOOKUPLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOOKUPLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOOKUPLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOOKUPLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_LOOKUPLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[LookupID], 
		[LookupGroup], 
		[LookUpValue], 
		[LookupDesc]
	FROM [dbo].[LOOKUP]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOOKUPLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOOKUPLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOOKUPUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOOKUPUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOOKUPUpdate];
GO

CREATE PROCEDURE [dbo].[proc_LOOKUPUpdate]
(
	@LookupID int, 
	@LookupGroup varchar(50) = NULL, 
	@LookUpValue int = NULL, 
	@LookupDesc varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [LOOKUP]
	SET
		[LookupGroup] = @LookupGroup, 
		[LookUpValue] = @LookUpValue, 
		[LookupDesc] = @LookupDesc
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOOKUPUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOOKUPUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOOKUPInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOOKUPInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOOKUPInsert];
GO

CREATE PROCEDURE [dbo].[proc_LOOKUPInsert]
(
	@LookupID int = NULL OUTPUT, 
	@LookupGroup varchar(50) = NULL, 
	@LookUpValue int = NULL, 
	@LookupDesc varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [LOOKUP]
	(
		[LookupGroup], 
		[LookUpValue], 
		[LookupDesc]
	)
	
	VALUES
	(
		@LookupGroup, 
		@LookUpValue, 
		@LookupDesc
	)

	SET @Err = @@Error

		
	SELECT @LookupID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOOKUPInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOOKUPInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_LOOKUPDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_LOOKUPDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_LOOKUPDelete];
GO

CREATE PROCEDURE [dbo].[proc_LOOKUPDelete]
(
	@LookupID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[LOOKUP]
	WHERE
		([LookupID] = @LookupID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_LOOKUPDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_LOOKUPDelete Error on Creation'
GO 


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


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_MATERIALLoadByPrimaryKey] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALLoadByPrimaryKey]
(
	@MATERIALID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[MATERIALID], 
		[MATERIALDESC], 
		[MATERIALUOM], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE], 
		[CHEMICALID]
	FROM [dbo].[MATERIAL]
	WHERE
		([MATERIALID] = @MATERIALID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALLoadAll] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[MATERIALID], 
		[MATERIALDESC], 
		[MATERIALUOM], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE], 
		[CHEMICALID]
	FROM [dbo].[MATERIAL]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALUpdate] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALUpdate];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALUpdate]
(
	@MATERIALID int, 
	@MATERIALDESC varchar(200) = NULL, 
	@MATERIALUOM varchar(50) = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@ISACTIVE bit = NULL, 
	@CHEMICALID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [MATERIAL]
	SET
		[MATERIALDESC] = @MATERIALDESC, 
		[MATERIALUOM] = @MATERIALUOM, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME, 
		[ISACTIVE] = @ISACTIVE, 
		[CHEMICALID] = @CHEMICALID
	WHERE
		([MATERIALID] = @MATERIALID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALInsert] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALInsert];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALInsert]
(
	@MATERIALID int = NULL OUTPUT, 
	@MATERIALDESC varchar(200) = NULL, 
	@MATERIALUOM varchar(50) = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@ISACTIVE bit = NULL, 
	@CHEMICALID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [MATERIAL]
	(
		[MATERIALDESC], 
		[MATERIALUOM], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE], 
		[CHEMICALID]
	)
	
	VALUES
	(
		@MATERIALDESC, 
		@MATERIALUOM, 
		@CREATEDBY, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME, 
		@ISACTIVE, 
		@CHEMICALID
	)

	SET @Err = @@Error

		
	SELECT @MATERIALID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALDelete] Script Date: 12/10/2013 4:01:07 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALDelete];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALDelete]
(
	@MATERIALID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[MATERIAL]
	WHERE
		([MATERIALID] = @MATERIALID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_MATERIALPRODUCTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:13 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALPRODUCTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALPRODUCTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALPRODUCTLoadByPrimaryKey]
(
	@MPID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[MPID], 
		[MATERIALID], 
		[PRODUCTID], 
		[MPNOTE]
	FROM [dbo].[MATERIALPRODUCT]
	WHERE
		([MPID] = @MPID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALPRODUCTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALPRODUCTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALPRODUCTLoadAll] Script Date: 12/10/2013 4:01:13 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALPRODUCTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALPRODUCTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALPRODUCTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[MPID], 
		[MATERIALID], 
		[PRODUCTID], 
		[MPNOTE]
	FROM [dbo].[MATERIALPRODUCT]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALPRODUCTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALPRODUCTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALPRODUCTUpdate] Script Date: 12/10/2013 4:01:13 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALPRODUCTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALPRODUCTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALPRODUCTUpdate]
(
	@MPID int, 
	@MATERIALID int = NULL, 
	@PRODUCTID int = NULL, 
	@MPNOTE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [MATERIALPRODUCT]
	SET
		[MATERIALID] = @MATERIALID, 
		[PRODUCTID] = @PRODUCTID, 
		[MPNOTE] = @MPNOTE
	WHERE
		([MPID] = @MPID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALPRODUCTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALPRODUCTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALPRODUCTInsert] Script Date: 12/10/2013 4:01:13 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALPRODUCTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALPRODUCTInsert];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALPRODUCTInsert]
(
	@MPID int = NULL OUTPUT, 
	@MATERIALID int = NULL, 
	@PRODUCTID int = NULL, 
	@MPNOTE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [MATERIALPRODUCT]
	(
		[MATERIALID], 
		[PRODUCTID], 
		[MPNOTE]
	)
	
	VALUES
	(
		@MATERIALID, 
		@PRODUCTID, 
		@MPNOTE
	)

	SET @Err = @@Error

		
	SELECT @MPID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALPRODUCTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALPRODUCTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_MATERIALPRODUCTDelete] Script Date: 12/10/2013 4:01:13 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_MATERIALPRODUCTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_MATERIALPRODUCTDelete];
GO

CREATE PROCEDURE [dbo].[proc_MATERIALPRODUCTDelete]
(
	@MPID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[MATERIALPRODUCT]
	WHERE
		([MPID] = @MPID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_MATERIALPRODUCTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_MATERIALPRODUCTDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_NOTELoadByPrimaryKey] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_NOTELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_NOTELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_NOTELoadByPrimaryKey]
(
	@NoteKey int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[NoteKey], 
		[LinkType], 
		[LinkKey], 
		[SourceType], 
		[SourceKey], 
		[NoteText], 
		[CreateTime], 
		[CreateBy], 
		[ModifyTime], 
		[ModifyBy], 
		[IsDeleted]
	FROM [dbo].[NOTE]
	WHERE
		([NoteKey] = @NoteKey)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NOTELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_NOTELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_NOTELoadAll] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_NOTELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_NOTELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_NOTELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[NoteKey], 
		[LinkType], 
		[LinkKey], 
		[SourceType], 
		[SourceKey], 
		[NoteText], 
		[CreateTime], 
		[CreateBy], 
		[ModifyTime], 
		[ModifyBy], 
		[IsDeleted]
	FROM [dbo].[NOTE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NOTELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_NOTELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_NOTEUpdate] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_NOTEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_NOTEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_NOTEUpdate]
(
	@NoteKey int, 
	@LinkType varchar(50) = NULL, 
	@LinkKey int = NULL, 
	@SourceType varchar(50) = NULL, 
	@SourceKey int = NULL, 
	@NoteText varchar(MAX) = NULL, 
	@CreateTime datetime = NULL, 
	@CreateBy varchar(50) = NULL, 
	@ModifyTime datetime = NULL, 
	@ModifyBy varchar(50) = NULL, 
	@IsDeleted bit
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [NOTE]
	SET
		[LinkType] = @LinkType, 
		[LinkKey] = @LinkKey, 
		[SourceType] = @SourceType, 
		[SourceKey] = @SourceKey, 
		[NoteText] = @NoteText, 
		[CreateTime] = @CreateTime, 
		[CreateBy] = @CreateBy, 
		[ModifyTime] = @ModifyTime, 
		[ModifyBy] = @ModifyBy, 
		[IsDeleted] = @IsDeleted
	WHERE
		([NoteKey] = @NoteKey)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NOTEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_NOTEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_NOTEInsert] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_NOTEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_NOTEInsert];
GO

CREATE PROCEDURE [dbo].[proc_NOTEInsert]
(
	@NoteKey int = NULL OUTPUT, 
	@LinkType varchar(50) = NULL, 
	@LinkKey int = NULL, 
	@SourceType varchar(50) = NULL, 
	@SourceKey int = NULL, 
	@NoteText varchar(MAX) = NULL, 
	@CreateTime datetime = NULL, 
	@CreateBy varchar(50) = NULL, 
	@ModifyTime datetime = NULL, 
	@ModifyBy varchar(50) = NULL, 
	@IsDeleted bit
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [NOTE]
	(
		[LinkType], 
		[LinkKey], 
		[SourceType], 
		[SourceKey], 
		[NoteText], 
		[CreateTime], 
		[CreateBy], 
		[ModifyTime], 
		[ModifyBy], 
		[IsDeleted]
	)
	
	VALUES
	(
		@LinkType, 
		@LinkKey, 
		@SourceType, 
		@SourceKey, 
		@NoteText, 
		@CreateTime, 
		@CreateBy, 
		@ModifyTime, 
		@ModifyBy, 
		@IsDeleted
	)

	SET @Err = @@Error

		
	SELECT @NoteKey = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NOTEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_NOTEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_NOTEDelete] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_NOTEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_NOTEDelete];
GO

CREATE PROCEDURE [dbo].[proc_NOTEDelete]
(
	@NoteKey int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[NOTE]
	WHERE
		([NoteKey] = @NoteKey)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NOTEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_NOTEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_POLoadByPrimaryKey] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_POLoadByPrimaryKey]
(
	@PONUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PONUMBER], 
		[VENDORID], 
		[PODATE], 
		[POTYPE], 
		[POTERMS], 
		[POSTATUS], 
		[CHANGEABLEPONUMBER], 
		[SHIPNAME], 
		[SHIPADDRESS1], 
		[SHIPADDRESS2], 
		[SHIPCITY], 
		[SHIPSTATE], 
		[SHIPZIP], 
		[SHIPCONTACT], 
		[SHIPPHONE], 
		[POSUBTOTAL], 
		[POSALESTAX], 
		[POFREIGHTIN], 
		[POTOTAL], 
		[INSTRUCTIONS], 
		[CUSTID], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	FROM [dbo].[PO]
	WHERE
		([PONUMBER] = @PONUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_POLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_POLoadAll] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_POLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PONUMBER], 
		[VENDORID], 
		[PODATE], 
		[POTYPE], 
		[POTERMS], 
		[POSTATUS], 
		[CHANGEABLEPONUMBER], 
		[SHIPNAME], 
		[SHIPADDRESS1], 
		[SHIPADDRESS2], 
		[SHIPCITY], 
		[SHIPSTATE], 
		[SHIPZIP], 
		[SHIPCONTACT], 
		[SHIPPHONE], 
		[POSUBTOTAL], 
		[POSALESTAX], 
		[POFREIGHTIN], 
		[POTOTAL], 
		[INSTRUCTIONS], 
		[CUSTID], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	FROM [dbo].[PO]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_POLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_POUpdate] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POUpdate];
GO

CREATE PROCEDURE [dbo].[proc_POUpdate]
(
	@PONUMBER int, 
	@VENDORID int = NULL, 
	@PODATE datetime = NULL, 
	@POTYPE varchar(24) = NULL, 
	@POTERMS varchar(50) = NULL, 
	@POSTATUS varchar(15) = NULL, 
	@CHANGEABLEPONUMBER varchar(50) = NULL, 
	@SHIPNAME varchar(50) = NULL, 
	@SHIPADDRESS1 varchar(50) = NULL, 
	@SHIPADDRESS2 varchar(50) = NULL, 
	@SHIPCITY varchar(50) = NULL, 
	@SHIPSTATE varchar(2) = NULL, 
	@SHIPZIP varchar(10) = NULL, 
	@SHIPCONTACT varchar(50) = NULL, 
	@SHIPPHONE varchar(20) = NULL, 
	@POSUBTOTAL money = NULL, 
	@POSALESTAX money = NULL, 
	@POFREIGHTIN money = NULL, 
	@POTOTAL money = NULL, 
	@INSTRUCTIONS varchar(MAX) = NULL, 
	@CUSTID int = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PO]
	SET
		[VENDORID] = @VENDORID, 
		[PODATE] = @PODATE, 
		[POTYPE] = @POTYPE, 
		[POTERMS] = @POTERMS, 
		[POSTATUS] = @POSTATUS, 
		[CHANGEABLEPONUMBER] = @CHANGEABLEPONUMBER, 
		[SHIPNAME] = @SHIPNAME, 
		[SHIPADDRESS1] = @SHIPADDRESS1, 
		[SHIPADDRESS2] = @SHIPADDRESS2, 
		[SHIPCITY] = @SHIPCITY, 
		[SHIPSTATE] = @SHIPSTATE, 
		[SHIPZIP] = @SHIPZIP, 
		[SHIPCONTACT] = @SHIPCONTACT, 
		[SHIPPHONE] = @SHIPPHONE, 
		[POSUBTOTAL] = @POSUBTOTAL, 
		[POSALESTAX] = @POSALESTAX, 
		[POFREIGHTIN] = @POFREIGHTIN, 
		[POTOTAL] = @POTOTAL, 
		[INSTRUCTIONS] = @INSTRUCTIONS, 
		[CUSTID] = @CUSTID, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME
	WHERE
		([PONUMBER] = @PONUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_POUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_POInsert] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POInsert];
GO

CREATE PROCEDURE [dbo].[proc_POInsert]
(
	@PONUMBER int = NULL OUTPUT, 
	@VENDORID int = NULL, 
	@PODATE datetime = NULL, 
	@POTYPE varchar(24) = NULL, 
	@POTERMS varchar(50) = NULL, 
	@POSTATUS varchar(15) = NULL, 
	@CHANGEABLEPONUMBER varchar(50) = NULL, 
	@SHIPNAME varchar(50) = NULL, 
	@SHIPADDRESS1 varchar(50) = NULL, 
	@SHIPADDRESS2 varchar(50) = NULL, 
	@SHIPCITY varchar(50) = NULL, 
	@SHIPSTATE varchar(2) = NULL, 
	@SHIPZIP varchar(10) = NULL, 
	@SHIPCONTACT varchar(50) = NULL, 
	@SHIPPHONE varchar(20) = NULL, 
	@POSUBTOTAL money = NULL, 
	@POSALESTAX money = NULL, 
	@POFREIGHTIN money = NULL, 
	@POTOTAL money = NULL, 
	@INSTRUCTIONS varchar(MAX) = NULL, 
	@CUSTID int = NULL, 
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
	INTO [PO]
	(
		[VENDORID], 
		[PODATE], 
		[POTYPE], 
		[POTERMS], 
		[POSTATUS], 
		[CHANGEABLEPONUMBER], 
		[SHIPNAME], 
		[SHIPADDRESS1], 
		[SHIPADDRESS2], 
		[SHIPCITY], 
		[SHIPSTATE], 
		[SHIPZIP], 
		[SHIPCONTACT], 
		[SHIPPHONE], 
		[POSUBTOTAL], 
		[POSALESTAX], 
		[POFREIGHTIN], 
		[POTOTAL], 
		[INSTRUCTIONS], 
		[CUSTID], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	)
	
	VALUES
	(
		@VENDORID, 
		@PODATE, 
		@POTYPE, 
		@POTERMS, 
		@POSTATUS, 
		@CHANGEABLEPONUMBER, 
		@SHIPNAME, 
		@SHIPADDRESS1, 
		@SHIPADDRESS2, 
		@SHIPCITY, 
		@SHIPSTATE, 
		@SHIPZIP, 
		@SHIPCONTACT, 
		@SHIPPHONE, 
		@POSUBTOTAL, 
		@POSALESTAX, 
		@POFREIGHTIN, 
		@POTOTAL, 
		@INSTRUCTIONS, 
		@CUSTID, 
		@CREATEDBY, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME
	)

	SET @Err = @@Error

		
	SELECT @PONUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_POInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PODelete] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PODelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PODelete];
GO

CREATE PROCEDURE [dbo].[proc_PODelete]
(
	@PONUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PO]
	WHERE
		([PONUMBER] = @PONUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PODelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PODelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_POITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_POITEMLoadByPrimaryKey]
(
	@POITEMNUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[POITEMNUMBER], 
		[PONUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYORDERED], 
		[QTYRELEASED], 
		[QTYRECEIVED], 
		[QTYCANCELED], 
		[VENDORITEMNUMBER], 
		[UNITCOST], 
		[EXTCOST], 
		[UOM], 
		[CONTAINER], 
		[UNITORCONTAINER], 
		[UNITS], 
		[EXPECTEDDELIVERY]
	FROM [dbo].[POITEM]
	WHERE
		([POITEMNUMBER] = @POITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_POITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_POITEMLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_POITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[POITEMNUMBER], 
		[PONUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYORDERED], 
		[QTYRELEASED], 
		[QTYRECEIVED], 
		[QTYCANCELED], 
		[VENDORITEMNUMBER], 
		[UNITCOST], 
		[EXTCOST], 
		[UOM], 
		[CONTAINER], 
		[UNITORCONTAINER], 
		[UNITS], 
		[EXPECTEDDELIVERY]
	FROM [dbo].[POITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_POITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_POITEMUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_POITEMUpdate]
(
	@POITEMNUMBER int, 
	@PONUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(150) = NULL, 
	@QTYORDERED numeric(18,4) = NULL, 
	@QTYRELEASED numeric(18,4) = NULL, 
	@QTYRECEIVED numeric(18,4) = NULL, 
	@QTYCANCELED numeric(18,4) = NULL, 
	@VENDORITEMNUMBER varchar(50) = NULL, 
	@UNITCOST money = NULL, 
	@EXTCOST money = NULL, 
	@UOM varchar(8) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITORCONTAINER varchar(1) = NULL, 
	@UNITS int = NULL, 
	@EXPECTEDDELIVERY datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [POITEM]
	SET
		[PONUMBER] = @PONUMBER, 
		[PRODUCTID] = @PRODUCTID, 
		[PRODUCTDESC] = @PRODUCTDESC, 
		[QTYORDERED] = @QTYORDERED, 
		[QTYRELEASED] = @QTYRELEASED, 
		[QTYRECEIVED] = @QTYRECEIVED, 
		[QTYCANCELED] = @QTYCANCELED, 
		[VENDORITEMNUMBER] = @VENDORITEMNUMBER, 
		[UNITCOST] = @UNITCOST, 
		[EXTCOST] = @EXTCOST, 
		[UOM] = @UOM, 
		[CONTAINER] = @CONTAINER, 
		[UNITORCONTAINER] = @UNITORCONTAINER, 
		[UNITS] = @UNITS, 
		[EXPECTEDDELIVERY] = @EXPECTEDDELIVERY
	WHERE
		([POITEMNUMBER] = @POITEMNUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_POITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_POITEMInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_POITEMInsert]
(
	@POITEMNUMBER int = NULL OUTPUT, 
	@PONUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(150) = NULL, 
	@QTYORDERED numeric(18,4) = NULL, 
	@QTYRELEASED numeric(18,4) = NULL, 
	@QTYRECEIVED numeric(18,4) = NULL, 
	@QTYCANCELED numeric(18,4) = NULL, 
	@VENDORITEMNUMBER varchar(50) = NULL, 
	@UNITCOST money = NULL, 
	@EXTCOST money = NULL, 
	@UOM varchar(8) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITORCONTAINER varchar(1) = NULL, 
	@UNITS int = NULL, 
	@EXPECTEDDELIVERY datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [POITEM]
	(
		[PONUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYORDERED], 
		[QTYRELEASED], 
		[QTYRECEIVED], 
		[QTYCANCELED], 
		[VENDORITEMNUMBER], 
		[UNITCOST], 
		[EXTCOST], 
		[UOM], 
		[CONTAINER], 
		[UNITORCONTAINER], 
		[UNITS], 
		[EXPECTEDDELIVERY]
	)
	
	VALUES
	(
		@PONUMBER, 
		@PRODUCTID, 
		@PRODUCTDESC, 
		@QTYORDERED, 
		@QTYRELEASED, 
		@QTYRECEIVED, 
		@QTYCANCELED, 
		@VENDORITEMNUMBER, 
		@UNITCOST, 
		@EXTCOST, 
		@UOM, 
		@CONTAINER, 
		@UNITORCONTAINER, 
		@UNITS, 
		@EXPECTEDDELIVERY
	)

	SET @Err = @@Error

		
	SELECT @POITEMNUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_POITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_POITEMDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_POITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_POITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_POITEMDelete]
(
	@POITEMNUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[POITEM]
	WHERE
		([POITEMNUMBER] = @POITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_POITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_POITEMDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PRICELISTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRICELISTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRICELISTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PRICELISTLoadByPrimaryKey]
(
	@PRICELISTID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRICELISTID], 
		[CUSTID], 
		[PRODUCTID], 
		[UNITS], 
		[CONTAINER], 
		[UNITPRICE], 
		[UOM], 
		[UNITORCONTAINER], 
		[EFFECTIVEDATE], 
		[TAXABLE], 
		[CONTAINERPRICE], 
		[CUSTOMERPRODUCTCODE]
	FROM [dbo].[PRICELIST]
	WHERE
		([PRICELISTID] = @PRICELISTID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRICELISTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRICELISTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRICELISTLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRICELISTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRICELISTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PRICELISTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRICELISTID], 
		[CUSTID], 
		[PRODUCTID], 
		[UNITS], 
		[CONTAINER], 
		[UNITPRICE], 
		[UOM], 
		[UNITORCONTAINER], 
		[EFFECTIVEDATE], 
		[TAXABLE], 
		[CONTAINERPRICE], 
		[CUSTOMERPRODUCTCODE]
	FROM [dbo].[PRICELIST]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRICELISTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRICELISTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRICELISTUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRICELISTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRICELISTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PRICELISTUpdate]
(
	@PRICELISTID int, 
	@CUSTID int = NULL, 
	@PRODUCTID int = NULL, 
	@UNITS numeric(18,4) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITPRICE money = NULL, 
	@UOM varchar(50) = NULL, 
	@UNITORCONTAINER varchar(1) = NULL, 
	@EFFECTIVEDATE datetime = NULL, 
	@TAXABLE bit = NULL, 
	@CONTAINERPRICE money = NULL, 
	@CUSTOMERPRODUCTCODE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PRICELIST]
	SET
		[CUSTID] = @CUSTID, 
		[PRODUCTID] = @PRODUCTID, 
		[UNITS] = @UNITS, 
		[CONTAINER] = @CONTAINER, 
		[UNITPRICE] = @UNITPRICE, 
		[UOM] = @UOM, 
		[UNITORCONTAINER] = @UNITORCONTAINER, 
		[EFFECTIVEDATE] = @EFFECTIVEDATE, 
		[TAXABLE] = @TAXABLE, 
		[CONTAINERPRICE] = @CONTAINERPRICE, 
		[CUSTOMERPRODUCTCODE] = @CUSTOMERPRODUCTCODE
	WHERE
		([PRICELISTID] = @PRICELISTID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRICELISTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRICELISTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRICELISTInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRICELISTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRICELISTInsert];
GO

CREATE PROCEDURE [dbo].[proc_PRICELISTInsert]
(
	@PRICELISTID int = NULL OUTPUT, 
	@CUSTID int = NULL, 
	@PRODUCTID int = NULL, 
	@UNITS numeric(18,4) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@UNITPRICE money = NULL, 
	@UOM varchar(50) = NULL, 
	@UNITORCONTAINER varchar(1) = NULL, 
	@EFFECTIVEDATE datetime = NULL, 
	@TAXABLE bit = NULL, 
	@CONTAINERPRICE money = NULL, 
	@CUSTOMERPRODUCTCODE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PRICELIST]
	(
		[CUSTID], 
		[PRODUCTID], 
		[UNITS], 
		[CONTAINER], 
		[UNITPRICE], 
		[UOM], 
		[UNITORCONTAINER], 
		[EFFECTIVEDATE], 
		[TAXABLE], 
		[CONTAINERPRICE], 
		[CUSTOMERPRODUCTCODE]
	)
	
	VALUES
	(
		@CUSTID, 
		@PRODUCTID, 
		@UNITS, 
		@CONTAINER, 
		@UNITPRICE, 
		@UOM, 
		@UNITORCONTAINER, 
		@EFFECTIVEDATE, 
		@TAXABLE, 
		@CONTAINERPRICE, 
		@CUSTOMERPRODUCTCODE
	)

	SET @Err = @@Error

		
	SELECT @PRICELISTID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRICELISTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRICELISTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRICELISTDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRICELISTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRICELISTDelete];
GO

CREATE PROCEDURE [dbo].[proc_PRICELISTDelete]
(
	@PRICELISTID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PRICELIST]
	WHERE
		([PRICELISTID] = @PRICELISTID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRICELISTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRICELISTDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PRODITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PRODITEMLoadByPrimaryKey]
(
	@PRODITEMNUM int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODITEMNUM], 
		[PRODORDERNUM], 
		[MATERIALID], 
		[APISNUM], 
		[UOM], 
		[QTY], 
		[ISCOMPLETE]
	FROM [dbo].[PRODITEM]
	WHERE
		([PRODITEMNUM] = @PRODITEMNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODITEMLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PRODITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODITEMNUM], 
		[PRODORDERNUM], 
		[MATERIALID], 
		[APISNUM], 
		[UOM], 
		[QTY], 
		[ISCOMPLETE]
	FROM [dbo].[PRODITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODITEMUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PRODITEMUpdate]
(
	@PRODITEMNUM int, 
	@PRODORDERNUM int = NULL, 
	@MATERIALID int = NULL, 
	@APISNUM int = NULL, 
	@UOM varchar(50) = NULL, 
	@QTY float = NULL, 
	@ISCOMPLETE bit
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PRODITEM]
	SET
		[PRODORDERNUM] = @PRODORDERNUM, 
		[MATERIALID] = @MATERIALID, 
		[APISNUM] = @APISNUM, 
		[UOM] = @UOM, 
		[QTY] = @QTY, 
		[ISCOMPLETE] = @ISCOMPLETE
	WHERE
		([PRODITEMNUM] = @PRODITEMNUM)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODITEMInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_PRODITEMInsert]
(
	@PRODITEMNUM int = NULL OUTPUT, 
	@PRODORDERNUM int = NULL, 
	@MATERIALID int = NULL, 
	@APISNUM int = NULL, 
	@UOM varchar(50) = NULL, 
	@QTY float = NULL, 
	@ISCOMPLETE bit
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PRODITEM]
	(
		[PRODORDERNUM], 
		[MATERIALID], 
		[APISNUM], 
		[UOM], 
		[QTY], 
		[ISCOMPLETE]
	)
	
	VALUES
	(
		@PRODORDERNUM, 
		@MATERIALID, 
		@APISNUM, 
		@UOM, 
		@QTY, 
		@ISCOMPLETE
	)

	SET @Err = @@Error

		
	SELECT @PRODITEMNUM = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODITEMDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_PRODITEMDelete]
(
	@PRODITEMNUM int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PRODITEM]
	WHERE
		([PRODITEMNUM] = @PRODITEMNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODITEMDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PRODNOTELoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODNOTELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODNOTELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PRODNOTELoadByPrimaryKey]
(
	@PRODNOTENUM int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODNOTENUM], 
		[PRODORDERNUM], 
		[SEQUENCE], 
		[PRODNOTE]
	FROM [dbo].[PRODNOTE]
	WHERE
		([PRODNOTENUM] = @PRODNOTENUM)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODNOTELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODNOTELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODNOTELoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODNOTELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODNOTELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PRODNOTELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODNOTENUM], 
		[PRODORDERNUM], 
		[SEQUENCE], 
		[PRODNOTE]
	FROM [dbo].[PRODNOTE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODNOTELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODNOTELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODNOTEUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODNOTEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODNOTEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PRODNOTEUpdate]
(
	@PRODNOTENUM int, 
	@PRODORDERNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@PRODNOTE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PRODNOTE]
	SET
		[PRODORDERNUM] = @PRODORDERNUM, 
		[SEQUENCE] = @SEQUENCE, 
		[PRODNOTE] = @PRODNOTE
	WHERE
		([PRODNOTENUM] = @PRODNOTENUM)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODNOTEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODNOTEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODNOTEInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODNOTEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODNOTEInsert];
GO

CREATE PROCEDURE [dbo].[proc_PRODNOTEInsert]
(
	@PRODNOTENUM int = NULL OUTPUT, 
	@PRODORDERNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@PRODNOTE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PRODNOTE]
	(
		[PRODORDERNUM], 
		[SEQUENCE], 
		[PRODNOTE]
	)
	
	VALUES
	(
		@PRODORDERNUM, 
		@SEQUENCE, 
		@PRODNOTE
	)

	SET @Err = @@Error

		
	SELECT @PRODNOTENUM = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODNOTEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODNOTEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODNOTEDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODNOTEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODNOTEDelete];
GO

CREATE PROCEDURE [dbo].[proc_PRODNOTEDelete]
(
	@PRODNOTENUM int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PRODNOTE]
	WHERE
		([PRODNOTENUM] = @PRODNOTENUM)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODNOTEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODNOTEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PRODORDERLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODORDERLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODORDERLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PRODORDERLoadByPrimaryKey]
(
	@PRODORDERNUM int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODORDERNUM], 
		[PRODORDERDATE], 
		[CREATEDBY], 
		[PRODUCTID], 
		[PRODUCTQTY], 
		[APISNUM], 
		[CUSTID], 
		[LOTNUMBER], 
		[NEEDEDBY], 
		[ISCOMPLETE], 
		[UNITCOST], 
		[WORKORDERNUMBER], 
		[COMPLETIONTIME], 
		[WORKORDERITEMNUMBER], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[WAREHOUSEID]
	FROM [dbo].[PRODORDER]
	WHERE
		([PRODORDERNUM] = @PRODORDERNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODORDERLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODORDERLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODORDERLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODORDERLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODORDERLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PRODORDERLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODORDERNUM], 
		[PRODORDERDATE], 
		[CREATEDBY], 
		[PRODUCTID], 
		[PRODUCTQTY], 
		[APISNUM], 
		[CUSTID], 
		[LOTNUMBER], 
		[NEEDEDBY], 
		[ISCOMPLETE], 
		[UNITCOST], 
		[WORKORDERNUMBER], 
		[COMPLETIONTIME], 
		[WORKORDERITEMNUMBER], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[WAREHOUSEID]
	FROM [dbo].[PRODORDER]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODORDERLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODORDERLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODORDERUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODORDERUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODORDERUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PRODORDERUpdate]
(
	@PRODORDERNUM int, 
	@PRODORDERDATE datetime = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTQTY int = NULL, 
	@APISNUM int = NULL, 
	@CUSTID int = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@NEEDEDBY datetime = NULL, 
	@ISCOMPLETE bit, 
	@UNITCOST money = NULL, 
	@WORKORDERNUMBER int = NULL, 
	@COMPLETIONTIME datetime = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@WAREHOUSEID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PRODORDER]
	SET
		[PRODORDERDATE] = @PRODORDERDATE, 
		[CREATEDBY] = @CREATEDBY, 
		[PRODUCTID] = @PRODUCTID, 
		[PRODUCTQTY] = @PRODUCTQTY, 
		[APISNUM] = @APISNUM, 
		[CUSTID] = @CUSTID, 
		[LOTNUMBER] = @LOTNUMBER, 
		[NEEDEDBY] = @NEEDEDBY, 
		[ISCOMPLETE] = @ISCOMPLETE, 
		[UNITCOST] = @UNITCOST, 
		[WORKORDERNUMBER] = @WORKORDERNUMBER, 
		[COMPLETIONTIME] = @COMPLETIONTIME, 
		[WORKORDERITEMNUMBER] = @WORKORDERITEMNUMBER, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME, 
		[WAREHOUSEID] = @WAREHOUSEID
	WHERE
		([PRODORDERNUM] = @PRODORDERNUM)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODORDERUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODORDERUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODORDERInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODORDERInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODORDERInsert];
GO

CREATE PROCEDURE [dbo].[proc_PRODORDERInsert]
(
	@PRODORDERNUM int = NULL OUTPUT, 
	@PRODORDERDATE datetime = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTQTY int = NULL, 
	@APISNUM int = NULL, 
	@CUSTID int = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@NEEDEDBY datetime = NULL, 
	@ISCOMPLETE bit, 
	@UNITCOST money = NULL, 
	@WORKORDERNUMBER int = NULL, 
	@COMPLETIONTIME datetime = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@WAREHOUSEID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PRODORDER]
	(
		[PRODORDERDATE], 
		[CREATEDBY], 
		[PRODUCTID], 
		[PRODUCTQTY], 
		[APISNUM], 
		[CUSTID], 
		[LOTNUMBER], 
		[NEEDEDBY], 
		[ISCOMPLETE], 
		[UNITCOST], 
		[WORKORDERNUMBER], 
		[COMPLETIONTIME], 
		[WORKORDERITEMNUMBER], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[WAREHOUSEID]
	)
	
	VALUES
	(
		@PRODORDERDATE, 
		@CREATEDBY, 
		@PRODUCTID, 
		@PRODUCTQTY, 
		@APISNUM, 
		@CUSTID, 
		@LOTNUMBER, 
		@NEEDEDBY, 
		@ISCOMPLETE, 
		@UNITCOST, 
		@WORKORDERNUMBER, 
		@COMPLETIONTIME, 
		@WORKORDERITEMNUMBER, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME, 
		@WAREHOUSEID
	)

	SET @Err = @@Error

		
	SELECT @PRODORDERNUM = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODORDERInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODORDERInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODORDERDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODORDERDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODORDERDelete];
GO

CREATE PROCEDURE [dbo].[proc_PRODORDERDelete]
(
	@PRODORDERNUM int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PRODORDER]
	WHERE
		([PRODORDERNUM] = @PRODORDERNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODORDERDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODORDERDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PRODPROCEDURELoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODPROCEDURELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODPROCEDURELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PRODPROCEDURELoadByPrimaryKey]
(
	@PRODPROCNUM int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODPROCNUM], 
		[PRODORDERNUM], 
		[SEQUENCE], 
		[PRODPROCEDURE]
	FROM [dbo].[PRODPROCEDURE]
	WHERE
		([PRODPROCNUM] = @PRODPROCNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODPROCEDURELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODPROCEDURELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODPROCEDURELoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODPROCEDURELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODPROCEDURELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PRODPROCEDURELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODPROCNUM], 
		[PRODORDERNUM], 
		[SEQUENCE], 
		[PRODPROCEDURE]
	FROM [dbo].[PRODPROCEDURE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODPROCEDURELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODPROCEDURELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODPROCEDUREUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODPROCEDUREUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODPROCEDUREUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PRODPROCEDUREUpdate]
(
	@PRODPROCNUM int, 
	@PRODORDERNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@PRODPROCEDURE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PRODPROCEDURE]
	SET
		[PRODORDERNUM] = @PRODORDERNUM, 
		[SEQUENCE] = @SEQUENCE, 
		[PRODPROCEDURE] = @PRODPROCEDURE
	WHERE
		([PRODPROCNUM] = @PRODPROCNUM)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODPROCEDUREUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODPROCEDUREUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODPROCEDUREInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODPROCEDUREInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODPROCEDUREInsert];
GO

CREATE PROCEDURE [dbo].[proc_PRODPROCEDUREInsert]
(
	@PRODPROCNUM int = NULL OUTPUT, 
	@PRODORDERNUM int = NULL, 
	@SEQUENCE int = NULL, 
	@PRODPROCEDURE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PRODPROCEDURE]
	(
		[PRODORDERNUM], 
		[SEQUENCE], 
		[PRODPROCEDURE]
	)
	
	VALUES
	(
		@PRODORDERNUM, 
		@SEQUENCE, 
		@PRODPROCEDURE
	)

	SET @Err = @@Error

		
	SELECT @PRODPROCNUM = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODPROCEDUREInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODPROCEDUREInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODPROCEDUREDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODPROCEDUREDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODPROCEDUREDelete];
GO

CREATE PROCEDURE [dbo].[proc_PRODPROCEDUREDelete]
(
	@PRODPROCNUM int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PRODPROCEDURE]
	WHERE
		([PRODPROCNUM] = @PRODPROCNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODPROCEDUREDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODPROCEDUREDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PRODTIMELoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODTIMELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODTIMELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PRODTIMELoadByPrimaryKey]
(
	@RecID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[ProdOrderNum], 
		[Who], 
		[Starttime], 
		[Endtime], 
		[LaborHrs], 
		[Completed]
	FROM [dbo].[PRODTIME]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODTIMELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODTIMELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODTIMELoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODTIMELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODTIMELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PRODTIMELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[ProdOrderNum], 
		[Who], 
		[Starttime], 
		[Endtime], 
		[LaborHrs], 
		[Completed]
	FROM [dbo].[PRODTIME]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODTIMELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODTIMELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODTIMEUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODTIMEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODTIMEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PRODTIMEUpdate]
(
	@RecID int, 
	@ProdOrderNum int, 
	@Who varchar(50), 
	@Starttime datetime, 
	@Endtime datetime, 
	@LaborHrs decimal(18,2), 
	@Completed bit
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PRODTIME]
	SET
		[ProdOrderNum] = @ProdOrderNum, 
		[Who] = @Who, 
		[Starttime] = @Starttime, 
		[Endtime] = @Endtime, 
		[LaborHrs] = @LaborHrs, 
		[Completed] = @Completed
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODTIMEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODTIMEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODTIMEInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODTIMEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODTIMEInsert];
GO

CREATE PROCEDURE [dbo].[proc_PRODTIMEInsert]
(
	@RecID int = NULL OUTPUT, 
	@ProdOrderNum int, 
	@Who varchar(50), 
	@Starttime datetime, 
	@Endtime datetime, 
	@LaborHrs decimal(18,2), 
	@Completed bit
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PRODTIME]
	(
		[ProdOrderNum], 
		[Who], 
		[Starttime], 
		[Endtime], 
		[LaborHrs], 
		[Completed]
	)
	
	VALUES
	(
		@ProdOrderNum, 
		@Who, 
		@Starttime, 
		@Endtime, 
		@LaborHrs, 
		@Completed
	)

	SET @Err = @@Error

		
	SELECT @RecID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODTIMEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODTIMEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODTIMEDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODTIMEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODTIMEDelete];
GO

CREATE PROCEDURE [dbo].[proc_PRODTIMEDelete]
(
	@RecID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PRODTIME]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODTIMEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODTIMEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PRODUCTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODUCTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODUCTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PRODUCTLoadByPrimaryKey]
(
	@PRODUCTID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODUCTID], 
		[PRODUCTDESC], 
		[STDWEIGHT], 
		[STDGALLONS], 
		[CONTAINER], 
		[HEALTH], 
		[FIRE], 
		[REACTIVITY], 
		[PERSONALPROTECTION], 
		[DOTDESC], 
		[HAZMATDESC], 
		[UNLINE], 
		[PLACARDREQUIRED], 
		[CLASSRATE], 
		[HAZMATID], 
		[QTYONHAND], 
		[QTYALLOCATED], 
		[QTYONORDER], 
		[QTYFORSALE], 
		[QTYMINONHAND], 
		[REORDERQTY], 
		[PREFERREDVENDORID], 
		[UNITCOST], 
		[DATECOSTLASTCHANGED], 
		[UNITS], 
		[UOM], 
		[DESC2], 
		[INVENTORYCLASS], 
		[ISACTIVE], 
		[CUSTID], 
		[ISLIQUID], 
		[RAWMATERIALGROUP], 
		[INVENTORYGROUPING], 
		[WEIGHTUOM], 
		[WEIGHTUNITS], 
		[VOLUMEUOM], 
		[VOLUMEUNITS], 
		[INVENTORYMETHOD], 
		[UNNUMBER], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[PHRANGELOW], 
		[PHRANGEHIGH], 
		[SGRANGELOW], 
		[SGRANGEHIGH], 
		[NEEDSTESTING], 
		[SHELFLIFE], 
		[HAZCLASSNUMBER], 
		[PACKAGEGROUP], 
		[CHEMICALID], 
		[IDNUMBER], 
		[STATE], 
		[ISINHAZOX], 
		[ISTOXIC], 
		[PRODUCTSTATUS]
	FROM [dbo].[PRODUCT]
	WHERE
		([PRODUCTID] = @PRODUCTID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODUCTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODUCTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODUCTLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODUCTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODUCTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PRODUCTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODUCTID], 
		[PRODUCTDESC], 
		[STDWEIGHT], 
		[STDGALLONS], 
		[CONTAINER], 
		[HEALTH], 
		[FIRE], 
		[REACTIVITY], 
		[PERSONALPROTECTION], 
		[DOTDESC], 
		[HAZMATDESC], 
		[UNLINE], 
		[PLACARDREQUIRED], 
		[CLASSRATE], 
		[HAZMATID], 
		[QTYONHAND], 
		[QTYALLOCATED], 
		[QTYONORDER], 
		[QTYFORSALE], 
		[QTYMINONHAND], 
		[REORDERQTY], 
		[PREFERREDVENDORID], 
		[UNITCOST], 
		[DATECOSTLASTCHANGED], 
		[UNITS], 
		[UOM], 
		[DESC2], 
		[INVENTORYCLASS], 
		[ISACTIVE], 
		[CUSTID], 
		[ISLIQUID], 
		[RAWMATERIALGROUP], 
		[INVENTORYGROUPING], 
		[WEIGHTUOM], 
		[WEIGHTUNITS], 
		[VOLUMEUOM], 
		[VOLUMEUNITS], 
		[INVENTORYMETHOD], 
		[UNNUMBER], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[PHRANGELOW], 
		[PHRANGEHIGH], 
		[SGRANGELOW], 
		[SGRANGEHIGH], 
		[NEEDSTESTING], 
		[SHELFLIFE], 
		[HAZCLASSNUMBER], 
		[PACKAGEGROUP], 
		[CHEMICALID], 
		[IDNUMBER], 
		[STATE], 
		[ISINHAZOX], 
		[ISTOXIC], 
		[PRODUCTSTATUS]
	FROM [dbo].[PRODUCT]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODUCTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODUCTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODUCTUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODUCTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODUCTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PRODUCTUpdate]
(
	@PRODUCTID int, 
	@PRODUCTDESC varchar(200) = NULL, 
	@STDWEIGHT int = NULL, 
	@STDGALLONS int = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@HEALTH int = NULL, 
	@FIRE int = NULL, 
	@REACTIVITY int = NULL, 
	@PERSONALPROTECTION varchar(3) = NULL, 
	@DOTDESC varchar(200) = NULL, 
	@HAZMATDESC varchar(200) = NULL, 
	@UNLINE varchar(200) = NULL, 
	@PLACARDREQUIRED varchar(50) = NULL, 
	@CLASSRATE varchar(50) = NULL, 
	@HAZMATID int = NULL, 
	@QTYONHAND int = NULL, 
	@QTYALLOCATED int = NULL, 
	@QTYONORDER int = NULL, 
	@QTYFORSALE int = NULL, 
	@QTYMINONHAND int = NULL, 
	@REORDERQTY int = NULL, 
	@PREFERREDVENDORID int = NULL, 
	@UNITCOST money = NULL, 
	@DATECOSTLASTCHANGED datetime = NULL, 
	@UNITS int = NULL, 
	@UOM varchar(50) = NULL, 
	@DESC2 varchar(50) = NULL, 
	@INVENTORYCLASS int = NULL, 
	@ISACTIVE bit = NULL, 
	@CUSTID int = NULL, 
	@ISLIQUID bit = NULL, 
	@RAWMATERIALGROUP varchar(4) = NULL, 
	@INVENTORYGROUPING int = NULL, 
	@WEIGHTUOM varchar(50) = NULL, 
	@WEIGHTUNITS decimal(18,2) = NULL, 
	@VOLUMEUOM varchar(50) = NULL, 
	@VOLUMEUNITS decimal(18,2) = NULL, 
	@INVENTORYMETHOD varchar(8) = NULL, 
	@UNNUMBER int = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@PHRANGELOW decimal(18,3) = NULL, 
	@PHRANGEHIGH decimal(18,3) = NULL, 
	@SGRANGELOW decimal(18,3) = NULL, 
	@SGRANGEHIGH decimal(18,3) = NULL, 
	@NEEDSTESTING bit, 
	@SHELFLIFE varchar(50) = NULL, 
	@HAZCLASSNUMBER varchar(50) = NULL, 
	@PACKAGEGROUP varchar(50) = NULL, 
	@CHEMICALID int = NULL, 
	@IDNUMBER varchar(50) = NULL, 
	@STATE varchar(50) = NULL, 
	@ISINHAZOX bit, 
	@ISTOXIC bit, 
	@PRODUCTSTATUS varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PRODUCT]
	SET
		[PRODUCTDESC] = @PRODUCTDESC, 
		[STDWEIGHT] = @STDWEIGHT, 
		[STDGALLONS] = @STDGALLONS, 
		[CONTAINER] = @CONTAINER, 
		[HEALTH] = @HEALTH, 
		[FIRE] = @FIRE, 
		[REACTIVITY] = @REACTIVITY, 
		[PERSONALPROTECTION] = @PERSONALPROTECTION, 
		[DOTDESC] = @DOTDESC, 
		[HAZMATDESC] = @HAZMATDESC, 
		[UNLINE] = @UNLINE, 
		[PLACARDREQUIRED] = @PLACARDREQUIRED, 
		[CLASSRATE] = @CLASSRATE, 
		[HAZMATID] = @HAZMATID, 
		[QTYONHAND] = @QTYONHAND, 
		[QTYALLOCATED] = @QTYALLOCATED, 
		[QTYONORDER] = @QTYONORDER, 
		[QTYFORSALE] = @QTYFORSALE, 
		[QTYMINONHAND] = @QTYMINONHAND, 
		[REORDERQTY] = @REORDERQTY, 
		[PREFERREDVENDORID] = @PREFERREDVENDORID, 
		[UNITCOST] = @UNITCOST, 
		[DATECOSTLASTCHANGED] = @DATECOSTLASTCHANGED, 
		[UNITS] = @UNITS, 
		[UOM] = @UOM, 
		[DESC2] = @DESC2, 
		[INVENTORYCLASS] = @INVENTORYCLASS, 
		[ISACTIVE] = @ISACTIVE, 
		[CUSTID] = @CUSTID, 
		[ISLIQUID] = @ISLIQUID, 
		[RAWMATERIALGROUP] = @RAWMATERIALGROUP, 
		[INVENTORYGROUPING] = @INVENTORYGROUPING, 
		[WEIGHTUOM] = @WEIGHTUOM, 
		[WEIGHTUNITS] = @WEIGHTUNITS, 
		[VOLUMEUOM] = @VOLUMEUOM, 
		[VOLUMEUNITS] = @VOLUMEUNITS, 
		[INVENTORYMETHOD] = @INVENTORYMETHOD, 
		[UNNUMBER] = @UNNUMBER, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME, 
		[PHRANGELOW] = @PHRANGELOW, 
		[PHRANGEHIGH] = @PHRANGEHIGH, 
		[SGRANGELOW] = @SGRANGELOW, 
		[SGRANGEHIGH] = @SGRANGEHIGH, 
		[NEEDSTESTING] = @NEEDSTESTING, 
		[SHELFLIFE] = @SHELFLIFE, 
		[HAZCLASSNUMBER] = @HAZCLASSNUMBER, 
		[PACKAGEGROUP] = @PACKAGEGROUP, 
		[CHEMICALID] = @CHEMICALID, 
		[IDNUMBER] = @IDNUMBER, 
		[STATE] = @STATE, 
		[ISINHAZOX] = @ISINHAZOX, 
		[ISTOXIC] = @ISTOXIC, 
		[PRODUCTSTATUS] = @PRODUCTSTATUS
	WHERE
		([PRODUCTID] = @PRODUCTID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODUCTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODUCTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODUCTInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODUCTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODUCTInsert];
GO

CREATE PROCEDURE [dbo].[proc_PRODUCTInsert]
(
	@PRODUCTID int = NULL OUTPUT, 
	@PRODUCTDESC varchar(200) = NULL, 
	@STDWEIGHT int = NULL, 
	@STDGALLONS int = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@HEALTH int = NULL, 
	@FIRE int = NULL, 
	@REACTIVITY int = NULL, 
	@PERSONALPROTECTION varchar(3) = NULL, 
	@DOTDESC varchar(200) = NULL, 
	@HAZMATDESC varchar(200) = NULL, 
	@UNLINE varchar(200) = NULL, 
	@PLACARDREQUIRED varchar(50) = NULL, 
	@CLASSRATE varchar(50) = NULL, 
	@HAZMATID int = NULL, 
	@QTYONHAND int = NULL, 
	@QTYALLOCATED int = NULL, 
	@QTYONORDER int = NULL, 
	@QTYFORSALE int = NULL, 
	@QTYMINONHAND int = NULL, 
	@REORDERQTY int = NULL, 
	@PREFERREDVENDORID int = NULL, 
	@UNITCOST money = NULL, 
	@DATECOSTLASTCHANGED datetime = NULL, 
	@UNITS int = NULL, 
	@UOM varchar(50) = NULL, 
	@DESC2 varchar(50) = NULL, 
	@INVENTORYCLASS int = NULL, 
	@ISACTIVE bit = NULL, 
	@CUSTID int = NULL, 
	@ISLIQUID bit = NULL, 
	@RAWMATERIALGROUP varchar(4) = NULL, 
	@INVENTORYGROUPING int = NULL, 
	@WEIGHTUOM varchar(50) = NULL, 
	@WEIGHTUNITS decimal(18,2) = NULL, 
	@VOLUMEUOM varchar(50) = NULL, 
	@VOLUMEUNITS decimal(18,2) = NULL, 
	@INVENTORYMETHOD varchar(8) = NULL, 
	@UNNUMBER int = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@PHRANGELOW decimal(18,3) = NULL, 
	@PHRANGEHIGH decimal(18,3) = NULL, 
	@SGRANGELOW decimal(18,3) = NULL, 
	@SGRANGEHIGH decimal(18,3) = NULL, 
	@NEEDSTESTING bit, 
	@SHELFLIFE varchar(50) = NULL, 
	@HAZCLASSNUMBER varchar(50) = NULL, 
	@PACKAGEGROUP varchar(50) = NULL, 
	@CHEMICALID int = NULL, 
	@IDNUMBER varchar(50) = NULL, 
	@STATE varchar(50) = NULL, 
	@ISINHAZOX bit, 
	@ISTOXIC bit, 
	@PRODUCTSTATUS varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PRODUCT]
	(
		[PRODUCTDESC], 
		[STDWEIGHT], 
		[STDGALLONS], 
		[CONTAINER], 
		[HEALTH], 
		[FIRE], 
		[REACTIVITY], 
		[PERSONALPROTECTION], 
		[DOTDESC], 
		[HAZMATDESC], 
		[UNLINE], 
		[PLACARDREQUIRED], 
		[CLASSRATE], 
		[HAZMATID], 
		[QTYONHAND], 
		[QTYALLOCATED], 
		[QTYONORDER], 
		[QTYFORSALE], 
		[QTYMINONHAND], 
		[REORDERQTY], 
		[PREFERREDVENDORID], 
		[UNITCOST], 
		[DATECOSTLASTCHANGED], 
		[UNITS], 
		[UOM], 
		[DESC2], 
		[INVENTORYCLASS], 
		[ISACTIVE], 
		[CUSTID], 
		[ISLIQUID], 
		[RAWMATERIALGROUP], 
		[INVENTORYGROUPING], 
		[WEIGHTUOM], 
		[WEIGHTUNITS], 
		[VOLUMEUOM], 
		[VOLUMEUNITS], 
		[INVENTORYMETHOD], 
		[UNNUMBER], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[PHRANGELOW], 
		[PHRANGEHIGH], 
		[SGRANGELOW], 
		[SGRANGEHIGH], 
		[NEEDSTESTING], 
		[SHELFLIFE], 
		[HAZCLASSNUMBER], 
		[PACKAGEGROUP], 
		[CHEMICALID], 
		[IDNUMBER], 
		[STATE], 
		[ISINHAZOX], 
		[ISTOXIC], 
		[PRODUCTSTATUS]
	)
	
	VALUES
	(
		@PRODUCTDESC, 
		@STDWEIGHT, 
		@STDGALLONS, 
		@CONTAINER, 
		@HEALTH, 
		@FIRE, 
		@REACTIVITY, 
		@PERSONALPROTECTION, 
		@DOTDESC, 
		@HAZMATDESC, 
		@UNLINE, 
		@PLACARDREQUIRED, 
		@CLASSRATE, 
		@HAZMATID, 
		@QTYONHAND, 
		@QTYALLOCATED, 
		@QTYONORDER, 
		@QTYFORSALE, 
		@QTYMINONHAND, 
		@REORDERQTY, 
		@PREFERREDVENDORID, 
		@UNITCOST, 
		@DATECOSTLASTCHANGED, 
		@UNITS, 
		@UOM, 
		@DESC2, 
		@INVENTORYCLASS, 
		@ISACTIVE, 
		@CUSTID, 
		@ISLIQUID, 
		@RAWMATERIALGROUP, 
		@INVENTORYGROUPING, 
		@WEIGHTUOM, 
		@WEIGHTUNITS, 
		@VOLUMEUOM, 
		@VOLUMEUNITS, 
		@INVENTORYMETHOD, 
		@UNNUMBER, 
		@CREATEDBY, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME, 
		@PHRANGELOW, 
		@PHRANGEHIGH, 
		@SGRANGELOW, 
		@SGRANGEHIGH, 
		@NEEDSTESTING, 
		@SHELFLIFE, 
		@HAZCLASSNUMBER, 
		@PACKAGEGROUP, 
		@CHEMICALID, 
		@IDNUMBER, 
		@STATE, 
		@ISINHAZOX, 
		@ISTOXIC, 
		@PRODUCTSTATUS
	)

	SET @Err = @@Error

		
	SELECT @PRODUCTID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODUCTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODUCTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODUCTDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODUCTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODUCTDelete];
GO

CREATE PROCEDURE [dbo].[proc_PRODUCTDelete]
(
	@PRODUCTID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PRODUCT]
	WHERE
		([PRODUCTID] = @PRODUCTID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODUCTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODUCTDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PRODUCTCOSTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODUCTCOSTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODUCTCOSTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PRODUCTCOSTLoadByPrimaryKey]
(
	@COSTRECID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COSTRECID], 
		[PRODUCTID], 
		[UOM], 
		[UNITS], 
		[UNITCOST], 
		[EFFECTIVEDATE], 
		[VENDORID], 
		[NOTES], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[VENDORITEMKEY], 
		[ISACTIVE]
	FROM [dbo].[PRODUCTCOST]
	WHERE
		([COSTRECID] = @COSTRECID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODUCTCOSTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODUCTCOSTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODUCTCOSTLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODUCTCOSTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODUCTCOSTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PRODUCTCOSTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[COSTRECID], 
		[PRODUCTID], 
		[UOM], 
		[UNITS], 
		[UNITCOST], 
		[EFFECTIVEDATE], 
		[VENDORID], 
		[NOTES], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[VENDORITEMKEY], 
		[ISACTIVE]
	FROM [dbo].[PRODUCTCOST]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODUCTCOSTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODUCTCOSTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODUCTCOSTUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODUCTCOSTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODUCTCOSTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PRODUCTCOSTUpdate]
(
	@COSTRECID int, 
	@PRODUCTID int = NULL, 
	@UOM varchar(50) = NULL, 
	@UNITS numeric(18,4) = NULL, 
	@UNITCOST money = NULL, 
	@EFFECTIVEDATE datetime = NULL, 
	@VENDORID int = NULL, 
	@NOTES varchar(MAX) = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@VENDORITEMKEY varchar(50) = NULL, 
	@ISACTIVE bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PRODUCTCOST]
	SET
		[PRODUCTID] = @PRODUCTID, 
		[UOM] = @UOM, 
		[UNITS] = @UNITS, 
		[UNITCOST] = @UNITCOST, 
		[EFFECTIVEDATE] = @EFFECTIVEDATE, 
		[VENDORID] = @VENDORID, 
		[NOTES] = @NOTES, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME, 
		[VENDORITEMKEY] = @VENDORITEMKEY, 
		[ISACTIVE] = @ISACTIVE
	WHERE
		([COSTRECID] = @COSTRECID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODUCTCOSTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODUCTCOSTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODUCTCOSTInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODUCTCOSTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODUCTCOSTInsert];
GO

CREATE PROCEDURE [dbo].[proc_PRODUCTCOSTInsert]
(
	@COSTRECID int = NULL OUTPUT, 
	@PRODUCTID int = NULL, 
	@UOM varchar(50) = NULL, 
	@UNITS numeric(18,4) = NULL, 
	@UNITCOST money = NULL, 
	@EFFECTIVEDATE datetime = NULL, 
	@VENDORID int = NULL, 
	@NOTES varchar(MAX) = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@VENDORITEMKEY varchar(50) = NULL, 
	@ISACTIVE bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PRODUCTCOST]
	(
		[PRODUCTID], 
		[UOM], 
		[UNITS], 
		[UNITCOST], 
		[EFFECTIVEDATE], 
		[VENDORID], 
		[NOTES], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[VENDORITEMKEY], 
		[ISACTIVE]
	)
	
	VALUES
	(
		@PRODUCTID, 
		@UOM, 
		@UNITS, 
		@UNITCOST, 
		@EFFECTIVEDATE, 
		@VENDORID, 
		@NOTES, 
		@CREATEDBY, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME, 
		@VENDORITEMKEY, 
		@ISACTIVE
	)

	SET @Err = @@Error

		
	SELECT @COSTRECID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODUCTCOSTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODUCTCOSTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODUCTCOSTDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODUCTCOSTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODUCTCOSTDelete];
GO

CREATE PROCEDURE [dbo].[proc_PRODUCTCOSTDelete]
(
	@COSTRECID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PRODUCTCOST]
	WHERE
		([COSTRECID] = @COSTRECID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODUCTCOSTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODUCTCOSTDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PURCHASEREQUESTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PURCHASEREQUESTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PURCHASEREQUESTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PURCHASEREQUESTLoadByPrimaryKey]
(
	@PurchReqID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PurchReqID], 
		[PurchReqDate], 
		[ProductID], 
		[QtyContainers], 
		[DateNeeded], 
		[PONumber], 
		[IsOrdered], 
		[CustID], 
		[VendorID], 
		[WorkOrderNumber], 
		[WorkOrderItemNumber], 
		[DateReceived], 
		[ReceiverItemNumber], 
		[ProdOrderNum], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	FROM [dbo].[PURCHASEREQUEST]
	WHERE
		([PurchReqID] = @PurchReqID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PURCHASEREQUESTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PURCHASEREQUESTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PURCHASEREQUESTLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PURCHASEREQUESTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PURCHASEREQUESTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PURCHASEREQUESTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PurchReqID], 
		[PurchReqDate], 
		[ProductID], 
		[QtyContainers], 
		[DateNeeded], 
		[PONumber], 
		[IsOrdered], 
		[CustID], 
		[VendorID], 
		[WorkOrderNumber], 
		[WorkOrderItemNumber], 
		[DateReceived], 
		[ReceiverItemNumber], 
		[ProdOrderNum], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	FROM [dbo].[PURCHASEREQUEST]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PURCHASEREQUESTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PURCHASEREQUESTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PURCHASEREQUESTUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PURCHASEREQUESTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PURCHASEREQUESTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PURCHASEREQUESTUpdate]
(
	@PurchReqID int, 
	@PurchReqDate datetime = NULL, 
	@ProductID int = NULL, 
	@QtyContainers int = NULL, 
	@DateNeeded datetime = NULL, 
	@PONumber int = NULL, 
	@IsOrdered int, 
	@CustID int = NULL, 
	@VendorID int = NULL, 
	@WorkOrderNumber int = NULL, 
	@WorkOrderItemNumber int = NULL, 
	@DateReceived datetime = NULL, 
	@ReceiverItemNumber int = NULL, 
	@ProdOrderNum int = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PURCHASEREQUEST]
	SET
		[PurchReqDate] = @PurchReqDate, 
		[ProductID] = @ProductID, 
		[QtyContainers] = @QtyContainers, 
		[DateNeeded] = @DateNeeded, 
		[PONumber] = @PONumber, 
		[IsOrdered] = @IsOrdered, 
		[CustID] = @CustID, 
		[VendorID] = @VendorID, 
		[WorkOrderNumber] = @WorkOrderNumber, 
		[WorkOrderItemNumber] = @WorkOrderItemNumber, 
		[DateReceived] = @DateReceived, 
		[ReceiverItemNumber] = @ReceiverItemNumber, 
		[ProdOrderNum] = @ProdOrderNum, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME
	WHERE
		([PurchReqID] = @PurchReqID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PURCHASEREQUESTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PURCHASEREQUESTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PURCHASEREQUESTInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PURCHASEREQUESTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PURCHASEREQUESTInsert];
GO

CREATE PROCEDURE [dbo].[proc_PURCHASEREQUESTInsert]
(
	@PurchReqID int = NULL OUTPUT, 
	@PurchReqDate datetime = NULL, 
	@ProductID int = NULL, 
	@QtyContainers int = NULL, 
	@DateNeeded datetime = NULL, 
	@PONumber int = NULL, 
	@IsOrdered int, 
	@CustID int = NULL, 
	@VendorID int = NULL, 
	@WorkOrderNumber int = NULL, 
	@WorkOrderItemNumber int = NULL, 
	@DateReceived datetime = NULL, 
	@ReceiverItemNumber int = NULL, 
	@ProdOrderNum int = NULL, 
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
	INTO [PURCHASEREQUEST]
	(
		[PurchReqDate], 
		[ProductID], 
		[QtyContainers], 
		[DateNeeded], 
		[PONumber], 
		[IsOrdered], 
		[CustID], 
		[VendorID], 
		[WorkOrderNumber], 
		[WorkOrderItemNumber], 
		[DateReceived], 
		[ReceiverItemNumber], 
		[ProdOrderNum], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	)
	
	VALUES
	(
		@PurchReqDate, 
		@ProductID, 
		@QtyContainers, 
		@DateNeeded, 
		@PONumber, 
		@IsOrdered, 
		@CustID, 
		@VendorID, 
		@WorkOrderNumber, 
		@WorkOrderItemNumber, 
		@DateReceived, 
		@ReceiverItemNumber, 
		@ProdOrderNum, 
		@CREATEDBY, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME
	)

	SET @Err = @@Error

		
	SELECT @PurchReqID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PURCHASEREQUESTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PURCHASEREQUESTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PURCHASEREQUESTDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PURCHASEREQUESTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PURCHASEREQUESTDelete];
GO

CREATE PROCEDURE [dbo].[proc_PURCHASEREQUESTDelete]
(
	@PurchReqID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PURCHASEREQUEST]
	WHERE
		([PurchReqID] = @PurchReqID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PURCHASEREQUESTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PURCHASEREQUESTDelete Error on Creation'
GO 


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


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_RECEIVERITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RECEIVERITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RECEIVERITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_RECEIVERITEMLoadByPrimaryKey]
(
	@RECEIVERITEMNUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECEIVERITEMNUMBER], 
		[RECEIVERNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYRECEIVED], 
		[CONTAINER], 
		[LOTNUMBER], 
		[WAREHOUSENUMBER], 
		[WAREHOUSELOCATION], 
		[POSTED], 
		[UNITCOST], 
		[UNITORCONTAINER], 
		[UNITS], 
		[UOM], 
		[INVENTORYCLASS]
	FROM [dbo].[RECEIVERITEM]
	WHERE
		([RECEIVERITEMNUMBER] = @RECEIVERITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RECEIVERITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_RECEIVERITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RECEIVERITEMLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RECEIVERITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RECEIVERITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_RECEIVERITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RECEIVERITEMNUMBER], 
		[RECEIVERNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYRECEIVED], 
		[CONTAINER], 
		[LOTNUMBER], 
		[WAREHOUSENUMBER], 
		[WAREHOUSELOCATION], 
		[POSTED], 
		[UNITCOST], 
		[UNITORCONTAINER], 
		[UNITS], 
		[UOM], 
		[INVENTORYCLASS]
	FROM [dbo].[RECEIVERITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RECEIVERITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_RECEIVERITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RECEIVERITEMUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RECEIVERITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RECEIVERITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_RECEIVERITEMUpdate]
(
	@RECEIVERITEMNUMBER int, 
	@RECEIVERNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QTYRECEIVED numeric(18,4) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@WAREHOUSENUMBER int = NULL, 
	@WAREHOUSELOCATION varchar(50) = NULL, 
	@POSTED varchar(1) = NULL, 
	@UNITCOST decimal(18,4) = NULL, 
	@UNITORCONTAINER varchar(1) = NULL, 
	@UNITS int = NULL, 
	@UOM varchar(24) = NULL, 
	@INVENTORYCLASS int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [RECEIVERITEM]
	SET
		[RECEIVERNUMBER] = @RECEIVERNUMBER, 
		[PRODUCTID] = @PRODUCTID, 
		[PRODUCTDESC] = @PRODUCTDESC, 
		[QTYRECEIVED] = @QTYRECEIVED, 
		[CONTAINER] = @CONTAINER, 
		[LOTNUMBER] = @LOTNUMBER, 
		[WAREHOUSENUMBER] = @WAREHOUSENUMBER, 
		[WAREHOUSELOCATION] = @WAREHOUSELOCATION, 
		[POSTED] = @POSTED, 
		[UNITCOST] = @UNITCOST, 
		[UNITORCONTAINER] = @UNITORCONTAINER, 
		[UNITS] = @UNITS, 
		[UOM] = @UOM, 
		[INVENTORYCLASS] = @INVENTORYCLASS
	WHERE
		([RECEIVERITEMNUMBER] = @RECEIVERITEMNUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RECEIVERITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_RECEIVERITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RECEIVERITEMInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RECEIVERITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RECEIVERITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_RECEIVERITEMInsert]
(
	@RECEIVERITEMNUMBER int = NULL OUTPUT, 
	@RECEIVERNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QTYRECEIVED numeric(18,4) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@WAREHOUSENUMBER int = NULL, 
	@WAREHOUSELOCATION varchar(50) = NULL, 
	@POSTED varchar(1) = NULL, 
	@UNITCOST decimal(18,4) = NULL, 
	@UNITORCONTAINER varchar(1) = NULL, 
	@UNITS int = NULL, 
	@UOM varchar(24) = NULL, 
	@INVENTORYCLASS int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [RECEIVERITEM]
	(
		[RECEIVERNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYRECEIVED], 
		[CONTAINER], 
		[LOTNUMBER], 
		[WAREHOUSENUMBER], 
		[WAREHOUSELOCATION], 
		[POSTED], 
		[UNITCOST], 
		[UNITORCONTAINER], 
		[UNITS], 
		[UOM], 
		[INVENTORYCLASS]
	)
	
	VALUES
	(
		@RECEIVERNUMBER, 
		@PRODUCTID, 
		@PRODUCTDESC, 
		@QTYRECEIVED, 
		@CONTAINER, 
		@LOTNUMBER, 
		@WAREHOUSENUMBER, 
		@WAREHOUSELOCATION, 
		@POSTED, 
		@UNITCOST, 
		@UNITORCONTAINER, 
		@UNITS, 
		@UOM, 
		@INVENTORYCLASS
	)

	SET @Err = @@Error

		
	SELECT @RECEIVERITEMNUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RECEIVERITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_RECEIVERITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RECEIVERITEMDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RECEIVERITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RECEIVERITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_RECEIVERITEMDelete]
(
	@RECEIVERITEMNUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[RECEIVERITEM]
	WHERE
		([RECEIVERITEMNUMBER] = @RECEIVERITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RECEIVERITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_RECEIVERITEMDelete Error on Creation'
GO 


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


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_RMAITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RMAITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RMAITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_RMAITEMLoadByPrimaryKey]
(
	@RMAITEMID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RMAITEMID], 
		[RMAID]
	FROM [dbo].[RMAITEM]
	WHERE
		([RMAITEMID] = @RMAITEMID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RMAITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_RMAITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RMAITEMLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RMAITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RMAITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_RMAITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RMAITEMID], 
		[RMAID]
	FROM [dbo].[RMAITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RMAITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_RMAITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RMAITEMUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RMAITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RMAITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_RMAITEMUpdate]
(
	@RMAITEMID int, 
	@RMAID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [RMAITEM]
	SET
		[RMAID] = @RMAID
	WHERE
		([RMAITEMID] = @RMAITEMID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RMAITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_RMAITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RMAITEMInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RMAITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RMAITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_RMAITEMInsert]
(
	@RMAITEMID int = NULL OUTPUT, 
	@RMAID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [RMAITEM]
	(
		[RMAID]
	)
	
	VALUES
	(
		@RMAID
	)

	SET @Err = @@Error

		
	SELECT @RMAITEMID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RMAITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_RMAITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_RMAITEMDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_RMAITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_RMAITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_RMAITEMDelete]
(
	@RMAITEMID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[RMAITEM]
	WHERE
		([RMAITEMID] = @RMAITEMID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_RMAITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_RMAITEMDelete Error on Creation'
GO 


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


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTLoadByPrimaryKey]
(
	@SHIPMENTNUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SHIPMENTNUMBER], 
		[SHIPMENTDATE], 
		[WORKORDERNUMBER], 
		[CUSTID], 
		[CUSTOMERNAME], 
		[SHIPFROMID], 
		[SHIPFROMNAME], 
		[SHIPFROMADDRESS1], 
		[SHIPFROMADDRESS2], 
		[SHIPFROMCITY], 
		[SHIPFROMSTATEPROV], 
		[SHIPFROMPOSTALCODE], 
		[SHIPFROMCOUNTRY], 
		[SHIPFROMPHONE], 
		[SHIPFROMFAX], 
		[SHIPFROMCONTACT], 
		[SHIPTOID], 
		[SHIPTONAME], 
		[SHIPTOADDRESS1], 
		[SHIPTOADDRESS2], 
		[SHIPTOCITY], 
		[SHIPTOSTATEPROV], 
		[SHIPTOPOSTALCODE], 
		[SHIPTOCOUNTRY], 
		[SHIPTOCONTACT], 
		[SHIPTOPHONE], 
		[CARRIERID], 
		[FREIGHTCARRIER], 
		[FOB], 
		[CUSTOMERPO], 
		[PLACARDSREQUIRED], 
		[PLACARDSSUPPLIED], 
		[SHIPMENTSTATUS], 
		[LOGISTICSID], 
		[COMMENTS], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	FROM [dbo].[SHIPMENT]
	WHERE
		([SHIPMENTNUMBER] = @SHIPMENTNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SHIPMENTNUMBER], 
		[SHIPMENTDATE], 
		[WORKORDERNUMBER], 
		[CUSTID], 
		[CUSTOMERNAME], 
		[SHIPFROMID], 
		[SHIPFROMNAME], 
		[SHIPFROMADDRESS1], 
		[SHIPFROMADDRESS2], 
		[SHIPFROMCITY], 
		[SHIPFROMSTATEPROV], 
		[SHIPFROMPOSTALCODE], 
		[SHIPFROMCOUNTRY], 
		[SHIPFROMPHONE], 
		[SHIPFROMFAX], 
		[SHIPFROMCONTACT], 
		[SHIPTOID], 
		[SHIPTONAME], 
		[SHIPTOADDRESS1], 
		[SHIPTOADDRESS2], 
		[SHIPTOCITY], 
		[SHIPTOSTATEPROV], 
		[SHIPTOPOSTALCODE], 
		[SHIPTOCOUNTRY], 
		[SHIPTOCONTACT], 
		[SHIPTOPHONE], 
		[CARRIERID], 
		[FREIGHTCARRIER], 
		[FOB], 
		[CUSTOMERPO], 
		[PLACARDSREQUIRED], 
		[PLACARDSSUPPLIED], 
		[SHIPMENTSTATUS], 
		[LOGISTICSID], 
		[COMMENTS], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	FROM [dbo].[SHIPMENT]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTUpdate];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTUpdate]
(
	@SHIPMENTNUMBER int, 
	@SHIPMENTDATE datetime = NULL, 
	@WORKORDERNUMBER int = NULL, 
	@CUSTID int = NULL, 
	@CUSTOMERNAME varchar(50) = NULL, 
	@SHIPFROMID int = NULL, 
	@SHIPFROMNAME varchar(50) = NULL, 
	@SHIPFROMADDRESS1 varchar(50) = NULL, 
	@SHIPFROMADDRESS2 varchar(50) = NULL, 
	@SHIPFROMCITY varchar(50) = NULL, 
	@SHIPFROMSTATEPROV varchar(50) = NULL, 
	@SHIPFROMPOSTALCODE varchar(24) = NULL, 
	@SHIPFROMCOUNTRY varchar(50) = NULL, 
	@SHIPFROMPHONE varchar(50) = NULL, 
	@SHIPFROMFAX varchar(50) = NULL, 
	@SHIPFROMCONTACT varchar(50) = NULL, 
	@SHIPTOID int = NULL, 
	@SHIPTONAME varchar(50) = NULL, 
	@SHIPTOADDRESS1 varchar(50) = NULL, 
	@SHIPTOADDRESS2 varchar(50) = NULL, 
	@SHIPTOCITY varchar(50) = NULL, 
	@SHIPTOSTATEPROV varchar(50) = NULL, 
	@SHIPTOPOSTALCODE varchar(24) = NULL, 
	@SHIPTOCOUNTRY varchar(50) = NULL, 
	@SHIPTOCONTACT varchar(50) = NULL, 
	@SHIPTOPHONE varchar(50) = NULL, 
	@CARRIERID int = NULL, 
	@FREIGHTCARRIER varchar(50) = NULL, 
	@FOB varchar(24) = NULL, 
	@CUSTOMERPO varchar(50) = NULL, 
	@PLACARDSREQUIRED varchar(50) = NULL, 
	@PLACARDSSUPPLIED varchar(3) = NULL, 
	@SHIPMENTSTATUS varchar(50) = NULL, 
	@LOGISTICSID int = NULL, 
	@COMMENTS varchar(MAX) = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [SHIPMENT]
	SET
		[SHIPMENTDATE] = @SHIPMENTDATE, 
		[WORKORDERNUMBER] = @WORKORDERNUMBER, 
		[CUSTID] = @CUSTID, 
		[CUSTOMERNAME] = @CUSTOMERNAME, 
		[SHIPFROMID] = @SHIPFROMID, 
		[SHIPFROMNAME] = @SHIPFROMNAME, 
		[SHIPFROMADDRESS1] = @SHIPFROMADDRESS1, 
		[SHIPFROMADDRESS2] = @SHIPFROMADDRESS2, 
		[SHIPFROMCITY] = @SHIPFROMCITY, 
		[SHIPFROMSTATEPROV] = @SHIPFROMSTATEPROV, 
		[SHIPFROMPOSTALCODE] = @SHIPFROMPOSTALCODE, 
		[SHIPFROMCOUNTRY] = @SHIPFROMCOUNTRY, 
		[SHIPFROMPHONE] = @SHIPFROMPHONE, 
		[SHIPFROMFAX] = @SHIPFROMFAX, 
		[SHIPFROMCONTACT] = @SHIPFROMCONTACT, 
		[SHIPTOID] = @SHIPTOID, 
		[SHIPTONAME] = @SHIPTONAME, 
		[SHIPTOADDRESS1] = @SHIPTOADDRESS1, 
		[SHIPTOADDRESS2] = @SHIPTOADDRESS2, 
		[SHIPTOCITY] = @SHIPTOCITY, 
		[SHIPTOSTATEPROV] = @SHIPTOSTATEPROV, 
		[SHIPTOPOSTALCODE] = @SHIPTOPOSTALCODE, 
		[SHIPTOCOUNTRY] = @SHIPTOCOUNTRY, 
		[SHIPTOCONTACT] = @SHIPTOCONTACT, 
		[SHIPTOPHONE] = @SHIPTOPHONE, 
		[CARRIERID] = @CARRIERID, 
		[FREIGHTCARRIER] = @FREIGHTCARRIER, 
		[FOB] = @FOB, 
		[CUSTOMERPO] = @CUSTOMERPO, 
		[PLACARDSREQUIRED] = @PLACARDSREQUIRED, 
		[PLACARDSSUPPLIED] = @PLACARDSSUPPLIED, 
		[SHIPMENTSTATUS] = @SHIPMENTSTATUS, 
		[LOGISTICSID] = @LOGISTICSID, 
		[COMMENTS] = @COMMENTS, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME
	WHERE
		([SHIPMENTNUMBER] = @SHIPMENTNUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTInsert];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTInsert]
(
	@SHIPMENTNUMBER int = NULL OUTPUT, 
	@SHIPMENTDATE datetime = NULL, 
	@WORKORDERNUMBER int = NULL, 
	@CUSTID int = NULL, 
	@CUSTOMERNAME varchar(50) = NULL, 
	@SHIPFROMID int = NULL, 
	@SHIPFROMNAME varchar(50) = NULL, 
	@SHIPFROMADDRESS1 varchar(50) = NULL, 
	@SHIPFROMADDRESS2 varchar(50) = NULL, 
	@SHIPFROMCITY varchar(50) = NULL, 
	@SHIPFROMSTATEPROV varchar(50) = NULL, 
	@SHIPFROMPOSTALCODE varchar(24) = NULL, 
	@SHIPFROMCOUNTRY varchar(50) = NULL, 
	@SHIPFROMPHONE varchar(50) = NULL, 
	@SHIPFROMFAX varchar(50) = NULL, 
	@SHIPFROMCONTACT varchar(50) = NULL, 
	@SHIPTOID int = NULL, 
	@SHIPTONAME varchar(50) = NULL, 
	@SHIPTOADDRESS1 varchar(50) = NULL, 
	@SHIPTOADDRESS2 varchar(50) = NULL, 
	@SHIPTOCITY varchar(50) = NULL, 
	@SHIPTOSTATEPROV varchar(50) = NULL, 
	@SHIPTOPOSTALCODE varchar(24) = NULL, 
	@SHIPTOCOUNTRY varchar(50) = NULL, 
	@SHIPTOCONTACT varchar(50) = NULL, 
	@SHIPTOPHONE varchar(50) = NULL, 
	@CARRIERID int = NULL, 
	@FREIGHTCARRIER varchar(50) = NULL, 
	@FOB varchar(24) = NULL, 
	@CUSTOMERPO varchar(50) = NULL, 
	@PLACARDSREQUIRED varchar(50) = NULL, 
	@PLACARDSSUPPLIED varchar(3) = NULL, 
	@SHIPMENTSTATUS varchar(50) = NULL, 
	@LOGISTICSID int = NULL, 
	@COMMENTS varchar(MAX) = NULL, 
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
	INTO [SHIPMENT]
	(
		[SHIPMENTDATE], 
		[WORKORDERNUMBER], 
		[CUSTID], 
		[CUSTOMERNAME], 
		[SHIPFROMID], 
		[SHIPFROMNAME], 
		[SHIPFROMADDRESS1], 
		[SHIPFROMADDRESS2], 
		[SHIPFROMCITY], 
		[SHIPFROMSTATEPROV], 
		[SHIPFROMPOSTALCODE], 
		[SHIPFROMCOUNTRY], 
		[SHIPFROMPHONE], 
		[SHIPFROMFAX], 
		[SHIPFROMCONTACT], 
		[SHIPTOID], 
		[SHIPTONAME], 
		[SHIPTOADDRESS1], 
		[SHIPTOADDRESS2], 
		[SHIPTOCITY], 
		[SHIPTOSTATEPROV], 
		[SHIPTOPOSTALCODE], 
		[SHIPTOCOUNTRY], 
		[SHIPTOCONTACT], 
		[SHIPTOPHONE], 
		[CARRIERID], 
		[FREIGHTCARRIER], 
		[FOB], 
		[CUSTOMERPO], 
		[PLACARDSREQUIRED], 
		[PLACARDSSUPPLIED], 
		[SHIPMENTSTATUS], 
		[LOGISTICSID], 
		[COMMENTS], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME]
	)
	
	VALUES
	(
		@SHIPMENTDATE, 
		@WORKORDERNUMBER, 
		@CUSTID, 
		@CUSTOMERNAME, 
		@SHIPFROMID, 
		@SHIPFROMNAME, 
		@SHIPFROMADDRESS1, 
		@SHIPFROMADDRESS2, 
		@SHIPFROMCITY, 
		@SHIPFROMSTATEPROV, 
		@SHIPFROMPOSTALCODE, 
		@SHIPFROMCOUNTRY, 
		@SHIPFROMPHONE, 
		@SHIPFROMFAX, 
		@SHIPFROMCONTACT, 
		@SHIPTOID, 
		@SHIPTONAME, 
		@SHIPTOADDRESS1, 
		@SHIPTOADDRESS2, 
		@SHIPTOCITY, 
		@SHIPTOSTATEPROV, 
		@SHIPTOPOSTALCODE, 
		@SHIPTOCOUNTRY, 
		@SHIPTOCONTACT, 
		@SHIPTOPHONE, 
		@CARRIERID, 
		@FREIGHTCARRIER, 
		@FOB, 
		@CUSTOMERPO, 
		@PLACARDSREQUIRED, 
		@PLACARDSSUPPLIED, 
		@SHIPMENTSTATUS, 
		@LOGISTICSID, 
		@COMMENTS, 
		@CREATEDBY, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME
	)

	SET @Err = @@Error

		
	SELECT @SHIPMENTNUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTDelete];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTDelete]
(
	@SHIPMENTNUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[SHIPMENT]
	WHERE
		([SHIPMENTNUMBER] = @SHIPMENTNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTDETAILLoadByPrimaryKey] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTDETAILLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTDETAILLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTDETAILLoadByPrimaryKey]
(
	@SHIPMENTDETAILID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SHIPMENTDETAILID], 
		[SHIPMENTNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYCONTAINERS], 
		[TOTALWEIGHT], 
		[BATCHNUMBER], 
		[STDWEIGHT], 
		[STDGALLONS], 
		[CONTAINER], 
		[DOTDESC], 
		[HAZMATDESC], 
		[UNLINE], 
		[CLASSRATE], 
		[LD1], 
		[LD2], 
		[LD3], 
		[BILLABLE], 
		[WORKORDERITEMNUMBER], 
		[ITEMTYPE]
	FROM [dbo].[SHIPMENTDETAIL]
	WHERE
		([SHIPMENTDETAILID] = @SHIPMENTDETAILID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTDETAILLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTDETAILLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTDETAILLoadAll] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTDETAILLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTDETAILLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTDETAILLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SHIPMENTDETAILID], 
		[SHIPMENTNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYCONTAINERS], 
		[TOTALWEIGHT], 
		[BATCHNUMBER], 
		[STDWEIGHT], 
		[STDGALLONS], 
		[CONTAINER], 
		[DOTDESC], 
		[HAZMATDESC], 
		[UNLINE], 
		[CLASSRATE], 
		[LD1], 
		[LD2], 
		[LD3], 
		[BILLABLE], 
		[WORKORDERITEMNUMBER], 
		[ITEMTYPE]
	FROM [dbo].[SHIPMENTDETAIL]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTDETAILLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTDETAILLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTDETAILUpdate] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTDETAILUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTDETAILUpdate];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTDETAILUpdate]
(
	@SHIPMENTDETAILID int, 
	@SHIPMENTNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QTYCONTAINERS int = NULL, 
	@TOTALWEIGHT int = NULL, 
	@BATCHNUMBER varchar(50) = NULL, 
	@STDWEIGHT int = NULL, 
	@STDGALLONS int = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@DOTDESC varchar(200) = NULL, 
	@HAZMATDESC varchar(200) = NULL, 
	@UNLINE varchar(200) = NULL, 
	@CLASSRATE varchar(50) = NULL, 
	@LD1 varchar(500) = NULL, 
	@LD2 varchar(500) = NULL, 
	@LD3 varchar(500) = NULL, 
	@BILLABLE bit = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@ITEMTYPE nchar(1) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [SHIPMENTDETAIL]
	SET
		[SHIPMENTNUMBER] = @SHIPMENTNUMBER, 
		[PRODUCTID] = @PRODUCTID, 
		[PRODUCTDESC] = @PRODUCTDESC, 
		[QTYCONTAINERS] = @QTYCONTAINERS, 
		[TOTALWEIGHT] = @TOTALWEIGHT, 
		[BATCHNUMBER] = @BATCHNUMBER, 
		[STDWEIGHT] = @STDWEIGHT, 
		[STDGALLONS] = @STDGALLONS, 
		[CONTAINER] = @CONTAINER, 
		[DOTDESC] = @DOTDESC, 
		[HAZMATDESC] = @HAZMATDESC, 
		[UNLINE] = @UNLINE, 
		[CLASSRATE] = @CLASSRATE, 
		[LD1] = @LD1, 
		[LD2] = @LD2, 
		[LD3] = @LD3, 
		[BILLABLE] = @BILLABLE, 
		[WORKORDERITEMNUMBER] = @WORKORDERITEMNUMBER, 
		[ITEMTYPE] = @ITEMTYPE
	WHERE
		([SHIPMENTDETAILID] = @SHIPMENTDETAILID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTDETAILUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTDETAILUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTDETAILInsert] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTDETAILInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTDETAILInsert];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTDETAILInsert]
(
	@SHIPMENTDETAILID int = NULL OUTPUT, 
	@SHIPMENTNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QTYCONTAINERS int = NULL, 
	@TOTALWEIGHT int = NULL, 
	@BATCHNUMBER varchar(50) = NULL, 
	@STDWEIGHT int = NULL, 
	@STDGALLONS int = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@DOTDESC varchar(200) = NULL, 
	@HAZMATDESC varchar(200) = NULL, 
	@UNLINE varchar(200) = NULL, 
	@CLASSRATE varchar(50) = NULL, 
	@LD1 varchar(500) = NULL, 
	@LD2 varchar(500) = NULL, 
	@LD3 varchar(500) = NULL, 
	@BILLABLE bit = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@ITEMTYPE nchar(1) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [SHIPMENTDETAIL]
	(
		[SHIPMENTNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYCONTAINERS], 
		[TOTALWEIGHT], 
		[BATCHNUMBER], 
		[STDWEIGHT], 
		[STDGALLONS], 
		[CONTAINER], 
		[DOTDESC], 
		[HAZMATDESC], 
		[UNLINE], 
		[CLASSRATE], 
		[LD1], 
		[LD2], 
		[LD3], 
		[BILLABLE], 
		[WORKORDERITEMNUMBER], 
		[ITEMTYPE]
	)
	
	VALUES
	(
		@SHIPMENTNUMBER, 
		@PRODUCTID, 
		@PRODUCTDESC, 
		@QTYCONTAINERS, 
		@TOTALWEIGHT, 
		@BATCHNUMBER, 
		@STDWEIGHT, 
		@STDGALLONS, 
		@CONTAINER, 
		@DOTDESC, 
		@HAZMATDESC, 
		@UNLINE, 
		@CLASSRATE, 
		@LD1, 
		@LD2, 
		@LD3, 
		@BILLABLE, 
		@WORKORDERITEMNUMBER, 
		@ITEMTYPE
	)

	SET @Err = @@Error

		
	SELECT @SHIPMENTDETAILID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTDETAILInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTDETAILInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTDETAILDelete] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTDETAILDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTDETAILDelete];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTDETAILDelete]
(
	@SHIPMENTDETAILID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[SHIPMENTDETAIL]
	WHERE
		([SHIPMENTDETAILID] = @SHIPMENTDETAILID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTDETAILDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTDETAILDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTITEMLoadByPrimaryKey]
(
	@SHIPMENTITEMNUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SHIPMENTITEMNUMBER], 
		[SHIPMENTNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYCONTAINERS], 
		[TOTALWEIGHT], 
		[LOTNUMBER], 
		[STDWEIGHT], 
		[STDGALLONS], 
		[CONTAINER], 
		[DOTDESC], 
		[HAZMATDESC], 
		[UNLINE], 
		[CLASSRATE], 
		[LD1], 
		[LD2], 
		[LD3], 
		[BILLABLE], 
		[WORKORDERNUMBER], 
		[WORKORDERITEMNUMBER], 
		[INVITEMNUMBER], 
		[UNITS], 
		[UOM], 
		[UNITCOST]
	FROM [dbo].[SHIPMENTITEM]
	WHERE
		([SHIPMENTITEMNUMBER] = @SHIPMENTITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTITEMLoadAll] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SHIPMENTITEMNUMBER], 
		[SHIPMENTNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYCONTAINERS], 
		[TOTALWEIGHT], 
		[LOTNUMBER], 
		[STDWEIGHT], 
		[STDGALLONS], 
		[CONTAINER], 
		[DOTDESC], 
		[HAZMATDESC], 
		[UNLINE], 
		[CLASSRATE], 
		[LD1], 
		[LD2], 
		[LD3], 
		[BILLABLE], 
		[WORKORDERNUMBER], 
		[WORKORDERITEMNUMBER], 
		[INVITEMNUMBER], 
		[UNITS], 
		[UOM], 
		[UNITCOST]
	FROM [dbo].[SHIPMENTITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTITEMUpdate] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTITEMUpdate]
(
	@SHIPMENTITEMNUMBER int, 
	@SHIPMENTNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QTYCONTAINERS int = NULL, 
	@TOTALWEIGHT int = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@STDWEIGHT int = NULL, 
	@STDGALLONS int = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@DOTDESC varchar(200) = NULL, 
	@HAZMATDESC varchar(200) = NULL, 
	@UNLINE varchar(200) = NULL, 
	@CLASSRATE varchar(50) = NULL, 
	@LD1 varchar(500) = NULL, 
	@LD2 varchar(500) = NULL, 
	@LD3 varchar(500) = NULL, 
	@BILLABLE bit = NULL, 
	@WORKORDERNUMBER int = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@INVITEMNUMBER int = NULL, 
	@UNITS decimal(18,4) = NULL, 
	@UOM varchar(50) = NULL, 
	@UNITCOST decimal(18,4) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [SHIPMENTITEM]
	SET
		[SHIPMENTNUMBER] = @SHIPMENTNUMBER, 
		[PRODUCTID] = @PRODUCTID, 
		[PRODUCTDESC] = @PRODUCTDESC, 
		[QTYCONTAINERS] = @QTYCONTAINERS, 
		[TOTALWEIGHT] = @TOTALWEIGHT, 
		[LOTNUMBER] = @LOTNUMBER, 
		[STDWEIGHT] = @STDWEIGHT, 
		[STDGALLONS] = @STDGALLONS, 
		[CONTAINER] = @CONTAINER, 
		[DOTDESC] = @DOTDESC, 
		[HAZMATDESC] = @HAZMATDESC, 
		[UNLINE] = @UNLINE, 
		[CLASSRATE] = @CLASSRATE, 
		[LD1] = @LD1, 
		[LD2] = @LD2, 
		[LD3] = @LD3, 
		[BILLABLE] = @BILLABLE, 
		[WORKORDERNUMBER] = @WORKORDERNUMBER, 
		[WORKORDERITEMNUMBER] = @WORKORDERITEMNUMBER, 
		[INVITEMNUMBER] = @INVITEMNUMBER, 
		[UNITS] = @UNITS, 
		[UOM] = @UOM, 
		[UNITCOST] = @UNITCOST
	WHERE
		([SHIPMENTITEMNUMBER] = @SHIPMENTITEMNUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTITEMInsert] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTITEMInsert]
(
	@SHIPMENTITEMNUMBER int = NULL OUTPUT, 
	@SHIPMENTNUMBER int = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@QTYCONTAINERS int = NULL, 
	@TOTALWEIGHT int = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@STDWEIGHT int = NULL, 
	@STDGALLONS int = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@DOTDESC varchar(200) = NULL, 
	@HAZMATDESC varchar(200) = NULL, 
	@UNLINE varchar(200) = NULL, 
	@CLASSRATE varchar(50) = NULL, 
	@LD1 varchar(500) = NULL, 
	@LD2 varchar(500) = NULL, 
	@LD3 varchar(500) = NULL, 
	@BILLABLE bit = NULL, 
	@WORKORDERNUMBER int = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@INVITEMNUMBER int = NULL, 
	@UNITS decimal(18,4) = NULL, 
	@UOM varchar(50) = NULL, 
	@UNITCOST decimal(18,4) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [SHIPMENTITEM]
	(
		[SHIPMENTNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[QTYCONTAINERS], 
		[TOTALWEIGHT], 
		[LOTNUMBER], 
		[STDWEIGHT], 
		[STDGALLONS], 
		[CONTAINER], 
		[DOTDESC], 
		[HAZMATDESC], 
		[UNLINE], 
		[CLASSRATE], 
		[LD1], 
		[LD2], 
		[LD3], 
		[BILLABLE], 
		[WORKORDERNUMBER], 
		[WORKORDERITEMNUMBER], 
		[INVITEMNUMBER], 
		[UNITS], 
		[UOM], 
		[UNITCOST]
	)
	
	VALUES
	(
		@SHIPMENTNUMBER, 
		@PRODUCTID, 
		@PRODUCTDESC, 
		@QTYCONTAINERS, 
		@TOTALWEIGHT, 
		@LOTNUMBER, 
		@STDWEIGHT, 
		@STDGALLONS, 
		@CONTAINER, 
		@DOTDESC, 
		@HAZMATDESC, 
		@UNLINE, 
		@CLASSRATE, 
		@LD1, 
		@LD2, 
		@LD3, 
		@BILLABLE, 
		@WORKORDERNUMBER, 
		@WORKORDERITEMNUMBER, 
		@INVITEMNUMBER, 
		@UNITS, 
		@UOM, 
		@UNITCOST
	)

	SET @Err = @@Error

		
	SELECT @SHIPMENTITEMNUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SHIPMENTITEMDelete] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SHIPMENTITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SHIPMENTITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_SHIPMENTITEMDelete]
(
	@SHIPMENTITEMNUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[SHIPMENTITEM]
	WHERE
		([SHIPMENTITEMNUMBER] = @SHIPMENTITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SHIPMENTITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_SHIPMENTITEMDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_SUPPLIERCOMPANYLoadByPrimaryKey] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SUPPLIERCOMPANYLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SUPPLIERCOMPANYLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_SUPPLIERCOMPANYLoadByPrimaryKey]
(
	@SUPPLIERCOMPANY varchar(50)
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SUPPLIERCOMPANY]
	FROM [dbo].[SUPPLIERCOMPANY]
	WHERE
		([SUPPLIERCOMPANY] = @SUPPLIERCOMPANY)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SUPPLIERCOMPANYLoadAll] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SUPPLIERCOMPANYLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SUPPLIERCOMPANYLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_SUPPLIERCOMPANYLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[SUPPLIERCOMPANY]
	FROM [dbo].[SUPPLIERCOMPANY]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYLoadAll Error on Creation'
GO 



-- -----------------------------------------
-- NO UPDATE Stored Procedure Generated 
-- All Columns are part of the Primary key
-- -----------------------------------------




-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SUPPLIERCOMPANYInsert] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SUPPLIERCOMPANYInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SUPPLIERCOMPANYInsert];
GO

CREATE PROCEDURE [dbo].[proc_SUPPLIERCOMPANYInsert]
(
	@SUPPLIERCOMPANY varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [SUPPLIERCOMPANY]
	(
		[SUPPLIERCOMPANY]
	)
	
	VALUES
	(
		@SUPPLIERCOMPANY
	)

	SET @Err = @@Error



	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SUPPLIERCOMPANYDelete] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SUPPLIERCOMPANYDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SUPPLIERCOMPANYDelete];
GO

CREATE PROCEDURE [dbo].[proc_SUPPLIERCOMPANYDelete]
(
	@SUPPLIERCOMPANY varchar(50)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[SUPPLIERCOMPANY]
	WHERE
		([SUPPLIERCOMPANY] = @SUPPLIERCOMPANY)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_SUPPLIERCOMPANYDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_SYSPARAMETERSLoadByPrimaryKey] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SYSPARAMETERSLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SYSPARAMETERSLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_SYSPARAMETERSLoadByPrimaryKey]
(
	@RecordID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecordID], 
		[CompanyName], 
		[CompanyAddress], 
		[CompanyCity], 
		[CompanyState], 
		[CompanyZipcode], 
		[CompanyCountry], 
		[CompanyPhone], 
		[CompanyFAX], 
		[DEFAULTSALESTAXRATE], 
		[STDLABORHOURCOST], 
		[FreezeWarning], 
		[COAText], 
		[STDOVERHEADHOURCOST], 
		[PRODORDERMaxIdleTime], 
		[MaxLoadWeight]
	FROM [dbo].[SYSPARAMETERS]
	WHERE
		([RecordID] = @RecordID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SYSPARAMETERSLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_SYSPARAMETERSLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SYSPARAMETERSLoadAll] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SYSPARAMETERSLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SYSPARAMETERSLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_SYSPARAMETERSLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecordID], 
		[CompanyName], 
		[CompanyAddress], 
		[CompanyCity], 
		[CompanyState], 
		[CompanyZipcode], 
		[CompanyCountry], 
		[CompanyPhone], 
		[CompanyFAX], 
		[DEFAULTSALESTAXRATE], 
		[STDLABORHOURCOST], 
		[FreezeWarning], 
		[COAText], 
		[STDOVERHEADHOURCOST], 
		[PRODORDERMaxIdleTime], 
		[MaxLoadWeight]
	FROM [dbo].[SYSPARAMETERS]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SYSPARAMETERSLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_SYSPARAMETERSLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SYSPARAMETERSUpdate] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SYSPARAMETERSUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SYSPARAMETERSUpdate];
GO

CREATE PROCEDURE [dbo].[proc_SYSPARAMETERSUpdate]
(
	@RecordID int, 
	@CompanyName varchar(50) = NULL, 
	@CompanyAddress varchar(50) = NULL, 
	@CompanyCity varchar(50) = NULL, 
	@CompanyState varchar(2) = NULL, 
	@CompanyZipcode varchar(50) = NULL, 
	@CompanyCountry varchar(50) = NULL, 
	@CompanyPhone varchar(24) = NULL, 
	@CompanyFAX varchar(24) = NULL, 
	@DEFAULTSALESTAXRATE decimal(18,4) = NULL, 
	@STDLABORHOURCOST decimal(18,4) = NULL, 
	@FreezeWarning int = NULL, 
	@COAText varchar(MAX) = NULL, 
	@STDOVERHEADHOURCOST decimal(18,4) = NULL, 
	@PRODORDERMaxIdleTime int = NULL, 
	@MaxLoadWeight int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [SYSPARAMETERS]
	SET
		[CompanyName] = @CompanyName, 
		[CompanyAddress] = @CompanyAddress, 
		[CompanyCity] = @CompanyCity, 
		[CompanyState] = @CompanyState, 
		[CompanyZipcode] = @CompanyZipcode, 
		[CompanyCountry] = @CompanyCountry, 
		[CompanyPhone] = @CompanyPhone, 
		[CompanyFAX] = @CompanyFAX, 
		[DEFAULTSALESTAXRATE] = @DEFAULTSALESTAXRATE, 
		[STDLABORHOURCOST] = @STDLABORHOURCOST, 
		[FreezeWarning] = @FreezeWarning, 
		[COAText] = @COAText, 
		[STDOVERHEADHOURCOST] = @STDOVERHEADHOURCOST, 
		[PRODORDERMaxIdleTime] = @PRODORDERMaxIdleTime, 
		[MaxLoadWeight] = @MaxLoadWeight
	WHERE
		([RecordID] = @RecordID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SYSPARAMETERSUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_SYSPARAMETERSUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SYSPARAMETERSInsert] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SYSPARAMETERSInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SYSPARAMETERSInsert];
GO

CREATE PROCEDURE [dbo].[proc_SYSPARAMETERSInsert]
(
	@RecordID int = NULL OUTPUT, 
	@CompanyName varchar(50) = NULL, 
	@CompanyAddress varchar(50) = NULL, 
	@CompanyCity varchar(50) = NULL, 
	@CompanyState varchar(2) = NULL, 
	@CompanyZipcode varchar(50) = NULL, 
	@CompanyCountry varchar(50) = NULL, 
	@CompanyPhone varchar(24) = NULL, 
	@CompanyFAX varchar(24) = NULL, 
	@DEFAULTSALESTAXRATE decimal(18,4) = NULL, 
	@STDLABORHOURCOST decimal(18,4) = NULL, 
	@FreezeWarning int = NULL, 
	@COAText varchar(MAX) = NULL, 
	@STDOVERHEADHOURCOST decimal(18,4) = NULL, 
	@PRODORDERMaxIdleTime int = NULL, 
	@MaxLoadWeight int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [SYSPARAMETERS]
	(
		[CompanyName], 
		[CompanyAddress], 
		[CompanyCity], 
		[CompanyState], 
		[CompanyZipcode], 
		[CompanyCountry], 
		[CompanyPhone], 
		[CompanyFAX], 
		[DEFAULTSALESTAXRATE], 
		[STDLABORHOURCOST], 
		[FreezeWarning], 
		[COAText], 
		[STDOVERHEADHOURCOST], 
		[PRODORDERMaxIdleTime], 
		[MaxLoadWeight]
	)
	
	VALUES
	(
		@CompanyName, 
		@CompanyAddress, 
		@CompanyCity, 
		@CompanyState, 
		@CompanyZipcode, 
		@CompanyCountry, 
		@CompanyPhone, 
		@CompanyFAX, 
		@DEFAULTSALESTAXRATE, 
		@STDLABORHOURCOST, 
		@FreezeWarning, 
		@COAText, 
		@STDOVERHEADHOURCOST, 
		@PRODORDERMaxIdleTime, 
		@MaxLoadWeight
	)

	SET @Err = @@Error

		
	SELECT @RecordID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SYSPARAMETERSInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_SYSPARAMETERSInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_SYSPARAMETERSDelete] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_SYSPARAMETERSDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_SYSPARAMETERSDelete];
GO

CREATE PROCEDURE [dbo].[proc_SYSPARAMETERSDelete]
(
	@RecordID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[SYSPARAMETERS]
	WHERE
		([RecordID] = @RecordID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_SYSPARAMETERSDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_SYSPARAMETERSDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_TESTSAMPLELoadByPrimaryKey] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_TESTSAMPLELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_TESTSAMPLELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_TESTSAMPLELoadByPrimaryKey]
(
	@TESTSAMPLEKEY int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[TESTSAMPLEKEY], 
		[LOTNUMBER], 
		[PRODUCTID], 
		[TESTTIME], 
		[TESTEDBY], 
		[TEMPERATURE], 
		[PHRESULT], 
		[PHRANGELOW], 
		[PHRANGEHIGH], 
		[PHACCEPTED], 
		[SGRESULT], 
		[SGRANGELOW], 
		[SGRANGEHIGH], 
		[SGACCEPTED], 
		[APPEARANCE], 
		[FREEFLOWING], 
		[PASSEDTIME], 
		[PASSEDBY], 
		[PASSEDTEST], 
		[COLOR], 
		[ODOR], 
		[STATE]
	FROM [dbo].[TESTSAMPLE]
	WHERE
		([TESTSAMPLEKEY] = @TESTSAMPLEKEY)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TESTSAMPLELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_TESTSAMPLELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_TESTSAMPLELoadAll] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_TESTSAMPLELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_TESTSAMPLELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_TESTSAMPLELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[TESTSAMPLEKEY], 
		[LOTNUMBER], 
		[PRODUCTID], 
		[TESTTIME], 
		[TESTEDBY], 
		[TEMPERATURE], 
		[PHRESULT], 
		[PHRANGELOW], 
		[PHRANGEHIGH], 
		[PHACCEPTED], 
		[SGRESULT], 
		[SGRANGELOW], 
		[SGRANGEHIGH], 
		[SGACCEPTED], 
		[APPEARANCE], 
		[FREEFLOWING], 
		[PASSEDTIME], 
		[PASSEDBY], 
		[PASSEDTEST], 
		[COLOR], 
		[ODOR], 
		[STATE]
	FROM [dbo].[TESTSAMPLE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TESTSAMPLELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_TESTSAMPLELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_TESTSAMPLEUpdate] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_TESTSAMPLEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_TESTSAMPLEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_TESTSAMPLEUpdate]
(
	@TESTSAMPLEKEY int, 
	@LOTNUMBER varchar(50) = NULL, 
	@PRODUCTID int = NULL, 
	@TESTTIME datetime = NULL, 
	@TESTEDBY varchar(50) = NULL, 
	@TEMPERATURE decimal(18,2) = NULL, 
	@PHRESULT decimal(18,2) = NULL, 
	@PHRANGELOW decimal(18,2) = NULL, 
	@PHRANGEHIGH decimal(18,2) = NULL, 
	@PHACCEPTED bit, 
	@SGRESULT decimal(18,3) = NULL, 
	@SGRANGELOW decimal(18,3) = NULL, 
	@SGRANGEHIGH decimal(18,3) = NULL, 
	@SGACCEPTED bit, 
	@APPEARANCE varchar(50) = NULL, 
	@FREEFLOWING bit = NULL, 
	@PASSEDTIME datetime = NULL, 
	@PASSEDBY varchar(50) = NULL, 
	@PASSEDTEST bit, 
	@COLOR varchar(50) = NULL, 
	@ODOR varchar(50) = NULL, 
	@STATE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [TESTSAMPLE]
	SET
		[LOTNUMBER] = @LOTNUMBER, 
		[PRODUCTID] = @PRODUCTID, 
		[TESTTIME] = @TESTTIME, 
		[TESTEDBY] = @TESTEDBY, 
		[TEMPERATURE] = @TEMPERATURE, 
		[PHRESULT] = @PHRESULT, 
		[PHRANGELOW] = @PHRANGELOW, 
		[PHRANGEHIGH] = @PHRANGEHIGH, 
		[PHACCEPTED] = @PHACCEPTED, 
		[SGRESULT] = @SGRESULT, 
		[SGRANGELOW] = @SGRANGELOW, 
		[SGRANGEHIGH] = @SGRANGEHIGH, 
		[SGACCEPTED] = @SGACCEPTED, 
		[APPEARANCE] = @APPEARANCE, 
		[FREEFLOWING] = @FREEFLOWING, 
		[PASSEDTIME] = @PASSEDTIME, 
		[PASSEDBY] = @PASSEDBY, 
		[PASSEDTEST] = @PASSEDTEST, 
		[COLOR] = @COLOR, 
		[ODOR] = @ODOR, 
		[STATE] = @STATE
	WHERE
		([TESTSAMPLEKEY] = @TESTSAMPLEKEY)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TESTSAMPLEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_TESTSAMPLEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_TESTSAMPLEInsert] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_TESTSAMPLEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_TESTSAMPLEInsert];
GO

CREATE PROCEDURE [dbo].[proc_TESTSAMPLEInsert]
(
	@TESTSAMPLEKEY int = NULL OUTPUT, 
	@LOTNUMBER varchar(50) = NULL, 
	@PRODUCTID int = NULL, 
	@TESTTIME datetime = NULL, 
	@TESTEDBY varchar(50) = NULL, 
	@TEMPERATURE decimal(18,2) = NULL, 
	@PHRESULT decimal(18,2) = NULL, 
	@PHRANGELOW decimal(18,2) = NULL, 
	@PHRANGEHIGH decimal(18,2) = NULL, 
	@PHACCEPTED bit, 
	@SGRESULT decimal(18,3) = NULL, 
	@SGRANGELOW decimal(18,3) = NULL, 
	@SGRANGEHIGH decimal(18,3) = NULL, 
	@SGACCEPTED bit, 
	@APPEARANCE varchar(50) = NULL, 
	@FREEFLOWING bit = NULL, 
	@PASSEDTIME datetime = NULL, 
	@PASSEDBY varchar(50) = NULL, 
	@PASSEDTEST bit, 
	@COLOR varchar(50) = NULL, 
	@ODOR varchar(50) = NULL, 
	@STATE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [TESTSAMPLE]
	(
		[LOTNUMBER], 
		[PRODUCTID], 
		[TESTTIME], 
		[TESTEDBY], 
		[TEMPERATURE], 
		[PHRESULT], 
		[PHRANGELOW], 
		[PHRANGEHIGH], 
		[PHACCEPTED], 
		[SGRESULT], 
		[SGRANGELOW], 
		[SGRANGEHIGH], 
		[SGACCEPTED], 
		[APPEARANCE], 
		[FREEFLOWING], 
		[PASSEDTIME], 
		[PASSEDBY], 
		[PASSEDTEST], 
		[COLOR], 
		[ODOR], 
		[STATE]
	)
	
	VALUES
	(
		@LOTNUMBER, 
		@PRODUCTID, 
		@TESTTIME, 
		@TESTEDBY, 
		@TEMPERATURE, 
		@PHRESULT, 
		@PHRANGELOW, 
		@PHRANGEHIGH, 
		@PHACCEPTED, 
		@SGRESULT, 
		@SGRANGELOW, 
		@SGRANGEHIGH, 
		@SGACCEPTED, 
		@APPEARANCE, 
		@FREEFLOWING, 
		@PASSEDTIME, 
		@PASSEDBY, 
		@PASSEDTEST, 
		@COLOR, 
		@ODOR, 
		@STATE
	)

	SET @Err = @@Error

		
	SELECT @TESTSAMPLEKEY = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TESTSAMPLEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_TESTSAMPLEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_TESTSAMPLEDelete] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_TESTSAMPLEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_TESTSAMPLEDelete];
GO

CREATE PROCEDURE [dbo].[proc_TESTSAMPLEDelete]
(
	@TESTSAMPLEKEY int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[TESTSAMPLE]
	WHERE
		([TESTSAMPLEKEY] = @TESTSAMPLEKEY)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_TESTSAMPLEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_TESTSAMPLEDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_VENDORLoadByPrimaryKey] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_VENDORLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_VENDORLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_VENDORLoadByPrimaryKey]
(
	@VENDORID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[VENDORID], 
		[VENDORNAME], 
		[VENDORADDRESS1], 
		[VENDORADDRESS2], 
		[VENDORCITY], 
		[VENDORSTATE], 
		[VENDORZIP], 
		[VENDORPHONE], 
		[VENDORFAX], 
		[VENDORCONTACT], 
		[VENDOREMAIL], 
		[VENDORURL], 
		[VENDORACCTNUMBER], 
		[TERMS], 
		[VENDORNOTES], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE]
	FROM [dbo].[VENDOR]
	WHERE
		([VENDORID] = @VENDORID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_VENDORLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_VENDORLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_VENDORLoadAll] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_VENDORLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_VENDORLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_VENDORLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[VENDORID], 
		[VENDORNAME], 
		[VENDORADDRESS1], 
		[VENDORADDRESS2], 
		[VENDORCITY], 
		[VENDORSTATE], 
		[VENDORZIP], 
		[VENDORPHONE], 
		[VENDORFAX], 
		[VENDORCONTACT], 
		[VENDOREMAIL], 
		[VENDORURL], 
		[VENDORACCTNUMBER], 
		[TERMS], 
		[VENDORNOTES], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE]
	FROM [dbo].[VENDOR]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_VENDORLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_VENDORLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_VENDORUpdate] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_VENDORUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_VENDORUpdate];
GO

CREATE PROCEDURE [dbo].[proc_VENDORUpdate]
(
	@VENDORID int, 
	@VENDORNAME varchar(50) = NULL, 
	@VENDORADDRESS1 varchar(50) = NULL, 
	@VENDORADDRESS2 varchar(50) = NULL, 
	@VENDORCITY varchar(50) = NULL, 
	@VENDORSTATE varchar(2) = NULL, 
	@VENDORZIP varchar(10) = NULL, 
	@VENDORPHONE varchar(20) = NULL, 
	@VENDORFAX varchar(20) = NULL, 
	@VENDORCONTACT varchar(50) = NULL, 
	@VENDOREMAIL varchar(100) = NULL, 
	@VENDORURL varchar(50) = NULL, 
	@VENDORACCTNUMBER varchar(50) = NULL, 
	@TERMS varchar(50) = NULL, 
	@VENDORNOTES varchar(MAX) = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@ISACTIVE bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [VENDOR]
	SET
		[VENDORNAME] = @VENDORNAME, 
		[VENDORADDRESS1] = @VENDORADDRESS1, 
		[VENDORADDRESS2] = @VENDORADDRESS2, 
		[VENDORCITY] = @VENDORCITY, 
		[VENDORSTATE] = @VENDORSTATE, 
		[VENDORZIP] = @VENDORZIP, 
		[VENDORPHONE] = @VENDORPHONE, 
		[VENDORFAX] = @VENDORFAX, 
		[VENDORCONTACT] = @VENDORCONTACT, 
		[VENDOREMAIL] = @VENDOREMAIL, 
		[VENDORURL] = @VENDORURL, 
		[VENDORACCTNUMBER] = @VENDORACCTNUMBER, 
		[TERMS] = @TERMS, 
		[VENDORNOTES] = @VENDORNOTES, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME, 
		[ISACTIVE] = @ISACTIVE
	WHERE
		([VENDORID] = @VENDORID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_VENDORUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_VENDORUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_VENDORInsert] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_VENDORInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_VENDORInsert];
GO

CREATE PROCEDURE [dbo].[proc_VENDORInsert]
(
	@VENDORID int = NULL OUTPUT, 
	@VENDORNAME varchar(50) = NULL, 
	@VENDORADDRESS1 varchar(50) = NULL, 
	@VENDORADDRESS2 varchar(50) = NULL, 
	@VENDORCITY varchar(50) = NULL, 
	@VENDORSTATE varchar(2) = NULL, 
	@VENDORZIP varchar(10) = NULL, 
	@VENDORPHONE varchar(20) = NULL, 
	@VENDORFAX varchar(20) = NULL, 
	@VENDORCONTACT varchar(50) = NULL, 
	@VENDOREMAIL varchar(100) = NULL, 
	@VENDORURL varchar(50) = NULL, 
	@VENDORACCTNUMBER varchar(50) = NULL, 
	@TERMS varchar(50) = NULL, 
	@VENDORNOTES varchar(MAX) = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@ISACTIVE bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [VENDOR]
	(
		[VENDORNAME], 
		[VENDORADDRESS1], 
		[VENDORADDRESS2], 
		[VENDORCITY], 
		[VENDORSTATE], 
		[VENDORZIP], 
		[VENDORPHONE], 
		[VENDORFAX], 
		[VENDORCONTACT], 
		[VENDOREMAIL], 
		[VENDORURL], 
		[VENDORACCTNUMBER], 
		[TERMS], 
		[VENDORNOTES], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[ISACTIVE]
	)
	
	VALUES
	(
		@VENDORNAME, 
		@VENDORADDRESS1, 
		@VENDORADDRESS2, 
		@VENDORCITY, 
		@VENDORSTATE, 
		@VENDORZIP, 
		@VENDORPHONE, 
		@VENDORFAX, 
		@VENDORCONTACT, 
		@VENDOREMAIL, 
		@VENDORURL, 
		@VENDORACCTNUMBER, 
		@TERMS, 
		@VENDORNOTES, 
		@CREATEDBY, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME, 
		@ISACTIVE
	)

	SET @Err = @@Error

		
	SELECT @VENDORID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_VENDORInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_VENDORInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_VENDORDelete] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_VENDORDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_VENDORDelete];
GO

CREATE PROCEDURE [dbo].[proc_VENDORDelete]
(
	@VENDORID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[VENDOR]
	WHERE
		([VENDORID] = @VENDORID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_VENDORDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_VENDORDelete Error on Creation'
GO 


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


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_WORKORDERLoadByPrimaryKey] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_WORKORDERLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_WORKORDERLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_WORKORDERLoadByPrimaryKey]
(
	@WORKORDERNUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[WORKORDERNUMBER], 
		[CUSTID], 
		[BILLADDRESS1], 
		[BILLADDRESS2], 
		[BILLCITY], 
		[BILLSTATEPROV], 
		[BILLPOSTALCODE], 
		[BILLCOUNTRY], 
		[BILLPHONE], 
		[BILLFAX], 
		[BILLCONTACT], 
		[SHIPADDRESS1], 
		[SHIPADDRESS2], 
		[SHIPCITY], 
		[SHIPSTATEPROV], 
		[SHIPPOSTALCODE], 
		[SHIPCOUNTRY], 
		[SHIPCONTACT], 
		[FREIGHTCARRIER], 
		[FOB], 
		[CUSTOMERPO], 
		[ORDERTERMS], 
		[DELIVERYDATE], 
		[PLANNEDSHIPDATE], 
		[HOWRECEIVED], 
		[ORDERSTATUS], 
		[ORDERNOTES], 
		[WORKORDERDATE], 
		[PREPAREDBY], 
		[SUPPLIERCOMPANY], 
		[SUBTOTAL], 
		[LOGISTICSID], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[SHIPPHONE], 
		[SHIPEMAIL], 
		[CARRIERID], 
		[WORKORDERTYPE], 
		[ONHOLD], 
		[ONHOLDREASON], 
		[FREIGHTCHARGES], 
		[FREIGHTBILLABLE], 
		[FREIGHTBILLCUSTOMER], 
		[FREIGHTONINVOICE], 
		[VENDORID]
	FROM [dbo].[WORKORDER]
	WHERE
		([WORKORDERNUMBER] = @WORKORDERNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_WORKORDERLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_WORKORDERLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_WORKORDERLoadAll] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_WORKORDERLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_WORKORDERLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_WORKORDERLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[WORKORDERNUMBER], 
		[CUSTID], 
		[BILLADDRESS1], 
		[BILLADDRESS2], 
		[BILLCITY], 
		[BILLSTATEPROV], 
		[BILLPOSTALCODE], 
		[BILLCOUNTRY], 
		[BILLPHONE], 
		[BILLFAX], 
		[BILLCONTACT], 
		[SHIPADDRESS1], 
		[SHIPADDRESS2], 
		[SHIPCITY], 
		[SHIPSTATEPROV], 
		[SHIPPOSTALCODE], 
		[SHIPCOUNTRY], 
		[SHIPCONTACT], 
		[FREIGHTCARRIER], 
		[FOB], 
		[CUSTOMERPO], 
		[ORDERTERMS], 
		[DELIVERYDATE], 
		[PLANNEDSHIPDATE], 
		[HOWRECEIVED], 
		[ORDERSTATUS], 
		[ORDERNOTES], 
		[WORKORDERDATE], 
		[PREPAREDBY], 
		[SUPPLIERCOMPANY], 
		[SUBTOTAL], 
		[LOGISTICSID], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[SHIPPHONE], 
		[SHIPEMAIL], 
		[CARRIERID], 
		[WORKORDERTYPE], 
		[ONHOLD], 
		[ONHOLDREASON], 
		[FREIGHTCHARGES], 
		[FREIGHTBILLABLE], 
		[FREIGHTBILLCUSTOMER], 
		[FREIGHTONINVOICE], 
		[VENDORID]
	FROM [dbo].[WORKORDER]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_WORKORDERLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_WORKORDERLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_WORKORDERUpdate] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_WORKORDERUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_WORKORDERUpdate];
GO

CREATE PROCEDURE [dbo].[proc_WORKORDERUpdate]
(
	@WORKORDERNUMBER int, 
	@CUSTID int = NULL, 
	@BILLADDRESS1 varchar(50) = NULL, 
	@BILLADDRESS2 varchar(50) = NULL, 
	@BILLCITY varchar(50) = NULL, 
	@BILLSTATEPROV varchar(50) = NULL, 
	@BILLPOSTALCODE varchar(24) = NULL, 
	@BILLCOUNTRY varchar(50) = NULL, 
	@BILLPHONE varchar(50) = NULL, 
	@BILLFAX varchar(50) = NULL, 
	@BILLCONTACT varchar(50) = NULL, 
	@SHIPADDRESS1 varchar(50) = NULL, 
	@SHIPADDRESS2 varchar(50) = NULL, 
	@SHIPCITY varchar(50) = NULL, 
	@SHIPSTATEPROV varchar(50) = NULL, 
	@SHIPPOSTALCODE varchar(24) = NULL, 
	@SHIPCOUNTRY varchar(50) = NULL, 
	@SHIPCONTACT varchar(50) = NULL, 
	@FREIGHTCARRIER varchar(50) = NULL, 
	@FOB varchar(24) = NULL, 
	@CUSTOMERPO varchar(50) = NULL, 
	@ORDERTERMS varchar(50) = NULL, 
	@DELIVERYDATE datetime = NULL, 
	@PLANNEDSHIPDATE datetime = NULL, 
	@HOWRECEIVED varchar(24) = NULL, 
	@ORDERSTATUS varchar(50) = NULL, 
	@ORDERNOTES varchar(MAX) = NULL, 
	@WORKORDERDATE datetime = NULL, 
	@PREPAREDBY varchar(50) = NULL, 
	@SUPPLIERCOMPANY varchar(50) = NULL, 
	@SUBTOTAL money = NULL, 
	@LOGISTICSID int = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@SHIPPHONE varchar(50) = NULL, 
	@SHIPEMAIL varchar(50) = NULL, 
	@CARRIERID int = NULL, 
	@WORKORDERTYPE varchar(50) = NULL, 
	@ONHOLD bit = NULL, 
	@ONHOLDREASON varchar(200) = NULL, 
	@FREIGHTCHARGES decimal(18,4) = NULL, 
	@FREIGHTBILLABLE decimal(18,4) = NULL, 
	@FREIGHTBILLCUSTOMER bit = NULL, 
	@FREIGHTONINVOICE bit = NULL, 
	@VENDORID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [WORKORDER]
	SET
		[CUSTID] = @CUSTID, 
		[BILLADDRESS1] = @BILLADDRESS1, 
		[BILLADDRESS2] = @BILLADDRESS2, 
		[BILLCITY] = @BILLCITY, 
		[BILLSTATEPROV] = @BILLSTATEPROV, 
		[BILLPOSTALCODE] = @BILLPOSTALCODE, 
		[BILLCOUNTRY] = @BILLCOUNTRY, 
		[BILLPHONE] = @BILLPHONE, 
		[BILLFAX] = @BILLFAX, 
		[BILLCONTACT] = @BILLCONTACT, 
		[SHIPADDRESS1] = @SHIPADDRESS1, 
		[SHIPADDRESS2] = @SHIPADDRESS2, 
		[SHIPCITY] = @SHIPCITY, 
		[SHIPSTATEPROV] = @SHIPSTATEPROV, 
		[SHIPPOSTALCODE] = @SHIPPOSTALCODE, 
		[SHIPCOUNTRY] = @SHIPCOUNTRY, 
		[SHIPCONTACT] = @SHIPCONTACT, 
		[FREIGHTCARRIER] = @FREIGHTCARRIER, 
		[FOB] = @FOB, 
		[CUSTOMERPO] = @CUSTOMERPO, 
		[ORDERTERMS] = @ORDERTERMS, 
		[DELIVERYDATE] = @DELIVERYDATE, 
		[PLANNEDSHIPDATE] = @PLANNEDSHIPDATE, 
		[HOWRECEIVED] = @HOWRECEIVED, 
		[ORDERSTATUS] = @ORDERSTATUS, 
		[ORDERNOTES] = @ORDERNOTES, 
		[WORKORDERDATE] = @WORKORDERDATE, 
		[PREPAREDBY] = @PREPAREDBY, 
		[SUPPLIERCOMPANY] = @SUPPLIERCOMPANY, 
		[SUBTOTAL] = @SUBTOTAL, 
		[LOGISTICSID] = @LOGISTICSID, 
		[CREATEDBY] = @CREATEDBY, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME, 
		[SHIPPHONE] = @SHIPPHONE, 
		[SHIPEMAIL] = @SHIPEMAIL, 
		[CARRIERID] = @CARRIERID, 
		[WORKORDERTYPE] = @WORKORDERTYPE, 
		[ONHOLD] = @ONHOLD, 
		[ONHOLDREASON] = @ONHOLDREASON, 
		[FREIGHTCHARGES] = @FREIGHTCHARGES, 
		[FREIGHTBILLABLE] = @FREIGHTBILLABLE, 
		[FREIGHTBILLCUSTOMER] = @FREIGHTBILLCUSTOMER, 
		[FREIGHTONINVOICE] = @FREIGHTONINVOICE, 
		[VENDORID] = @VENDORID
	WHERE
		([WORKORDERNUMBER] = @WORKORDERNUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_WORKORDERUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_WORKORDERUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_WORKORDERInsert] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_WORKORDERInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_WORKORDERInsert];
GO

CREATE PROCEDURE [dbo].[proc_WORKORDERInsert]
(
	@WORKORDERNUMBER int = NULL OUTPUT, 
	@CUSTID int = NULL, 
	@BILLADDRESS1 varchar(50) = NULL, 
	@BILLADDRESS2 varchar(50) = NULL, 
	@BILLCITY varchar(50) = NULL, 
	@BILLSTATEPROV varchar(50) = NULL, 
	@BILLPOSTALCODE varchar(24) = NULL, 
	@BILLCOUNTRY varchar(50) = NULL, 
	@BILLPHONE varchar(50) = NULL, 
	@BILLFAX varchar(50) = NULL, 
	@BILLCONTACT varchar(50) = NULL, 
	@SHIPADDRESS1 varchar(50) = NULL, 
	@SHIPADDRESS2 varchar(50) = NULL, 
	@SHIPCITY varchar(50) = NULL, 
	@SHIPSTATEPROV varchar(50) = NULL, 
	@SHIPPOSTALCODE varchar(24) = NULL, 
	@SHIPCOUNTRY varchar(50) = NULL, 
	@SHIPCONTACT varchar(50) = NULL, 
	@FREIGHTCARRIER varchar(50) = NULL, 
	@FOB varchar(24) = NULL, 
	@CUSTOMERPO varchar(50) = NULL, 
	@ORDERTERMS varchar(50) = NULL, 
	@DELIVERYDATE datetime = NULL, 
	@PLANNEDSHIPDATE datetime = NULL, 
	@HOWRECEIVED varchar(24) = NULL, 
	@ORDERSTATUS varchar(50) = NULL, 
	@ORDERNOTES varchar(MAX) = NULL, 
	@WORKORDERDATE datetime = NULL, 
	@PREPAREDBY varchar(50) = NULL, 
	@SUPPLIERCOMPANY varchar(50) = NULL, 
	@SUBTOTAL money = NULL, 
	@LOGISTICSID int = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@SHIPPHONE varchar(50) = NULL, 
	@SHIPEMAIL varchar(50) = NULL, 
	@CARRIERID int = NULL, 
	@WORKORDERTYPE varchar(50) = NULL, 
	@ONHOLD bit = NULL, 
	@ONHOLDREASON varchar(200) = NULL, 
	@FREIGHTCHARGES decimal(18,4) = NULL, 
	@FREIGHTBILLABLE decimal(18,4) = NULL, 
	@FREIGHTBILLCUSTOMER bit = NULL, 
	@FREIGHTONINVOICE bit = NULL, 
	@VENDORID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [WORKORDER]
	(
		[CUSTID], 
		[BILLADDRESS1], 
		[BILLADDRESS2], 
		[BILLCITY], 
		[BILLSTATEPROV], 
		[BILLPOSTALCODE], 
		[BILLCOUNTRY], 
		[BILLPHONE], 
		[BILLFAX], 
		[BILLCONTACT], 
		[SHIPADDRESS1], 
		[SHIPADDRESS2], 
		[SHIPCITY], 
		[SHIPSTATEPROV], 
		[SHIPPOSTALCODE], 
		[SHIPCOUNTRY], 
		[SHIPCONTACT], 
		[FREIGHTCARRIER], 
		[FOB], 
		[CUSTOMERPO], 
		[ORDERTERMS], 
		[DELIVERYDATE], 
		[PLANNEDSHIPDATE], 
		[HOWRECEIVED], 
		[ORDERSTATUS], 
		[ORDERNOTES], 
		[WORKORDERDATE], 
		[PREPAREDBY], 
		[SUPPLIERCOMPANY], 
		[SUBTOTAL], 
		[LOGISTICSID], 
		[CREATEDBY], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[SHIPPHONE], 
		[SHIPEMAIL], 
		[CARRIERID], 
		[WORKORDERTYPE], 
		[ONHOLD], 
		[ONHOLDREASON], 
		[FREIGHTCHARGES], 
		[FREIGHTBILLABLE], 
		[FREIGHTBILLCUSTOMER], 
		[FREIGHTONINVOICE], 
		[VENDORID]
	)
	
	VALUES
	(
		@CUSTID, 
		@BILLADDRESS1, 
		@BILLADDRESS2, 
		@BILLCITY, 
		@BILLSTATEPROV, 
		@BILLPOSTALCODE, 
		@BILLCOUNTRY, 
		@BILLPHONE, 
		@BILLFAX, 
		@BILLCONTACT, 
		@SHIPADDRESS1, 
		@SHIPADDRESS2, 
		@SHIPCITY, 
		@SHIPSTATEPROV, 
		@SHIPPOSTALCODE, 
		@SHIPCOUNTRY, 
		@SHIPCONTACT, 
		@FREIGHTCARRIER, 
		@FOB, 
		@CUSTOMERPO, 
		@ORDERTERMS, 
		@DELIVERYDATE, 
		@PLANNEDSHIPDATE, 
		@HOWRECEIVED, 
		@ORDERSTATUS, 
		@ORDERNOTES, 
		@WORKORDERDATE, 
		@PREPAREDBY, 
		@SUPPLIERCOMPANY, 
		@SUBTOTAL, 
		@LOGISTICSID, 
		@CREATEDBY, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME, 
		@SHIPPHONE, 
		@SHIPEMAIL, 
		@CARRIERID, 
		@WORKORDERTYPE, 
		@ONHOLD, 
		@ONHOLDREASON, 
		@FREIGHTCHARGES, 
		@FREIGHTBILLABLE, 
		@FREIGHTBILLCUSTOMER, 
		@FREIGHTONINVOICE, 
		@VENDORID
	)

	SET @Err = @@Error

		
	SELECT @WORKORDERNUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_WORKORDERInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_WORKORDERInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_WORKORDERDelete] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_WORKORDERDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_WORKORDERDelete];
GO

CREATE PROCEDURE [dbo].[proc_WORKORDERDelete]
(
	@WORKORDERNUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[WORKORDER]
	WHERE
		([WORKORDERNUMBER] = @WORKORDERNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_WORKORDERDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_WORKORDERDelete Error on Creation'
GO 


USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_WORKORDERITEMLoadByPrimaryKey] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_WORKORDERITEMLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_WORKORDERITEMLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_WORKORDERITEMLoadByPrimaryKey]
(
	@WORKORDERITEMNUMBER int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[WORKORDERITEMNUMBER], 
		[WORKORDERNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[CONTAINER], 
		[QTY], 
		[INVITEMNUMBER], 
		[ITEMCOMMENTS], 
		[LOTNUMBER], 
		[WAREHOUSELOCATION], 
		[BILLABLE], 
		[UNITCOST], 
		[ITEMPRICE], 
		[ITEMPROFIT], 
		[UNITORCONTAINER], 
		[UNITS], 
		[UOM], 
		[EXTPRICE], 
		[EXTCOST], 
		[EXTPROFIT], 
		[SOURCETYPE], 
		[SOURCEDOCUMENT], 
		[WORKORDERITEMSTATUS], 
		[CUSTOMERPO], 
		[SHIPMENTITEMNUMBER], 
		[INVOICEITEMNUMBER], 
		[ITEMTYPE]
	FROM [dbo].[WORKORDERITEM]
	WHERE
		([WORKORDERITEMNUMBER] = @WORKORDERITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_WORKORDERITEMLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_WORKORDERITEMLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_WORKORDERITEMLoadAll] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_WORKORDERITEMLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_WORKORDERITEMLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_WORKORDERITEMLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[WORKORDERITEMNUMBER], 
		[WORKORDERNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[CONTAINER], 
		[QTY], 
		[INVITEMNUMBER], 
		[ITEMCOMMENTS], 
		[LOTNUMBER], 
		[WAREHOUSELOCATION], 
		[BILLABLE], 
		[UNITCOST], 
		[ITEMPRICE], 
		[ITEMPROFIT], 
		[UNITORCONTAINER], 
		[UNITS], 
		[UOM], 
		[EXTPRICE], 
		[EXTCOST], 
		[EXTPROFIT], 
		[SOURCETYPE], 
		[SOURCEDOCUMENT], 
		[WORKORDERITEMSTATUS], 
		[CUSTOMERPO], 
		[SHIPMENTITEMNUMBER], 
		[INVOICEITEMNUMBER], 
		[ITEMTYPE]
	FROM [dbo].[WORKORDERITEM]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_WORKORDERITEMLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_WORKORDERITEMLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_WORKORDERITEMUpdate] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_WORKORDERITEMUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_WORKORDERITEMUpdate];
GO

CREATE PROCEDURE [dbo].[proc_WORKORDERITEMUpdate]
(
	@WORKORDERITEMNUMBER int, 
	@WORKORDERNUMBER int, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@QTY numeric(18,4) = NULL, 
	@INVITEMNUMBER int = NULL, 
	@ITEMCOMMENTS varchar(MAX) = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@WAREHOUSELOCATION varchar(50) = NULL, 
	@BILLABLE bit = NULL, 
	@UNITCOST decimal(18,4) = NULL, 
	@ITEMPRICE decimal(18,4) = NULL, 
	@ITEMPROFIT decimal(18,4) = NULL, 
	@UNITORCONTAINER varchar(1) = NULL, 
	@UNITS int = NULL, 
	@UOM varchar(8) = NULL, 
	@EXTPRICE decimal(18,4) = NULL, 
	@EXTCOST decimal(18,4) = NULL, 
	@EXTPROFIT decimal(18,4) = NULL, 
	@SOURCETYPE varchar(50) = NULL, 
	@SOURCEDOCUMENT int = NULL, 
	@WORKORDERITEMSTATUS varchar(50) = NULL, 
	@CUSTOMERPO varchar(50) = NULL, 
	@SHIPMENTITEMNUMBER int = NULL, 
	@INVOICEITEMNUMBER int = NULL, 
	@ITEMTYPE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [WORKORDERITEM]
	SET
		[WORKORDERNUMBER] = @WORKORDERNUMBER, 
		[PRODUCTID] = @PRODUCTID, 
		[PRODUCTDESC] = @PRODUCTDESC, 
		[CONTAINER] = @CONTAINER, 
		[QTY] = @QTY, 
		[INVITEMNUMBER] = @INVITEMNUMBER, 
		[ITEMCOMMENTS] = @ITEMCOMMENTS, 
		[LOTNUMBER] = @LOTNUMBER, 
		[WAREHOUSELOCATION] = @WAREHOUSELOCATION, 
		[BILLABLE] = @BILLABLE, 
		[UNITCOST] = @UNITCOST, 
		[ITEMPRICE] = @ITEMPRICE, 
		[ITEMPROFIT] = @ITEMPROFIT, 
		[UNITORCONTAINER] = @UNITORCONTAINER, 
		[UNITS] = @UNITS, 
		[UOM] = @UOM, 
		[EXTPRICE] = @EXTPRICE, 
		[EXTCOST] = @EXTCOST, 
		[EXTPROFIT] = @EXTPROFIT, 
		[SOURCETYPE] = @SOURCETYPE, 
		[SOURCEDOCUMENT] = @SOURCEDOCUMENT, 
		[WORKORDERITEMSTATUS] = @WORKORDERITEMSTATUS, 
		[CUSTOMERPO] = @CUSTOMERPO, 
		[SHIPMENTITEMNUMBER] = @SHIPMENTITEMNUMBER, 
		[INVOICEITEMNUMBER] = @INVOICEITEMNUMBER, 
		[ITEMTYPE] = @ITEMTYPE
	WHERE
		([WORKORDERITEMNUMBER] = @WORKORDERITEMNUMBER)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_WORKORDERITEMUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_WORKORDERITEMUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_WORKORDERITEMInsert] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_WORKORDERITEMInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_WORKORDERITEMInsert];
GO

CREATE PROCEDURE [dbo].[proc_WORKORDERITEMInsert]
(
	@WORKORDERITEMNUMBER int = NULL OUTPUT, 
	@WORKORDERNUMBER int, 
	@PRODUCTID int = NULL, 
	@PRODUCTDESC varchar(200) = NULL, 
	@CONTAINER varchar(50) = NULL, 
	@QTY numeric(18,4) = NULL, 
	@INVITEMNUMBER int = NULL, 
	@ITEMCOMMENTS varchar(MAX) = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@WAREHOUSELOCATION varchar(50) = NULL, 
	@BILLABLE bit = NULL, 
	@UNITCOST decimal(18,4) = NULL, 
	@ITEMPRICE decimal(18,4) = NULL, 
	@ITEMPROFIT decimal(18,4) = NULL, 
	@UNITORCONTAINER varchar(1) = NULL, 
	@UNITS int = NULL, 
	@UOM varchar(8) = NULL, 
	@EXTPRICE decimal(18,4) = NULL, 
	@EXTCOST decimal(18,4) = NULL, 
	@EXTPROFIT decimal(18,4) = NULL, 
	@SOURCETYPE varchar(50) = NULL, 
	@SOURCEDOCUMENT int = NULL, 
	@WORKORDERITEMSTATUS varchar(50) = NULL, 
	@CUSTOMERPO varchar(50) = NULL, 
	@SHIPMENTITEMNUMBER int = NULL, 
	@INVOICEITEMNUMBER int = NULL, 
	@ITEMTYPE varchar(50) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [WORKORDERITEM]
	(
		[WORKORDERNUMBER], 
		[PRODUCTID], 
		[PRODUCTDESC], 
		[CONTAINER], 
		[QTY], 
		[INVITEMNUMBER], 
		[ITEMCOMMENTS], 
		[LOTNUMBER], 
		[WAREHOUSELOCATION], 
		[BILLABLE], 
		[UNITCOST], 
		[ITEMPRICE], 
		[ITEMPROFIT], 
		[UNITORCONTAINER], 
		[UNITS], 
		[UOM], 
		[EXTPRICE], 
		[EXTCOST], 
		[EXTPROFIT], 
		[SOURCETYPE], 
		[SOURCEDOCUMENT], 
		[WORKORDERITEMSTATUS], 
		[CUSTOMERPO], 
		[SHIPMENTITEMNUMBER], 
		[INVOICEITEMNUMBER], 
		[ITEMTYPE]
	)
	
	VALUES
	(
		@WORKORDERNUMBER, 
		@PRODUCTID, 
		@PRODUCTDESC, 
		@CONTAINER, 
		@QTY, 
		@INVITEMNUMBER, 
		@ITEMCOMMENTS, 
		@LOTNUMBER, 
		@WAREHOUSELOCATION, 
		@BILLABLE, 
		@UNITCOST, 
		@ITEMPRICE, 
		@ITEMPROFIT, 
		@UNITORCONTAINER, 
		@UNITS, 
		@UOM, 
		@EXTPRICE, 
		@EXTCOST, 
		@EXTPROFIT, 
		@SOURCETYPE, 
		@SOURCEDOCUMENT, 
		@WORKORDERITEMSTATUS, 
		@CUSTOMERPO, 
		@SHIPMENTITEMNUMBER, 
		@INVOICEITEMNUMBER, 
		@ITEMTYPE
	)

	SET @Err = @@Error

		
	SELECT @WORKORDERITEMNUMBER = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_WORKORDERITEMInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_WORKORDERITEMInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_WORKORDERITEMDelete] Script Date: 12/10/2013 4:01:18 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_WORKORDERITEMDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_WORKORDERITEMDelete];
GO

CREATE PROCEDURE [dbo].[proc_WORKORDERITEMDelete]
(
	@WORKORDERITEMNUMBER int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[WORKORDERITEM]
	WHERE
		([WORKORDERITEMNUMBER] = @WORKORDERITEMNUMBER)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_WORKORDERITEMDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_WORKORDERITEMDelete Error on Creation'
GO 

