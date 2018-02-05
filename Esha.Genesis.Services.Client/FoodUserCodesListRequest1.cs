using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class FoodUserCodesListRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public FoodUserCodesListRequest FoodUserCodesListRequest;

        public FoodUserCodesListRequest1()
        {
        }

        public FoodUserCodesListRequest1(FoodUserCodesListRequest foodUserCodesListRequest) => FoodUserCodesListRequest = foodUserCodesListRequest;
    }
}