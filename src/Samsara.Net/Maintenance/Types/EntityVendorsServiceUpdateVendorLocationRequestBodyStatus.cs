using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

[JsonConverter(
    typeof(StringEnumSerializer<EntityVendorsServiceUpdateVendorLocationRequestBodyStatus>)
)]
[Serializable]
public readonly record struct EntityVendorsServiceUpdateVendorLocationRequestBodyStatus
    : IStringEnum
{
    public static readonly EntityVendorsServiceUpdateVendorLocationRequestBodyStatus Active = new(
        Values.Active
    );

    public static readonly EntityVendorsServiceUpdateVendorLocationRequestBodyStatus Inactive = new(
        Values.Inactive
    );

    public static readonly EntityVendorsServiceUpdateVendorLocationRequestBodyStatus Unknown = new(
        Values.Unknown
    );

    public EntityVendorsServiceUpdateVendorLocationRequestBodyStatus(string value)
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
    public static EntityVendorsServiceUpdateVendorLocationRequestBodyStatus FromCustom(string value)
    {
        return new EntityVendorsServiceUpdateVendorLocationRequestBodyStatus(value);
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
        EntityVendorsServiceUpdateVendorLocationRequestBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityVendorsServiceUpdateVendorLocationRequestBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityVendorsServiceUpdateVendorLocationRequestBodyStatus value
    ) => value.Value;

    public static explicit operator EntityVendorsServiceUpdateVendorLocationRequestBodyStatus(
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
