using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<FleetOrderServiceLocationInputRequestBodyServiceLocationType>)
)]
[Serializable]
public readonly record struct FleetOrderServiceLocationInputRequestBodyServiceLocationType
    : IStringEnum
{
    public static readonly FleetOrderServiceLocationInputRequestBodyServiceLocationType SavedAddress =
        new(Values.SavedAddress);

    public static readonly FleetOrderServiceLocationInputRequestBodyServiceLocationType CustomAddress =
        new(Values.CustomAddress);

    public FleetOrderServiceLocationInputRequestBodyServiceLocationType(string value)
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
    public static FleetOrderServiceLocationInputRequestBodyServiceLocationType FromCustom(
        string value
    )
    {
        return new FleetOrderServiceLocationInputRequestBodyServiceLocationType(value);
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
        FleetOrderServiceLocationInputRequestBodyServiceLocationType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FleetOrderServiceLocationInputRequestBodyServiceLocationType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FleetOrderServiceLocationInputRequestBodyServiceLocationType value
    ) => value.Value;

    public static explicit operator FleetOrderServiceLocationInputRequestBodyServiceLocationType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string SavedAddress = "savedAddress";

        public const string CustomAddress = "customAddress";
    }
}
