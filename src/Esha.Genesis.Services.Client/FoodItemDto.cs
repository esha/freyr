using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [XmlInclude(typeof(SupplementFoodItemDto))]
    [XmlInclude(typeof(PureFoodItemDto))]
    [XmlInclude(typeof(SupplementFormulaFoodItemDto))]
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class FoodItemDto
    {
        private AmountDto _amountField;

        private Guid _foodIdField;

        private String _noteField;

        /// <remarks />
        [XmlElement]
        public Guid FoodId
        {
            get => _foodIdField;
            set => _foodIdField = value;
        }

        /// <remarks />
        [XmlElement]
        public AmountDto Amount
        {
            get => _amountField;
            set => _amountField = value;
        }

        /// <remarks />
        [XmlElement]
        public String Note
        {
            get => _noteField;
            set => _noteField = value;
        }
    }
}