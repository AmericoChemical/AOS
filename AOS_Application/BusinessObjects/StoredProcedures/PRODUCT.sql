
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

