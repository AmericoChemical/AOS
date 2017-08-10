

USE [AOSDev]
GO

/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERLoadByPrimaryKey] Script Date: 6/10/2014 12:12:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERLoadByPrimaryKey]
(
	@Custid int
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
		[NEEDPACKINGLIST], 
		[SALESBYCUSTOMERREPORT], 
		[SECONDARYSALESPERSONID], 
		[TRENDANALYSISREPORT], 
		[ACCOUNTTYPE], 
		[ACCOUNTSTATUS], 
		[PRODFULFILLMENTNOTES], 
		[TRANSPORTATIONNOTES], 
		[BILLOFLADINGNOTES], 
		[ACCOUNTINGNOTES], 
		[ISCONSIGNMENT]
	FROM [dbo].[CUSTOMER]
	WHERE
		([CUSTID] = @Custid)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERLoadAll] Script Date: 6/10/2014 12:12:05 PM ******/
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
		[NEEDPACKINGLIST], 
		[SALESBYCUSTOMERREPORT], 
		[SECONDARYSALESPERSONID], 
		[TRENDANALYSISREPORT], 
		[ACCOUNTTYPE], 
		[ACCOUNTSTATUS], 
		[PRODFULFILLMENTNOTES], 
		[TRANSPORTATIONNOTES], 
		[BILLOFLADINGNOTES], 
		[ACCOUNTINGNOTES], 
		[ISCONSIGNMENT]
	FROM [dbo].[CUSTOMER]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERUpdate] Script Date: 6/10/2014 12:12:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERUpdate];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERUpdate]
