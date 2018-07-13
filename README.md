# Client Library Documentation

# Add to App.config
```
<system.serviceModel>
    <bindings>
        <wsHttpBinding>
            <binding name="WSHttpBinding_IFoodEditService"
                     maxReceivedMessageSize="20000000"
                     maxBufferPoolSize="20000000"
                     >
                <security mode="None" />
            </binding>
            <binding name="WSHttpBinding_IFoodQueryService"
                     maxReceivedMessageSize="20000000"
                     maxBufferPoolSize="20000000">
                <security mode="None" />
            </binding>
            <binding name="WSHttpBinding_ILabelImageService"
                     maxReceivedMessageSize="20000000"
                     maxBufferPoolSize="20000000">
                <security mode="None" />
            </binding>
        </wsHttpBinding>
    </bindings>
    <client>
        <endpoint address="http://localhost:80/soap/FoodEditService.svc"
                  binding="wsHttpBinding" bindingConfiguration="WSHttpBinding_IFoodEditService"
                  contract="Esha.Genesis.Services.Client.IFoodEditService"
                  name="WSHttpBinding_IFoodEditService" />
        <endpoint address="http://localhost:80/soap/FoodQueryService.svc"
                  binding="wsHttpBinding" bindingConfiguration="WSHttpBinding_IFoodQueryService"
                  contract="Esha.Genesis.Services.Client.IFoodQueryService"
                  name="WSHttpBinding_IFoodQueryService" />
        <endpoint address="http://localhost:80/SOAP/LabelImageService.svc"
                  binding="wsHttpBinding" bindingConfiguration="WSHttpBinding_ILabelImageService"
                  contract="Esha.Genesis.Services.Client.ILabelImageService"
                  name="WSHttpBinding_ILabelImageService" />
    </client>
</system.serviceModel>
```

