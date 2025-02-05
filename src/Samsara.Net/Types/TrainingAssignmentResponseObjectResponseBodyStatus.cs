using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<TrainingAssignmentResponseObjectResponseBodyStatus>))]
public enum TrainingAssignmentResponseObjectResponseBodyStatus
{
    [EnumMember(Value = "notStarted")]
    NotStarted,

    [EnumMember(Value = "inProgress")]
    InProgress,

    [EnumMember(Value = "completed")]
    Completed,
}
