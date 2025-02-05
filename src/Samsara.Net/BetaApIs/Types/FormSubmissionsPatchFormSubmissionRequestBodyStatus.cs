using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(EnumSerializer<FormSubmissionsPatchFormSubmissionRequestBodyStatus>))]
public enum FormSubmissionsPatchFormSubmissionRequestBodyStatus
{
    [EnumMember(Value = "toDo")]
    ToDo,

    [EnumMember(Value = "dismissed")]
    Dismissed,
}
