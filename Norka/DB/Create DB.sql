USE [Norka]
GO
/****** Object:  Table [dbo].[Zeichnungsdruck]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zeichnungsdruck](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Artikel] [nvarchar](50) NULL,
	[VW_Typ] [int] NULL,
	[VW_Breite] [float] NULL,
	[VW_Hoehe] [float] NULL,
	[VW_Bodenfreiheit] [float] NULL,
	[VW_Tuerbreite] [float] NULL,
	[VW_SchildLinks] [float] NULL,
	[VW_SchildRechts] [float] NULL,
	[VW_Schildhoehe] [float] NULL,
	[VW_Tuerhoehe] [float] NULL,
	[VW_PlatteSchildLinks] [float] NULL,
	[VW_PlatteSchildRechts] [float] NULL,
	[VW_Verbindungsstueck] [float] NULL,
	[VW_Verstaerkung] [float] NULL,
	[VW_Tuere] [float] NULL,
	[TEXT_Beschreibung] [nvarchar](max) NULL,
	[RK_Typ] [int] NULL,
	[RK_Breite] [float] NULL,
	[RK_Hoehe] [float] NULL,
	[RK_Bodenfreiheit] [float] NULL,
	[RK_Tuerbreite] [float] NULL,
	[RK_Tueranzahl] [float] NULL,
	[RK_Trennwand] [float] NULL,
	[RK_SchildLinks] [float] NULL,
	[RK_SchildRechts] [float] NULL,
	[RK_Schildhoehe] [float] NULL,
	[RK_Tuerhoehe] [float] NULL,
	[RK_Mittelschild] [float] NULL,
	[RK_Tuere] [float] NULL,
	[RK_PlatteTrennwand] [float] NULL,
	[RK_PlatteSchildLinks] [float] NULL,
	[RK_PlatteSchildRechts] [float] NULL,
	[RK_PlatteMittelschild] [float] NULL,
	[RK_Aussen] [float] NULL,
	[RK_Alu] [float] NULL,
	[RK_Verbindungsstueck] [float] NULL,
	[EK_Typ] [int] NULL,
	[EK_Breite] [float] NULL,
	[EK_Hohe] [float] NULL,
	[EK_Bodenfreiheit] [float] NULL,
	[EK_Tuerbreite] [float] NULL,
	[EK_Tueranzahl] [float] NULL,
	[EK_Trennwand] [float] NULL,
	[EK_Wandschild] [float] NULL,
	[EK_Eckschild] [float] NULL,
	[EK_SchildHoehe] [float] NULL,
	[EK_Tuerhoehe] [float] NULL,
	[EK_Mittelschild] [float] NULL,
	[EK_Tuer] [float] NULL,
	[EK_Plattetrennwand] [float] NULL,
	[EK_Plattewandschild] [float] NULL,
	[EK_Platteeckschild] [float] NULL,
	[EK_PlatteMittelschild] [float] NULL,
	[EK_Aussen] [float] NULL,
	[EK_Alu] [float] NULL,
	[EK_Alueck] [float] NULL,
	[EK_Verbindungsstueck] [float] NULL,
	[SK_Typ] [int] NULL,
	[SK_Breite] [float] NULL,
	[SK_Hoehe] [float] NULL,
	[SK_Bodenfreiheit] [float] NULL,
	[SK_Tuerbreite] [float] NULL,
	[SK_Tueranzahl] [int] NULL,
	[SK_Trennwand] [float] NULL,
	[SK_Wandschild] [float] NULL,
	[SK_Eckschild] [float] NULL,
	[SK_Schildhoehe] [float] NULL,
	[SK_Tuerhoehe] [float] NULL,
	[SK_Tuer] [float] NULL,
	[SK_PlatteTrennwand] [float] NULL,
	[SK_PlatteWandschild] [float] NULL,
	[SK_PlatteEckschild] [float] NULL,
	[SK_MittelschildLinks] [float] NULL,
	[SK_MittelschildRechts] [float] NULL,
	[SK_AluEck] [float] NULL,
	[SK_Alu] [float] NULL,
	[SK_Verbindungsstueck] [float] NULL,
	[SK_PlatteMittelschildLinks] [float] NULL,
	[SK_PlatteMittelschildRechts] [float] NULL,
	[SK_Aussen] [float] NULL,
	[SW_Stk] [int] NULL,
	[SW_Breite] [float] NULL,
	[SW_Hoehe] [float] NULL,
	[SW_Bodenfreiheit] [float] NULL,
	[SW_PlatteBreite] [float] NULL,
	[SW_PlatteHoehe] [float] NULL,
	[TW_Stk] [int] NULL,
	[TW_Hoehe] [float] NULL,
	[TW_Bodenfreiheit] [float] NULL,
	[TW_Bruestungshoehe] [float] NULL,
	[TW_BreiteSchild] [float] NULL,
	[TW_BreiteAussp] [float] NULL,
	[TW_HoeheSchild] [float] NULL,
	[TW_HoeheAussp] [float] NULL,
	[TW_PlatteBreiteSchild] [float] NULL,
	[TW_PlatteBreiteAussp] [float] NULL,
	[TW_PlatteHoeheSchild] [float] NULL,
	[TW_PlatteHoeheAussp] [float] NULL,
	[TW_AluTrennwand] [float] NULL,
	[TW_AluETW] [float] NULL,
	[TW_AluAussp] [float] NULL,
	[Schild_Stk] [int] NULL,
	[Schild_Hoehe] [float] NULL,
	[Schild_Bodenfreiheit] [float] NULL,
	[Schild_Bruestungshoehe] [float] NULL,
	[Schild_BreiteSchild] [float] NULL,
	[Schild_BreiteAussp] [float] NULL,
	[Schild_HoeheSchild] [float] NULL,
	[Schild_HoeheAussp] [float] NULL,
	[Schild_PlatteBreiteSchild] [float] NULL,
	[Schild_PlatteBreiteAussp] [float] NULL,
	[Schild_AluAussp] [float] NULL,
	[Schild_PlatteHoeheSchild] [float] NULL,
	[Schild_PlatteHoeheAussp] [float] NULL,
 CONSTRAINT [PK_Zeichnungsdruck] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Zeichenparameter]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Zeichenparameter](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[VW_PlattenLuft] [float] NOT NULL,
	[TuerLuft] [float] NOT NULL,
	[SchildLuft] [float] NOT NULL,
	[VW_Verbindungsstück] [float] NOT NULL,
	[KleinesU] [float] NOT NULL,
	[GrossesU] [float] NOT NULL,
	[VW_VerstaerkungGrenze] [float] NOT NULL,
	[RK_TrennwandLuft] [float] NOT NULL,
	[RK_Trennwandstaerke] [float] NOT NULL,
	[RK_MittelschildLuft] [float] NOT NULL,
	[RK_SchildLuft] [float] NOT NULL,
	[RK_Alu] [float] NOT NULL,
	[RK_Verbindungsstück] [float] NOT NULL,
	[EK_Alu] [float] NOT NULL,
	[SCHILD_Alu] [float] NOT NULL,
	[TW_Alu] [float] NOT NULL,
	[TW_ETW] [float] NOT NULL,
 CONSTRAINT [PK_Zeichenparameter] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rechnung]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rechnung](
	[RechnungID] [int] IDENTITY(1022,1) NOT NULL,
	[Datum] [date] NOT NULL,
	[StornoID] [int] NULL,
	[KundeID] [int] NOT NULL,
	[Gesamtbetrag] [money] NOT NULL,
	[Schlussrechnung] [varchar](4) NULL,
	[Steuer] [money] NOT NULL,
	[Empfänger] [varchar](max) NULL,
	[Typ] [varchar](max) NULL,
	[Betreff] [varchar](max) NULL,
	[BV] [varchar](200) NULL,
	[Nachlass] [money] NULL,
	[NachlassArt] [varchar](7) NULL,
	[Zahlungsbedingung] [varchar](50) NULL,
	[Aufmaß] [varchar](4) NULL,
	[Anfahrt] [varchar](4) NULL,
	[BV2] [varchar](200) NULL,
	[Sondertext] [varchar](max) NULL,
	[Mahndatum] [date] NULL,
 CONSTRAINT [PK_Rechnung_1] PRIMARY KEY CLUSTERED 
(
	[RechnungID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Land]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Land](
	[LandKurz] [varchar](10) NOT NULL,
	[LandLang] [varchar](max) NOT NULL
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Kurzbezeichnung' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Land', @level2type=N'COLUMN',@level2name=N'LandKurz'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Langbezeichnung' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Land', @level2type=N'COLUMN',@level2name=N'LandLang'
GO
/****** Object:  Table [dbo].[Lagerkategorie]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lagerkategorie](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Bezeichnung] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Lagerkategorie] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lagereinheit]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lagereinheit](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Bezeichnung] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Lagereinheiten] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Kunde]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kunde](
	[KundeID] [int] IDENTITY(1000,1) NOT NULL,
	[Anrede] [varchar](50) NOT NULL,
	[Vorname] [varchar](50) NULL,
	[Name_Firma] [varchar](100) NOT NULL,
	[Straße] [varchar](100) NULL,
	[AdressZusatz1] [varchar](50) NULL,
	[AdressZusatz2] [varchar](50) NULL,
	[PLZ] [varchar](5) NOT NULL,
	[Land] [varchar](2) NOT NULL,
	[Ort] [varchar](50) NOT NULL,
	[Telefon2] [varchar](50) NULL,
	[Fax2] [varchar](50) NULL,
	[Telefon1] [varchar](50) NULL,
	[Fax1] [varchar](50) NULL,
	[Mobil] [varchar](50) NULL,
	[Email1] [varchar](50) NULL,
	[Email2] [varchar](50) NULL,
	[Homepage] [varchar](100) NULL,
	[Matchcode] [varchar](100) NULL,
	[Kategorie] [varchar](6) NOT NULL,
	[Status] [varchar](8) NULL,
	[Notiz] [varchar](max) NULL,
 CONSTRAINT [PK_Kunde] PRIMARY KEY CLUSTERED 
(
	[KundeID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Kundennummer' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kunde', @level2type=N'COLUMN',@level2name=N'KundeID'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kunde', @level2type=N'COLUMN',@level2name=N'Anrede'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'geschäftlich Telefon' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kunde', @level2type=N'COLUMN',@level2name=N'Telefon2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'geschäftlich Fax' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kunde', @level2type=N'COLUMN',@level2name=N'Fax2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'privat Telefon' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kunde', @level2type=N'COLUMN',@level2name=N'Telefon1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'privat Fax' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kunde', @level2type=N'COLUMN',@level2name=N'Fax1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'privat Email' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kunde', @level2type=N'COLUMN',@level2name=N'Email1'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'geschäftlich Email' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kunde', @level2type=N'COLUMN',@level2name=N'Email2'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Individueller Suchbegriff' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kunde', @level2type=N'COLUMN',@level2name=N'Matchcode'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Kennzeichen ob Kunde gesperrt ist.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kunde', @level2type=N'COLUMN',@level2name=N'Status'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Individuelle Notiz' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kunde', @level2type=N'COLUMN',@level2name=N'Notiz'
GO
/****** Object:  Table [dbo].[Kalkulationsparameter]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Kalkulationsparameter](
	[ParamterID] [int] IDENTITY(1,1) NOT NULL,
	[PlattenkostenTM] [decimal](10, 2) NOT NULL,
	[PlattenkostenTS] [decimal](10, 2) NULL,
	[PlattenkostenNK] [decimal](10, 2) NULL,
	[Aluprofilkosten] [decimal](10, 2) NULL,
	[Beschlagkosten] [decimal](10, 2) NULL,
	[Fixkosten] [decimal](10, 2) NULL,
	[Pulverkosten] [decimal](10, 2) NULL,
	[Montagekosten] [decimal](10, 2) NULL,
	[LohnkostenTM] [decimal](10, 2) NULL,
	[LohnkostenTS] [decimal](10, 2) NULL,
	[LohnkostenNK] [decimal](10, 2) NULL,
	[OberlichtkostenTM] [decimal](10, 2) NULL,
	[OberlichtkostenTS] [decimal](10, 2) NULL,
	[OberlichtkostenNK] [decimal](10, 2) NULL,
	[Gewinn] [decimal](10, 3) NULL,
	[Mwst] [decimal](10, 3) NULL,
	[Sonderzuschlag] [decimal](10, 3) NULL,
	[Aussparung] [decimal](10, 3) NULL,
 CONSTRAINT [PK_Kalkulationsparameter] PRIMARY KEY CLUSTERED 
(
	[ParamterID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelpreis Platten pro Einheit - Anlagentyp TM' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'PlattenkostenTM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelpreis Platten pro Einheit - Anlagentyp TS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'PlattenkostenTS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelpreis Platten pro Einheit - Anlagentyp NK' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'PlattenkostenNK'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelpreis Aluprofil pro Einheit' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'Aluprofilkosten'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelpreis pro Türbeschlag' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'Beschlagkosten'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelpreis Fixkosten pro Teil' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'Fixkosten'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelpreis pro Aluprofileinheit' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'Pulverkosten'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelpreis Montage pro Teil' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'Montagekosten'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelpreis Lohn Anlagentyp TM' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'LohnkostenTM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelpreis Lohn Anlagentyp TS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'LohnkostenTS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelpreis Lohn Anlagentyp NK' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'LohnkostenNK'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelpreis Oberlicht Anlagentyp TM' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'OberlichtkostenTM'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelpreis Oberlicht Anlagentyp TS' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'OberlichtkostenTS'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelpreis Oberlicht Anlagentyp NK' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'OberlichtkostenNK'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Gewinnzuschlag' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'Gewinn'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mehrwertsteuer' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'Mwst'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Sonderzuschlag' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'Sonderzuschlag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelpreis pro Aussparung' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulationsparameter', @level2type=N'COLUMN',@level2name=N'Aussparung'
GO
/****** Object:  Table [dbo].[Kalkulation]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Kalkulation](
	[KalkulationID] [int] IDENTITY(1,1) NOT NULL,
	[Sondertext] [varchar](198) NULL,
	[Typ] [varchar](50) NOT NULL,
	[Artikel] [varchar](50) NOT NULL,
	[AnlagenStk] [int] NOT NULL,
	[Breite] [int] NOT NULL,
	[Tiefe] [int] NULL,
	[Türen] [int] NOT NULL,
	[Trennwaende] [int] NOT NULL,
	[Rabatt_VK] [decimal](10, 3) NOT NULL,
	[Rabatt_Art] [char](1) NULL,
	[Plattenmenge] [decimal](10, 2) NOT NULL,
	[Alumenge] [decimal](10, 2) NOT NULL,
	[BeschlagStk] [int] NOT NULL,
	[FixkostenGesamt] [int] NULL,
	[DivKostenGesamt] [int] NULL,
	[MontagepreisEinzel] [decimal](10, 2) NOT NULL,
	[LohnEinzel] [decimal](10, 2) NOT NULL,
	[Teile] [int] NOT NULL,
	[PulverpreisEinzel] [int] NOT NULL,
	[PulverBool] [char](1) NOT NULL,
	[PlattenpreisEinzel] [decimal](10, 2) NOT NULL,
	[AlupreisEinzel] [decimal](10, 2) NOT NULL,
	[BeschlagpreisEinzel] [decimal](10, 2) NOT NULL,
	[Gesamtpreis100] [varchar](50) NOT NULL,
	[Zuschlag] [varchar](50) NULL,
	[Gesamtpreis] [varchar](50) NULL,
 CONSTRAINT [PK_Kalkulation] PRIMARY KEY CLUSTERED 
(
	[KalkulationID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Vom Benutzer eingegebener individueller Text' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'Sondertext'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Anlagentyp' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'Typ'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Anlagenartikel' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'Artikel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Stückzahl pro Anlage' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'AnlagenStk'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Breite pro Anlage' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'Breite'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Tiefe pro Anlage' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'Tiefe'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Türen pro Anlage' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'Türen'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Trennwände pro Anlage' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'Trennwaende'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Zuschlag/Rabatt pro Anlage in Prozent oder Euro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'Rabatt_VK'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Prozent(0) oder Euro(1)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'Rabatt_Art'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Holzplattenmenge pro Anlage' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'Plattenmenge'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Menge Aluprofile pro Anlage' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'Alumenge'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Türbeschläge pro Anlage' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'BeschlagStk'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Gesamtfixkosten pro Anlage' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'FixkostenGesamt'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Gesamtkosten diverses pro Anlage' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'DivKostenGesamt'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Montagekosten pro Teil' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'MontagepreisEinzel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Lohnkosten pro Teil' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'LohnEinzel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Teileanzahl pro Anlage' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'Teile'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Pulverbeschichtungskosten pro Anlage' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'PulverpreisEinzel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Mit Beschichtung(1) ohne Beschichtung(0)' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'PulverBool'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelkosten pro Platteneinheit' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'PlattenpreisEinzel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelkosten pro Aluprofileinheit' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'AlupreisEinzel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Einzelkosten pro Türbeschlag' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'BeschlagpreisEinzel'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Gesamtkosten inklusive Gewinn und Sonderzuschlag' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'Gesamtpreis100'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Zuschlag pro Tür in euro' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'Zuschlag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Gesamtkosten zuzüglich/abzüglich Rabatt_VK' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Kalkulation', @level2type=N'COLUMN',@level2name=N'Gesamtpreis'
GO
/****** Object:  Table [dbo].[Firmendaten]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Firmendaten](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Inhaber] [varchar](50) NOT NULL,
	[Straße] [varchar](50) NOT NULL,
	[PLZ] [varchar](50) NOT NULL,
	[Ort] [varchar](50) NOT NULL,
	[Telefon] [varchar](50) NOT NULL,
	[Fax] [varchar](50) NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Homepage] [varchar](50) NOT NULL,
	[Steuernummer] [varchar](50) NOT NULL,
	[Ust_Nummer] [varchar](50) NOT NULL,
	[Bank1] [varchar](50) NOT NULL,
	[BLZ1] [varchar](50) NOT NULL,
	[Konto1] [varchar](50) NOT NULL,
	[Bank2] [varchar](50) NULL,
	[BLZ2] [varchar](50) NULL,
	[Konto2] [varchar](50) NULL,
 CONSTRAINT [PK_Firmendaten] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Firmendaten', @level2type=N'COLUMN',@level2name=N'Name'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Firmendaten', @level2type=N'COLUMN',@level2name=N'Inhaber'
GO
/****** Object:  Table [dbo].[Brief]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brief](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Betreff] [nvarchar](max) NULL,
	[Text] [nvarchar](max) NULL,
	[Bauvorhaben] [nvarchar](max) NULL,
	[Anrede] [nvarchar](max) NULL,
	[ZuHaenden] [nvarchar](max) NULL,
 CONSTRAINT [PK_Brief] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Steuer]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Steuer](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Prozent] [decimal](18, 0) NOT NULL,
	[Dezimal] [decimal](18, 2) NULL,
 CONSTRAINT [PK_Steuer] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reports]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Reports](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Pfad] [varchar](max) NOT NULL,
	[Name] [varchar](200) NULL,
 CONSTRAINT [PK_Reports] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rechnung_Position]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rechnung_Position](
	[PosID] [int] IDENTITY(1,1) NOT NULL,
	[RechnungID] [int] NULL,
	[Artikel] [varchar](13) NOT NULL,
	[Sondertext] [varchar](max) NULL,
	[Typ] [varchar](50) NOT NULL,
	[AnlagenStk] [decimal](10, 2) NOT NULL,
	[Breite] [int] NOT NULL,
	[Tiefe] [int] NOT NULL,
	[Türen] [int] NULL,
	[TW] [int] NULL,
	[ZuschlagTür] [int] NULL,
	[Zuschlag] [int] NULL,
	[ZuschlagArt] [varchar](7) NOT NULL,
	[Einzelpreis] [money] NOT NULL,
	[Alupulver] [decimal](10, 2) NOT NULL,
	[Montage] [varchar](4) NOT NULL,
	[AussparungStk] [int] NULL,
	[AussparungTxt] [varchar](max) NULL,
	[Alternativ1Typ] [varchar](2) NULL,
	[Alternativ1Preis] [money] NULL,
	[Alternativ2Typ] [varchar](2) NULL,
	[Alternativ2Preis] [money] NULL,
	[SondertextOben] [varchar](max) NULL,
 CONSTRAINT [PK_Rechnung_Position] PRIMARY KEY CLUSTERED 
(
	[PosID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Angebot]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Angebot](
	[AngebotID] [int] IDENTITY(1000,1) NOT NULL,
	[KundeID] [int] NOT NULL,
	[Empfänger] [varchar](max) NULL,
	[Datum] [date] NOT NULL,
	[Typ] [varchar](max) NULL,
	[Betreff] [varchar](max) NOT NULL,
	[BV] [varchar](200) NULL,
	[Gesamtbetrag] [money] NOT NULL,
	[Nachlass] [money] NULL,
	[NachlassArt] [varchar](7) NOT NULL,
	[Steuer] [money] NOT NULL,
	[Zahlungsbedingung] [varchar](50) NOT NULL,
	[Aufmaß] [varchar](4) NULL,
	[Anfahrt] [varchar](4) NULL,
	[Angebotstext] [varchar](50) NULL,
	[BV2] [varchar](200) NULL,
	[Sondertext] [varchar](max) NULL,
	[SondertextUnten] [varchar](max) NULL,
	[VorgabedatumRechnung] [date] NULL,
 CONSTRAINT [PK_Angebot] PRIMARY KEY CLUSTERED 
(
	[AngebotID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Auftrag]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Auftrag](
	[AuftragID] [int] IDENTITY(1000,1) NOT NULL,
	[Empfänger] [varchar](max) NULL,
	[Datum] [date] NOT NULL,
	[Typ] [varchar](max) NULL,
	[Betreff] [varchar](max) NOT NULL,
	[BV] [varchar](200) NULL,
	[Gesamtbetrag] [money] NOT NULL,
	[Nachlass] [money] NULL,
	[NachlassArt] [varchar](7) NOT NULL,
	[Steuer] [money] NOT NULL,
	[Zahlungsbedingung] [varchar](50) NOT NULL,
	[Aufmaß] [varchar](4) NULL,
	[Anfahrt] [varchar](4) NULL,
	[Angebotstext] [varchar](50) NULL,
	[BV2] [varchar](200) NULL,
	[Sondertext] [varchar](max) NULL,
	[KundeID] [int] NOT NULL,
	[Rechnungsstatus] [int] NULL,
	[SondertextUnten] [varchar](max) NULL,
	[VorgabedatumRechnung] [date] NULL,
 CONSTRAINT [PK_Auftrag] PRIMARY KEY CLUSTERED 
(
	[AuftragID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lager]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lager](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Bezeichnung] [nvarchar](50) NOT NULL,
	[Kategorie] [int] NULL,
	[Einheit] [int] NULL,
	[Stk] [float] NOT NULL,
	[EK] [float] NOT NULL,
 CONSTRAINT [PK_Lager] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[VIEW_Nettoumsatz_ProMonat]    Script Date: 03/15/2011 20:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_Nettoumsatz_ProMonat]
AS
SELECT TOP(100) PERCENT
         YEAR(r.Datum)                                        AS Jahr
       , DATENAME(MONTH, DATEADD(MONTH, MONTH(r.Datum), 0)-1) AS Monat
       , SUM(
                  CASE(r.Steuer)
                           WHEN 0
                           THEN CAST((r.Gesamtbetrag) AS DECIMAL(9, 2))
                           ELSE CAST((r.Gesamtbetrag / (r.steuer + 1)) AS      DECIMAL(9, 2))
                  END) AS Umsatz
FROM     dbo.Rechnung  AS r
GROUP BY YEAR(r.Datum)
       , MONTH(r.Datum)
ORDER BY YEAR(r.Datum)
       , MONTH(r.Datum) ASC
GO
/****** Object:  View [dbo].[VIEW_Nettoumsatz_ProJahr]    Script Date: 03/15/2011 20:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_Nettoumsatz_ProJahr]
AS
SELECT TOP(100) PERCENT
         YEAR(r.Datum) AS Jahr
       , SUM(
                  CASE(r.Steuer)
                           WHEN 0
                           THEN CAST((r.Gesamtbetrag) AS DECIMAL(9, 2))
                           ELSE CAST((r.Gesamtbetrag / (r.steuer + 1)) AS      DECIMAL(9, 2))
                  END) AS Umsatz
FROM     dbo.Rechnung  AS r
GROUP BY YEAR(r.Datum)
ORDER BY YEAR(r.Datum) ASC
GO
/****** Object:  View [dbo].[VIEW_Nettoumsatz_KundeProMonat]    Script Date: 03/15/2011 20:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_Nettoumsatz_KundeProMonat]
AS
     SELECT TOP(100) PERCENT
         YEAR(r.Datum)                                        AS Jahr
       , DATENAME(MONTH, DATEADD(MONTH, MONTH(r.Datum), 0)-1) AS Monat
       , SUM(
                  CASE(r.Steuer)
                           WHEN 0.0
                           THEN CAST((r.Gesamtbetrag) AS DECIMAL(9, 2))
                           ELSE CAST((r.Gesamtbetrag / (r.Steuer + 1)) AS      DECIMAL(9, 2))
                  END) AS Umsatz
       , k.KundeID
       , k.Name_Firma
FROM     dbo.Rechnung         AS r
         INNER JOIN dbo.Kunde AS k
         ON       r.KundeID=k.KundeID
GROUP BY k.KundeID
       , k.Name_Firma
       , YEAR(r.Datum)
       , MONTH(r.Datum)
ORDER BY YEAR(r.datum)
       , MONTH(r.Datum) ASC
       , k.Name_Firma
GO
/****** Object:  View [dbo].[VIEW_Nettoumsatz_KundeProJahr]    Script Date: 03/15/2011 20:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_Nettoumsatz_KundeProJahr]
AS
     SELECT TOP(100) PERCENT
         YEAR(r.Datum)                                        AS Jahr
       , SUM(
                  CASE(r.Steuer)
                           WHEN 0.0
                           THEN CAST((r.Gesamtbetrag) AS DECIMAL(9, 2))
                           ELSE CAST((r.Gesamtbetrag / (r.Steuer + 1)) AS      DECIMAL(9, 2))
                  END) AS Umsatz
       , k.KundeID
       , k.Name_Firma
FROM     dbo.Rechnung         AS r
         INNER JOIN dbo.Kunde AS k
         ON       r.KundeID=k.KundeID
GROUP BY k.KundeID
       , k.Name_Firma
       , YEAR(r.Datum)
ORDER BY YEAR(r.datum)
       , k.Name_Firma
GO
/****** Object:  View [dbo].[VIEW_ArchivRechnungAlle]    Script Date: 03/15/2011 20:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_ArchivRechnungAlle]
AS
SELECT TOP(100) PERCENT
         dbo.Rechnung.RechnungID
       , dbo.Rechnung.StornoID
       , dbo.Kunde.KundeID
       , dbo.Kunde.Name_Firma
       , dbo.Rechnung.Empfänger
       , dbo.Rechnung.Datum AS [RechDatum]
       , dbo.Rechnung.Mahndatum
       , dbo.Rechnung.Schlussrechnung AS SR
       , dbo.Rechnung.BV
       , dbo.Rechnung.BV2
       , CASE(dbo.Rechnung.Steuer)
                  WHEN 0
                  THEN CAST((dbo.Rechnung.Gesamtbetrag) AS DECIMAL(9, 2))
                  ELSE CAST((dbo.Rechnung.Gesamtbetrag / (dbo.Rechnung.Steuer + 1)) AS        DECIMAL(9, 2))
         END                                              AS Nettobetrag
       , CAST(dbo.Rechnung.Gesamtbetrag AS DECIMAL(9, 2)) AS Gesamtbetrag
       , CAST(dbo.Rechnung.Nachlass AS     DECIMAL(9, 2)) AS Nachlass
       , dbo.Rechnung.NachlassArt
       , CAST(dbo.Rechnung.Steuer * 100 as Decimal(9,0)) as Steuer
       , dbo.Rechnung.Zahlungsbedingung
FROM     dbo.Kunde
         INNER JOIN dbo.Rechnung
         ON       dbo.Kunde.KundeID = dbo.Rechnung.KundeID
ORDER BY dbo.Rechnung.RechnungID DESC
GO
/****** Object:  View [dbo].[VIEW_ArchivAuftragAlle]    Script Date: 03/15/2011 20:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_ArchivAuftragAlle]
AS
SELECT dbo.Auftrag.AuftragID
     , dbo.Kunde.KundeID
     , dbo.Kunde.Name_Firma
     , dbo.Auftrag.Empfänger
     , dbo.Auftrag.Datum
     , dbo.Auftrag.Typ
     , dbo.Auftrag.BV
     , dbo.Auftrag.BV2
     , CASE(dbo.Auftrag.Steuer)
              WHEN 0
              THEN CAST((dbo.Auftrag.Gesamtbetrag) AS DECIMAL(9, 2))
              ELSE CAST((dbo.Auftrag.Gesamtbetrag / (dbo.Auftrag.Steuer + 1)) AS        DECIMAL(9, 2))
       END                                             AS Nettobetrag
     , CAST(dbo.Auftrag.Gesamtbetrag AS DECIMAL(9, 2)) AS Gesamtbetrag
     , CAST(dbo.Auftrag.Nachlass AS     DECIMAL(9, 2)) AS Nachlass
     , dbo.Auftrag.NachlassArt
     ,CAST(dbo.Auftrag.Steuer * 100 as Decimal(9,0)) as Steuer
     , dbo.Auftrag.Zahlungsbedingung
     , dbo.Auftrag.Aufmaß
     , dbo.Auftrag.Anfahrt
     , dbo.Auftrag.Sondertext
FROM   dbo.Kunde
       INNER JOIN dbo.Auftrag
       ON     dbo.Kunde.KundeID = dbo.Auftrag.KundeID
GO
/****** Object:  View [dbo].[VIEW_ArchivAngeboteAlle]    Script Date: 03/15/2011 20:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_ArchivAngeboteAlle]
AS
SELECT dbo.Angebot.AngebotID
     , dbo.Kunde.KundeID
     , dbo.Kunde.Name_Firma
     , dbo.Angebot.Empfänger
     , dbo.Angebot.Datum
     , dbo.Angebot.Typ
     , dbo.Angebot.BV
     , dbo.Angebot.BV2
     , CASE(dbo.Angebot.Steuer)
              WHEN 0
              THEN CAST((dbo.Angebot.Gesamtbetrag) AS                           DECIMAL(9, 2))
              ELSE CAST((dbo.Angebot.Gesamtbetrag /(dbo.Angebot.Steuer + 1)) AS DECIMAL(9, 2))
       END                                             AS Nettobetrag
     , CAST(dbo.Angebot.Gesamtbetrag AS DECIMAL(9, 2)) AS Gesamtbetrag
     , CAST(dbo.Angebot.Nachlass AS     DECIMAL(9, 2)) AS Nachlass
     , dbo.Angebot.NachlassArt
     , cast(dbo.Angebot.Steuer * 100 as Decimal(9,0)) as Steuer
     , dbo.Angebot.Zahlungsbedingung
     , dbo.Angebot.Aufmaß
     , dbo.Angebot.Anfahrt
     , dbo.Angebot.Sondertext
FROM   dbo.Angebot
       INNER JOIN dbo.Kunde
       ON     dbo.Angebot.KundeID = dbo.Kunde.KundeID
GO
/****** Object:  View [dbo].[VIEW_Angebote_KundeProJahr]    Script Date: 03/15/2011 20:38:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[VIEW_Angebote_KundeProJahr]
AS
    SELECT TOP (100) PERCENT
            j.Jahr,
            k.KundeID,
            k.Name_Firma,
            (select COUNT(angebot.AngebotID) from Angebot where KundeID = k.Kundeid and YEAR(angebot.datum) = j.Jahr) as Angebote,
            (select COUNT(auftrag.AuftragID) from Auftrag where KundeID = k.Kundeid and YEAR(auftrag.datum) = j.Jahr) as Aufträge,
            (select COUNT(rechnung.rechnungID) from Rechnung where KundeID = k.Kundeid and YEAR(rechnung.datum) = j.Jahr and Rechnung.StornoID is null and Rechnung.Gesamtbetrag >0) as Rechnungen
       FROM Kunde k, --inner join Angebot a on k.KundeID = a.KundeID,
       ( select year(angebot.Datum) as Jahr FROM angebot
   union
   select year(auftrag.Datum) as Jahr FROM auftrag
   union 
   select year(rechnung.datum) as Jahr FROM rechnung) as j
   where (((select COUNT(angebot.AngebotID) from Angebot where KundeID = k.Kundeid and YEAR(angebot.datum) = j.Jahr) <> 0)
   or ( (select COUNT(auftrag.AuftragID) from Auftrag where KundeID = k.Kundeid and YEAR(auftrag.datum) = j.Jahr)<> 0)
   or ((select COUNT(rechnung.rechnungID) from Rechnung where KundeID = k.Kundeid and YEAR(rechnung.datum) = j.Jahr) <> 0))
   GROUP BY k.KundeID, k.Name_Firma, j.Jahr
   ORDER BY k.KundeID,Jahr desc
GO
/****** Object:  Table [dbo].[Auftrag_Position]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Auftrag_Position](
	[PosID] [int] IDENTITY(1,1) NOT NULL,
	[AuftragID] [int] NOT NULL,
	[RechnungID] [int] NULL,
	[Artikel] [varchar](13) NOT NULL,
	[Sondertext] [varchar](max) NULL,
	[Typ] [varchar](50) NOT NULL,
	[AnlagenStk] [decimal](10, 2) NOT NULL,
	[Breite] [int] NOT NULL,
	[Tiefe] [int] NOT NULL,
	[Türen] [int] NULL,
	[TW] [int] NULL,
	[ZuschlagTür] [int] NULL,
	[Zuschlag] [int] NULL,
	[ZuschlagArt] [varchar](7) NOT NULL,
	[Einzelpreis] [money] NOT NULL,
	[Alupulver] [decimal](10, 2) NOT NULL,
	[Montage] [varchar](4) NOT NULL,
	[AussparungStk] [int] NULL,
	[AussparungTxt] [varchar](max) NULL,
	[Alternativ1Typ] [varchar](2) NULL,
	[Alternativ1Preis] [money] NULL,
	[Alternativ2Typ] [varchar](2) NULL,
	[Alternativ2Preis] [money] NULL,
	[SondertextOben] [varchar](max) NULL,
 CONSTRAINT [PK_Auftrag_Position] PRIMARY KEY CLUSTERED 
(
	[PosID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Angebot_Position]    Script Date: 03/15/2011 20:38:03 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Angebot_Position](
	[PosID] [int] IDENTITY(1,1) NOT NULL,
	[AngebotID] [int] NOT NULL,
	[AuftragID] [int] NULL,
	[Artikel] [varchar](13) NOT NULL,
	[Sondertext] [varchar](max) NULL,
	[Typ] [varchar](50) NOT NULL,
	[AnlagenStk] [decimal](10, 2) NOT NULL,
	[Breite] [int] NOT NULL,
	[Tiefe] [int] NOT NULL,
	[Türen] [int] NULL,
	[TW] [int] NULL,
	[ZuschlagTür] [int] NULL,
	[Zuschlag] [int] NULL,
	[ZuschlagArt] [varchar](7) NOT NULL,
	[Einzelpreis] [money] NOT NULL,
	[Alupulver] [decimal](10, 2) NOT NULL,
	[Montage] [varchar](4) NOT NULL,
	[AussparungStk] [int] NULL,
	[AussparungTxt] [varchar](max) NULL,
	[Alternativ1Typ] [varchar](2) NULL,
	[Alternativ1Preis] [money] NULL,
	[Alternativ2Typ] [varchar](2) NULL,
	[Alternativ2Preis] [money] NULL,
	[SondertextOben] [varchar](max) NULL,
 CONSTRAINT [PK_Angebot_Position] PRIMARY KEY CLUSTERED 
(
	[PosID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Vom Anwender manuell eingegebner Einzelpreis.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Angebot_Position', @level2type=N'COLUMN',@level2name=N'Zuschlag'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'Vom Anwender manuell eingegebner Artikeltext.' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'Angebot_Position', @level2type=N'COLUMN',@level2name=N'ZuschlagArt'
GO
/****** Object:  Default [DF_Angebot_SondertextUnten]    Script Date: 03/15/2011 20:38:03 ******/
ALTER TABLE [dbo].[Angebot] ADD  CONSTRAINT [DF_Angebot_SondertextUnten]  DEFAULT (NULL) FOR [SondertextUnten]
GO
/****** Object:  Default [DF_Auftrag_SondertextUnten]    Script Date: 03/15/2011 20:38:03 ******/
ALTER TABLE [dbo].[Auftrag] ADD  CONSTRAINT [DF_Auftrag_SondertextUnten]  DEFAULT (NULL) FOR [SondertextUnten]
GO
/****** Object:  Default [DF_Rechnung_Mahndatum]    Script Date: 03/15/2011 20:38:03 ******/
ALTER TABLE [dbo].[Rechnung] ADD  CONSTRAINT [DF_Rechnung_Mahndatum]  DEFAULT (NULL) FOR [Mahndatum]
GO
/****** Object:  ForeignKey [FK_Angebot_Kunde]    Script Date: 03/15/2011 20:38:03 ******/
ALTER TABLE [dbo].[Angebot]  WITH NOCHECK ADD  CONSTRAINT [FK_Angebot_Kunde] FOREIGN KEY([KundeID])
REFERENCES [dbo].[Kunde] ([KundeID])
GO
ALTER TABLE [dbo].[Angebot] CHECK CONSTRAINT [FK_Angebot_Kunde]
GO
/****** Object:  ForeignKey [FK_Angebot_Position_Angebot]    Script Date: 03/15/2011 20:38:03 ******/
ALTER TABLE [dbo].[Angebot_Position]  WITH NOCHECK ADD  CONSTRAINT [FK_Angebot_Position_Angebot] FOREIGN KEY([AngebotID])
REFERENCES [dbo].[Angebot] ([AngebotID])
GO
ALTER TABLE [dbo].[Angebot_Position] CHECK CONSTRAINT [FK_Angebot_Position_Angebot]
GO
/****** Object:  ForeignKey [FK_Angebot_Position_Auftrag]    Script Date: 03/15/2011 20:38:03 ******/
ALTER TABLE [dbo].[Angebot_Position]  WITH NOCHECK ADD  CONSTRAINT [FK_Angebot_Position_Auftrag] FOREIGN KEY([AuftragID])
REFERENCES [dbo].[Auftrag] ([AuftragID])
GO
ALTER TABLE [dbo].[Angebot_Position] CHECK CONSTRAINT [FK_Angebot_Position_Auftrag]
GO
/****** Object:  ForeignKey [FK_Auftrag_Kunde]    Script Date: 03/15/2011 20:38:03 ******/
ALTER TABLE [dbo].[Auftrag]  WITH NOCHECK ADD  CONSTRAINT [FK_Auftrag_Kunde] FOREIGN KEY([KundeID])
REFERENCES [dbo].[Kunde] ([KundeID])
GO
ALTER TABLE [dbo].[Auftrag] CHECK CONSTRAINT [FK_Auftrag_Kunde]
GO
/****** Object:  ForeignKey [FK_Auftrag_Position_Auftrag]    Script Date: 03/15/2011 20:38:03 ******/
ALTER TABLE [dbo].[Auftrag_Position]  WITH NOCHECK ADD  CONSTRAINT [FK_Auftrag_Position_Auftrag] FOREIGN KEY([AuftragID])
REFERENCES [dbo].[Auftrag] ([AuftragID])
GO
ALTER TABLE [dbo].[Auftrag_Position] CHECK CONSTRAINT [FK_Auftrag_Position_Auftrag]
GO
/****** Object:  ForeignKey [FK_Auftrag_Position_Rechnung]    Script Date: 03/15/2011 20:38:03 ******/
ALTER TABLE [dbo].[Auftrag_Position]  WITH NOCHECK ADD  CONSTRAINT [FK_Auftrag_Position_Rechnung] FOREIGN KEY([RechnungID])
REFERENCES [dbo].[Rechnung] ([RechnungID])
GO
ALTER TABLE [dbo].[Auftrag_Position] CHECK CONSTRAINT [FK_Auftrag_Position_Rechnung]
GO
/****** Object:  ForeignKey [FK_Lager_Lagereinheit]    Script Date: 03/15/2011 20:38:03 ******/
ALTER TABLE [dbo].[Lager]  WITH CHECK ADD  CONSTRAINT [FK_Lager_Lagereinheit] FOREIGN KEY([Einheit])
REFERENCES [dbo].[Lagereinheit] ([ID])
GO
ALTER TABLE [dbo].[Lager] CHECK CONSTRAINT [FK_Lager_Lagereinheit]
GO
/****** Object:  ForeignKey [FK_Lager_Lagerkategorie]    Script Date: 03/15/2011 20:38:03 ******/
ALTER TABLE [dbo].[Lager]  WITH CHECK ADD  CONSTRAINT [FK_Lager_Lagerkategorie] FOREIGN KEY([Kategorie])
REFERENCES [dbo].[Lagerkategorie] ([ID])
GO
ALTER TABLE [dbo].[Lager] CHECK CONSTRAINT [FK_Lager_Lagerkategorie]
GO
/****** Object:  ForeignKey [FK_Rechnung_Position_Rechnung]    Script Date: 03/15/2011 20:38:03 ******/
ALTER TABLE [dbo].[Rechnung_Position]  WITH NOCHECK ADD  CONSTRAINT [FK_Rechnung_Position_Rechnung] FOREIGN KEY([RechnungID])
REFERENCES [dbo].[Rechnung] ([RechnungID])
GO
ALTER TABLE [dbo].[Rechnung_Position] CHECK CONSTRAINT [FK_Rechnung_Position_Rechnung]
GO


