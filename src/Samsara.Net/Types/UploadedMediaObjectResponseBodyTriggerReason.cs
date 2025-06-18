using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<UploadedMediaObjectResponseBodyTriggerReason>))]
public enum UploadedMediaObjectResponseBodyTriggerReason
{
    [EnumMember(Value = "api")]
    Api,

    [EnumMember(Value = "panicButton")]
    PanicButton,

    [EnumMember(Value = "periodicStill")]
    PeriodicStill,

    [EnumMember(Value = "rfidEvent")]
    RfidEvent,

    [EnumMember(Value = "safetyEvent")]
    SafetyEvent,

    [EnumMember(Value = "tripEndStill")]
    TripEndStill,

    [EnumMember(Value = "tripStartStill")]
    TripStartStill,

    [EnumMember(Value = "videoRetrieval")]
    VideoRetrieval,
}
