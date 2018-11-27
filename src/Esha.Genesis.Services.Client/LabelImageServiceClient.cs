using System;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using Esha.Genesis.Services.Client.Internal;

namespace Esha.Genesis.Services.Client
{
    [DebuggerStepThrough]
    public class LabelImageServiceClient : ClientBase<Internal.ILabelImageService>, Internal.ILabelImageService, ILabelImageService
    {
        public LabelImageServiceClient()
        {
        }

        public LabelImageServiceClient(String endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public LabelImageServiceClient(String endpointConfigurationName, String remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public LabelImageServiceClient(String endpointConfigurationName, EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public LabelImageServiceClient(Binding binding, EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ImageResponse1 Internal.ILabelImageService.GetBarcodeImage(ImageRequest1 request) => Channel.GetBarcodeImage(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<ImageResponse1> Internal.ILabelImageService.GetBarcodeImageAsync(ImageRequest1 request) => Channel.GetBarcodeImageAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ImageResponse1 Internal.ILabelImageService.GetLabelImage(ImageRequest1 request) => Channel.GetLabelImage(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<ImageResponse1> Internal.ILabelImageService.GetLabelImageAsync(ImageRequest1 request) => Channel.GetLabelImageAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ImageResponse1 Internal.ILabelImageService.GetLabelImageByUserCode(ImageByUserCodeRequest1 request) => Channel.GetLabelImageByUserCode(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<ImageResponse1> Internal.ILabelImageService.GetLabelImageByUserCodeAsync(ImageByUserCodeRequest1 request) =>
            Channel.GetLabelImageByUserCodeAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ImageResponse1 Internal.ILabelImageService.GetLabelImageByFoodId(ImageByFoodIdRequest1 request) => Channel.GetLabelImageByFoodId(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<ImageResponse1> Internal.ILabelImageService.GetLabelImageByFoodIdAsync(ImageByFoodIdRequest1 request) =>
            Channel.GetLabelImageByFoodIdAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ImageResponse1 Internal.ILabelImageService.GetBarcodeImageByUserCode(ImageByUserCodeRequest1 request) => Channel.GetBarcodeImageByUserCode(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<ImageResponse1> Internal.ILabelImageService.GetBarcodeImageByUserCodeAsync(ImageByUserCodeRequest1 request) =>
            Channel.GetBarcodeImageByUserCodeAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<ImageResponse1> Internal.ILabelImageService.GetBarcodeImageByFoodIdAsync(ImageByFoodIdRequest1 request) =>
            Channel.GetBarcodeImageByFoodIdAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ImageResponse1 Internal.ILabelImageService.GetBarcodeImageByFoodId(ImageByFoodIdRequest1 request) => Channel.GetBarcodeImageByFoodId(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<ImageResponse1> Internal.ILabelImageService.GetLabelImageForFoodAsync(ImageForFoodRequest1 request) => Channel.GetLabelImageForFoodAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ImageResponse1 Internal.ILabelImageService.GetLabelImageForFood(ImageForFoodRequest1 request) => Channel.GetLabelImageForFood(request);

        public ImageResponse GetBarcodeImage(ImageRequest imageRequest)
        {
            var inValue = new ImageRequest1 {ImageRequest = imageRequest};
            var retVal = ((Internal.ILabelImageService)this).GetBarcodeImage(inValue);
            return retVal.ImageResponse;
        }

        public async Task<ImageResponse> GetBarcodeImageAsync(ImageRequest imageRequest)
        {
            var inValue = new ImageRequest1 {ImageRequest = imageRequest};
            var retVal = await ((Internal.ILabelImageService)this).GetBarcodeImageAsync(inValue);
            return retVal.ImageResponse;
        }

        public ImageResponse GetLabelImage(ImageRequest imageRequest)
        {
            var inValue = new ImageRequest1 {ImageRequest = imageRequest};
            var retVal = ((Internal.ILabelImageService)this).GetLabelImage(inValue);
            return retVal.ImageResponse;
        }

        public async Task<ImageResponse> GetLabelImageAsync(ImageRequest imageRequest)
        {
            var inValue = new ImageRequest1 {ImageRequest = imageRequest};
            var retVal = await ((Internal.ILabelImageService)this).GetLabelImageAsync(inValue);
            return retVal.ImageResponse;
        }

        public ImageResponse GetBarcodeImageByFoodId(Guid foodId)
        {
            var inValue = new ImageByFoodIdRequest1 {ImageByFoodIdRequest = new ImageByFoodIdRequest {FoodId = foodId}};
            var retVal = ((Internal.ILabelImageService)this).GetBarcodeImageByFoodId(inValue);
            return retVal.ImageResponse;
        }

        public async Task<ImageResponse> GetBarcodeImageByFoodIdAsync(Guid foodId)
        {
            var inValue = new ImageByFoodIdRequest1 {ImageByFoodIdRequest = new ImageByFoodIdRequest {FoodId = foodId}};
            var retVal = await ((Internal.ILabelImageService)this).GetBarcodeImageByFoodIdAsync(inValue);
            return retVal.ImageResponse;
        }

        public ImageResponse GetBarcodeImageByUserCode(String userCode)
        {
            var inValue = new ImageByUserCodeRequest1 {ImageByUserCodeRequest = new ImageByUserCodeRequest {UserCode = userCode}};
            var retVal = ((Internal.ILabelImageService)this).GetBarcodeImageByUserCode(inValue);
            return retVal.ImageResponse;
        }

        public async Task<ImageResponse> GetBarcodeImageByUserCodeAsync(String userCode)
        {
            var inValue = new ImageByUserCodeRequest1 {ImageByUserCodeRequest = new ImageByUserCodeRequest {UserCode = userCode}};
            var retVal = await ((Internal.ILabelImageService)this).GetBarcodeImageByUserCodeAsync(inValue);
            return retVal.ImageResponse;
        }

        public ImageResponse GetLabelImageByFoodId(Guid foodId)
        {
            var inValue = new ImageByFoodIdRequest1 {ImageByFoodIdRequest = new ImageByFoodIdRequest {FoodId = foodId}};
            var retVal = ((Internal.ILabelImageService)this).GetLabelImageByFoodId(inValue);
            return retVal.ImageResponse;
        }

        public async Task<ImageResponse> GetLabelImageByFoodIdAsync(Guid foodId)
        {
            var inValue = new ImageByFoodIdRequest1 {ImageByFoodIdRequest = new ImageByFoodIdRequest {FoodId = foodId}};
            var retVal = await ((Internal.ILabelImageService)this).GetLabelImageByFoodIdAsync(inValue);
            return retVal.ImageResponse;
        }

        public ImageResponse GetLabelImageByUserCode(String userCode)
        {
            var inValue = new ImageByUserCodeRequest1 {ImageByUserCodeRequest = new ImageByUserCodeRequest {UserCode = userCode}};
            var retVal = ((Internal.ILabelImageService)this).GetLabelImageByUserCode(inValue);
            return retVal.ImageResponse;
        }

        public async Task<ImageResponse> GetLabelImageByUserCodeAsync(String userCode)
        {
            var inValue = new ImageByUserCodeRequest1 {ImageByUserCodeRequest = new ImageByUserCodeRequest {UserCode = userCode}};
            var retVal = await ((Internal.ILabelImageService)this).GetLabelImageByUserCodeAsync(inValue);
            return retVal.ImageResponse;
        }

        public ImageResponse GetLabelImageForFood(ImageForFoodRequest imageRequest)
        {
            var inValue = new ImageForFoodRequest1 {ImageForFoodRequest = imageRequest};
            var retVal = ((Internal.ILabelImageService)this).GetLabelImageForFood(inValue);
            return retVal.ImageResponse;
        }

        public async Task<ImageResponse> GetLabelImageForFoodAsync(ImageForFoodRequest imageRequest)
        {
            var inValue = new ImageForFoodRequest1 {ImageForFoodRequest = imageRequest};
            var retVal = await ((Internal.ILabelImageService)this).GetLabelImageForFoodAsync(inValue);
            return retVal.ImageResponse;
        }
    }
}