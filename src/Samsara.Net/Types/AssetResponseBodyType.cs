using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<AssetResponseBodyType>))]
[Serializable]
public readonly record struct AssetResponseBodyType : IStringEnum
{
    public static readonly AssetResponseBodyType Uncategorized = new(Values.Uncategorized);

    public static readonly AssetResponseBodyType Trailer = new(Values.Trailer);

    public static readonly AssetResponseBodyType Equipment = new(Values.Equipment);

    public static readonly AssetResponseBodyType Unpowered = new(Values.Unpowered);

    public static readonly AssetResponseBodyType Vehicle = new(Values.Vehicle);

    public AssetResponseBodyType(string value)
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
    public static AssetResponseBodyType FromCustom(string value)
    {
        return new AssetResponseBodyType(value);
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

    public static bool operator ==(AssetResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AssetResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AssetResponseBodyType value) => value.Value;

    public static explicit operator AssetResponseBodyType(string value) => new(value);

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
