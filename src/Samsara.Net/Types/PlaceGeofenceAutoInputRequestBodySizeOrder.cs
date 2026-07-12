using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PlaceGeofenceAutoInputRequestBodySizeOrder>))]
[Serializable]
public readonly record struct PlaceGeofenceAutoInputRequestBodySizeOrder : IStringEnum
{
    public static readonly PlaceGeofenceAutoInputRequestBodySizeOrder SmallestFirst = new(
        Values.SmallestFirst
    );

    public static readonly PlaceGeofenceAutoInputRequestBodySizeOrder LargestFirst = new(
        Values.LargestFirst
    );

    public PlaceGeofenceAutoInputRequestBodySizeOrder(string value)
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
    public static PlaceGeofenceAutoInputRequestBodySizeOrder FromCustom(string value)
    {
        return new PlaceGeofenceAutoInputRequestBodySizeOrder(value);
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
        PlaceGeofenceAutoInputRequestBodySizeOrder value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PlaceGeofenceAutoInputRequestBodySizeOrder value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(PlaceGeofenceAutoInputRequestBodySizeOrder value) =>
        value.Value;

    public static explicit operator PlaceGeofenceAutoInputRequestBodySizeOrder(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string SmallestFirst = "smallestFirst";

        public const string LargestFirst = "largestFirst";
    }
}
