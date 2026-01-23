using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Assets;

[JsonConverter(typeof(StringEnumSerializer<AssetsUpdateAssetRequestBodyType>))]
[Serializable]
public readonly record struct AssetsUpdateAssetRequestBodyType : IStringEnum
{
    public static readonly AssetsUpdateAssetRequestBodyType Uncategorized = new(
        Values.Uncategorized
    );

    public static readonly AssetsUpdateAssetRequestBodyType Trailer = new(Values.Trailer);

    public static readonly AssetsUpdateAssetRequestBodyType Equipment = new(Values.Equipment);

    public static readonly AssetsUpdateAssetRequestBodyType Unpowered = new(Values.Unpowered);

    public static readonly AssetsUpdateAssetRequestBodyType Vehicle = new(Values.Vehicle);

    public AssetsUpdateAssetRequestBodyType(string value)
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
    public static AssetsUpdateAssetRequestBodyType FromCustom(string value)
    {
        return new AssetsUpdateAssetRequestBodyType(value);
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

    public static bool operator ==(AssetsUpdateAssetRequestBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AssetsUpdateAssetRequestBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AssetsUpdateAssetRequestBodyType value) => value.Value;

    public static explicit operator AssetsUpdateAssetRequestBodyType(string value) => new(value);

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
