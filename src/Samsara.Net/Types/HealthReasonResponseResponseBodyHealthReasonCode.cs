using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<HealthReasonResponseResponseBodyHealthReasonCode>))]
[Serializable]
public readonly record struct HealthReasonResponseResponseBodyHealthReasonCode : IStringEnum
{
    public static readonly HealthReasonResponseResponseBodyHealthReasonCode AssetUnplugged = new(
        Values.AssetUnplugged
    );

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode CameraMisaligned = new(
        Values.CameraMisaligned
    );

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode DataPending = new(
        Values.DataPending
    );

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode Healthy = new(
        Values.Healthy
    );

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode InwardCameraObstruction =
        new(Values.InwardCameraObstruction);

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode IrregularRecording =
        new(Values.IrregularRecording);

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode LowDeviceBattery = new(
        Values.LowDeviceBattery
    );

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode MissingEldDiagnostics =
        new(Values.MissingEldDiagnostics);

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode MissingVin = new(
        Values.MissingVin
    );

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode NeedsReplacement = new(
        Values.NeedsReplacement
    );

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode NewlyInstalledDevice =
        new(Values.NewlyInstalledDevice);

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode NoGpsSignal = new(
        Values.NoGpsSignal
    );

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode NotDetected = new(
        Values.NotDetected
    );

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode OutwardCameraObstruction =
        new(Values.OutwardCameraObstruction);

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode RecordingTimeRequired =
        new(Values.RecordingTimeRequired);

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode Unknown = new(
        Values.Unknown
    );

    public static readonly HealthReasonResponseResponseBodyHealthReasonCode VgUnplugged = new(
        Values.VgUnplugged
    );

    public HealthReasonResponseResponseBodyHealthReasonCode(string value)
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
    public static HealthReasonResponseResponseBodyHealthReasonCode FromCustom(string value)
    {
        return new HealthReasonResponseResponseBodyHealthReasonCode(value);
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
        HealthReasonResponseResponseBodyHealthReasonCode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        HealthReasonResponseResponseBodyHealthReasonCode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        HealthReasonResponseResponseBodyHealthReasonCode value
    ) => value.Value;

    public static explicit operator HealthReasonResponseResponseBodyHealthReasonCode(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AssetUnplugged = "assetUnplugged";

        public const string CameraMisaligned = "cameraMisaligned";

        public const string DataPending = "dataPending";

        public const string Healthy = "healthy";

        public const string InwardCameraObstruction = "inwardCameraObstruction";

        public const string IrregularRecording = "irregularRecording";

        public const string LowDeviceBattery = "lowDeviceBattery";

        public const string MissingEldDiagnostics = "missingEldDiagnostics";

        public const string MissingVin = "missingVin";

        public const string NeedsReplacement = "needsReplacement";

        public const string NewlyInstalledDevice = "newlyInstalledDevice";

        public const string NoGpsSignal = "noGpsSignal";

        public const string NotDetected = "notDetected";

        public const string OutwardCameraObstruction = "outwardCameraObstruction";

        public const string RecordingTimeRequired = "recordingTimeRequired";

        public const string Unknown = "unknown";

        public const string VgUnplugged = "vgUnplugged";
    }
}
