using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(EnumSerializer<DvirSubmittedDeviceTriggerDetailsObjectRequestBodyDvirSubmissionTypesItem>)
)]
public enum DvirSubmittedDeviceTriggerDetailsObjectRequestBodyDvirSubmissionTypesItem
{
    [EnumMember(Value = "SAFE_NO_DEFECTS")]
    SafeNoDefects,

    [EnumMember(Value = "SAFE_WITH_DEFECTS")]
    SafeWithDefects,

    [EnumMember(Value = "UNSAFE")]
    Unsafe,
}
