﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Threading.Tasks;
using Esha.Genesis.Services.Client.Internal;

namespace Esha.Genesis.Services.Client
{
    [DebuggerStepThrough]
    public class FoodEditServiceClient : ClientBase<Internal.IFoodEditService>, Internal.IFoodEditService, IFoodEditService
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
        NewFoodResponse1 Internal.IFoodEditService.NewFood(NewFoodRequest1 request) => Channel.NewFood(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<NewFoodResponse1> Internal.IFoodEditService.NewFoodAsync(NewFoodRequest1 request) => Channel.NewFoodAsync(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        UpdateFoodResponse1 Internal.IFoodEditService.UpdateFood(UpdateFoodRequest1 request) => Channel.UpdateFood(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<UpdateFoodResponse1> Internal.IFoodEditService.UpdateFoodAsync(UpdateFoodRequest1 request) => Channel.UpdateFoodAsync(request);

        public NewFoodResponse NewFood(NewFoodRequest newFoodRequest)
        {
            var inValue = new NewFoodRequest1 {NewFoodRequest = newFoodRequest};
            var retVal = ((Internal.IFoodEditService)this).NewFood(inValue);
            return retVal.NewFoodResponse;
        }

        public async Task<NewFoodResponse> NewFoodAsync(NewFoodRequest newFoodRequest)
        {
            var inValue = new NewFoodRequest1 {NewFoodRequest = newFoodRequest};
            var retVal = await ((Internal.IFoodEditService)this).NewFoodAsync(inValue);
            return retVal.NewFoodResponse;
        }

        public UpdateFoodResponse UpdateFood(UpdateFoodRequest updateFoodRequest)
        {
            var inValue = new UpdateFoodRequest1 {UpdateFoodRequest = updateFoodRequest};
            var retVal = ((Internal.IFoodEditService)this).UpdateFood(inValue);
            return retVal.UpdateFoodResponse;
        }

        public async Task<UpdateFoodResponse> UpdateFoodAsync(UpdateFoodRequest updateFoodRequest)
        {
            var inValue = new UpdateFoodRequest1 {UpdateFoodRequest = updateFoodRequest};
            var retVal = await ((Internal.IFoodEditService)this).UpdateFoodAsync(inValue);
            return retVal.UpdateFoodResponse;
        }
    }
}