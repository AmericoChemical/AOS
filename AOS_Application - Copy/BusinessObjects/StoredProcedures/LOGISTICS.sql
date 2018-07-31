
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

