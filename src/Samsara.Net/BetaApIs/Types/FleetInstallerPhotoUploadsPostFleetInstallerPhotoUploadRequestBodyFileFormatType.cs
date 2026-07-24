using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyFileFormatType>)
)]
[Serializable]
public readonly record struct FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyFileFormatType
    : IStringEnum
{
    public static readonly FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyFileFormatType ImageJpeg =
        new(Values.ImageJpeg);

    public static readonly FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyFileFormatType ImagePng =
        new(Values.ImagePng);

    public FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyFileFormatType(
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
    public static FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyFileFormatType FromCustom(
        string value
    )
    {
        return new FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyFileFormatType(
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
        FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyFileFormatType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyFileFormatType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyFileFormatType value
    ) => value.Value;

    public static explicit operator FleetInstallerPhotoUploadsPostFleetInstallerPhotoUploadRequestBodyFileFormatType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ImageJpeg = "imageJpeg";

        public const string ImagePng = "imagePng";
    }
}
