using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<GetQualificationRecordsStreamRequestEntityType>))]
[Serializable]
public readonly record struct GetQualificationRecordsStreamRequestEntityType : IStringEnum
{
    public static readonly GetQualificationRecordsStreamRequestEntityType Worker = new(
        Values.Worker
    );

    public static readonly GetQualificationRecordsStreamRequestEntityType Asset = new(Values.Asset);

    public GetQualificationRecordsStreamRequestEntityType(string value)
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
    public static GetQualificationRecordsStreamRequestEntityType FromCustom(string value)
    {
        return new GetQualificationRecordsStreamRequestEntityType(value);
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
        GetQualificationRecordsStreamRequestEntityType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetQualificationRecordsStreamRequestEntityType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetQualificationRecordsStreamRequestEntityType value) =>
        value.Value;

    public static explicit operator GetQualificationRecordsStreamRequestEntityType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Worker = "worker";

        public const string Asset = "asset";
    }
}
