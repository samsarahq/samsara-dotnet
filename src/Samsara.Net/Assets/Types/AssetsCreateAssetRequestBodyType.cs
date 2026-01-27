using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Assets;

[JsonConverter(typeof(StringEnumSerializer<AssetsCreateAssetRequestBodyType>))]
[Serializable]
public readonly record struct AssetsCreateAssetRequestBodyType : IStringEnum
{
    public static readonly AssetsCreateAssetRequestBodyType Uncategorized = new(
        Values.Uncategorized
    );

    public static readonly AssetsCreateAssetRequestBodyType Trailer = new(Values.Trailer);

    public static readonly AssetsCreateAssetRequestBodyType Equipment = new(Values.Equipment);

    public static readonly AssetsCreateAssetRequestBodyType Unpowered = new(Values.Unpowered);

    public static readonly AssetsCreateAssetRequestBodyType Vehicle = new(Values.Vehicle);

    public AssetsCreateAssetRequestBodyType(string value)
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
    public static AssetsCreateAssetRequestBodyType FromCustom(string value)
    {
        return new AssetsCreateAssetRequestBodyType(value);
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

    public static bool operator ==(AssetsCreateAssetRequestBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AssetsCreateAssetRequestBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AssetsCreateAssetRequestBodyType value) => value.Value;

    public static explicit operator AssetsCreateAssetRequestBodyType(string value) => new(value);

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
