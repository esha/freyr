using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Esha.Genesis.Services.Client
{
    public interface IFoodBuilderService
    {
        AnalyzeResponse Analyze(AnalyzeRequest analyzeRequest);
        Task<AnalyzeResponse> AnalyzeAsync(AnalyzeRequest analyzeRequest);
    }
}
