using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FunctionsStorageSignedUrlResponseBodyUrlType>))]
[Serializable]
public readonly record struct FunctionsStorageSignedUrlResponseBodyUrlType : IStringEnum
{
    public static readonly FunctionsStorageSignedUrlResponseBodyUrlType Download = new(
        Values.Download
    );

    public static readonly FunctionsStorageSignedUrlResponseBodyUrlType Upload = new(Values.Upload);

    public static readonly FunctionsStorageSignedUrlResponseBodyUrlType Unknown = new(
        Values.Unknown
    );

    public FunctionsStorageSignedUrlResponseBodyUrlType(string value)
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
    public static FunctionsStorageSignedUrlResponseBodyUrlType FromCustom(string value)
    {
        return new FunctionsStorageSignedUrlResponseBodyUrlType(value);
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
        FunctionsStorageSignedUrlResponseBodyUrlType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FunctionsStorageSignedUrlResponseBodyUrlType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FunctionsStorageSignedUrlResponseBodyUrlType value) =>
        value.Value;

    public static explicit operator FunctionsStorageSignedUrlResponseBodyUrlType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Download = "download";

        public const string Upload = "upload";

        public const string Unknown = "unknown";
    }
}
