using System;
using System.CodeDom.Compiler;
using System.ServiceModel;
using System.Threading.Tasks;

namespace Esha.Genesis.Services.Client
{
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(Namespace = "http://ns.esha.com/2013/genesisapi", ConfigurationName = "Esha.Genesis.Services.Client.IFoodEditService")]
    public interface IFoodEditService
    {
        // CODEGEN: Generating message contract since the operation NewFood is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/newfood", ReplyAction = "http://ns.esha.com/2013/genesisapi/newfoodresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        NewFoodResponse1 NewFood(NewFoodRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/newfood", ReplyAction = "http://ns.esha.com/2013/genesisapi/newfoodresponse")]
        Task<NewFoodResponse1> NewFoodAsync(NewFoodRequest1 request);

        // CODEGEN: Generating message contract since the operation UpdateFood is neither RPC nor document wrapped.
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/updatefood", ReplyAction = "http://ns.esha.com/2013/genesisapi/updatefoodresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        UpdateFoodResponse1 UpdateFood(UpdateFoodRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/updatefood", ReplyAction = "http://ns.esha.com/2013/genesisapi/updatefoodresponse")]
        Task<UpdateFoodResponse1> UpdateFoodAsync(UpdateFoodRequest1 request);
    }
}