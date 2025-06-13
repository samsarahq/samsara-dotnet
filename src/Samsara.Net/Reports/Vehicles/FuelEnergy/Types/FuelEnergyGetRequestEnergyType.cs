using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Reports.Vehicles.FuelEnergy;

[JsonConverter(typeof(EnumSerializer<FuelEnergyGetRequestEnergyType>))]
public enum FuelEnergyGetRequestEnergyType
{
    [EnumMember(Value = "fuel")]
    Fuel,

    [EnumMember(Value = "hybrid")]
    Hybrid,

    [EnumMember(Value = "electric")]
    Electric,
}
