using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<MediaObjectResponseBodyStatus>))]
public enum MediaObjectResponseBodyStatus
{
    [EnumMember(Value = "available")]
    Available,

    [EnumMember(Value = "invalid")]
    Invalid,

    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "requested")]
    Requested,
}
