using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<FleetOrderServiceLocationObjectResponseBodyServiceLocationType>)
)]
[Serializable]
public readonly record struct FleetOrderServiceLocationObjectResponseBodyServiceLocationType
    : IStringEnum
{
    public static readonly FleetOrderServiceLocationObjectResponseBodyServiceLocationType Unknown =
        new(Values.Unknown);

    public static readonly FleetOrderServiceLocationObjectResponseBodyServiceLocationType SavedAddress =
        new(Values.SavedAddress);

    public static readonly FleetOrderServiceLocationObjectResponseBodyServiceLocationType CustomAddress =
        new(Values.CustomAddress);

    public FleetOrderServiceLocationObjectResponseBodyServiceLocationType(string value)
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
    public static FleetOrderServiceLocationObjectResponseBodyServiceLocationType FromCustom(
        string value
    )
    {
        return new FleetOrderServiceLocationObjectResponseBodyServiceLocationType(value);
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
        FleetOrderServiceLocationObjectResponseBodyServiceLocationType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FleetOrderServiceLocationObjectResponseBodyServiceLocationType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FleetOrderServiceLocationObjectResponseBodyServiceLocationType value
    ) => value.Value;

    public static explicit operator FleetOrderServiceLocationObjectResponseBodyServiceLocationType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string SavedAddress = "savedAddress";

        public const string CustomAddress = "customAddress";
    }
}
