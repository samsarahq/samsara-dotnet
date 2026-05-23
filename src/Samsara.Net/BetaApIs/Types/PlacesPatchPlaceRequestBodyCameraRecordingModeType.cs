using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<PlacesPatchPlaceRequestBodyCameraRecordingModeType>))]
[Serializable]
public readonly record struct PlacesPatchPlaceRequestBodyCameraRecordingModeType : IStringEnum
{
    public static readonly PlacesPatchPlaceRequestBodyCameraRecordingModeType FullRecording = new(
        Values.FullRecording
    );

    public static readonly PlacesPatchPlaceRequestBodyCameraRecordingModeType DriverPrivacy = new(
        Values.DriverPrivacy
    );

    public static readonly PlacesPatchPlaceRequestBodyCameraRecordingModeType CompletePrivacy = new(
        Values.CompletePrivacy
    );

    public static readonly PlacesPatchPlaceRequestBodyCameraRecordingModeType Inherit = new(
        Values.Inherit
    );

    public static readonly PlacesPatchPlaceRequestBodyCameraRecordingModeType Unknown = new(
        Values.Unknown
    );

    public static readonly PlacesPatchPlaceRequestBodyCameraRecordingModeType Unspecified = new(
        Values.Unspecified
    );

    public PlacesPatchPlaceRequestBodyCameraRecordingModeType(string value)
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
    public static PlacesPatchPlaceRequestBodyCameraRecordingModeType FromCustom(string value)
    {
        return new PlacesPatchPlaceRequestBodyCameraRecordingModeType(value);
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
        PlacesPatchPlaceRequestBodyCameraRecordingModeType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PlacesPatchPlaceRequestBodyCameraRecordingModeType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PlacesPatchPlaceRequestBodyCameraRecordingModeType value
    ) => value.Value;

    public static explicit operator PlacesPatchPlaceRequestBodyCameraRecordingModeType(
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
