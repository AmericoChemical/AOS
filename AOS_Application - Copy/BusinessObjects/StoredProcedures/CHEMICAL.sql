
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_CHEMICALLoadByPrimaryKey] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALLoadByPrimaryKey]
(
	@CHEMICALID int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMICALID], 
		[CHEMICALNAME], 
		[CASNUMBER], 
		[pH_LOW], 
		[pH_HIGH], 
		[pH_COMPSYMBOL], 
		[pH_COMPVALUE], 
		[SG_LOW], 
		[SG_HIGH], 
		[SG_COMPSYMBOL], 
		[SG_COMPVALUE], 
		[DOTNAME], 
		[APPEARANCE], 
		[COLOR], 
		[ODOR], 
		[STATE], 
		[DENSITY]
	FROM [dbo].[CHEMICAL]
	WHERE
		([CHEMICALID] = @CHEMICALID)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALLoadAll] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[CHEMICALID], 
		[CHEMICALNAME], 
		[CASNUMBER], 
		[pH_LOW], 
		[pH_HIGH], 
		[pH_COMPSYMBOL], 
		[pH_COMPVALUE], 
		[SG_LOW], 
		[SG_HIGH], 
		[SG_COMPSYMBOL], 
		[SG_COMPVALUE], 
		[DOTNAME], 
		[APPEARANCE], 
		[COLOR], 
		[ODOR], 
		[STATE], 
		[DENSITY]
	FROM [dbo].[CHEMICAL]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALUpdate] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALUpdate];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALUpdate]
(
	@CHEMICALID int, 
	@CHEMICALNAME varchar(200) = NULL, 
	@CASNUMBER varchar(50) = NULL, 
	@pH_LOW decimal(18,3) = NULL, 
	@pH_HIGH decimal(18,3) = NULL, 
	@pH_COMPSYMBOL varchar(8) = NULL, 
	@pH_COMPVALUE decimal(18,3) = NULL, 
	@SG_LOW decimal(18,3) = NULL, 
	@SG_HIGH decimal(18,3) = NULL, 
	@SG_COMPSYMBOL varchar(8) = NULL, 
	@SG_COMPVALUE decimal(18,3) = NULL, 
	@DOTNAME varchar(200) = NULL, 
	@APPEARANCE varchar(50) = NULL, 
	@COLOR varchar(50) = NULL, 
	@ODOR varchar(50) = NULL, 
	@STATE varchar(50) = NULL, 
	@DENSITY decimal(18,3) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [CHEMICAL]
	SET
		[CHEMICALNAME] = @CHEMICALNAME, 
		[CASNUMBER] = @CASNUMBER, 
		[pH_LOW] = @pH_LOW, 
		[pH_HIGH] = @pH_HIGH, 
		[pH_COMPSYMBOL] = @pH_COMPSYMBOL, 
		[pH_COMPVALUE] = @pH_COMPVALUE, 
		[SG_LOW] = @SG_LOW, 
		[SG_HIGH] = @SG_HIGH, 
		[SG_COMPSYMBOL] = @SG_COMPSYMBOL, 
		[SG_COMPVALUE] = @SG_COMPVALUE, 
		[DOTNAME] = @DOTNAME, 
		[APPEARANCE] = @APPEARANCE, 
		[COLOR] = @COLOR, 
		[ODOR] = @ODOR, 
		[STATE] = @STATE, 
		[DENSITY] = @DENSITY
	WHERE
		([CHEMICALID] = @CHEMICALID)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALInsert] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALInsert];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALInsert]
(
	@CHEMICALID int = NULL OUTPUT, 
	@CHEMICALNAME varchar(200) = NULL, 
	@CASNUMBER varchar(50) = NULL, 
	@pH_LOW decimal(18,3) = NULL, 
	@pH_HIGH decimal(18,3) = NULL, 
	@pH_COMPSYMBOL varchar(8) = NULL, 
	@pH_COMPVALUE decimal(18,3) = NULL, 
	@SG_LOW decimal(18,3) = NULL, 
	@SG_HIGH decimal(18,3) = NULL, 
	@SG_COMPSYMBOL varchar(8) = NULL, 
	@SG_COMPVALUE decimal(18,3) = NULL, 
	@DOTNAME varchar(200) = NULL, 
	@APPEARANCE varchar(50) = NULL, 
	@COLOR varchar(50) = NULL, 
	@ODOR varchar(50) = NULL, 
	@STATE varchar(50) = NULL, 
	@DENSITY decimal(18,3) = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [CHEMICAL]
	(
		[CHEMICALNAME], 
		[CASNUMBER], 
		[pH_LOW], 
		[pH_HIGH], 
		[pH_COMPSYMBOL], 
		[pH_COMPVALUE], 
		[SG_LOW], 
		[SG_HIGH], 
		[SG_COMPSYMBOL], 
		[SG_COMPVALUE], 
		[DOTNAME], 
		[APPEARANCE], 
		[COLOR], 
		[ODOR], 
		[STATE], 
		[DENSITY]
	)
	
	VALUES
	(
		@CHEMICALNAME, 
		@CASNUMBER, 
		@pH_LOW, 
		@pH_HIGH, 
		@pH_COMPSYMBOL, 
		@pH_COMPVALUE, 
		@SG_LOW, 
		@SG_HIGH, 
		@SG_COMPSYMBOL, 
		@SG_COMPVALUE, 
		@DOTNAME, 
		@APPEARANCE, 
		@COLOR, 
		@ODOR, 
		@STATE, 
		@DENSITY
	)

	SET @Err = @@Error

		
	SELECT @CHEMICALID = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_CHEMICALDelete] Script Date: 12/10/2013 4:01:04 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_CHEMICALDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_CHEMICALDelete];
GO

CREATE PROCEDURE [dbo].[proc_CHEMICALDelete]
(
	@CHEMICALID int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[CHEMICAL]
	WHERE
		([CHEMICALID] = @CHEMICALID)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_CHEMICALDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_CHEMICALDelete Error on Creation'
GO 

