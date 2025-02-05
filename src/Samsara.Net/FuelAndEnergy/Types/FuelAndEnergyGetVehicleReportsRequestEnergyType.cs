using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.FuelAndEnergy;

[JsonConverter(typeof(EnumSerializer<FuelAndEnergyGetVehicleReportsRequestEnergyType>))]
public enum FuelAndEnergyGetVehicleReportsRequestEnergyType
{
    [EnumMember(Value = "fuel")]
    Fuel,

    [EnumMember(Value = "hybrid")]
    Hybrid,

    [EnumMember(Value = "electric")]
    Electric,
}
