using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<HealthResponseResponseBodyPrimaryHealthReason>))]
public enum HealthResponseResponseBodyPrimaryHealthReason
{
    [EnumMember(Value = "assetUnplugged")]
    AssetUnplugged,

    [EnumMember(Value = "cameraMisaligned")]
    CameraMisaligned,

    [EnumMember(Value = "healthy")]
    Healthy,

    [EnumMember(Value = "inwardCameraObstruction")]
    InwardCameraObstruction,

    [EnumMember(Value = "irregularRecording")]
    IrregularRecording,

    [EnumMember(Value = "lowDeviceBattery")]
    LowDeviceBattery,

    [EnumMember(Value = "missingEldDiagnostics")]
    MissingEldDiagnostics,

    [EnumMember(Value = "missingVin")]
    MissingVin,

    [EnumMember(Value = "needsReplacement")]
    NeedsReplacement,

    [EnumMember(Value = "newlyInstalledDevice")]
    NewlyInstalledDevice,

    [EnumMember(Value = "noGpsSignal")]
    NoGpsSignal,

    [EnumMember(Value = "notDetected")]
    NotDetected,

    [EnumMember(Value = "outwardCameraObstruction")]
    OutwardCameraObstruction,

    [EnumMember(Value = "recordingTimeRequired")]
    RecordingTimeRequired,

    [EnumMember(Value = "unknown")]
    Unknown,

    [EnumMember(Value = "vgUnplugged")]
    VgUnplugged,
}
