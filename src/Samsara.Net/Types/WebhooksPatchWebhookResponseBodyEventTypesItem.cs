using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WebhooksPatchWebhookResponseBodyEventTypesItem>))]
[Serializable]
public readonly record struct WebhooksPatchWebhookResponseBodyEventTypesItem : IStringEnum
{
    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem AddressCreated = new(
        Values.AddressCreated
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem AddressDeleted = new(
        Values.AddressDeleted
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem AddressUpdated = new(
        Values.AddressUpdated
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem AlertIncident = new(
        Values.AlertIncident
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem AlertObjectEvent = new(
        Values.AlertObjectEvent
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem DocumentSubmitted = new(
        Values.DocumentSubmitted
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem DriverCreated = new(
        Values.DriverCreated
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem DriverUpdated = new(
        Values.DriverUpdated
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem DvirSubmitted = new(
        Values.DvirSubmitted
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem EngineFaultOff = new(
        Values.EngineFaultOff
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem EngineFaultOn = new(
        Values.EngineFaultOn
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem FormSubmitted = new(
        Values.FormSubmitted
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem FormUpdated = new(
        Values.FormUpdated
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem GatewayUnplugged = new(
        Values.GatewayUnplugged
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem GeofenceEntry = new(
        Values.GeofenceEntry
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem GeofenceExit = new(
        Values.GeofenceExit
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem IssueCreated = new(
        Values.IssueCreated
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem MissingDvirPastDue = new(
        Values.MissingDvirPastDue
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem PredictiveMaintenanceAlert =
        new(Values.PredictiveMaintenanceAlert);

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem RouteStopArrival = new(
        Values.RouteStopArrival
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem RouteStopDeparture = new(
        Values.RouteStopDeparture
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem RouteStopEarlyLateArrival =
        new(Values.RouteStopEarlyLateArrival);

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem RouteStopEtaUpdated = new(
        Values.RouteStopEtaUpdated
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem RouteStopResequence = new(
        Values.RouteStopResequence
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem SevereSpeedingEnded = new(
        Values.SevereSpeedingEnded
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem SevereSpeedingStarted =
        new(Values.SevereSpeedingStarted);

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem SpeedingEventEnded = new(
        Values.SpeedingEventEnded
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem SpeedingEventStarted =
        new(Values.SpeedingEventStarted);

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem SuddenFuelLevelDrop = new(
        Values.SuddenFuelLevelDrop
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem SuddenFuelLevelRise = new(
        Values.SuddenFuelLevelRise
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem VehicleCreated = new(
        Values.VehicleCreated
    );

    public static readonly WebhooksPatchWebhookResponseBodyEventTypesItem VehicleUpdated = new(
        Values.VehicleUpdated
    );

    public WebhooksPatchWebhookResponseBodyEventTypesItem(string value)
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
    public static WebhooksPatchWebhookResponseBodyEventTypesItem FromCustom(string value)
    {
        return new WebhooksPatchWebhookResponseBodyEventTypesItem(value);
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
        WebhooksPatchWebhookResponseBodyEventTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WebhooksPatchWebhookResponseBodyEventTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WebhooksPatchWebhookResponseBodyEventTypesItem value) =>
        value.Value;

    public static explicit operator WebhooksPatchWebhookResponseBodyEventTypesItem(string value) =>
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

        public const string MissingDvirPastDue = "MissingDvirPastDue";

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
