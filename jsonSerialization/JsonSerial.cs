using Newtonsoft.Json;

namespace jsonSerialization
{
    public static class JsonSerial
    {
        public static string JsonSerializeObject<T>(this T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
    }
}