(
	@Custid int, 
	@Custname varchar(50) = NULL, 
	@Custbilladdress1 varchar(50) = NULL, 
	@Custbilladdress2 varchar(50) = NULL, 
	@Custbillcity varchar(50) = NULL, 
	@Custbillstateprov varchar(50) = NULL, 
	@Custbillpostalcode varchar(24) = NULL, 
	@Custbillcountry varchar(50) = NULL, 
	@Custphone varchar(24) = NULL, 
	@Custfax varchar(24) = NULL, 
	@Custbillcontact varchar(50) = NULL, 
	@Custshipaddress1 varchar(50) = NULL, 
	@Custshipaddress2 varchar(50) = NULL, 
	@Custshipcity varchar(50) = NULL, 
	@Custshipstateprov varchar(50) = NULL, 
	@Custshippostalcode varchar(24) = NULL, 
	@Custshipcountry varchar(50) = NULL, 
	@Custshipcontact varchar(50) = NULL, 
	@Freightcarrier1 varchar(50) = NULL, 
	@Freightcarrier2 varchar(50) = NULL, 
	@Fob varchar(24) = NULL, 
	@Custnotes varchar(MAX) = NULL, 
	@Taxexempt nvarchar(1) = NULL, 
	@Createdby varchar(50) = NULL, 
	@Createdtime datetime = NULL, 
	@Modifyby varchar(50) = NULL, 
	@Modifytime datetime = NULL, 
	@Isactive bit = NULL, 
	@Carrierid int = NULL, 
	@Logisticsid int = NULL, 
	@Bulkcarrierid int = NULL, 
	@Salespersonid int = NULL, 
	@Freightbillcustomer bit = NULL, 
	@Freightoninvoice bit = NULL, 
	@Ordernote varchar(MAX) = NULL, 
	@Shipmentnote varchar(MAX) = NULL, 
	@Invoicenote varchar(MAX) = NULL, 
	@Custemail varchar(200) = NULL, 
	@Needpackinglist bit = NULL, 
	@Salesbycustomerreport bit, 
	@Secondarysalespersonid int = NULL, 
	@Trendanalysisreport bit, 
	@Accounttype varchar(50) = NULL, 
	@Accountstatus varchar(50) = NULL, 
	@Prodfulfillmentnotes varchar(MAX) = NULL, 
	@Transportationnotes varchar(MAX) = NULL, 
	@Billofladingnotes varchar(MAX) = NULL, 
	@Accountingnotes varchar(MAX) = NULL, 
	@Isconsignment bit = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CUSTOMER]
	SET
		[CUSTNAME] = @Custname, 
		[CUSTBILLADDRESS1] = @Custbilladdress1, 
		[CUSTBILLADDRESS2] = @Custbilladdress2, 
		[CUSTBILLCITY] = @Custbillcity, 
		[CUSTBILLSTATEPROV] = @Custbillstateprov, 
		[CUSTBILLPOSTALCODE] = @Custbillpostalcode, 
		[CUSTBILLCOUNTRY] = @Custbillcountry, 
		[CUSTPHONE] = @Custphone, 
		[CUSTFAX] = @Custfax, 
		[CUSTBILLCONTACT] = @Custbillcontact, 
		[CUSTSHIPADDRESS1] = @Custshipaddress1, 
		[CUSTSHIPADDRESS2] = @Custshipaddress2, 
		[CUSTSHIPCITY] = @Custshipcity, 
		[CUSTSHIPSTATEPROV] = @Custshipstateprov, 
		[CUSTSHIPPOSTALCODE] = @Custshippostalcode, 
		[CUSTSHIPCOUNTRY] = @Custshipcountry, 
		[CUSTSHIPCONTACT] = @Custshipcontact, 
		[FREIGHTCARRIER1] = @Freightcarrier1, 
		[FREIGHTCARRIER2] = @Freightcarrier2, 
		[FOB] = @Fob, 
		[CUSTNOTES] = @Custnotes, 
		[TAXEXEMPT] = @Taxexempt, 
		[CREATEDBY] = @Createdby, 
		[CREATEDTIME] = @Createdtime, 
		[MODIFYBY] = @Modifyby, 
		[MODIFYTIME] = @Modifytime, 
		[ISACTIVE] = @Isactive, 
		[CARRIERID] = @Carrierid, 
		[LOGISTICSID] = @Logisticsid, 
		[BULKCARRIERID] = @Bulkcarrierid, 
		[SALESPERSONID] = @Salespersonid, 
		[FREIGHTBILLCUSTOMER] = @Freightbillcustomer, 
		[FREIGHTONINVOICE] = @Freightoninvoice, 
		[ORDERNOTE] = @Ordernote, 
		[SHIPMENTNOTE] = @Shipmentnote, 
		[INVOICENOTE] = @Invoicenote, 
		[CUSTEMAIL] = @Custemail, 
		[NEEDPACKINGLIST] = @Needpackinglist, 
		[SALESBYCUSTOMERREPORT] = @Salesbycustomerreport, 
		[SECONDARYSALESPERSONID] = @Secondarysalespersonid, 
		[TRENDANALYSISREPORT] = @Trendanalysisreport, 
		[ACCOUNTTYPE] = @Accounttype, 
		[ACCOUNTSTATUS] = @Accountstatus, 
		[PRODFULFILLMENTNOTES] = @Prodfulfillmentnotes, 
		[TRANSPORTATIONNOTES] = @Transportationnotes, 
		[BILLOFLADINGNOTES] = @Billofladingnotes, 
		[ACCOUNTINGNOTES] = @Accountingnotes, 
		[ISCONSIGNMENT] = @Isconsignment
	WHERE
		([CUSTID] = @Custid)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERInsert] Script Date: 6/10/2014 12:12:05 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERInsert];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERInsert]
