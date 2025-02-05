using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<TripResponseBodyCompletionStatus>))]
public enum TripResponseBodyCompletionStatus
{
    [EnumMember(Value = "inProgress")]
    InProgress,

    [EnumMember(Value = "completed")]
    Completed,
}
