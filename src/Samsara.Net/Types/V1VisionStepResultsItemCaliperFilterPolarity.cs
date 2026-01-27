using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<V1VisionStepResultsItemCaliperFilterPolarity>))]
[Serializable]
public readonly record struct V1VisionStepResultsItemCaliperFilterPolarity : IStringEnum
{
    public static readonly V1VisionStepResultsItemCaliperFilterPolarity LightToDark = new(
        Values.LightToDark
    );

    public static readonly V1VisionStepResultsItemCaliperFilterPolarity DarkToLight = new(
        Values.DarkToLight
    );

    public V1VisionStepResultsItemCaliperFilterPolarity(string value)
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
    public static V1VisionStepResultsItemCaliperFilterPolarity FromCustom(string value)
    {
        return new V1VisionStepResultsItemCaliperFilterPolarity(value);
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
        V1VisionStepResultsItemCaliperFilterPolarity value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        V1VisionStepResultsItemCaliperFilterPolarity value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(V1VisionStepResultsItemCaliperFilterPolarity value) =>
        value.Value;

    public static explicit operator V1VisionStepResultsItemCaliperFilterPolarity(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string LightToDark = "LIGHT TO DARK";

        public const string DarkToLight = "DARK TO LIGHT";
    }
}
