using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<MaintenanceEstimateAttachmentCreateResultResponseBodyProcessingStatus>)
)]
[Serializable]
public readonly record struct MaintenanceEstimateAttachmentCreateResultResponseBodyProcessingStatus
    : IStringEnum
{
    public static readonly MaintenanceEstimateAttachmentCreateResultResponseBodyProcessingStatus Unknown =
        new(Values.Unknown);

    public static readonly MaintenanceEstimateAttachmentCreateResultResponseBodyProcessingStatus Processing =
        new(Values.Processing);

    public static readonly MaintenanceEstimateAttachmentCreateResultResponseBodyProcessingStatus Finished =
        new(Values.Finished);

    public MaintenanceEstimateAttachmentCreateResultResponseBodyProcessingStatus(string value)
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
    public static MaintenanceEstimateAttachmentCreateResultResponseBodyProcessingStatus FromCustom(
        string value
    )
    {
        return new MaintenanceEstimateAttachmentCreateResultResponseBodyProcessingStatus(value);
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
        MaintenanceEstimateAttachmentCreateResultResponseBodyProcessingStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceEstimateAttachmentCreateResultResponseBodyProcessingStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        MaintenanceEstimateAttachmentCreateResultResponseBodyProcessingStatus value
    ) => value.Value;

    public static explicit operator MaintenanceEstimateAttachmentCreateResultResponseBodyProcessingStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Processing = "processing";

        public const string Finished = "finished";
    }
}
