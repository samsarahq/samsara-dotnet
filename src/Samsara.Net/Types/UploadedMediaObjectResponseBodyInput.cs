using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<UploadedMediaObjectResponseBodyInput>))]
[Serializable]
public readonly record struct UploadedMediaObjectResponseBodyInput : IStringEnum
{
    public static readonly UploadedMediaObjectResponseBodyInput DashcamForwardFacing = new(
        Values.DashcamForwardFacing
    );

    public static readonly UploadedMediaObjectResponseBodyInput DashcamInwardFacing = new(
        Values.DashcamInwardFacing
    );

    public static readonly UploadedMediaObjectResponseBodyInput Analog1 = new(Values.Analog1);

    public static readonly UploadedMediaObjectResponseBodyInput Analog2 = new(Values.Analog2);

    public static readonly UploadedMediaObjectResponseBodyInput Analog3 = new(Values.Analog3);

    public static readonly UploadedMediaObjectResponseBodyInput Analog4 = new(Values.Analog4);

    public UploadedMediaObjectResponseBodyInput(string value)
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
    public static UploadedMediaObjectResponseBodyInput FromCustom(string value)
    {
        return new UploadedMediaObjectResponseBodyInput(value);
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

    public static bool operator ==(UploadedMediaObjectResponseBodyInput value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(UploadedMediaObjectResponseBodyInput value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(UploadedMediaObjectResponseBodyInput value) =>
        value.Value;

    public static explicit operator UploadedMediaObjectResponseBodyInput(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string DashcamForwardFacing = "dashcamForwardFacing";

        public const string DashcamInwardFacing = "dashcamInwardFacing";

        public const string Analog1 = "analog1";

        public const string Analog2 = "analog2";

        public const string Analog3 = "analog3";

        public const string Analog4 = "analog4";
    }
}
