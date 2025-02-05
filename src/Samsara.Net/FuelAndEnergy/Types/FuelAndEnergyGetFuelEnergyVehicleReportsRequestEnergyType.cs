using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.FuelAndEnergy;

[JsonConverter(typeof(EnumSerializer<FuelAndEnergyGetFuelEnergyVehicleReportsRequestEnergyType>))]
public enum FuelAndEnergyGetFuelEnergyVehicleReportsRequestEnergyType
{
    [EnumMember(Value = "fuel")]
    Fuel,

    [EnumMember(Value = "hybrid")]
    Hybrid,

    [EnumMember(Value = "electric")]
    Electric,
}
