﻿using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client 
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped=false)]
    public class ImageByUserCodeRequest1
    {
        
        [MessageBodyMember(Namespace="http://ns.esha.com/2013/genesisapi/label/image", Order=0)]
        public ImageByUserCodeRequest ImageByUserCodeRequest;
        
        public ImageByUserCodeRequest1()
        {
        }
        
        public ImageByUserCodeRequest1(ImageByUserCodeRequest imageByUserCodeRequest) => ImageByUserCodeRequest = imageByUserCodeRequest;
    }
}
