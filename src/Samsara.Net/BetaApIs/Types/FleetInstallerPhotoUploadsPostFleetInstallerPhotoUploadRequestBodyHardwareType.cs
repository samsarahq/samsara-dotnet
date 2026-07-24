using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType>)
)]
[Serializable]
public readonly record struct FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType
    : IStringEnum
{
    public static readonly FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType VehicleGateway =
        new(Values.VehicleGateway);

    public static readonly FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType AssetGateway =
        new(Values.AssetGateway);

    public static readonly FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType Camera =
        new(Values.Camera);

    public static readonly FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType CameraConnector =
        new(Values.CameraConnector);

    public static readonly FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType EnvironmentalMonitor =
        new(Values.EnvironmentalMonitor);

    public static readonly FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType AssetTag =
        new(Values.AssetTag);

    public static readonly FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType TrackingLabel =
        new(Values.TrackingLabel);

    public FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType(
        string value
    )
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
    public static FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType FromCustom(
        string value
    )
    {
        return new FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType(
            value
        );
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
        FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType value
    ) => value.Value;

    public static explicit operator FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyHardwareType(
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
    }
}
