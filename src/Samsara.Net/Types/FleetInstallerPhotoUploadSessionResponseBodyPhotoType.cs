using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FleetInstallerPhotoUploadSessionResponseBodyPhotoType>))]
[Serializable]
public readonly record struct FleetInstallerPhotoUploadSessionResponseBodyPhotoType : IStringEnum
{
    public static readonly FleetInstallerPhotoUploadSessionResponseBodyPhotoType InstallPhoto = new(
        Values.InstallPhoto
    );

    public static readonly FleetInstallerPhotoUploadSessionResponseBodyPhotoType AssetPhoto = new(
        Values.AssetPhoto
    );

    public static readonly FleetInstallerPhotoUploadSessionResponseBodyPhotoType Unknown = new(
        Values.Unknown
    );

    public FleetInstallerPhotoUploadSessionResponseBodyPhotoType(string value)
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
    public static FleetInstallerPhotoUploadSessionResponseBodyPhotoType FromCustom(string value)
    {
        return new FleetInstallerPhotoUploadSessionResponseBodyPhotoType(value);
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
        FleetInstallerPhotoUploadSessionResponseBodyPhotoType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FleetInstallerPhotoUploadSessionResponseBodyPhotoType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FleetInstallerPhotoUploadSessionResponseBodyPhotoType value
    ) => value.Value;

    public static explicit operator FleetInstallerPhotoUploadSessionResponseBodyPhotoType(
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

        public const string Unknown = "unknown";
    }
}
