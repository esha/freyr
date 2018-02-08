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
    public class FoodMetadataResponse1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public FoodMetadataResponse FoodMetadataResponse;

        public FoodMetadataResponse1()
        {
        }

        public FoodMetadataResponse1(FoodMetadataResponse foodMetadataResponse) => FoodMetadataResponse = foodMetadataResponse;
    }
}