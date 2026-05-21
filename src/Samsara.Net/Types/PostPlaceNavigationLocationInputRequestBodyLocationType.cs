using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PostPlaceNavigationLocationInputRequestBodyLocationType>)
)]
[Serializable]
public readonly record struct PostPlaceNavigationLocationInputRequestBodyLocationType : IStringEnum
{
    public static readonly PostPlaceNavigationLocationInputRequestBodyLocationType Entrance = new(
        Values.Entrance
    );

    public static readonly PostPlaceNavigationLocationInputRequestBodyLocationType Exit = new(
        Values.Exit
    );

    public static readonly PostPlaceNavigationLocationInputRequestBodyLocationType TwoWay = new(
        Values.TwoWay
    );

    public PostPlaceNavigationLocationInputRequestBodyLocationType(string value)
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
    public static PostPlaceNavigationLocationInputRequestBodyLocationType FromCustom(string value)
    {
        return new PostPlaceNavigationLocationInputRequestBodyLocationType(value);
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
        PostPlaceNavigationLocationInputRequestBodyLocationType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PostPlaceNavigationLocationInputRequestBodyLocationType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PostPlaceNavigationLocationInputRequestBodyLocationType value
    ) => value.Value;

    public static explicit operator PostPlaceNavigationLocationInputRequestBodyLocationType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Entrance = "entrance";

        public const string Exit = "exit";

        public const string TwoWay = "twoWay";
    }
}
