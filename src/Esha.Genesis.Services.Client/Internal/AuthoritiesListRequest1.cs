using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class AuthoritiesListRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public AuthoritiesListRequest AuthoritiesListRequest;

        public AuthoritiesListRequest1()
        {
        }

        public AuthoritiesListRequest1(AuthoritiesListRequest authoritiesListRequest) => AuthoritiesListRequest = authoritiesListRequest;
    }
}