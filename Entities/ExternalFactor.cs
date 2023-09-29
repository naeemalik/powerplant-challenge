using Newtonsoft.Json;
namespace API.Entities
{
	public class ExternalFactor
	{
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal Gas { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal Kerosine { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal Co2 { get; set; }

        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public decimal Wind { get; set; }
    }
}

