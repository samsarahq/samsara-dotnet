using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[JsonConverter(typeof(StringEnumSerializer<DeviceRecoveryRecoverAssetRequestBodyRecoveryStatus>))]
[Serializable]
public readonly record struct DeviceRecoveryRecoverAssetRequestBodyRecoveryStatus : IStringEnum
{
    public static readonly DeviceRecoveryRecoverAssetRequestBodyRecoveryStatus Yes = new(
        Values.Yes
    );

    public static readonly DeviceRecoveryRecoverAssetRequestBodyRecoveryStatus No = new(Values.No);

    public static readonly DeviceRecoveryRecoverAssetRequestBodyRecoveryStatus NotSure = new(
        Values.NotSure
    );

    public DeviceRecoveryRecoverAssetRequestBodyRecoveryStatus(string value)
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
    public static DeviceRecoveryRecoverAssetRequestBodyRecoveryStatus FromCustom(string value)
    {
        return new DeviceRecoveryRecoverAssetRequestBodyRecoveryStatus(value);
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
        DeviceRecoveryRecoverAssetRequestBodyRecoveryStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeviceRecoveryRecoverAssetRequestBodyRecoveryStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DeviceRecoveryRecoverAssetRequestBodyRecoveryStatus value
    ) => value.Value;

    public static explicit operator DeviceRecoveryRecoverAssetRequestBodyRecoveryStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Yes = "YES";

        public const string No = "NO";

        public const string NotSure = "NOT_SURE";
    }
}
