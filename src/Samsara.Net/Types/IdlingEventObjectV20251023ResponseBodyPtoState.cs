using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<IdlingEventObjectV20251023ResponseBodyPtoState>))]
[Serializable]
public readonly record struct IdlingEventObjectV20251023ResponseBodyPtoState : IStringEnum
{
    public static readonly IdlingEventObjectV20251023ResponseBodyPtoState ActiveInactive = new(
        Values.ActiveInactive
    );

    public IdlingEventObjectV20251023ResponseBodyPtoState(string value)
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
    public static IdlingEventObjectV20251023ResponseBodyPtoState FromCustom(string value)
    {
        return new IdlingEventObjectV20251023ResponseBodyPtoState(value);
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
        IdlingEventObjectV20251023ResponseBodyPtoState value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        IdlingEventObjectV20251023ResponseBodyPtoState value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(IdlingEventObjectV20251023ResponseBodyPtoState value) =>
        value.Value;

    public static explicit operator IdlingEventObjectV20251023ResponseBodyPtoState(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string ActiveInactive = "active, inactive";
    }
}
