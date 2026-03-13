using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<DeviceRecoveryRecoverAssetRequestBodyStatus>))]
[Serializable]
public readonly record struct DeviceRecoveryRecoverAssetRequestBodyStatus : IStringEnum
{
    public static readonly DeviceRecoveryRecoverAssetRequestBodyStatus Recovered = new(
        Values.Recovered
    );

    public DeviceRecoveryRecoverAssetRequestBodyStatus(string value)
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
    public static DeviceRecoveryRecoverAssetRequestBodyStatus FromCustom(string value)
    {
        return new DeviceRecoveryRecoverAssetRequestBodyStatus(value);
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
        DeviceRecoveryRecoverAssetRequestBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeviceRecoveryRecoverAssetRequestBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(DeviceRecoveryRecoverAssetRequestBodyStatus value) =>
        value.Value;

    public static explicit operator DeviceRecoveryRecoverAssetRequestBodyStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Recovered = "RECOVERED";
    }
}
