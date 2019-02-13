using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class CompositeIngredientEditDto
    {
        private CompositeIngredientDto _compositeIngredientField;
        private EditDetailsDto _editDetailsField;

        /// <remarks />
        public CompositeIngredientDto CompositeIngredient
        {
            get => _compositeIngredientField;
            set => _compositeIngredientField = value;
        }

        /// <remarks />
        public EditDetailsDto EditDetails
        {
            get => _editDetailsField;
            set => _editDetailsField = value;
        }
    }
}