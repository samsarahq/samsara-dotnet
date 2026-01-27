using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<AssetResponseBodyRegulationMode>))]
[Serializable]
public readonly record struct AssetResponseBodyRegulationMode : IStringEnum
{
    public static readonly AssetResponseBodyRegulationMode Mixed = new(Values.Mixed);

    public static readonly AssetResponseBodyRegulationMode Regulated = new(Values.Regulated);

    public static readonly AssetResponseBodyRegulationMode Unregulated = new(Values.Unregulated);

    public AssetResponseBodyRegulationMode(string value)
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
    public static AssetResponseBodyRegulationMode FromCustom(string value)
    {
        return new AssetResponseBodyRegulationMode(value);
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

    public static bool operator ==(AssetResponseBodyRegulationMode value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(AssetResponseBodyRegulationMode value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(AssetResponseBodyRegulationMode value) => value.Value;

    public static explicit operator AssetResponseBodyRegulationMode(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Mixed = "mixed";

        public const string Regulated = "regulated";

        public const string Unregulated = "unregulated";
    }
}
