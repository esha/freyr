using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    [Serializable]
    [XmlRoot(Namespace = "http://ns.esha.com/2013/exlx")]
    public class PropertyValuesCollectionDto : IXmlSerializable
    {
        private List<KeyValuePair<PropertyDto, Object>> _values;

        public List<KeyValuePair<PropertyDto, Object>> Values
        {
            get => _values;
            set => _values = value;
        }

        XmlSchema IXmlSerializable.GetSchema() => null;

        void IXmlSerializable.ReadXml(XmlReader reader)
        {
            var isEmpty = reader.IsEmptyElement;

            reader.Read();

            if (isEmpty)
            {
                return;
            }

            while (reader.NodeType != XmlNodeType.EndElement)
            {
                var propertyName = XName.Get(reader.LocalName, reader.NamespaceURI);
                var property = new PropertyDto
                {
                    Name = propertyName
                };

                _values.Add(new KeyValuePair<PropertyDto, Object>(property, reader.ReadElementContentAsString()));
            }

            reader.MoveToContent();
            reader.ReadEndElement();
        }

        void IXmlSerializable.WriteXml(XmlWriter writer)
        {
            foreach (var kvp in _values)
            {
                var property = kvp.Key;
                writer.WriteElementString(property.Name.LocalName, property.Name.NamespaceName, kvp.Value.ToString());
            }
        }
    }
}