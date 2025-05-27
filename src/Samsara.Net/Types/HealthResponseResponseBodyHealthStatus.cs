using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<HealthResponseResponseBodyHealthStatus>))]
public enum HealthResponseResponseBodyHealthStatus
{
    [EnumMember(Value = "dataPending")]
    DataPending,

    [EnumMember(Value = "healthy")]
    Healthy,

    [EnumMember(Value = "needsAttention")]
    NeedsAttention,

    [EnumMember(Value = "needsReplacement")]
    NeedsReplacement,
}
