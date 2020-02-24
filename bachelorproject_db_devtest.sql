-- phpMyAdmin SQL Dump
-- version 4.8.5
-- https://www.phpmyadmin.net/
--
-- Värd: 127.0.0.1
-- Tid vid skapande: 24 feb 2020 kl 09:48
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

--
-- Dumpning av Data i tabell `company`
--

INSERT INTO `company` (`CompanyId`, `Company_Name`, `Company_DirectionIn`, `Company_DirectionOut`, `Company_Phone`, `Company_Label`, `Company_Slogan`) VALUES
(1, 'hassel ', 1, 0, 'kentrolite ', 'bystreets ', 'piteous '),
(2, 'tyrannizes ', 1, 0, 'orbiculatoelliptical ', 'idiocratic ', 'rockwood '),
(3, 'alethiologic ', 1, 1, 'corevolve ', 'sylphids ', 'recalesce '),
(4, 'hyperepinephrinemia ', 0, 0, 'holometabole ', 'gulliver ', 'soubresauts '),
(5, 'faired ', 0, 0, 'executonis ', 'todlowrie ', 'inevaporable '),
(6, 'misinflame ', 0, 1, 'rootery ', 'townsendite ', 'betting '),
(7, 'reliquefying ', 0, 0, 'souplike ', 'noctule ', 'petiole '),
(8, 'masty ', 1, 1, 'keratitis ', 'disapprovals ', 'philantomba '),
(9, 'precleans ', 1, 1, 'florican ', 'poetic ', 'windwaywardly '),
(10, 'plasmapheresis ', 1, 0, 'undismayedly ', 'metargon ', 'simility ');

-- --------------------------------------------------------

--
-- Tabellstruktur `department`
--

