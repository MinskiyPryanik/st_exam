using Newtonsoft.Json;

namespace jsonSerialization
{
    internal class JsonSerial
    {
        public static string JsonSerializeObject<T>(T obj)
        {
            string jsonObject = JsonConvert.SerializeObject(obj);
            return jsonObject;
        }
    }
}
