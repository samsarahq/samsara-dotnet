using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<FormsMediaRecordObjectResponseBodyProcessingStatus>))]
public enum FormsMediaRecordObjectResponseBodyProcessingStatus
{
    [EnumMember(Value = "unknown")]
    Unknown,

    [EnumMember(Value = "processing")]
    Processing,

    [EnumMember(Value = "finished")]
    Finished,
}
