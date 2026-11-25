using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<RecallResponseObjectResponseBodyRecallSource>))]
[Serializable]
public readonly record struct RecallResponseObjectResponseBodyRecallSource : IStringEnum
{
    public static readonly RecallResponseObjectResponseBodyRecallSource RecallMasters = new(
        Values.RecallMasters
    );

    public static readonly RecallResponseObjectResponseBodyRecallSource Nhtsa = new(Values.Nhtsa);

    public static readonly RecallResponseObjectResponseBodyRecallSource Oem = new(Values.Oem);

    public static readonly RecallResponseObjectResponseBodyRecallSource Manual = new(Values.Manual);

    public static readonly RecallResponseObjectResponseBodyRecallSource Api = new(Values.Api);

    public static readonly RecallResponseObjectResponseBodyRecallSource Unknown = new(
        Values.Unknown
    );

    public RecallResponseObjectResponseBodyRecallSource(string value)
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
    public static RecallResponseObjectResponseBodyRecallSource FromCustom(string value)
    {
        return new RecallResponseObjectResponseBodyRecallSource(value);
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
        RecallResponseObjectResponseBodyRecallSource value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        RecallResponseObjectResponseBodyRecallSource value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(RecallResponseObjectResponseBodyRecallSource value) =>
        value.Value;

    public static explicit operator RecallResponseObjectResponseBodyRecallSource(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string RecallMasters = "recallMasters";

        public const string Nhtsa = "nhtsa";

        public const string Oem = "oem";

        public const string Manual = "manual";

        public const string Api = "api";

        public const string Unknown = "unknown";
    }
}
