using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[JsonConverter(
    typeof(StringEnumSerializer<TachographFileUploadsPostTachographFileUploadRequestBodyFileType>)
)]
[Serializable]
public readonly record struct TachographFileUploadsPostTachographFileUploadRequestBodyFileType
    : IStringEnum
{
    public static readonly TachographFileUploadsPostTachographFileUploadRequestBodyFileType DriverCard =
        new(Values.DriverCard);

    public static readonly TachographFileUploadsPostTachographFileUploadRequestBodyFileType VehicleUnit =
        new(Values.VehicleUnit);

    public TachographFileUploadsPostTachographFileUploadRequestBodyFileType(string value)
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
    public static TachographFileUploadsPostTachographFileUploadRequestBodyFileType FromCustom(
        string value
    )
    {
        return new TachographFileUploadsPostTachographFileUploadRequestBodyFileType(value);
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
        TachographFileUploadsPostTachographFileUploadRequestBodyFileType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TachographFileUploadsPostTachographFileUploadRequestBodyFileType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TachographFileUploadsPostTachographFileUploadRequestBodyFileType value
    ) => value.Value;

    public static explicit operator TachographFileUploadsPostTachographFileUploadRequestBodyFileType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string DriverCard = "driverCard";

        public const string VehicleUnit = "vehicleUnit";
    }
}
