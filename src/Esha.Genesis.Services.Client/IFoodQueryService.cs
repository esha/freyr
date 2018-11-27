using System;
using System.Threading.Tasks;

namespace Esha.Genesis.Services.Client
{
    public interface IFoodQueryService
    {
        FoodAnalysisResponse GetAnalysis(FoodAnalysisRequest foodAnalysisRequest);
        Task<FoodAnalysisResponse> GetAnalysisAsync(FoodAnalysisRequest foodAnalysisRequest);
        FoodConversionsResponse GetConversions(FoodMetadataRequest foodMetadataRequest);
        Task<FoodConversionsResponse> GetConversionsAsync(FoodMetadataRequest foodMetadataRequest);
        FoodMetadataResponse GetFood(FoodMetadataRequest foodMetadataRequest);
        Task<FoodMetadataResponse> GetFoodAsync(FoodMetadataRequest foodMetadataRequest);
        FoodMetadataResponse GetFoodByFoodId(Guid foodId);
        Task<FoodMetadataResponse> GetFoodByFoodIdAsync(Guid foodId);
        FoodMetadataResponse GetFoodByUserCode(String userCode);
        Task<FoodMetadataResponse> GetFoodByUserCodeAsync(String userCode);
        AllergenListResponse ListAllergens(AllergenListRequest allergenListRequest);
        Task<AllergenListResponse> ListAllergensAsync(AllergenListRequest allergenListRequest);
        AuthoritiesListResponse ListAuthorities(AuthoritiesListRequest authoritiesListRequest);
        Task<AuthoritiesListResponse> ListAuthoritiesAsync(AuthoritiesListRequest authoritiesListRequest);
        FoodsListResponse ListFoods(FoodsListRequest foodsListRequest);
        Task<FoodsListResponse> ListFoodsAsync(FoodsListRequest foodsListRequest);
        FoodUserCodesListResponse ListFoodUserCodes(FoodUserCodesListRequest foodUserCodesListRequest);
        Task<FoodUserCodesListResponse> ListFoodUserCodesAsync(FoodUserCodesListRequest foodUserCodesListRequest);
        GroupsListResponse ListGroups(GroupsListRequest groupsListRequest);
        Task<GroupsListResponse> ListGroupsAsync(GroupsListRequest groupsListRequest);
        NutrientListResponse ListNutrients(NutrientListRequest nutrientListRequest);
        Task<NutrientListResponse> ListNutrientsAsync(NutrientListRequest nutrientListRequest);
        RecommendationProfilesListResponse ListRecommendationProfiles(RecommendationProfilesListRequest recommendationProfilesListRequest);
        Task<RecommendationProfilesListResponse> ListRecommendationProfilesAsync(RecommendationProfilesListRequest recommendationProfilesListRequest);
        UnitListResponse ListUnits(UnitListRequest unitListRequest);
        Task<UnitListResponse> ListUnitsAsync(UnitListRequest unitListRequest);
        FoodsListResponse Search(FoodsSearchRequest foodsSearchRequest);
        Task<FoodsListResponse> SearchAsync(FoodsSearchRequest foodsSearchRequest);
        FoodsListResponse SearchByGroup(FoodsByGroupRequest foodsByGroupRequest);
        Task<FoodsListResponse> SearchByGroupAsync(FoodsByGroupRequest foodsByGroupRequest);
        FoodsListResponse SearchByModifiedDateRange(FoodsByModifiedDateRangeRequest foodsByModifiedDateRangeRequest);
        Task<FoodsListResponse> SearchByModifiedDateRangeAsync(FoodsByModifiedDateRangeRequest foodsByModifiedDateRangeRequest);
        FoodsListResponse SearchByName(FoodsByNameRequest foodsByNameRequest);
        Task<FoodsListResponse> SearchByNameAsync(FoodsByNameRequest foodsByNameRequest);
        FoodsListResponse SearchByProperty(FoodsByPropertyRequest foodsByPropertyRequest);
        Task<FoodsListResponse> SearchByPropertyAsync(FoodsByPropertyRequest foodsByPropertyRequest);
    }
}