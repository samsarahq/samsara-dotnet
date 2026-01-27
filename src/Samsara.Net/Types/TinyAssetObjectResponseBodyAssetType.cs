using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<TinyAssetObjectResponseBodyAssetType>))]
[Serializable]
public readonly record struct TinyAssetObjectResponseBodyAssetType : IStringEnum
{
    public static readonly TinyAssetObjectResponseBodyAssetType Uncategorized = new(
        Values.Uncategorized
    );

    public static readonly TinyAssetObjectResponseBodyAssetType Trailer = new(Values.Trailer);

    public static readonly TinyAssetObjectResponseBodyAssetType Equipment = new(Values.Equipment);

    public static readonly TinyAssetObjectResponseBodyAssetType Unpowered = new(Values.Unpowered);

    public static readonly TinyAssetObjectResponseBodyAssetType Vehicle = new(Values.Vehicle);

    public TinyAssetObjectResponseBodyAssetType(string value)
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
    public static TinyAssetObjectResponseBodyAssetType FromCustom(string value)
    {
        return new TinyAssetObjectResponseBodyAssetType(value);
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

    public static bool operator ==(TinyAssetObjectResponseBodyAssetType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TinyAssetObjectResponseBodyAssetType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TinyAssetObjectResponseBodyAssetType value) =>
        value.Value;

    public static explicit operator TinyAssetObjectResponseBodyAssetType(string value) =>
        new(value);

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