BEGIN TRANSACTION
GO
ALTER TABLE dbo.Rechnung ADD
	Einbehalt date NULL
GO
ALTER TABLE dbo.Rechnung ADD CONSTRAINT
	DF_Rechnung_Einbehalt DEFAULT (NULL) FOR Einbehalt
GO
ALTER TABLE dbo.Rechnung SET (LOCK_ESCALATION = TABLE)
GO
COMMIT


USE [Norka]
GO

/****** Object:  View [dbo].[VIEW_ArchivRechnungAlle]    Script Date: 04/29/2011 08:17:32 ******/
IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[VIEW_ArchivRechnungAlle]'))
DROP VIEW [dbo].[VIEW_ArchivRechnungAlle]
GO

USE [Norka]
GO

/****** Object:  View [dbo].[VIEW_ArchivRechnungAlle]    Script Date: 04/29/2011 08:17:32 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[VIEW_ArchivRechnungAlle]
AS
SELECT TOP(100) PERCENT
         dbo.Rechnung.RechnungID
       , dbo.Rechnung.StornoID
       , dbo.Kunde.KundeID
       , dbo.Kunde.Name_Firma
       , dbo.Rechnung.Empfänger
       , dbo.Rechnung.Datum AS [RechDatum]
       , dbo.Rechnung.Mahndatum
       , dbo.Rechnung.Einbehalt
       , dbo.Rechnung.Schlussrechnung AS SR
       , dbo.Rechnung.BV
       , dbo.Rechnung.BV2
       , CASE(dbo.Rechnung.Steuer)
                  WHEN 0
                  THEN CAST((dbo.Rechnung.Gesamtbetrag) AS DECIMAL(9, 2))
                  ELSE CAST((dbo.Rechnung.Gesamtbetrag / (dbo.Rechnung.Steuer + 1)) AS        DECIMAL(9, 2))
         END                                              AS Nettobetrag
       , CAST(dbo.Rechnung.Gesamtbetrag AS DECIMAL(9, 2)) AS Gesamtbetrag
       , CAST(dbo.Rechnung.Nachlass AS     DECIMAL(9, 2)) AS Nachlass
       , dbo.Rechnung.NachlassArt
       , CAST(dbo.Rechnung.Steuer * 100 as Decimal(9,0)) as Steuer
       , dbo.Rechnung.Zahlungsbedingung
FROM     dbo.Kunde
         INNER JOIN dbo.Rechnung
         ON       dbo.Kunde.KundeID = dbo.Rechnung.KundeID
ORDER BY dbo.Rechnung.RechnungID DESC
GO


CREATE VIEW [dbo].[VIEW_Nettoumsatz_KundeProMonat]
AS
SELECT     TOP (100) PERCENT YEAR(r.Datum) AS Jahr, MONTH(r.Datum) AS Monat, SUM(CASE (r.Steuer) WHEN 0.0 THEN CAST((r.Gesamtbetrag) AS DECIMAL(9, 2)) 
                      ELSE CAST((r.Gesamtbetrag / (r.Steuer + 1)) AS DECIMAL(9, 2)) END) AS Umsatz, k.KundeID, k.Name_Firma
FROM         dbo.Rechnung AS r INNER JOIN
                      dbo.Kunde AS k ON r.KundeID = k.KundeID
GROUP BY k.KundeID, k.Name_Firma, YEAR(r.Datum), MONTH(r.Datum)
ORDER BY Jahr, Monat, k.KundeID
GO