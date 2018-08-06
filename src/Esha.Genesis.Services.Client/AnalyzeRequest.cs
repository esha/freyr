using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class AnalyzeRequest
    {
        private RecipeDto _recipeField;

        [XmlElement]
        public RecipeDto Recipe
        {
            get => _recipeField;
            set => _recipeField = value;
        }
    }
}
