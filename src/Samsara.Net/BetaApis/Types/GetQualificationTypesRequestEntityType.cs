using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApis;

[JsonConverter(typeof(StringEnumSerializer<GetQualificationTypesRequestEntityType>))]
[Serializable]
public readonly record struct GetQualificationTypesRequestEntityType : IStringEnum
{
    public static readonly GetQualificationTypesRequestEntityType Worker = new(Values.Worker);

    public static readonly GetQualificationTypesRequestEntityType Asset = new(Values.Asset);

    public GetQualificationTypesRequestEntityType(string value)
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
    public static GetQualificationTypesRequestEntityType FromCustom(string value)
    {
        return new GetQualificationTypesRequestEntityType(value);
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

    public static bool operator ==(GetQualificationTypesRequestEntityType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetQualificationTypesRequestEntityType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetQualificationTypesRequestEntityType value) =>
        value.Value;

    public static explicit operator GetQualificationTypesRequestEntityType(string value) =>
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
