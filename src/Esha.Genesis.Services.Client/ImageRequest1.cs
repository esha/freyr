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
    public class ImageRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi/label/image", Order = 0)]
        public ImageRequest ImageRequest;

        public ImageRequest1()
        {
        }

        public ImageRequest1(ImageRequest imageRequest) => ImageRequest = imageRequest;
    }
}