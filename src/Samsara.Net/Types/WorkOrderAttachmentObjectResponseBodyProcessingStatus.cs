using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<WorkOrderAttachmentObjectResponseBodyProcessingStatus>))]
public enum WorkOrderAttachmentObjectResponseBodyProcessingStatus
{
    [EnumMember(Value = "unknown")]
    Unknown,

    [EnumMember(Value = "processing")]
    Processing,

    [EnumMember(Value = "finished")]
    Finished,
}
