using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormSubmissionRequestAssignedToRequestBodyType>))]
public enum FormSubmissionRequestAssignedToRequestBodyType
{
    [EnumMember(Value = "driver")]
    Driver,

    [EnumMember(Value = "user")]
    User,
}
