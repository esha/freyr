using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client 
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class ImageByFoodIdRequest1 
    {

        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi/label/image", Order = 0)]
        public ImageByFoodIdRequest ImageByFoodIdRequest;

        public ImageByFoodIdRequest1() {
        }

        public ImageByFoodIdRequest1(ImageByFoodIdRequest imageByFoodIdRequest) => ImageByFoodIdRequest = imageByFoodIdRequest;
    }
}
