
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

