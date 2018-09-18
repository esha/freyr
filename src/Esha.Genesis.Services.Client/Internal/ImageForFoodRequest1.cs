using System;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class ImageForFoodRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public ImageForFoodRequest ImageForFoodRequest;

        public ImageForFoodRequest1()
        {
        }

        public ImageForFoodRequest1(ImageForFoodRequest imageForFoodRequest) => ImageForFoodRequest = imageForFoodRequest;
    }
}