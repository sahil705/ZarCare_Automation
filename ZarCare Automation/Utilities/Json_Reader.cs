namespace ZarCare_Automation.Utilities
{
    public class Json_Reader
    {
        public static JObject ReadJsonText(string JsonFilePath)
        {
            string JsonString = File.ReadAllText(JsonFilePath);
            var JsonObject = JObject.Parse(JsonString);
            return JsonObject;
        }
        
        public static JObject GetDataFromJson(string classname)
        {
            string path = Generic_Utils.getDataPath("Datasets");
            string jsonString = File.ReadAllText(path + "\\" + classname + ".json");
            JObject jsonobj = JObject.Parse(jsonString);
            return jsonobj;
        }

        public static JArray GetArrayFromJson(string classname, string arrayKey)
        {
            string path = Generic_Utils.getDataPath("Datasets");
            string jsonString = File.ReadAllText(path + "\\" + classname + ".json");
            JObject jsonobj = JObject.Parse(jsonString);

            if (jsonobj[arrayKey] != null && jsonobj[arrayKey] is JArray)
            {
                JArray jsonArray = (JArray)jsonobj[arrayKey];
                return jsonArray;
            }
            else
            {
                throw new Exception($"Array not found for the specified key '{arrayKey}'.");
            }
        }
    }
}
