using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FleetOrderTaskObjectResponseBodyTaskType>))]
[Serializable]
public readonly record struct FleetOrderTaskObjectResponseBodyTaskType : IStringEnum
{
    public static readonly FleetOrderTaskObjectResponseBodyTaskType Unknown = new(Values.Unknown);

    public static readonly FleetOrderTaskObjectResponseBodyTaskType Delivery = new(Values.Delivery);

    public static readonly FleetOrderTaskObjectResponseBodyTaskType Pickup = new(Values.Pickup);

    public static readonly FleetOrderTaskObjectResponseBodyTaskType PickupDelivery = new(
        Values.PickupDelivery
    );

    public FleetOrderTaskObjectResponseBodyTaskType(string value)
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
    public static FleetOrderTaskObjectResponseBodyTaskType FromCustom(string value)
    {
        return new FleetOrderTaskObjectResponseBodyTaskType(value);
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
        FleetOrderTaskObjectResponseBodyTaskType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FleetOrderTaskObjectResponseBodyTaskType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FleetOrderTaskObjectResponseBodyTaskType value) =>
        value.Value;

    public static explicit operator FleetOrderTaskObjectResponseBodyTaskType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Delivery = "delivery";

        public const string Pickup = "pickup";

        public const string PickupDelivery = "pickupDelivery";
    }
}
