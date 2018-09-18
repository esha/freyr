using System;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class UnitListRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public UnitListRequest UnitListRequest;

        public UnitListRequest1()
        {
        }

        public UnitListRequest1(UnitListRequest unitListRequest) => UnitListRequest = unitListRequest;
    }
}