using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PlaceGeofenceAutoFallbackBehaviorInputRequestBodyBehaviorType>)
)]
[Serializable]
public readonly record struct PlaceGeofenceAutoFallbackBehaviorInputRequestBodyBehaviorType
    : IStringEnum
{
    public static readonly PlaceGeofenceAutoFallbackBehaviorInputRequestBodyBehaviorType Fail = new(
        Values.Fail
    );

    public static readonly PlaceGeofenceAutoFallbackBehaviorInputRequestBodyBehaviorType Circle =
        new(Values.Circle);

    public PlaceGeofenceAutoFallbackBehaviorInputRequestBodyBehaviorType(string value)
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
    public static PlaceGeofenceAutoFallbackBehaviorInputRequestBodyBehaviorType FromCustom(
        string value
    )
    {
        return new PlaceGeofenceAutoFallbackBehaviorInputRequestBodyBehaviorType(value);
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
        PlaceGeofenceAutoFallbackBehaviorInputRequestBodyBehaviorType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PlaceGeofenceAutoFallbackBehaviorInputRequestBodyBehaviorType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PlaceGeofenceAutoFallbackBehaviorInputRequestBodyBehaviorType value
    ) => value.Value;

    public static explicit operator PlaceGeofenceAutoFallbackBehaviorInputRequestBodyBehaviorType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Fail = "fail";

        public const string Circle = "circle";
    }
}
