using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DeviceRecoveryStateResponseBodyStatus>))]
[Serializable]
public readonly record struct DeviceRecoveryStateResponseBodyStatus : IStringEnum
{
    public static readonly DeviceRecoveryStateResponseBodyStatus Unknown = new(Values.Unknown);

    public static readonly DeviceRecoveryStateResponseBodyStatus Missing = new(Values.Missing);

    public static readonly DeviceRecoveryStateResponseBodyStatus Located = new(Values.Located);

    public static readonly DeviceRecoveryStateResponseBodyStatus Recovered = new(Values.Recovered);

    public DeviceRecoveryStateResponseBodyStatus(string value)
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
    public static DeviceRecoveryStateResponseBodyStatus FromCustom(string value)
    {
        return new DeviceRecoveryStateResponseBodyStatus(value);
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

    public static bool operator ==(DeviceRecoveryStateResponseBodyStatus value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DeviceRecoveryStateResponseBodyStatus value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DeviceRecoveryStateResponseBodyStatus value) =>
        value.Value;

    public static explicit operator DeviceRecoveryStateResponseBodyStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "UNKNOWN";

        public const string Missing = "MISSING";

        public const string Located = "LOCATED";

        public const string Recovered = "RECOVERED";
    }
}
