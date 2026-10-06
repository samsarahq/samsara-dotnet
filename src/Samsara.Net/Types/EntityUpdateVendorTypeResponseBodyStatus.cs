using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityUpdateVendorTypeResponseBodyStatus>))]
[Serializable]
public readonly record struct EntityUpdateVendorTypeResponseBodyStatus : IStringEnum
{
    public static readonly EntityUpdateVendorTypeResponseBodyStatus Active = new(Values.Active);

    public static readonly EntityUpdateVendorTypeResponseBodyStatus Inactive = new(Values.Inactive);

    public static readonly EntityUpdateVendorTypeResponseBodyStatus Unknown = new(Values.Unknown);

    public EntityUpdateVendorTypeResponseBodyStatus(string value)
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
    public static EntityUpdateVendorTypeResponseBodyStatus FromCustom(string value)
    {
        return new EntityUpdateVendorTypeResponseBodyStatus(value);
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
        EntityUpdateVendorTypeResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityUpdateVendorTypeResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EntityUpdateVendorTypeResponseBodyStatus value) =>
        value.Value;

    public static explicit operator EntityUpdateVendorTypeResponseBodyStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Active = "active";

        public const string Inactive = "inactive";

        public const string Unknown = "unknown";
    }
}
