using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<Dvir2SubmissionResponseObjectResponseBodyInspectionType>)
)]
[Serializable]
public readonly record struct Dvir2SubmissionResponseObjectResponseBodyInspectionType : IStringEnum
{
    public static readonly Dvir2SubmissionResponseObjectResponseBodyInspectionType PreTrip = new(
        Values.PreTrip
    );

    public static readonly Dvir2SubmissionResponseObjectResponseBodyInspectionType PostTrip = new(
        Values.PostTrip
    );

    public static readonly Dvir2SubmissionResponseObjectResponseBodyInspectionType Mechanic = new(
        Values.Mechanic
    );

    public static readonly Dvir2SubmissionResponseObjectResponseBodyInspectionType Unset = new(
        Values.Unset
    );

    public Dvir2SubmissionResponseObjectResponseBodyInspectionType(string value)
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
    public static Dvir2SubmissionResponseObjectResponseBodyInspectionType FromCustom(string value)
    {
        return new Dvir2SubmissionResponseObjectResponseBodyInspectionType(value);
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
        Dvir2SubmissionResponseObjectResponseBodyInspectionType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        Dvir2SubmissionResponseObjectResponseBodyInspectionType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        Dvir2SubmissionResponseObjectResponseBodyInspectionType value
    ) => value.Value;

    public static explicit operator Dvir2SubmissionResponseObjectResponseBodyInspectionType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string PreTrip = "preTrip";

        public const string PostTrip = "postTrip";

        public const string Mechanic = "mechanic";

        public const string Unset = "unset";
    }
}
