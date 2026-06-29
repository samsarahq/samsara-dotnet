using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType>)
)]
[Serializable]
public readonly record struct FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType
    : IStringEnum
{
    public static readonly FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType VehicleGateway =
        new(Values.VehicleGateway);

    public static readonly FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType AssetGateway =
        new(Values.AssetGateway);

    public static readonly FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType Camera = new(
        Values.Camera
    );

    public static readonly FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType CameraConnector =
        new(Values.CameraConnector);

    public static readonly FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType EnvironmentalMonitor =
        new(Values.EnvironmentalMonitor);

    public static readonly FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType AssetTag =
        new(Values.AssetTag);

    public static readonly FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType TrackingLabel =
        new(Values.TrackingLabel);

    public static readonly FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType Unknown =
        new(Values.Unknown);

    public FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType(string value)
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
    public static FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType FromCustom(
        string value
    )
    {
        return new FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType(value);
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
        FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType value
    ) => value.Value;

    public static explicit operator FleetInstallerPhotoUploadCreateDataResponseBodyHardwareType(
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
