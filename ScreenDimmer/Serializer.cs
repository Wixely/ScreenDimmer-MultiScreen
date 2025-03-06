using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Augustine.ScreenDimmer
{
    class Serializer
    {
        public static void SerializeObject<T>(T serializableObject, string fileName)
        {
            if (serializableObject == null) { return; }

            try
            {
                var data = JsonConvert.SerializeObject(serializableObject, Newtonsoft.Json.Formatting.Indented);
                File.WriteAllText($"{fileName}.json", data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static T DeSerializeObject<T>(string fileName)
        {
            if (string.IsNullOrEmpty(fileName)) { return default(T); }

            try
            {
                var data = File.ReadAllText($"{fileName}.json");
                return JsonConvert.DeserializeObject<T>(data);
            }
            catch (Exception ex)
            {
                return default(T);
            }
        }
    }
}
