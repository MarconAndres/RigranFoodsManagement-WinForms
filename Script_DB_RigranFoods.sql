


CREATE TABLE ProductType(
ID int IDENTITY(1,1) NOT NULL,
[Name] VARCHAR (50) NOT NULL,
CONSTRAINT PK_ProductType PRIMARY KEY (ID)
);
GO

INSERT INTO ProductType ([Name])
VALUES ('Pulses / Legumes'), ('Seeds / Specialities');
GO

CREATE TABLE ProductMaster(
ID INT IDENTITY(1,1) NOT NULL,
IdProductType INT NOT NULL,
[Name] VARCHAR (100) NOT NULL,
CONSTRAINT PK_ProductMaster PRIMARY KEY (ID),
CONSTRAINT FK_ProductMaster_ProductType FOREIGN KEY (IdProductType) REFERENCES ProductType (ID)
);
GO

INSERT INTO ProductMaster (IdProductType, [Name])
VALUES
	--legumes / Pulses (IdProductType = 1)
	(1, 'Kabuli Chickpeas'),
	(1, 'Lentils'),
	(1, 'Green Peas'),
	(1, 'Black Beans'),
	(1, 'Cranberry Beans'),
	(1, 'Dark Red Kidney Beans'),
	(1, 'Light Red Kidney Beans'),
	(1, 'Green Mung Beans'),
	(1, 'Adzuki Beans'),
	(1, 'Alubia Beans'),

	--Seeds / Specialities (IdProductType = 2)
	(2, 'Golden Flaxseed'),
	(2, 'Brown Flaxseed'),
	(2, 'Chia Seeds'),
	(2, 'Sesame Seeds'),
	(2, 'Coriander'),
	(2, 'Confection Sunflower'),
	(2, 'Striped Sunflower'),
	(2, 'Popcorn' );
GO


CREATE TABLE ProductSpecifications(
ID INT IDENTITY(1,1) NOT NULL,
IdProductMaster INT NOT NULL,
[Size] VARCHAR(20),
Moisture VARCHAR(20),
SplitAndBroken VARCHAR(20),
Foreignmatter VARCHAR(20),
TotalDamage VARCHAR(20),
Purity VARCHAR(20),
AddSpecs VARCHAR(MAX),
CONSTRAINT PK_ProductSpecifications PRIMARY KEY (ID),
CONSTRAINT FK_ProductSpecifications_ProductMaster FOREIGN KEY (IdProductMaster) REFERENCES ProductMaster (ID)
);
GO

INSERT INTO ProductSpecifications 
    (IdProductMaster, [Size], Moisture, SplitAndBroken, Foreignmatter, TotalDamage, Purity, AddSpecs)
VALUES
    -- 1. KABULI CHICKPEAS
    (1, '7-8-9 mm', '14.0%', '1.0%', '0.5%', '4.0%', '99.0%', 'Export Quality - Undersize 10% max, Discolored 1% max, Cracked seed coat 1% max'),

    -- 4. BLACK BEANS
    (4, '3.5-4 mm', '14.0%', '1.0%', '0.5%', '5.0%', '99.0%', 'Export Quality - Undersize 10% max, Discolored 1% max, Cracked seed coat 2% max'),

    -- 5. CRANBERRY BEANS
    (5, '170-230/100g', '15.0%', '1.0%', '0.5%', '4.0%', '99.0%', 'Export Quality - Stained 2% max, Cracked seed coat 1% max'),

    -- 6. DARK RED KIDNEY BEANS
    (6, '170-210/100g', '15.0%', '1.0%', '0.5%', '4.0%', '99.0%', 'Export Quality - Stained 2% max, Cracked seed coat 1% max'),

    -- 8. GREEN MUNG BEANS
    (8, '3.25-4 mm', '14.0%', '1.0%', '0.5%', '7.0%', '99.0%', 'Export Quality - Undersize 10% max, Discolored 3% max, Wrinkled 2% max'),

    -- 10. ALUBIA BEANS
    (10, '180-200/100g', '15.0%', '1.0%', '0.5%', '4.0%', '99.0%', 'Export Quality - Stained 2% max, Cracked seed coat 1% max'),

    -- 18. POPCORN 
    (18, '55-67 (K10)', '14.5%', '1.0%', '0.5%', '1.5%', '99.5%', 'Butterfly Type - Export Quality');
