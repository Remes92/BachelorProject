using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BachelorProjectBackend.Models;


namespace BachelorDegreeProject.Types
{
    public class PersonObjType : ObjectGraphType<Person>
    {
        public PersonObjType()
        {
            Name = Person.person;
            Field(x => x.PersonId, type: typeof(IdGraphType));
            Field(x => x.EmployeeId, type: typeof(IntGraphType));
            Field(x => x.Person_Address1, type: typeof(StringGraphType));
            Field(x => x.Person_Address2, type: typeof(StringGraphType));
            Field(x => x.Person_Address3, type: typeof(StringGraphType));
            Field(x => x.Person_Address4, type: typeof(StringGraphType));
            Field(x => x.Person_Address5, type: typeof(StringGraphType));
            Field(x => x.Person_Name, type: typeof(StringGraphType));
            Field(x => x.Person_BirthDate, type: typeof(DateTimeGraphType));
            Field(x => x.Person_Class, type: typeof(StringGraphType));
            Field(x => x.Person_Description, type: typeof(StringGraphType));
            Field(x => x.Person_Gender, type: typeof(StringGraphType));
            Field(x => x.Person_LastName, type: typeof(StringGraphType));
            Field(x => x.Person_CountryId, type: typeof(StringGraphType));
            Field(x => x.Person_FullName, type: typeof(StringGraphType));
            Field(x => x.Person_Phone, type: typeof(StringGraphType));
            Field(x => x.Person_FavoritePizza, type: typeof(StringGraphType));
            Field(x => x.Person_CustomFields, type: typeof(StringGraphType));
            Field(x => x.DefaultCompanyId, type: typeof(StringGraphType));
            Field(x => x.Person_FavoritePasta, type: typeof(StringGraphType));
            Field(x => x.Person_Division, type: typeof(StringGraphType));
            Field(x => x.Person_Email, type: typeof(StringGraphType));
            Field(x => x.Person_Rating, type: typeof(StringGraphType));
            Field(x => x.Person_Reference, type: typeof(StringGraphType));
            Field(x => x.Person_FaxNumber, type: typeof(StringGraphType));
            Field(x => x.Person_FirstName2, type: typeof(StringGraphType));
            Field(x => x.Person_StoneBricksID, type: typeof(StringGraphType));
            Field(x => x.Person_Group, type: typeof(StringGraphType));
            Field(x => x.Person_GroupCode, type: typeof(StringGraphType));
            Field(x => x.Person_HasData, type: typeof(BooleanGraphType));
            Field(x => x.Person_String, type: typeof(StringGraphType));
            Field(x => x.Person_FavoriteInstrument, type: typeof(StringGraphType));
            Field(x => x.MyAccountId1, type: typeof(StringGraphType));
            Field(x => x.MyAccountId2, type: typeof(StringGraphType));
            Field(x => x.Person_InternalCode, type: typeof(StringGraphType));
            Field(x => x.Person_HasParty, type: typeof(BooleanGraphType));
            Field(x => x.Person_IsCompany, type: typeof(BooleanGraphType));
            Field(x => x.Person_IsPhilosopher, type: typeof(BooleanGraphType));
            Field(x => x.Person_HasCompany, type: typeof(BooleanGraphType));
            Field(x => x.Person_IsSupplier, type: typeof(BooleanGraphType));
            Field(x => x.Person_HasIssues, type: typeof(BooleanGraphType));
            Field(x => x.Person_isPerson, type: typeof(BooleanGraphType));
            Field(x => x.Person_IsNaturalPerson, type: typeof(BooleanGraphType));
            Field(x => x.Person_IsProfessional, type: typeof(BooleanGraphType));
            Field(x => x.Person_IsReseller, type: typeof(BooleanGraphType));
            Field(x => x.Person_IsTaxPayer, type: typeof(BooleanGraphType));
            Field(x => x.Person_LastName2, type: typeof(StringGraphType));
            Field(x => x.Person_LEIA, type: typeof(StringGraphType));
            Field(x => x.Person_FavoriteMOvie, type: typeof(StringGraphType));
            Field(x => x.Person_MiddleNames, type: typeof(StringGraphType));
            Field(x => x.Person_Migration, type: typeof(StringGraphType));
            Field(x => x.Person_LaundryRisk, type: typeof(StringGraphType));
            Field(x => x.Person_PassportNumber, type: typeof(StringGraphType));
            Field(x => x.Person_PersonalNumber, type: typeof(StringGraphType));
            Field(x => x.Person_PhoneHome, type: typeof(StringGraphType));
            Field(x => x.Person_PhoneMobile, type: typeof(StringGraphType));
            Field(x => x.Person_PhoneWork, type: typeof(StringGraphType));
            Field(x => x.Person_PostageAddressAttention, type: typeof(StringGraphType));
            Field(x => x.Person_PostageAddressCity, type: typeof(StringGraphType));
            Field(x => x.Person_PostageAddressCO, type: typeof(StringGraphType));
            Field(x => x.PostageAddressCountryId, type: typeof(StringGraphType));
            Field(x => x.Person_PostageAddressDepartment, type: typeof(StringGraphType));
            Field(x => x.Person_PostageAddressStreet, type: typeof(StringGraphType));
            Field(x => x.Person_PostageAddressZip, type: typeof(StringGraphType));
            Field(x => x.Person_BrokerNode, type: typeof(StringGraphType));
            Field(x => x.Person_Opinions, type: typeof(StringGraphType));
            Field(x => x.Person_MovieComment, type: typeof(StringGraphType));
            Field(x => x.Person_CreditCardCode, type: typeof(StringGraphType));
            Field(x => x.Person_FavoriteDrink, type: typeof(StringGraphType));
            Field(x => x.Person_PepsiStatus, type: typeof(StringGraphType));
            Field(x => x.Person_PrintStatus, type: typeof(StringGraphType));
            Field(x => x.Person_PrintStatusTimeStamp, type: typeof(BooleanGraphType));
            Field(x => x.Person_PrintStatusTimeStampString, type: typeof(StringGraphType));
            Field(x => x.Person_RatingAgency, type: typeof(StringGraphType));
            Field(x => x.ResellerId, type: typeof(StringGraphType));
            Field(x => x.Person_Section, type: typeof(StringGraphType));
            Field(x => x.Person_Sector, type: typeof(StringGraphType));
            Field(x => x.Person_Signing, type: typeof(StringGraphType));
            Field(x => x.Person_Taxi, type: typeof(StringGraphType));
            Field(x => x.Person_KnowledgeLevel, type: typeof(StringGraphType));
            Field(x => x.Country2, type: typeof(StringGraphType));
            Field(x => x.Person_Id2, type: typeof(StringGraphType));
            Field(x => x.Person_IdType, type: typeof(StringGraphType));
            Field(x => x.Person_ManualHandling, type: typeof(BooleanGraphType));
            Field(x => x.InstanceId, type: typeof(StringGraphType));
        }
    }
}
