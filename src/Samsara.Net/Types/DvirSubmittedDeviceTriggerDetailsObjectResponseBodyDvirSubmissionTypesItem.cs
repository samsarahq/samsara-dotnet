using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<DvirSubmittedDeviceTriggerDetailsObjectResponseBodyDvirSubmissionTypesItem>)
)]
public enum DvirSubmittedDeviceTriggerDetailsObjectResponseBodyDvirSubmissionTypesItem
{
    [EnumMember(Value = "SAFE_NO_DEFECTS")]
    SafeNoDefects,

    [EnumMember(Value = "SAFE_WITH_DEFECTS")]
    SafeWithDefects,

    [EnumMember(Value = "UNSAFE")]
    Unsafe,
}
