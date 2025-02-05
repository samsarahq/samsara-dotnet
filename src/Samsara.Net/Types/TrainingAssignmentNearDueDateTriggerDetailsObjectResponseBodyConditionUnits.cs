using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBodyConditionUnits>)
)]
public enum TrainingAssignmentNearDueDateTriggerDetailsObjectResponseBodyConditionUnits
{
    [EnumMember(Value = "DAYS")]
    Days,

    [EnumMember(Value = "WEEKS")]
    Weeks,
}
