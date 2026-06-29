using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<FleetInstallerPhotoUploadSessionResponseBodyHardwareType>)
)]
[Serializable]
public readonly record struct FleetInstallerPhotoUploadSessionResponseBodyHardwareType : IStringEnum
{
    public static readonly FleetInstallerPhotoUploadSessionResponseBodyHardwareType VehicleGateway =
        new(Values.VehicleGateway);

    public static readonly FleetInstallerPhotoUploadSessionResponseBodyHardwareType AssetGateway =
        new(Values.AssetGateway);

    public static readonly FleetInstallerPhotoUploadSessionResponseBodyHardwareType Camera = new(
        Values.Camera
    );

    public static readonly FleetInstallerPhotoUploadSessionResponseBodyHardwareType CameraConnector =
        new(Values.CameraConnector);

    public static readonly FleetInstallerPhotoUploadSessionResponseBodyHardwareType EnvironmentalMonitor =
        new(Values.EnvironmentalMonitor);

    public static readonly FleetInstallerPhotoUploadSessionResponseBodyHardwareType AssetTag = new(
        Values.AssetTag
    );

    public static readonly FleetInstallerPhotoUploadSessionResponseBodyHardwareType TrackingLabel =
        new(Values.TrackingLabel);

    public static readonly FleetInstallerPhotoUploadSessionResponseBodyHardwareType Unknown = new(
        Values.Unknown
    );

    public FleetInstallerPhotoUploadSessionResponseBodyHardwareType(string value)
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
    public static FleetInstallerPhotoUploadSessionResponseBodyHardwareType FromCustom(string value)
    {
        return new FleetInstallerPhotoUploadSessionResponseBodyHardwareType(value);
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
        FleetInstallerPhotoUploadSessionResponseBodyHardwareType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FleetInstallerPhotoUploadSessionResponseBodyHardwareType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FleetInstallerPhotoUploadSessionResponseBodyHardwareType value
    ) => value.Value;

    public static explicit operator FleetInstallerPhotoUploadSessionResponseBodyHardwareType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string VehicleGateway = "vehicleGateway";

        public const string AssetGateway = "assetGateway";

        public const string Camera = "camera";

        public const string CameraConnector = "cameraConnector";

        public const string EnvironmentalMonitor = "environmentalMonitor";

        public const string AssetTag = "assetTag";

        public const string TrackingLabel = "trackingLabel";

        public const string Unknown = "unknown";
    }
}
