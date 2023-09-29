using Newtonsoft.Json;
using API.Helpers;

namespace API.Entities
{
	public class Variable
	{
		public Variable()
		{
		}

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "type")]
        public PowerplantType Type { get; set; }

        [JsonProperty(PropertyName = "efficiency")]
        public decimal Efficiency { get; set; }

        [JsonProperty(PropertyName = "pmin")]
        public decimal PMin { get; set; }

        [JsonProperty(PropertyName = "pmax")]
        public decimal PMax { get; set; }

        public decimal RunningCost { get; set; }
    }
}

