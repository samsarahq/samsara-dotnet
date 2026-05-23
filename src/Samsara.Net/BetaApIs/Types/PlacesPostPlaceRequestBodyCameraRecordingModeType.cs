using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<PlacesPostPlaceRequestBodyCameraRecordingModeType>))]
[Serializable]
public readonly record struct PlacesPostPlaceRequestBodyCameraRecordingModeType : IStringEnum
{
    public static readonly PlacesPostPlaceRequestBodyCameraRecordingModeType FullRecording = new(
        Values.FullRecording
    );

    public static readonly PlacesPostPlaceRequestBodyCameraRecordingModeType DriverPrivacy = new(
        Values.DriverPrivacy
    );

    public static readonly PlacesPostPlaceRequestBodyCameraRecordingModeType CompletePrivacy = new(
        Values.CompletePrivacy
    );

    public static readonly PlacesPostPlaceRequestBodyCameraRecordingModeType Inherit = new(
        Values.Inherit
    );

    public static readonly PlacesPostPlaceRequestBodyCameraRecordingModeType Unknown = new(
        Values.Unknown
    );

    public static readonly PlacesPostPlaceRequestBodyCameraRecordingModeType Unspecified = new(
        Values.Unspecified
    );

    public PlacesPostPlaceRequestBodyCameraRecordingModeType(string value)
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
    public static PlacesPostPlaceRequestBodyCameraRecordingModeType FromCustom(string value)
    {
        return new PlacesPostPlaceRequestBodyCameraRecordingModeType(value);
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
        PlacesPostPlaceRequestBodyCameraRecordingModeType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PlacesPostPlaceRequestBodyCameraRecordingModeType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PlacesPostPlaceRequestBodyCameraRecordingModeType value
    ) => value.Value;

    public static explicit operator PlacesPostPlaceRequestBodyCameraRecordingModeType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string FullRecording = "fullRecording";

        public const string DriverPrivacy = "driverPrivacy";

        public const string CompletePrivacy = "completePrivacy";

        public const string Inherit = "inherit";

        public const string Unknown = "unknown";

        public const string Unspecified = "unspecified";
    }
}