(
	@Custid int = NULL OUTPUT, 
	@Custname varchar(50) = NULL, 
	@Custbilladdress1 varchar(50) = NULL, 
	@Custbilladdress2 varchar(50) = NULL, 
	@Custbillcity varchar(50) = NULL, 
	@Custbillstateprov varchar(50) = NULL, 
	@Custbillpostalcode varchar(24) = NULL, 
	@Custbillcountry varchar(50) = NULL, 
	@Custphone varchar(24) = NULL, 
	@Custfax varchar(24) = NULL, 
	@Custbillcontact varchar(50) = NULL, 
	@Custshipaddress1 varchar(50) = NULL, 
	@Custshipaddress2 varchar(50) = NULL, 
	@Custshipcity varchar(50) = NULL, 
	@Custshipstateprov varchar(50) = NULL, 
	@Custshippostalcode varchar(24) = NULL, 
	@Custshipcountry varchar(50) = NULL, 
	@Custshipcontact varchar(50) = NULL, 
	@Freightcarrier1 varchar(50) = NULL, 
	@Freightcarrier2 varchar(50) = NULL, 
	@Fob varchar(24) = NULL, 
	@Custnotes varchar(MAX) = NULL, 
	@Taxexempt nvarchar(1) = NULL, 
	@Createdby varchar(50) = NULL, 
	@Createdtime datetime = NULL, 
	@Modifyby varchar(50) = NULL, 
	@Modifytime datetime = NULL, 
	@Isactive bit = NULL, 
	@Carrierid int = NULL, 
	@Logisticsid int = NULL, 
	@Bulkcarrierid int = NULL, 
	@Salespersonid int = NULL, 
	@Freightbillcustomer bit = NULL, 
	@Freightoninvoice bit = NULL, 
	@Ordernote varchar(MAX) = NULL, 
	@Shipmentnote varchar(MAX) = NULL, 
	@Invoicenote varchar(MAX) = NULL, 
	@Custemail varchar(200) = NULL, 
	@Needpackinglist bit = NULL, 
	@Salesbycustomerreport bit, 
	@Secondarysalespersonid int = NULL, 
	@Trendanalysisreport bit, 
	@Accounttype varchar(50) = NULL, 
	@Accountstatus varchar(50) = NULL, 
	@Prodfulfillmentnotes varchar(MAX) = NULL, 
	@Transportationnotes varchar(MAX) = NULL, 
	@Billofladingnotes varchar(MAX) = NULL, 
	@Accountingnotes varchar(MAX) = NULL, 
	@Isconsignment bit = NULL
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
		[NEEDPACKINGLIST], 
		[SALESBYCUSTOMERREPORT], 
		[SECONDARYSALESPERSONID], 
		[TRENDANALYSISREPORT], 
		[ACCOUNTTYPE], 
		[ACCOUNTSTATUS], 
		[PRODFULFILLMENTNOTES], 
		[TRANSPORTATIONNOTES], 
		[BILLOFLADINGNOTES], 
		[ACCOUNTINGNOTES], 
		[ISCONSIGNMENT]
	)
	
	VALUES
	(
		@Custname, 
		@Custbilladdress1, 
		@Custbilladdress2, 
		@Custbillcity, 
		@Custbillstateprov, 
		@Custbillpostalcode, 
		@Custbillcountry, 
		@Custphone, 
		@Custfax, 
		@Custbillcontact, 
		@Custshipaddress1, 
		@Custshipaddress2, 
		@Custshipcity, 
		@Custshipstateprov, 
		@Custshippostalcode, 
		@Custshipcountry, 
		@Custshipcontact, 
		@Freightcarrier1, 
		@Freightcarrier2, 
		@Fob, 
		@Custnotes, 
		@Taxexempt, 
		@Createdby, 
		@Createdtime, 
		@Modifyby, 
		@Modifytime, 
		@Isactive, 
		@Carrierid, 
		@Logisticsid, 
		@Bulkcarrierid, 
		@Salespersonid, 
		@Freightbillcustomer, 
		@Freightoninvoice, 
		@Ordernote, 
		@Shipmentnote, 
		@Invoicenote, 
		@Custemail, 
		@Needpackinglist, 
		@Salesbycustomerreport, 
		@Secondarysalespersonid, 
		@Trendanalysisreport, 
		@Accounttype, 
		@Accountstatus, 
		@Prodfulfillmentnotes, 
		@Transportationnotes, 
		@Billofladingnotes, 
		@Accountingnotes, 
		@Isconsignment
	)


	SET @Err = @@Error

		
	SELECT @Custid = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CUSTOMERDelete] Script Date: 6/10/2014 12:12:06 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CUSTOMERDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CUSTOMERDelete];
GO

CREATE PROCEDURE [dbo].[proc_CUSTOMERDelete]
(
	@Custid int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[CUSTOMER]
	WHERE
		([CUSTID] = @Custid)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CUSTOMERDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CUSTOMERDelete Error on Creation'
GO 

