using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<MaintenanceEstimateInlineFileRequestBodyContentType>))]
[Serializable]
public readonly record struct MaintenanceEstimateInlineFileRequestBodyContentType : IStringEnum
{
    public static readonly MaintenanceEstimateInlineFileRequestBodyContentType ApplicationPdf = new(
        Values.ApplicationPdf
    );

    public static readonly MaintenanceEstimateInlineFileRequestBodyContentType ImageJpeg = new(
        Values.ImageJpeg
    );

    public static readonly MaintenanceEstimateInlineFileRequestBodyContentType ImagePng = new(
        Values.ImagePng
    );

    public MaintenanceEstimateInlineFileRequestBodyContentType(string value)
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
    public static MaintenanceEstimateInlineFileRequestBodyContentType FromCustom(string value)
    {
        return new MaintenanceEstimateInlineFileRequestBodyContentType(value);
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
        MaintenanceEstimateInlineFileRequestBodyContentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MaintenanceEstimateInlineFileRequestBodyContentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        MaintenanceEstimateInlineFileRequestBodyContentType value
    ) => value.Value;

    public static explicit operator MaintenanceEstimateInlineFileRequestBodyContentType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ApplicationPdf = "application/pdf";

        public const string ImageJpeg = "image/jpeg";

        public const string ImagePng = "image/png";
    }
}
