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
    public class ImageModelDto
    {
        private Byte[] _dataField;

        private Boolean _isDefaultField;

        /// <remarks />
        [XmlElement(DataType = "base64Binary")]
        public Byte[] Data
        {
            get => _dataField;
            set => _dataField = value;
        }

        /// <remarks />
        [XmlAttribute]
        public Boolean IsDefault
        {
            get => _isDefaultField;
            set => _isDefaultField = value;
        }
    }
}