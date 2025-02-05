using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<V1JobStatus>))]
public enum V1JobStatus
{
    [EnumMember(Value = "JobState_Unassigned")]
    JobStateUnassigned,

    [EnumMember(Value = "JobState_Scheduled")]
    JobStateScheduled,

    [EnumMember(Value = "JobState_EnRoute")]
    JobStateEnRoute,

    [EnumMember(Value = "JobState_Arrived")]
    JobStateArrived,

    [EnumMember(Value = "JobState_Completed")]
    JobStateCompleted,

    [EnumMember(Value = "JobState_Skipped")]
    JobStateSkipped,
}
