using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<EntityVendorProfilesServiceCreateVendorGroupRequestBodyStatus>)
)]
[Serializable]
public readonly record struct EntityVendorProfilesServiceCreateVendorGroupRequestBodyStatus
    : IStringEnum
{
    public static readonly EntityVendorProfilesServiceCreateVendorGroupRequestBodyStatus Active =
        new(Values.Active);

    public static readonly EntityVendorProfilesServiceCreateVendorGroupRequestBodyStatus Inactive =
        new(Values.Inactive);

    public static readonly EntityVendorProfilesServiceCreateVendorGroupRequestBodyStatus Unknown =
        new(Values.Unknown);

    public EntityVendorProfilesServiceCreateVendorGroupRequestBodyStatus(string value)
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
    public static EntityVendorProfilesServiceCreateVendorGroupRequestBodyStatus FromCustom(
        string value
    )
    {
        return new EntityVendorProfilesServiceCreateVendorGroupRequestBodyStatus(value);
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
        EntityVendorProfilesServiceCreateVendorGroupRequestBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityVendorProfilesServiceCreateVendorGroupRequestBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityVendorProfilesServiceCreateVendorGroupRequestBodyStatus value
    ) => value.Value;

    public static explicit operator EntityVendorProfilesServiceCreateVendorGroupRequestBodyStatus(
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
