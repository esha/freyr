﻿using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class FoodsByPropertyRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public FoodsByPropertyRequest FoodsByPropertyRequest;

        public FoodsByPropertyRequest1()
        {
        }

        public FoodsByPropertyRequest1(FoodsByPropertyRequest foodsByPropertyRequest) => FoodsByPropertyRequest = foodsByPropertyRequest;
    }
}