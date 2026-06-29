using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<FleetInstallerPhotoUploadSessionResponseBodyFileFormatType>)
)]
[Serializable]
public readonly record struct FleetInstallerPhotoUploadSessionResponseBodyFileFormatType
    : IStringEnum
{
    public static readonly FleetInstallerPhotoUploadSessionResponseBodyFileFormatType ImageJpeg =
        new(Values.ImageJpeg);

    public static readonly FleetInstallerPhotoUploadSessionResponseBodyFileFormatType ImagePng =
        new(Values.ImagePng);

    public static readonly FleetInstallerPhotoUploadSessionResponseBodyFileFormatType Unknown = new(
        Values.Unknown
    );

    public FleetInstallerPhotoUploadSessionResponseBodyFileFormatType(string value)
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
    public static FleetInstallerPhotoUploadSessionResponseBodyFileFormatType FromCustom(
        string value
    )
    {
        return new FleetInstallerPhotoUploadSessionResponseBodyFileFormatType(value);
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
        FleetInstallerPhotoUploadSessionResponseBodyFileFormatType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FleetInstallerPhotoUploadSessionResponseBodyFileFormatType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FleetInstallerPhotoUploadSessionResponseBodyFileFormatType value
    ) => value.Value;

    public static explicit operator FleetInstallerPhotoUploadSessionResponseBodyFileFormatType(
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

        public const string Unknown = "unknown";
    }
}
