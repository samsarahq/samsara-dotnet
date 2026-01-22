using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WebhooksGetWebhookResponseBodyEventTypesItem>))]
[Serializable]
public readonly record struct WebhooksGetWebhookResponseBodyEventTypesItem : IStringEnum
{
    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem AddressCreated = new(
        Values.AddressCreated
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem AddressDeleted = new(
        Values.AddressDeleted
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem AddressUpdated = new(
        Values.AddressUpdated
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem AlertIncident = new(
        Values.AlertIncident
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem AlertObjectEvent = new(
        Values.AlertObjectEvent
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem DocumentSubmitted = new(
        Values.DocumentSubmitted
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem DriverCreated = new(
        Values.DriverCreated
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem DriverUpdated = new(
        Values.DriverUpdated
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem DvirSubmitted = new(
        Values.DvirSubmitted
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem EngineFaultOff = new(
        Values.EngineFaultOff
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem EngineFaultOn = new(
        Values.EngineFaultOn
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem FormSubmitted = new(
        Values.FormSubmitted
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem FormUpdated = new(
        Values.FormUpdated
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem GatewayUnplugged = new(
        Values.GatewayUnplugged
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem GeofenceEntry = new(
        Values.GeofenceEntry
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem GeofenceExit = new(
        Values.GeofenceExit
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem IssueCreated = new(
        Values.IssueCreated
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem PredictiveMaintenanceAlert =
        new(Values.PredictiveMaintenanceAlert);

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem RouteStopArrival = new(
        Values.RouteStopArrival
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem RouteStopDeparture = new(
        Values.RouteStopDeparture
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem RouteStopEarlyLateArrival =
        new(Values.RouteStopEarlyLateArrival);

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem RouteStopEtaUpdated = new(
        Values.RouteStopEtaUpdated
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem RouteStopResequence = new(
        Values.RouteStopResequence
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem SevereSpeedingEnded = new(
        Values.SevereSpeedingEnded
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem SevereSpeedingStarted = new(
        Values.SevereSpeedingStarted
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem SpeedingEventEnded = new(
        Values.SpeedingEventEnded
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem SpeedingEventStarted = new(
        Values.SpeedingEventStarted
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem SuddenFuelLevelDrop = new(
        Values.SuddenFuelLevelDrop
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem SuddenFuelLevelRise = new(
        Values.SuddenFuelLevelRise
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem VehicleCreated = new(
        Values.VehicleCreated
    );

    public static readonly WebhooksGetWebhookResponseBodyEventTypesItem VehicleUpdated = new(
        Values.VehicleUpdated
    );

    public WebhooksGetWebhookResponseBodyEventTypesItem(string value)
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
    public static WebhooksGetWebhookResponseBodyEventTypesItem FromCustom(string value)
    {
        return new WebhooksGetWebhookResponseBodyEventTypesItem(value);
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
        WebhooksGetWebhookResponseBodyEventTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WebhooksGetWebhookResponseBodyEventTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WebhooksGetWebhookResponseBodyEventTypesItem value) =>
        value.Value;

    public static explicit operator WebhooksGetWebhookResponseBodyEventTypesItem(string value) =>
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
