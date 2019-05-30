using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam30._05._2019.Models
{
    public class Feature
    {
        [JsonProperty("properties")]
        public Property properties { get; set; }
    }
}
