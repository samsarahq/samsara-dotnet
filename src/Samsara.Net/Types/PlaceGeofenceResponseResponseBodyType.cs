using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PlaceGeofenceResponseResponseBodyType>))]
[Serializable]
public readonly record struct PlaceGeofenceResponseResponseBodyType : IStringEnum
{
    public static readonly PlaceGeofenceResponseResponseBodyType Circle = new(Values.Circle);

    public static readonly PlaceGeofenceResponseResponseBodyType Polygon = new(Values.Polygon);

    public static readonly PlaceGeofenceResponseResponseBodyType Unknown = new(Values.Unknown);

    public PlaceGeofenceResponseResponseBodyType(string value)
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
    public static PlaceGeofenceResponseResponseBodyType FromCustom(string value)
    {
        return new PlaceGeofenceResponseResponseBodyType(value);
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

    public static bool operator ==(PlaceGeofenceResponseResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(PlaceGeofenceResponseResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(PlaceGeofenceResponseResponseBodyType value) =>
        value.Value;

    public static explicit operator PlaceGeofenceResponseResponseBodyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Circle = "circle";

        public const string Polygon = "polygon";

        public const string Unknown = "unknown";
    }
}
