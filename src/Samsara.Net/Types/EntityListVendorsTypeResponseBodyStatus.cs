using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityListVendorsTypeResponseBodyStatus>))]
[Serializable]
public readonly record struct EntityListVendorsTypeResponseBodyStatus : IStringEnum
{
    public static readonly EntityListVendorsTypeResponseBodyStatus Active = new(Values.Active);

    public static readonly EntityListVendorsTypeResponseBodyStatus Inactive = new(Values.Inactive);

    public static readonly EntityListVendorsTypeResponseBodyStatus Unknown = new(Values.Unknown);

    public EntityListVendorsTypeResponseBodyStatus(string value)
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
    public static EntityListVendorsTypeResponseBodyStatus FromCustom(string value)
    {
        return new EntityListVendorsTypeResponseBodyStatus(value);
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

    public static bool operator ==(EntityListVendorsTypeResponseBodyStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(EntityListVendorsTypeResponseBodyStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(EntityListVendorsTypeResponseBodyStatus value) =>
        value.Value;

    public static explicit operator EntityListVendorsTypeResponseBodyStatus(string value) =>
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
