using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<HealthResponseResponseBodyRecommendedAction>))]
[Serializable]
public readonly record struct HealthResponseResponseBodyRecommendedAction : IStringEnum
{
    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionAgHealthy =
        new(Values.RecommendedActionAgHealthy);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionAgLowDeviceBatteryAg45 =
        new(Values.RecommendedActionAgLowDeviceBatteryAg45);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionAgLowDeviceBatteryAg46 =
        new(Values.RecommendedActionAgLowDeviceBatteryAg46);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionAgLowDeviceBatteryAg51 =
        new(Values.RecommendedActionAgLowDeviceBatteryAg51);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionAgLowDeviceBatteryPoweredAg =
        new(Values.RecommendedActionAgLowDeviceBatteryPoweredAg);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionAgNoGpsSignal =
        new(Values.RecommendedActionAgNoGpsSignal);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionAgNotDetected =
        new(Values.RecommendedActionAgNotDetected);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionAgUnplugged =
        new(Values.RecommendedActionAgUnplugged);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionBleDataPending =
        new(Values.RecommendedActionBleDataPending);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionBleHealthy =
        new(Values.RecommendedActionBleHealthy);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionBleLowBattery =
        new(Values.RecommendedActionBleLowBattery);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionBleNotDetected =
        new(Values.RecommendedActionBleNotDetected);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionCcHealthy =
        new(Values.RecommendedActionCcHealthy);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionCcLowUptime =
        new(Values.RecommendedActionCcLowUptime);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionCcMediaInputUptime =
        new(Values.RecommendedActionCcMediaInputUptime);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionCcNotDetected =
        new(Values.RecommendedActionCcNotDetected);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionCmCameraMisaligned =
        new(Values.RecommendedActionCmCameraMisaligned);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionCmHealthy =
        new(Values.RecommendedActionCmHealthy);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionCmInactive =
        new(Values.RecommendedActionCmInactive);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionCmInwardCameraObstruction =
        new(Values.RecommendedActionCmInwardCameraObstruction);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionCmIrregularRecording =
        new(Values.RecommendedActionCmIrregularRecording);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionCmLowUptime =
        new(Values.RecommendedActionCmLowUptime);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionCmNewlyInstalledDevice =
        new(Values.RecommendedActionCmNewlyInstalledDevice);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionCmNotDetected =
        new(Values.RecommendedActionCmNotDetected);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionCmOutwardCameraObstruction =
        new(Values.RecommendedActionCmOutwardCameraObstruction);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionCmRecordingTimeRequired =
        new(Values.RecommendedActionCmRecordingTimeRequired);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionCmVgUnplugged =
        new(Values.RecommendedActionCmVgUnplugged);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionGatewayNewlyInstalledDevice =
        new(Values.RecommendedActionGatewayNewlyInstalledDevice);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionHealthy =
        new(Values.RecommendedActionHealthy);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionLowBatteryVoltage =
        new(Values.RecommendedActionLowBatteryVoltage);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionOemNotReporting =
        new(Values.RecommendedActionOemNotReporting);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionVehicleOff =
        new(Values.RecommendedActionVehicleOff);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionVgHealthy =
        new(Values.RecommendedActionVgHealthy);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionVgMissingEldDiagnostics =
        new(Values.RecommendedActionVgMissingEldDiagnostics);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionVgMissingEldDiagnosticsExchangeSubmitted =
        new(Values.RecommendedActionVgMissingEldDiagnosticsExchangeSubmitted);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionVgMissingEldDiagnosticsHardwareExchanged =
        new(Values.RecommendedActionVgMissingEldDiagnosticsHardwareExchanged);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionVgMissingEldDiagnosticsNoExchangeSubmitted =
        new(Values.RecommendedActionVgMissingEldDiagnosticsNoExchangeSubmitted);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionVgMissingVin =
        new(Values.RecommendedActionVgMissingVin);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionVgNeedsReplacement =
        new(Values.RecommendedActionVgNeedsReplacement);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionVgNotDetected =
        new(Values.RecommendedActionVgNotDetected);

    public static readonly HealthResponseResponseBodyRecommendedAction RecommendedActionVgVgUnplugged =
        new(Values.RecommendedActionVgVgUnplugged);

    public static readonly HealthResponseResponseBodyRecommendedAction Unknown = new(
        Values.Unknown
    );

    public HealthResponseResponseBodyRecommendedAction(string value)
    {
        Value = value;
    }

    /// <summary>
    /// The string value of the enum.
    /// </summary>
    public string Value { get; }

    /// <summary>
    /// Create a string enum with the given value.
    /// </summary>
    public static HealthResponseResponseBodyRecommendedAction FromCustom(string value)
    {
        return new HealthResponseResponseBodyRecommendedAction(value);
    }

    public bool Equals(string? other)
    {
        return Value.Equals(other);
    }

    /// <summary>
    /// Returns the string value of the enum.
    /// </summary>
    public override string ToString()
    {
        return Value;
    }

    public static bool operator ==(
        HealthResponseResponseBodyRecommendedAction value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        HealthResponseResponseBodyRecommendedAction value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(HealthResponseResponseBodyRecommendedAction value) =>
        value.Value;

    public static explicit operator HealthResponseResponseBodyRecommendedAction(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string RecommendedActionAgHealthy = "recommendedActionAgHealthy";

        public const string RecommendedActionAgLowDeviceBatteryAg45 =
            "recommendedActionAgLowDeviceBatteryAG45";

        public const string RecommendedActionAgLowDeviceBatteryAg46 =
            "recommendedActionAgLowDeviceBatteryAG46";

        public const string RecommendedActionAgLowDeviceBatteryAg51 =
            "recommendedActionAgLowDeviceBatteryAG51";

        public const string RecommendedActionAgLowDeviceBatteryPoweredAg =
            "recommendedActionAgLowDeviceBatteryPoweredAG";

        public const string RecommendedActionAgNoGpsSignal = "recommendedActionAgNoGpsSignal";

        public const string RecommendedActionAgNotDetected = "recommendedActionAgNotDetected";

        public const string RecommendedActionAgUnplugged = "recommendedActionAgUnplugged";

        public const string RecommendedActionBleDataPending = "recommendedActionBLEDataPending";

        public const string RecommendedActionBleHealthy = "recommendedActionBLEHealthy";

        public const string RecommendedActionBleLowBattery = "recommendedActionBLELowBattery";

        public const string RecommendedActionBleNotDetected = "recommendedActionBLENotDetected";

        public const string RecommendedActionCcHealthy = "recommendedActionCcHealthy";

        public const string RecommendedActionCcLowUptime = "recommendedActionCcLowUptime";

        public const string RecommendedActionCcMediaInputUptime =
            "recommendedActionCcMediaInputUptime";

        public const string RecommendedActionCcNotDetected = "recommendedActionCcNotDetected";

        public const string RecommendedActionCmCameraMisaligned =
            "recommendedActionCmCameraMisaligned";

        public const string RecommendedActionCmHealthy = "recommendedActionCmHealthy";

        public const string RecommendedActionCmInactive = "recommendedActionCmInactive";

        public const string RecommendedActionCmInwardCameraObstruction =
            "recommendedActionCmInwardCameraObstruction";

        public const string RecommendedActionCmIrregularRecording =
            "recommendedActionCmIrregularRecording";

        public const string RecommendedActionCmLowUptime = "recommendedActionCmLowUptime";

        public const string RecommendedActionCmNewlyInstalledDevice =
            "recommendedActionCmNewlyInstalledDevice";

        public const string RecommendedActionCmNotDetected = "recommendedActionCmNotDetected";

        public const string RecommendedActionCmOutwardCameraObstruction =
            "recommendedActionCmOutwardCameraObstruction";

        public const string RecommendedActionCmRecordingTimeRequired =
            "recommendedActionCmRecordingTimeRequired";

        public const string RecommendedActionCmVgUnplugged = "recommendedActionCmVgUnplugged";

        public const string RecommendedActionGatewayNewlyInstalledDevice =
            "recommendedActionGatewayNewlyInstalledDevice";

        public const string RecommendedActionHealthy = "recommendedActionHealthy";

        public const string RecommendedActionLowBatteryVoltage =
            "recommendedActionLowBatteryVoltage";

        public const string RecommendedActionOemNotReporting = "recommendedActionOemNotReporting";

        public const string RecommendedActionVehicleOff = "recommendedActionVehicleOff";

        public const string RecommendedActionVgHealthy = "recommendedActionVgHealthy";

        public const string RecommendedActionVgMissingEldDiagnostics =
            "recommendedActionVgMissingEldDiagnostics";

        public const string RecommendedActionVgMissingEldDiagnosticsExchangeSubmitted =
            "recommendedActionVgMissingEldDiagnosticsExchangeSubmitted";

        public const string RecommendedActionVgMissingEldDiagnosticsHardwareExchanged =
            "recommendedActionVgMissingEldDiagnosticsHardwareExchanged";

        public const string RecommendedActionVgMissingEldDiagnosticsNoExchangeSubmitted =
            "recommendedActionVgMissingEldDiagnosticsNoExchangeSubmitted";

        public const string RecommendedActionVgMissingVin = "recommendedActionVgMissingVin";

        public const string RecommendedActionVgNeedsReplacement =
            "recommendedActionVgNeedsReplacement";

        public const string RecommendedActionVgNotDetected = "recommendedActionVgNotDetected";

        public const string RecommendedActionVgVgUnplugged = "recommendedActionVgVgUnplugged";

        public const string Unknown = "unknown";
    }
}
