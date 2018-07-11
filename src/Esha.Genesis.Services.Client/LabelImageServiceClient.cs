using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using Esha.Genesis.Services.Client.Internal;

namespace Esha.Genesis.Services.Client
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class LabelImageServiceClient : ClientBase<ILabelImageService>, ILabelImageService
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
        ImageResponse1 ILabelImageService.GetBarcodeImage(ImageRequest1 request) => Channel.GetBarcodeImage(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<ImageResponse1> ILabelImageService.GetBarcodeImageAsync(ImageRequest1 request) => Channel.GetBarcodeImageAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ImageResponse1 ILabelImageService.GetLabelImage(ImageRequest1 request) => Channel.GetLabelImage(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<ImageResponse1> ILabelImageService.GetLabelImageAsync(ImageRequest1 request) => Channel.GetLabelImageAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ImageResponse1 ILabelImageService.GetLabelImageByUserCode(ImageByUserCodeRequest1 request) => Channel.GetLabelImageByUserCode(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<ImageResponse1> ILabelImageService.GetLabelImageByUserCodeAsync(ImageByUserCodeRequest1 request) => Channel.GetLabelImageByUserCodeAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ImageResponse1 ILabelImageService.GetLabelImageByFoodId(ImageByFoodIdRequest1 request) => Channel.GetLabelImageByFoodId(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<ImageResponse1> ILabelImageService.GetLabelImageByFoodIdAsync(ImageByFoodIdRequest1 request) => Channel.GetLabelImageByFoodIdAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ImageResponse1 ILabelImageService.GetBarcodeImageByUserCode(ImageByUserCodeRequest1 request) => Channel.GetBarcodeImageByUserCode(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<ImageResponse1> ILabelImageService.GetBarcodeImageByUserCodeAsync(ImageByUserCodeRequest1 request) => Channel.GetBarcodeImageByUserCodeAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<ImageResponse1> ILabelImageService.GetBarcodeImageByFoodIdAsync(ImageByFoodIdRequest1 request) => Channel.GetBarcodeImageByFoodIdAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        ImageResponse1 ILabelImageService.GetBarcodeImageByFoodId(ImageByFoodIdRequest1 request) => Channel.GetBarcodeImageByFoodId(request);

        public ImageResponse GetBarcodeImage(ImageRequest imageRequest)
        {
            var inValue = new ImageRequest1 {ImageRequest = imageRequest};
            var retVal = ((ILabelImageService)this).GetBarcodeImage(inValue);
            return retVal.ImageResponse;
        }

        public async Task<ImageResponse> GetBarcodeImageAsync(ImageRequest imageRequest)
        {
            var inValue = new ImageRequest1 {ImageRequest = imageRequest};
            var retVal = await ((ILabelImageService)this).GetBarcodeImageAsync(inValue);
            return retVal.ImageResponse;
        }

        public ImageResponse GetLabelImage(ImageRequest imageRequest)
        {
            var inValue = new ImageRequest1 {ImageRequest = imageRequest};
            var retVal = ((ILabelImageService)this).GetLabelImage(inValue);
            return retVal.ImageResponse;
        }

        public async Task<ImageResponse> GetLabelImageAsync(ImageRequest imageRequest)
        {
            var inValue = new ImageRequest1 {ImageRequest = imageRequest};
            var retVal = await ((ILabelImageService)this).GetLabelImageAsync(inValue);
            return retVal.ImageResponse;
        }

        public ImageResponse GetBarcodeImageByFoodId(Guid foodId)
        {
            var inValue = new ImageByFoodIdRequest1 {ImageByFoodIdRequest = new ImageByFoodIdRequest {FoodId = foodId}};
            var retVal = ((ILabelImageService)(this)).GetBarcodeImageByFoodId(inValue);
            return retVal.ImageResponse;
        }

        public async Task<ImageResponse> GetBarcodeImageByFoodIdAsync(Guid foodId)
        {
            var inValue = new ImageByFoodIdRequest1 {ImageByFoodIdRequest =  new ImageByFoodIdRequest {FoodId = foodId}};
            var retVal = await ((ILabelImageService)(this)).GetBarcodeImageByFoodIdAsync(inValue);
            return retVal.ImageResponse;
        }

        public ImageResponse GetBarcodeImageByUserCode(String userCode)
        {
            var inValue = new ImageByUserCodeRequest1 {ImageByUserCodeRequest = new ImageByUserCodeRequest {UserCode = userCode}};
            var retVal = ((ILabelImageService)(this)).GetBarcodeImageByUserCode(inValue);
            return retVal.ImageResponse;
        }

        public async Task<ImageResponse> GetBarcodeImageByUserCodeAsync(String userCode)
        {
            var inValue = new ImageByUserCodeRequest1 {ImageByUserCodeRequest = new ImageByUserCodeRequest {UserCode = userCode}};
            var retVal = await ((ILabelImageService)(this)).GetBarcodeImageByUserCodeAsync(inValue);
            return retVal.ImageResponse;
        }

        public ImageResponse GetLabelImageByFoodId(Guid foodId)
        {
            var inValue = new ImageByFoodIdRequest1 {ImageByFoodIdRequest =  new ImageByFoodIdRequest {FoodId = foodId}};
            var retVal = ((ILabelImageService)(this)).GetLabelImageByFoodId(inValue);
            return retVal.ImageResponse;
        }

        public async Task<ImageResponse> GetLabelImageByFoodIdAsync(Guid foodId)
        {
            var inValue = new ImageByFoodIdRequest1 {ImageByFoodIdRequest =  new ImageByFoodIdRequest {FoodId = foodId}};
            var retVal = await ((ILabelImageService)(this)).GetLabelImageByFoodIdAsync(inValue);
            return retVal.ImageResponse;
        }

        public ImageResponse GetLabelImageByUserCode(String userCode)
        {
            var inValue = new ImageByUserCodeRequest1 {ImageByUserCodeRequest = new ImageByUserCodeRequest {UserCode = userCode}};
            var retVal = ((ILabelImageService)(this)).GetLabelImageByUserCode(inValue);
            return retVal.ImageResponse;
        }

        public async Task<ImageResponse> GetLabelImageByUserCodeAsync(String userCode)
        {
            var inValue = new ImageByUserCodeRequest1 {ImageByUserCodeRequest = new ImageByUserCodeRequest {UserCode = userCode}};
            var retVal = await ((ILabelImageService)(this)).GetLabelImageByUserCodeAsync(inValue);
            return retVal.ImageResponse;
        }
    }
}