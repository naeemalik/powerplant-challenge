namespace API.DTOs
{
	public class CalcInputDto
	{
        public decimal Load { get; set; }
        public ExternalFactorDto Fuels { get; set; }
        public List<VariableDto> Powerplants { get; set; }
    }
}

