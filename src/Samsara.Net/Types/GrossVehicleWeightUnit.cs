using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<GrossVehicleWeightUnit>))]
public enum GrossVehicleWeightUnit
{
    [EnumMember(Value = "lb")]
    Lb,

    [EnumMember(Value = "kg")]
    Kg,
}
