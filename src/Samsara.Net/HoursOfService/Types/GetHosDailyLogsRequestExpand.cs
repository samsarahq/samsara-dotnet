using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.HoursOfService;

[JsonConverter(typeof(StringEnumSerializer<GetHosDailyLogsRequestExpand>))]
[Serializable]
public readonly record struct GetHosDailyLogsRequestExpand : IStringEnum
{
    public static readonly GetHosDailyLogsRequestExpand Vehicle = new(Values.Vehicle);

    public GetHosDailyLogsRequestExpand(string value)
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
    public static GetHosDailyLogsRequestExpand FromCustom(string value)
    {
        return new GetHosDailyLogsRequestExpand(value);
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

    public static bool operator ==(GetHosDailyLogsRequestExpand value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetHosDailyLogsRequestExpand value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetHosDailyLogsRequestExpand value) => value.Value;

    public static explicit operator GetHosDailyLogsRequestExpand(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Vehicle = "vehicle";
    }
}
