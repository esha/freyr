using System;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class RecommendationProfilesListRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public RecommendationProfilesListRequest RecommendationProfilesListRequest;

        public RecommendationProfilesListRequest1()
        {
        }

        public RecommendationProfilesListRequest1(RecommendationProfilesListRequest recommendationProfilesListRequest) =>
            RecommendationProfilesListRequest = recommendationProfilesListRequest;
    }
}