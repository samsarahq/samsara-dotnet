using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(
    typeof(StringEnumSerializer<AssetAssignmentsCreateAssetAssignmentRequestBodyAssigneeType>)
)]
[Serializable]
public readonly record struct AssetAssignmentsCreateAssetAssignmentRequestBodyAssigneeType
    : IStringEnum
{
    public static readonly AssetAssignmentsCreateAssetAssignmentRequestBodyAssigneeType Driver =
        new(Values.Driver);

    public static readonly AssetAssignmentsCreateAssetAssignmentRequestBodyAssigneeType Asset = new(
        Values.Asset
    );

    public static readonly AssetAssignmentsCreateAssetAssignmentRequestBodyAssigneeType Geofence =
        new(Values.Geofence);

    public AssetAssignmentsCreateAssetAssignmentRequestBodyAssigneeType(string value)
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
    public static AssetAssignmentsCreateAssetAssignmentRequestBodyAssigneeType FromCustom(
        string value
    )
    {
        return new AssetAssignmentsCreateAssetAssignmentRequestBodyAssigneeType(value);
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
        AssetAssignmentsCreateAssetAssignmentRequestBodyAssigneeType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetAssignmentsCreateAssetAssignmentRequestBodyAssigneeType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetAssignmentsCreateAssetAssignmentRequestBodyAssigneeType value
    ) => value.Value;

    public static explicit operator AssetAssignmentsCreateAssetAssignmentRequestBodyAssigneeType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Driver = "driver";

        public const string Asset = "asset";

        public const string Geofence = "geofence";
    }
}
