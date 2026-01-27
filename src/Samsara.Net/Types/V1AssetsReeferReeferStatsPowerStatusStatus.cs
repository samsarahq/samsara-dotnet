using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<V1AssetsReeferReeferStatsPowerStatusStatus>))]
[Serializable]
public readonly record struct V1AssetsReeferReeferStatsPowerStatusStatus : IStringEnum
{
    public static readonly V1AssetsReeferReeferStatsPowerStatusStatus Off = new(Values.Off);

    public static readonly V1AssetsReeferReeferStatsPowerStatusStatus Active = new(Values.Active);

    public static readonly V1AssetsReeferReeferStatsPowerStatusStatus ActiveStartStop = new(
        Values.ActiveStartStop
    );

    public static readonly V1AssetsReeferReeferStatsPowerStatusStatus ActiveContinuous = new(
        Values.ActiveContinuous
    );

    public V1AssetsReeferReeferStatsPowerStatusStatus(string value)
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
    public static V1AssetsReeferReeferStatsPowerStatusStatus FromCustom(string value)
    {
        return new V1AssetsReeferReeferStatsPowerStatusStatus(value);
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
        V1AssetsReeferReeferStatsPowerStatusStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        V1AssetsReeferReeferStatsPowerStatusStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(V1AssetsReeferReeferStatsPowerStatusStatus value) =>
        value.Value;

    public static explicit operator V1AssetsReeferReeferStatsPowerStatusStatus(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Off = "Off";

        public const string Active = "Active";

        public const string ActiveStartStop = "Active (Start/Stop)";

        public const string ActiveContinuous = "Active (Continuous)";
    }
}
