using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<TrainingAssignmentNearDueDateTriggerDetailsObjectRequestBodyConditionUnits>)
)]
public enum TrainingAssignmentNearDueDateTriggerDetailsObjectRequestBodyConditionUnits
{
    [EnumMember(Value = "DAYS")]
    Days,

    [EnumMember(Value = "WEEKS")]
    Weeks,
}
