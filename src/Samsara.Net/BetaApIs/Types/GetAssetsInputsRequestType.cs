using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<GetAssetsInputsRequestType>))]
[Serializable]
public readonly record struct GetAssetsInputsRequestType : IStringEnum
{
    public static readonly GetAssetsInputsRequestType AuxInput1 = new(Values.AuxInput1);

    public static readonly GetAssetsInputsRequestType AuxInput2 = new(Values.AuxInput2);

    public static readonly GetAssetsInputsRequestType AuxInput3 = new(Values.AuxInput3);

    public static readonly GetAssetsInputsRequestType AuxInput4 = new(Values.AuxInput4);

    public static readonly GetAssetsInputsRequestType AuxInput5 = new(Values.AuxInput5);

    public static readonly GetAssetsInputsRequestType AuxInput6 = new(Values.AuxInput6);

    public static readonly GetAssetsInputsRequestType AuxInput7 = new(Values.AuxInput7);

    public static readonly GetAssetsInputsRequestType AuxInput8 = new(Values.AuxInput8);

    public static readonly GetAssetsInputsRequestType AuxInput9 = new(Values.AuxInput9);

    public static readonly GetAssetsInputsRequestType AuxInput10 = new(Values.AuxInput10);

    public static readonly GetAssetsInputsRequestType AuxInput11 = new(Values.AuxInput11);

    public static readonly GetAssetsInputsRequestType AuxInput12 = new(Values.AuxInput12);

    public static readonly GetAssetsInputsRequestType AuxInput13 = new(Values.AuxInput13);

    public static readonly GetAssetsInputsRequestType AnalogInput1Voltage = new(
        Values.AnalogInput1Voltage
    );

    public static readonly GetAssetsInputsRequestType AnalogInput2Voltage = new(
        Values.AnalogInput2Voltage
    );

    public static readonly GetAssetsInputsRequestType AnalogInput1Current = new(
        Values.AnalogInput1Current
    );

    public static readonly GetAssetsInputsRequestType AnalogInput2Current = new(
        Values.AnalogInput2Current
    );

    public static readonly GetAssetsInputsRequestType BatteryVoltage = new(Values.BatteryVoltage);

    public GetAssetsInputsRequestType(string value)
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
    public static GetAssetsInputsRequestType FromCustom(string value)
    {
        return new GetAssetsInputsRequestType(value);
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

    public static bool operator ==(GetAssetsInputsRequestType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GetAssetsInputsRequestType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GetAssetsInputsRequestType value) => value.Value;

    public static explicit operator GetAssetsInputsRequestType(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string AuxInput1 = "auxInput1";

        public const string AuxInput2 = "auxInput2";

        public const string AuxInput3 = "auxInput3";

        public const string AuxInput4 = "auxInput4";

        public const string AuxInput5 = "auxInput5";

        public const string AuxInput6 = "auxInput6";

        public const string AuxInput7 = "auxInput7";

        public const string AuxInput8 = "auxInput8";

        public const string AuxInput9 = "auxInput9";

        public const string AuxInput10 = "auxInput10";

        public const string AuxInput11 = "auxInput11";

        public const string AuxInput12 = "auxInput12";

        public const string AuxInput13 = "auxInput13";

        public const string AnalogInput1Voltage = "analogInput1Voltage";

        public const string AnalogInput2Voltage = "analogInput2Voltage";

        public const string AnalogInput1Current = "analogInput1Current";

        public const string AnalogInput2Current = "analogInput2Current";

        public const string BatteryVoltage = "batteryVoltage";
    }
}
