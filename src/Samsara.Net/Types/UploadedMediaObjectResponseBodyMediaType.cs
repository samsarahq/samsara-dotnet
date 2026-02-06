using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<UploadedMediaObjectResponseBodyMediaType>))]
[Serializable]
public readonly record struct UploadedMediaObjectResponseBodyMediaType : IStringEnum
{
    public static readonly UploadedMediaObjectResponseBodyMediaType Image = new(Values.Image);

    public static readonly UploadedMediaObjectResponseBodyMediaType VideoHighRes = new(
        Values.VideoHighRes
    );

    public static readonly UploadedMediaObjectResponseBodyMediaType VideoLowRes = new(
        Values.VideoLowRes
    );

    public static readonly UploadedMediaObjectResponseBodyMediaType Hyperlapse = new(
        Values.Hyperlapse
    );

    public UploadedMediaObjectResponseBodyMediaType(string value)
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
    public static UploadedMediaObjectResponseBodyMediaType FromCustom(string value)
    {
        return new UploadedMediaObjectResponseBodyMediaType(value);
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
        UploadedMediaObjectResponseBodyMediaType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UploadedMediaObjectResponseBodyMediaType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(UploadedMediaObjectResponseBodyMediaType value) =>
        value.Value;

    public static explicit operator UploadedMediaObjectResponseBodyMediaType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Image = "image";

        public const string VideoHighRes = "videoHighRes";

        public const string VideoLowRes = "videoLowRes";

        public const string Hyperlapse = "hyperlapse";
    }
}
