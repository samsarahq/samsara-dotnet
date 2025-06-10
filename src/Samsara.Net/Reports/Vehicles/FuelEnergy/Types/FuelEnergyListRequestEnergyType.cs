using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Reports.Vehicles.FuelEnergy;

[JsonConverter(typeof(EnumSerializer<FuelEnergyListRequestEnergyType>))]
public enum FuelEnergyListRequestEnergyType
{
    [EnumMember(Value = "fuel")]
    Fuel,

    [EnumMember(Value = "hybrid")]
    Hybrid,

    [EnumMember(Value = "electric")]
    Electric,
}
