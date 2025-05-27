using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.FormSubmissions;

[JsonConverter(typeof(EnumSerializer<FormSubmissionsPatchFormSubmissionRequestBodyStatus>))]
public enum FormSubmissionsPatchFormSubmissionRequestBodyStatus
{
    [EnumMember(Value = "notStarted")]
    NotStarted,

    [EnumMember(Value = "archived")]
    Archived,

    [EnumMember(Value = "inProgress")]
    InProgress,

    [EnumMember(Value = "changesRequested")]
    ChangesRequested,

    [EnumMember(Value = "approved")]
    Approved,
}
