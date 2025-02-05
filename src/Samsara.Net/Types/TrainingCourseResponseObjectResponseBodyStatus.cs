using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<TrainingCourseResponseObjectResponseBodyStatus>))]
public enum TrainingCourseResponseObjectResponseBodyStatus
{
    [EnumMember(Value = "published")]
    Published,

    [EnumMember(Value = "deleted")]
    Deleted,

    [EnumMember(Value = "archived")]
    Archived,

    [EnumMember(Value = "unknown")]
    Unknown,
}
