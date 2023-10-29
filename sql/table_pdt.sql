USE [stock]
GO

/****** Object:  Table [dbo].[produits]    Script Date: 26/10/2021 18:39:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[produits](
	[N°produit] [int] NOT NULL,
	[libelle] [nchar](100) NULL,
	[stock] [int] NULL,
	[prix achat] [float] NULL,
	[prix vente] [float] NULL,
 CONSTRAINT [PK_produits] PRIMARY KEY CLUSTERED 
(
	[N°produit] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


