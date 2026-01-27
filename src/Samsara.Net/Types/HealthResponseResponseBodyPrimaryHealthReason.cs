using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<HealthResponseResponseBodyPrimaryHealthReason>))]
[Serializable]
public readonly record struct HealthResponseResponseBodyPrimaryHealthReason : IStringEnum
{
    public static readonly HealthResponseResponseBodyPrimaryHealthReason AssetUnplugged = new(
        Values.AssetUnplugged
    );

    public static readonly HealthResponseResponseBodyPrimaryHealthReason CameraMisaligned = new(
        Values.CameraMisaligned
    );

    public static readonly HealthResponseResponseBodyPrimaryHealthReason DataPending = new(
        Values.DataPending
    );

    public static readonly HealthResponseResponseBodyPrimaryHealthReason Healthy = new(
        Values.Healthy
    );

    public static readonly HealthResponseResponseBodyPrimaryHealthReason InwardCameraObstruction =
        new(Values.InwardCameraObstruction);

    public static readonly HealthResponseResponseBodyPrimaryHealthReason IrregularRecording = new(
        Values.IrregularRecording
    );

    public static readonly HealthResponseResponseBodyPrimaryHealthReason LowDeviceBattery = new(
        Values.LowDeviceBattery
    );

    public static readonly HealthResponseResponseBodyPrimaryHealthReason MissingEldDiagnostics =
        new(Values.MissingEldDiagnostics);

    public static readonly HealthResponseResponseBodyPrimaryHealthReason MissingVin = new(
        Values.MissingVin
    );

    public static readonly HealthResponseResponseBodyPrimaryHealthReason NeedsReplacement = new(
        Values.NeedsReplacement
    );

    public static readonly HealthResponseResponseBodyPrimaryHealthReason NewlyInstalledDevice = new(
        Values.NewlyInstalledDevice
    );

    public static readonly HealthResponseResponseBodyPrimaryHealthReason NoGpsSignal = new(
        Values.NoGpsSignal
    );

    public static readonly HealthResponseResponseBodyPrimaryHealthReason NotDetected = new(
        Values.NotDetected
    );

    public static readonly HealthResponseResponseBodyPrimaryHealthReason OutwardCameraObstruction =
        new(Values.OutwardCameraObstruction);

    public static readonly HealthResponseResponseBodyPrimaryHealthReason RecordingTimeRequired =
        new(Values.RecordingTimeRequired);

    public static readonly HealthResponseResponseBodyPrimaryHealthReason Unknown = new(
        Values.Unknown
    );

    public static readonly HealthResponseResponseBodyPrimaryHealthReason VgUnplugged = new(
        Values.VgUnplugged
    );

    public HealthResponseResponseBodyPrimaryHealthReason(string value)
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
    public static HealthResponseResponseBodyPrimaryHealthReason FromCustom(string value)
    {
        return new HealthResponseResponseBodyPrimaryHealthReason(value);
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
        HealthResponseResponseBodyPrimaryHealthReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        HealthResponseResponseBodyPrimaryHealthReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(HealthResponseResponseBodyPrimaryHealthReason value) =>
        value.Value;

    public static explicit operator HealthResponseResponseBodyPrimaryHealthReason(string value) =>
        new(value);

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
