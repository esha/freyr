using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class UnitListResponse1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public UnitListResponse UnitListResponse;

        public UnitListResponse1()
        {
        }

        public UnitListResponse1(UnitListResponse unitListResponse) => UnitListResponse = unitListResponse;
    }
}