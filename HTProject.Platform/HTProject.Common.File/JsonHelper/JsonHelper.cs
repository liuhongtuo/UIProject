using Common.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HTProject.Common.File.JsonHelper
{
    public static class JsonHelper
    {
        private static ILog logger = LogManager.GetLogger(typeof(JsonHelper));

        public static string ObjToJson(object obj)
        {
            string result = string.Empty;
            try
            {
                using (StringWriter sw = new StringWriter())
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(sw, obj);
                    result = sw.ToString();
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Exception:{ex.Message}");
            }
            return result;
        }

        public static T JsonToObj<T>(string json)
        {
            T result = default(T);
            try
            {
                using (StringReader sr = new StringReader(json))
                {
                    using (JsonReader jr = new JsonTextReader(sr))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        result = serializer.Deserialize<T>(jr);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error($"Exception:{ex.Message}");
            }
            return result;
        }
    }
}
