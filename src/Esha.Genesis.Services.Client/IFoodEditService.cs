using System.Threading.Tasks;

namespace Esha.Genesis.Services.Client
{
    public interface IFoodEditService
    {
        NewFoodResponse NewFood(NewFoodRequest newFoodRequest);
        Task<NewFoodResponse> NewFoodAsync(NewFoodRequest newFoodRequest);
        UpdateFoodResponse UpdateFood(UpdateFoodRequest updateFoodRequest);
        Task<UpdateFoodResponse> UpdateFoodAsync(UpdateFoodRequest updateFoodRequest);
    }
}