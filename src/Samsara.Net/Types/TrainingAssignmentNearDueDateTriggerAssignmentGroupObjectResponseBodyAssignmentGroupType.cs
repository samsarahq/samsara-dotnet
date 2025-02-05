using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBodyAssignmentGroupType>)
)]
public enum TrainingAssignmentNearDueDateTriggerAssignmentGroupObjectResponseBodyAssignmentGroupType
{
    [EnumMember(Value = "CATEGORY")]
    Category,

    [EnumMember(Value = "COURSE")]
    Course,
}
