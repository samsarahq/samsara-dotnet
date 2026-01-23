using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<DeviceResponseResponseBodyModel>))]
[Serializable]
public readonly record struct DeviceResponseResponseBodyModel : IStringEnum
{
    public static readonly DeviceResponseResponseBodyModel Ag24 = new(Values.Ag24);

    public static readonly DeviceResponseResponseBodyModel Ag24Eu = new(Values.Ag24Eu);

    public static readonly DeviceResponseResponseBodyModel Ag26 = new(Values.Ag26);

    public static readonly DeviceResponseResponseBodyModel Ag26Eu = new(Values.Ag26Eu);

    public static readonly DeviceResponseResponseBodyModel Ag45 = new(Values.Ag45);

    public static readonly DeviceResponseResponseBodyModel Ag45Eu = new(Values.Ag45Eu);

    public static readonly DeviceResponseResponseBodyModel Ag46 = new(Values.Ag46);

    public static readonly DeviceResponseResponseBodyModel Ag46Eu = new(Values.Ag46Eu);

    public static readonly DeviceResponseResponseBodyModel Ag46P = new(Values.Ag46P);

    public static readonly DeviceResponseResponseBodyModel Ag46Peu = new(Values.Ag46Peu);

    public static readonly DeviceResponseResponseBodyModel Ag51 = new(Values.Ag51);

    public static readonly DeviceResponseResponseBodyModel Ag51Eu = new(Values.Ag51Eu);

    public static readonly DeviceResponseResponseBodyModel Ag52 = new(Values.Ag52);

    public static readonly DeviceResponseResponseBodyModel Ag52Eu = new(Values.Ag52Eu);

    public static readonly DeviceResponseResponseBodyModel Ag53 = new(Values.Ag53);

    public static readonly DeviceResponseResponseBodyModel Ag53Eu = new(Values.Ag53Eu);

    public static readonly DeviceResponseResponseBodyModel At11 = new(Values.At11);

    public static readonly DeviceResponseResponseBodyModel At11X = new(Values.At11X);

    public static readonly DeviceResponseResponseBodyModel Cm31 = new(Values.Cm31);

    public static readonly DeviceResponseResponseBodyModel Cm32 = new(Values.Cm32);

    public static readonly DeviceResponseResponseBodyModel Cm33 = new(Values.Cm33);

    public static readonly DeviceResponseResponseBodyModel Cm34 = new(Values.Cm34);

    public static readonly DeviceResponseResponseBodyModel Oem = new(Values.Oem);

    public static readonly DeviceResponseResponseBodyModel Oemp = new(Values.Oemp);

    public static readonly DeviceResponseResponseBodyModel Oemr = new(Values.Oemr);

    public static readonly DeviceResponseResponseBodyModel Oemv = new(Values.Oemv);

    public static readonly DeviceResponseResponseBodyModel Vg34 = new(Values.Vg34);

    public static readonly DeviceResponseResponseBodyModel Vg34Eu = new(Values.Vg34Eu);

    public static readonly DeviceResponseResponseBodyModel Vg34Fn = new(Values.Vg34Fn);

    public static readonly DeviceResponseResponseBodyModel Vg34M = new(Values.Vg34M);

    public static readonly DeviceResponseResponseBodyModel Vg54Eu = new(Values.Vg54Eu);

    public static readonly DeviceResponseResponseBodyModel Vg54Na = new(Values.Vg54Na);

    public static readonly DeviceResponseResponseBodyModel Vg55Eu = new(Values.Vg55Eu);

    public static readonly DeviceResponseResponseBodyModel Vg55Na = new(Values.Vg55Na);

    public DeviceResponseResponseBodyModel(string value)
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
    public static DeviceResponseResponseBodyModel FromCustom(string value)
    {
        return new DeviceResponseResponseBodyModel(value);
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

    public static bool operator ==(DeviceResponseResponseBodyModel value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(DeviceResponseResponseBodyModel value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(DeviceResponseResponseBodyModel value) => value.Value;

    public static explicit operator DeviceResponseResponseBodyModel(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Ag24 = "AG24";

        public const string Ag24Eu = "AG24EU";

        public const string Ag26 = "AG26";

        public const string Ag26Eu = "AG26EU";

        public const string Ag45 = "AG45";

        public const string Ag45Eu = "AG45EU";

        public const string Ag46 = "AG46";

        public const string Ag46Eu = "AG46EU";

        public const string Ag46P = "AG46P";

        public const string Ag46Peu = "AG46PEU";

        public const string Ag51 = "AG51";

        public const string Ag51Eu = "AG51EU";

        public const string Ag52 = "AG52";

        public const string Ag52Eu = "AG52EU";

        public const string Ag53 = "AG53";

        public const string Ag53Eu = "AG53EU";

        public const string At11 = "AT11";

        public const string At11X = "AT11X";

        public const string Cm31 = "CM31";

        public const string Cm32 = "CM32";

        public const string Cm33 = "CM33";

        public const string Cm34 = "CM34";

        public const string Oem = "OEM";

        public const string Oemp = "OEMP";

        public const string Oemr = "OEMR";

        public const string Oemv = "OEMV";

        public const string Vg34 = "VG34";

        public const string Vg34Eu = "VG34EU";

        public const string Vg34Fn = "VG34FN";

        public const string Vg34M = "VG34M";

        public const string Vg54Eu = "VG54EU";

        public const string Vg54Na = "VG54NA";

        public const string Vg55Eu = "VG55EU";

        public const string Vg55Na = "VG55NA";
    }
}
