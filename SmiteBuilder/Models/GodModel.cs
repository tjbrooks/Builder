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

    public class GodSetModel : Model
    {
        public List<GodModel> GodSet { get; }

        public GodSetModel()
        {
            string path = "gods.json";
            GodSet = new List<GodModel>();
            string json = FileFormat(System.IO.File.ReadAllText(path), "GodSet");
            JsonConvert.PopulateObject(json, this);
        }

        public void GetGodsInfo()
        {
            foreach(var god in GodSet)
            {
                
            }
        }
    }
}