using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<WebhooksPostWebhooksResponseBodyEventTypesItem>))]
[Serializable]
public readonly record struct WebhooksPostWebhooksResponseBodyEventTypesItem : IStringEnum
{
    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem AddressCreated = new(
        Values.AddressCreated
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem AddressDeleted = new(
        Values.AddressDeleted
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem AddressUpdated = new(
        Values.AddressUpdated
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem AlertIncident = new(
        Values.AlertIncident
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem AlertObjectEvent = new(
        Values.AlertObjectEvent
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem DocumentSubmitted = new(
        Values.DocumentSubmitted
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem DriverCreated = new(
        Values.DriverCreated
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem DriverUpdated = new(
        Values.DriverUpdated
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem DvirSubmitted = new(
        Values.DvirSubmitted
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem EngineFaultOff = new(
        Values.EngineFaultOff
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem EngineFaultOn = new(
        Values.EngineFaultOn
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem FormSubmitted = new(
        Values.FormSubmitted
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem FormUpdated = new(
        Values.FormUpdated
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem GatewayUnplugged = new(
        Values.GatewayUnplugged
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem GeofenceEntry = new(
        Values.GeofenceEntry
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem GeofenceExit = new(
        Values.GeofenceExit
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem IssueCreated = new(
        Values.IssueCreated
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem PredictiveMaintenanceAlert =
        new(Values.PredictiveMaintenanceAlert);

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem RouteStopArrival = new(
        Values.RouteStopArrival
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem RouteStopDeparture = new(
        Values.RouteStopDeparture
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem RouteStopEarlyLateArrival =
        new(Values.RouteStopEarlyLateArrival);

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem RouteStopEtaUpdated = new(
        Values.RouteStopEtaUpdated
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem RouteStopResequence = new(
        Values.RouteStopResequence
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem SevereSpeedingEnded = new(
        Values.SevereSpeedingEnded
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem SevereSpeedingStarted =
        new(Values.SevereSpeedingStarted);

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem SpeedingEventEnded = new(
        Values.SpeedingEventEnded
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem SpeedingEventStarted =
        new(Values.SpeedingEventStarted);

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem SuddenFuelLevelDrop = new(
        Values.SuddenFuelLevelDrop
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem SuddenFuelLevelRise = new(
        Values.SuddenFuelLevelRise
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem VehicleCreated = new(
        Values.VehicleCreated
    );

    public static readonly WebhooksPostWebhooksResponseBodyEventTypesItem VehicleUpdated = new(
        Values.VehicleUpdated
    );

    public WebhooksPostWebhooksResponseBodyEventTypesItem(string value)
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
    public static WebhooksPostWebhooksResponseBodyEventTypesItem FromCustom(string value)
    {
        return new WebhooksPostWebhooksResponseBodyEventTypesItem(value);
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
        WebhooksPostWebhooksResponseBodyEventTypesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        WebhooksPostWebhooksResponseBodyEventTypesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(WebhooksPostWebhooksResponseBodyEventTypesItem value) =>
        value.Value;

    public static explicit operator WebhooksPostWebhooksResponseBodyEventTypesItem(string value) =>
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
