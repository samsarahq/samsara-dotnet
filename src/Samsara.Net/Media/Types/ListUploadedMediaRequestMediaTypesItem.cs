using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Media;

[JsonConverter(typeof(StringEnumSerializer<ListUploadedMediaRequestMediaTypesItem>))]
[Serializable]
public readonly record struct ListUploadedMediaRequestMediaTypesItem : IStringEnum
{
    public static readonly ListUploadedMediaRequestMediaTypesItem Image = new(Values.Image);

    public static readonly ListUploadedMediaRequestMediaTypesItem VideoHighRes = new(
        Values.VideoHighRes
    );

    public ListUploadedMediaRequestMediaTypesItem(string value)
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
    public static ListUploadedMediaRequestMediaTypesItem FromCustom(string value)
    {
        return new ListUploadedMediaRequestMediaTypesItem(value);
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

    public static bool operator ==(ListUploadedMediaRequestMediaTypesItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListUploadedMediaRequestMediaTypesItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListUploadedMediaRequestMediaTypesItem value) =>
        value.Value;

    public static explicit operator ListUploadedMediaRequestMediaTypesItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Image = "image";

        public const string VideoHighRes = "videoHighRes";
    }
}
