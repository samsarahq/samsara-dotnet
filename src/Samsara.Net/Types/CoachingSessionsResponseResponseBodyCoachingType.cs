using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<CoachingSessionsResponseResponseBodyCoachingType>))]
public enum CoachingSessionsResponseResponseBodyCoachingType
{
    [EnumMember(Value = "fullySharedWithManager")]
    FullySharedWithManager,

    [EnumMember(Value = "selfCoaching")]
    SelfCoaching,

    [EnumMember(Value = "unknown")]
    Unknown,

    [EnumMember(Value = "unshared")]
    Unshared,

    [EnumMember(Value = "withManager")]
    WithManager,
}
