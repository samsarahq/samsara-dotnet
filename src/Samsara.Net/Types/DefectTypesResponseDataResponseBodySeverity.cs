using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DefectTypesResponseDataResponseBodySeverity>))]
[Serializable]
public readonly record struct DefectTypesResponseDataResponseBodySeverity : IStringEnum
{
    public static readonly DefectTypesResponseDataResponseBodySeverity Major = new(Values.Major);

    public static readonly DefectTypesResponseDataResponseBodySeverity Minor = new(Values.Minor);

    public static readonly DefectTypesResponseDataResponseBodySeverity NotApplicable = new(
        Values.NotApplicable
    );

    public DefectTypesResponseDataResponseBodySeverity(string value)
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
    public static DefectTypesResponseDataResponseBodySeverity FromCustom(string value)
    {
        return new DefectTypesResponseDataResponseBodySeverity(value);
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
        DefectTypesResponseDataResponseBodySeverity value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DefectTypesResponseDataResponseBodySeverity value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DefectTypesResponseDataResponseBodySeverity value) =>
        value.Value;

    public static explicit operator DefectTypesResponseDataResponseBodySeverity(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Major = "major";

        public const string Minor = "minor";

        public const string NotApplicable = "notApplicable";
    }
}
