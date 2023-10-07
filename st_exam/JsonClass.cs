using System.Text.Json;

namespace st_exam
{
        public static class JsonExtensions
        {
            public static T Deserialize<T>(this string json, JsonSerializerOptions options = null)
            {
                return JsonSerializer.Deserialize<T>(json, options);
            }
        }
}
