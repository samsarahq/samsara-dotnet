using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.HoursOfService;

[JsonConverter(typeof(StringEnumSerializer<GetHosDailyLogsRequestDriverActivationStatus>))]
[Serializable]
public readonly record struct GetHosDailyLogsRequestDriverActivationStatus : IStringEnum
{
    public static readonly GetHosDailyLogsRequestDriverActivationStatus Active = new(Values.Active);

    public static readonly GetHosDailyLogsRequestDriverActivationStatus Deactivated = new(
        Values.Deactivated
    );

    public GetHosDailyLogsRequestDriverActivationStatus(string value)
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
    public static GetHosDailyLogsRequestDriverActivationStatus FromCustom(string value)
    {
        return new GetHosDailyLogsRequestDriverActivationStatus(value);
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
        GetHosDailyLogsRequestDriverActivationStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetHosDailyLogsRequestDriverActivationStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetHosDailyLogsRequestDriverActivationStatus value) =>
        value.Value;

    public static explicit operator GetHosDailyLogsRequestDriverActivationStatus(string value) =>
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
