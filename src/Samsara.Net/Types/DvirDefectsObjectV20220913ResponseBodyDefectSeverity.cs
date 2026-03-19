using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DvirDefectsObjectV20220913ResponseBodyDefectSeverity>))]
[Serializable]
public readonly record struct DvirDefectsObjectV20220913ResponseBodyDefectSeverity : IStringEnum
{
    public static readonly DvirDefectsObjectV20220913ResponseBodyDefectSeverity Minor = new(
        Values.Minor
    );

    public static readonly DvirDefectsObjectV20220913ResponseBodyDefectSeverity Major = new(
        Values.Major
    );

    public static readonly DvirDefectsObjectV20220913ResponseBodyDefectSeverity Unspecified = new(
        Values.Unspecified
    );

    public DvirDefectsObjectV20220913ResponseBodyDefectSeverity(string value)
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
    public static DvirDefectsObjectV20220913ResponseBodyDefectSeverity FromCustom(string value)
    {
        return new DvirDefectsObjectV20220913ResponseBodyDefectSeverity(value);
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
        DvirDefectsObjectV20220913ResponseBodyDefectSeverity value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DvirDefectsObjectV20220913ResponseBodyDefectSeverity value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DvirDefectsObjectV20220913ResponseBodyDefectSeverity value
    ) => value.Value;

    public static explicit operator DvirDefectsObjectV20220913ResponseBodyDefectSeverity(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Minor = "minor";

        public const string Major = "major";

        public const string Unspecified = "unspecified";
    }
}
