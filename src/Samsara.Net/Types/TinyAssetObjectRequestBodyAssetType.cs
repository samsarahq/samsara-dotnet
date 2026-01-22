using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<TinyAssetObjectRequestBodyAssetType>))]
[Serializable]
public readonly record struct TinyAssetObjectRequestBodyAssetType : IStringEnum
{
    public static readonly TinyAssetObjectRequestBodyAssetType Uncategorized = new(
        Values.Uncategorized
    );

    public static readonly TinyAssetObjectRequestBodyAssetType Trailer = new(Values.Trailer);

    public static readonly TinyAssetObjectRequestBodyAssetType Equipment = new(Values.Equipment);

    public static readonly TinyAssetObjectRequestBodyAssetType Unpowered = new(Values.Unpowered);

    public static readonly TinyAssetObjectRequestBodyAssetType Vehicle = new(Values.Vehicle);

    public TinyAssetObjectRequestBodyAssetType(string value)
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
    public static TinyAssetObjectRequestBodyAssetType FromCustom(string value)
    {
        return new TinyAssetObjectRequestBodyAssetType(value);
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

    public static bool operator ==(TinyAssetObjectRequestBodyAssetType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(TinyAssetObjectRequestBodyAssetType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(TinyAssetObjectRequestBodyAssetType value) =>
        value.Value;

    public static explicit operator TinyAssetObjectRequestBodyAssetType(string value) => new(value);

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
