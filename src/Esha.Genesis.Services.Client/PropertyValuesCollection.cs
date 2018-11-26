using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    [Serializable]
    [XmlRoot(Namespace = "http://ns.esha.com/2013/exlx")]
    public class PropertyValuesCollection : IXmlSerializable
    {
        private List<KeyValuePair<Property, Object>> _values;
	
        public List<KeyValuePair<Property, Object>> Values
        {
            get => _values;
            set => _values = value;
        }

        XmlSchema IXmlSerializable.GetSchema() => null;

        void IXmlSerializable.ReadXml(XmlReader reader)
        {
            while (reader.NodeType != XmlNodeType.EndElement)
            {
                var propertyName = XName.Get(reader.LocalName, reader.NamespaceURI);
                var property = new Property
                {
                    Name = propertyName
                };

                _values.Add(new KeyValuePair<Property, Object>(property, reader.ReadElementContentAsString()));
                reader.MoveToContent();
            }
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
