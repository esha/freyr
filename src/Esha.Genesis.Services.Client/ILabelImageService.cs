using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Esha.Genesis.Services.Client
{
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(Namespace = "http://ns.esha.com/2013/genesisapi/label/image", ConfigurationName = "Esha.Genesis.Services.Client.ILabelImageService")]
    public interface ILabelImageService
    {
        // CODEGEN: Generating message contract since the operation GetBarcodeImage is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/label/image/getbarcodeimage",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/label/image/getbarcodeimageresponse")]
        [XmlSerializerFormat]
        ImageResponse1 GetBarcodeImage(ImageRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/label/image/getbarcodeimage",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/label/image/getbarcodeimageresponse")]
        Task<ImageResponse1> GetBarcodeImageAsync(ImageRequest1 request);

        // CODEGEN: Generating message contract since the operation GetLabelImage is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/label/image/getlabelimage",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/label/image/getlabelimageresponse")]
        [XmlSerializerFormat]
        ImageResponse1 GetLabelImage(ImageRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/label/image/getlabelimage",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/label/image/getlabelimageresponse")]
        Task<ImageResponse1> GetLabelImageAsync(ImageRequest1 request);

        // CODEGEN: Generating message contract since the operation GetLabelImageByFoodId is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/label/image/getlabelimagebyfoodid",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/label/image/getlabelimagebyfoodidresponse")]
        [XmlSerializerFormat]
        ImageResponse1 GetLabelImageByFoodId(ImageByFoodIdRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/label/image/getlabelimagebyfoodid",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/label/image/getlabelimagebyfoodidresponse")]
        Task<ImageResponse1> GetLabelImageByFoodIdAsync(ImageByFoodIdRequest1 request);

        // CODEGEN: Generating message contract since the operation GetLabelImageByUserCode is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/label/image/getlabelimagebyusercode",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/label/image/getlabelimagebyusercoderesponse")]
        [XmlSerializerFormat]
        ImageResponse1 GetLabelImageByUserCode(ImageByUserCodeRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/label/image/getlabelimagebyusercode",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/label/image/getlabelimagebyusercoderesponse")]
        Task<ImageResponse1> GetLabelImageByUserCodeAsync(ImageByUserCodeRequest1 request);

        // CODEGEN: Generating message contract since the operation GetBarcodeImageByFoodId is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/label/image/getbarcodeimagebyfoodid", ReplyAction = "http://ns.esha.com/2013/genesisapi/label/image/getbarcodeimagebyfoodidresponse")]
        [XmlSerializerFormat]
        ImageResponse1 GetBarcodeImageByFoodId(ImageByFoodIdRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/label/image/getbarcodeimagebyfoodid", ReplyAction = "http://ns.esha.com/2013/genesisapi/label/image/getbarcodeimagebyfoodidresponse")]
        Task<ImageResponse1> GetBarcodeImageByFoodIdAsync(ImageByFoodIdRequest1 request);

        // CODEGEN: Generating message contract since the operation GetBarcodeImageByUserCode is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/label/image/getbarcodeimagebyusercode", ReplyAction = "http://ns.esha.com/2013/genesisapi/label/image/getbarcodeimagebyusercoderesponse")]
        [XmlSerializerFormat]
        ImageResponse1 GetBarcodeImageByUserCode(ImageByUserCodeRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/label/image/getbarcodeimagebyusercode", ReplyAction = "http://ns.esha.com/2013/genesisapi/label/image/getbarcodeimagebyusercoderesponse")]
        Task<ImageResponse1> GetBarcodeImageByUserCodeAsync(ImageByUserCodeRequest1 request);
    }
}