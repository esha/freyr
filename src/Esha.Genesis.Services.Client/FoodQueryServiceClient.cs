using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using Esha.Genesis.Services.Client.Internal;

namespace Esha.Genesis.Services.Client
{
    [DebuggerStepThrough]
    public class FoodQueryServiceClient : ClientBase<Internal.IFoodQueryService>, Internal.IFoodQueryService, IFoodQueryService
    {
        private IDictionary<Guid, NutrientDto> _nutrientDictionary;

        public FoodQueryServiceClient()
        {
        }

        public FoodQueryServiceClient(String endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public FoodQueryServiceClient(String endpointConfigurationName, String remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public FoodQueryServiceClient(String endpointConfigurationName, EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public FoodQueryServiceClient(Binding binding, EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        NutrientListResponse1 Internal.IFoodQueryService.ListNutrients(NutrientListRequest1 request) => Channel.ListNutrients(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<NutrientListResponse1> Internal.IFoodQueryService.ListNutrientsAsync(NutrientListRequest1 request) => Channel.ListNutrientsAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        UnitListResponse1 Internal.IFoodQueryService.ListUnits(UnitListRequest1 request) => Channel.ListUnits(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<UnitListResponse1> Internal.IFoodQueryService.ListUnitsAsync(UnitListRequest1 request) => Channel.ListUnitsAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        AllergenListResponse1 Internal.IFoodQueryService.ListAllergens(AllergenListRequest1 request) => Channel.ListAllergens(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<AllergenListResponse1> Internal.IFoodQueryService.ListAllergensAsync(AllergenListRequest1 request) => Channel.ListAllergensAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodsListResponse1 Internal.IFoodQueryService.ListFoods(FoodsListRequest1 request) => Channel.ListFoods(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodsListResponse1> Internal.IFoodQueryService.ListFoodsAsync(FoodsListRequest1 request) => Channel.ListFoodsAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodMetadataResponse1 Internal.IFoodQueryService.GetFood(FoodMetadataRequest1 request) => Channel.GetFood(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodMetadataResponse1> Internal.IFoodQueryService.GetFoodAsync(FoodMetadataRequest1 request) => Channel.GetFoodAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodMetadataResponse1 Internal.IFoodQueryService.GetFoodByFoodId(GetFoodByFoodIdRequest1 request) => Channel.GetFoodByFoodId(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodMetadataResponse1> Internal.IFoodQueryService.GetFoodByFoodIdAsync(GetFoodByFoodIdRequest1 request) => Channel.GetFoodByFoodIdAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodMetadataResponse1 Internal.IFoodQueryService.GetFoodByUserCode(GetFoodByUserCodeRequest1 request) => Channel.GetFoodByUserCode(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodMetadataResponse1> Internal.IFoodQueryService.GetFoodByUserCodeAsync(GetFoodByUserCodeRequest1 request) =>
            Channel.GetFoodByUserCodeAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodAnalysisResponse1 Internal.IFoodQueryService.GetAnalysis(FoodAnalysisRequest1 request) => Channel.GetAnalysis(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodAnalysisResponse1> Internal.IFoodQueryService.GetAnalysisAsync(FoodAnalysisRequest1 request) => Channel.GetAnalysisAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodsListResponse1 Internal.IFoodQueryService.SearchByGroup(FoodsByGroupRequest1 request) => Channel.SearchByGroup(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodsListResponse1> Internal.IFoodQueryService.SearchByGroupAsync(FoodsByGroupRequest1 request) => Channel.SearchByGroupAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodsListResponse1 Internal.IFoodQueryService.SearchByName(FoodsByNameRequest1 request) => Channel.SearchByName(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodsListResponse1> Internal.IFoodQueryService.SearchByNameAsync(FoodsByNameRequest1 request) => Channel.SearchByNameAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodsListResponse1 Internal.IFoodQueryService.SearchByModifiedDateRange(FoodsByModifiedDateRangeRequest1 request) =>
            Channel.SearchByModifiedDateRange(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodsListResponse1> Internal.IFoodQueryService.SearchByModifiedDateRangeAsync(FoodsByModifiedDateRangeRequest1 request) =>
            Channel.SearchByModifiedDateRangeAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodUserCodesListResponse1 Internal.IFoodQueryService.ListFoodUserCodes(FoodUserCodesListRequest1 request) => Channel.ListFoodUserCodes(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodUserCodesListResponse1> Internal.IFoodQueryService.ListFoodUserCodesAsync(FoodUserCodesListRequest1 request) =>
            Channel.ListFoodUserCodesAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        GroupsListResponse1 Internal.IFoodQueryService.ListGroups(GroupsListRequest1 request) => Channel.ListGroups(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<GroupsListResponse1> Internal.IFoodQueryService.ListGroupsAsync(GroupsListRequest1 request) => Channel.ListGroupsAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodConversionsResponse1 Internal.IFoodQueryService.GetConversions(FoodMetadataRequest1 request) => Channel.GetConversions(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodConversionsResponse1> Internal.IFoodQueryService.GetConversionsAsync(FoodMetadataRequest1 request) => Channel.GetConversionsAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodsListResponse1 Internal.IFoodQueryService.Search(FoodsSearchRequest1 request) => Channel.Search(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodsListResponse1> Internal.IFoodQueryService.SearchAsync(FoodsSearchRequest1 request) => Channel.SearchAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodsListResponse1 Internal.IFoodQueryService.SearchByProperty(FoodsByPropertyRequest1 request) => Channel.SearchByProperty(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodsListResponse1> Internal.IFoodQueryService.SearchByPropertyAsync(FoodsByPropertyRequest1 request) => Channel.SearchByPropertyAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        RecommendationProfilesListResponse1 Internal.IFoodQueryService.ListRecommendationProfiles(RecommendationProfilesListRequest1 request) =>
            Channel.ListRecommendationProfiles(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<RecommendationProfilesListResponse1> Internal.IFoodQueryService.ListRecommendationProfilesAsync(RecommendationProfilesListRequest1 request) =>
            Channel.ListRecommendationProfilesAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        AuthoritiesListResponse1 Internal.IFoodQueryService.ListAuthorities(AuthoritiesListRequest1 request) => Channel.ListAuthorities(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<AuthoritiesListResponse1> Internal.IFoodQueryService.ListAuthoritiesAsync(AuthoritiesListRequest1 request) =>
            Channel.ListAuthoritiesAsync(request);

        public FoodAnalysisResponse GetAnalysis(FoodAnalysisRequest foodAnalysisRequest)
        {
            if (_nutrientDictionary is null)
            {
                var nutRetVal = ((Internal.IFoodQueryService)this).ListNutrients(new NutrientListRequest1 {NutrientListRequest = new NutrientListRequest()});
                _nutrientDictionary = createNutrientDictionary(nutRetVal);
            }

            var inValue = new FoodAnalysisRequest1 {FoodAnalysisRequest = foodAnalysisRequest};
            var retVal = ((Internal.IFoodQueryService)this).GetAnalysis(inValue);

            return processFoodAnalysisResponse(retVal.FoodAnalysisResponse);
        }

        public async Task<FoodAnalysisResponse> GetAnalysisAsync(FoodAnalysisRequest foodAnalysisRequest)
        {
            if (_nutrientDictionary is null)
            {
                var nutRetVal = await ((Internal.IFoodQueryService)this).ListNutrientsAsync(new NutrientListRequest1
                {
                    NutrientListRequest = new NutrientListRequest()
                });
                _nutrientDictionary = createNutrientDictionary(nutRetVal);
            }

            var inValue = new FoodAnalysisRequest1 {FoodAnalysisRequest = foodAnalysisRequest};
            var retVal = await ((Internal.IFoodQueryService)this).GetAnalysisAsync(inValue);

            return processFoodAnalysisResponse(retVal.FoodAnalysisResponse);
        }

        public FoodConversionsResponse GetConversions(FoodMetadataRequest foodMetadataRequest)
        {
            var inValue = new FoodMetadataRequest1 {FoodMetadataRequest = foodMetadataRequest};
            var retVal = ((Internal.IFoodQueryService)this).GetConversions(inValue);
            return retVal.FoodConversionsResponse;
        }

        public async Task<FoodConversionsResponse> GetConversionsAsync(FoodMetadataRequest foodMetadataRequest)
        {
            var inValue = new FoodMetadataRequest1 {FoodMetadataRequest = foodMetadataRequest};
            var retVal = await ((Internal.IFoodQueryService)this).GetConversionsAsync(inValue);
            return retVal.FoodConversionsResponse;
        }

        public FoodMetadataResponse GetFood(FoodMetadataRequest foodMetadataRequest)
        {
            var inValue = new FoodMetadataRequest1 {FoodMetadataRequest = foodMetadataRequest};
            var retVal = ((Internal.IFoodQueryService)this).GetFood(inValue);
            return retVal.FoodMetadataResponse;
        }

        public async Task<FoodMetadataResponse> GetFoodAsync(FoodMetadataRequest foodMetadataRequest)
        {
            var inValue = new FoodMetadataRequest1 {FoodMetadataRequest = foodMetadataRequest};
            var retVal = await ((Internal.IFoodQueryService)this).GetFoodAsync(inValue);
            return retVal.FoodMetadataResponse;
        }

        public FoodMetadataResponse GetFoodByFoodId(Guid foodId)
        {
            var inValue = new GetFoodByFoodIdRequest1 {GetFoodByFoodIdRequest = new GetFoodByFoodIdRequest {FoodId = foodId}};
            var retVal = ((Internal.IFoodQueryService)this).GetFoodByFoodId(inValue);
            return retVal.FoodMetadataResponse;
        }

        public async Task<FoodMetadataResponse> GetFoodByFoodIdAsync(Guid foodId)
        {
            var inValue = new GetFoodByFoodIdRequest1 {GetFoodByFoodIdRequest = new GetFoodByFoodIdRequest {FoodId = foodId}};
            var retVal = await ((Internal.IFoodQueryService)this).GetFoodByFoodIdAsync(inValue);
            return retVal.FoodMetadataResponse;
        }

        public FoodMetadataResponse GetFoodByUserCode(String userCode)
        {
            var inValue = new GetFoodByUserCodeRequest1 {GetFoodByUserCodeRequest = new GetFoodByUserCodeRequest {UserCode = userCode}};
            var retVal = ((Internal.IFoodQueryService)this).GetFoodByUserCode(inValue);
            return retVal.FoodMetadataResponse;
        }

        public async Task<FoodMetadataResponse> GetFoodByUserCodeAsync(String userCode)
        {
            var inValue = new GetFoodByUserCodeRequest1 {GetFoodByUserCodeRequest = new GetFoodByUserCodeRequest {UserCode = userCode}};
            var retVal = await ((Internal.IFoodQueryService)this).GetFoodByUserCodeAsync(inValue);
            return retVal.FoodMetadataResponse;
        }

        public AllergenListResponse ListAllergens(AllergenListRequest allergenListRequest)
        {
            var inValue = new AllergenListRequest1 {AllergenListRequest = allergenListRequest};
            var retVal = ((Internal.IFoodQueryService)this).ListAllergens(inValue);
            return retVal.AllergenListResponse;
        }

        public async Task<AllergenListResponse> ListAllergensAsync(AllergenListRequest allergenListRequest)
        {
            var inValue = new AllergenListRequest1 {AllergenListRequest = allergenListRequest};
            var retVal = await ((Internal.IFoodQueryService)this).ListAllergensAsync(inValue);
            return retVal.AllergenListResponse;
        }

        public AuthoritiesListResponse ListAuthorities(AuthoritiesListRequest authoritiesListRequest)
        {
            var inValue = new AuthoritiesListRequest1 {AuthoritiesListRequest = authoritiesListRequest};
            var retVal = ((Internal.IFoodQueryService)this).ListAuthorities(inValue);
            return retVal.AuthoritiesListResponse;
        }

        public async Task<AuthoritiesListResponse> ListAuthoritiesAsync(AuthoritiesListRequest authoritiesListRequest)
        {
            var inValue = new AuthoritiesListRequest1 {AuthoritiesListRequest = authoritiesListRequest};
            var retVal = await ((Internal.IFoodQueryService)this).ListAuthoritiesAsync(inValue);
            return retVal.AuthoritiesListResponse;
        }

        public FoodsListResponse ListFoods(FoodsListRequest foodsListRequest)
        {
            var inValue = new FoodsListRequest1 {FoodsListRequest = foodsListRequest};
            var retVal = ((Internal.IFoodQueryService)this).ListFoods(inValue);
            return retVal.FoodsListResponse;
        }

        public async Task<FoodsListResponse> ListFoodsAsync(FoodsListRequest foodsListRequest)
        {
            var inValue = new FoodsListRequest1 {FoodsListRequest = foodsListRequest};
            var retVal = await ((Internal.IFoodQueryService)this).ListFoodsAsync(inValue);
            return retVal.FoodsListResponse;
        }

        public FoodUserCodesListResponse ListFoodUserCodes(FoodUserCodesListRequest foodUserCodesListRequest)
        {
            var inValue = new FoodUserCodesListRequest1 {FoodUserCodesListRequest = foodUserCodesListRequest};
            var retVal = ((Internal.IFoodQueryService)this).ListFoodUserCodes(inValue);
            return retVal.FoodUserCodesListResponse;
        }

        public async Task<FoodUserCodesListResponse> ListFoodUserCodesAsync(FoodUserCodesListRequest foodUserCodesListRequest)
        {
            var inValue = new FoodUserCodesListRequest1 {FoodUserCodesListRequest = foodUserCodesListRequest};
            var retVal = await ((Internal.IFoodQueryService)this).ListFoodUserCodesAsync(inValue);
            return retVal.FoodUserCodesListResponse;
        }

        public GroupsListResponse ListGroups(GroupsListRequest groupsListRequest)
        {
            var inValue = new GroupsListRequest1 {GroupsListRequest = groupsListRequest};
            var retVal = ((Internal.IFoodQueryService)this).ListGroups(inValue);
            return retVal.GroupsListResponse;
        }

        public async Task<GroupsListResponse> ListGroupsAsync(GroupsListRequest groupsListRequest)
        {
            var inValue = new GroupsListRequest1 {GroupsListRequest = groupsListRequest};
            var retVal = await ((Internal.IFoodQueryService)this).ListGroupsAsync(inValue);
            return retVal.GroupsListResponse;
        }

        public NutrientListResponse ListNutrients(NutrientListRequest nutrientListRequest)
        {
            var inValue = new NutrientListRequest1 {NutrientListRequest = nutrientListRequest};
            var retVal = ((Internal.IFoodQueryService)this).ListNutrients(inValue);
            return retVal.NutrientListResponse;
        }

        public async Task<NutrientListResponse> ListNutrientsAsync(NutrientListRequest nutrientListRequest)
        {
            var inValue = new NutrientListRequest1 {NutrientListRequest = nutrientListRequest};
            var retVal = await ((Internal.IFoodQueryService)this).ListNutrientsAsync(inValue);
            return retVal.NutrientListResponse;
        }

        public RecommendationProfilesListResponse ListRecommendationProfiles(RecommendationProfilesListRequest recommendationProfilesListRequest)
        {
            var inValue = new RecommendationProfilesListRequest1 {RecommendationProfilesListRequest = recommendationProfilesListRequest};
            var retVal = ((Internal.IFoodQueryService)this).ListRecommendationProfiles(inValue);
            return retVal.RecommendationProfilesListResponse;
        }

        public async Task<RecommendationProfilesListResponse> ListRecommendationProfilesAsync(
            RecommendationProfilesListRequest recommendationProfilesListRequest)
        {
            var inValue = new RecommendationProfilesListRequest1 {RecommendationProfilesListRequest = recommendationProfilesListRequest};
            var retVal = await ((Internal.IFoodQueryService)this).ListRecommendationProfilesAsync(inValue);
            return retVal.RecommendationProfilesListResponse;
        }

        public UnitListResponse ListUnits(UnitListRequest unitListRequest)
        {
            var inValue = new UnitListRequest1 {UnitListRequest = unitListRequest};
            var retVal = ((Internal.IFoodQueryService)this).ListUnits(inValue);
            return retVal.UnitListResponse;
        }

        public async Task<UnitListResponse> ListUnitsAsync(UnitListRequest unitListRequest)
        {
            var inValue = new UnitListRequest1 {UnitListRequest = unitListRequest};
            var retVal = await ((Internal.IFoodQueryService)this).ListUnitsAsync(inValue);
            return retVal.UnitListResponse;
        }

        public FoodsListResponse Search(FoodsSearchRequest foodsSearchRequest)
        {
            var inValue = new FoodsSearchRequest1 {FoodsSearchRequest = foodsSearchRequest};
            var retVal = ((Internal.IFoodQueryService)this).Search(inValue);
            return retVal.FoodsListResponse;
        }

        public async Task<FoodsListResponse> SearchAsync(FoodsSearchRequest foodsSearchRequest)
        {
            var inValue = new FoodsSearchRequest1 {FoodsSearchRequest = foodsSearchRequest};
            var retVal = await ((Internal.IFoodQueryService)this).SearchAsync(inValue);
            return retVal.FoodsListResponse;
        }

        public FoodsListResponse SearchByGroup(FoodsByGroupRequest foodsByGroupRequest)
        {
            var inValue = new FoodsByGroupRequest1 {FoodsByGroupRequest = foodsByGroupRequest};
            var retVal = ((Internal.IFoodQueryService)this).SearchByGroup(inValue);
            return retVal.FoodsListResponse;
        }

        public async Task<FoodsListResponse> SearchByGroupAsync(FoodsByGroupRequest foodsByGroupRequest)
        {
            var inValue = new FoodsByGroupRequest1 {FoodsByGroupRequest = foodsByGroupRequest};
            var retVal = await ((Internal.IFoodQueryService)this).SearchByGroupAsync(inValue);
            return retVal.FoodsListResponse;
        }

        public FoodsListResponse SearchByModifiedDateRange(FoodsByModifiedDateRangeRequest foodsByModifiedDateRangeRequest)
        {
            var inValue = new FoodsByModifiedDateRangeRequest1 {FoodsByModifiedDateRangeRequest = foodsByModifiedDateRangeRequest};
            var retVal = ((Internal.IFoodQueryService)this).SearchByModifiedDateRange(inValue);
            return retVal.FoodsListResponse;
        }

        public async Task<FoodsListResponse> SearchByModifiedDateRangeAsync(FoodsByModifiedDateRangeRequest foodsByModifiedDateRangeRequest)
        {
            var inValue = new FoodsByModifiedDateRangeRequest1 {FoodsByModifiedDateRangeRequest = foodsByModifiedDateRangeRequest};
            var retVal = await ((Internal.IFoodQueryService)this).SearchByModifiedDateRangeAsync(inValue);
            return retVal.FoodsListResponse;
        }

        public FoodsListResponse SearchByName(FoodsByNameRequest foodsByNameRequest)
        {
            var inValue = new FoodsByNameRequest1 {FoodsByNameRequest = foodsByNameRequest};
            var retVal = ((Internal.IFoodQueryService)this).SearchByName(inValue);
            return retVal.FoodsListResponse;
        }

        public async Task<FoodsListResponse> SearchByNameAsync(FoodsByNameRequest foodsByNameRequest)
        {
            var inValue = new FoodsByNameRequest1 {FoodsByNameRequest = foodsByNameRequest};
            var retVal = await ((Internal.IFoodQueryService)this).SearchByNameAsync(inValue);
            return retVal.FoodsListResponse;
        }

        public FoodsListResponse SearchByProperty(FoodsByPropertyRequest foodsByPropertyRequest)
        {
            var inValue = new FoodsByPropertyRequest1 {FoodsByPropertyRequest = foodsByPropertyRequest};
            var retVal = ((Internal.IFoodQueryService)this).SearchByProperty(inValue);
            return retVal.FoodsListResponse;
        }

        public async Task<FoodsListResponse> SearchByPropertyAsync(FoodsByPropertyRequest foodsByPropertyRequest)
        {
            var inValue = new FoodsByPropertyRequest1 {FoodsByPropertyRequest = foodsByPropertyRequest};
            var retVal = await ((Internal.IFoodQueryService)this).SearchByPropertyAsync(inValue);
            return retVal.FoodsListResponse;
        }

        private IDictionary<Guid, NutrientDto> createNutrientDictionary(NutrientListResponse1 nutrientListResponse1)
        {
            var nutrients = nutrientListResponse1?.NutrientListResponse?.Nutrients;

            return nutrients?.ToDictionary(n => n.Id.Value, n => n);
        }

        private FoodAnalysisResponse processFoodAnalysisResponse(FoodAnalysisResponse analysisResponse)
        {
            var analyses = analysisResponse?.Food?.Analyses;
            if (analyses is null)
            {
                return analysisResponse;
            }

            var nutrientInfoDtos = analyses.Select(getNutrientInfoDtos).SelectMany(l => l);

            foreach (var nutrientInfoDto in nutrientInfoDtos)
            {
                var nutrientId = nutrientInfoDto.NutrientId;
                nutrientInfoDto.UnitId = !_nutrientDictionary?.ContainsKey(nutrientId) ?? false
                    ? null
                    : _nutrientDictionary[nutrientId].UnitId;
            }

            return analysisResponse;
        }

        private IEnumerable<NutrientInfoDto> getNutrientInfoDtos(AnalysisDto analysis)
        {
            if (analysis?.GrossNutrientValues is null || analysis?.NetNutrientValues is null)
            {
                return new List<NutrientInfoDto>();
            }

            var grossNutrients = analysis.GrossNutrientValues;
            var allNutrients = grossNutrients.Zip(analysis.NetNutrientValues, (g, n) => new[] {g, n})
                .SelectMany(a => a);

            var itemNutrients = analysis.ItemAnalyses?.Select(i => getNutrientInfoDtos(i.Analysis)).SelectMany(a => a)
                                ?? new List<NutrientInfoDto>();

            return allNutrients.Concat(itemNutrients);
        }
    }
}