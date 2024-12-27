using System.Text;

namespace System.Xml.Serialization;

public static class XmlExtensions
{
    public static string ToXml<T>(this T value, XmlSerializerNamespaces namespaces = null, Encoding encoding = null)
    {
        using var stringWriter = new AlternativeWriter(encoding ?? Encoding.UTF8);
        using var xmlWriter = XmlWriter.Create(stringWriter);
        new XmlSerializer(typeof(T)).Serialize(xmlWriter, value, namespaces);
        return stringWriter.ToString();
    }

    public static T XmlTo<T>(string xml)
    {
        using var reader = new StringReader(xml);
        return (T)new XmlSerializer(typeof(T)).Deserialize(reader);
    }
}

public class AlternativeWriter : StringWriter
{
    private readonly Encoding _encoding;

    public AlternativeWriter(Encoding encoding = null)
    {
        _encoding = encoding ?? Encoding.UTF8;
    }

    public override Encoding Encoding => _encoding;
}
