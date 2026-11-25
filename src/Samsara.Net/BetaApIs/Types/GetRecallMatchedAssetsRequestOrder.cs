using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<GetRecallMatchedAssetsRequestOrder>))]
[Serializable]
public readonly record struct GetRecallMatchedAssetsRequestOrder : IStringEnum
{
    public static readonly GetRecallMatchedAssetsRequestOrder AssetId = new(Values.AssetId);

    public static readonly GetRecallMatchedAssetsRequestOrder MakeModelYearAsc = new(
        Values.MakeModelYearAsc
    );

    public static readonly GetRecallMatchedAssetsRequestOrder MakeModelYearDesc = new(
        Values.MakeModelYearDesc
    );

    public GetRecallMatchedAssetsRequestOrder(string value)
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
    public static GetRecallMatchedAssetsRequestOrder FromCustom(string value)
    {
        return new GetRecallMatchedAssetsRequestOrder(value);
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

    public static bool operator ==(GetRecallMatchedAssetsRequestOrder value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetRecallMatchedAssetsRequestOrder value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetRecallMatchedAssetsRequestOrder value) => value.Value;

    public static explicit operator GetRecallMatchedAssetsRequestOrder(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AssetId = "assetId";

        public const string MakeModelYearAsc = "makeModelYearAsc";

        public const string MakeModelYearDesc = "makeModelYearDesc";
    }
}
