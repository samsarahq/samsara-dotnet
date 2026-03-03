using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[JsonConverter(typeof(StringEnumSerializer<DeviceRecoveryRecoverAssetRequestBodyMissingReason>))]
[Serializable]
public readonly record struct DeviceRecoveryRecoverAssetRequestBodyMissingReason : IStringEnum
{
    public static readonly DeviceRecoveryRecoverAssetRequestBodyMissingReason Misplaced = new(
        Values.Misplaced
    );

    public static readonly DeviceRecoveryRecoverAssetRequestBodyMissingReason Stolen = new(
        Values.Stolen
    );

    public static readonly DeviceRecoveryRecoverAssetRequestBodyMissingReason NotSure = new(
        Values.NotSure
    );

    public DeviceRecoveryRecoverAssetRequestBodyMissingReason(string value)
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
    public static DeviceRecoveryRecoverAssetRequestBodyMissingReason FromCustom(string value)
    {
        return new DeviceRecoveryRecoverAssetRequestBodyMissingReason(value);
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
        DeviceRecoveryRecoverAssetRequestBodyMissingReason value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        DeviceRecoveryRecoverAssetRequestBodyMissingReason value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        DeviceRecoveryRecoverAssetRequestBodyMissingReason value
    ) => value.Value;

    public static explicit operator DeviceRecoveryRecoverAssetRequestBodyMissingReason(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Misplaced = "MISPLACED";

        public const string Stolen = "STOLEN";

        public const string NotSure = "NOT_SURE";
    }
}
