
USE [SMSSmartCare]
GO
SET QUOTED_IDENTIFIER ON 
GO
SET ANSI_NULLS ON 
GO

	

/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Gets records from the MessageTemplate table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usp_MessageTemplate_GetPaged
(

	@WhereClause nvarchar (2000)  ,

	@OrderBy varchar (200)  
)
AS


    SET NOCOUNT OFF
	
    DECLARE @SQL AS nvarchar(2000)
    SET @SQL = 'SELECT'
    SET @SQL = @SQL + '[Id],'
    SET @SQL = @SQL + '[Title],'
    SET @SQL = @SQL + '[ContentText],'
    SET @SQL = @SQL + '[Status],'
    SET @SQL = @SQL + '[CreatedDate],'
    SET @SQL = @SQL + '[Note]'
    SET @SQL = @SQL + ' FROM [dbo].[MessageTemplate]'
    IF LEN(@WhereClause) > 0
    BEGIN
        SET @SQL = @SQL + ' WHERE ' + @WhereClause
    END
    IF (LEN(@OrderBy) > 0)
    BEGIN
        SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
    END
    EXEC sp_executesql @SQL
    

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS ON 
GO

	

/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Gets records from the MessageTemplate table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usp_MessageTemplate_GetRowCount
(

	@WhereClause nvarchar (2000)  
)
AS


    SET NOCOUNT OFF
	
    DECLARE @SQL AS nvarchar(1500)
    SET @SQL = 'SELECT COUNT(Id) as TotalItems' 
    SET @SQL = @SQL + ' FROM [dbo].[MessageTemplate]'
    IF LEN(@WhereClause) > 0
    BEGIN
        SET @SQL = @SQL + ' WHERE ' + @WhereClause
    END
    EXEC sp_executesql @SQL
    

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS ON 
GO

	

/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Inserts a record into the MessageTemplate table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usp_MessageTemplate_Insert
(

	@Id int    OUTPUT,

	@Title nvarchar (255)  ,

	@ContentText nvarchar (180)  ,

	@Status int   ,

	@CreatedDate datetime   ,

	@Note nvarchar (300)  
)
AS


    SET NOCOUNT OFF
    
	INSERT INTO [dbo].[MessageTemplate]
	(
        [Title],
        [ContentText],
        [Status],
        [CreatedDate],
        [Note]
	)
	VALUES
	(
        @Title,
        @ContentText,
        @Status,
        @CreatedDate,
        @Note
	)
	
	-- Get the identity value
	SET @Id = SCOPE_IDENTITY()
						
	

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS ON 
GO

	

/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Updates a record in the MessageTemplate table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usp_MessageTemplate_Update
(

	@Id int   ,

	@Title nvarchar (255)  ,

	@ContentText nvarchar (180)  ,

	@Status int   ,

	@CreatedDate datetime   ,

	@Note nvarchar (300)  
)
AS


    SET NOCOUNT OFF
    
	UPDATE [dbo].[MessageTemplate] SET
           [Title] = @Title,
           [ContentText] = @ContentText,
           [Status] = @Status,
           [CreatedDate] = @CreatedDate,
           [Note] = @Note
	 WHERE [Id] = @Id 

	

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS ON 
GO

	

/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Deletes a record in the MessageTemplate table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usp_MessageTemplate_Delete
(

	@Id int   
)
AS


    SET NOCOUNT OFF
	
    DELETE FROM [dbo].[MessageTemplate] WITH (ROWLOCK) 
	      WHERE [Id] = @Id
	

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS ON 
GO

	

/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Select records from the MessageTemplate table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usp_MessageTemplate_GetById
(

	@Id int   
)
AS


    SET NOCOUNT OFF
    
	SELECT
            [Id],
            [Title],
            [ContentText],
            [Status],
            [CreatedDate],
            [Note]
	  FROM
		    [dbo].[MessageTemplate]
	 WHERE
            [Id] = @Id
	

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS ON 
GO

	

