-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Värd: 127.0.0.1
-- Tid vid skapande: 20 feb 2020 kl 14:39
-- Serverversion: 10.1.38-MariaDB
-- PHP-version: 7.3.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Databas: `bachelorproject_db`
--

-- --------------------------------------------------------

--
-- Tabellstruktur `company`
--

CREATE TABLE `company` (
  `CompanyId` int(11) NOT NULL,
  `Company_Name` varchar(50) NOT NULL,
  `Company_DirectionIn` tinyint(1) NOT NULL,
  `Company_DirectionOut` tinyint(1) NOT NULL,
  `Company_Phone` varchar(50) NOT NULL,
  `Company_Label` varchar(50) NOT NULL,
  `Company_Slogan` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellstruktur `department`
--

CREATE TABLE `department` (
  `DepartmentId` int(11) NOT NULL,
  `CompanyId` int(11) NOT NULL,
  `Department_Description` text NOT NULL,
  `Department_Key` varchar(50) NOT NULL,
  `Department_Label` varchar(50) NOT NULL,
  `Department_Name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellstruktur `person`
--

CREATE TABLE `person` (
  `PersonId` int(11) NOT NULL,
  `EmployeeId` int(11) NOT NULL COMMENT 'relation',
  `Person_Address1` varchar(50) NOT NULL,
  `Person_Address2` varchar(50) NOT NULL,
  `Person_Address3` varchar(50) NOT NULL,
  `Person_Address4` varchar(50) NOT NULL,
  `Person_Address5` varchar(50) NOT NULL,
  `Person_Name` varchar(50) NOT NULL,
  `Person_BirthDate` datetime NOT NULL,
  `Person_Class` varchar(50) NOT NULL,
  `Person_Description` text NOT NULL,
  `Person_Gender` varchar(50) NOT NULL,
  `Person_LastName` varchar(50) NOT NULL,
  `LookupItem_CountryId` varchar(32) NOT NULL COMMENT 'guid',
  `Person_FullName` varchar(50) NOT NULL,
  `Person_Phone` varchar(50) NOT NULL,
  `Person_FavoritePizza` varchar(50) NOT NULL,
  `Person_CustomFields` varchar(50) NOT NULL,
  `DefaultCompanyId` varchar(32) NOT NULL COMMENT 'guid',
  `Person_FavoritePasta` varchar(50) NOT NULL,
  `Person_Division` varchar(50) NOT NULL,
  `Person_Email` varchar(50) NOT NULL,
  `Person_Rating` varchar(50) NOT NULL,
  `Person_Reference` varchar(50) NOT NULL,
  `Person_FaxNumber` varchar(50) NOT NULL,
  `Person_FirstName2` varchar(50) NOT NULL,
  `StoneBricksID` varchar(32) NOT NULL COMMENT 'guid',
  `Person_Group` varchar(50) NOT NULL,
  `Person_GroupCode` varchar(50) NOT NULL,
  `Person_HasData` tinyint(1) NOT NULL,
  `Person_String` varchar(50) NOT NULL,
  `Person_FavoriteInstrument` varchar(50) NOT NULL,
  `myAccountId1` varchar(32) NOT NULL COMMENT 'guid',
  `myAccountId2` varchar(32) NOT NULL COMMENT 'guid',
  `Person_InternalCode` varchar(50) NOT NULL,
  `Person_HasParty` tinyint(1) NOT NULL,
  `Person_IsCompany` tinyint(1) NOT NULL,
  `Person_IsPhilosopher` tinyint(1) NOT NULL,
  `Person_HasCompany` tinyint(1) NOT NULL,
  `Person_IsSupplier` tinyint(1) NOT NULL,
  `Person_HasIssues` tinyint(1) NOT NULL,
  `Person_IsNaturalPerson` tinyint(1) NOT NULL,
  `Person_IsPerson` tinyint(1) NOT NULL,
  `Person_IsProfessional` tinyint(1) NOT NULL,
  `Person_IsReseller` tinyint(1) NOT NULL,
  `Person_IsTaxPayer` tinyint(1) NOT NULL,
  `Person_LastName2` varchar(50) NOT NULL,
  `Person_LEIA` varchar(50) NOT NULL,
  `Person_FavoriteMOvie` varchar(50) NOT NULL,
  `Person_MiddleNames` varchar(50) NOT NULL,
  `Person_Migration` varchar(50) NOT NULL,
  `Person_LaundryRisk` varchar(50) NOT NULL,
  `Person_PassportNumber` varchar(50) NOT NULL,
  `Person_PersonalNumber` varchar(50) NOT NULL,
  `Person_PhoneHome` varchar(50) NOT NULL,
  `Person_PhoneMobile` varchar(50) NOT NULL,
  `Person_PhoneWork` varchar(50) NOT NULL,
  `Person_PostageAddressAttention` varchar(50) NOT NULL,
  `Person_PostageAddressCity` varchar(50) NOT NULL,
  `Person_PostageAddressCO` varchar(50) NOT NULL,
  `PostageAddressCountryId` varchar(32) NOT NULL COMMENT 'guid',
  `Person_PostageAddressDepartment` varchar(50) NOT NULL,
  `Person_PostageAddressStreet` varchar(50) NOT NULL,
  `Person_PostageAddressZip` varchar(50) NOT NULL,
  `Person_Brokernode` varchar(50) NOT NULL,
  `Person_Opinions` varchar(50) NOT NULL,
  `Person_MovieComment` varchar(50) NOT NULL,
  `Person_CreditCardCode` varchar(50) NOT NULL,
  `Person_FavoriteDrink` varchar(50) NOT NULL,
  `Person_PepsiStatus` int(11) NOT NULL,
  `Person_PrintStatus` int(11) NOT NULL,
  `Person_PrintStatusTimeStamp` datetime NOT NULL,
  `Person_PrintStatusTimeStampString` varchar(50) NOT NULL,
  `Person_RatingAgency` varchar(50) NOT NULL,
  `ResellerId` varchar(32) NOT NULL COMMENT 'guid',
  `Person_Section` varchar(50) NOT NULL,
  `Person_Sector` varchar(50) NOT NULL,
  `Person_Signing` varchar(50) NOT NULL,
  `Person_Taxi` varchar(32) NOT NULL COMMENT 'guid',
  `Person_KnowledgeLevel` varchar(50) NOT NULL,
  `CountryId2` varchar(32) NOT NULL COMMENT 'guid',
  `Person_Id2` varchar(50) NOT NULL,
  `Person_IdType` varchar(50) NOT NULL,
  `Person_ManualHandling` tinyint(1) NOT NULL,
  `InstanceId` varchar(32) NOT NULL COMMENT 'guid'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellstruktur `product`
--

CREATE TABLE `product` (
  `ProductId` int(11) NOT NULL,
  `productTypeId` int(11) NOT NULL COMMENT 'relation',
  `CompanyId` int(11) NOT NULL COMMENT 'relation',
  `ManagerId` varchar(32) NOT NULL COMMENT 'guid',
  `AdministratorId` varchar(32) NOT NULL COMMENT 'guid',
  `Product_Interval` int(11) NOT NULL,
  `AdjustedId` varchar(32) NOT NULL COMMENT 'guid',
  `Product_Comment` varchar(50) NOT NULL,
  `Product_Country` varchar(32) NOT NULL COMMENT 'guid',
  `Currency` varchar(50) NOT NULL,
  `Product_Type` varchar(50) NOT NULL,
  `Product_DescriptionString` text NOT NULL,
  `Product_EndDate` datetime NOT NULL,
  `Product_ExternalReference` varchar(50) NOT NULL,
  `Product_Price` decimal(10,2) NOT NULL,
  `Product_Interests` varchar(50) NOT NULL,
  `Product_Category` varchar(50) NOT NULL,
  `Product_CommissionPrice` decimal(10,2) NOT NULL,
  `Product_SupplierId` varchar(32) NOT NULL COMMENT 'guid',
  `Product_Rating` decimal(10,2) NOT NULL,
  `Product_Key` varchar(50) NOT NULL,
  `Product_Max` varchar(50) NOT NULL,
  `Product_Name` varchar(50) NOT NULL,
  `Product_Price2` decimal(10,2) NOT NULL,
  `Product_Parameters` varchar(50) NOT NULL,
  `Product_NoticeLevel` int(11) NOT NULL,
  `Product_Premium` varchar(50) NOT NULL,
  `Product_Product` varchar(50) NOT NULL,
  `Product_Version` varchar(50) NOT NULL,
  `Product_Level` decimal(10,2) NOT NULL,
  `Product_ApprovedDate` datetime NOT NULL,
  `ResellerId` varchar(32) NOT NULL COMMENT 'guid',
  `Product_Retention` decimal(10,2) NOT NULL,
  `Product_Rule1` decimal(10,2) NOT NULL,
  `Product_Rule2` decimal(10,2) NOT NULL,
  `Product_Rule3` decimal(10,2) NOT NULL,
  `Product_Method` varchar(50) NOT NULL,
  `Product_StartDate` datetime NOT NULL,
  `Product_Status` int(11) NOT NULL,
  `Product_StatusString` varchar(50) NOT NULL,
  `Product_PhoneNo` varchar(50) NOT NULL,
  `Product_URL` varchar(50) NOT NULL,
  `ProductType` varchar(32) NOT NULL COMMENT 'guid'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellstruktur `producttype`
--

CREATE TABLE `producttype` (
  `ProductTypeId` int(11) NOT NULL,
  `ProductType_DescriptionString` text NOT NULL,
  `ProductType_KeySellingPoint` varchar(50) NOT NULL,
  `ProductType_Label` varchar(50) NOT NULL,
  `ProductType_Name` varchar(50) NOT NULL,
  `ProductType_Status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Index för dumpade tabeller
--

--
-- Index för tabell `company`
--
ALTER TABLE `company`
  ADD PRIMARY KEY (`CompanyId`);

--
-- Index för tabell `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`DepartmentId`),
  ADD UNIQUE KEY `DepartmentId` (`DepartmentId`);

--
-- Index för tabell `person`
--
ALTER TABLE `person`
  ADD PRIMARY KEY (`PersonId`),
  ADD UNIQUE KEY `EmployeeId` (`EmployeeId`);

--
-- Index för tabell `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductId`),
  ADD UNIQUE KEY `CompanyId` (`CompanyId`,`productTypeId`);

--
-- Index för tabell `producttype`
--
ALTER TABLE `producttype`
  ADD PRIMARY KEY (`ProductTypeId`);

--
-- AUTO_INCREMENT för dumpade tabeller
--

--
-- AUTO_INCREMENT för tabell `company`
--
ALTER TABLE `company`
  MODIFY `CompanyId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT för tabell `department`
--
ALTER TABLE `department`
  MODIFY `DepartmentId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT för tabell `person`
--
ALTER TABLE `person`
  MODIFY `PersonId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT för tabell `product`
--
ALTER TABLE `product`
  MODIFY `ProductId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT för tabell `producttype`
--
ALTER TABLE `producttype`
  MODIFY `ProductTypeId` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
