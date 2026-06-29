using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<FleetInstallerPhotoUploadCreateDataResponseBodyProcessingStatus>)
)]
[Serializable]
public readonly record struct FleetInstallerPhotoUploadCreateDataResponseBodyProcessingStatus
    : IStringEnum
{
    public static readonly FleetInstallerPhotoUploadCreateDataResponseBodyProcessingStatus AwaitingUpload =
        new(Values.AwaitingUpload);

    public static readonly FleetInstallerPhotoUploadCreateDataResponseBodyProcessingStatus Processing =
        new(Values.Processing);

    public static readonly FleetInstallerPhotoUploadCreateDataResponseBodyProcessingStatus Finished =
        new(Values.Finished);

    public static readonly FleetInstallerPhotoUploadCreateDataResponseBodyProcessingStatus Unknown =
        new(Values.Unknown);

    public FleetInstallerPhotoUploadCreateDataResponseBodyProcessingStatus(string value)
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
    public static FleetInstallerPhotoUploadCreateDataResponseBodyProcessingStatus FromCustom(
        string value
    )
    {
        return new FleetInstallerPhotoUploadCreateDataResponseBodyProcessingStatus(value);
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
        FleetInstallerPhotoUploadCreateDataResponseBodyProcessingStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FleetInstallerPhotoUploadCreateDataResponseBodyProcessingStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FleetInstallerPhotoUploadCreateDataResponseBodyProcessingStatus value
    ) => value.Value;

    public static explicit operator FleetInstallerPhotoUploadCreateDataResponseBodyProcessingStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AwaitingUpload = "awaitingUpload";

        public const string Processing = "processing";

        public const string Finished = "finished";

        public const string Unknown = "unknown";
    }
}
