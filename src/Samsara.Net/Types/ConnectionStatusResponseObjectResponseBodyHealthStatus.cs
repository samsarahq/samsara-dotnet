using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<ConnectionStatusResponseObjectResponseBodyHealthStatus>)
)]
[Serializable]
public readonly record struct ConnectionStatusResponseObjectResponseBodyHealthStatus : IStringEnum
{
    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus StatusNotSet =
        new(Values.StatusNotSet);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus Connected = new(
        Values.Connected
    );

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus NotInstalled =
        new(Values.NotInstalled);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus PowerSourceOffActiveVehicle =
        new(Values.PowerSourceOffActiveVehicle);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus PowerSourceOffInactiveVehicle =
        new(Values.PowerSourceOffInactiveVehicle);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus WeakCellularSignal =
        new(Values.WeakCellularSignal);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus RequiresInvestigation =
        new(Values.RequiresInvestigation);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus RequiresCharge =
        new(Values.RequiresCharge);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus UnsupportedProduct =
        new(Values.UnsupportedProduct);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus LowBatteryReplaceDevice =
        new(Values.LowBatteryReplaceDevice);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus LowVehicleBattery =
        new(Values.LowVehicleBattery);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus Unplugged = new(
        Values.Unplugged
    );

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus LowChargingState =
        new(Values.LowChargingState);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus VehicleOff = new(
        Values.VehicleOff
    );

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus WeakGpsSignal =
        new(Values.WeakGpsSignal);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus LowGatewayBattery =
        new(Values.LowGatewayBattery);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus LowGatewayBatteryAg24 =
        new(Values.LowGatewayBatteryAg24);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus LowGatewayBatteryAg45 =
        new(Values.LowGatewayBatteryAg45);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus LowGatewayBatteryAg26 =
        new(Values.LowGatewayBatteryAg26);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus LowGatewayBatteryAg46 =
        new(Values.LowGatewayBatteryAg46);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus LowGatewayBatteryAg46P =
        new(Values.LowGatewayBatteryAg46P);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus TemporarilyOffline =
        new(Values.TemporarilyOffline);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus ProlongedOffline =
        new(Values.ProlongedOffline);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus RecentlyOffline =
        new(Values.RecentlyOffline);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus ReplacementRequired =
        new(Values.ReplacementRequired);

    public static readonly ConnectionStatusResponseObjectResponseBodyHealthStatus StatusUnknown =
        new(Values.StatusUnknown);

    public ConnectionStatusResponseObjectResponseBodyHealthStatus(string value)
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
    public static ConnectionStatusResponseObjectResponseBodyHealthStatus FromCustom(string value)
    {
        return new ConnectionStatusResponseObjectResponseBodyHealthStatus(value);
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
        ConnectionStatusResponseObjectResponseBodyHealthStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ConnectionStatusResponseObjectResponseBodyHealthStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ConnectionStatusResponseObjectResponseBodyHealthStatus value
    ) => value.Value;

    public static explicit operator ConnectionStatusResponseObjectResponseBodyHealthStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string StatusNotSet = "Status Not Set";

        public const string Connected = "Connected";

        public const string NotInstalled = "Not Installed";

        public const string PowerSourceOffActiveVehicle = "Power Source Off - Active Vehicle";

        public const string PowerSourceOffInactiveVehicle = "Power Source Off - Inactive Vehicle";

        public const string WeakCellularSignal = "Weak Cellular Signal";

        public const string RequiresInvestigation = "Requires Investigation";

        public const string RequiresCharge = "Requires Charge";

        public const string UnsupportedProduct = "Unsupported Product";

        public const string LowBatteryReplaceDevice = "Low Battery. Replace Device.";

        public const string LowVehicleBattery = "Low Vehicle Battery";

        public const string Unplugged = "Unplugged";

        public const string LowChargingState = "Low Charging State";

        public const string VehicleOff = "Vehicle Off";

        public const string WeakGpsSignal = "Weak GPS Signal";

        public const string LowGatewayBattery = "Low Gateway Battery";

        public const string LowGatewayBatteryAg24 = "Low Gateway Battery (AG24)";

        public const string LowGatewayBatteryAg45 = "Low Gateway Battery (AG45)";

        public const string LowGatewayBatteryAg26 = "Low Gateway Battery (AG26)";

        public const string LowGatewayBatteryAg46 = "Low Gateway Battery (AG46)";

        public const string LowGatewayBatteryAg46P = "Low Gateway Battery (AG46-P)";

        public const string TemporarilyOffline = "Temporarily Offline";

        public const string ProlongedOffline = "Prolonged Offline";

        public const string RecentlyOffline = "Recently Offline";

        public const string ReplacementRequired = "Replacement Required";

        public const string StatusUnknown = "Status Unknown";
    }
}
