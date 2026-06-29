using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<TachographFileUploadsPostTachographFileUploadRequestBodyContentType>)
)]
[Serializable]
public readonly record struct TachographFileUploadsPostTachographFileUploadRequestBodyContentType
    : IStringEnum
{
    public static readonly TachographFileUploadsPostTachographFileUploadRequestBodyContentType ApplicationOctetStream =
        new(Values.ApplicationOctetStream);

    public TachographFileUploadsPostTachographFileUploadRequestBodyContentType(string value)
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
    public static TachographFileUploadsPostTachographFileUploadRequestBodyContentType FromCustom(
        string value
    )
    {
        return new TachographFileUploadsPostTachographFileUploadRequestBodyContentType(value);
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
        TachographFileUploadsPostTachographFileUploadRequestBodyContentType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TachographFileUploadsPostTachographFileUploadRequestBodyContentType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TachographFileUploadsPostTachographFileUploadRequestBodyContentType value
    ) => value.Value;

    public static explicit operator TachographFileUploadsPostTachographFileUploadRequestBodyContentType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ApplicationOctetStream = "application/octet-stream";
    }
}
