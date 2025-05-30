using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Cameras.Media;

[JsonConverter(typeof(EnumSerializer<MediaListRequestTriggerReasonsItem>))]
public enum MediaListRequestTriggerReasonsItem
{
    [EnumMember(Value = "api")]
    Api,

    [EnumMember(Value = "panicButton")]
    PanicButton,

    [EnumMember(Value = "periodicStill")]
    PeriodicStill,

    [EnumMember(Value = "safetyEvent")]
    SafetyEvent,

    [EnumMember(Value = "tripEndStill")]
    TripEndStill,

    [EnumMember(Value = "tripStartStill")]
    TripStartStill,

    [EnumMember(Value = "videoRetrieval")]
    VideoRetrieval,
}
