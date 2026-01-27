using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<StopTaskCompletedEventDetailsResponseBodyTaskType>))]
[Serializable]
public readonly record struct StopTaskCompletedEventDetailsResponseBodyTaskType : IStringEnum
{
    public static readonly StopTaskCompletedEventDetailsResponseBodyTaskType Form = new(
        Values.Form
    );

    public static readonly StopTaskCompletedEventDetailsResponseBodyTaskType Document = new(
        Values.Document
    );

    public StopTaskCompletedEventDetailsResponseBodyTaskType(string value)
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
    public static StopTaskCompletedEventDetailsResponseBodyTaskType FromCustom(string value)
    {
        return new StopTaskCompletedEventDetailsResponseBodyTaskType(value);
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
        StopTaskCompletedEventDetailsResponseBodyTaskType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        StopTaskCompletedEventDetailsResponseBodyTaskType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        StopTaskCompletedEventDetailsResponseBodyTaskType value
    ) => value.Value;

    public static explicit operator StopTaskCompletedEventDetailsResponseBodyTaskType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Form = "form";

        public const string Document = "document";
    }
}
