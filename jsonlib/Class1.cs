using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jsonlib
{
    public class ConverJson
    {
        public static void Serialize<T>(T avtor, string file)
        {
            string desktoop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = JsonConvert.SerializeObject(avtor);
            File.WriteAllText(desktoop+ "\\" + file, json);
        }
        public static T Desir<T>(string file)
        {
            string desktoop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = "";
            try
            {
                json = File.ReadAllText(desktoop +"\\"+ file);
            }
            catch
            {
                File.Create(desktoop + "\\" + file).Close();
            }
            T avtor = JsonConvert.DeserializeObject<T>(json);
            return avtor;
        }
    }
}
