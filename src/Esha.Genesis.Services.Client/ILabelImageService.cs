using System;
using System.Threading.Tasks;

namespace Esha.Genesis.Services.Client
{
    public interface ILabelImageService
    {
        ImageResponse GetBarcodeImage(ImageRequest imageRequest);
        Task<ImageResponse> GetBarcodeImageAsync(ImageRequest imageRequest);
        ImageResponse GetLabelImage(ImageRequest imageRequest);
        Task<ImageResponse> GetLabelImageAsync(ImageRequest imageRequest);
        ImageResponse GetBarcodeImageByFoodId(Guid foodId);
        Task<ImageResponse> GetBarcodeImageByFoodIdAsync(Guid foodId);
        ImageResponse GetBarcodeImageByUserCode(String userCode);
        Task<ImageResponse> GetBarcodeImageByUserCodeAsync(String userCode);
        ImageResponse GetLabelImageByFoodId(Guid foodId);
        Task<ImageResponse> GetLabelImageByFoodIdAsync(Guid foodId);
        ImageResponse GetLabelImageByUserCode(String userCode);
        Task<ImageResponse> GetLabelImageByUserCodeAsync(String userCode);
        ImageResponse GetLabelImageForFood(ImageForFoodRequest imageRequest);
        Task<ImageResponse> GetLabelImageForFoodAsync(ImageForFoodRequest imageRequest);
    }
}