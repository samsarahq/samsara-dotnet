using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WatchpointCustomDetectionResponseTypeResponseBodyType>))]
[Serializable]
public readonly record struct WatchpointCustomDetectionResponseTypeResponseBodyType : IStringEnum
{
    public static readonly WatchpointCustomDetectionResponseTypeResponseBodyType Unknown = new(
        Values.Unknown
    );

    public static readonly WatchpointCustomDetectionResponseTypeResponseBodyType WorkZone = new(
        Values.WorkZone
    );

    public static readonly WatchpointCustomDetectionResponseTypeResponseBodyType StoppedVehicle =
        new(Values.StoppedVehicle);

    public static readonly WatchpointCustomDetectionResponseTypeResponseBodyType VehicleCollision =
        new(Values.VehicleCollision);

    public static readonly WatchpointCustomDetectionResponseTypeResponseBodyType RoadObstruction =
        new(Values.RoadObstruction);

    public static readonly WatchpointCustomDetectionResponseTypeResponseBodyType RoadClosure = new(
        Values.RoadClosure
    );

    public static readonly WatchpointCustomDetectionResponseTypeResponseBodyType RoadDefect = new(
        Values.RoadDefect
    );

    public static readonly WatchpointCustomDetectionResponseTypeResponseBodyType TrafficSignalFault =
        new(Values.TrafficSignalFault);

    public WatchpointCustomDetectionResponseTypeResponseBodyType(string value)
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
    public static WatchpointCustomDetectionResponseTypeResponseBodyType FromCustom(string value)
    {
        return new WatchpointCustomDetectionResponseTypeResponseBodyType(value);
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
        WatchpointCustomDetectionResponseTypeResponseBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WatchpointCustomDetectionResponseTypeResponseBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        WatchpointCustomDetectionResponseTypeResponseBodyType value
    ) => value.Value;

    public static explicit operator WatchpointCustomDetectionResponseTypeResponseBodyType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string WorkZone = "workZone";

        public const string StoppedVehicle = "stoppedVehicle";

        public const string VehicleCollision = "vehicleCollision";

        public const string RoadObstruction = "roadObstruction";

        public const string RoadClosure = "roadClosure";

        public const string RoadDefect = "roadDefect";

        public const string TrafficSignalFault = "trafficSignalFault";
    }
}
