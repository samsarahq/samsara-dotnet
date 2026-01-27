using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Assets;

[JsonConverter(typeof(StringEnumSerializer<AssetsUpdateAssetRequestBodyRegulationMode>))]
[Serializable]
public readonly record struct AssetsUpdateAssetRequestBodyRegulationMode : IStringEnum
{
    public static readonly AssetsUpdateAssetRequestBodyRegulationMode Mixed = new(Values.Mixed);

    public static readonly AssetsUpdateAssetRequestBodyRegulationMode Regulated = new(
        Values.Regulated
    );

    public static readonly AssetsUpdateAssetRequestBodyRegulationMode Unregulated = new(
        Values.Unregulated
    );

    public AssetsUpdateAssetRequestBodyRegulationMode(string value)
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
    public static AssetsUpdateAssetRequestBodyRegulationMode FromCustom(string value)
    {
        return new AssetsUpdateAssetRequestBodyRegulationMode(value);
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
        AssetsUpdateAssetRequestBodyRegulationMode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetsUpdateAssetRequestBodyRegulationMode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(AssetsUpdateAssetRequestBodyRegulationMode value) =>
        value.Value;

    public static explicit operator AssetsUpdateAssetRequestBodyRegulationMode(string value) =>
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