GO

CREATE TABLE [Status](
ID INT IDENTITY(1,1) NOT NULL,
[Name] VARCHAR(30) NOT NULL,
CONSTRAINT PK_Status PRIMARY KEY (ID)
);
GO 

INSERT INTO [Status] ([Name])
VALUES ('In Progress'), ('Completed'), ('Canceled');
GO

CREATE TABLE BusinessSector(
ID INT IDENTITY (1,1) NOT NULL,
Description VARCHAR (50),
CONSTRAINT PK_BusinessSector PRIMARY KEY (ID)
);
GO

INSERT INTO BusinessSector
VALUES ('Canning'), ('Repacking&Wholesaling'),('Processing/Milling'),('Trading/Brokerage');
GO

CREATE TABLE Country(
ID INT IDENTITY (1,1) NOT NULL,
[Name] VARCHAR(100) NOT NULL,
CONSTRAINT PK_Country PRIMARY KEY (ID)
);
GO

INSERT INTO Country
VALUES 
('United States'), ('Canada'), ('Mexico'), ('Guatemala'), 
('Belize'), ('El Salvador'), ('Honduras'), ('Nicaragua'), 
('Costa Rica'), ('Panama'), ('Cuba'), ('Jamaica'), 
('Haiti'), ('Dominican Republic'), ('Bahamas'), ('Trinidad and Tobago'),
('Barbados'), ('Saint Lucia'), ('Saint Kitts and Nevis'), ('Saint Vincent and the Grenadines'),
('Grenada'), ('Antigua and Barbuda'),

('Argentina'), ('Brazil'), ('Colombia'), ('Peru'), 
('Venezuela'), ('Chile'), ('Ecuador'), ('Bolivia'), 
('Paraguay'), ('Uruguay'), ('Guyana'), ('Suriname'),

('Poland'), ('Germany'), ('France'), ('Italy'), 
('Spain'), ('United Kingdom'), ('Netherlands'), ('Belgium'), 
('Switzerland'), ('Austria'), ('Sweden'), ('Norway'), 
('Finland'), ('Denmark'), ('Portugal'), ('Ireland'), 
('Greece'), ('Czech Republic'), ('Hungary'), ('Romania'), 
('Bulgaria'), ('Ukraine'), ('Russia'), ('Belarus'), 
('Slovakia'), ('Slovenia'), ('Croatia'), ('Bosnia and Herzegovina'), 
('Serbia'), ('Montenegro'), ('Albania'), ('North Macedonia'), 
('Estonia'), ('Latvia'), ('Lithuania'), ('Moldova'), 
('Georgia'), ('Armenia'), ('Azerbaijan'), ('Cyprus'), 
('Malta'), ('Iceland'), ('Luxembourg'), ('Monaco'), 
('Andorra'), ('San Marino'), ('Vatican City'), ('Liechtenstein'),

('China'), ('India'), ('Japan'), ('South Korea'), 
('Indonesia'), ('Pakistan'), ('Bangladesh'), ('Philippines'), 
('Vietnam'), ('Thailand'), ('Malaysia'), ('Singapore'), 
('Myanmar'), ('Cambodia'), ('Laos'), ('Sri Lanka'), 
('Nepal'), ('Israel'), ('Turkey'), ('Saudi Arabia'), 
('United Arab Emirates'), ('Iran'), ('Iraq'), ('Jordan'), 
('Lebanon'), ('Syria'), ('Yemen'), ('Oman'), 
('Qatar'), ('Kuwait'), ('Bahrain'), ('Kazakhstan'), 
('Uzbekistan'), ('Turkmenistan'), ('Kyrgyzstan'), ('Tajikistan'), 
('Afghanistan'), ('Mongolia'), ('Taiwan'), ('North Korea'), 
('Maldives'), ('Brunei'), ('Timor-Leste'), ('Bhutan'),

