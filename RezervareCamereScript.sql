USE [RezervareCamere]
GO
/****** Object:  Table [dbo].[Camere]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Camere](
	[IdCamera] [int] IDENTITY(1,1) NOT NULL,
	[NrCamera] [int] NOT NULL,
	[NrLocuri] [int] NOT NULL,
	[Etaj] [int] NOT NULL,
	[PretZi] [decimal](18, 0) NOT NULL,
	[SpImagine] [varbinary](max) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clienti]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clienti](
	[IdClient] [int] IDENTITY(1,1) NOT NULL,
	[NumeClient] [nvarchar](max) NOT NULL,
	[NrTelefon] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[IdClient] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rezervari]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rezervari](
	[IdRezervare] [int] IDENTITY(1,1) NOT NULL,
	[DataRezervarii] [datetime] NOT NULL,
	[IdClient] [int] NOT NULL,
 CONSTRAINT [PK_Rezervari] PRIMARY KEY CLUSTERED 
(
	[IdRezervare] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RezervariContinut]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RezervariContinut](
	[IdRezervare] [int] NOT NULL,
	[Nrc] [int] IDENTITY(1,1) NOT NULL,
	[IdCamera] [int] NOT NULL,
	[DataCazarii] [datetime] NOT NULL,
	[NrZile] [int] NOT NULL,
 CONSTRAINT [PK_RezervariContinut] PRIMARY KEY CLUSTERED 
(
	[Nrc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Utilizatori]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Utilizatori](
	[IdUtilizator] [int] NOT NULL,
	[Nume] [nvarchar](50) NOT NULL,
	[Parola] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Utilizatori] PRIMARY KEY CLUSTERED 
(
	[IdUtilizator] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[actalizareCamera]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actalizareCamera]
(
@IdCamera int,
@NrCamera int,
@NrLocuri int, 
@Etaj int,
@PretZi decimal,
@SpImagine varbinary(max)
)
as
begin
update Camere set NrCamera=@NrCamera,NrLocuri=@NrLocuri,Etaj=@Etaj,PretZi=@PretZi,SpImagine=@SpImagine where IdCamera=@IdCamera
end
GO
/****** Object:  StoredProcedure [dbo].[actalizareClient]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[actalizareClient]
(
@IdClient int,
@NumeClient nvarchar(50),
@NrTelefon nvarchar(50)
)
as
begin
update Clienti set NumeClient=@NumeClient,NrTelefon=@NrTelefon where IdClient=@IdClient
end
GO
/****** Object:  StoredProcedure [dbo].[actaulizareDetaliiRezervare]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actaulizareDetaliiRezervare]
(
@Nrc int,
@IdCamera int,
@DataCazarii datetime,
@NrZile int
)
as
begin
update RezervariContinut set IdCamera=@IdCamera,DataCazarii=@DataCazarii,NrZile=@NrZile where Nrc=@Nrc
end
GO
/****** Object:  StoredProcedure [dbo].[actualizareRezervare]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[actualizareRezervare]
(
@IdRezervare int,
@IdClient int
)
as
begin
update Rezervari set IdClient=@IdClient where IdRezervare=@IdRezervare
end
GO
/****** Object:  StoredProcedure [dbo].[adaugareCamera]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[adaugareCamera]
(
@NrCamera int,
@NrLocuri int,
@Etaj int,
@PretZi decimal,
@SpImagine varbinary(max)
)
as
begin
insert into Camere (NrCamera,NrLocuri,Etaj,PretZi,SpImagine) values(@NrCamera,@NrLocuri,@Etaj,@PretZi,@SpImagine)
end
GO
/****** Object:  StoredProcedure [dbo].[adaugareClient]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[adaugareClient]
(
@NumeClient nvarchar(50),
@NrTelefon nvarchar(50)
)
as
begin
insert into Clienti(NumeClient,NrTelefon) values(@NumeClient,@NrTelefon)
end
GO
/****** Object:  StoredProcedure [dbo].[adaugareDetaliiRezervare]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create PROCEDURE [dbo].[adaugareDetaliiRezervare]
(
    @IdRezervare int,
	@IdCamera int,
	@DataCazarii datetime,
	@NrZile int
)
as
begin
insert into RezervariContinut(IdRezervare,IdCamera,DataCazarii,NrZile) values(@IdRezervare,@IdCamera,@DataCazarii,@NrZile)
end
GO
/****** Object:  StoredProcedure [dbo].[adaugareRezervare]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[adaugareRezervare]
(
    @IdClient int,
	@DataRezervarii datetime
)
as
begin
insert into Rezervari(IdClient,DataRezervarii) values(@IdClient,@DataRezervarii)
end
GO
/****** Object:  StoredProcedure [dbo].[getCamere]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getCamere]
as
begin
set nocount on;
select IdCamera,NrCamera from Camere order by NrCamera asc
end
GO
/****** Object:  StoredProcedure [dbo].[getClient]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getClient]
as
begin
set nocount on;
select IdClient,NumeClient from Clienti order by NumeClient asc
end
GO
/****** Object:  StoredProcedure [dbo].[getRezervari_DupaNume]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[getRezervari_DupaNume]
(
@IdClient int
)
as
begin
set nocount on;
select r.IdRezervare,r.DataRezervarii,c.NumeClient,r.IdClient from Rezervari as r 
INNER JOIN Clienti as c on r.IdClient = c.IdClient
where r.IdClient=@IdClient
end
GO
/****** Object:  StoredProcedure [dbo].[stergeCamera]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stergeCamera]
(
@IdCamera int 
)
as
begin
Delete from Camere where IdCamera=@IdCamera
end
GO
/****** Object:  StoredProcedure [dbo].[stergeClient]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[stergeClient]
(
@IdClient int 
)
as
begin
Delete from Clienti where IdClient=@IdClient
end
GO
/****** Object:  StoredProcedure [dbo].[stergeRezervare]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stergeRezervare]
(
@IdRezervare int 
)
as
begin
Delete from Rezervari where IdRezervare=@IdRezervare
end
GO
/****** Object:  StoredProcedure [dbo].[stergeRezervareContinut]    Script Date: 13.01.2024 23:15:00 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[stergeRezervareContinut]
(
@Nrc int 
)
as
begin
Delete from RezervariContinut where Nrc=@Nrc
end
GO
