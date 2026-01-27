using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Media;

[JsonConverter(typeof(StringEnumSerializer<MediaRetrievalPostMediaRetrievalRequestBodyInputsItem>))]
[Serializable]
public readonly record struct MediaRetrievalPostMediaRetrievalRequestBodyInputsItem : IStringEnum
{
    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyInputsItem DashcamRoadFacing =
        new(Values.DashcamRoadFacing);

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyInputsItem DashcamDriverFacing =
        new(Values.DashcamDriverFacing);

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyInputsItem Analog1 = new(
        Values.Analog1
    );

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyInputsItem Analog2 = new(
        Values.Analog2
    );

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyInputsItem Analog3 = new(
        Values.Analog3
    );

    public static readonly MediaRetrievalPostMediaRetrievalRequestBodyInputsItem Analog4 = new(
        Values.Analog4
    );

    public MediaRetrievalPostMediaRetrievalRequestBodyInputsItem(string value)
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
    public static MediaRetrievalPostMediaRetrievalRequestBodyInputsItem FromCustom(string value)
    {
        return new MediaRetrievalPostMediaRetrievalRequestBodyInputsItem(value);
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
        MediaRetrievalPostMediaRetrievalRequestBodyInputsItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        MediaRetrievalPostMediaRetrievalRequestBodyInputsItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        MediaRetrievalPostMediaRetrievalRequestBodyInputsItem value
    ) => value.Value;

    public static explicit operator MediaRetrievalPostMediaRetrievalRequestBodyInputsItem(
        string value
    ) => new(value);

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
