using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<PlaceGeofenceSuggestionCandidateResponseResponseBodyType>)
)]
[Serializable]
public readonly record struct PlaceGeofenceSuggestionCandidateResponseResponseBodyType : IStringEnum
{
    public static readonly PlaceGeofenceSuggestionCandidateResponseResponseBodyType Building = new(
        Values.Building
    );

    public static readonly PlaceGeofenceSuggestionCandidateResponseResponseBodyType Parcel = new(
        Values.Parcel
    );

    public static readonly PlaceGeofenceSuggestionCandidateResponseResponseBodyType LandUse = new(
        Values.LandUse
    );

    public static readonly PlaceGeofenceSuggestionCandidateResponseResponseBodyType Boundary = new(
        Values.Boundary
    );

    public static readonly PlaceGeofenceSuggestionCandidateResponseResponseBodyType Facility = new(
        Values.Facility
    );

    public static readonly PlaceGeofenceSuggestionCandidateResponseResponseBodyType Infrastructure =
        new(Values.Infrastructure);

    public static readonly PlaceGeofenceSuggestionCandidateResponseResponseBodyType Unknown = new(
        Values.Unknown
    );

    public PlaceGeofenceSuggestionCandidateResponseResponseBodyType(string value)
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
    public static PlaceGeofenceSuggestionCandidateResponseResponseBodyType FromCustom(string value)
    {
        return new PlaceGeofenceSuggestionCandidateResponseResponseBodyType(value);
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
        PlaceGeofenceSuggestionCandidateResponseResponseBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        PlaceGeofenceSuggestionCandidateResponseResponseBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        PlaceGeofenceSuggestionCandidateResponseResponseBodyType value
    ) => value.Value;

    public static explicit operator PlaceGeofenceSuggestionCandidateResponseResponseBodyType(
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

        public const string Unknown = "unknown";
    }
}
