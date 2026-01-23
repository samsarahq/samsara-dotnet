using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem>)
)]
[Serializable]
public readonly record struct FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem
    : IStringEnum
{
    public static readonly FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem Vehicle =
        new(Values.Vehicle);

    public static readonly FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem Trailer =
        new(Values.Trailer);

    public static readonly FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem Equipment =
        new(Values.Equipment);

    public static readonly FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem UnpoweredAsset =
        new(Values.UnpoweredAsset);

    public FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem(string value)
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
    public static FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem FromCustom(
        string value
    )
    {
        return new FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem(value);
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
        FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem value
    ) => value.Value;

    public static explicit operator FormsFieldDefinitionObjectResponseBodyAllowedAssetTypesItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Vehicle = "vehicle";

        public const string Trailer = "trailer";

        public const string Equipment = "equipment";

        public const string UnpoweredAsset = "unpoweredAsset";
    }
}