('South Africa'), ('Egypt'), ('Nigeria'), ('Kenya'), 
('Morocco'), ('Algeria'), ('Tunisia'), ('Libya'), 
('Sudan'), ('Ethiopia'), ('Ghana'), ('Ivory Coast'), 
('Senegal'), ('Cameroon'), ('Angola'), ('Mozambique'), 
('Tanzania'), ('Uganda'), ('Zimbabwe'), ('Zambia'), 
('Botswana'), ('Namibia'), ('Madagascar'), ('Mauritius'), 
('Somalia'), ('Djibouti'), ('Eritrea'), ('South Sudan'), 
('Central African Republic'), ('Chad'), ('Niger'), ('Mali'), 
('Mauritania'), ('Burkina Faso'), ('Guinea'), ('Sierra Leone'), 
('Liberia'), ('Togo'), ('Benin'), ('Gabon'), 
('Republic of the Congo'), ('Democratic Republic of the Congo'), ('Rwanda'), ('Burundi'), 
('Malawi'), ('Lesotho'), ('Eswatini'), ('Gambia'), 
('Guinea-Bissau'), ('Cape Verde'), ('Sao Tome and Principe'), ('Equatorial Guinea'), 
('Comoros'), ('Seychelles'),

('Australia'), ('New Zealand'), ('Papua New Guinea'), ('Fiji'), 
('Solomon Islands'), ('Vanuatu'), ('Samoa'), ('Tonga'), 
('Micronesia'), ('Marshall Islands'), ('Palau'), ('Kiribati'), 
('Tuvalu'), ('Nauru');
GO


CREATE TABLE Customer(
ID INT IDENTITY(1,1) NOT NULL,
[Name] VARCHAR (100) NOT NULL,
IdBusinessSector INT,
RegisteredName VARCHAR (100),
[Address] VARCHAR (100),
[E-mail] VARCHAR (100) NOT NULL,
VAT VARCHAR (100),
IdCountry INT NOT NULL,
PhoneNumber VARCHAR (50) NOT NULL,
BIO VARCHAR (MAX),
Active BIT NOT NULL,
EORI VARCHAR (50),
CONSTRAINT PK_Customer PRIMARY KEY (ID),
CONSTRAINT FK_Customer_BusinessSector FOREIGN KEY (IdBusinessSector) REFERENCES BusinessSector (ID),
CONSTRAINT FK_Customer_Country FOREIGN KEY (IdCountry) REFERENCES Country (ID)
);
GO



CREATE TABLE CustomerContact(
ID INT IDENTITY (1,1) NOT NULL,
IdCustomer INT NOT NULL,
FirstName VARCHAR (50) NOT NULL,
LastName VARCHAR (50),
[Role/Position] VARCHAR (50),
Email VARCHAR (100),
PhoneNumber VARCHAR (50),
CONSTRAINT PK_CustomerContact PRIMARY KEY (ID),
CONSTRAINT FK_CustomerContact_Customer FOREIGN KEY (IdCustomer) REFERENCES Customer (ID)
);
GO

CREATE TABLE PreferredPackaging(
ID INT IDENTITY(1,1) NOT NULL,
[Name] VARCHAR (20),
CONSTRAINT PK_PreferredPackaging PRIMARY KEY (ID)
);
GO

INSERT INTO PreferredPackaging
VALUES ('BigBag'),('25kg Bag');
GO

