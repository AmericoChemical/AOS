
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PRODTIMELoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODTIMELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODTIMELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PRODTIMELoadByPrimaryKey]
(
	@RecID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[ProdOrderNum], 
		[Who], 
		[Starttime], 
		[Endtime], 
		[LaborHrs], 
		[Completed]
	FROM [dbo].[PRODTIME]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODTIMELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODTIMELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODTIMELoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODTIMELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODTIMELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PRODTIMELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[RecID], 
		[ProdOrderNum], 
		[Who], 
		[Starttime], 
		[Endtime], 
		[LaborHrs], 
		[Completed]
	FROM [dbo].[PRODTIME]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODTIMELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODTIMELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODTIMEUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODTIMEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODTIMEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PRODTIMEUpdate]
(
	@RecID int, 
	@ProdOrderNum int, 
	@Who varchar(50), 
	@Starttime datetime, 
	@Endtime datetime, 
	@LaborHrs decimal(18,2), 
	@Completed bit
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PRODTIME]
	SET
		[ProdOrderNum] = @ProdOrderNum, 
		[Who] = @Who, 
		[Starttime] = @Starttime, 
		[Endtime] = @Endtime, 
		[LaborHrs] = @LaborHrs, 
		[Completed] = @Completed
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODTIMEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODTIMEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODTIMEInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODTIMEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODTIMEInsert];
GO

CREATE PROCEDURE [dbo].[proc_PRODTIMEInsert]
(
	@RecID int = NULL OUTPUT, 
	@ProdOrderNum int, 
	@Who varchar(50), 
	@Starttime datetime, 
	@Endtime datetime, 
	@LaborHrs decimal(18,2), 
	@Completed bit
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PRODTIME]
	(
		[ProdOrderNum], 
		[Who], 
		[Starttime], 
		[Endtime], 
		[LaborHrs], 
		[Completed]
	)
	
	VALUES
	(
		@ProdOrderNum, 
		@Who, 
		@Starttime, 
		@Endtime, 
		@LaborHrs, 
		@Completed
	)

	SET @Err = @@Error

		
	SELECT @RecID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODTIMEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODTIMEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODTIMEDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODTIMEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODTIMEDelete];
GO

CREATE PROCEDURE [dbo].[proc_PRODTIMEDelete]
(
	@RecID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PRODTIME]
	WHERE
		([RecID] = @RecID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODTIMEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODTIMEDelete Error on Creation'
GO 

