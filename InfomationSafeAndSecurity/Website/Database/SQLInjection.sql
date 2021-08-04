GO
/****** Object:  Table [dbo].[Products]    Script Date: 11/07/2021 12:36:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[Id] [int] NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
	[Description] [nvarchar](500) NOT NULL,
	[ImageUrl] [varchar](250) NULL,
	[Price] [bigint] NOT NULL,
	[Status] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedBy] [varchar](20) NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/07/2021 12:36:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Username] [varchar](20) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Status] [int] NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Products] ([Id], [Name], [Description], [ImageUrl], [Price], [Status], [CreatedDate], [CreatedBy]) VALUES (1, N'Điện thoại iPhone 12 Pro Max 128GB', N'iPhone 12 Pro Max 128 GB một siêu phẩm smartphone đến từ Apple. Máy có một hiệu năng hoàn toàn mạnh mẽ đáp ứng tốt nhiều nhu cầu đến từ người dùng và mang trong mình một thiết kế đầy vuông vức, sang trọng.  "Siêu phẩm công nghệ" với nhiều nâng cấp mạnh mẽ về thiết kế, cấu hình và hiệu năng, khẳng định đẳng cấp thời thượng trên thị trường smartphone cao cấp.', N'/images/iPhone12ProMax128GB.jpg', 30990000, 1, CAST(N'2020-11-23T08:55:38.270' AS DateTime), N'admin')
GO
INSERT [dbo].[Users] ([Username], [Password], [Name], [Status]) VALUES (N'admin', N'admin123', N'Quản trị', 1)
GO
ALTER TABLE [dbo].[Products] ADD  CONSTRAINT [DF_Products_Status]  DEFAULT ((1)) FOR [Status]
GO
ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [DF_Users_Status]  DEFAULT ((1)) FOR [Status]
GO
/****** Object:  StoredProcedure [dbo].[Custom_News_Get_List]    Script Date: 11/07/2021 12:36:15 PM ******/
SET ANSI_NULLS OFF
GO
SET QUOTED_IDENTIFIER ON
GO







/*
----------------------------------------------------------------------------------------------------

-- Created By: MTSoftware (www.mtsoftware.com.vn)
-- Purpose: Gets list records from the QL_SanPham table
----------------------------------------------------------------------------------------------------
*/

--exec Custom_QL_SanPham_Get_List 0,'',0,'','',0,0,1,100

CREATE PROCEDURE [dbo].[Custom_News_Get_List] 
(
	@NewsId			int,
	@CategoryId		int,
	@Title			nvarchar(250),
	@Language		varchar(10),
	@PageIndex		int,
	@PageSize		int
)
AS
	SET NOCOUNT ON

	SELECT 	TT.Id,
			TT.CategoryId,
			LT.NewsCategoryName,
			TT.Title,
			TT.MetaTitle,
			TT.Description,
			TT.ImageUrl,
			TT.Source,
			TT.ViewCount,
			TT.CreatedDate,
			ROW_NUMBER() OVER (ORDER BY TT.CreatedDate DESC) as RowNumber,
			CONVERT(int, CEILING(CAST(COUNT(*) OVER () AS DECIMAL(10, 2))/CAST(@PageSize AS DECIMAL(10, 2)))) as TotalPages
	   FROM	   
			dbo.News as TT INNER JOIN
			(SELECT Id, 
					[Name] as NewsCategoryName
			   FROM dbo.NewsCategories
			  WHERE ([Status]=1)
			) as LT ON TT.CategoryId=LT.Id
	  WHERE
			(TT.[Status]=1) AND
			(TT.[Language]=@Language) AND
			(LEN(@Title)=0 OR TT.Title Like N'%' + @Title + '%') AND
			(@NewsId=0 OR TT.Id<>@NewsId) AND
			(@CategoryId=0 OR TT.CategoryId=@CategoryId)
   ORDER BY RowNumber ASC
			OFFSET ((@PageIndex-1) * @PageSize) ROWS 
			FETCH NEXT @PageSize ROWS ONLY;

GO
