USE [ClimaTempoSimples]
GO

/****** Object:  Table [dbo].[Estado]    Script Date: 10/6/2021 6:33:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Estado](
	[Id] [int] NOT NULL,
	[Nome] [nvarchar](200) NOT NULL,
	[UF] [nvarchar](2) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [ClimaTempoSimples]
GO

USE [ClimaTempoSimples]
GO

/****** Object:  Table [dbo].[Cidade]    Script Date: 10/6/2021 6:34:47 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cidade](
	[Id] [int] NOT NULL,
	[Nome] [nvarchar](200) NOT NULL,
	[EstadoId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Cidade]  WITH CHECK ADD  CONSTRAINT [fk_cidade_estado] FOREIGN KEY([EstadoId])
REFERENCES [dbo].[Estado] ([Id])
GO

ALTER TABLE [dbo].[Cidade] CHECK CONSTRAINT [fk_cidade_estado]
GO

USE [ClimaTempoSimples]
GO

/****** Object:  Table [dbo].[PrevisaoClima]    Script Date: 10/6/2021 6:35:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[PrevisaoClima](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CidadeId] [int] NOT NULL,
	[DataPrevisao] [date] NOT NULL,
	[Clima] [nvarchar](15) NOT NULL,
	[TemperaturaMinima] [numeric](3, 1) NULL,
	[TemperaturaMaxima] [numeric](3, 1) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[PrevisaoClima]  WITH CHECK ADD  CONSTRAINT [fk_previsao_cidade] FOREIGN KEY([CidadeId])
REFERENCES [dbo].[Cidade] ([Id])
GO

ALTER TABLE [dbo].[PrevisaoClima] CHECK CONSTRAINT [fk_previsao_cidade]
GO

ALTER TABLE [dbo].[PrevisaoClima]  WITH CHECK ADD CHECK  (([clima]='instavel' OR [clima]='tempestuoso' OR [clima]='chuvoso' OR [clima]='nublado' OR [clima]='ensolarado'))
GO

