
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

