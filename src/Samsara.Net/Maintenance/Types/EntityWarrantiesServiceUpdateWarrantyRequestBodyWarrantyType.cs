using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

[JsonConverter(
    typeof(StringEnumSerializer<EntityWarrantiesServiceUpdateWarrantyRequestBodyWarrantyType>)
)]
[Serializable]
public readonly record struct EntityWarrantiesServiceUpdateWarrantyRequestBodyWarrantyType
    : IStringEnum
{
    public static readonly EntityWarrantiesServiceUpdateWarrantyRequestBodyWarrantyType Unknown =
        new(Values.Unknown);

    public static readonly EntityWarrantiesServiceUpdateWarrantyRequestBodyWarrantyType Manufacturer =
        new(Values.Manufacturer);

    public static readonly EntityWarrantiesServiceUpdateWarrantyRequestBodyWarrantyType Extended =
        new(Values.Extended);

    public static readonly EntityWarrantiesServiceUpdateWarrantyRequestBodyWarrantyType Other = new(
        Values.Other
    );

    public EntityWarrantiesServiceUpdateWarrantyRequestBodyWarrantyType(string value)
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
    public static EntityWarrantiesServiceUpdateWarrantyRequestBodyWarrantyType FromCustom(
        string value
    )
    {
        return new EntityWarrantiesServiceUpdateWarrantyRequestBodyWarrantyType(value);
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
        EntityWarrantiesServiceUpdateWarrantyRequestBodyWarrantyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityWarrantiesServiceUpdateWarrantyRequestBodyWarrantyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityWarrantiesServiceUpdateWarrantyRequestBodyWarrantyType value
    ) => value.Value;

    public static explicit operator EntityWarrantiesServiceUpdateWarrantyRequestBodyWarrantyType(
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
