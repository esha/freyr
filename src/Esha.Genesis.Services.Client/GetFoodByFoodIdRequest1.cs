﻿using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client {
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class GetFoodByFoodIdRequest1 
    {

        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi", Order = 0)]
        public GetFoodByFoodIdRequest GetFoodByFoodIdRequest;

        public GetFoodByFoodIdRequest1() {
        }

        public GetFoodByFoodIdRequest1(GetFoodByFoodIdRequest getFoodByFoodIdRequest) => GetFoodByFoodIdRequest = getFoodByFoodIdRequest;
    }
}
