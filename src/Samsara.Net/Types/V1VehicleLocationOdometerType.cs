using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<V1VehicleLocationOdometerType>))]
public enum V1VehicleLocationOdometerType
{
    [EnumMember(Value = "GPS")]
    Gps,

    [EnumMember(Value = "OBD")]
    Obd,
}
