using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<GetHosEldEventsRequestDriverActivationStatus>))]
[Serializable]
public readonly record struct GetHosEldEventsRequestDriverActivationStatus : IStringEnum
{
    public static readonly GetHosEldEventsRequestDriverActivationStatus Active = new(Values.Active);

    public static readonly GetHosEldEventsRequestDriverActivationStatus Deactivated = new(
        Values.Deactivated
    );

    public GetHosEldEventsRequestDriverActivationStatus(string value)
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
    public static GetHosEldEventsRequestDriverActivationStatus FromCustom(string value)
    {
        return new GetHosEldEventsRequestDriverActivationStatus(value);
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
        GetHosEldEventsRequestDriverActivationStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetHosEldEventsRequestDriverActivationStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetHosEldEventsRequestDriverActivationStatus value) =>
        value.Value;

    public static explicit operator GetHosEldEventsRequestDriverActivationStatus(string value) =>
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
