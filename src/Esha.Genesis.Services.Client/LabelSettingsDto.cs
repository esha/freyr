using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class LabelSettingsDto : EshaDto
    {
        private String _amountColumnJustificationField;

        private Boolean _amountHeaderInColumnField;

        private Boolean _amountInColumnField;

        private Int32 _amountWidthField;

        private String _columnJustificationField;

        private String _fontFamilyField;

        private Int32 _fontSizeField;

        private Int32 _footnoteFontSizeField;

        private Int32 _headerFontSizeField;

        private Int32 _heavyBarSizeField;

        private Int32 _heightField;

        private Boolean _hyphenationField;

        private Int32 _indentSizeField;

        private Boolean _isLinearField;

        private Boolean _isTemplateField;

        private Int32 _lightBarSizeField;

        private Boolean _linearJustifyField;

        private String _nameField;

        private Int32 _nameWidthField;

        private Boolean _optimalParagraphField;

        private String _titleField;

        private Boolean _useAbbreviationsField;

        private Boolean _useBoldField;

        private Int32 _widthField;

        /// <remarks />
        [XmlElement]
        public Boolean AmountHeaderInColumn
        {
            get => _amountHeaderInColumnField;
            set => _amountHeaderInColumnField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32 NameWidth
        {
            get => _nameWidthField;
            set => _nameWidthField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32 AmountWidth
        {
            get => _amountWidthField;
            set => _amountWidthField = value;
        }

        /// <remarks />
        [XmlElement]
        public String AmountColumnJustification
        {
            get => _amountColumnJustificationField;
            set => _amountColumnJustificationField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32 HeavyBarSize
        {
            get => _heavyBarSizeField;
            set => _heavyBarSizeField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32 LightBarSize
        {
            get => _lightBarSizeField;
            set => _lightBarSizeField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32 IndentSize
        {
            get => _indentSizeField;
            set => _indentSizeField = value;
        }

        /// <remarks />
        [XmlElement]
        public Boolean AmountInColumn
        {
            get => _amountInColumnField;
            set => _amountInColumnField = value;
        }

        /// <remarks />
        [XmlElement]
        public String ColumnJustification
        {
            get => _columnJustificationField;
            set => _columnJustificationField = value;
        }

        /// <remarks />
        [XmlElement]
        public Boolean UseAbbreviations
        {
            get => _useAbbreviationsField;
            set => _useAbbreviationsField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32 Width
        {
            get => _widthField;
            set => _widthField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32 Height
        {
            get => _heightField;
            set => _heightField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32 FontSize
        {
            get => _fontSizeField;
            set => _fontSizeField = value;
        }

        /// <remarks />
        [XmlElement]
        public String FontFamily
        {
            get => _fontFamilyField;
            set => _fontFamilyField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32 FootnoteFontSize
        {
            get => _footnoteFontSizeField;
            set => _footnoteFontSizeField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32 HeaderFontSize
        {
            get => _headerFontSizeField;
            set => _headerFontSizeField = value;
        }

        /// <remarks />
        [XmlElement]
        public Boolean IsLinear
        {
            get => _isLinearField;
            set => _isLinearField = value;
        }

        /// <remarks />
        [XmlElement]
        public Boolean UseBold
        {
            get => _useBoldField;
            set => _useBoldField = value;
        }

        /// <remarks />
        [XmlElement]
        public Boolean OptimalParagraph
        {
            get => _optimalParagraphField;
            set => _optimalParagraphField = value;
        }

        /// <remarks />
        [XmlElement]
        public Boolean Hyphenation
        {
            get => _hyphenationField;
            set => _hyphenationField = value;
        }

        /// <remarks />
        [XmlElement]
        public String Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlElement]
        public String Title
        {
            get => _titleField;
            set => _titleField = value;
        }

        /// <remarks />
        [XmlElement]
        public Boolean IsTemplate
        {
            get => _isTemplateField;
            set => _isTemplateField = value;
        }

        /// <remarks />
        [XmlElement]
        public Boolean LinearJustify
        {
            get => _linearJustifyField;
            set => _linearJustifyField = value;
        }
    }
}