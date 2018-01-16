using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace App.Common
{
    public static class Serialize
    {
        public static void SerializeToXmlUft8<T>(string path, object obj)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));

            using (StreamWriter sr = new StreamWriter(path, false, Encoding.UTF8))
            {
                xs.Serialize(sr, obj);
            }
        }

        public static T DeserializeFromXmlUtf8<T>(string path)
        {
            XmlSerializer xs = new XmlSerializer(typeof(T));
            string text = string.Empty;
            List<string> listLine = new List<string>();

            using (StreamReader srd = new StreamReader(path, Encoding.UTF8))
            {
                return (T)xs.Deserialize(srd);
            }
        }
    }
}