CREATE TABLE PurchaseFrequency(
ID INT IDENTITY(1,1) NOT NULL,
[Name] VARCHAR (20),
CONSTRAINT PK_PurchaseFrequency PRIMARY KEY (ID)
);
GO

INSERT INTO PurchaseFrequency
VALUES ('Monthly'), ('Quarterly'), ('Bi-annually'), ('Seasonal');
GO

CREATE TABLE PriceSensitivity(
ID INT IDENTITY(1,1) NOT NULL,
Level VARCHAR (20),
CONSTRAINT PK_PriceSensitivity PRIMARY KEY (ID)
);
GO

INSERT INTO PriceSensitivity
VALUES ('High'), ('Medium'), ('Low');
GO

CREATE TABLE QualityStandart(
ID INT IDENTITY(1,1) NOT NULL,
[Name] VARCHAR (50),
[Description] VARCHAR (200),
CONSTRAINT PK_QualityStandart PRIMARY KEY (ID)
);
GO
 

INSERT INTO QualityStandart ([Name])
VALUES ('Standart'), ('EU Standart'), ('Organic');
GO

CREATE TABLE CustomerProductProfile(
IdCustomer INT NOT NULL,
IdProductMaster INT NOT NULL,
AnnualVolume DECIMAL (10,3),
IdPreferredPackaging INT,
IdPurchaseFrequency INT,
IdPriceSensitivity INT,
AlternativeOrigin VARCHAR (100),
IdQualityStandart INT,
Notes VARCHAR(MAX),
CONSTRAINT PK_CustomerProductProfile PRIMARY KEY (IdCustomer, IdProductMaster),
CONSTRAINT FK_CustomerProductProfile_Customer FOREIGN KEY (IdCustomer) REFERENCES Customer (ID),
CONSTRAINT FK_CustomerProductProfile_ProductMaster FOREIGN KEY (IdProductMaster) REFERENCES ProductMaster (ID),
CONSTRAINT FK_CPP_PreferredPackaging FOREIGN KEY (IdPreferredPackaging) REFERENCES PreferredPackaging (ID),
CONSTRAINT FK_CPP_PurchaseFrequency FOREIGN KEY (IdPurchaseFrequency) REFERENCES PurchaseFrequency (ID),
CONSTRAINT FK_CPP_PriceSensitivity FOREIGN KEY (IdPriceSensitivity) REFERENCES PriceSensitivity (ID),
CONSTRAINT FK_CPP_QualityStandart FOREIGN KEY (IdQualityStandart) REFERENCES QualityStandart (ID)
);
GO

CREATE TABLE IncoTerm(
ID INT IDENTITY(1,1) NOT NULL,
Code VARCHAR (3) NOT NULL,
[Description] VARCHAR (150) NOT NULL,
CONSTRAINT PK_IncoTerm PRIMARY KEY (ID)
);
GO

INSERT INTO Incoterm (Code, [Description]) VALUES 
('FOB', 'Free On Board'),
('CFR', 'Cost and Freight'),
('CIF', 'Cost, Insurance and Freight'),
('EXW', 'Ex Works'),
('FCA', 'Free Carrier');
GO

CREATE TABLE MethodOfPayment(
ID INT IDENTITY (1,1) NOT NULL,
Code VARCHAR (30) NOT NULL,
[Description] VARCHAR (100) NOT NULL
CONSTRAINT PK_MethodOfPayment PRIMARY KEY (ID)
);
GO

