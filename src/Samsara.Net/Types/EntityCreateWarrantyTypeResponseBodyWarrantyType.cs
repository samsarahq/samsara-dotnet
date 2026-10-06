using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityCreateWarrantyTypeResponseBodyWarrantyType>))]
[Serializable]
public readonly record struct EntityCreateWarrantyTypeResponseBodyWarrantyType : IStringEnum
{
    public static readonly EntityCreateWarrantyTypeResponseBodyWarrantyType Unknown = new(
        Values.Unknown
    );

    public static readonly EntityCreateWarrantyTypeResponseBodyWarrantyType Manufacturer = new(
        Values.Manufacturer
    );

    public static readonly EntityCreateWarrantyTypeResponseBodyWarrantyType Extended = new(
        Values.Extended
    );

    public static readonly EntityCreateWarrantyTypeResponseBodyWarrantyType Other = new(
        Values.Other
    );

    public EntityCreateWarrantyTypeResponseBodyWarrantyType(string value)
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
    public static EntityCreateWarrantyTypeResponseBodyWarrantyType FromCustom(string value)
    {
        return new EntityCreateWarrantyTypeResponseBodyWarrantyType(value);
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
        EntityCreateWarrantyTypeResponseBodyWarrantyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityCreateWarrantyTypeResponseBodyWarrantyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityCreateWarrantyTypeResponseBodyWarrantyType value
    ) => value.Value;

    public static explicit operator EntityCreateWarrantyTypeResponseBodyWarrantyType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Manufacturer = "manufacturer";

        public const string Extended = "extended";

        public const string Other = "other";
    }
}