/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Gets records from the MessageHistory table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usp_MessageHistory_GetPaged
(

	@WhereClause nvarchar (2000)  ,

	@OrderBy varchar (200)  
)
AS


    SET NOCOUNT OFF
	
    DECLARE @SQL AS nvarchar(2000)
    SET @SQL = 'SELECT'
    SET @SQL = @SQL + '[Id],'
    SET @SQL = @SQL + '[MessageType],'
    SET @SQL = @SQL + '[FromPhoneNumber],'
    SET @SQL = @SQL + '[ToPhoneNumber],'
    SET @SQL = @SQL + '[ContentText],'
    SET @SQL = @SQL + '[Status],'
    SET @SQL = @SQL + '[CreatedDate],'
    SET @SQL = @SQL + '[SentDate],'
    SET @SQL = @SQL + '[Note]'
    SET @SQL = @SQL + ' FROM [dbo].[MessageHistory]'
    IF LEN(@WhereClause) > 0
    BEGIN
        SET @SQL = @SQL + ' WHERE ' + @WhereClause
    END
    IF (LEN(@OrderBy) > 0)
    BEGIN
        SET @SQL = @SQL + ' ORDER BY ' + @OrderBy
    END
    EXEC sp_executesql @SQL
    

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS ON 
GO

	

/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Gets records from the MessageHistory table passing page index and page count parameters
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usp_MessageHistory_GetRowCount
(

	@WhereClause nvarchar (2000)  
)
AS


    SET NOCOUNT OFF
	
    DECLARE @SQL AS nvarchar(1500)
    SET @SQL = 'SELECT COUNT(Id) as TotalItems' 
    SET @SQL = @SQL + ' FROM [dbo].[MessageHistory]'
    IF LEN(@WhereClause) > 0
    BEGIN
        SET @SQL = @SQL + ' WHERE ' + @WhereClause
    END
    EXEC sp_executesql @SQL
    

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS ON 
GO

	

/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Inserts a record into the MessageHistory table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usp_MessageHistory_Insert
(

	@Id uniqueidentifier   ,

	@MessageType int   ,

	@FromPhoneNumber varchar (15)  ,

	@ToPhoneNumber varchar (15)  ,

	@ContentText nvarchar (180)  ,

	@Status int   ,

	@CreatedDate datetime   ,

	@SentDate datetime   ,

	@Note nvarchar (300)  
)
AS


    SET NOCOUNT OFF
    
	INSERT INTO [dbo].[MessageHistory]
	(
        [Id],
        [MessageType],
        [FromPhoneNumber],
        [ToPhoneNumber],
        [ContentText],
        [Status],
        [CreatedDate],
        [SentDate],
        [Note]
	)
	VALUES
	(
        @Id,
        @MessageType,
        @FromPhoneNumber,
        @ToPhoneNumber,
        @ContentText,
        @Status,
        @CreatedDate,
        @SentDate,
        @Note
	)
	
						
	

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS ON 
GO

	

/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Updates a record in the MessageHistory table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usp_MessageHistory_Update
(

	@Id uniqueidentifier   ,

	@OriginalId uniqueidentifier   ,

	@MessageType int   ,

	@FromPhoneNumber varchar (15)  ,

	@ToPhoneNumber varchar (15)  ,

	@ContentText nvarchar (180)  ,

	@Status int   ,

	@CreatedDate datetime   ,

	@SentDate datetime   ,

	@Note nvarchar (300)  
)
AS


    SET NOCOUNT OFF
    
	UPDATE [dbo].[MessageHistory] SET
           [Id] = @Id,
           [MessageType] = @MessageType,
           [FromPhoneNumber] = @FromPhoneNumber,
           [ToPhoneNumber] = @ToPhoneNumber,
           [ContentText] = @ContentText,
           [Status] = @Status,
           [CreatedDate] = @CreatedDate,
           [SentDate] = @SentDate,
           [Note] = @Note
	 WHERE [Id] = @OriginalId 

	

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS ON 
GO

	

/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Deletes a record in the MessageHistory table
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usp_MessageHistory_Delete
(

	@Id uniqueidentifier   
)
AS


    SET NOCOUNT OFF
	
    DELETE FROM [dbo].[MessageHistory] WITH (ROWLOCK) 
	      WHERE [Id] = @Id
	

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS ON 
GO

	

/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Select records from the MessageHistory table through an index
----------------------------------------------------------------------------------------------------
*/


CREATE PROCEDURE dbo.usp_MessageHistory_GetById
(

	@Id uniqueidentifier   
)
AS


    SET NOCOUNT OFF
    
	SELECT
            [Id],
            [MessageType],
            [FromPhoneNumber],
            [ToPhoneNumber],
            [ContentText],
            [Status],
            [CreatedDate],
            [SentDate],
            [Note]
	  FROM
		    [dbo].[MessageHistory]
	 WHERE
            [Id] = @Id
	

GO
SET QUOTED_IDENTIFIER ON 
GO
SET NOCOUNT ON
GO
SET ANSI_NULLS ON 
GO

