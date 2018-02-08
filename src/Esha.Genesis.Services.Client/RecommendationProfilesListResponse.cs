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
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class RecommendationProfilesListResponse
    {
        private RecommendationProfileDto[] _recommendationProfilesField;

        private String _responseVersionField;

        private ResultStatus _statusField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("RecommendationProfile")]
        public RecommendationProfileDto[] RecommendationProfiles
        {
            get => _recommendationProfilesField;
            set => _recommendationProfilesField = value;
        }

        /// <remarks />
        [XmlElement]
        public ResultStatus Status
        {
            get => _statusField;
            set => _statusField = value;
        }

        /// <remarks />
        [XmlElement]
        public String ResponseVersion
        {
            get => _responseVersionField;
            set => _responseVersionField = value;
        }
    }
}