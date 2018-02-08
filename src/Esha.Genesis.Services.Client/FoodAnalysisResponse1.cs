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
    public class FoodAnalysisResponse1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public FoodAnalysisResponse FoodAnalysisResponse;

        public FoodAnalysisResponse1()
        {
        }

        public FoodAnalysisResponse1(FoodAnalysisResponse foodAnalysisResponse) => FoodAnalysisResponse = foodAnalysisResponse;
    }
}