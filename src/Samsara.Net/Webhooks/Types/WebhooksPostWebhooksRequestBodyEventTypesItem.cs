using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Webhooks;

[JsonConverter(typeof(StringEnumSerializer<WebhooksPostWebhooksRequestBodyEventTypesItem>))]
[Serializable]
public readonly record struct WebhooksPostWebhooksRequestBodyEventTypesItem : IStringEnum
{
    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem AddressCreated = new(
        Values.AddressCreated
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem AddressDeleted = new(
        Values.AddressDeleted
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem AddressUpdated = new(
        Values.AddressUpdated
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem AlertIncident = new(
        Values.AlertIncident
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem AlertObjectEvent = new(
        Values.AlertObjectEvent
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem DocumentSubmitted = new(
        Values.DocumentSubmitted
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem DriverCreated = new(
        Values.DriverCreated
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem DriverUpdated = new(
        Values.DriverUpdated
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem DvirSubmitted = new(
        Values.DvirSubmitted
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem EngineFaultOff = new(
        Values.EngineFaultOff
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem EngineFaultOn = new(
        Values.EngineFaultOn
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem FormSubmitted = new(
        Values.FormSubmitted
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem FormUpdated = new(
        Values.FormUpdated
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem GatewayUnplugged = new(
        Values.GatewayUnplugged
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem GeofenceEntry = new(
        Values.GeofenceEntry
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem GeofenceExit = new(
        Values.GeofenceExit
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem IssueCreated = new(
        Values.IssueCreated
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem MissingDvirPastDue = new(
        Values.MissingDvirPastDue
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem PredictiveMaintenanceAlert =
        new(Values.PredictiveMaintenanceAlert);

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem RouteStopArrival = new(
        Values.RouteStopArrival
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem RouteStopDeparture = new(
        Values.RouteStopDeparture
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem RouteStopEarlyLateArrival =
        new(Values.RouteStopEarlyLateArrival);

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem RouteStopEtaUpdated = new(
        Values.RouteStopEtaUpdated
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem RouteStopResequence = new(
        Values.RouteStopResequence
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem SevereSpeedingEnded = new(
        Values.SevereSpeedingEnded
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem SevereSpeedingStarted =
        new(Values.SevereSpeedingStarted);

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem SpeedingEventEnded = new(
        Values.SpeedingEventEnded
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem SpeedingEventStarted = new(
        Values.SpeedingEventStarted
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem SuddenFuelLevelDrop = new(
        Values.SuddenFuelLevelDrop
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem SuddenFuelLevelRise = new(
        Values.SuddenFuelLevelRise
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem VehicleCreated = new(
        Values.VehicleCreated
    );

    public static readonly WebhooksPostWebhooksRequestBodyEventTypesItem VehicleUpdated = new(
        Values.VehicleUpdated
    );

    public WebhooksPostWebhooksRequestBodyEventTypesItem(string value)
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
    public static WebhooksPostWebhooksRequestBodyEventTypesItem FromCustom(string value)
    {
        return new WebhooksPostWebhooksRequestBodyEventTypesItem(value);
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
        WebhooksPostWebhooksRequestBodyEventTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WebhooksPostWebhooksRequestBodyEventTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WebhooksPostWebhooksRequestBodyEventTypesItem value) =>
        value.Value;

    public static explicit operator WebhooksPostWebhooksRequestBodyEventTypesItem(string value) =>
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
