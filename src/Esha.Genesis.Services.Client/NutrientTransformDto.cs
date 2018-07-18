using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class NutrientTransformDto : EshaDto
    {
        private GlobalString[] _nameField;

        private QuantityDto _scalarTransformField;

        private Guid[] _transformIdsField;

        private NutrientTransformType _transformTypeField;

        private NutrientQuantityDto[] _vectorTransformField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlElement]
        public NutrientTransformType TransformType
        {
            get => _transformTypeField;
            set => _transformTypeField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto ScalarTransform
        {
            get => _scalarTransformField;
            set => _scalarTransformField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("ChildTransformId", IsNullable = false)]
        public Guid[] TransformIds
        {
            get => _transformIdsField;
            set => _transformIdsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("TransformElement")]
        public NutrientQuantityDto[] VectorTransform
        {
            get => _vectorTransformField;
            set => _vectorTransformField = value;
        }
    }
}