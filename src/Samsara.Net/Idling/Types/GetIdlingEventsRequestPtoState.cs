using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Idling;

[JsonConverter(typeof(StringEnumSerializer<GetIdlingEventsRequestPtoState>))]
[Serializable]
public readonly record struct GetIdlingEventsRequestPtoState : IStringEnum
{
    public static readonly GetIdlingEventsRequestPtoState Active = new(Values.Active);

    public static readonly GetIdlingEventsRequestPtoState Inactive = new(Values.Inactive);

    public GetIdlingEventsRequestPtoState(string value)
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
    public static GetIdlingEventsRequestPtoState FromCustom(string value)
    {
        return new GetIdlingEventsRequestPtoState(value);
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

    public static bool operator ==(GetIdlingEventsRequestPtoState value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetIdlingEventsRequestPtoState value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetIdlingEventsRequestPtoState value) => value.Value;

    public static explicit operator GetIdlingEventsRequestPtoState(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Active = "active";

        public const string Inactive = "inactive";
    }
}
