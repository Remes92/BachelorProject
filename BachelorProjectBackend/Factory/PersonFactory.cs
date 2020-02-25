using System;
using BachelorProjectBackend.Models;
using MySql.Data.MySqlClient;

/// <summary>
/// Produces Persons 
/// </summary>
public static class PersonFactory
{
	public static Person Create(MySqlDataReader rdr)
    {
        rdr.Read();

        Person p = new Person()
        {
            PersonId = (int)rdr[0],
            EmployeeId = (int)rdr[1],
            Person_Address1 = rdr[2].ToString(),
            Person_Address2 = rdr[3].ToString(),
            Person_Address3 = rdr[4].ToString(),
            Person_Address4 = rdr[5].ToString(),
            Person_Address5 = rdr[6].ToString(),
            Person_Name = rdr[7].ToString(),
            Person_BirthDate = (DateTime)rdr[8],
            Person_Class = rdr[9].ToString(),
            Person_Description = rdr[10].ToString(),
            Person_Gender = rdr[11].ToString(),
            Person_LastName = rdr[12].ToString(),
            Person_CountryId = rdr[13].ToString(),
            Person_FullName = rdr[14].ToString(),
            Person_Phone = rdr[15].ToString(),
            Person_FavoritePizza = rdr[16].ToString(),
            Person_CustomFields = rdr[17].ToString(),
            DefaultCompanyId = rdr[18].ToString(),
            Person_FavoritePasta = rdr[19].ToString(),
            Person_Division = rdr[20].ToString(),
            Person_Email = rdr[21].ToString(),
            Person_Rating = rdr[22].ToString(),
            Person_Reference = rdr[23].ToString(),
            Person_FirstName2 = rdr[24].ToString(),
            Person_FaxNumber = rdr[25].ToString(),
            Person_StoneBricksID = rdr[26].ToString(),
            Person_Group = rdr[27].ToString(),
            Person_GroupCode = rdr[28].ToString(),
            Person_HasData = (Boolean)rdr[29],
            Person_String = rdr[30].ToString(),
            Person_FavoriteInstrument = rdr[31].ToString(),
            myAccountId1 = rdr[32].ToString(),
            myAccountId2 = rdr[33].ToString(),
            Person_InternalCode = rdr[34].ToString(),
            Person_HasParty = (Boolean)rdr[35],
            Person_IsCompany = (Boolean)rdr[36],
            Person_IsPhilosopher = (Boolean)rdr[37],
            Person_HasCompany = (Boolean)rdr[38],
            Person_IsSupplier = (Boolean)rdr[39],
            Person_HasIssues = (Boolean)rdr[40],
            Person_isPerson = (Boolean)rdr[41],
            Person_IsNaturalPerson = (Boolean)rdr[42],
            Person_IsProfessional = (Boolean)rdr[43],
            Person_IsReseller = (Boolean)rdr[44],
            Person_IsTaxPayer = (Boolean)rdr[45],
            Person_LastName2 = rdr[46].ToString(),
            Person_LEIA = rdr[47].ToString(),
            Person_FavoriteMOvie = rdr[48].ToString(),
            Person_MiddleNames = rdr[49].ToString(),
            Person_Migration = rdr[50].ToString(),
            Person_LaundryRisk = rdr[51].ToString(),
            Person_PassportNumber = rdr[52].ToString(),
            Person_PersonalNumber = rdr[53].ToString(),
            Person_PhoneHome = rdr[54].ToString(),
            Person_PhoneMobile = rdr[55].ToString(),
            Person_PhoneWork = rdr[56].ToString(),
            Person_PostageAddressAttention = rdr[57].ToString(),
            Person_PostageAddressCity = rdr[58].ToString(),
            Person_PostageAddressCO = rdr[59].ToString(),
            PostageAddressCountryId = rdr[60].ToString(),
            Person_PostageAddressDepartment = rdr[61].ToString(),
            Person_PostageAddressStreet = rdr[62].ToString(),
            Person_PostageAddressZip = rdr[63].ToString(),
            Person_BrokerNode = rdr[64].ToString(),
            Person_Opinions = rdr[65].ToString(),
            Person_MovieComment = rdr[66].ToString(),
            Person_CreditCardCode = rdr[67].ToString(),
            Person_FavoriteDrink = rdr[68].ToString(),
            Person_PepsiStatus = (int)rdr[69],
            Person_PrintStatus = (int)rdr[70],
            Person_PrintStatusTimeStamp = (DateTime)rdr[71],
            Person_PrintStatusTimeStampString = rdr[72].ToString(),
            Person_RatingAgency = rdr[73].ToString(),
            ResellerId = rdr[74].ToString(),
            Person_Section = rdr[75].ToString(),
            Person_Sector = rdr[76].ToString(),
            Person_Signing = rdr[77].ToString(),
            Person_Taxi = rdr[78].ToString(),
            Person_KnowledgeLevel = rdr[79].ToString(),
            Country2 = rdr[80].ToString(),
            Person_Id2 = rdr[81].ToString(),
            Person_IdType = rdr[82].ToString(),
            Person_ManualHandling = (Boolean)rdr[83],
            InstanceId = rdr[84].ToString()
        };
        return p; 
    }

    public static Person Create()
    {
        Person p = new Person();
        //TODO get some data in and creat person using that data.
        return p;
    }
}
