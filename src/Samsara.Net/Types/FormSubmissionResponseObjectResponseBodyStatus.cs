using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormSubmissionResponseObjectResponseBodyStatus>))]
public enum FormSubmissionResponseObjectResponseBodyStatus
{
    [EnumMember(Value = "notStarted")]
    NotStarted,

    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "archived")]
    Archived,

    [EnumMember(Value = "inProgress")]
    InProgress,

    [EnumMember(Value = "needsReview")]
    NeedsReview,

    [EnumMember(Value = "changesRequested")]
    ChangesRequested,

    [EnumMember(Value = "approved")]
    Approved,
}
