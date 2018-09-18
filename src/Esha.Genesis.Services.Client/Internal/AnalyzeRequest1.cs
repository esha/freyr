using System;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class AnalyzeRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public AnalyzeRequest AnalyzeRequest;

        public AnalyzeRequest1()
        {
        }

        public AnalyzeRequest1(AnalyzeRequest analyzeRequest) => AnalyzeRequest = analyzeRequest;
    }
}