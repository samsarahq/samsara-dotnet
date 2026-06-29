using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<FleetInstallerPhotoUploadCreateDataResponseBodyFileFormatType>)
)]
[Serializable]
public readonly record struct FleetInstallerPhotoUploadCreateDataResponseBodyFileFormatType
    : IStringEnum
{
    public static readonly FleetInstallerPhotoUploadCreateDataResponseBodyFileFormatType ImageJpeg =
        new(Values.ImageJpeg);

    public static readonly FleetInstallerPhotoUploadCreateDataResponseBodyFileFormatType ImagePng =
        new(Values.ImagePng);

    public static readonly FleetInstallerPhotoUploadCreateDataResponseBodyFileFormatType Unknown =
        new(Values.Unknown);

    public FleetInstallerPhotoUploadCreateDataResponseBodyFileFormatType(string value)
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
    public static FleetInstallerPhotoUploadCreateDataResponseBodyFileFormatType FromCustom(
        string value
    )
    {
        return new FleetInstallerPhotoUploadCreateDataResponseBodyFileFormatType(value);
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
        FleetInstallerPhotoUploadCreateDataResponseBodyFileFormatType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FleetInstallerPhotoUploadCreateDataResponseBodyFileFormatType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FleetInstallerPhotoUploadCreateDataResponseBodyFileFormatType value
    ) => value.Value;

    public static explicit operator FleetInstallerPhotoUploadCreateDataResponseBodyFileFormatType(
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
