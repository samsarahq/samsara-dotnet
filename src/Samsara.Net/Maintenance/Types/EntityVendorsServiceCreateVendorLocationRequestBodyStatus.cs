using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

[JsonConverter(
    typeof(StringEnumSerializer<EntityVendorsServiceCreateVendorLocationRequestBodyStatus>)
)]
[Serializable]
public readonly record struct EntityVendorsServiceCreateVendorLocationRequestBodyStatus
    : IStringEnum
{
    public static readonly EntityVendorsServiceCreateVendorLocationRequestBodyStatus Active = new(
        Values.Active
    );

    public static readonly EntityVendorsServiceCreateVendorLocationRequestBodyStatus Inactive = new(
        Values.Inactive
    );

    public static readonly EntityVendorsServiceCreateVendorLocationRequestBodyStatus Unknown = new(
        Values.Unknown
    );

    public EntityVendorsServiceCreateVendorLocationRequestBodyStatus(string value)
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
    public static EntityVendorsServiceCreateVendorLocationRequestBodyStatus FromCustom(string value)
    {
        return new EntityVendorsServiceCreateVendorLocationRequestBodyStatus(value);
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
        EntityVendorsServiceCreateVendorLocationRequestBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityVendorsServiceCreateVendorLocationRequestBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityVendorsServiceCreateVendorLocationRequestBodyStatus value
    ) => value.Value;

    public static explicit operator EntityVendorsServiceCreateVendorLocationRequestBodyStatus(
        string value
    ) => new(value);

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
