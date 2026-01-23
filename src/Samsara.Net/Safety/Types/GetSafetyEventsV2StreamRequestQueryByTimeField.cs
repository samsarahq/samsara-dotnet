using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Safety;

[JsonConverter(typeof(StringEnumSerializer<GetSafetyEventsV2StreamRequestQueryByTimeField>))]
[Serializable]
public readonly record struct GetSafetyEventsV2StreamRequestQueryByTimeField : IStringEnum
{
    public static readonly GetSafetyEventsV2StreamRequestQueryByTimeField UpdatedAtTime = new(
        Values.UpdatedAtTime
    );

    public static readonly GetSafetyEventsV2StreamRequestQueryByTimeField CreatedAtTime = new(
        Values.CreatedAtTime
    );

    public GetSafetyEventsV2StreamRequestQueryByTimeField(string value)
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
    public static GetSafetyEventsV2StreamRequestQueryByTimeField FromCustom(string value)
    {
        return new GetSafetyEventsV2StreamRequestQueryByTimeField(value);
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
        GetSafetyEventsV2StreamRequestQueryByTimeField value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        GetSafetyEventsV2StreamRequestQueryByTimeField value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(GetSafetyEventsV2StreamRequestQueryByTimeField value) =>
        value.Value;

    public static explicit operator GetSafetyEventsV2StreamRequestQueryByTimeField(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string UpdatedAtTime = "updatedAtTime";

        public const string CreatedAtTime = "createdAtTime";
    }
}
