using System;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class NutrientListResponse1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public NutrientListResponse NutrientListResponse;

        public NutrientListResponse1()
        {
        }

        public NutrientListResponse1(NutrientListResponse nutrientListResponse) => NutrientListResponse = nutrientListResponse;
    }
}