using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<SafetyEventCoachingState>))]
public enum SafetyEventCoachingState
{
    [EnumMember(Value = "needsReview")]
    NeedsReview,

    [EnumMember(Value = "coached")]
    Coached,

    [EnumMember(Value = "dismissed")]
    Dismissed,

    [EnumMember(Value = "reviewed")]
    Reviewed,

    [EnumMember(Value = "archived")]
    Archived,

    [EnumMember(Value = "manualReview")]
    ManualReview,

    [EnumMember(Value = "needsCoaching")]
    NeedsCoaching,

    [EnumMember(Value = "autoDismissed")]
    AutoDismissed,

    [EnumMember(Value = "needsRecognition")]
    NeedsRecognition,

    [EnumMember(Value = "recognized")]
    Recognized,

    [EnumMember(Value = "invalid")]
    Invalid,
}
