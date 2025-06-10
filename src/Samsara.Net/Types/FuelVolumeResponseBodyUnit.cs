using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FuelVolumeResponseBodyUnit>))]
public enum FuelVolumeResponseBodyUnit
{
    [EnumMember(Value = "GALLONS")]
    Gallons,

    [EnumMember(Value = "LITERS")]
    Liters,
}
