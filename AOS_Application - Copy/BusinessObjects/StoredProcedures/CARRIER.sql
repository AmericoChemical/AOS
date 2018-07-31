
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

