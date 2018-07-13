﻿using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough()]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class FoodsSearchRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public FoodsSearchRequest FoodsSearchRequest;

        public FoodsSearchRequest1()
        {
        }

        public FoodsSearchRequest1(FoodsSearchRequest foodsSearchRequest) => FoodsSearchRequest = foodsSearchRequest;
    }
}
