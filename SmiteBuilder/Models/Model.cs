using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmiteBuilder.Models
{
    public class Model
    {
        public string FileFormat(string json, string objName)
        {
            objName = String.Concat("{\"", objName);
            objName = String.Concat(objName, "\":");
            if (!json.StartsWith(objName)) json = String.Concat(objName, json);
            if (!json.EndsWith("}")) json = String.Concat(json, "}");
            return json;
        }
    }
}
