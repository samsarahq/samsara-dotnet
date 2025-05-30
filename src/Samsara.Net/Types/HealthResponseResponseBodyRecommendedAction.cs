using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<HealthResponseResponseBodyRecommendedAction>))]
public enum HealthResponseResponseBodyRecommendedAction
{
    [EnumMember(Value = "recommendedActionAgHealthy")]
    RecommendedActionAgHealthy,

    [EnumMember(Value = "recommendedActionAgLowDeviceBatteryAG45")]
    RecommendedActionAgLowDeviceBatteryAg45,

    [EnumMember(Value = "recommendedActionAgLowDeviceBatteryAG46")]
    RecommendedActionAgLowDeviceBatteryAg46,

    [EnumMember(Value = "recommendedActionAgLowDeviceBatteryAG51")]
    RecommendedActionAgLowDeviceBatteryAg51,

    [EnumMember(Value = "recommendedActionAgLowDeviceBatteryPoweredAG")]
    RecommendedActionAgLowDeviceBatteryPoweredAg,

    [EnumMember(Value = "recommendedActionAgNoGpsSignal")]
    RecommendedActionAgNoGpsSignal,

    [EnumMember(Value = "recommendedActionAgNotDetected")]
    RecommendedActionAgNotDetected,

    [EnumMember(Value = "recommendedActionAgUnplugged")]
    RecommendedActionAgUnplugged,

    [EnumMember(Value = "recommendedActionCmCameraMisaligned")]
    RecommendedActionCmCameraMisaligned,

    [EnumMember(Value = "recommendedActionCmHealthy")]
    RecommendedActionCmHealthy,

    [EnumMember(Value = "recommendedActionCmInwardCameraObstruction")]
    RecommendedActionCmInwardCameraObstruction,

    [EnumMember(Value = "recommendedActionCmIrregularRecording")]
    RecommendedActionCmIrregularRecording,

    [EnumMember(Value = "recommendedActionCmNewlyInstalledDevice")]
    RecommendedActionCmNewlyInstalledDevice,

    [EnumMember(Value = "recommendedActionCmNotDetected")]
    RecommendedActionCmNotDetected,

    [EnumMember(Value = "recommendedActionCmOutwardCameraObstruction")]
    RecommendedActionCmOutwardCameraObstruction,

    [EnumMember(Value = "recommendedActionCmRecordingTimeRequired")]
    RecommendedActionCmRecordingTimeRequired,

    [EnumMember(Value = "recommendedActionCmVgUnplugged")]
    RecommendedActionCmVgUnplugged,

    [EnumMember(Value = "recommendedActionGatewayNewlyInstalledDevice")]
    RecommendedActionGatewayNewlyInstalledDevice,

    [EnumMember(Value = "recommendedActionVgHealthy")]
    RecommendedActionVgHealthy,

    [EnumMember(Value = "recommendedActionVgMissingEldDiagnostics")]
    RecommendedActionVgMissingEldDiagnostics,

    [EnumMember(Value = "recommendedActionVgMissingEldDiagnosticsExchangeSubmitted")]
    RecommendedActionVgMissingEldDiagnosticsExchangeSubmitted,

    [EnumMember(Value = "recommendedActionVgMissingEldDiagnosticsHardwareExchanged")]
    RecommendedActionVgMissingEldDiagnosticsHardwareExchanged,

    [EnumMember(Value = "recommendedActionVgMissingEldDiagnosticsNoExchangeSubmitted")]
    RecommendedActionVgMissingEldDiagnosticsNoExchangeSubmitted,

    [EnumMember(Value = "recommendedActionVgMissingVin")]
    RecommendedActionVgMissingVin,

    [EnumMember(Value = "recommendedActionVgNeedsReplacement")]
    RecommendedActionVgNeedsReplacement,

    [EnumMember(Value = "recommendedActionVgNotDetected")]
    RecommendedActionVgNotDetected,

    [EnumMember(Value = "recommendedActionVgVgUnplugged")]
    RecommendedActionVgVgUnplugged,

    [EnumMember(Value = "unknown")]
    Unknown,
}
