using Newtonsoft.Json;

namespace System.Text.Json;

public static class JsonExtensions
{
    public static string ToJson<T>(this T value, JsonSerializerSettings settings)
    {
        return JsonConvert.SerializeObject(value, settings);
    }

    public static T JsonTo<T>(this string json, JsonSerializerSettings settings)
    {
        return JsonConvert.DeserializeObject<T>(json, settings);
    }
}
