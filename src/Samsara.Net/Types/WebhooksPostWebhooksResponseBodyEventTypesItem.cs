using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<WebhooksPostWebhooksResponseBodyEventTypesItem>))]
public enum WebhooksPostWebhooksResponseBodyEventTypesItem
{
    [EnumMember(Value = "AddressCreated")]
    AddressCreated,

    [EnumMember(Value = "AddressDeleted")]
    AddressDeleted,

    [EnumMember(Value = "AddressUpdated")]
    AddressUpdated,

    [EnumMember(Value = "AlertIncident")]
    AlertIncident,

    [EnumMember(Value = "AlertObjectEvent")]
    AlertObjectEvent,

    [EnumMember(Value = "DocumentSubmitted")]
    DocumentSubmitted,

    [EnumMember(Value = "DriverCreated")]
    DriverCreated,

    [EnumMember(Value = "DriverUpdated")]
    DriverUpdated,

    [EnumMember(Value = "DvirSubmitted")]
    DvirSubmitted,

    [EnumMember(Value = "EngineFaultOff")]
    EngineFaultOff,

    [EnumMember(Value = "EngineFaultOn")]
    EngineFaultOn,

    [EnumMember(Value = "FormSubmitted")]
    FormSubmitted,

    [EnumMember(Value = "GatewayUnplugged")]
    GatewayUnplugged,

    [EnumMember(Value = "GeofenceEntry")]
    GeofenceEntry,

    [EnumMember(Value = "GeofenceExit")]
    GeofenceExit,

    [EnumMember(Value = "IssueCreated")]
    IssueCreated,

    [EnumMember(Value = "PredictiveMaintenanceAlert")]
    PredictiveMaintenanceAlert,

    [EnumMember(Value = "RouteStopArrival")]
    RouteStopArrival,

    [EnumMember(Value = "RouteStopDeparture")]
    RouteStopDeparture,

    [EnumMember(Value = "RouteStopResequence")]
    RouteStopResequence,

    [EnumMember(Value = "SevereSpeedingEnded")]
    SevereSpeedingEnded,

    [EnumMember(Value = "SevereSpeedingStarted")]
    SevereSpeedingStarted,

    [EnumMember(Value = "SuddenFuelLevelDrop")]
    SuddenFuelLevelDrop,

    [EnumMember(Value = "SuddenFuelLevelRise")]
    SuddenFuelLevelRise,

    [EnumMember(Value = "VehicleCreated")]
    VehicleCreated,

    [EnumMember(Value = "VehicleUpdated")]
    VehicleUpdated,
}
