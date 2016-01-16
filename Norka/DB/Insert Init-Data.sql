USE [MOMO]
SET NOCOUNT ON;
SET XACT_ABORT ON;
GO

SET IDENTITY_INSERT [dbo].[Firmendaten] ON;
BEGIN TRANSACTION;
INSERT INTO [dbo].[Firmendaten]([ID], [Name], [Inhaber], [Straße], [PLZ], [Ort], [Telefon], [Fax], [Email], [Homepage], [Steuernummer], [Ust_Nummer], [Bank1], [BLZ1], [Konto1], [Bank2], [BLZ2], [Konto2])
SELECT 1, N'NORKA Sanitärkabinen e.K.', N'Wolfgang Marxer', N'Güterbahnhof 14', N'88416', N'Ochsenhausen', N'07352/4724', N'07352/4848', N'info@norka-sanitaerkabinen.de', N'www.norka-sanitaerkabinen.de', N'54234/32002', N'DE 144920309', N'Südwestbank Ochsenhausen', N'600 907 00', N'687 368 014', N'Kreissparkasse Ochsenhausen', N'654 500 70', N'8 159 702'
COMMIT;
RAISERROR (N'[dbo].[Firmendaten]: Insert Batch: 1.....Done!', 10, 1) WITH NOWAIT;
GO

SET IDENTITY_INSERT [dbo].[Firmendaten] OFF;

SET IDENTITY_INSERT [dbo].[Kalkulationsparameter] ON;
BEGIN TRANSACTION;
INSERT INTO [dbo].[Kalkulationsparameter]([ParamterID], [PlattenkostenTM], [PlattenkostenTS], [PlattenkostenNK], [Aluprofilkosten], [Beschlagkosten], [Fixkosten], [Pulverkosten], [Montagekosten], [LohnkostenTM], [LohnkostenTS], [LohnkostenNK], [OberlichtkostenTM], [OberlichtkostenTS], [OberlichtkostenNK], [Gewinn], [Mwst], [Sonderzuschlag], [Aussparung])
SELECT 1, 18.00, 25.00, 40.00, 5.00, 4.50, 7.25, 3.00, 15.00, 33.00, 45.00, 75.00, 25.00, 25.00, 25.00, 1.070, 0.000, 1.050, 0.000
COMMIT;
RAISERROR (N'[dbo].[Kalkulationsparameter]: Insert Batch: 1.....Done!', 10, 1) WITH NOWAIT;
GO

SET IDENTITY_INSERT [dbo].[Kalkulationsparameter] OFF;


BEGIN TRANSACTION;
INSERT INTO [dbo].[Land]([LandKurz], [LandLang])
SELECT N'DE', N'Deutschland' UNION ALL
SELECT N'AT', N'Östereich' UNION ALL
SELECT N'CH', N'Schweiz'
COMMIT;
RAISERROR (N'[dbo].[Land]: Insert Batch: 1.....Done!', 10, 1) WITH NOWAIT;
GO


SET IDENTITY_INSERT [dbo].[Reports] ON;
BEGIN TRANSACTION;
INSERT INTO [dbo].[Reports]([ID], [Pfad], [Name])
SELECT 1, N'E:\project\Norka\Norka\Reports\Angebot.rpt', N'Angebot' UNION ALL
SELECT 2, N'E:\project\Norka\Norka\Reports\Telefonliste.rpt', N'Telefonliste' UNION ALL
SELECT 3, N'E:\project\Norka\Norka\Reports\Kalkulation.rpt', N'Kalkulation' UNION ALL
SELECT 4, N'E:\project\Norka\Norka\Reports\Auftragsbestätigung.rpt', N'Auftragsbestätigung' UNION ALL
SELECT 5, N'E:\project\Norka\Norka\Reports\Rechnung.rpt', N'Rechnung' UNION ALL
SELECT 6, N'E:\project\Norka\Norka\Reports\Kundendatenblatt.rpt', N'Kundendatenblatt' UNION ALL
SELECT 7, N'E:\project\Norka\Norka\Reports\Begleitschreiben.rpt', N'Begleitschreiben' UNION ALL
SELECT 8, N'E:\project\Norka\Norka\Reports\Absage nicht im Programm.rpt', N'AbsageProgramm' UNION ALL
SELECT 9, N'E:\project\Norka\Norka\Reports\Außerhalb vom Wirkungskreis.rpt', N'AbsageWirkungskreis' UNION ALL
SELECT 10, N'E:\project\Norka\Norka\Reports\Mahnung.rpt', N'Mahnung' UNION ALL
SELECT 15, N'E:\project\Norka\Norka\Reports\Zeichnen.rpt', N'Zeichnen' UNION ALL
SELECT 16, N'E:\project\Norka\Norka\Reports\Brief.rpt', N'Brief' UNION ALL
SELECT 17, N'E:\project\Norka\Norka\Reports\Inventurliste.rpt', N'Inventurliste'
COMMIT;
RAISERROR (N'[dbo].[Reports]: Insert Batch: 1.....Done!', 10, 1) WITH NOWAIT;
GO

SET IDENTITY_INSERT [dbo].[Reports] OFF;
SET IDENTITY_INSERT [dbo].[Steuer] ON;
BEGIN TRANSACTION;
INSERT INTO [dbo].[Steuer]([ID], [Prozent], [Dezimal])
SELECT 1, 0, 0.00 UNION ALL
SELECT 2, 19, 0.19
COMMIT;
RAISERROR (N'[dbo].[Steuer]: Insert Batch: 1.....Done!', 10, 1) WITH NOWAIT;
GO

SET IDENTITY_INSERT [dbo].[Steuer] OFF;
SET IDENTITY_INSERT [dbo].[Zeichenparameter] ON;
BEGIN TRANSACTION;
INSERT INTO [dbo].[Zeichenparameter]([ID], [VW_PlattenLuft], [TuerLuft], [SchildLuft], [VW_Verbindungsstück], [KleinesU], [GrossesU], [VW_VerstaerkungGrenze], [RK_TrennwandLuft], [RK_Trennwandstaerke], [RK_MittelschildLuft], [RK_SchildLuft], [RK_Alu], [RK_Verbindungsstück], [EK_Alu], [SCHILD_Alu], [TW_Alu], [TW_ETW])
SELECT 1, 1.7, 2.4, 0.5, 4, 1, 1.2, 170, 1.7, 3, 0.6, 1.7, 3,4, 1, 2.1, 4, 2.2
COMMIT;
RAISERROR (N'[dbo].[Zeichenparameter]: Insert Batch: 1.....Done!', 10, 1) WITH NOWAIT;
GO

SET IDENTITY_INSERT [dbo].[Zeichenparameter] OFF;