CREATE TABLE `department` (
  `DepartmentId` int(11) NOT NULL,
  `CompanyId` int(11) NOT NULL COMMENT 'relation',
  `Department_Description` text NOT NULL,
  `Department_Key` varchar(50) NOT NULL,
  `Department_Label` varchar(50) NOT NULL,
  `Department_Name` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumpning av Data i tabell `department`
--

INSERT INTO `department` (`DepartmentId`, `CompanyId`, `Department_Description`, `Department_Key`, `Department_Label`, `Department_Name`) VALUES
(1, 9, 'uncongenially disability refallen condition phenalgin svanetian blepharoconjunctivitis pulicarious warrantor periependymal racebrood wists domett noncompulsory mycomycetous underpossessor subterjacent occident haddocker ', 'predaceous ', 'worses ', 'uncompulsively '),
(2, 3, 'synchronise tungstenic medusae inveteration cryptology recomparison clackdish butterfish polypus perfectivize quailery icehouse battuta limpets falcade moffle rankless homodermic heypen unharmonised choriambuses snod ', 'beseek ', 'myxopodia ', 'nonboasting '),
(3, 4, 'minyadidae unepithelial spuria sarafan unwrit osteodermous unfrenchified acridonium nici diffide manhunts endoblastic tragedienne cockawee uralitizing prosit anconeal nassidae remunerativeness waterings antipatheticalness ', 'icosasemic ', 'archiepiscopality ', 'dehydrogenase '),
(4, 2, 'mismosh oversaves semiannealed debuts doilies unimpoisoned unabetted coracomorph eucryphiaceae larrikinism absolves become paratriptic heteronymic douanes hypostases bulliest nondemocracies planetogeny unimpartable bashmuric ', 'overgrind ', 'azure ', 'tears '),
(5, 5, 'houseling reprisalist redocument competitively cojudge reexplicated cupules dictum pulers swell vinicultural mantispid strelitzi kilopound dextrans bopster autocracy defleas shebeening misses rulingly circumscriptions ', 'cremated ', 'dimensible ', 'ethmolachrymal '),
(6, 8, 'avocat formulizing nonimmanency miscal unlaconic hazzanut hitlerite traditions dungy crabbedness troic beadledom trawlnet futilitarian unorphaned dolci bucking anomoeanism petroglyph barndoor antimonium tuberculiferous ', 'bonedry ', 'acrimoniousness ', 'reflector '),
(7, 6, 'raffishness chiliagon introactive longer conclaves somatological footwalls acclaim jalloped sittringy anterior somnambulance retches tobymen nondefensively cuspidate nonfashionableness hypochlorhydria intermesenterial ', 'holoparasite ', 'equestrienne ', 'seismograph '),
(8, 7, 'craniums aliening cicone nonqualification lightbrained setaceous rubbernecker acervuline lacrym trifanious envisionment tetanise procerebrum stroying preacknowledgment maumet foilsmen addressograph gypster scroinoch uncomputableness ', 'nonstylization ', 'teruah ', 'begirdle '),
(9, 2, 'heliochrome parosteosis bulletmaking ruggedize unpalatal tachysystole monotheists bluegown squirreled revolution tiswin fartherer meningocortical unpromising incurved unchronically cattleship amphibolite sloops annunciators ', 'palaeophytic ', 'ir ', 'nitrogenization '),
(10, 1, 'pickaxed zoilean multivalent warrty syzygium fibrinokinase unpontifical illicit axolotl untidied parlamento redocketing leproseries lyophobe nabla kehoeite alectoris unejective chondrification beflecking goldenmouth vomers ', 'interdeal ', 'mellisugent ', 'coadunite ');

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
  `LookupItem_CountryId` varchar(36) NOT NULL COMMENT 'guid',
  `Person_FullName` varchar(50) NOT NULL,
  `Person_Phone` varchar(50) NOT NULL,
  `Person_FavoritePizza` varchar(50) NOT NULL,
  `Person_CustomFields` varchar(50) NOT NULL,
  `DefaultCompanyId` varchar(36) NOT NULL COMMENT 'guid',
  `Person_FavoritePasta` varchar(50) NOT NULL,
  `Person_Division` varchar(50) NOT NULL,
  `Person_Email` varchar(50) NOT NULL,
  `Person_Rating` varchar(50) NOT NULL,
  `Person_Reference` varchar(50) NOT NULL,
  `Person_FaxNumber` varchar(50) NOT NULL,
  `Person_FirstName2` varchar(50) NOT NULL,
  `StoneBricksID` varchar(36) NOT NULL COMMENT 'guid',
  `Person_Group` varchar(50) NOT NULL,
  `Person_GroupCode` varchar(50) NOT NULL,
  `Person_HasData` tinyint(1) NOT NULL,
  `Person_String` varchar(50) NOT NULL,
  `Person_FavoriteInstrument` varchar(50) NOT NULL,
  `myAccountId1` varchar(36) NOT NULL COMMENT 'guid',
  `myAccountId2` varchar(36) NOT NULL COMMENT 'guid',
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
  `PostageAddressCountryId` varchar(36) NOT NULL COMMENT 'guid',
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
  `ResellerId` varchar(36) NOT NULL COMMENT 'guid',
  `Person_Section` varchar(50) NOT NULL,
  `Person_Sector` varchar(50) NOT NULL,
  `Person_Signing` varchar(50) NOT NULL,
  `Person_Taxi` varchar(36) NOT NULL COMMENT 'guid',
  `Person_KnowledgeLevel` varchar(50) NOT NULL,
  `CountryId2` varchar(36) NOT NULL COMMENT 'guid',
  `Person_Id2` varchar(50) NOT NULL,
  `Person_IdType` varchar(50) NOT NULL,
  `Person_ManualHandling` tinyint(1) NOT NULL,
  `InstanceId` varchar(36) NOT NULL COMMENT 'guid'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumpning av Data i tabell `person`
--

INSERT INTO `person` (`PersonId`, `EmployeeId`, `Person_Address1`, `Person_Address2`, `Person_Address3`, `Person_Address4`, `Person_Address5`, `Person_Name`, `Person_BirthDate`, `Person_Class`, `Person_Description`, `Person_Gender`, `Person_LastName`, `LookupItem_CountryId`, `Person_FullName`, `Person_Phone`, `Person_FavoritePizza`, `Person_CustomFields`, `DefaultCompanyId`, `Person_FavoritePasta`, `Person_Division`, `Person_Email`, `Person_Rating`, `Person_Reference`, `Person_FaxNumber`, `Person_FirstName2`, `StoneBricksID`, `Person_Group`, `Person_GroupCode`, `Person_HasData`, `Person_String`, `Person_FavoriteInstrument`, `myAccountId1`, `myAccountId2`, `Person_InternalCode`, `Person_HasParty`, `Person_IsCompany`, `Person_IsPhilosopher`, `Person_HasCompany`, `Person_IsSupplier`, `Person_HasIssues`, `Person_IsNaturalPerson`, `Person_IsPerson`, `Person_IsProfessional`, `Person_IsReseller`, `Person_IsTaxPayer`, `Person_LastName2`, `Person_LEIA`, `Person_FavoriteMOvie`, `Person_MiddleNames`, `Person_Migration`, `Person_LaundryRisk`, `Person_PassportNumber`, `Person_PersonalNumber`, `Person_PhoneHome`, `Person_PhoneMobile`, `Person_PhoneWork`, `Person_PostageAddressAttention`, `Person_PostageAddressCity`, `Person_PostageAddressCO`, `PostageAddressCountryId`, `Person_PostageAddressDepartment`, `Person_PostageAddressStreet`, `Person_PostageAddressZip`, `Person_Brokernode`, `Person_Opinions`, `Person_MovieComment`, `Person_CreditCardCode`, `Person_FavoriteDrink`, `Person_PepsiStatus`, `Person_PrintStatus`, `Person_PrintStatusTimeStamp`, `Person_PrintStatusTimeStampString`, `Person_RatingAgency`, `ResellerId`, `Person_Section`, `Person_Sector`, `Person_Signing`, `Person_Taxi`, `Person_KnowledgeLevel`, `CountryId2`, `Person_Id2`, `Person_IdType`, `Person_ManualHandling`, `InstanceId`) VALUES
(1, 10, 'enthymeme ', 'photechy ', 'tideswell ', 'clausilia ', 'unsubmitting ', 'stereocomparagraph ', '2020-04-30 10:46:54', 'lockbox ', 'phallocrypsis coagulative ureosecretory moguey hotchpotchly inboards aristol foreplays joyweed mesenterium julianto chamberer vulturinae splitters youthless prizing flocculose arriswise precompulsion nonowning turrel ', 'dumpy ', 'meteorically ', 'ed1002b5-5a02-462e-a584-eefcbaa847af', 'yaupon ', 'scyphistomoid ', 'thermolabile ', 'lepidoblastic ', '626be9fc-f155-4bfd-8340-693c15f1cad0', 'slosher ', 'noncallability ', 'cismontanism ', 'summarizations ', 'presentiments ', 'circumradii ', 'unextinctness ', '617cd1f7-180c-4544-b215-d2539e7236c1', 'coercends ', 'verberation ', 0, 'rouncival ', 'narc ', 'b5fa91b9-1d24-40d0-a88e-f6295ab17dfd', 'f3afac02-e403-433c-b562-112dcff045bc', 'epencephalons ', 1, 1, 1, 1, 0, 0, 0, 1, 0, 1, 1, 'tomcatted ', 'offhandedness ', 'fraid ', 'tricolic ', 'pathetical ', 'pepsine ', 'bespate ', 'nonprofession ', 'daydrudge ', 'supercynical ', 'agminate ', 'saguerus ', 'downtown ', 'inhabitability ', 'cb2cecdb-9600-4040-8ba0-7c1456efe914', 'electrics ', 'thinkingness ', 'pass ', 'mistimes ', 'spectrographer ', 'ferineness ', 'hessians ', 'quohog ', 1560659861, 1182004213, '2014-10-14 12:47:01', 'questman ', 'minion ', 'a034e147-1e2a-45c5-8d98-1136e2ff36a5', 'longilingual ', 'alodialism ', 'antheridium ', '4e9ed7c9-efda-469c-bea3-c360c01c49c6', 'nonsubliminal ', '1fee55d7-b143-40bc-87cb-0efa6746aae3', 'cockled ', 'feigher ', 0, '0b31e091-a637-4e96-8e62-7d0f828ca98f'),
(2, 1, 'hydroidean ', 'tithes ', 'beardedness ', 'reporteress ', 'barramunda ', 'looping ', '2020-09-19 14:47:01', 'horseplay ', 'acinary monocots unpsychopathic pursier trichronous glads phaeosporous noneuphoniously infratonsillar rateability americomania womaned wastelot archipelagian shtetel nonprotractile lepidodendroid bezzi horsefishes tremolando ', 'epeus ', 'acrindoline ', '6edb2617-adbb-4150-a6ac-26fdb87ce27f', 'needlefish ', 'uncrumpled ', 'largy ', 'antanandro ', 'baf5eabc-6a41-4656-b5b9-2ddd379a5516', 'frison ', 'nonpermanence ', 'horonite ', 'scorpionfish ', 'competent ', 'tonsures ', 'equalize ', '136e984f-08e2-442f-b62e-073aae0dbd01', 'hexastigm ', 'midocean ', 0, 'idiomorphous ', 'indirectly ', 'fd19576f-7ed8-4f51-b1ef-5c1dc234a673', '6b41f07e-5579-4ccd-9b93-4c79e0c339ce', 'typefounder ', 0, 1, 0, 0, 0, 0, 0, 0, 1, 1, 0, 'overlittle ', 'preternaturalism ', 'inkling ', 'pituite ', 'nonincreasing ', 'encephalalgia ', 'cargos ', 'skreel ', 'assailment ', 'taxodont ', 'canids ', 'nonvitiation ', 'funky ', 'crossroading ', 'd1c7e48e-8f45-4e33-b61e-aa5b6431bd42', 'loess ', 'sughing ', 'bishopscap ', 'parennir ', 'epipolism ', 'bawls ', 'conferencing ', 'dismissible ', 1501357228, 536290104, '2021-01-20 17:47:01', 'ironed ', 'harem ', '71291b87-69fb-467f-a00b-bdd00166e8ba', 'semihumanism ', 'signalment ', 'candleball ', '06666e17-89b3-483e-b81c-ed2402094392', 'tussuck ', '1002bb0a-c3e2-4a1d-99f1-928013c35324', 'ephedraceae ', 'metallic ', 1, '7a03af7c-875e-4c6f-aaf4-5c7a328926d1'),
(3, 7, 'spongier ', 'meadwort ', 'peartly ', 'subungulata ', 'friponerie ', 'endemically ', '2020-02-28 09:47:01', 'galvanotactic ', 'misbranded firehouses autoschediastical chromophilous dialectologic universitas leucines playland musnud castoff decyl acknowledger urna inconcussible trevets crowdedly rearii reproductively monumentalize rabbitwood rugose ', 'staphylectomy ', 'perissological ', '736780ce-0477-477d-b4b8-e09915f1f85b', 'carburise ', 'associableness ', 'unannihilative ', 'reincidency ', 'fc367630-5a9d-4312-b78a-04bde3bb6cea', 'hymeneal ', 'negroloid ', 'vehiculatory ', 'affettuoso ', 'justicing ', 'disarmingly ', 'dehydrogenase ', '6547b619-223f-4e5c-ba40-731461aee95b', 'overoptimism ', 'clarabella ', 1, 'vivariia ', 'diuretical ', 'd8106e10-a034-480a-8b69-186341376b83', 'f8ef3322-89f0-4086-b9d0-ea3f7754a97f', 'localizer ', 0, 1, 0, 1, 1, 0, 0, 0, 0, 1, 0, 'falconidae ', 'stockcar ', 'lengthsmen ', 'cambodians ', 'oblong ', 'lossproof ', 'unrestraint ', 'manifoldwise ', 'banders ', 'yam ', 'phlegmonoid ', 'arrowlike ', 'reaspire ', 'roadite ', '9c1755eb-7e59-4201-afc7-be559d2f473a', 'nontoxic ', 'bacteriaemia ', 'albruna ', 'unaudibly ', 'somniloquist ', 'scissurellidae ', 'allactite ', 'pluriliteral ', 306559642, 1717920678, '2016-06-21 02:47:01', 'alfin ', 'bowing ', '0ad04389-d48b-46a9-bca8-94f287ef2972', 'animacule ', 'blarney ', 'cheka ', 'd684c418-d14c-4553-99c8-d5e545a35fc2', 'lycanthrope ', '34dfa6b0-1cf6-41c7-b52a-425355481514', 'nonpermeation ', 'idolatrising ', 0, '10b98f11-b882-4a89-a938-68b911acc1c3'),
(4, 7, 'unterseness ', 'unions ', 'reciprocative ', 'swobber ', 'torrentially ', 'lighterman ', '2020-01-21 21:47:01', 'exorcist ', 'tippee classifying antigenes handoff outcried terutero prepurchasing tripped termly guerdon gonfanon sealet defectiveness reawaken mustelus friedcake padcluoth cofferdams spurrey kiowa improvision disrooted cud bluntishness ', 'compania ', 'electrophone ', '1226936c-32c4-4bd0-9486-a046833212a4', 'architeuthis ', 'chicot ', 'gristle ', 'laborsaving ', '40fddbc5-caa1-4852-9f86-330dcb16854d', 'untomb ', 'horridity ', 'gor ', 'nephritic ', 'electroshock ', 'ebbet ', 'subcomputation ', 'ce54659d-a1b3-45f7-bed3-e53acfcb35f6', 'susanna ', 'unrebated ', 1, 'squishy ', 'tecum ', '194141e1-c307-42de-a50b-6cedba95d563', 'faaebd99-229b-4de1-b8df-be8d020bd06d', 'caesura ', 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 'lycaenidae ', 'pretermitted ', 'insanities ', 'unanticipatedly ', 'rhizopodous ', 'variedness ', 'idealistically ', 'waterwort ', 'colonaded ', 'melodramaticism ', 'windfalls ', 'amberoids ', 'putanism ', 'probuilding ', '1b7c1149-7f4c-41ba-b909-57f5a5e5dd0a', 'bethorns ', 'proteopexis ', 'counterpoint ', 'statuted ', 'equivalency ', 'thallium ', 'nonpersecutive ', 'paradigms ', 907786031, 939685230, '2017-07-08 09:47:01', 'adffroze ', 'surbate ', 'bb6b4484-80aa-4069-9f81-73bb51128fe6', 'doubted ', 'nontraceableness ', 'frounceless ', '5fc5700a-9dca-498f-9d2b-34358ee3c5b6', 'trichoschisis ', '6b26a59d-74c6-40ad-996b-2a6e9dac2e94', 'endometrial ', 'fluidimeter ', 1, 'd2e29213-e7ec-4f5a-be80-c62bae8d538e'),
(5, 1, 'champagneless ', 'multiracial ', 'briards ', 'wreathen ', 'grosgrains ', 'anthemas ', '2020-01-20 06:47:01', 'snowk ', 'irreverend termen preengage hippuric pedestrial hawkwise underlines verdure hederin vale hystrix palimpsestic superacute sawbelly clamjamfery pretoria tantalizers materiable deoxyribose pennine typhoids gyniatries soppier ', 'multitube ', 'unspecific ', 'f3588dc7-89bc-44fb-b542-aab042c0d7e2', 'thesaurismosis ', 'bilaan ', 'bailouts ', 'overexuberance ', 'f31c49d2-f84a-4c91-8155-28d6c7f509b8', 'dikaryophyte ', 'sherardizer ', 'vairagi ', 'androgen ', 'zoon ', 'unrivaling ', 'machinule ', '37a788ce-92d1-4f25-af5c-a1b8e9f44a7e', 'sweetweed ', 'nonnationalistic ', 1, 'artocarpous ', 'ninetyknot ', '191ef559-4fdd-444b-8020-6bad8ffda172', 'd2ff52b5-a2ac-4c79-81c4-e647ce1b403a', 'upstretched ', 1, 0, 0, 0, 0, 1, 0, 1, 1, 1, 1, 'tiresomeness ', 'sepulchering ', 'toxophobia ', 'whopped ', 'tuborrhea ', 'synonymist ', 'perphenazine ', 'undelinquent ', 'bytime ', 'nonsusceptible ', 'haste ', 'sleuthing ', 'deleading ', 'volga ', '11366626-2a88-40e6-aae8-e30a6b0b9be1', 'engirdled ', 'nylast ', 'tulchin ', 'deuteroscopy ', 'vesiculectomy ', 'unwatery ', 'uromeric ', 'walkways ', 1592609486, 1776508540, '2020-07-08 13:47:01', 'expt ', 'misthinking ', 'a016b81c-a99c-4672-b30b-46a98d729984', 'unsegregatedness ', 'nonvillainously ', 'foliage ', 'a5f7f4a3-5a80-4286-97d5-02326af5f248', 'unmolestedly ', '10faa9d1-dbf5-47ce-982f-9b5e41a41cf4', 'recane ', 'rebasis ', 0, 'd0bbd46d-9cac-445a-833c-b5451ae1a834'),
(6, 5, 'photerythrous ', 'acholoe ', 'conformed ', 'alkyne ', 'topmen ', 'explanatoriness ', '2017-12-19 20:47:01', 'sidechairs ', 'irretrievability fatigability superlogical bogglers diatheses mausolea chuttie daisy plup antwise unneutrally unconcealedly malacodermidae localite configurationist myelapoplexy annist sops allotropize ayre noisemakers ', 'uppercutting ', 'vanilloyl ', '2b6b5701-e526-4680-bd33-e06f87b19f63', 'fustigate ', 'odontodynia ', 'adure ', 'legist ', '78f35bb3-2f09-40ab-b04b-0a08bc4d4d7a', 'tazza ', 'tetraplous ', 'mackled ', 'spiderwebbed ', 'extempore ', 'milkman ', 'priestshire ', '0f5a1ba8-85a9-463f-bac4-623a51c41d44', 'angioneoplasm ', 'stoppel ', 0, 'pediluvium ', 'ecdyses ', 'f50b9e28-7534-43a1-bd78-783dac4fd458', '191a1682-95fa-435e-9aaa-e6bedfc3e09c', 'distemonous ', 1, 1, 0, 0, 1, 0, 0, 1, 0, 1, 0, 'jackstraws ', 'bilbo ', 'kvasses ', 'meandrite ', 'underspecify ', 'conniptions ', 'unsentinelled ', 'headlands ', 'jumpmaster ', 'reinquiries ', 'communise ', 'jactant ', 'symphysis ', 'quadrinodal ', '84c18081-9c18-4da3-b8a1-73b35a3485bf', 'suppressiveness ', 'bulkheads ', 'determine ', 'anywhen ', 'lacrimator ', 'acetoveratrone ', 'phototypic ', 'superimposing ', 1525241549, 1165965336, '2021-10-17 07:47:01', 'psychotropic ', 'bereaver ', 'a2b2ff13-1593-4d3f-9cbd-13046a732699', 'psychotaxis ', 'flouts ', 'rubible ', '939c3cd3-44e9-4a40-a7de-2ba077067fac', 'expressional ', 'dc277dc6-9bbb-4978-8c61-aa1cf218f220', 'splanchnomegalia ', 'straticulate ', 1, '91c0acb3-7141-4531-ac36-8c4f2aae19cf'),
(7, 4, 'clavariaceae ', 'babished ', 'homologation ', 'valvelet ', 'extradecretal ', 'odinian ', '2021-12-25 19:47:01', 'taxodont ', 'transpenetrable thermotype dolley undelusory smoothies berascals automats accus plurennial caulotaxis boreens kashube covariable demibuckram tweets devilishly carnie shipboard flatus khutbah zones lithuria promotability ', 'stonemint ', 'squeegees ', '6cedb0cb-1edb-4d92-87fa-97b2c2d922ec', 'unintruding ', 'deoxygenize ', 'bewelcome ', 'uniserial ', '5f71d0ff-0ad7-4bc2-b0e4-ce186fb089cb', 'neighing ', 'unmeditatively ', 'statospore ', 'nonadeptly ', 'yack ', 'ambling ', 'airscapes ', 'bb732503-2038-43fe-b2cc-12b29e9924e1', 'coleen ', 'idioblastic ', 0, 'rewarming ', 'allergin ', '668759ca-14a3-4366-82e5-c7828bab09ed', '5295e2fe-f956-4f7e-b421-5e428bfdac18', 'nespelim ', 1, 1, 1, 1, 0, 0, 1, 0, 1, 0, 0, 'abreast ', 'yezdi ', 'outstealing ', 'wirrah ', 'oversupplying ', 'infuriated ', 'opisthodomos ', 'guayroto ', 'birchbark ', 'stippen ', 'dissymmetric ', 'unwoundableness ', 'skewwise ', 'expressionist ', '2f97e110-ad4d-4ee9-beae-0c0ac47db53c', 'noncommemorational ', 'diuresis ', 'mandates ', 'vaccinella ', 'nocturne ', 'nonnotification ', 'lecideiform ', 'splenectomized ', 598080894, 2021555012, '2022-04-27 14:47:01', 'outby ', 'ophthalmorrhexis ', 'c6547285-ff74-44a7-9ee0-4896d2f3d4d7', 'nephrostome ', 'palaeogeographic ', 'carcoon ', 'b2ce6629-f09e-4f04-a2b3-5e40dc7b45d3', 'sensile ', '8b279e48-7818-4bbd-a8c9-68452b9209de', 'savories ', 'ophthalmoleucoscope ', 0, 'e0184343-b3b8-410c-b6de-2ce0599960e5'),
(8, 3, 'dacryoblenorrhea ', 'curacaos ', 'communistery ', 'suicidist ', 'remarkability ', 'prothalamiumia ', '2021-02-11 19:47:01', 'pyrrhus ', 'hairlet abdiel vesicatories orthodox unfurnish winoes rhabdocoelida discomfort subclavia lanarkia divisions konia restitutionist unverdantly shared reemphasize outfast ultrademocratic defensorship undefilable beggarlice ', 'transcriptive ', 'sized ', '3483ea87-6790-4715-9397-1e21b2473503', 'inoperation ', 'pozzuolana ', 'suprasensuous ', 'progenital ', '3c3c562f-474a-43f7-a084-07938ffee609', 'coelestine ', 'glossary ', 'nondefiling ', 'unbridled ', 'unobligingly ', 'renomme ', 'unperspired ', '2de11c42-c13c-446d-a299-460bd0011825', 'reexpressed ', 'scowdering ', 0, 'acocantherin ', 'assecurator ', '0521df07-5267-450c-9200-21ea8ac6f924', '126a75dc-4a67-4e7b-b91a-6dedbf3870aa', 'thrombotic ', 0, 0, 1, 0, 0, 1, 1, 1, 0, 0, 1, 'rhamnohexite ', 'gneu ', 'styx ', 'danseuse ', 'blackwood ', 'discabinet ', 'cotta ', 'bailiffs ', 'cesarolite ', 'pathologist ', 'unnoisily ', 'nikethamide ', 'possemen ', 'cushionflower ', '13e16943-b363-467a-8b93-8939b52e4b3b', 'weighs ', 'irreparableness ', 'undwelt ', 'upstick ', 'flaunted ', 'signance ', 'happened ', 'catelectrotonic ', 232838876, 1163763189, '2015-07-22 19:47:01', 'promulgating ', 'creationistic ', 'f6da35ec-6e30-4816-8572-e5774385d00e', 'demodulation ', 'metrology ', 'snakier ', '9e9f8ee1-a68a-4212-8619-d2ee482b3bec', 'ghoulishly ', 'a238005d-ef28-458f-9704-982da54b2cab', 'contrariety ', 'oilmonger ', 1, '50e8aa0e-9272-4c2a-8353-bc5d4e37a233'),
(9, 9, 'maraud ', 'transformational ', 'unvoyaging ', 'breadnuts ', 'ciliiferous ', 'chloralism ', '2022-04-24 20:47:01', 'insular ', 'adscriptive handblow amphioxi panmelodion pillwort microsporous discoloredness reptility botas unacquit deterred nonsensual antiauxin dicarpellary glyconics anapsid portcullises dorado multum worldlings anglophile sporty ', 'dactyliomancy ', 'hypnobate ', 'b88bdc8e-9acc-4f41-bb7f-f945244447f7', 'palaeothentes ', 'impatible ', 'agrobiological ', 'unpersonal ', 'b33ab232-a8cb-4f00-a07c-9df3f2189d1a', 'melursus ', 'discursify ', 'eucharitidae ', 'paroch ', 'chevalier ', 'unemulous ', 'zionless ', '73fa7f13-0081-42a5-849d-9eaa21122005', 'hebrician ', 'unliveried ', 1, 'hove ', 'volvuli ', '827eb483-cc37-4957-9f3e-8195bbbba815', '8b063bfa-9087-433e-93c7-0eaa20a906f9', 'hayfork ', 1, 0, 1, 0, 1, 1, 0, 0, 0, 1, 1, 'salterns ', 'cephalohumeral ', 'boddhisattva ', 'redistend ', 'homophile ', 'vitiated ', 'cuspidor ', 'santal ', 'atrabiliarious ', 'hillsman ', 'carving ', 'deference ', 'angustifolious ', 'overlies ', '8b3c9ace-d38b-4c9d-a02c-8a65d09b3607', 'dunnesses ', 'enisled ', 'dyschroa ', 'tinggian ', 'basic ', 'protesting ', 'contaggia ', 'topesthesia ', 1024895791, 1051914954, '2022-01-24 12:47:01', 'oarless ', 'monospace ', '5153c134-fd1f-4aa7-b5bc-30c5e8524a2a', 'axiom ', 'praisworthiness ', 'uncunningly ', 'c3d33dd1-3990-4a53-b603-0e9d4fa58f6e', 'unjoyously ', 'd4fc1b20-09c0-4ee0-b37c-88b03039f38a', 'precostal ', 'thalassographical ', 0, '81d13fe6-dabb-418f-a22a-bd8210252281'),
(10, 10, 'unwieldly ', 'sentences ', 'unshamably ', 'nanosec ', 'nectarean ', 'hyperaltruistic ', '2022-03-27 03:47:01', 'tartarizing ', 'grossart disembogue wanner unsizeable shoecraft mordacity cephalograph inextensible bitumed visuals legginged unhonored catalase eosine eably hemispherically unexpansible amulla tenantship triodontoidei snapout telencephala ', 'laical ', 'cellarers ', 'e75c841f-6613-43df-8277-fd182c49e079', 'obsoletism ', 'reinvigorates ', 'goldie ', 'streamling ', 'a1e870d0-01fd-4f9a-9931-0412841853b3', 'tolerances ', 'ungainable ', 'unsincerely ', 'pteric ', 'comitiva ', 'bringsel ', 'sulfocarbamide ', '570a9c35-1c01-43e3-87eb-13c93fe4da5a', 'befile ', 'predecay ', 1, 'sieve ', 'bellybuttons ', '5ec54011-bb28-40bb-a54c-2fd9ef62b44f', '1e7f318d-ec2e-4ecf-aa89-33aa84c7a8d5', 'parietales ', 0, 1, 0, 1, 1, 1, 1, 0, 1, 1, 0, 'axillar ', 'calcedony ', 'acanthon ', 'crowtoe ', 'syndactylus ', 'nontransitively ', 'inwork ', 'fouler ', 'dispiteousness ', 'scalawag ', 'peroral ', 'annotinous ', 'hegaris ', 'hasp ', '9617bdda-d0e7-44a0-9dc4-688ec15a3581', 'lovemate ', 'redelivery ', 'eucalyn ', 'curaris ', 'maharanees ', 'pinocytotically ', 'repermit ', 'intertransversary ', 11597315, 917823532, '2015-02-12 17:47:01', 'overbravely ', 'ungarrulously ', '6fae6adf-3f08-44ed-afa2-124e63a4050a', 'dunderpate ', 'esotropic ', 'pipsqueak ', '8e3b0879-f3e2-4ff2-8a5d-e57aab9fe252', 'unwelcomely ', '906b9369-09e1-45ef-a45f-18ec0150cd2d', 'carucage ', 'malaccident ', 1, 'c299f2fa-1fe9-4d1b-8568-2ad3b0df75e0');

-- --------------------------------------------------------

--
-- Tabellstruktur `product`
--

CREATE TABLE `product` (
  `ProductId` int(11) NOT NULL,
  `productTypeId` int(11) NOT NULL COMMENT 'relation',
  `CompanyId` int(11) NOT NULL COMMENT 'relation',
  `ManagerId` varchar(36) NOT NULL COMMENT 'guid',
  `AdministratorId` varchar(36) NOT NULL COMMENT 'guid',
  `Product_Interval` int(11) NOT NULL,
  `AdjustedId` varchar(36) NOT NULL COMMENT 'guid',
  `Product_Comment` varchar(50) NOT NULL,
  `Product_Country` varchar(36) NOT NULL COMMENT 'guid',
  `Currency` varchar(50) NOT NULL,
  `Product_Type` varchar(50) NOT NULL,
  `Product_DescriptionString` text NOT NULL,
  `Product_EndDate` datetime NOT NULL,
  `Product_ExternalReference` varchar(50) NOT NULL,
  `Product_Price` decimal(10,2) NOT NULL,
  `Product_Interests` varchar(50) NOT NULL,
  `Product_Category` varchar(50) NOT NULL,
  `Product_CommissionPrice` decimal(10,2) NOT NULL,
  `Product_SupplierId` varchar(36) NOT NULL COMMENT 'guid',
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
  `ResellerId` varchar(36) NOT NULL COMMENT 'guid',
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
  `ProductType` varchar(36) NOT NULL COMMENT 'guid'
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumpning av Data i tabell `product`
--

INSERT INTO `product` (`ProductId`, `productTypeId`, `CompanyId`, `ManagerId`, `AdministratorId`, `Product_Interval`, `AdjustedId`, `Product_Comment`, `Product_Country`, `Currency`, `Product_Type`, `Product_DescriptionString`, `Product_EndDate`, `Product_ExternalReference`, `Product_Price`, `Product_Interests`, `Product_Category`, `Product_CommissionPrice`, `Product_SupplierId`, `Product_Rating`, `Product_Key`, `Product_Max`, `Product_Name`, `Product_Price2`, `Product_Parameters`, `Product_NoticeLevel`, `Product_Premium`, `Product_Product`, `Product_Version`, `Product_Level`, `Product_ApprovedDate`, `ResellerId`, `Product_Retention`, `Product_Rule1`, `Product_Rule2`, `Product_Rule3`, `Product_Method`, `Product_StartDate`, `Product_Status`, `Product_StatusString`, `Product_PhoneNo`, `Product_URL`, `ProductType`) VALUES
(1, 6, 5, 'f07f1532-5007-4077-b905-fdd21073a949', '40c0c25f-61b0-4dab-b171-5b7a417beb04', 250188453, '5c9905ef-92ec-419e-9f58-16c69fbdd25e', 'saddleleaf ', '174fbde2-507a-4e7c-85d6-edbb60e82a87', 'strewment ', 'negotiation ', 'bogus malaclemys academicians traumas unhealthsome jactation exciseman potoroo centares tokoloshe photomontage cartographic dialogistic hyphenising huntley nonobjectivity guitarfishes cheekful forbruise rescript concinnating ', '2017-07-25 13:47:02', 'unitistic ', '6.36', 'unguentous ', 'quinarii ', '7.12', '4007697a-71dd-4481-9765-525e1fbc06ec', '6.70', 'cinemograph ', 'stomatitis ', 'graverobber ', '3.19', 'polyposis ', 136092500, 'squinters ', 'weightlessness ', 'sudations ', '6.27', '2015-07-18 17:47:02', 'd9b52b57-7458-452a-8c57-c19fcf2c5d75', '9.21', '8.15', '4.65', '0.14', 'semiclinical ', '2019-01-13 02:47:02', 803804511, 'suretyship ', 'tubercularized ', 'biniodide ', '3ea25730-5443-45e7-83d5-18f101d5723b'),
(2, 2, 5, '073c7ba4-ddc4-4df6-80ac-a52a0873e160', '99a699b5-8d06-4a3f-ba45-504b502c9fe0', 1037221683, '8a5a7eb7-169b-4e2c-9f4f-977b857b8194', 'vanfoss ', '82a6945f-995d-431c-817a-fa3aabfa5742', 'irritations ', 'lippiest ', 'decylic blushers polypragmatist breviger unpolitically working nitrosulphuric syntonise suddy scholarity declinedness biland krisuvigite escobilla leaf disaggregation cardiectomy amphodelite tyauve dorsoventrality naphthoic ', '2022-10-10 17:47:02', 'cabbalahs ', '5.79', 'antigonus ', 'abalienated ', '0.55', '4bf41792-966c-48c7-891e-c2d314294b37', '7.95', 'chickaree ', 'dereism ', 'sledging ', '8.62', 'fraudulently ', 405435037, 'laminar ', 'pleatless ', 'nonphotographical ', '2.79', '2023-02-02 23:47:02', '47191d87-06c1-410d-a6da-a2625f94bb13', '4.41', '8.36', '5.95', '9.40', 'unadmire ', '2018-02-22 09:47:02', 521546989, 'gradient ', 'chiarooscuro ', 'cheesewood ', 'c0e60e9f-d23e-4383-a588-6bebdd41b681'),
(3, 3, 2, 'b267928b-3e6c-497f-9ae1-a52c41d37485', '40141574-d08e-40d9-b05a-2276c4e71f59', 1811330588, 'ca8d031c-0059-452d-ada6-5fb00f5d8d62', 'nonopinionaness ', '53c5400a-0c56-431a-8a51-6c11f218a5b1', 'shibar ', 'extracerebral ', 'unpersecuted elevon rebind actinomycesous dupability nonconversance unhonorable euchlorite ophiophagus haussmannization fiscal cassabanana pendicle enrolment stylohyoideus molossine tortricoidea cristate novobiocin telphers ', '2015-03-01 06:47:02', 'salinella ', '8.10', 'fuye ', 'magnates ', '5.09', '2b51db02-4149-4f19-b9c5-f58eeab16926', '8.34', 'cicerones ', 'nonpedigree ', 'planera ', '5.90', 'multicordate ', 321047095, 'rooflet ', 'monadism ', 'unserved ', '1.83', '2014-12-13 18:47:02', '59573f7c-7709-4c38-8eea-983092025e51', '0.05', '8.28', '6.30', '7.56', 'dawting ', '2017-07-14 17:47:02', 284535851, 'palet ', 'revolatilize ', 'nondeprecatory ', '638bca24-a7b4-4611-a63f-5d09ea4f2b38'),
(4, 4, 1, 'cb31fbfc-4930-4539-bc19-201c42b0da85', '4ce9305a-58a1-4653-8cf1-7b6fb526a153', 686083604, 'fdec7800-9615-46ad-b572-545c8a221954', 'speeled ', 'df64ceb8-9f3b-4b34-a6c6-cba1a898f607', 'conchate ', 'swithe ', 'zooscopy chordata cystitides bonita designator dioeciodimorphous rarefying dab indeterminableness kalathoi goldbird dominant phaenogenetic prepromising smuggleable stercorist sphenodontia anoplura micromazia belord overissuing ', '2020-08-12 06:47:02', 'blottier ', '3.08', 'tenebrificate ', 'allegiancy ', '7.42', 'acf313fc-4cf4-464f-bcfd-302769f100ec', '5.68', 'crabhole ', 'convince ', 'psize ', '8.00', 'leniencies ', 1920761766, 'unsubstantialization ', 'unmellow ', 'lampyrid ', '5.69', '2020-05-25 10:47:02', '9d52e2f7-bee8-4cfc-98b4-77bc73368693', '0.13', '5.35', '1.64', '2.66', 'superficialism ', '2021-06-19 07:47:02', 639528892, 'photoepinastically ', 'stockmaking ', 'subcrenate ', '97b6da68-3f06-4fee-bbc5-0993ddca1490'),
(5, 8, 10, '71343606-6850-43df-8a00-f2990e9a7357', '4076d6ec-2f21-42f1-99e6-afe37c82e10a', 932277563, 'df60fa48-fe61-4049-bb64-ee3bed1649b5', 'justle ', '992376a4-e8f2-4227-b95e-881d819a3525', 'urucury ', 'brachytmema ', 'gigantically octarchy violaceously unfruitful unwinnowed uncounselable eyestalks unprovidential turus espressos housecraft pulpers contacting cuidado thermoduric formalizations prosubscription chopped placent planeness ', '2021-03-26 22:47:02', 'toluifera ', '6.28', 'thermodynam ', 'supercongestion ', '0.80', '24145186-a956-491b-af38-907acecef2e9', '9.84', 'overexpressively ', 'reifier ', 'caulophylline ', '4.26', 'margaux ', 414246756, 'pubiotomy ', 'coccyx ', 'nonhunting ', '9.19', '2018-04-18 16:47:02', '8fe27e6c-942c-4671-ae9f-0100ab0c9006', '9.54', '8.78', '7.06', '2.93', 'transhape ', '2017-07-06 03:47:02', 1722535610, 'gateado ', 'suburbans ', 'restrictedness ', 'e8f0c606-695b-449a-b09b-7f41e8737bc7'),
(6, 5, 6, '14b10031-d23b-491c-acb7-0837110f2680', 'f45002a4-5a20-46a2-a695-16b69db4b30a', 1368839647, 'c994274e-d544-4c70-956a-5d234f47ca75', 'linguopalatal ', '5e5755b7-34ff-45b0-b8bf-4b12d4e02333', 'hydrant ', 'gemotes ', 'reinserted moralioralist reexporter upshot quaigh gubernaculum hyperbarically depreciator puccinia unemphatical pial cooja majidieh serjania digestive covariate runouts azoxyphenetole scordature overobeseness preobtrudingpreobtrusion ', '2019-01-14 00:47:02', 'structuralism ', '3.33', 'revaluation ', 'cyclogram ', '4.78', '261f16dd-0745-4316-8a77-a7332d7ef410', '0.64', 'palings ', 'firehouse ', 'pluralism ', '0.40', 'peever ', 1026155030, 'prepunish ', 'pantagrueline ', 'biters ', '5.87', '2022-08-21 07:47:02', 'c17fb230-e4fa-4cbf-baa9-59b28f8ac394', '8.96', '2.60', '4.66', '3.71', 'dualize ', '2020-08-13 04:47:02', 2058174657, 'sandies ', 'dactyli ', 'magazinish ', '9efe794e-bfc5-4fa2-9ec9-2868df0488f3'),
(7, 7, 8, '6d22486a-d9a3-451b-b55f-07461388ee29', '455ad187-23da-4046-b260-e296f0ca982b', 1131006601, '60084531-426c-4d45-aac9-849ed678e117', 'coparent ', 'faf2c981-4bbe-4fde-9684-f5bf828bd260', 'unsynchronized ', 'dyaster ', 'azons pegmatitic omnitonality spug slottery pewy schmoozes haganah condylomatous immanentistic paleozoological fried rebaits extremistic perishing thiazine methodistically fusty nostochine resoil becharming sanitarium ', '2022-02-22 23:47:02', 'encyclical ', '0.37', 'tenuirostral ', 'bufonite ', '0.72', 'f3e38a0b-6b86-47ca-ab8a-ef8f9fd4c87b', '2.44', 'bawty ', 'outrances ', 'entrancer ', '4.43', 'rutch ', 2009692831, 'proveditore ', 'unreconstructible ', 'manganetic ', '7.34', '2014-05-29 03:47:02', 'c4bc3e94-6da9-4817-be79-0aafc23de924', '2.63', '3.00', '6.57', '0.31', 'bathinette ', '2014-02-13 07:47:02', 814313716, 'jocote ', 'thriftlessness ', 'overextend ', '01590f66-f190-4b6e-9cf9-2a855eeac50e'),
(8, 3, 6, 'e52b707d-f167-4b4b-a96f-2db3182a20e7', '88437cf5-2981-4ddd-87cc-15fdb62136ed', 1139631228, '10aeff23-f001-4ca8-abbb-e48a7eedd7b1', 'enventual ', '265f6f44-d602-414e-95a8-50bc1519477e', 'sweetless ', 'unexultant ', 'unprudence balneae mechanomorphism outstudies agoramania unnationalistically aliet unapparentness forthtell hematoblast sellar ruble foreslack homomerous supersmartly heteroousiast intercondylic physicophilosophy flatboats ', '2022-09-08 03:47:02', 'zenithal ', '8.61', 'pythonic ', 'pseudoovally ', '1.32', '78aa5b39-65e9-4675-acc5-533b9dfd3e30', '6.56', 'materialized ', 'peewee ', 'prognostical ', '7.08', 'cinnamon ', 304677861, 'discussible ', 'desideratum ', 'stenochoria ', '3.90', '2023-01-30 20:47:02', '19808ea9-9532-4fe1-9cd8-c5482f8b1938', '1.18', '8.77', '3.56', '7.18', 'reblooming ', '2017-03-17 02:47:02', 1506843736, 'duntle ', 'concourse ', 'sickish ', '91bd2d28-2957-4145-aafd-4dc060c14ce1'),
(9, 1, 8, '0899fee5-153b-4ba3-b8c6-41be5c595a35', '559f9599-cd6a-4436-b388-9fb8faaeb5be', 1464203904, '28546c22-1b04-44c7-96a5-6c9722306de0', 'homoerotism ', '18469d89-aca3-47ac-8231-d48050636dec', 'ob ', 'anecdotalism ', 'camellin ferromagneticism bosques hierocracy strangleable brainwave goodish lorarii shiftability uniovular synched bipods quasiorder secundiflorous cousins layerage withbeg sating quizzed potometer betso subpharyngeally ', '2017-08-14 05:47:02', 'silviculturally ', '4.72', 'caffiaceous ', 'aecial ', '7.47', 'c101d9e2-74c4-4ef3-9cf2-2ea5224de7fb', '5.88', 'lation ', 'jarfuls ', 'overfamiliarity ', '7.10', 'isocorydine ', 42748974, 'thaumatologies ', 'buick ', 'popelike ', '9.44', '2020-12-08 05:47:02', '0d73e054-c4b6-40cb-82e5-e4291c232dad', '2.50', '1.53', '8.43', '9.59', 'doggone ', '2021-04-19 03:47:02', 1166056166, 'beround ', 'fountains ', 'unprimitiveness ', 'c5125f16-a420-4da6-920c-d6134118a09d'),
(10, 1, 6, 'cae0f8e2-5cc9-427d-86bc-b763f4f8255a', '18531cc6-d09e-4fb1-96a8-075df36981a5', 2132830460, '3ab853fd-008f-4a31-90d9-555c8d7c7b56', 'undazzling ', '4c2e5758-100b-4c50-9cc9-3a48f59f2899', 'vigilantes ', 'fundholder ', 'mononitrate basset tonnishly hydrobiology extraviolet lycosa anatira luteofuscous factorist pirojki hyperparathyroidism duftite survived decahedron unrelievable extrusile oxeate accused nonconsecutiveness sportswoman ', '2022-09-06 03:47:02', 'rifer ', '8.59', 'ensculpture ', 'tomcats ', '0.89', '0e7b7652-d682-44fb-9949-693bb14b4578', '8.69', 'benzophenoxazine ', 'snivelers ', 'ophiomorphic ', '3.26', 'precite ', 469509644, 'troezenian ', 'unelicitable ', 'nonprosperously ', '2.12', '2019-11-24 11:47:02', '33ab01b3-93e9-4968-bf50-af92e45d4a4c', '0.41', '2.84', '2.40', '9.02', 'linguloid ', '2020-01-04 15:47:02', 1021596925, 'weka ', 'photoelasticity ', 'cheremissian ', 'd86e7143-ddbb-4efa-a493-fd88530b243f');

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
-- Dumpning av Data i tabell `producttype`
--

INSERT INTO `producttype` (`ProductTypeId`, `ProductType_DescriptionString`, `ProductType_KeySellingPoint`, `ProductType_Label`, `ProductType_Name`, `ProductType_Status`) VALUES
(1, 'sibyl calyptranthes amidrazone milken nannyberry jugged noncrystalline phonemes palikar nondisastrously sermonoid clubfist hobblebush miniatures impanels prescriptibility paintless subsiders purposing terminer antiabortion ', 'indoctrinator ', 'martyrizer ', 'staffelite ', 246017455),
(2, 'finnicize conciseness rehone banefulness razeeing polymastia totanus trillionize misorganizing snudge stulm manutagi astrand ahorse untrustworthy inhauler trainshed fumeroot converginerved christcross bedizening ichneumoned ', 'preprimary ', 'nobleheartedness ', 'militates ', 115472265),
(3, 'trichopteran thoracoscopy sympossia indispose durndest symposisia nonsulfurous hardcore mujeres actinoidea tranquilized overgot unmaidenlike pyramoid guestimate outlaugh cothurnate unjewel icicles undrunkenness prohibitorily ', 'tympanosquamosal ', 'parallaxes ', 'perturbate ', 307343886),
(4, 'staggart dispose acetolysis palaeoethnological incorr supplanted scrob antagonism hyperbolizing herewithal hypermysticalness reimburses habituality brandies provection cornelius eutaxies numerating gypseous decongest ', 'chrysophyllum ', 'staphylematoma ', 'nonpunitory ', 96041925),
(5, 'dentinoblast proceritic castling hardiest enfortune chine denom varisse goodlihead brahmachari exocardia intertidal misericordia heterostructure aquintocubitalism wartiest protophyll corresponded overlayer chivareing ', 'antlike ', 'banana ', 'sulfoborite ', 1630391792),
(6, 'specificness fierily iliac pastry isogamies ariole hematolite uptrain monoprogramming overreacted unpermixed iliahi dysoxidize gooseflower antitax ouricury churchmanship ricinine dermoreaction preconizing phoh sugarhouse ', 'crustacea ', 'intertwisting ', 'semicollapsible ', 1176307720),
(7, 'pictorialising leapt daybooks pinedrops indivisibleness unmusing worried bord squaws talmudists lysis outlaughing cryptozygy andean expectance shorefish supercrescent kytoon fartlek outtalked beakless thundercloud misdirection ', 'siphonless ', 'unsuppressive ', 'unstripped ', 261607211),
(8, 'elne alexipyretic tessellation roistering decorousness grammatology episcotister genetical recharging induceable reaves uncreatability latexosis ampitheater rebuffs lancetfishes tarrock gades storytellers phtalic nonomission ', 'limnoriidae ', 'inscrutables ', 'laicize ', 1180098892),
(9, 'stomachachy intrans monodactyle disillusioniser ramiflorous tuberculosectorial patriarchal eyrant mollienisia unquarrelsome stupeous foresays sobby thoracicohumeral cephalospinal lamplit corduroy piliganin corticin sained ', 'capouches ', 'iridoparalysis ', 'crawley ', 405422126),
(10, 'frenghi unimpeachable doctrinalism criminol resatisfy nardoo durenol disembitter osmosing viduous resiniform proxenete pialyn folly schiller stambouline ariosos gremlin excurvature carnivores wanigans possessively isopropylamine ', 'nephalist ', 'subconformably ', 'predisappointment ', 583109392);

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
  ADD PRIMARY KEY (`DepartmentId`);

--
-- Index för tabell `person`
--
ALTER TABLE `person`
  ADD PRIMARY KEY (`PersonId`);

--
-- Index för tabell `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`ProductId`);

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
  MODIFY `CompanyId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT för tabell `department`
--
ALTER TABLE `department`
  MODIFY `DepartmentId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT för tabell `person`
--
ALTER TABLE `person`
  MODIFY `PersonId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT för tabell `product`
--
ALTER TABLE `product`
  MODIFY `ProductId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT för tabell `producttype`
--
ALTER TABLE `producttype`
  MODIFY `ProductTypeId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
