using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormSubmissionPdfExportResponseObjectResponseBodyJobStatus>))]
public enum FormSubmissionPdfExportResponseObjectResponseBodyJobStatus
{
    [EnumMember(Value = "unknown")]
    Unknown,

    [EnumMember(Value = "pending")]
    Pending,

    [EnumMember(Value = "done")]
    Done,

    [EnumMember(Value = "failed")]
    Failed,
}
