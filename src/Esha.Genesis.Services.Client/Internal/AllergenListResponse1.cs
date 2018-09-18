﻿using System;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class AllergenListResponse1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public AllergenListResponse AllergenListResponse;

        public AllergenListResponse1()
        {
        }

        public AllergenListResponse1(AllergenListResponse allergenListResponse) => AllergenListResponse = allergenListResponse;
    }
}