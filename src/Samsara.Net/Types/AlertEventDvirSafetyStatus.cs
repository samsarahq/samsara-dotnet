using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<AlertEventDvirSafetyStatus>))]
public enum AlertEventDvirSafetyStatus
{
    [EnumMember(Value = "safe")]
    Safe,

    [EnumMember(Value = "unsafe")]
    Unsafe,
}
