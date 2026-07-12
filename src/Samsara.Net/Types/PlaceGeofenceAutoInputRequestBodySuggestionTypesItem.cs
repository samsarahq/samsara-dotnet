using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<PlaceGeofenceAutoInputRequestBodySuggestionTypesItem>))]
[Serializable]
public readonly record struct PlaceGeofenceAutoInputRequestBodySuggestionTypesItem : IStringEnum
{
    public static readonly PlaceGeofenceAutoInputRequestBodySuggestionTypesItem Building = new(
        Values.Building
    );

    public static readonly PlaceGeofenceAutoInputRequestBodySuggestionTypesItem Parcel = new(
        Values.Parcel
    );

    public static readonly PlaceGeofenceAutoInputRequestBodySuggestionTypesItem LandUse = new(
        Values.LandUse
    );

    public static readonly PlaceGeofenceAutoInputRequestBodySuggestionTypesItem Boundary = new(
        Values.Boundary
    );

    public static readonly PlaceGeofenceAutoInputRequestBodySuggestionTypesItem Facility = new(
        Values.Facility
    );

    public static readonly PlaceGeofenceAutoInputRequestBodySuggestionTypesItem Infrastructure =
        new(Values.Infrastructure);

    public PlaceGeofenceAutoInputRequestBodySuggestionTypesItem(string value)
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
    public static PlaceGeofenceAutoInputRequestBodySuggestionTypesItem FromCustom(string value)
    {
        return new PlaceGeofenceAutoInputRequestBodySuggestionTypesItem(value);
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
        PlaceGeofenceAutoInputRequestBodySuggestionTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PlaceGeofenceAutoInputRequestBodySuggestionTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PlaceGeofenceAutoInputRequestBodySuggestionTypesItem value
    ) => value.Value;

    public static explicit operator PlaceGeofenceAutoInputRequestBodySuggestionTypesItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Building = "building";

        public const string Parcel = "parcel";

        public const string LandUse = "landUse";

        public const string Boundary = "boundary";

        public const string Facility = "facility";

        public const string Infrastructure = "infrastructure";
    }
}
