using System.Runtime.Serialization;
namespace API.Helpers
{
	public enum PowerplantType
    {
        [EnumMember(Value = "gasfired")]
        gasfired = 0,
        [EnumMember(Value = "turbojet")]
        turbojet = 1,
        [EnumMember(Value = "windturbine")]
        windturbine = 2
    }
}

