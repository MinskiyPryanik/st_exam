using Newtonsoft.Json;

namespace StudentREST
{
    public static class JsonSerial
    {
            public static string JsonSerializeObject<T>(T obj)
            {
                string jsonObject = JsonConvert.SerializeObject(obj);
                return jsonObject;
            }
            public static T JsonDeserializeObject<T>(this string json)
            {
            return JsonConvert.DeserializeObject<T>(json);
            }
        }
    }
