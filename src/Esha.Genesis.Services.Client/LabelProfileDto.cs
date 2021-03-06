﻿using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class LabelProfileDto
    {
        private GlobalString[] _alternateHeadingField;

        private AuthorityDto _authorityField;

        private LabelFormat _labelFormat;

        private LabelStyle _labelStyleField;

        private Guid _recommendationProfileIdField;

        private GlobalString[] _servingSizeField;

        private GlobalString[] _servingsPerContainerField;

        /// <remarks />
        public AuthorityDto Authority
        {
            get => _authorityField;
            set => _authorityField = value;
        }

        /// <remarks />
        public Guid RecommendationProfileId
        {
            get => _recommendationProfileIdField;
            set => _recommendationProfileIdField = value;
        }

        /// <remarks />
        public LabelStyle LabelStyle
        {
            get => _labelStyleField;
            set => _labelStyleField = value;
        }

        /// <remarks />
        public LabelFormat LabelFormat
        {
            get => _labelFormat;
            set => _labelFormat = value;
        }

        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] AlternateHeading
        {
            get => _alternateHeadingField;
            set => _alternateHeadingField = value;
        }

        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] ServingSize
        {
            get => _servingSizeField;
            set => _servingSizeField = value;
        }

        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] ServingsPerContainer
        {
            get => _servingsPerContainerField;
            set => _servingsPerContainerField = value;
        }
    }
}