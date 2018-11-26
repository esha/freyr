using System.ServiceModel;
using System.Threading.Tasks;

namespace Esha.Genesis.Services.Client.Internal
{
    [ServiceContract(Namespace = "http://ns.esha.com/2013/genesisapi", ConfigurationName = "Esha.Genesis.Services.Client.IFoodBuilderService")]
    public interface IFoodBuilderService
    {
        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/analyze", ReplyAction = "http://ns.esha.com/2013/genesisapi/analyzeresponse")]
        [XmlSerializerFormat]
        [ServiceKnownType(typeof(EshaDto))]
        AnalyzeResponse1 Analyze(AnalyzeRequest1 request);

        [OperationContract(Action = "http://ns.esha.com/2013/genesisapi/analyze", ReplyAction = "http://ns.esha.com/2013/genesisapi/analyzeresponse")]
        Task<AnalyzeResponse1> AnalyzeAsync(AnalyzeRequest1 request);
    }
}