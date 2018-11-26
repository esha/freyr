using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class RecommendationProfilesListResponse1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public RecommendationProfilesListResponse RecommendationProfilesListResponse;

        public RecommendationProfilesListResponse1()
        {
        }

        public RecommendationProfilesListResponse1(RecommendationProfilesListResponse recommendationProfilesListResponse) =>
            RecommendationProfilesListResponse = recommendationProfilesListResponse;
    }
}