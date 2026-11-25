using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

[JsonConverter(
    typeof(StringEnumSerializer<EntityVendorProfilesServiceCreateVendorRequestBodyStatus>)
)]
[Serializable]
public readonly record struct EntityVendorProfilesServiceCreateVendorRequestBodyStatus : IStringEnum
{
    public static readonly EntityVendorProfilesServiceCreateVendorRequestBodyStatus Active = new(
        Values.Active
    );

    public static readonly EntityVendorProfilesServiceCreateVendorRequestBodyStatus Inactive = new(
        Values.Inactive
    );

    public static readonly EntityVendorProfilesServiceCreateVendorRequestBodyStatus Unknown = new(
        Values.Unknown
    );

    public EntityVendorProfilesServiceCreateVendorRequestBodyStatus(string value)
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
    public static EntityVendorProfilesServiceCreateVendorRequestBodyStatus FromCustom(string value)
    {
        return new EntityVendorProfilesServiceCreateVendorRequestBodyStatus(value);
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
        EntityVendorProfilesServiceCreateVendorRequestBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityVendorProfilesServiceCreateVendorRequestBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityVendorProfilesServiceCreateVendorRequestBodyStatus value
    ) => value.Value;

    public static explicit operator EntityVendorProfilesServiceCreateVendorRequestBodyStatus(
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
