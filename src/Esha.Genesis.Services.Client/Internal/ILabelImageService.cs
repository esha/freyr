using System.ServiceModel;
using System.Threading.Tasks;

namespace Esha.Genesis.Services.Client.Internal
{
    [ServiceContract(Namespace = "http://ns.esha.com/2013/genesisapi", ConfigurationName = "Esha.Genesis.Services.Client.ILabelImageService")]
    public interface ILabelImageService
    {
        // CODEGEN: Generating message contract since the operation GetBarcodeImage is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getbarcodeimage",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getbarcodeimageresponse")]
        [XmlSerializerFormat]
        ImageResponse1 GetBarcodeImage(ImageRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getbarcodeimage",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getbarcodeimageresponse")]
        Task<ImageResponse1> GetBarcodeImageAsync(ImageRequest1 request);

        // CODEGEN: Generating message contract since the operation GetLabelImage is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getlabelimage",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getlabelimageresponse")]
        [XmlSerializerFormat]
        ImageResponse1 GetLabelImage(ImageRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getlabelimage",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getlabelimageresponse")]
        Task<ImageResponse1> GetLabelImageAsync(ImageRequest1 request);

        // CODEGEN: Generating message contract since the operation GetLabelImageByFoodId is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getlabelimagebyfoodid",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getlabelimagebyfoodidresponse")]
        [XmlSerializerFormat]
        ImageResponse1 GetLabelImageByFoodId(ImageByFoodIdRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getlabelimagebyfoodid",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getlabelimagebyfoodidresponse")]
        Task<ImageResponse1> GetLabelImageByFoodIdAsync(ImageByFoodIdRequest1 request);

        // CODEGEN: Generating message contract since the operation GetLabelImageByUserCode is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getlabelimagebyusercode",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getlabelimagebyusercoderesponse")]
        [XmlSerializerFormat]
        ImageResponse1 GetLabelImageByUserCode(ImageByUserCodeRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getlabelimagebyusercode",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getlabelimagebyusercoderesponse")]
        Task<ImageResponse1> GetLabelImageByUserCodeAsync(ImageByUserCodeRequest1 request);

        // CODEGEN: Generating message contract since the operation GetBarcodeImageByFoodId is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getbarcodeimagebyfoodid",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getbarcodeimagebyfoodidresponse")]
        [XmlSerializerFormat]
        ImageResponse1 GetBarcodeImageByFoodId(ImageByFoodIdRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getbarcodeimagebyfoodid",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getbarcodeimagebyfoodidresponse")]
        Task<ImageResponse1> GetBarcodeImageByFoodIdAsync(ImageByFoodIdRequest1 request);

        // CODEGEN: Generating message contract since the operation GetBarcodeImageByUserCode is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getbarcodeimagebyusercode",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getbarcodeimagebyusercoderesponse")]
        [XmlSerializerFormat]
        ImageResponse1 GetBarcodeImageByUserCode(ImageByUserCodeRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getbarcodeimagebyusercode",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getbarcodeimagebyusercoderesponse")]
        Task<ImageResponse1> GetBarcodeImageByUserCodeAsync(ImageByUserCodeRequest1 request);

        // CODEGEN: Generating message contract since the operation GetBarcodeImageByUserCode is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getlabelimageforfood",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getlabelimageforfoodresponse")]
        [XmlSerializerFormat]
        ImageResponse1 GetLabelImageForFood(ImageForFoodRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/getlabelimageforfood",
            ReplyAction = "http://ns.esha.com/2013/genesisapi/getlabelimageforfoodresponse")]
        Task<ImageResponse1> GetLabelImageForFoodAsync(ImageForFoodRequest1 request);
    }
}