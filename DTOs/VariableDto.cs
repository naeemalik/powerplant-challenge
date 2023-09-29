using API.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace API.DTOs
{
	public class VariableDto
    { 
        public string Name { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public PowerplantType Type { get; set; }

        public decimal Efficiency { get; set; }

        public decimal PMin { get; set; }

        public decimal PMax { get; set; }

        public decimal RunningCost { get; set; }
    }
}

