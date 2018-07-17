using System;
using System.CodeDom.Compiler;
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
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class FoodQueryServiceClient : ClientBase<IFoodQueryService>, IFoodQueryService
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
        NutrientListResponse1 IFoodQueryService.ListNutrients(NutrientListRequest1 request) => Channel.ListNutrients(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<NutrientListResponse1> IFoodQueryService.ListNutrientsAsync(NutrientListRequest1 request) => Channel.ListNutrientsAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        UnitListResponse1 IFoodQueryService.ListUnits(UnitListRequest1 request) => Channel.ListUnits(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<UnitListResponse1> IFoodQueryService.ListUnitsAsync(UnitListRequest1 request) => Channel.ListUnitsAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        AllergenListResponse1 IFoodQueryService.ListAllergens(AllergenListRequest1 request) => Channel.ListAllergens(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<AllergenListResponse1> IFoodQueryService.ListAllergensAsync(AllergenListRequest1 request) => Channel.ListAllergensAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodsListResponse1 IFoodQueryService.ListFoods(FoodsListRequest1 request) => Channel.ListFoods(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodsListResponse1> IFoodQueryService.ListFoodsAsync(FoodsListRequest1 request) => Channel.ListFoodsAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodMetadataResponse1 IFoodQueryService.GetFood(FoodMetadataRequest1 request) => Channel.GetFood(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodMetadataResponse1> IFoodQueryService.GetFoodAsync(FoodMetadataRequest1 request) => Channel.GetFoodAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodMetadataResponse1 IFoodQueryService.GetFoodByFoodId(GetFoodByFoodIdRequest1 request) => Channel.GetFoodByFoodId(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodMetadataResponse1> IFoodQueryService.GetFoodByFoodIdAsync(GetFoodByFoodIdRequest1 request) => Channel.GetFoodByFoodIdAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodMetadataResponse1 IFoodQueryService.GetFoodByUserCode(GetFoodByUserCodeRequest1 request) => Channel.GetFoodByUserCode(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodMetadataResponse1> IFoodQueryService.GetFoodByUserCodeAsync(GetFoodByUserCodeRequest1 request) => Channel.GetFoodByUserCodeAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodAnalysisResponse1 IFoodQueryService.GetAnalysis(FoodAnalysisRequest1 request) => Channel.GetAnalysis(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodAnalysisResponse1> IFoodQueryService.GetAnalysisAsync(FoodAnalysisRequest1 request) => Channel.GetAnalysisAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodsListResponse1 IFoodQueryService.SearchByGroup(FoodsByGroupRequest1 request) => Channel.SearchByGroup(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodsListResponse1> IFoodQueryService.SearchByGroupAsync(FoodsByGroupRequest1 request) => Channel.SearchByGroupAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodsListResponse1 IFoodQueryService.SearchByName(FoodsByNameRequest1 request) => Channel.SearchByName(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodsListResponse1> IFoodQueryService.SearchByNameAsync(FoodsByNameRequest1 request) => Channel.SearchByNameAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodsListResponse1 IFoodQueryService.SearchByModifiedDateRange(FoodsByModifiedDateRangeRequest1 request) => Channel.SearchByModifiedDateRange(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodsListResponse1> IFoodQueryService.SearchByModifiedDateRangeAsync(FoodsByModifiedDateRangeRequest1 request) =>
            Channel.SearchByModifiedDateRangeAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodUserCodesListResponse1 IFoodQueryService.ListFoodUserCodes(FoodUserCodesListRequest1 request) => Channel.ListFoodUserCodes(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodUserCodesListResponse1> IFoodQueryService.ListFoodUserCodesAsync(FoodUserCodesListRequest1 request) => Channel.ListFoodUserCodesAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        GroupsListResponse1 IFoodQueryService.ListGroups(GroupsListRequest1 request) => Channel.ListGroups(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<GroupsListResponse1> IFoodQueryService.ListGroupsAsync(GroupsListRequest1 request) => Channel.ListGroupsAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodConversionsResponse1 IFoodQueryService.GetConversions(FoodMetadataRequest1 request) => Channel.GetConversions(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodConversionsResponse1> IFoodQueryService.GetConversionsAsync(FoodMetadataRequest1 request) => Channel.GetConversionsAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodsListResponse1 IFoodQueryService.Search(FoodsSearchRequest1 request) => Channel.Search(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodsListResponse1> IFoodQueryService.SearchAsync(FoodsSearchRequest1 request) => Channel.SearchAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        FoodsListResponse1 IFoodQueryService.SearchByProperty(FoodsByPropertyRequest1 request) => Channel.SearchByProperty(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<FoodsListResponse1> IFoodQueryService.SearchByPropertyAsync(FoodsByPropertyRequest1 request) => Channel.SearchByPropertyAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        RecommendationProfilesListResponse1 IFoodQueryService.ListRecommendationProfiles(RecommendationProfilesListRequest1 request) =>
            Channel.ListRecommendationProfiles(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<RecommendationProfilesListResponse1> IFoodQueryService.ListRecommendationProfilesAsync(RecommendationProfilesListRequest1 request) =>
            Channel.ListRecommendationProfilesAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        AuthoritiesListResponse1 IFoodQueryService.ListAuthorities(AuthoritiesListRequest1 request) => Channel.ListAuthorities(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<AuthoritiesListResponse1> IFoodQueryService.ListAuthoritiesAsync(AuthoritiesListRequest1 request) => Channel.ListAuthoritiesAsync(request);

        public FoodAnalysisResponse GetAnalysis(FoodAnalysisRequest foodAnalysisRequest)
        {
            if (_nutrientDictionary is null)
            {
                var nutRetVal = ((IFoodQueryService)this).ListNutrients(new NutrientListRequest1 { NutrientListRequest = new NutrientListRequest() });
                _nutrientDictionary = createNutrientDictionary(nutRetVal);
            }

            var inValue = new FoodAnalysisRequest1 {FoodAnalysisRequest = foodAnalysisRequest};
            var retVal = ((IFoodQueryService)this).GetAnalysis(inValue);
            
            return processFoodAnalysisResponse(retVal.FoodAnalysisResponse);
        }

        public async Task<FoodAnalysisResponse> GetAnalysisAsync(FoodAnalysisRequest foodAnalysisRequest)
        {
            if (_nutrientDictionary is null)
            {
                var nutRetVal = await ((IFoodQueryService)this).ListNutrientsAsync(new NutrientListRequest1 { NutrientListRequest = new NutrientListRequest() });
                _nutrientDictionary = createNutrientDictionary(nutRetVal);
            }

            var inValue = new FoodAnalysisRequest1 {FoodAnalysisRequest = foodAnalysisRequest};
            var retVal = await ((IFoodQueryService)this).GetAnalysisAsync(inValue);

            return processFoodAnalysisResponse(retVal.FoodAnalysisResponse);
        }

        public FoodConversionsResponse GetConversions(FoodMetadataRequest foodMetadataRequest)
        {
            var inValue = new FoodMetadataRequest1 {FoodMetadataRequest = foodMetadataRequest};
            var retVal = ((IFoodQueryService)this).GetConversions(inValue);
            return retVal.FoodConversionsResponse;
        }

        public async Task<FoodConversionsResponse> GetConversionsAsync(FoodMetadataRequest foodMetadataRequest)
        {
            var inValue = new FoodMetadataRequest1 {FoodMetadataRequest = foodMetadataRequest};
            var retVal = await((IFoodQueryService)this).GetConversionsAsync(inValue);
            return retVal.FoodConversionsResponse;
        }

        public FoodMetadataResponse GetFood(FoodMetadataRequest foodMetadataRequest)
        {
            var inValue = new FoodMetadataRequest1 {FoodMetadataRequest = foodMetadataRequest};
            var retVal = ((IFoodQueryService)this).GetFood(inValue);
            return retVal.FoodMetadataResponse;
        }

        public async Task<FoodMetadataResponse> GetFoodAsync(FoodMetadataRequest foodMetadataRequest)
        {
            var inValue = new FoodMetadataRequest1 {FoodMetadataRequest = foodMetadataRequest};
            var retVal = await ((IFoodQueryService)this).GetFoodAsync(inValue);
            return retVal.FoodMetadataResponse;
        }

        public FoodMetadataResponse GetFoodByFoodId(Guid foodId) 
        {
            var inValue = new GetFoodByFoodIdRequest1 {GetFoodByFoodIdRequest = new GetFoodByFoodIdRequest {FoodId = foodId}};
            var retVal = ((IFoodQueryService)(this)).GetFoodByFoodId(inValue);
            return retVal.FoodMetadataResponse;
        }

        public async Task<FoodMetadataResponse> GetFoodByFoodIdAsync(Guid foodId) 
        {
            var inValue = new GetFoodByFoodIdRequest1 {GetFoodByFoodIdRequest = new GetFoodByFoodIdRequest {FoodId = foodId}};
            var retVal = await ((IFoodQueryService)(this)).GetFoodByFoodIdAsync(inValue);
            return retVal.FoodMetadataResponse;
        }

        public FoodMetadataResponse GetFoodByUserCode(String userCode) 
        {
            var inValue = new GetFoodByUserCodeRequest1 {GetFoodByUserCodeRequest = new GetFoodByUserCodeRequest {UserCode = userCode}};
            var retVal = ((IFoodQueryService)(this)).GetFoodByUserCode(inValue);
            return retVal.FoodMetadataResponse;
        }

        public async Task<FoodMetadataResponse> GetFoodByUserCodeAsync(String userCode) 
        {
            var inValue = new GetFoodByUserCodeRequest1 {GetFoodByUserCodeRequest = new GetFoodByUserCodeRequest {UserCode = userCode}};
            var retVal = await ((IFoodQueryService)(this)).GetFoodByUserCodeAsync(inValue);
            return retVal.FoodMetadataResponse;
        }

        public AllergenListResponse ListAllergens(AllergenListRequest allergenListRequest)
        {
            var inValue = new AllergenListRequest1 {AllergenListRequest = allergenListRequest};
            var retVal = ((IFoodQueryService)this).ListAllergens(inValue);
            return retVal.AllergenListResponse;
        }

        public async Task<AllergenListResponse> ListAllergensAsync(AllergenListRequest allergenListRequest)
        {
            var inValue = new AllergenListRequest1 {AllergenListRequest = allergenListRequest};
            var retVal = await ((IFoodQueryService)this).ListAllergensAsync(inValue);
            return retVal.AllergenListResponse;
        }

        public AuthoritiesListResponse ListAuthorities(AuthoritiesListRequest authoritiesListRequest)
        {
            var inValue = new AuthoritiesListRequest1 {AuthoritiesListRequest = authoritiesListRequest};
            var retVal = ((IFoodQueryService)this).ListAuthorities(inValue);
            return retVal.AuthoritiesListResponse;
        }

        public async Task<AuthoritiesListResponse> ListAuthoritiesAsync(AuthoritiesListRequest authoritiesListRequest)
        {
            var inValue = new AuthoritiesListRequest1 {AuthoritiesListRequest = authoritiesListRequest};
            var retVal = await ((IFoodQueryService)this).ListAuthoritiesAsync(inValue);
            return retVal.AuthoritiesListResponse;
        }

        public FoodsListResponse ListFoods(FoodsListRequest foodsListRequest)
        {
            var inValue = new FoodsListRequest1 {FoodsListRequest = foodsListRequest};
            var retVal = ((IFoodQueryService)this).ListFoods(inValue);
            return retVal.FoodsListResponse;
        }

        public async Task<FoodsListResponse> ListFoodsAsync(FoodsListRequest foodsListRequest)
        {
            var inValue = new FoodsListRequest1 {FoodsListRequest = foodsListRequest};
            var retVal = await ((IFoodQueryService)this).ListFoodsAsync(inValue);
            return retVal.FoodsListResponse;
        }

        public FoodUserCodesListResponse ListFoodUserCodes(FoodUserCodesListRequest foodUserCodesListRequest)
        {
            var inValue = new FoodUserCodesListRequest1 {FoodUserCodesListRequest = foodUserCodesListRequest};
            var retVal = ((IFoodQueryService)this).ListFoodUserCodes(inValue);
            return retVal.FoodUserCodesListResponse;
        }

        public async Task<FoodUserCodesListResponse> ListFoodUserCodesAsync(FoodUserCodesListRequest foodUserCodesListRequest)
        {
            var inValue = new FoodUserCodesListRequest1 {FoodUserCodesListRequest = foodUserCodesListRequest};
            var retVal = await ((IFoodQueryService)this).ListFoodUserCodesAsync(inValue);
            return retVal.FoodUserCodesListResponse;
        }

        public GroupsListResponse ListGroups(GroupsListRequest groupsListRequest)
        {
            var inValue = new GroupsListRequest1 {GroupsListRequest = groupsListRequest};
            var retVal = ((IFoodQueryService)this).ListGroups(inValue);
            return retVal.GroupsListResponse;
        }

        public async Task<GroupsListResponse> ListGroupsAsync(GroupsListRequest groupsListRequest)
        {
            var inValue = new GroupsListRequest1 {GroupsListRequest = groupsListRequest};
            var retVal = await ((IFoodQueryService)this).ListGroupsAsync(inValue);
            return retVal.GroupsListResponse;
        }

        public NutrientListResponse ListNutrients(NutrientListRequest nutrientListRequest)
        {
            var inValue = new NutrientListRequest1 {NutrientListRequest = nutrientListRequest};
            var retVal = ((IFoodQueryService)this).ListNutrients(inValue);
            return retVal.NutrientListResponse;
        }

        public async Task<NutrientListResponse> ListNutrientsAsync(NutrientListRequest nutrientListRequest)
        {
            var inValue = new NutrientListRequest1 {NutrientListRequest = nutrientListRequest};
            var retVal = await ((IFoodQueryService)this).ListNutrientsAsync(inValue);
            return retVal.NutrientListResponse;
        }

        public RecommendationProfilesListResponse ListRecommendationProfiles(RecommendationProfilesListRequest recommendationProfilesListRequest)
        {
            var inValue = new RecommendationProfilesListRequest1 {RecommendationProfilesListRequest = recommendationProfilesListRequest};
            var retVal = ((IFoodQueryService)this).ListRecommendationProfiles(inValue);
            return retVal.RecommendationProfilesListResponse;
        }

        public async Task<RecommendationProfilesListResponse> ListRecommendationProfilesAsync(RecommendationProfilesListRequest recommendationProfilesListRequest)
        {
            var inValue = new RecommendationProfilesListRequest1 {RecommendationProfilesListRequest = recommendationProfilesListRequest};
            var retVal = await ((IFoodQueryService)this).ListRecommendationProfilesAsync(inValue);
            return retVal.RecommendationProfilesListResponse;
        }

        public UnitListResponse ListUnits(UnitListRequest unitListRequest)
        {
            var inValue = new UnitListRequest1 {UnitListRequest = unitListRequest};
            var retVal = ((IFoodQueryService)this).ListUnits(inValue);
            return retVal.UnitListResponse;
        }

        public async Task<UnitListResponse> ListUnitsAsync(UnitListRequest unitListRequest)
        {
            var inValue = new UnitListRequest1 {UnitListRequest = unitListRequest};
            var retVal = await ((IFoodQueryService)this).ListUnitsAsync(inValue);
            return retVal.UnitListResponse;
        }

        public FoodsListResponse Search(FoodsSearchRequest foodsSearchRequest)
        {
            var inValue = new FoodsSearchRequest1 {FoodsSearchRequest = foodsSearchRequest};
            var retVal = ((IFoodQueryService)this).Search(inValue);
            return retVal.FoodsListResponse;
        }

        public async Task<FoodsListResponse> SearchAsync(FoodsSearchRequest foodsSearchRequest)
        {
            var inValue = new FoodsSearchRequest1 {FoodsSearchRequest = foodsSearchRequest};
            var retVal = await ((IFoodQueryService)this).SearchAsync(inValue);
            return retVal.FoodsListResponse;
        }

        public FoodsListResponse SearchByGroup(FoodsByGroupRequest foodsByGroupRequest)
        {
            var inValue = new FoodsByGroupRequest1 {FoodsByGroupRequest = foodsByGroupRequest};
            var retVal = ((IFoodQueryService)this).SearchByGroup(inValue);
            return retVal.FoodsListResponse;
        }

        public async Task<FoodsListResponse> SearchByGroupAsync(FoodsByGroupRequest foodsByGroupRequest)
        {
            var inValue = new FoodsByGroupRequest1 {FoodsByGroupRequest = foodsByGroupRequest};
            var retVal = await ((IFoodQueryService)this).SearchByGroupAsync(inValue);
            return retVal.FoodsListResponse;
        }

        public FoodsListResponse SearchByModifiedDateRange(FoodsByModifiedDateRangeRequest foodsByModifiedDateRangeRequest)
        {
            var inValue = new FoodsByModifiedDateRangeRequest1 {FoodsByModifiedDateRangeRequest = foodsByModifiedDateRangeRequest};
            var retVal = ((IFoodQueryService)this).SearchByModifiedDateRange(inValue);
            return retVal.FoodsListResponse;
        }

        public async Task<FoodsListResponse> SearchByModifiedDateRangeAsync(FoodsByModifiedDateRangeRequest foodsByModifiedDateRangeRequest)
        {
            var inValue = new FoodsByModifiedDateRangeRequest1 {FoodsByModifiedDateRangeRequest = foodsByModifiedDateRangeRequest};
            var retVal = await ((IFoodQueryService)this).SearchByModifiedDateRangeAsync(inValue);
            return retVal.FoodsListResponse;
        }

        public FoodsListResponse SearchByName(FoodsByNameRequest foodsByNameRequest)
        {
            var inValue = new FoodsByNameRequest1 {FoodsByNameRequest = foodsByNameRequest};
            var retVal = ((IFoodQueryService)this).SearchByName(inValue);
            return retVal.FoodsListResponse;
        }

        public async Task<FoodsListResponse> SearchByNameAsync(FoodsByNameRequest foodsByNameRequest)
        {
            var inValue = new FoodsByNameRequest1 {FoodsByNameRequest = foodsByNameRequest};
            var retVal = await ((IFoodQueryService)this).SearchByNameAsync(inValue);
            return retVal.FoodsListResponse;
        }

        public FoodsListResponse SearchByProperty(FoodsByPropertyRequest foodsByPropertyRequest)
        {
            var inValue = new FoodsByPropertyRequest1 {FoodsByPropertyRequest = foodsByPropertyRequest};
            var retVal = ((IFoodQueryService)this).SearchByProperty(inValue);
            return retVal.FoodsListResponse;
        }

        public async Task<FoodsListResponse> SearchByPropertyAsync(FoodsByPropertyRequest foodsByPropertyRequest)
        {
            var inValue = new FoodsByPropertyRequest1 {FoodsByPropertyRequest = foodsByPropertyRequest};
            var retVal = await ((IFoodQueryService)this).SearchByPropertyAsync(inValue);
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
                    ? null : _nutrientDictionary[nutrientId].UnitId;
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