INSERT INTO MethodOfPayment (Code, [Description]) VALUES 
('10/90_CAD_COPY', '10/90 CAD copy'),
('15/85_CAD_COPY', '15/85 CAD copy'),
('20/80_CAD_COPY', '20/80 CAD copy'),
('25/75_CAD_COPY', '25/75 CAD copy'),
('30/70_CAD_COPY', '30/70 CAD copy'),
('35/65_CAD_COPY', '35/65 CAD copy'),
('40/60_CAD_COPY', '40/60 CAD copy'),
('45/55_CAD_COPY', '45/55 CAD copy'),
('50/50_CAD_COPY', '50/50 CAD copy'),
('55/45_CAD_COPY', '55/45 CAD copy'),
('60/40_CAD_COPY', '60/40 CAD copy'),
('65/35_CAD_COPY', '65/35 CAD copy'),
('70/30_CAD_COPY', '70/30 CAD copy'),
('75/25_CAD_COPY', '75/25 CAD copy'),
('80/20_CAD_COPY', '80/20 CAD copy'),
('85/15_CAD_COPY', '85/15 CAD copy'),
('90/10_CAD_COPY', '90/10 CAD copy'),
('95/05_CAD_COPY', '95/05 CAD copy'),
('100_CAD_COPY', '100 CAD copy'),
('100_CAD_BANK', '100 CAD bank');
GO

CREATE TABLE Currency(
ID INT IDENTITY(1,1) NOT NULL,
Code VARCHAR (3) NOT NULL,
[Name] VARCHAR (50) NOT NULL
CONSTRAINT PK_Currency PRIMARY KEY (ID)
);
GO

INSERT INTO Currency (Code, [Name]) VALUES 
-- Monedas Principales de Comercio Exterior
('USD', 'US Dollar'),
('EUR', 'Euro'),
('GBP', 'British Pound'),
('CHF', 'Swiss Franc'),

-- Europa del Este
('PLN', 'Polish Zloty'),
('CZK', 'Czech Koruna'),
('HUF', 'Hungarian Forint'),
('UAH', 'Ukrainian Hryvnia'),
('BGN', 'Bulgarian Lev'),
('RON', 'Romanian Leu'),

-- América 
('ARS', 'Argentine Peso'),
('BRL', 'Brazilian Real'),
('CAD', 'Canadian Dollar'),
('MXN', 'Mexican Peso'),
('COP', 'Colombian Peso'),

-- Asia y Medio Oriente
('CNY', 'Chinese Yuan'),
('INR', 'Indian Rupee'),
('JPY', 'Japanese Yen'),
('SGD', 'Singapore Dollar'),
('HKD', 'Hong Kong Dollar'),
('AED', 'UAE Dirham'),
('TRY', 'Turkish Lira'),
('THB', 'Thai Baht'),
('VND', 'Vietnamese Dong'),
('MYR', 'Malaysian Ringgit');
GO


CREATE TABLE [Ports](
ID INT IDENTITY(1,1) NOT NULL,
[Name] VARCHAR (50) NOT NULL,
IdCountry INT,
CONSTRAINT PK_Ports PRIMARY KEY (ID),
CONSTRAINT FK_Ports_Country FOREIGN KEY (IdCountry) REFERENCES Country (ID)
);
GO

INSERT INTO Ports([Name], IdCountry) VALUES 
-- POLONIA Y BÁLTICO
('Gdynia', 35),('Gdansk', 35),('Szczecin', 35),('Swinoujscie', 35),('Klaipeda', 69),('Riga', 68),('Tallinn', 67),

-- EUROPA DEL NORTE Y OESTE
('Hamburg', 36),('Bremen', 36),('Bremerhaven', 36),('Rotterdam', 41),('Antwerp', 42), ('Zeebrugge', 42),('Le Havre', 37),('Marseille', 37),('Felixstowe', 40),('Southampton', 40),
('London', 40),('Dublin', 50),

-- EUROPA DEL SUR Y MEDITERRÁNEO
('Valencia', 39),('Barcelona', 39),('Algeciras', 39),('Bilbao', 39),('Genoa', 38),('Trieste', 38),('Livorno', 38),('Civitavecchia', 38),('Piraeus', 51),('Thessaloniki', 51),
('Koper', 60),('Rijeka', 61),('Constanta', 54),('Varna', 55),

