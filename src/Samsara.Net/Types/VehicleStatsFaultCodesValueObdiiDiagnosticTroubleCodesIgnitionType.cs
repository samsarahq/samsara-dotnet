using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<VehicleStatsFaultCodesValueObdiiDiagnosticTroubleCodesIgnitionType>)
)]
public enum VehicleStatsFaultCodesValueObdiiDiagnosticTroubleCodesIgnitionType
{
    [EnumMember(Value = "spark")]
    Spark,

    [EnumMember(Value = "compression")]
    Compression,
}
