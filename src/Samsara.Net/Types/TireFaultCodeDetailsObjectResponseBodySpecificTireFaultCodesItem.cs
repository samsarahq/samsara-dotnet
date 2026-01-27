using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem>)
)]
[Serializable]
public readonly record struct TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem
    : IStringEnum
{
    public static readonly TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem TireAlertAcrossAxleFault =
        new(Values.TireAlertAcrossAxleFault);

    public static readonly TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem TireAlertExtremeOverPressure =
        new(Values.TireAlertExtremeOverPressure);

    public static readonly TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem TireAlertExtremeUnderPressure =
        new(Values.TireAlertExtremeUnderPressure);

    public static readonly TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem TireAlertFlatSpot =
        new(Values.TireAlertFlatSpot);

    public static readonly TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem TireAlertImbalance =
        new(Values.TireAlertImbalance);

    public static readonly TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem TireAlertInvalid =
        new(Values.TireAlertInvalid);

    public static readonly TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem TireAlertLeakDetected =
        new(Values.TireAlertLeakDetected);

    public static readonly TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem TireAlertOverPressure =
        new(Values.TireAlertOverPressure);

    public static readonly TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem TireAlertOverTemperature =
        new(Values.TireAlertOverTemperature);

    public static readonly TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem TireAlertSensorDefect =
        new(Values.TireAlertSensorDefect);

    public static readonly TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem TireAlertSensorLooseOrFlipped =
        new(Values.TireAlertSensorLooseOrFlipped);

    public static readonly TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem TireAlertSensorLowBattery =
        new(Values.TireAlertSensorLowBattery);

    public static readonly TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem TireAlertSensorMissing =
        new(Values.TireAlertSensorMissing);

    public static readonly TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem TireAlertUnderPressure =
        new(Values.TireAlertUnderPressure);

    public TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem(string value)
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
    public static TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem FromCustom(
        string value
    )
    {
        return new TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem(value);
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
        TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem value
    ) => value.Value;

    public static explicit operator TireFaultCodeDetailsObjectResponseBodySpecificTireFaultCodesItem(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string TireAlertAcrossAxleFault = "TIRE_ALERT_ACROSS_AXLE_FAULT";

        public const string TireAlertExtremeOverPressure = "TIRE_ALERT_EXTREME_OVER_PRESSURE";

        public const string TireAlertExtremeUnderPressure = "TIRE_ALERT_EXTREME_UNDER_PRESSURE";

        public const string TireAlertFlatSpot = "TIRE_ALERT_FLAT_SPOT";

        public const string TireAlertImbalance = "TIRE_ALERT_IMBALANCE";

        public const string TireAlertInvalid = "TIRE_ALERT_INVALID";

        public const string TireAlertLeakDetected = "TIRE_ALERT_LEAK_DETECTED";

        public const string TireAlertOverPressure = "TIRE_ALERT_OVER_PRESSURE";

        public const string TireAlertOverTemperature = "TIRE_ALERT_OVER_TEMPERATURE";

        public const string TireAlertSensorDefect = "TIRE_ALERT_SENSOR_DEFECT";

        public const string TireAlertSensorLooseOrFlipped = "TIRE_ALERT_SENSOR_LOOSE_OR_FLIPPED";

        public const string TireAlertSensorLowBattery = "TIRE_ALERT_SENSOR_LOW_BATTERY";

        public const string TireAlertSensorMissing = "TIRE_ALERT_SENSOR_MISSING";

        public const string TireAlertUnderPressure = "TIRE_ALERT_UNDER_PRESSURE";
    }
}
