using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SmiteBuilder.Models
{
    public class GodModel
    {
        public int id { get; set; }
        public string name { get; set; }
        public string title { get; set; }
        public string pantheon { get; set; }
        public string pros { get; set; }
        public string type { get; set; }
        public string role { get; set; }
        public string card { get; set; }
    }

    public class GodSetModel
    {
        public List<GodModel> GodSet { get; }

        public GodSetModel()
        {
            string path = "gods.json";
            FileFormat(path);
            GodSet = new List<GodModel>();
            string json = System.IO.File.ReadAllText(path);
            JsonConvert.PopulateObject(json, this);

        }
        public void FileFormat(string path)
        {
            string s = System.IO.File.ReadAllText(path);
            if (!s.StartsWith("{\"GodSet\":")) s = String.Concat("{\"GodSet\":", s);
            if (!s.EndsWith("}")) s = String.Concat(s, "}");
            System.IO.File.WriteAllText(path, s);
        }
    }
}