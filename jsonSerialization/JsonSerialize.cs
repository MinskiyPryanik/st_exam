using System.IO;
using System.Xml.Serialization;

namespace jsonSerialization
{
    public static class JsonSerialize
    {
        public static string Serialize<T>(this T obj)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StringWriter writer = new StringWriter())
            {
                serializer.Serialize(writer, obj);
                return writer.ToString();
            }
        }
    }

}
