using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WebhookResponseResponseBodyEventTypesItem>))]
[Serializable]
public readonly record struct WebhookResponseResponseBodyEventTypesItem : IStringEnum
{
    public static readonly WebhookResponseResponseBodyEventTypesItem AddressCreated = new(
        Values.AddressCreated
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem AddressDeleted = new(
        Values.AddressDeleted
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem AddressUpdated = new(
        Values.AddressUpdated
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem AlertIncident = new(
        Values.AlertIncident
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem AlertObjectEvent = new(
        Values.AlertObjectEvent
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem DocumentSubmitted = new(
        Values.DocumentSubmitted
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem DriverCreated = new(
        Values.DriverCreated
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem DriverUpdated = new(
        Values.DriverUpdated
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem DvirSubmitted = new(
        Values.DvirSubmitted
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem EngineFaultOff = new(
        Values.EngineFaultOff
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem EngineFaultOn = new(
        Values.EngineFaultOn
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem FormSubmitted = new(
        Values.FormSubmitted
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem FormUpdated = new(
        Values.FormUpdated
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem GatewayUnplugged = new(
        Values.GatewayUnplugged
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem GeofenceEntry = new(
        Values.GeofenceEntry
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem GeofenceExit = new(
        Values.GeofenceExit
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem IssueCreated = new(
        Values.IssueCreated
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem PredictiveMaintenanceAlert =
        new(Values.PredictiveMaintenanceAlert);

    public static readonly WebhookResponseResponseBodyEventTypesItem RouteStopArrival = new(
        Values.RouteStopArrival
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem RouteStopDeparture = new(
        Values.RouteStopDeparture
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem RouteStopEarlyLateArrival =
        new(Values.RouteStopEarlyLateArrival);

    public static readonly WebhookResponseResponseBodyEventTypesItem RouteStopEtaUpdated = new(
        Values.RouteStopEtaUpdated
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem RouteStopResequence = new(
        Values.RouteStopResequence
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem SevereSpeedingEnded = new(
        Values.SevereSpeedingEnded
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem SevereSpeedingStarted = new(
        Values.SevereSpeedingStarted
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem SpeedingEventEnded = new(
        Values.SpeedingEventEnded
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem SpeedingEventStarted = new(
        Values.SpeedingEventStarted
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem SuddenFuelLevelDrop = new(
        Values.SuddenFuelLevelDrop
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem SuddenFuelLevelRise = new(
        Values.SuddenFuelLevelRise
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem VehicleCreated = new(
        Values.VehicleCreated
    );

    public static readonly WebhookResponseResponseBodyEventTypesItem VehicleUpdated = new(
        Values.VehicleUpdated
    );

    public WebhookResponseResponseBodyEventTypesItem(string value)
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
    public static WebhookResponseResponseBodyEventTypesItem FromCustom(string value)
    {
        return new WebhookResponseResponseBodyEventTypesItem(value);
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
        WebhookResponseResponseBodyEventTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WebhookResponseResponseBodyEventTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WebhookResponseResponseBodyEventTypesItem value) =>
        value.Value;

    public static explicit operator WebhookResponseResponseBodyEventTypesItem(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AddressCreated = "AddressCreated";

        public const string AddressDeleted = "AddressDeleted";

        public const string AddressUpdated = "AddressUpdated";

        public const string AlertIncident = "AlertIncident";

        public const string AlertObjectEvent = "AlertObjectEvent";

        public const string DocumentSubmitted = "DocumentSubmitted";

        public const string DriverCreated = "DriverCreated";

        public const string DriverUpdated = "DriverUpdated";

        public const string DvirSubmitted = "DvirSubmitted";

        public const string EngineFaultOff = "EngineFaultOff";

        public const string EngineFaultOn = "EngineFaultOn";

        public const string FormSubmitted = "FormSubmitted";

        public const string FormUpdated = "FormUpdated";

        public const string GatewayUnplugged = "GatewayUnplugged";

        public const string GeofenceEntry = "GeofenceEntry";

        public const string GeofenceExit = "GeofenceExit";

        public const string IssueCreated = "IssueCreated";

        public const string PredictiveMaintenanceAlert = "PredictiveMaintenanceAlert";

        public const string RouteStopArrival = "RouteStopArrival";

        public const string RouteStopDeparture = "RouteStopDeparture";

        public const string RouteStopEarlyLateArrival = "RouteStopEarlyLateArrival";

        public const string RouteStopEtaUpdated = "RouteStopEtaUpdated";

        public const string RouteStopResequence = "RouteStopResequence";

        public const string SevereSpeedingEnded = "SevereSpeedingEnded";

        public const string SevereSpeedingStarted = "SevereSpeedingStarted";

        public const string SpeedingEventEnded = "SpeedingEventEnded";

        public const string SpeedingEventStarted = "SpeedingEventStarted";

        public const string SuddenFuelLevelDrop = "SuddenFuelLevelDrop";

        public const string SuddenFuelLevelRise = "SuddenFuelLevelRise";

        public const string VehicleCreated = "VehicleCreated";

        public const string VehicleUpdated = "VehicleUpdated";
    }
}
