using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Media;

[JsonConverter(typeof(StringEnumSerializer<MediaRetrievalPostMediaRetrievalRequestBodyMediaType>))]
[Serializable]
public readonly record struct MediaRetrievalPostMediaRetrievalRequestBodyMediaType : IStringEnum
{
    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyMediaType Image = new(
        Values.Image
    );

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyMediaType VideoHighRes = new(
        Values.VideoHighRes
    );

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyMediaType VideoLowRes = new(
        Values.VideoLowRes
    );

    public MediaRetrievalPostMediaRetrievalRequestBodyMediaType(string value)
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
    public static MediaRetrievalPostMediaRetrievalRequestBodyMediaType FromCustom(string value)
    {
        return new MediaRetrievalPostMediaRetrievalRequestBodyMediaType(value);
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
        MediaRetrievalPostMediaRetrievalRequestBodyMediaType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MediaRetrievalPostMediaRetrievalRequestBodyMediaType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        MediaRetrievalPostMediaRetrievalRequestBodyMediaType value
    ) => value.Value;

    public static explicit operator MediaRetrievalPostMediaRetrievalRequestBodyMediaType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Image = "image";

        public const string VideoHighRes = "videoHighRes";

        public const string VideoLowRes = "videoLowRes";
    }
}
