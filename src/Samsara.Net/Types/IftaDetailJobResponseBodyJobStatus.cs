using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<IftaDetailJobResponseBodyJobStatus>))]
public enum IftaDetailJobResponseBodyJobStatus
{
    [EnumMember(Value = "Requested")]
    Requested,

    [EnumMember(Value = "Processing")]
    Processing,

    [EnumMember(Value = "Completed")]
    Completed,

    [EnumMember(Value = "Failed")]
    Failed,
}
