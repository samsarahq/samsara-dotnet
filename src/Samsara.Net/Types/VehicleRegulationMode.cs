using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleRegulationMode>))]
public enum VehicleRegulationMode
{
    [EnumMember(Value = "regulated")]
    Regulated,

    [EnumMember(Value = "unregulated")]
    Unregulated,

    [EnumMember(Value = "mixed")]
    Mixed,
}
