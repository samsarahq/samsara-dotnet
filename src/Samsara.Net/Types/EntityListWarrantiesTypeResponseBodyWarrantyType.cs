using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityListWarrantiesTypeResponseBodyWarrantyType>))]
[Serializable]
public readonly record struct EntityListWarrantiesTypeResponseBodyWarrantyType : IStringEnum
{
    public static readonly EntityListWarrantiesTypeResponseBodyWarrantyType Unknown = new(
        Values.Unknown
    );

    public static readonly EntityListWarrantiesTypeResponseBodyWarrantyType Manufacturer = new(
        Values.Manufacturer
    );

    public static readonly EntityListWarrantiesTypeResponseBodyWarrantyType Extended = new(
        Values.Extended
    );

    public static readonly EntityListWarrantiesTypeResponseBodyWarrantyType Other = new(
        Values.Other
    );

    public EntityListWarrantiesTypeResponseBodyWarrantyType(string value)
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
    public static EntityListWarrantiesTypeResponseBodyWarrantyType FromCustom(string value)
    {
        return new EntityListWarrantiesTypeResponseBodyWarrantyType(value);
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
        EntityListWarrantiesTypeResponseBodyWarrantyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityListWarrantiesTypeResponseBodyWarrantyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityListWarrantiesTypeResponseBodyWarrantyType value
    ) => value.Value;

    public static explicit operator EntityListWarrantiesTypeResponseBodyWarrantyType(
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
