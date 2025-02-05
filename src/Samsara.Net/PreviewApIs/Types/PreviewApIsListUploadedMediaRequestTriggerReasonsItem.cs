using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[JsonConverter(typeof(EnumSerializer<PreviewApIsListUploadedMediaRequestTriggerReasonsItem>))]
public enum PreviewApIsListUploadedMediaRequestTriggerReasonsItem
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
