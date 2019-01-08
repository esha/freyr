using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class RecipeEditDto
    {
        private EditDetailsDto _editDetailsField;
        private LabelProfileDto _labelProfileField;
        private RecipeDto _recipeField;

        /// <remarks />
        public RecipeDto Recipe
        {
            get => _recipeField;
            set => _recipeField = value;
        }

        /// <remarks />
        public LabelProfileDto LabelProfile
        {
            get => _labelProfileField;
            set => _labelProfileField = value;
        }

        /// <remarks />
        public EditDetailsDto EditDetails
        {
            get => _editDetailsField;
            set => _editDetailsField = value;
        }
    }
}