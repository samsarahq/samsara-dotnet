using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityCreateVendorGroupTypeResponseBodyStatus>))]
[Serializable]
public readonly record struct EntityCreateVendorGroupTypeResponseBodyStatus : IStringEnum
{
    public static readonly EntityCreateVendorGroupTypeResponseBodyStatus Active = new(
        Values.Active
    );

    public static readonly EntityCreateVendorGroupTypeResponseBodyStatus Inactive = new(
        Values.Inactive
    );

    public static readonly EntityCreateVendorGroupTypeResponseBodyStatus Unknown = new(
        Values.Unknown
    );

    public EntityCreateVendorGroupTypeResponseBodyStatus(string value)
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
    public static EntityCreateVendorGroupTypeResponseBodyStatus FromCustom(string value)
    {
        return new EntityCreateVendorGroupTypeResponseBodyStatus(value);
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
        EntityCreateVendorGroupTypeResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityCreateVendorGroupTypeResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EntityCreateVendorGroupTypeResponseBodyStatus value) =>
        value.Value;

    public static explicit operator EntityCreateVendorGroupTypeResponseBodyStatus(string value) =>
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
