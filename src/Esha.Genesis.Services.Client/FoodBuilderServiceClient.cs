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
    public class FoodBuilderServiceClient : ClientBase<IFoodBuilderService>, IFoodBuilderService
    {
        public FoodBuilderServiceClient()
        {
        }

        public FoodBuilderServiceClient(String endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public FoodBuilderServiceClient(String endpointConfigurationName, String remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public FoodBuilderServiceClient(String endpointConfigurationName, EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public FoodBuilderServiceClient(Binding binding, EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        AnalyzeResponse1 IFoodBuilderService.Analyze(AnalyzeRequest1 request) => Channel.Analyze(request);

        [EditorBrowsable(EditorBrowsableState.Advanced)]
        Task<AnalyzeResponse1> IFoodBuilderService.AnalyzeAsync(AnalyzeRequest1 request) => Channel.AnalyzeAsync(request);

        public AnalyzeResponse Analyze(AnalyzeRequest analyzeRequest)
        {
            var inValue = new AnalyzeRequest1 {AnalyzeRequest = analyzeRequest};
            var retVal = ((IFoodBuilderService)this).Analyze(inValue);
            return retVal.AnalyzeResponse;
        }

        public async Task<AnalyzeResponse> AnalyzeAsync(AnalyzeRequest analyzeRequest)
        {
            var inValue = new AnalyzeRequest1 {AnalyzeRequest = analyzeRequest};
            var retVal = await ((IFoodBuilderService)this).AnalyzeAsync(inValue);
            return retVal.AnalyzeResponse;
        }
    }
}