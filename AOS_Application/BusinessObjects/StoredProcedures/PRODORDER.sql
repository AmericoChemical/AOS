
USE [AOSData]
GO

/****** Object:  StoredProcedure [dbo].[proc_PRODORDERLoadByPrimaryKey] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODORDERLoadByPrimaryKey]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODORDERLoadByPrimaryKey];
GO

CREATE PROCEDURE [dbo].[proc_PRODORDERLoadByPrimaryKey]
(
	@PRODORDERNUM int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODORDERNUM], 
		[PRODORDERDATE], 
		[CREATEDBY], 
		[PRODUCTID], 
		[PRODUCTQTY], 
		[APISNUM], 
		[CUSTID], 
		[LOTNUMBER], 
		[NEEDEDBY], 
		[ISCOMPLETE], 
		[UNITCOST], 
		[WORKORDERNUMBER], 
		[COMPLETIONTIME], 
		[WORKORDERITEMNUMBER], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[WAREHOUSEID]
	FROM [dbo].[PRODORDER]
	WHERE
		([PRODORDERNUM] = @PRODORDERNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO	


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODORDERLoadByPrimaryKey Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODORDERLoadByPrimaryKey Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODORDERLoadAll] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODORDERLoadAll]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODORDERLoadAll];
GO

CREATE PROCEDURE [dbo].[proc_PRODORDERLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[PRODORDERNUM], 
		[PRODORDERDATE], 
		[CREATEDBY], 
		[PRODUCTID], 
		[PRODUCTQTY], 
		[APISNUM], 
		[CUSTID], 
		[LOTNUMBER], 
		[NEEDEDBY], 
		[ISCOMPLETE], 
		[UNITCOST], 
		[WORKORDERNUMBER], 
		[COMPLETIONTIME], 
		[WORKORDERITEMNUMBER], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[WAREHOUSEID]
	FROM [dbo].[PRODORDER]

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODORDERLoadAll Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODORDERLoadAll Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODORDERUpdate] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODORDERUpdate]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODORDERUpdate];
GO

CREATE PROCEDURE [dbo].[proc_PRODORDERUpdate]
(
	@PRODORDERNUM int, 
	@PRODORDERDATE datetime = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTQTY int = NULL, 
	@APISNUM int = NULL, 
	@CUSTID int = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@NEEDEDBY datetime = NULL, 
	@ISCOMPLETE bit, 
	@UNITCOST money = NULL, 
	@WORKORDERNUMBER int = NULL, 
	@COMPLETIONTIME datetime = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@WAREHOUSEID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	UPDATE [PRODORDER]
	SET
		[PRODORDERDATE] = @PRODORDERDATE, 
		[CREATEDBY] = @CREATEDBY, 
		[PRODUCTID] = @PRODUCTID, 
		[PRODUCTQTY] = @PRODUCTQTY, 
		[APISNUM] = @APISNUM, 
		[CUSTID] = @CUSTID, 
		[LOTNUMBER] = @LOTNUMBER, 
		[NEEDEDBY] = @NEEDEDBY, 
		[ISCOMPLETE] = @ISCOMPLETE, 
		[UNITCOST] = @UNITCOST, 
		[WORKORDERNUMBER] = @WORKORDERNUMBER, 
		[COMPLETIONTIME] = @COMPLETIONTIME, 
		[WORKORDERITEMNUMBER] = @WORKORDERITEMNUMBER, 
		[CREATEDTIME] = @CREATEDTIME, 
		[MODIFYBY] = @MODIFYBY, 
		[MODIFYTIME] = @MODIFYTIME, 
		[WAREHOUSEID] = @WAREHOUSEID
	WHERE
		([PRODORDERNUM] = @PRODORDERNUM)

	SET @Err = @@Error


	RETURN @Err
END
GO



-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODORDERUpdate Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODORDERUpdate Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODORDERInsert] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODORDERInsert]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODORDERInsert];
GO

CREATE PROCEDURE [dbo].[proc_PRODORDERInsert]
(
	@PRODORDERNUM int = NULL OUTPUT, 
	@PRODORDERDATE datetime = NULL, 
	@CREATEDBY varchar(50) = NULL, 
	@PRODUCTID int = NULL, 
	@PRODUCTQTY int = NULL, 
	@APISNUM int = NULL, 
	@CUSTID int = NULL, 
	@LOTNUMBER varchar(50) = NULL, 
	@NEEDEDBY datetime = NULL, 
	@ISCOMPLETE bit, 
	@UNITCOST money = NULL, 
	@WORKORDERNUMBER int = NULL, 
	@COMPLETIONTIME datetime = NULL, 
	@WORKORDERITEMNUMBER int = NULL, 
	@CREATEDTIME datetime = NULL, 
	@MODIFYBY varchar(50) = NULL, 
	@MODIFYTIME datetime = NULL, 
	@WAREHOUSEID int = NULL
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	

	INSERT
	INTO [PRODORDER]
	(
		[PRODORDERDATE], 
		[CREATEDBY], 
		[PRODUCTID], 
		[PRODUCTQTY], 
		[APISNUM], 
		[CUSTID], 
		[LOTNUMBER], 
		[NEEDEDBY], 
		[ISCOMPLETE], 
		[UNITCOST], 
		[WORKORDERNUMBER], 
		[COMPLETIONTIME], 
		[WORKORDERITEMNUMBER], 
		[CREATEDTIME], 
		[MODIFYBY], 
		[MODIFYTIME], 
		[WAREHOUSEID]
	)
	
	VALUES
	(
		@PRODORDERDATE, 
		@CREATEDBY, 
		@PRODUCTID, 
		@PRODUCTQTY, 
		@APISNUM, 
		@CUSTID, 
		@LOTNUMBER, 
		@NEEDEDBY, 
		@ISCOMPLETE, 
		@UNITCOST, 
		@WORKORDERNUMBER, 
		@COMPLETIONTIME, 
		@WORKORDERITEMNUMBER, 
		@CREATEDTIME, 
		@MODIFYBY, 
		@MODIFYTIME, 
		@WAREHOUSEID
	)

	SET @Err = @@Error

		
	SELECT @PRODORDERNUM = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODORDERInsert Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODORDERInsert Error on Creation'
GO 


/****** Object:  StoredProcedure [dbo].[proc_PRODORDERDelete] Script Date: 12/10/2013 4:01:17 PM ******/
IF EXISTS (SELECT * FROM dbo.sysobjects WHERE id = OBJECT_ID(N'[dbo].[proc_PRODORDERDelete]') AND OBJECTPROPERTY(id,N'IsProcedure') = 1)
    DROP PROCEDURE [dbo].[proc_PRODORDERDelete];
GO

CREATE PROCEDURE [dbo].[proc_PRODORDERDelete]
(
	@PRODORDERNUM int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[PRODORDER]
	WHERE
		([PRODORDERNUM] = @PRODORDERNUM)

	SET @Err = @@Error

	RETURN @Err
END
GO


-- Display the status of Proc creation
IF (@@Error = 0) PRINT 'Procedure Creation: proc_PRODORDERDelete Succeeded'
ELSE PRINT 'Procedure Creation: proc_PRODORDERDelete Error on Creation'
GO 

