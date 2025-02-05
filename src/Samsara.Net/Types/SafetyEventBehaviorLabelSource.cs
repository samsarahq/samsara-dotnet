using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<SafetyEventBehaviorLabelSource>))]
public enum SafetyEventBehaviorLabelSource
{
    [EnumMember(Value = "automated")]
    Automated,

    [EnumMember(Value = "userGenerated")]
    UserGenerated,
}
