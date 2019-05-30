using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam30._05._2019.Models
{
    public class Earthquakes
    {
        [JsonProperty("features")]
        public List<Feature> features;
    }
}
