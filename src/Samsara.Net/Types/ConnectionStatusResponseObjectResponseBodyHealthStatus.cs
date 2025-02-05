using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(EnumSerializer<ConnectionStatusResponseObjectResponseBodyHealthStatus>))]
public enum ConnectionStatusResponseObjectResponseBodyHealthStatus
{
    [EnumMember(Value = "Status Not Set")]
    StatusNotSet,

    [EnumMember(Value = "Connected")]
    Connected,

    [EnumMember(Value = "Not Installed")]
    NotInstalled,

    [EnumMember(Value = "Power Source Off - Active Vehicle")]
    PowerSourceOffActiveVehicle,

    [EnumMember(Value = "Power Source Off - Inactive Vehicle")]
    PowerSourceOffInactiveVehicle,

    [EnumMember(Value = "Weak Cellular Signal")]
    WeakCellularSignal,

    [EnumMember(Value = "Requires Investigation")]
    RequiresInvestigation,

    [EnumMember(Value = "Requires Charge")]
    RequiresCharge,

    [EnumMember(Value = "Unsupported Product")]
    UnsupportedProduct,

    [EnumMember(Value = "Low Battery. Replace Device.")]
    LowBatteryReplaceDevice,

    [EnumMember(Value = "Low Vehicle Battery")]
    LowVehicleBattery,

    [EnumMember(Value = "Unplugged")]
    Unplugged,

    [EnumMember(Value = "Low Charging State")]
    LowChargingState,

    [EnumMember(Value = "Vehicle Off")]
    VehicleOff,

    [EnumMember(Value = "Weak GPS Signal")]
    WeakGpsSignal,

    [EnumMember(Value = "Low Gateway Battery")]
    LowGatewayBattery,

    [EnumMember(Value = "Low Gateway Battery (AG24)")]
    LowGatewayBatteryAg24,

    [EnumMember(Value = "Low Gateway Battery (AG45)")]
    LowGatewayBatteryAg45,

    [EnumMember(Value = "Low Gateway Battery (AG26)")]
    LowGatewayBatteryAg26,

    [EnumMember(Value = "Low Gateway Battery (AG46)")]
    LowGatewayBatteryAg46,

    [EnumMember(Value = "Low Gateway Battery (AG46-P)")]
    LowGatewayBatteryAg46P,

    [EnumMember(Value = "Temporarily Offline")]
    TemporarilyOffline,

    [EnumMember(Value = "Prolonged Offline")]
    ProlongedOffline,

    [EnumMember(Value = "Recently Offline")]
    RecentlyOffline,

    [EnumMember(Value = "Replacement Required")]
    ReplacementRequired,

    [EnumMember(Value = "Status Unknown")]
    StatusUnknown,
}
