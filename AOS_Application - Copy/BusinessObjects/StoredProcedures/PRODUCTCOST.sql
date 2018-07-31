
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

