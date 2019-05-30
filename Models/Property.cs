using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam30._05._2019.Models
{
    public class Property
    {
        [JsonProperty("mag")]
        public double? Magnitude { get; set; }
        [JsonProperty("place")]
        public string Place { get; set; }
        [JsonProperty("sig")]
        public double? Depth { get; set; }
        [JsonProperty("time")]
        public object Time { get; set; }
    }
}
