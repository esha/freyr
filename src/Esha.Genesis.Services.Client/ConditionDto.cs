﻿using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class ConditionDto : EshaDto
    {
        private String _claimField;

        private Guid[] _nutrientIdsField;

        /// <remarks />
        [XmlElement]
        public String Claim
        {
            get => _claimField;
            set => _claimField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Id", IsNullable = false)]
        public Guid[] NutrientIds
        {
            get => _nutrientIdsField;
            set => _nutrientIdsField = value;
        }
    }
}