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
    public class PersonDto : ConsumerDto
    {
        private String _addressLine1Field;

        private String _addressLine2Field;

        private String _allergiesField;

        private String _cityField;

        private String _countryField;

        private Double? _desiredWeightKilogramsField;

        private String _dietaryRestrictionsField;

        private String _familyNameField;

        private String _faxNumberField;

        private String _givenNameField;

        private String _phoneNumberField;

        private String _physiciansField;

        private String _postalCodeField;

        private Double? _ratePerWeekKilogramsField;

        private String _stateField;

        /// <remarks />
        [XmlElement]
        public String GivenName
        {
            get => _givenNameField;
            set => _givenNameField = value;
        }

        /// <remarks />
        [XmlElement]
        public String FamilyName
        {
            get => _familyNameField;
            set => _familyNameField = value;
        }

        /// <remarks />
        [XmlElement]
        public String AddressLine1
        {
            get => _addressLine1Field;
            set => _addressLine1Field = value;
        }

        /// <remarks />
        [XmlElement]
        public String AddressLine2
        {
            get => _addressLine2Field;
            set => _addressLine2Field = value;
        }

        /// <remarks />
        [XmlElement]
        public String Country
        {
            get => _countryField;
            set => _countryField = value;
        }

        /// <remarks />
        [XmlElement]
        public String PhoneNumber
        {
            get => _phoneNumberField;
            set => _phoneNumberField = value;
        }

        /// <remarks />
        [XmlElement]
        public String FaxNumber
        {
            get => _faxNumberField;
            set => _faxNumberField = value;
        }

        /// <remarks />
        [XmlElement]
        public String Allergies
        {
            get => _allergiesField;
            set => _allergiesField = value;
        }

        /// <remarks />
        [XmlElement]
        public String City
        {
            get => _cityField;
            set => _cityField = value;
        }

        /// <remarks />
        [XmlElement]
        public String State
        {
            get => _stateField;
            set => _stateField = value;
        }

        /// <remarks />
        [XmlElement]
        public String PostalCode
        {
            get => _postalCodeField;
            set => _postalCodeField = value;
        }

        /// <remarks />
        [XmlElement]
        public String Physicians
        {
            get => _physiciansField;
            set => _physiciansField = value;
        }

        /// <remarks />
        [XmlElement]
        public String DietaryRestrictions
        {
            get => _dietaryRestrictionsField;
            set => _dietaryRestrictionsField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Double? DesiredWeightKilograms
        {
            get => _desiredWeightKilogramsField;
            set => _desiredWeightKilogramsField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Double? RatePerWeekKilograms
        {
            get => _ratePerWeekKilogramsField;
            set => _ratePerWeekKilogramsField = value;
        }
    }
}