using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<AssetAssignmentAssigneeResponseObjectResponseBodyAssigneeType>)
)]
[Serializable]
public readonly record struct AssetAssignmentAssigneeResponseObjectResponseBodyAssigneeType
    : IStringEnum
{
    public static readonly AssetAssignmentAssigneeResponseObjectResponseBodyAssigneeType Unknown =
        new(Values.Unknown);

    public static readonly AssetAssignmentAssigneeResponseObjectResponseBodyAssigneeType Driver =
        new(Values.Driver);

    public static readonly AssetAssignmentAssigneeResponseObjectResponseBodyAssigneeType Asset =
        new(Values.Asset);

    public static readonly AssetAssignmentAssigneeResponseObjectResponseBodyAssigneeType Geofence =
        new(Values.Geofence);

    public AssetAssignmentAssigneeResponseObjectResponseBodyAssigneeType(string value)
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
    public static AssetAssignmentAssigneeResponseObjectResponseBodyAssigneeType FromCustom(
        string value
    )
    {
        return new AssetAssignmentAssigneeResponseObjectResponseBodyAssigneeType(value);
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
        AssetAssignmentAssigneeResponseObjectResponseBodyAssigneeType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        AssetAssignmentAssigneeResponseObjectResponseBodyAssigneeType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        AssetAssignmentAssigneeResponseObjectResponseBodyAssigneeType value
    ) => value.Value;

    public static explicit operator AssetAssignmentAssigneeResponseObjectResponseBodyAssigneeType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Driver = "driver";

        public const string Asset = "asset";

        public const string Geofence = "geofence";
    }
}
