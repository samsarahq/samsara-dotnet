using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WatchpointCustomDetectionRequestTypeRequestBodyType>))]
[Serializable]
public readonly record struct WatchpointCustomDetectionRequestTypeRequestBodyType : IStringEnum
{
    public static readonly WatchpointCustomDetectionRequestTypeRequestBodyType WorkZone = new(
        Values.WorkZone
    );

    public static readonly WatchpointCustomDetectionRequestTypeRequestBodyType StoppedVehicle = new(
        Values.StoppedVehicle
    );

    public static readonly WatchpointCustomDetectionRequestTypeRequestBodyType VehicleCollision =
        new(Values.VehicleCollision);

    public static readonly WatchpointCustomDetectionRequestTypeRequestBodyType RoadObstruction =
        new(Values.RoadObstruction);

    public static readonly WatchpointCustomDetectionRequestTypeRequestBodyType RoadClosure = new(
        Values.RoadClosure
    );

    public static readonly WatchpointCustomDetectionRequestTypeRequestBodyType RoadDefect = new(
        Values.RoadDefect
    );

    public static readonly WatchpointCustomDetectionRequestTypeRequestBodyType TrafficSignalFault =
        new(Values.TrafficSignalFault);

    public WatchpointCustomDetectionRequestTypeRequestBodyType(string value)
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
    public static WatchpointCustomDetectionRequestTypeRequestBodyType FromCustom(string value)
    {
        return new WatchpointCustomDetectionRequestTypeRequestBodyType(value);
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
        WatchpointCustomDetectionRequestTypeRequestBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WatchpointCustomDetectionRequestTypeRequestBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        WatchpointCustomDetectionRequestTypeRequestBodyType value
    ) => value.Value;

    public static explicit operator WatchpointCustomDetectionRequestTypeRequestBodyType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string WorkZone = "workZone";

        public const string StoppedVehicle = "stoppedVehicle";

        public const string VehicleCollision = "vehicleCollision";

        public const string RoadObstruction = "roadObstruction";

        public const string RoadClosure = "roadClosure";

        public const string RoadDefect = "roadDefect";

        public const string TrafficSignalFault = "trafficSignalFault";
    }
}
