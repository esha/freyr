﻿using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class ImageResponse1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi", Order = 0)]
        public ImageResponse ImageResponse;

        public ImageResponse1()
        {
        }

        public ImageResponse1(ImageResponse imageResponse) => ImageResponse = imageResponse;
    }
}