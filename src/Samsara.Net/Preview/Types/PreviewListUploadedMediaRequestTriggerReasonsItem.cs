using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Preview;

[JsonConverter(typeof(EnumSerializer<PreviewListUploadedMediaRequestTriggerReasonsItem>))]
public enum PreviewListUploadedMediaRequestTriggerReasonsItem
{
    [EnumMember(Value = "api")]
    Api,

    [EnumMember(Value = "panicButton")]
    PanicButton,

    [EnumMember(Value = "periodicStill")]
    PeriodicStill,

    [EnumMember(Value = "tripEndStill")]
    TripEndStill,

    [EnumMember(Value = "tripStartStill")]
    TripStartStill,

    [EnumMember(Value = "videoRetrieval")]
    VideoRetrieval,
}
