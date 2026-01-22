using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<AlertObjectAssetResponseBodyType>))]
[Serializable]
public readonly record struct AlertObjectAssetResponseBodyType : IStringEnum
{
    public static readonly AlertObjectAssetResponseBodyType Uncategorized = new(
        Values.Uncategorized
    );

    public static readonly AlertObjectAssetResponseBodyType Trailer = new(Values.Trailer);

    public static readonly AlertObjectAssetResponseBodyType Equipment = new(Values.Equipment);

    public static readonly AlertObjectAssetResponseBodyType Unpowered = new(Values.Unpowered);

    public static readonly AlertObjectAssetResponseBodyType Vehicle = new(Values.Vehicle);

    public AlertObjectAssetResponseBodyType(string value)
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
    public static AlertObjectAssetResponseBodyType FromCustom(string value)
    {
        return new AlertObjectAssetResponseBodyType(value);
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

    public static bool operator ==(AlertObjectAssetResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AlertObjectAssetResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AlertObjectAssetResponseBodyType value) => value.Value;

    public static explicit operator AlertObjectAssetResponseBodyType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Uncategorized = "uncategorized";

        public const string Trailer = "trailer";

        public const string Equipment = "equipment";

        public const string Unpowered = "unpowered";

        public const string Vehicle = "vehicle";
    }
}
