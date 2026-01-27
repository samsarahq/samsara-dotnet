using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Assets;

[JsonConverter(typeof(StringEnumSerializer<AssetsCreateAssetRequestBodyRegulationMode>))]
[Serializable]
public readonly record struct AssetsCreateAssetRequestBodyRegulationMode : IStringEnum
{
    public static readonly AssetsCreateAssetRequestBodyRegulationMode Mixed = new(Values.Mixed);

    public static readonly AssetsCreateAssetRequestBodyRegulationMode Regulated = new(
        Values.Regulated
    );

    public static readonly AssetsCreateAssetRequestBodyRegulationMode Unregulated = new(
        Values.Unregulated
    );

    public AssetsCreateAssetRequestBodyRegulationMode(string value)
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
    public static AssetsCreateAssetRequestBodyRegulationMode FromCustom(string value)
    {
        return new AssetsCreateAssetRequestBodyRegulationMode(value);
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
        AssetsCreateAssetRequestBodyRegulationMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetsCreateAssetRequestBodyRegulationMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AssetsCreateAssetRequestBodyRegulationMode value) =>
        value.Value;

    public static explicit operator AssetsCreateAssetRequestBodyRegulationMode(string value) =>
        new(value);

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
