using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;
using System.Text;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class AnalyzeResponse1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public AnalyzeResponse AnalyzeResponse;

        public AnalyzeResponse1()
        {
        }

        public AnalyzeResponse1(AnalyzeResponse analyzeResponse) => AnalyzeResponse = analyzeResponse;
    }
}
