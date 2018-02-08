using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Esha.Genesis.Services.Client
{
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(Namespace = "http://ns.esha.com/2013/genesisapi", ConfigurationName = "Esha.Genesis.Services.Client.IFoodQueryService")]
    public interface IFoodQueryService
    {
        // CODEGEN: Generating message contract since the operation GetAnalysis is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getanalysis", ReplyAction = "http://ns.esha.com/2013/genesisapi/getanalysisresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        FoodAnalysisResponse1 GetAnalysis(FoodAnalysisRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getanalysis", ReplyAction = "http://ns.esha.com/2013/genesisapi/getanalysisresponse")]
        Task<FoodAnalysisResponse1> GetAnalysisAsync(FoodAnalysisRequest1 request);

        // CODEGEN: Generating message contract since the operation GetConversions is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getconversions",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getconversionsresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        FoodConversionsResponse1 GetConversions(FoodMetadataRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getconversions",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getconversionsresponse")]
        Task<FoodConversionsResponse1> GetConversionsAsync(FoodMetadataRequest1 request);

        // CODEGEN: Generating message contract since the operation GetFood is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getfood", ReplyAction = "http://ns.esha.com/2013/genesisapi/getfoodresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        FoodMetadataResponse1 GetFood(FoodMetadataRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getfood", ReplyAction = "http://ns.esha.com/2013/genesisapi/getfoodresponse")]
        Task<FoodMetadataResponse1> GetFoodAsync(FoodMetadataRequest1 request);

        // CODEGEN: Generating message contract since the operation GetFoodByFoodId is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getfoodbyfoodid", ReplyAction = "http://ns.esha.com/2013/genesisapi/getfoodbyfoodidresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        FoodMetadataResponse1 GetFoodByFoodId(GetFoodByFoodIdRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getfoodbyfoodid", ReplyAction = "http://ns.esha.com/2013/genesisapi/getfoodbyfoodidresponse")]
        Task<FoodMetadataResponse1> GetFoodByFoodIdAsync(GetFoodByFoodIdRequest1 request);

        // CODEGEN: Generating message contract since the operation GetFoodByUserCode is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getfoodbyusercode", ReplyAction = "http://ns.esha.com/2013/genesisapi/getfoodbyusercoderesponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        FoodMetadataResponse1 GetFoodByUserCode(GetFoodByUserCodeRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getfoodbyusercode", ReplyAction = "http://ns.esha.com/2013/genesisapi/getfoodbyusercoderesponse")]
        Task<FoodMetadataResponse1> GetFoodByUserCodeAsync(GetFoodByUserCodeRequest1 request);

        // CODEGEN: Generating message contract since the operation ListAllergens is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listallergens",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/listallergensresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        AllergenListResponse1 ListAllergens(AllergenListRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listallergens",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/listallergensresponse")]
        Task<AllergenListResponse1> ListAllergensAsync(AllergenListRequest1 request);

        // CODEGEN: Generating message contract since the operation ListAuthorities is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listauthorities",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/listauthoritiesresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        AuthoritiesListResponse1 ListAuthorities(AuthoritiesListRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listauthorities",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/listauthoritiesresponse")]
        Task<AuthoritiesListResponse1> ListAuthoritiesAsync(AuthoritiesListRequest1 request);

        // CODEGEN: Generating message contract since the operation ListFoods is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listfoods", ReplyAction = "http://ns.esha.com/2013/genesisapi/listfoodsresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        FoodsListResponse1 ListFoods(FoodsListRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listfoods", ReplyAction = "http://ns.esha.com/2013/genesisapi/listfoodsresponse")]
        Task<FoodsListResponse1> ListFoodsAsync(FoodsListRequest1 request);

        // CODEGEN: Generating message contract since the operation ListFoodUserCodes is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listfoodusercodes",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/listfoodusercodesresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        FoodUserCodesListResponse1 ListFoodUserCodes(FoodUserCodesListRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listfoodusercodes",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/listfoodusercodesresponse")]
        Task<FoodUserCodesListResponse1> ListFoodUserCodesAsync(FoodUserCodesListRequest1 request);

        // CODEGEN: Generating message contract since the operation ListGroups is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listgroups", ReplyAction = "http://ns.esha.com/2013/genesisapi/listgroupsresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        GroupsListResponse1 ListGroups(GroupsListRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listgroups", ReplyAction = "http://ns.esha.com/2013/genesisapi/listgroupsresponse")]
        Task<GroupsListResponse1> ListGroupsAsync(GroupsListRequest1 request);

        // CODEGEN: Generating message contract since the operation ListNutrients is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listnutrients",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/listnutrientsresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        NutrientListResponse1 ListNutrients(NutrientListRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listnutrients",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/listnutrientsresponse")]
        Task<NutrientListResponse1> ListNutrientsAsync(NutrientListRequest1 request);

        // CODEGEN: Generating message contract since the operation ListRecommendationProfiles is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listrecommendationprofiles",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/listrecommendationprofilesresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        RecommendationProfilesListResponse1 ListRecommendationProfiles(RecommendationProfilesListRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listrecommendationprofiles",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/listrecommendationprofilesresponse")]
        Task<RecommendationProfilesListResponse1> ListRecommendationProfilesAsync(RecommendationProfilesListRequest1 request);

        // CODEGEN: Generating message contract since the operation ListUnits is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listunits", ReplyAction = "http://ns.esha.com/2013/genesisapi/listunitsresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        UnitListResponse1 ListUnits(UnitListRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/listunits", ReplyAction = "http://ns.esha.com/2013/genesisapi/listunitsresponse")]
        Task<UnitListResponse1> ListUnitsAsync(UnitListRequest1 request);

        // CODEGEN: Generating message contract since the operation Search is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/search", ReplyAction = "http://ns.esha.com/2013/genesisapi/searchresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        FoodsListResponse1 Search(FoodsSearchRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/search", ReplyAction = "http://ns.esha.com/2013/genesisapi/searchresponse")]
        Task<FoodsListResponse1> SearchAsync(FoodsSearchRequest1 request);

        // CODEGEN: Generating message contract since the operation SearchByGroup is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/searchbygroup",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/searchbygroupresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        FoodsListResponse1 SearchByGroup(FoodsByGroupRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/searchbygroup",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/searchbygroupresponse")]
        Task<FoodsListResponse1> SearchByGroupAsync(FoodsByGroupRequest1 request);

        // CODEGEN: Generating message contract since the operation SearchByModifiedDateRange is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/searchbymodifieddaterange",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/searchbymodifieddaterangeresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        FoodsListResponse1 SearchByModifiedDateRange(FoodsByModifiedDateRangeRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/searchbymodifieddaterange",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/searchbymodifieddaterangeresponse")]
        Task<FoodsListResponse1> SearchByModifiedDateRangeAsync(FoodsByModifiedDateRangeRequest1 request);

        // CODEGEN: Generating message contract since the operation SearchByName is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/searchbyname", ReplyAction = "http://ns.esha.com/2013/genesisapi/searchbynameresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        FoodsListResponse1 SearchByName(FoodsByNameRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/searchbyname", ReplyAction = "http://ns.esha.com/2013/genesisapi/searchbynameresponse")]
        Task<FoodsListResponse1> SearchByNameAsync(FoodsByNameRequest1 request);

        // CODEGEN: Generating message contract since the operation SearchByProperty is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/searchbyproperty",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/searchbypropertyresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        FoodsListResponse1 SearchByProperty(FoodsByPropertyRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/searchbyproperty",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/searchbypropertyresponse")]
        Task<FoodsListResponse1> SearchByPropertyAsync(FoodsByPropertyRequest1 request);
    }
}