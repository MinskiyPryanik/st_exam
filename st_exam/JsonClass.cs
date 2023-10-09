using System.Text.Json;

namespace st_exam
{
        public static class JsonExtensions
        {
            public static T Deserialize<T>(this string json)
            {
                return JsonSerializer.Deserialize<T>(json);
            }
        }
}
