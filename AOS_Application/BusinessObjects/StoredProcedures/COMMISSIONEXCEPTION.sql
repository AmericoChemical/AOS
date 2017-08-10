
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