-- AMÉRICA DEL SUR
('Buenos Aires', 23),('Rosario', 23),('San Lorenzo', 23),('Bahia Blanca', 23),('Necochea', 23),('Montevideo', 32),('Santos', 24),('Paranagua', 24),('Rio Grande', 24),('Itajai', 24),
('Salvador', 24),('San Antonio', 28),('Valparaiso', 28),('Callao', 26),('Paita', 26),('Guayaquil', 29),('Buenaventura', 25),('Cartagena', 25),('Puerto Cabello', 27),

-- AMÉRICA DEL NORTE Y CENTRAL
('Vancouver', 2),('Montreal', 2),('Prince Rupert', 2),('New York & New Jersey', 1),('Los Angeles', 1),('Long Beach', 1),('Seattle', 1),('Savannah', 1),('Houston', 1),('New Orleans', 1),
('Norfolk', 1),('Miami', 1),('Veracruz', 3),('Manzanillo', 3),('Altamira', 3),('Lazaro Cardenas', 3),('Puerto Quetzal', 4),('Puerto Cortes', 7),('Balboa', 10),('Colon', 10),

-- ASIA
('Shanghai', 83),('Ningbo-Zhoushan', 83),('Shenzhen', 83),('Qingdao', 83),('Tianjin', 83),('Guangzhou', 83),('Xiamen', 83),('Dalian', 83),('Hong Kong', 83),('Kaohsiung', 121),('Keelung', 121),
('Singapore', 94),('Port Klang', 93),('Tanjung Pelepas', 93),('Laem Chabang', 92),('Bangkok', 92),('Ho Chi Minh City', 91),('Haiphong', 91),('Jakarta (Tanjung Priok)', 87),('Surabaya', 87),
('Manila', 90),('Tokyo', 85),('Yokohama', 85),('Kobe', 85),('Osaka', 85),('Busan', 86),('Incheon', 86),('Nhava Sheva (Mumbai)', 84),('Mundra', 84),('Chennai', 84),('Kolkata', 84),('Karachi', 88),
('Qasim', 88),('Colombo', 98),('Chittagong', 89),

-- MEDIO ORIENTE Y TURQUÍA
('Jebel Ali (Dubai)', 103),('Abu Dhabi', 103),('Jeddah', 102),('Dammam', 102),('Ambarli (Istanbul)', 101),('Mersin', 101),('Izmir', 101),('Haifa', 100),('Ashdod', 100),('Aqaba', 106),
('Salalah', 110),('Doha', 111),

-- ÁFRICA
('Durban', 127),('Cape Town', 127),('Port Said', 128),('Alexandria', 128),('Damietta', 128),('Casablanca', 131),('Tanger Med', 131),('Algiers', 132),('Tunis', 133),('Lagos (Apapa)', 129),
('Tin Can Island', 129),('Mombasa', 130),('Dar es Salaam', 143),('Abidjan', 138),('Dakar', 139),('Beira', 142),('Luanda', 141),('Djibouti', 152),

-- OCEANÍA
('Sydney', 181),('Melbourne', 181),('Brisbane', 181),('Fremantle', 181),('Auckland', 182),('Tauranga', 182);
GO



