using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<EntityVendorsServiceCreateVendorRequestBodyStatus>))]
[Serializable]
public readonly record struct EntityVendorsServiceCreateVendorRequestBodyStatus : IStringEnum
{
    public static readonly EntityVendorsServiceCreateVendorRequestBodyStatus Active = new(
        Values.Active
    );

    public static readonly EntityVendorsServiceCreateVendorRequestBodyStatus Inactive = new(
        Values.Inactive
    );

    public static readonly EntityVendorsServiceCreateVendorRequestBodyStatus Unknown = new(
        Values.Unknown
    );

    public EntityVendorsServiceCreateVendorRequestBodyStatus(string value)
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
    public static EntityVendorsServiceCreateVendorRequestBodyStatus FromCustom(string value)
    {
        return new EntityVendorsServiceCreateVendorRequestBodyStatus(value);
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
        EntityVendorsServiceCreateVendorRequestBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityVendorsServiceCreateVendorRequestBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityVendorsServiceCreateVendorRequestBodyStatus value
    ) => value.Value;

    public static explicit operator EntityVendorsServiceCreateVendorRequestBodyStatus(
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
