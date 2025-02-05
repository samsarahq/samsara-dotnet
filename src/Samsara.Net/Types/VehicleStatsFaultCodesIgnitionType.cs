using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<VehicleStatsFaultCodesIgnitionType>))]
public enum VehicleStatsFaultCodesIgnitionType
{
    [EnumMember(Value = "spark")]
    Spark,

    [EnumMember(Value = "compression")]
    Compression,
}