CREATE TABLE Sales(
ID INT IDENTITY(1,1) NOT NULL,
IdCustomer INT NOT NULL,
IdProduct INT NOT NULL,
IdStatus INT NOT NULL,
ContractDate DATE NOT NULL,
Shipper VARCHAR (100),
Seller VARCHAR (100),
CropYear VARCHAR (20) NOT NULL,
Quantity DECIMAL(10,3) NOT NULL,
PricePerTon DECIMAL (9,2) NOT NULL,
IdCurrency INT NOT NULL,
IdIncoTerm INT NOT NULL,
IdMethodOfPayment INT NOT NULL,
IdPortOfLoading INT,
IdPortOfDestination INT,
BrokerComissionPc DECIMAL (3,2),
CONSTRAINT PK_SaleS PRIMARY KEY (ID),
CONSTRAINT FK_Sales_Customer FOREIGN KEY (IdCustomer) REFERENCES Customer (ID),
CONSTRAINT FK_Sales_Status FOREIGN KEY (IdStatus) REFERENCES [Status] (ID),
CONSTRAINT FK_Sales_Product FOREIGN KEY (IdProduct) REFERENCES ProductMaster (ID),
CONSTRAINT FK_Sales_Currency FOREIGN KEY (IdCurrency) REFERENCES Currency (ID),
CONSTRAINT FK_Sales_IncoTerm FOREIGN KEY (IdIncoTerm) REFERENCES Incoterm (ID),
CONSTRAINT FK_Sales_MOP FOREIGN KEY (IdMethodOfPayment) REFERENCES MethodOfPayment (ID),
CONSTRAINT FK_Sales_POL FOREIGN KEY (IdPortOfLoading) REFERENCES [Ports] (ID),
CONSTRAINT FK_Sales_POD FOREIGN KEY (IdPortOfDestination) REFERENCES [Ports] (ID)
);
GO


CREATE TABLE ShipmentStatus(
ID INT IDENTITY(1,1) NOT NULL,
[Name] VARCHAR (30) NOT NULL,
CONSTRAINT PK_ShipmentStatus PRIMARY KEY (ID)
);
GO

INSERT INTO ShipmentStatus ([Name]) VALUES 
('Awaiting Consolidation'),    
('Consolidated'),             
('Shipped / On Board'),       
('BL Drafts Sent'),           
('BL Drafts Confirmed'),     
('Originals Sent by Email'), 
('Paid'),        
('Physical Documents Sent'),   
('Arrived at Destination'),   
('Completed'),
('Canceled');                
GO

CREATE TABLE ContainerType (
    ID INT IDENTITY(1,1) NOT NULL,
    Code VARCHAR(10) NOT NULL, 
    [Description] VARCHAR(100) NOT NULL, 
    CONSTRAINT PK_ContainerType PRIMARY KEY (ID)
);
GO

INSERT INTO ContainerType (Code, [Description]) VALUES 
('20DV', '20'' Standard Dry Van'),
('40DV', '40'' Standard Dry Van'),
('40HC', '40'' High Cube (Extra Height)'),
('20RF', '20'' Reefer (Refrigerated)'),
('40RF', '40'' Reefer (Refrigerated)');
GO



CREATE TABLE Shipments(
ID INT IDENTITY (1,1) NOT NULL,
IdSales INT NOT NULL,
IdShipmentStatus INT NOT NULL,
BookingNumber VARCHAR (50),
ContainerNumber VARCHAR (MAX),
IdContainerType INT,
ShippingLine VARCHAR (100),
IdPortOfLoading INT,
IdPortOfDestination INT,
ETD DATE,
ATD DATE,
ETA DATE,
ATA DATE,
FreeDays VARCHAR (50),
BLApproved BIT NOT NULL DEFAULT 0,
DHLNumber VARCHAR (100),
HasClaim BIT DEFAULT 0,
ClaimNotes VARCHAR (MAX),
Notes VARCHAR (MAX),
CONSTRAINT PK_Shipments PRIMARY KEY (ID),
CONSTRAINT FK_Shipments_Sale FOREIGN KEY (IdSales) REFERENCES Sales (ID),
CONSTRAINT FK_Shipments_ShipmentStatus FOREIGN KEY (IdShipmentStatus) REFERENCES ShipmentStatus (ID),
CONSTRAINT FK_Shipments_ContainerType FOREIGN KEY (IdContainerType) REFERENCES ContainerType (ID),
CONSTRAINT FK_Shipments_POL FOREIGN KEY (IdPortOfLoading) REFERENCES [Ports] (ID),
CONSTRAINT FK_Shipments_POD FOREIGN KEY (IdPortOfDestination) REFERENCES [Ports] (ID)
);
GO