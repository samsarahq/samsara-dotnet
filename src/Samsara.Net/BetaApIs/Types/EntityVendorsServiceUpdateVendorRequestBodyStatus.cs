using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<EntityVendorsServiceUpdateVendorRequestBodyStatus>))]
[Serializable]
public readonly record struct EntityVendorsServiceUpdateVendorRequestBodyStatus : IStringEnum
{
    public static readonly EntityVendorsServiceUpdateVendorRequestBodyStatus Active = new(
        Values.Active
    );

    public static readonly EntityVendorsServiceUpdateVendorRequestBodyStatus Inactive = new(
        Values.Inactive
    );

    public static readonly EntityVendorsServiceUpdateVendorRequestBodyStatus Unknown = new(
        Values.Unknown
    );

    public EntityVendorsServiceUpdateVendorRequestBodyStatus(string value)
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
    public static EntityVendorsServiceUpdateVendorRequestBodyStatus FromCustom(string value)
    {
        return new EntityVendorsServiceUpdateVendorRequestBodyStatus(value);
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
        EntityVendorsServiceUpdateVendorRequestBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityVendorsServiceUpdateVendorRequestBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityVendorsServiceUpdateVendorRequestBodyStatus value
    ) => value.Value;

    public static explicit operator EntityVendorsServiceUpdateVendorRequestBodyStatus(
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
