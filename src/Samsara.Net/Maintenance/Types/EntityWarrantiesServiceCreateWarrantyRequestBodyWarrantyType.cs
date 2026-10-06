using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

[JsonConverter(
    typeof(StringEnumSerializer<EntityWarrantiesServiceCreateWarrantyRequestBodyWarrantyType>)
)]
[Serializable]
public readonly record struct EntityWarrantiesServiceCreateWarrantyRequestBodyWarrantyType
    : IStringEnum
{
    public static readonly EntityWarrantiesServiceCreateWarrantyRequestBodyWarrantyType Unknown =
        new(Values.Unknown);

    public static readonly EntityWarrantiesServiceCreateWarrantyRequestBodyWarrantyType Manufacturer =
        new(Values.Manufacturer);

    public static readonly EntityWarrantiesServiceCreateWarrantyRequestBodyWarrantyType Extended =
        new(Values.Extended);

    public static readonly EntityWarrantiesServiceCreateWarrantyRequestBodyWarrantyType Other = new(
        Values.Other
    );

    public EntityWarrantiesServiceCreateWarrantyRequestBodyWarrantyType(string value)
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
    public static EntityWarrantiesServiceCreateWarrantyRequestBodyWarrantyType FromCustom(
        string value
    )
    {
        return new EntityWarrantiesServiceCreateWarrantyRequestBodyWarrantyType(value);
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
        EntityWarrantiesServiceCreateWarrantyRequestBodyWarrantyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityWarrantiesServiceCreateWarrantyRequestBodyWarrantyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityWarrantiesServiceCreateWarrantyRequestBodyWarrantyType value
    ) => value.Value;

    public static explicit operator EntityWarrantiesServiceCreateWarrantyRequestBodyWarrantyType(
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