# Client Library Examples
```
/**********************************************************************************************************
* FoodQueryService
**********************************************************************************************************/

/**********************************************************************************************************
* GetAnalysis
**********************************************************************************************************/

// Using FoodId
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodAnalysisRequest = new FoodAnalysisRequest 
{
    FoodId = Guid.Parse("d6e1c25c-45ea-00e3-575f-443582096cec"),
    Quantity = new QuantityDto
    {
        Type = QuantityType.Double,
        Value = "100"
    },
    UnitId = Guid.Parse("a7df0af5-0008-0000-7484-751e8eaf05c6")
};
var foodAnalysisResponse = foodQueryServiceClient.GetAnalysis(foodAnalysisRequest);

// Using UserCode
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodAnalysisRequest = new FoodAnalysisRequest 
{
    UserCode = "1414-2",
    Quantity = new QuantityDto
    {
        Type = QuantityType.Double,
        Value = "100"
    },
    UnitId = Guid.Parse("a7df0af5-0008-0000-7484-751e8eaf05c6")
};
var foodAnalysisResponse = foodQueryServiceClient.GetAnalysis(foodAnalysisRequest);

/**********************************************************************************************************
* GetConversions
**********************************************************************************************************/

// Using FoodId
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodMetadataRequest = new FoodMetadataRequest
{
    FoodId = Guid.Parse("d6e1c25c-45ea-00e3-575f-443582096cec")
}; 
var foodConversionsResponse =  foodQueryServiceClient.GetConversions(foodMetadataRequest);

// Using UserCode 
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodMetadataRequest = new FoodMetadataRequest
{
    UserCode = "1414-2"
}; 
var foodConversionsResponse =  foodQueryServiceClient.GetConversions(foodMetadataRequest);

/**********************************************************************************************************
* GetFood
**********************************************************************************************************/

// Using FoodId
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodMetadataRequest = new FoodMetadataRequest
{
    FoodId = Guid.Parse("d6e1c25c-45ea-00e3-575f-443582096cec")
}; 
var foodMetaDataResponse =  foodQueryServiceClient.GetFood(foodMetadataRequest);

// Using UserCode 
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodMetadataRequest = new FoodMetadataRequest
{
    UserCode = "1414-2"
}; 
var foodMetadataResponse =  foodQueryServiceClient.GetFood(foodMetadataRequest);

/**********************************************************************************************************
* GetFoodByFoodId
**********************************************************************************************************/

var foodQueryServiceClient = new FoodQueryServiceClient();
var foodMetadataResponse =  foodQueryServiceClient.GetFoodByFoodId(Guid.Parse("d6e1c25c-45ea-00e3-575f-443582096cec"));

/**********************************************************************************************************
* GetFoodByUserCode
**********************************************************************************************************/

var foodQueryServiceClient = new FoodQueryServiceClient();
var foodMetadataResponse =  foodQueryServiceClient.GetFoodByUserCode("15");

/**********************************************************************************************************
* ListAllergens
**********************************************************************************************************/

// All Allergens
var foodQueryServiceClient = new FoodQueryServiceClient();
var allergenListResponse = foodQueryServiceClient.ListAllergens(new AllergenListRequest());

// First 10 Allergens
var foodQueryServiceClient = new FoodQueryServiceClient();
var allergenListRequest = new AllergenListRequest
{
    StartIndex = 1,
    PageSize = 10
};
var allergenListResponse = foodQueryServiceClient.ListAllergens(allergenListRequest);

/**********************************************************************************************************
* ListAuthorities 
**********************************************************************************************************/

// All Authorities 
var foodQueryServiceClient = new FoodQueryServiceClient();
var authoritiesListResponse = foodQueryServiceClient.ListAuthorities(new AuthoritiesListRequest());

// First 10 Authorities 
var foodQueryServiceClient = new FoodQueryServiceClient();
var authoritiesListRequest = new AuthoritiesListRequest
{
    StartIndex = 1,
    PageSize = 10
};
var authoritiesListResponse =  foodQueryServiceClient.ListAuthorities(authoritiesListRequest);

/**********************************************************************************************************
* ListFoods
**********************************************************************************************************/

// All Published Foods
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsListResponse = foodQueryServiceClient.ListFoods(new FoodsListRequest());

// All Foods
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsListRequest = new FoodsListRequest
{
    FilterByPublicationStates = new[] { PublicationState.Draft, PublicationState.Published }
};
var foodsListResponse = foodQueryServiceClient.ListFoods(foodsListRequest);

// All Ingredients 
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsListRequest = new FoodsListRequest
{
    FilterByPublicationStates = new[] { PublicationState.Draft, PublicationState.Published },
    FilterByFoodTypes = new[] {FoodType.Ingredient}
};
var foodsListResponse = foodQueryServiceClient.ListFoods(foodsListRequest);

// First 10 Ingredients 
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsListRequest = new FoodsListRequest
{
    FilterByPublicationStates = new[] { PublicationState.Draft, PublicationState.Published },
    FilterByFoodTypes = new[] {FoodType.Ingredient},
    StartIndex = 1,
    PageSize = 10
};
var foodsListResponse = foodQueryServiceClient.ListFoods(foodsListRequest);

/**********************************************************************************************************
* ListFoodUserCodes
**********************************************************************************************************/

// All Published Foods User Codes
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodUserCodesListResponse = foodQueryServiceClient.ListFoodUserCodes(new FoodUserCodesListRequest());

// All Foods User Codes 
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodUserCodesListRequest = new FoodUserCodesListRequest
{
    FilterByPublicationStates = new[] { PublicationState.Draft, PublicationState.Published }
};
var foodUserCodesListResponse = foodQueryServiceClient.ListFoodUserCodes(foodUserCodesListRequest);

// All Ingredients User Codes 
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodUserCodesListRequest = new FoodUserCodesListRequest
{
    FilterByPublicationStates = new[] { PublicationState.Draft, PublicationState.Published },
    FilterByFoodTypes = new[] {FoodType.Ingredient}
};
var foodUserCodesListResponse = foodQueryServiceClient.ListFoodUserCodes(foodUserCodesListRequest);

// First 10 Ingredients User Codes
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodUserCodesListRequest = new FoodUserCodesListRequest
{
    FilterByPublicationStates = new[] { PublicationState.Draft, PublicationState.Published },
    FilterByFoodTypes = new[] {FoodType.Ingredient},
    StartIndex = 1,
    PageSize = 10
};
var foodUserCodesListResponse = foodQueryServiceClient.ListFoodUserCodes(foodUserCodesListRequest);

/**********************************************************************************************************
* ListGroups
**********************************************************************************************************/

// All Groups 
var foodQueryServiceClient = new FoodQueryServiceClient();
var groupsListResponse = foodQueryServiceClient.ListGroups(new GroupsListRequest());

// First 10 Groups 
var foodQueryServiceClient = new FoodQueryServiceClient();
var groupsListRequest = new GroupsListRequest
{
    StartIndex = 1,
    PageSize = 10
};
var groupsListResponse =  foodQueryServiceClient.ListGroups(groupsListRequest);

// Get info on a specific Group
var foodQueryServiceClient = new FoodQueryServiceClient();
var groupsListRequest = new GroupsListRequest
{
   FilterByGroupIds = new Guid?[] { Guid.Parse("021c021f-000a-0000-8d69-0b60293379ea") }
};
var groupsListResponse =  foodQueryServiceClient.ListGroups(groupsListRequest);

/**********************************************************************************************************
* ListNutrients
**********************************************************************************************************/

// All Nutrients 
var foodQueryServiceClient = new FoodQueryServiceClient();
var nutrientListResponse = foodQueryServiceClient.ListNutrients(new NutrientListRequest());

// First 10 Nutrients 
var foodQueryServiceClient = new FoodQueryServiceClient();
var nutrientListRequest = new NutrientListRequest
{
    StartIndex = 1,
    PageSize = 10
};
var nutrientListResponse =  foodQueryServiceClient.ListNutrients(nutrientListRequest);

/**********************************************************************************************************
* ListRecommendationProfiles
**********************************************************************************************************/

// All RecommendationProfiles
var foodQueryServiceClient = new FoodQueryServiceClient();
var recommendationProfilesListResponse = foodQueryServiceClient.ListRecommendationProfiles(new RecommendationProfilesListRequest());

// First 10 RecommendationProfiles
var foodQueryServiceClient = new FoodQueryServiceClient();
var recommendationProfilesListRequest = new RecommendationProfilesListRequest
{
    StartIndex = 1,
    PageSize = 10
};
var recommendationProfilesListResponse = foodQueryServiceClient.ListRecommendationProfiles(recommendationProfilesListRequest);

// All RecommendationProfiles for a Given Authority
var foodQueryServiceClient = new FoodQueryServiceClient();
var recommendationProfilesListRequest = new RecommendationProfilesListRequest
{
    ForAuthority = unitedStatesAuthority 
};
var recommendationProfilesListResponse = foodQueryServiceClient.ListRecommendationProfiles(recommendationProfilesListRequest);

/**********************************************************************************************************
* ListUnits
**********************************************************************************************************/

// All Nutrients 
var foodQueryServiceClient = new FoodQueryServiceClient();
var unitListResponse = foodQueryServiceClient.ListUnits(new UnitListRequest());

// First 10 Nutrients 
var foodQueryServiceClient = new FoodQueryServiceClient();
var unitListRequest = new UnitListRequest
{
    StartIndex = 1,
    PageSize = 10
};
var unitListResponse =  foodQueryServiceClient.ListUnits(unitListRequest);

/**********************************************************************************************************
* Search
**********************************************************************************************************/

// All foods that match search criteria 
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodListResponse = foodQueryServiceClient.Search(new FoodsSearchRequest {SearchText = "Oats"});

// First 10 foods that match the search criteria 
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsSearchRequest = new FoodsSearchRequest
{
    SearchText = "Oats",
    StartIndex = 1,
    PageSize = 10
};
var foodsListResponse = foodQueryServiceClient.Search(foodsSearchRequest);

/**********************************************************************************************************
* SearchByGroups
**********************************************************************************************************/

// Get All Published Foods in Group
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsByGroupRequest = new FoodsByGroupRequest
{
    GroupName = "Vegan Foods"
};
var foodsListResponse = foodQueryServiceClient.SearchByGroup(foodsByGroupRequest);

// Get All Foods in Group
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsByGroupRequest = new FoodsByGroupRequest
{
    GroupName = "Vegan Foods",
    FilterByPublicationStates = new [] {PublicationState.Draft, PublicationState.Published }
};
var foodsListResponse = foodQueryServiceClient.SearchByGroup(foodsByGroupRequest);

// Get All Recipes in Group
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsByGroupRequest = new FoodsByGroupRequest
{
    GroupName = "Vegan Foods",
    FilterByPublicationStates = new [] {PublicationState.Draft, PublicationState.Published },
    FilterByFoodTypes = new [] {FoodType.Recipe}
};
var foodsListResponse = foodQueryServiceClient.SearchByGroup(foodsByGroupRequest);

// Get First 10 Recipes in Group
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsByGroupRequest = new FoodsByGroupRequest
{
    GroupName = "Vegan Foods",
    FilterByPublicationStates = new [] {PublicationState.Draft, PublicationState.Published },
    FilterByFoodTypes = new [] {FoodType.Recipe},
    StartIndex = 1,
    PageSize = 10
};
var foodsListResponse = foodQueryServiceClient.SearchByGroup(foodsByGroupRequest);

/**********************************************************************************************************
* SearchByModifiedDateRange
**********************************************************************************************************/

// Get All Published Foods
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsListResponse = foodQueryServiceClient.SearchByModifiedDateRange( new FoodsByModifiedDateRangeRequest());

// Get All Published Foods Modified Between two Dates
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsByModifiedDateRangeRequest = new FoodsByModifiedDateRangeRequest
{
    Start = new XmlDateTimeOffset { DateTime = new DateTime(2017, 1, 1), UtcOffsetInMinutes = 0},
    End = new XmlDateTimeOffset { DateTime = new DateTime(2017, 12, 31), UtcOffsetInMinutes = 0 },
};
var foodsListResponse = foodQueryServiceClient.SearchByModifiedDateRange(foodsByModifiedDateRangeRequest);

// Get All Foods Modified Between two Dates
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsByModifiedDateRangeRequest = new FoodsByModifiedDateRangeRequest
{
    Start = new XmlDateTimeOffset { DateTime = new DateTime(2017, 1, 1), UtcOffsetInMinutes = 0},
    End = new XmlDateTimeOffset { DateTime = new DateTime(2017, 12, 31), UtcOffsetInMinutes = 0 },
    FilterByPublicationStates = new[] { PublicationState.Draft, PublicationState.Published },
};
var foodsListResponse = foodQueryServiceClient.SearchByModifiedDateRange(foodsByModifiedDateRangeRequest);

// All Ingredients Modified Between two Dates
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsByModifiedDateRangeRequest = new FoodsByModifiedDateRangeRequest
{
    Start = new XmlDateTimeOffset { DateTime = new DateTime(2017, 1, 1), UtcOffsetInMinutes = 0},
    End = new XmlDateTimeOffset { DateTime = new DateTime(2017, 12, 31), UtcOffsetInMinutes = 0 },
    FilterByPublicationStates = new[] { PublicationState.Draft, PublicationState.Published },
    FilterByFoodTypes = new[] { FoodType.Ingredient }
};
var foodsListResponse = foodQueryServiceClient.SearchByModifiedDateRange(foodsByModifiedDateRangeRequest);

// First 10 Ingredients Modified Between two Dates
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsByModifiedDateRangeRequest = new FoodsByModifiedDateRangeRequest
{
    Start = new XmlDateTimeOffset { DateTime = new DateTime(2017, 1, 1), UtcOffsetInMinutes = 0},
    End = new XmlDateTimeOffset { DateTime = new DateTime(2017, 12, 31), UtcOffsetInMinutes = 0 },
    FilterByPublicationStates = new[] { PublicationState.Draft, PublicationState.Published },
    FilterByFoodTypes = new[] { FoodType.Ingredient },
    StartIndex = 1,
    PageSize = 10
};
var foodsListResponse = foodQueryServiceClient.SearchByModifiedDateRange(foodsByModifiedDateRangeRequest);

/**********************************************************************************************************
* SearchByName
**********************************************************************************************************/

// Get All Published Foods that match Pizza
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsListResponse = foodQueryServiceClient.SearchByName(new FoodsByNameRequest { FoodName = "Pizza" });

// Get All Foods that match Pizza 
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsByNameRequest = new FoodsByNameRequest
{
    FoodName = "Pizza",
    FilterByPublicationStates = new[] { PublicationState.Draft, PublicationState.Published }
};
var foodsListResponse = foodQueryServiceClient.SearchByName(foodsByNameRequest);

// Get All Recipes that match Pizza 
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsByNameRequest = new FoodsByNameRequest
{
    FoodName = "Pizza",
    FilterByPublicationStates = new[] { PublicationState.Draft, PublicationState.Published },
    FilterByFoodTypes = new[] { FoodType.Recipe }
};
var foodsListResponse = foodQueryServiceClient.SearchByName(foodsByNameRequest);

// Get First 10 Recipes that match Pizza 
var foodQueryServiceClient = new FoodQueryServiceClient();
var foodsByNameRequest = new FoodsByNameRequest
{
    FoodName = "Pizza",
    FilterByPublicationStates = new[] { PublicationState.Draft, PublicationState.Published },
    FilterByFoodTypes = new[] { FoodType.Recipe },
    StartIndex = 1,
    PageSize =  10
};
var foodsListResponse = foodQueryServiceClient.SearchByName(foodsByNameRequest);

/**********************************************************************************************************
* SearchByProperty Not Relevant to Users
**********************************************************************************************************/

/**********************************************************************************************************
* LabelImageService
**********************************************************************************************************/

/**********************************************************************************************************
* GetBarcodeImage
**********************************************************************************************************/

// Using FoodId
var labelImageServiceClient = new LabelImageServiceClient();
var imageRequest = new ImageRequest
{
    FoodId = Guid.Parse("d6e1c25c-45ea-00e3-575f-443582096cec")
};
var imageResponse = labelImageServiceClient.GetBarcodeImage(imageRequest);

// Using UserCode
var labelImageServiceClient = new LabelImageServiceClient();
var imageRequest = new ImageRequest
{
    UserCode = "1414-2"
};
var imageResponse = labelImageServiceClient.GetBarcodeImage(imageRequest);

/**********************************************************************************************************
* GetBarcodeImageByFoodId
**********************************************************************************************************/

var labelImageServiceClient = new LabelImageServiceClient();
var imageResponse = labelImageServiceClient.GetBarcodeImageByFoodId(Guid.Parse("d6e1c25c-45ea-00e3-575f-443582096cec"));

/**********************************************************************************************************
* GetBarcodeImageByUserCode
**********************************************************************************************************/

var labelImageServiceClient = new LabelImageServiceClient();
var imageResponse = labelImageServiceClient.GetBarcodeImageByUserCode("1414-2");

/**********************************************************************************************************
* GetLabelImage
**********************************************************************************************************/

// Using FoodId
var labelImageServiceClient = new LabelImageServiceClient();
var imageRequest = new ImageRequest 
{
    FoodId = Guid.Parse("d6e1c25c-45ea-00e3-575f-443582096cec")
};
var imageResponse = labelImageServiceClient.GetLabelImage(imageRequest);

// Using UserCode
var labelImageServiceClient = new LabelImageServiceClient();
var imageRequest = new ImageRequest 
{
    UserCode = "1414-2"
};
var imageResponse = labelImageServiceClient.GetLabelImage(imageRequest);

/**********************************************************************************************************
* GetLabelImageByFoodId
**********************************************************************************************************/

var labelImageServiceClient = new LabelImageServiceClient();
var imageResponse = labelImageServiceClient.GetLabelImageByFoodId(Guid.Parse("d6e1c25c-45ea-00e3-575f-443582096cec"));

/**********************************************************************************************************
* GetLabelImageByUserCode
**********************************************************************************************************/

var labelImageServiceClient = new LabelImageServiceClient();
var imageResponse = labelImageServiceClient.GetLabelImageByUserCode("1414-2");

/**********************************************************************************************************
* FoodEditService
**********************************************************************************************************/

/**********************************************************************************************************
* NewFood (Ingredient)
**********************************************************************************************************/

var foodEditServiceClient = new FoodEditServiceClient();

var ingredient = new IngredientDto();
ingredient.Name = new [] { new GlobalString() { Language = "en-US", Value = "New Ingredient1" } };
ingredient.CommonName = new[] { new GlobalString() { Language = "en-US", Value = "Ingredient" } };
ingredient.UserCode = "1414-3";
ingredient.Description = new[] { new GlobalString() { Language = "en-US", Value = "Description" } };
ingredient.UsdaCode = 1234;
ingredient.Created = new XmlDateTimeOffset
{
    DateTime = DateTime.Now.ToUniversalTime(),
    UtcOffsetInMinutes = 0
};
ingredient.Brand = new BrandDto
{
    Product = "Product",
    Supplier = "Supplier"
};
ingredient.AllergenStatements = new []
{
    new AllergenStatementDto {AllergenGroups = new []
    {
        Guid.Parse("f01975c0-0191-0000-ff88-2a01e505d63d") // Egg
    }}
}; 
ingredient.Groups = new[] {Guid.Parse("021c021f-000a-0000-8d69-0b60293379ea")};
ingredient.Conversions = new[]
{
    new ConversionDto
    {
        From = new AmountDto
        {
            Quantity = new QuantityDto() { Type = QuantityType.Double, Value = "100" },
            UnitId = Guid.Parse("a7df0af5-0008-0000-7484-751e8eaf05c6") // gram
        },
        To = new AmountDto
        {
            Quantity = new QuantityDto() { Type = QuantityType.Double, Value = "1" },
            UnitId = Guid.Parse("a7df0af5-001c-0000-7484-751e8eaf05c6") // bowl
        },
    }
};
ingredient.DefiningAmount = new AmountDto 
{
    Quantity = new QuantityDto() { Type = QuantityType.Double, Value = "100" },
    UnitId = Guid.Parse("a7df0af5-0008-0000-7484-751e8eaf05c6")
};
ingredient.NutrientProfileId = Guid.NewGuid();


var nutrientProfile = new NutrientProfileDto();
nutrientProfile.Id = ingredient.NutrientProfileId;
nutrientProfile.DefiningAmount = ingredient.DefiningAmount;
nutrientProfile.NutrientIdVector = new []
{
    new NutrientQuantityDto
    {
        NutrientId = Guid.Parse("84a8709a-0000-0000-ebf9-90cea7d9d44f"),
        Quantity = new QuantityDto
        {
            Type = QuantityType.Double,
            Value = "10"
        }
    }
};

var newFoodRequest = new NewFoodRequest
{
    Foods = new [] {ingredient},
    NutrientProfiles = new []{nutrientProfile}
};
var newFoodResponse = foodEditServiceClient.NewFood(newFoodRequest);

/**********************************************************************************************************
* NewFood (Recipe)
**********************************************************************************************************/

var foodEditServiceClient = new FoodEditServiceClient();

var recipe = new RecipeDto();
recipe.Name = new [] { new GlobalString() { Language = "en-US", Value = "New Recipe" } };
recipe.CommonName = new[] { new GlobalString() { Language = "en-US", Value = "Recipe" } };
recipe.UserCode = "1414-3";
recipe.Description = new[] { new GlobalString() { Language = "en-US", Value = "Description" } };
recipe.UsdaCode = 1234;
recipe.Created = new XmlDateTimeOffset
{
    DateTime = DateTime.Now.ToUniversalTime(),
    UtcOffsetInMinutes = 0
};
recipe.Brand = new BrandDto
{
    Product = "Product",
    Supplier = "Supplier"
};
recipe.AllergenStatements = new []
{
    new AllergenStatementDto {AllergenGroups = new []
    {
        Guid.Parse("f01975c0-0191-0000-ff88-2a01e505d63d") // Egg
    }}
}; 
recipe.Groups = new[] {Guid.Parse("021c021f-000a-0000-8d69-0b60293379ea")};
recipe.Conversions = new[]
{
    new ConversionDto
    {
        From = new AmountDto
        {
            Quantity = new QuantityDto() { Type = QuantityType.Double, Value = "100" },
            UnitId = Guid.Parse("a7df0af5-0008-0000-7484-751e8eaf05c6") // gram
        },
        To = new AmountDto
        {
            Quantity = new QuantityDto() { Type = QuantityType.Double, Value = "1" },
            UnitId = Guid.Parse("a7df0af5-001c-0000-7484-751e8eaf05c6") // bowl
        },
    }
};
recipe.DefiningAmount = new AmountDto 
{
    Quantity = new QuantityDto() { Type = QuantityType.Double, Value = "100" },
    UnitId = Guid.Parse("a7df0af5-0008-0000-7484-751e8eaf05c6")
};
recipe.Items = new[] {new FoodItemDto
{
    FoodId = Guid.Parse("d6e1c25c-45ea-00e3-575f-443582096cec"), // Existing Food in Database
    Amount = new AmountDto
    {
        Quantity = new QuantityDto() { Type = QuantityType.Double, Value = "100" },
        UnitId = Guid.Parse("a7df0af5-0008-0000-7484-751e8eaf05c6") // gram
    }
}};

var newFoodRequest = new NewFoodRequest
{
    Foods = new [] {recipe}
};
var newFoodResponse = foodEditServiceClient.NewFood(newFoodRequest);

/**********************************************************************************************************
* UpdateFood (Ingredient)
**********************************************************************************************************/

var foodEditServiceClient = new FoodEditServiceClient();

var ingredient = new IngredientDto();
ingredient.Id = Guid.Parse("d6e1c25c-45ea-00e3-575f-443582096cec");  // Existing Item in Database
ingredient.Name = new [] { new GlobalString() { Language = "en-US", Value = "New Ingredient1" } };
ingredient.CommonName = new[] { new GlobalString() { Language = "en-US", Value = "Ingredient" } };
ingredient.UserCode = "1414-3";
ingredient.Description = new[] { new GlobalString() { Language = "en-US", Value = "Description" } };
ingredient.UsdaCode = 1234;
ingredient.Created = new XmlDateTimeOffset
{
    DateTime = DateTime.Now.ToUniversalTime(),
    UtcOffsetInMinutes = 0
};
ingredient.Brand = new BrandDto
{
    Product = "Product",
    Supplier = "Supplier"
};
ingredient.AllergenStatements = new []
{
    new AllergenStatementDto {AllergenGroups = new []
    {
        Guid.Parse("f01975c0-0191-0000-ff88-2a01e505d63d") // Egg
    }}
}; 
ingredient.Groups = new[] {Guid.Parse("021c021f-000a-0000-8d69-0b60293379ea")};
ingredient.Conversions = new[]
{
    new ConversionDto
    {
        From = new AmountDto
        {
            Quantity = new QuantityDto() { Type = QuantityType.Double, Value = "100" },
            UnitId = Guid.Parse("a7df0af5-0008-0000-7484-751e8eaf05c6") // gram
        },
        To = new AmountDto
        {
            Quantity = new QuantityDto() { Type = QuantityType.Double, Value = "1" },
            UnitId = Guid.Parse("a7df0af5-001c-0000-7484-751e8eaf05c6") // bowl
        },
    }
};
ingredient.DefiningAmount = new AmountDto 
{
    Quantity = new QuantityDto() { Type = QuantityType.Double, Value = "100" },
    UnitId = Guid.Parse("a7df0af5-0008-0000-7484-751e8eaf05c6")
};
ingredient.NutrientProfileId = Guid.NewGuid();

var nutrientProfile = new NutrientProfileDto();
nutrientProfile.Id = ingredient.NutrientProfileId;
nutrientProfile.DefiningAmount = ingredient.DefiningAmount;
nutrientProfile.NutrientIdVector = new []
{
    new NutrientQuantityDto
    {
        NutrientId = Guid.Parse("84a8709a-0000-0000-ebf9-90cea7d9d44f"),
        Quantity = new QuantityDto
        {
            Type = QuantityType.Double,
            Value = "10"
        }
    }
};

var updateFoodRequest = new UpdateFoodRequest
{
    Foods = new [] {ingredient},
    NutrientProfiles = new []{nutrientProfile}
};
var updateFoodResponse = foodEditServiceClient.UpdateFood(updateFoodRequest);

/**********************************************************************************************************
* UpdateFood (Recipe)
**********************************************************************************************************/

var foodEditServiceClient = new FoodEditServiceClient();

var recipe = new RecipeDto();
recipe.Id = Guid.Parse("d6e1c25c-45ea-00e3-575f-443582096cec");  // Existing Item in Database
recipe.Name = new [] { new GlobalString() { Language = "en-US", Value = "New Recipe" } };
recipe.CommonName = new[] { new GlobalString() { Language = "en-US", Value = "Recipe" } };
recipe.UserCode = "1414-3";
recipe.Description = new[] { new GlobalString() { Language = "en-US", Value = "Description" } };
recipe.UsdaCode = 1234;
recipe.Created = new XmlDateTimeOffset
{
    DateTime = DateTime.Now.ToUniversalTime(),
    UtcOffsetInMinutes = 0
};
recipe.Brand = new BrandDto
{
    Product = "Product",
    Supplier = "Supplier"
};
recipe.AllergenStatements = new []
{
    new AllergenStatementDto {AllergenGroups = new []
    {
        Guid.Parse("f01975c0-0191-0000-ff88-2a01e505d63d") // Egg
    }}
}; 
recipe.Groups = new[] {Guid.Parse("021c021f-000a-0000-8d69-0b60293379ea")};
recipe.Conversions = new[]
{
    new ConversionDto
    {
        From = new AmountDto
        {
            Quantity = new QuantityDto() { Type = QuantityType.Double, Value = "100" },
            UnitId = Guid.Parse("a7df0af5-0008-0000-7484-751e8eaf05c6") // gram
        },
        To = new AmountDto
        {
            Quantity = new QuantityDto() { Type = QuantityType.Double, Value = "1" },
            UnitId = Guid.Parse("a7df0af5-001c-0000-7484-751e8eaf05c6") // bowl
        },
    }
};
recipe.DefiningAmount = new AmountDto 
{
    Quantity = new QuantityDto() { Type = QuantityType.Double, Value = "100" },
    UnitId = Guid.Parse("a7df0af5-0008-0000-7484-751e8eaf05c6")
};
recipe.Items = new[] {new FoodItemDto
{
    FoodId = Guid.Parse("d6e1c25c-45ea-00e3-575f-443582096cec"), // Existing Food in Database
    Amount = new AmountDto
    {
        Quantity = new QuantityDto() { Type = QuantityType.Double, Value = "100" },
        UnitId = Guid.Parse("a7df0af5-0008-0000-7484-751e8eaf05c6") // gram
    }
}};

var updateFoodRequest = new UpdateFoodRequest
{
    Foods = new [] {recipe}
};
var updateFoodRequest = foodEditServiceClient.UpdateFood(updateFoodRequest);
```
