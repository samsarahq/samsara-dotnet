using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyPhotoType>)
)]
[Serializable]
public readonly record struct FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyPhotoType
    : IStringEnum
{
    public static readonly FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyPhotoType InstallPhoto =
        new(Values.InstallPhoto);

    public static readonly FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyPhotoType AssetPhoto =
        new(Values.AssetPhoto);

    public FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyPhotoType(string value)
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
    public static FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyPhotoType FromCustom(
        string value
    )
    {
        return new FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyPhotoType(
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
        FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyPhotoType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyPhotoType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyPhotoType value
    ) => value.Value;

    public static explicit operator FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyPhotoType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string InstallPhoto = "installPhoto";

        public const string AssetPhoto = "assetPhoto";
    }
}
