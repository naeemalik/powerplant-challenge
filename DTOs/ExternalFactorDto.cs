using Newtonsoft.Json;

namespace API.DTOs
{
	public class ExternalFactorDto
	{
        [JsonProperty(PropertyName = "gas(euro/MWh)")]
        public decimal Gas { get; set; }

        [JsonProperty(PropertyName = "kerosine(euro/MWh)")]
        public decimal Kerosine { get; set; }

        [JsonProperty(PropertyName = "co2(euro/ton)")]
        public decimal Co2 { get; set; }

        [JsonProperty(PropertyName = "wind(%)")]
        public decimal Wind { get; set; }
    }
}

