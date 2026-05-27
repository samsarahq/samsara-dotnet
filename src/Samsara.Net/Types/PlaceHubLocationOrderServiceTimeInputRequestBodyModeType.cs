using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PlaceHubLocationOrderServiceTimeInputRequestBodyModeType>)
)]
[Serializable]
public readonly record struct PlaceHubLocationOrderServiceTimeInputRequestBodyModeType : IStringEnum
{
    public static readonly PlaceHubLocationOrderServiceTimeInputRequestBodyModeType Fixed = new(
        Values.Fixed
    );

    public static readonly PlaceHubLocationOrderServiceTimeInputRequestBodyModeType Variable = new(
        Values.Variable
    );

    public static readonly PlaceHubLocationOrderServiceTimeInputRequestBodyModeType Unknown = new(
        Values.Unknown
    );

    public static readonly PlaceHubLocationOrderServiceTimeInputRequestBodyModeType Unspecified =
        new(Values.Unspecified);

    public PlaceHubLocationOrderServiceTimeInputRequestBodyModeType(string value)
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
    public static PlaceHubLocationOrderServiceTimeInputRequestBodyModeType FromCustom(string value)
    {
        return new PlaceHubLocationOrderServiceTimeInputRequestBodyModeType(value);
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
        PlaceHubLocationOrderServiceTimeInputRequestBodyModeType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PlaceHubLocationOrderServiceTimeInputRequestBodyModeType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PlaceHubLocationOrderServiceTimeInputRequestBodyModeType value
    ) => value.Value;

    public static explicit operator PlaceHubLocationOrderServiceTimeInputRequestBodyModeType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Fixed = "fixed";

        public const string Variable = "variable";

        public const string Unknown = "unknown";

        public const string Unspecified = "unspecified";
    }
}
