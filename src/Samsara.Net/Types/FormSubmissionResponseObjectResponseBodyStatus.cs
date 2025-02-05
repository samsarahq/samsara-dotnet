using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormSubmissionResponseObjectResponseBodyStatus>))]
public enum FormSubmissionResponseObjectResponseBodyStatus
{
    [EnumMember(Value = "toDo")]
    ToDo,

    [EnumMember(Value = "submitted")]
    Submitted,

    [EnumMember(Value = "dismissed")]
    Dismissed,
}
