using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class MealDto : FoodDto
    {
        private Int32? _legacyPositionField;

        private MealTypeDto _mealTypeField;

        /// <remarks />
        [XmlElement]
        public MealTypeDto MealType
        {
            get => _mealTypeField;
            set => _mealTypeField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? LegacyPosition
        {
            get => _legacyPositionField;
            set => _legacyPositionField = value;
        }
    }
}