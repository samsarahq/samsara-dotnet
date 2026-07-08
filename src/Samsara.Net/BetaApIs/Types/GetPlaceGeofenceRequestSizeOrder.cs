using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<GetPlaceGeofenceRequestSizeOrder>))]
[Serializable]
public readonly record struct GetPlaceGeofenceRequestSizeOrder : IStringEnum
{
    public static readonly GetPlaceGeofenceRequestSizeOrder SmallestFirst = new(
        Values.SmallestFirst
    );

    public static readonly GetPlaceGeofenceRequestSizeOrder LargestFirst = new(Values.LargestFirst);

    public GetPlaceGeofenceRequestSizeOrder(string value)
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
    public static GetPlaceGeofenceRequestSizeOrder FromCustom(string value)
    {
        return new GetPlaceGeofenceRequestSizeOrder(value);
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

    public static bool operator ==(GetPlaceGeofenceRequestSizeOrder value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetPlaceGeofenceRequestSizeOrder value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetPlaceGeofenceRequestSizeOrder value) => value.Value;

    public static explicit operator GetPlaceGeofenceRequestSizeOrder(string value) => new(value);

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
