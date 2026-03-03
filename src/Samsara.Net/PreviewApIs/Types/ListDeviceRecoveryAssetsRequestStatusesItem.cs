using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[JsonConverter(typeof(StringEnumSerializer<ListDeviceRecoveryAssetsRequestStatusesItem>))]
[Serializable]
public readonly record struct ListDeviceRecoveryAssetsRequestStatusesItem : IStringEnum
{
    public static readonly ListDeviceRecoveryAssetsRequestStatusesItem Unknown = new(
        Values.Unknown
    );

    public static readonly ListDeviceRecoveryAssetsRequestStatusesItem Missing = new(
        Values.Missing
    );

    public static readonly ListDeviceRecoveryAssetsRequestStatusesItem Located = new(
        Values.Located
    );

    public static readonly ListDeviceRecoveryAssetsRequestStatusesItem Recovered = new(
        Values.Recovered
    );

    public ListDeviceRecoveryAssetsRequestStatusesItem(string value)
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
    public static ListDeviceRecoveryAssetsRequestStatusesItem FromCustom(string value)
    {
        return new ListDeviceRecoveryAssetsRequestStatusesItem(value);
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
        ListDeviceRecoveryAssetsRequestStatusesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListDeviceRecoveryAssetsRequestStatusesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(ListDeviceRecoveryAssetsRequestStatusesItem value) =>
        value.Value;

    public static explicit operator ListDeviceRecoveryAssetsRequestStatusesItem(string value) =>
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
