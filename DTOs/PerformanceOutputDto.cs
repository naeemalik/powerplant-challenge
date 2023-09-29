using Newtonsoft.Json;

namespace API.DTOs
{
	public class PerformanceOutputDto
	{
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "p")]
        public decimal Power { get; set; }
    }
}

