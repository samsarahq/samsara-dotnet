using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Media;

[JsonConverter(typeof(StringEnumSerializer<ListUploadedMediaRequestInputsItem>))]
[Serializable]
public readonly record struct ListUploadedMediaRequestInputsItem : IStringEnum
{
    public static readonly ListUploadedMediaRequestInputsItem DashcamRoadFacing = new(
        Values.DashcamRoadFacing
    );

    public static readonly ListUploadedMediaRequestInputsItem DashcamDriverFacing = new(
        Values.DashcamDriverFacing
    );

    public static readonly ListUploadedMediaRequestInputsItem Analog1 = new(Values.Analog1);

    public static readonly ListUploadedMediaRequestInputsItem Analog2 = new(Values.Analog2);

    public static readonly ListUploadedMediaRequestInputsItem Analog3 = new(Values.Analog3);

    public static readonly ListUploadedMediaRequestInputsItem Analog4 = new(Values.Analog4);

    public ListUploadedMediaRequestInputsItem(string value)
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
    public static ListUploadedMediaRequestInputsItem FromCustom(string value)
    {
        return new ListUploadedMediaRequestInputsItem(value);
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

    public static bool operator ==(ListUploadedMediaRequestInputsItem value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListUploadedMediaRequestInputsItem value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListUploadedMediaRequestInputsItem value) => value.Value;

    public static explicit operator ListUploadedMediaRequestInputsItem(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string DashcamRoadFacing = "dashcamRoadFacing";

        public const string DashcamDriverFacing = "dashcamDriverFacing";

        public const string Analog1 = "analog1";

        public const string Analog2 = "analog2";

        public const string Analog3 = "analog3";

        public const string Analog4 = "analog4";
    }
}
