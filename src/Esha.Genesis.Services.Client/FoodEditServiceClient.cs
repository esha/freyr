using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;

namespace Esha.Genesis.Services.Client
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public class FoodEditServiceClient : ClientBase<IFoodEditService>, IFoodEditService
    {
        public FoodEditServiceClient()
        {
        }

        public FoodEditServiceClient(String endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public FoodEditServiceClient(String endpointConfigurationName, String remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public FoodEditServiceClient(String endpointConfigurationName, EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public FoodEditServiceClient(Binding binding, EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        NewFoodResponse1 IFoodEditService.NewFood(NewFoodRequest1 request) => Channel.NewFood(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<NewFoodResponse1> IFoodEditService.NewFoodAsync(NewFoodRequest1 request) => Channel.NewFoodAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        UpdateFoodResponse1 IFoodEditService.UpdateFood(UpdateFoodRequest1 request) => Channel.UpdateFood(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<UpdateFoodResponse1> IFoodEditService.UpdateFoodAsync(UpdateFoodRequest1 request) => Channel.UpdateFoodAsync(request);

        public NewFoodResponse NewFood(NewFoodRequest newFoodRequest)
        {
            var inValue = new NewFoodRequest1 {NewFoodRequest = newFoodRequest};
            var retVal = ((IFoodEditService)this).NewFood(inValue);
            return retVal.NewFoodResponse;
        }

        public async Task<NewFoodResponse> NewFoodAsync(NewFoodRequest newFoodRequest)
        {
            var inValue = new NewFoodRequest1 {NewFoodRequest = newFoodRequest};
            var retVal = await ((IFoodEditService)this).NewFoodAsync(inValue);
            return retVal.NewFoodResponse;
        }

        public UpdateFoodResponse UpdateFood(UpdateFoodRequest updateFoodRequest)
        {
            var inValue = new UpdateFoodRequest1 {UpdateFoodRequest = updateFoodRequest};
            var retVal = ((IFoodEditService)this).UpdateFood(inValue);
            return retVal.UpdateFoodResponse;
        }

        public async Task<UpdateFoodResponse> UpdateFoodAsync(UpdateFoodRequest updateFoodRequest)
        {
            var inValue = new UpdateFoodRequest1 {UpdateFoodRequest = updateFoodRequest};
            var retVal = await ((IFoodEditService)this).UpdateFoodAsync(inValue);
            return retVal.UpdateFoodResponse;
        }
    }
}