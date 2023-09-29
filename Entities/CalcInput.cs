namespace API.Entities
{
	public class CalcInput
	{
        public decimal Load { get; set; }
        public ExternalFactor Fuels { get; set; }
        public List<Variable> Powerplants { get; set; }
    }
}

