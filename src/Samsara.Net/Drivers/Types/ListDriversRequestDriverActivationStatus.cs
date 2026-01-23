using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Drivers;

[JsonConverter(typeof(StringEnumSerializer<ListDriversRequestDriverActivationStatus>))]
[Serializable]
public readonly record struct ListDriversRequestDriverActivationStatus : IStringEnum
{
    public static readonly ListDriversRequestDriverActivationStatus Active = new(Values.Active);

    public static readonly ListDriversRequestDriverActivationStatus Deactivated = new(
        Values.Deactivated
    );

    public ListDriversRequestDriverActivationStatus(string value)
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
    public static ListDriversRequestDriverActivationStatus FromCustom(string value)
    {
        return new ListDriversRequestDriverActivationStatus(value);
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
        ListDriversRequestDriverActivationStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListDriversRequestDriverActivationStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListDriversRequestDriverActivationStatus value) =>
        value.Value;

    public static explicit operator ListDriversRequestDriverActivationStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Active = "active";

        public const string Deactivated = "deactivated";
    }
}
