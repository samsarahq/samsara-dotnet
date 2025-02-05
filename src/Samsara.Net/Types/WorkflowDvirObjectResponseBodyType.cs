using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<WorkflowDvirObjectResponseBodyType>))]
public enum WorkflowDvirObjectResponseBodyType
{
    [EnumMember(Value = "preTrip")]
    PreTrip,

    [EnumMember(Value = "postTrip")]
    PostTrip,

    [EnumMember(Value = "mechanic")]
    Mechanic,

    [EnumMember(Value = "unspecified")]
    Unspecified,
}
