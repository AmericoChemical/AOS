
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_APISHISTORYLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISHISTORYLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISHISTORYLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_APISHISTORYLoadByPrimaryKey]
(
	@APISCHANGEID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISCHANGEID], 
		[APISNUM], 
		[CHANGEDATE], 
		[WHOCHANGED], 
		[REASONFORCHANGE]
	FROM [dbo].[APISHISTORY]
	WHERE
		([APISCHANGEID] = @APISCHANGEID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISHISTORYLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISHISTORYLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISHISTORYLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISHISTORYLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISHISTORYLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_APISHISTORYLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[APISCHANGEID], 
		[APISNUM], 
		[CHANGEDATE], 
		[WHOCHANGED], 
		[REASONFORCHANGE]
	FROM [dbo].[APISHISTORY]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISHISTORYLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISHISTORYLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISHISTORYUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISHISTORYUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISHISTORYUpdate];
GO

CREATE PROCEDURE [dbo].[proc_APISHISTORYUpdate]
(
	@APISCHANGEID int, 
	@APISNUM int = NULL, 
	@CHANGEDATE datetime = NULL, 
	@WHOCHANGED varchar(50) = NULL, 
	@REASONFORCHANGE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [APISHISTORY]
	SET
		[APISNUM] = @APISNUM, 
		[CHANGEDATE] = @CHANGEDATE, 
		[WHOCHANGED] = @WHOCHANGED, 
		[REASONFORCHANGE] = @REASONFORCHANGE
	WHERE
		([APISCHANGEID] = @APISCHANGEID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISHISTORYUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISHISTORYUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISHISTORYInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISHISTORYInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISHISTORYInsert];
GO

CREATE PROCEDURE [dbo].[proc_APISHISTORYInsert]
(
	@APISCHANGEID int = NULL OUTPUT, 
	@APISNUM int = NULL, 
	@CHANGEDATE datetime = NULL, 
	@WHOCHANGED varchar(50) = NULL, 
	@REASONFORCHANGE varchar(MAX) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [APISHISTORY]
	(
		[APISNUM], 
		[CHANGEDATE], 
		[WHOCHANGED], 
		[REASONFORCHANGE]
	)
	
	VALUES
	(
		@APISNUM, 
		@CHANGEDATE, 
		@WHOCHANGED, 
		@REASONFORCHANGE
	)

	SET @Err = @@Error

		
	SELECT @APISCHANGEID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISHISTORYInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISHISTORYInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_APISHISTORYDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_APISHISTORYDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_APISHISTORYDelete];
GO

CREATE PROCEDURE [dbo].[proc_APISHISTORYDelete]
(
	@APISCHANGEID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[APISHISTORY]
	WHERE
		([APISCHANGEID] = @APISCHANGEID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_APISHISTORYDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_APISHISTORYDelete Error on Creation'
GO 

