
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

