using Newtonsoft.Json.Linq;

namespace com.bbm.Helpers
{
    public static class JSONExtention
    {
        public static string optString(this JObject jObject, string key, string defaultValue)
        {
            JToken token = jObject[key];
            return token == null ? defaultValue : (string)token;
        }

        public static bool optBoolean(this JObject jObject, string key, bool defaultValue)
        {
            JToken token = jObject[key];
            return token == null ? defaultValue : (bool)token;
        }

        public static double optDouble(this JObject jObject, string key, double defaultValue)
        {
            JToken token = jObject[key];
            return token == null ? defaultValue : (double)token;
        }

        public static int optInt(this JObject jObject, string key, int defaultValue)
        {
            JToken token = jObject[key];
            return token == null ? defaultValue : (int)token;
        }

        public static long optInt(this JObject jObject, string key, long defaultValue)
        {
            JToken token = jObject[key];
            return token == null ? defaultValue : (long)token;
        }

        public static bool has(this JObject jObject, string key)
        {
            return jObject[key] == null ? false : true;
        }
    }
}

