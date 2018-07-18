using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class AuthoritiesListResponse1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public AuthoritiesListResponse AuthoritiesListResponse;

        public AuthoritiesListResponse1()
        {
        }

        public AuthoritiesListResponse1(AuthoritiesListResponse authoritiesListResponse) => AuthoritiesListResponse = authoritiesListResponse;
    }
}