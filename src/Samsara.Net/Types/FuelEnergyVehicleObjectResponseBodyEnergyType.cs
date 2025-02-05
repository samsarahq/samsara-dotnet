using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FuelEnergyVehicleObjectResponseBodyEnergyType>))]
public enum FuelEnergyVehicleObjectResponseBodyEnergyType
{
    [EnumMember(Value = "fuel")]
    Fuel,

    [EnumMember(Value = "hybrid")]
    Hybrid,

    [EnumMember(Value = "electric")]
    Electric,
}
