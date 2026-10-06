using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityUpdateVendorGroupTypeResponseBodyStatus>))]
[Serializable]
public readonly record struct EntityUpdateVendorGroupTypeResponseBodyStatus : IStringEnum
{
    public static readonly EntityUpdateVendorGroupTypeResponseBodyStatus Active = new(
        Values.Active
    );

    public static readonly EntityUpdateVendorGroupTypeResponseBodyStatus Inactive = new(
        Values.Inactive
    );

    public static readonly EntityUpdateVendorGroupTypeResponseBodyStatus Unknown = new(
        Values.Unknown
    );

    public EntityUpdateVendorGroupTypeResponseBodyStatus(string value)
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
    public static EntityUpdateVendorGroupTypeResponseBodyStatus FromCustom(string value)
    {
        return new EntityUpdateVendorGroupTypeResponseBodyStatus(value);
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
        EntityUpdateVendorGroupTypeResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityUpdateVendorGroupTypeResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(EntityUpdateVendorGroupTypeResponseBodyStatus value) =>
        value.Value;

    public static explicit operator EntityUpdateVendorGroupTypeResponseBodyStatus(string value) =>
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
