using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(EnumSerializer<BetaApIsGetHosEldEventsRequestDriverActivationStatus>))]
public enum BetaApIsGetHosEldEventsRequestDriverActivationStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "deactivated")]
    Deactivated,
}
