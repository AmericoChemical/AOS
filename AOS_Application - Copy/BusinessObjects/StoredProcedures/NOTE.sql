
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_NOTELoadByPrimaryKey] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_NOTELoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_NOTELoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_NOTELoadByPrimaryKey]
(
	@NoteKey int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[NoteKey], 
		[LinkType], 
		[LinkKey], 
		[SourceType], 
		[SourceKey], 
		[NoteText], 
		[CreateTime], 
		[CreateBy], 
		[ModifyTime], 
		[ModifyBy], 
		[IsDeleted]
	FROM [dbo].[NOTE]
	WHERE
		([NoteKey] = @NoteKey)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NOTELoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_NOTELoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_NOTELoadAll] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_NOTELoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_NOTELoadAll];
GO

CREATE PROCEDURE [dbo].[proc_NOTELoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[NoteKey], 
		[LinkType], 
		[LinkKey], 
		[SourceType], 
		[SourceKey], 
		[NoteText], 
		[CreateTime], 
		[CreateBy], 
		[ModifyTime], 
		[ModifyBy], 
		[IsDeleted]
	FROM [dbo].[NOTE]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NOTELoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_NOTELoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_NOTEUpdate] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_NOTEUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_NOTEUpdate];
GO

CREATE PROCEDURE [dbo].[proc_NOTEUpdate]
(
	@NoteKey int, 
	@LinkType varchar(50) = NULL, 
	@LinkKey int = NULL, 
	@SourceType varchar(50) = NULL, 
	@SourceKey int = NULL, 
	@NoteText varchar(MAX) = NULL, 
	@CreateTime datetime = NULL, 
	@CreateBy varchar(50) = NULL, 
	@ModifyTime datetime = NULL, 
	@ModifyBy varchar(50) = NULL, 
	@IsDeleted bit
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [NOTE]
	SET
		[LinkType] = @LinkType, 
		[LinkKey] = @LinkKey, 
		[SourceType] = @SourceType, 
		[SourceKey] = @SourceKey, 
		[NoteText] = @NoteText, 
		[CreateTime] = @CreateTime, 
		[CreateBy] = @CreateBy, 
		[ModifyTime] = @ModifyTime, 
		[ModifyBy] = @ModifyBy, 
		[IsDeleted] = @IsDeleted
	WHERE
		([NoteKey] = @NoteKey)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NOTEUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_NOTEUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_NOTEInsert] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_NOTEInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_NOTEInsert];
GO

CREATE PROCEDURE [dbo].[proc_NOTEInsert]
(
	@NoteKey int = NULL OUTPUT, 
	@LinkType varchar(50) = NULL, 
	@LinkKey int = NULL, 
	@SourceType varchar(50) = NULL, 
	@SourceKey int = NULL, 
	@NoteText varchar(MAX) = NULL, 
	@CreateTime datetime = NULL, 
	@CreateBy varchar(50) = NULL, 
	@ModifyTime datetime = NULL, 
	@ModifyBy varchar(50) = NULL, 
	@IsDeleted bit
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [NOTE]
	(
		[LinkType], 
		[LinkKey], 
		[SourceType], 
		[SourceKey], 
		[NoteText], 
		[CreateTime], 
		[CreateBy], 
		[ModifyTime], 
		[ModifyBy], 
		[IsDeleted]
	)
	
	VALUES
	(
		@LinkType, 
		@LinkKey, 
		@SourceType, 
		@SourceKey, 
		@NoteText, 
		@CreateTime, 
		@CreateBy, 
		@ModifyTime, 
		@ModifyBy, 
		@IsDeleted
	)

	SET @Err = @@Error

		
	SELECT @NoteKey = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NOTEInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_NOTEInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_NOTEDelete] Script Date: 12/10/2013 4:01:16 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_NOTEDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_NOTEDelete];
GO

CREATE PROCEDURE [dbo].[proc_NOTEDelete]
(
	@NoteKey int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[NOTE]
	WHERE
		([NoteKey] = @NoteKey)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_NOTEDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_NOTEDelete Error on Creation'
GO 

