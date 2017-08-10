
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

