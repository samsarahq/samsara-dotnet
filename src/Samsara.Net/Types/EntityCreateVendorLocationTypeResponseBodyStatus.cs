using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityCreateVendorLocationTypeResponseBodyStatus>))]
[Serializable]
public readonly record struct EntityCreateVendorLocationTypeResponseBodyStatus : IStringEnum
{
    public static readonly EntityCreateVendorLocationTypeResponseBodyStatus Active = new(
        Values.Active
    );

    public static readonly EntityCreateVendorLocationTypeResponseBodyStatus Inactive = new(
        Values.Inactive
    );

    public static readonly EntityCreateVendorLocationTypeResponseBodyStatus Unknown = new(
        Values.Unknown
    );

    public EntityCreateVendorLocationTypeResponseBodyStatus(string value)
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
    public static EntityCreateVendorLocationTypeResponseBodyStatus FromCustom(string value)
    {
        return new EntityCreateVendorLocationTypeResponseBodyStatus(value);
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
        EntityCreateVendorLocationTypeResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityCreateVendorLocationTypeResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityCreateVendorLocationTypeResponseBodyStatus value
    ) => value.Value;

    public static explicit operator EntityCreateVendorLocationTypeResponseBodyStatus(
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
