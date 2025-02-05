using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<CoachingSessionsResponseResponseBodySessionStatus>))]
public enum CoachingSessionsResponseResponseBodySessionStatus
{
    [EnumMember(Value = "unknown")]
    Unknown,

    [EnumMember(Value = "upcoming")]
    Upcoming,

    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "deleted")]
    Deleted,
}
