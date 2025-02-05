using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<SafetyEventActivityFeedItemResponseBodyType>))]
public enum SafetyEventActivityFeedItemResponseBodyType
{
    [EnumMember(Value = "BehaviorLabelActivityType")]
    BehaviorLabelActivityType,

    [EnumMember(Value = "CoachingStateActivityType")]
    CoachingStateActivityType,

    [EnumMember(Value = "CreateSafetyEventActivityType")]
    CreateSafetyEventActivityType,
}
