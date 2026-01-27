using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<GatewayResponseObjectResponseBodyModel>))]
[Serializable]
public readonly record struct GatewayResponseObjectResponseBodyModel : IStringEnum
{
    public static readonly GatewayResponseObjectResponseBodyModel Ag15 = new(Values.Ag15);

    public static readonly GatewayResponseObjectResponseBodyModel Ag24 = new(Values.Ag24);

    public static readonly GatewayResponseObjectResponseBodyModel Ag24Eu = new(Values.Ag24Eu);

    public static readonly GatewayResponseObjectResponseBodyModel Ag26 = new(Values.Ag26);

    public static readonly GatewayResponseObjectResponseBodyModel Ag26Eu = new(Values.Ag26Eu);

    public static readonly GatewayResponseObjectResponseBodyModel Ag41 = new(Values.Ag41);

    public static readonly GatewayResponseObjectResponseBodyModel Ag41Eu = new(Values.Ag41Eu);

    public static readonly GatewayResponseObjectResponseBodyModel Ag45 = new(Values.Ag45);

    public static readonly GatewayResponseObjectResponseBodyModel Ag45Eu = new(Values.Ag45Eu);

    public static readonly GatewayResponseObjectResponseBodyModel Ag46 = new(Values.Ag46);

    public static readonly GatewayResponseObjectResponseBodyModel Ag46Eu = new(Values.Ag46Eu);

    public static readonly GatewayResponseObjectResponseBodyModel Ag46P = new(Values.Ag46P);

    public static readonly GatewayResponseObjectResponseBodyModel Ag46Peu = new(Values.Ag46Peu);

    public static readonly GatewayResponseObjectResponseBodyModel Ag51 = new(Values.Ag51);

    public static readonly GatewayResponseObjectResponseBodyModel Ag51Eu = new(Values.Ag51Eu);

    public static readonly GatewayResponseObjectResponseBodyModel Ag52 = new(Values.Ag52);

    public static readonly GatewayResponseObjectResponseBodyModel Ag52Eu = new(Values.Ag52Eu);

    public static readonly GatewayResponseObjectResponseBodyModel Ag53 = new(Values.Ag53);

    public static readonly GatewayResponseObjectResponseBodyModel Ag53Eu = new(Values.Ag53Eu);

    public static readonly GatewayResponseObjectResponseBodyModel Ig15 = new(Values.Ig15);

    public static readonly GatewayResponseObjectResponseBodyModel Ig21 = new(Values.Ig21);

    public static readonly GatewayResponseObjectResponseBodyModel Ig41 = new(Values.Ig41);

    public static readonly GatewayResponseObjectResponseBodyModel Ig61 = new(Values.Ig61);

    public static readonly GatewayResponseObjectResponseBodyModel Sg1 = new(Values.Sg1);

    public static readonly GatewayResponseObjectResponseBodyModel Sg1B = new(Values.Sg1B);

    public static readonly GatewayResponseObjectResponseBodyModel Sg1G = new(Values.Sg1G);

    public static readonly GatewayResponseObjectResponseBodyModel Sg1G32 = new(Values.Sg1G32);

    public static readonly GatewayResponseObjectResponseBodyModel Sg1X = new(Values.Sg1X);

    public static readonly GatewayResponseObjectResponseBodyModel Vg32 = new(Values.Vg32);

    public static readonly GatewayResponseObjectResponseBodyModel Vg33 = new(Values.Vg33);

    public static readonly GatewayResponseObjectResponseBodyModel Vg34 = new(Values.Vg34);

    public static readonly GatewayResponseObjectResponseBodyModel Vg34Eu = new(Values.Vg34Eu);

    public static readonly GatewayResponseObjectResponseBodyModel Vg34Fn = new(Values.Vg34Fn);

    public static readonly GatewayResponseObjectResponseBodyModel Vg34M = new(Values.Vg34M);

    public static readonly GatewayResponseObjectResponseBodyModel Vg54Att = new(Values.Vg54Att);

    public static readonly GatewayResponseObjectResponseBodyModel Vg54Eu = new(Values.Vg54Eu);

    public static readonly GatewayResponseObjectResponseBodyModel Vg54Fn = new(Values.Vg54Fn);

    public static readonly GatewayResponseObjectResponseBodyModel Vg54Na = new(Values.Vg54Na);

    public static readonly GatewayResponseObjectResponseBodyModel Vg54Nae = new(Values.Vg54Nae);

    public static readonly GatewayResponseObjectResponseBodyModel Vg54Nah = new(Values.Vg54Nah);

    public static readonly GatewayResponseObjectResponseBodyModel Vg55Eu = new(Values.Vg55Eu);

    public static readonly GatewayResponseObjectResponseBodyModel Vg55Fn = new(Values.Vg55Fn);

    public static readonly GatewayResponseObjectResponseBodyModel Vg55Na = new(Values.Vg55Na);

    public GatewayResponseObjectResponseBodyModel(string value)
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
    public static GatewayResponseObjectResponseBodyModel FromCustom(string value)
    {
        return new GatewayResponseObjectResponseBodyModel(value);
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

    public static bool operator ==(GatewayResponseObjectResponseBodyModel value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(GatewayResponseObjectResponseBodyModel value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(GatewayResponseObjectResponseBodyModel value) =>
        value.Value;

    public static explicit operator GatewayResponseObjectResponseBodyModel(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Ag15 = "AG15";

        public const string Ag24 = "AG24";

        public const string Ag24Eu = "AG24EU";

        public const string Ag26 = "AG26";

        public const string Ag26Eu = "AG26EU";

        public const string Ag41 = "AG41";

        public const string Ag41Eu = "AG41EU";

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

        public const string Ig15 = "IG15";

        public const string Ig21 = "IG21";

        public const string Ig41 = "IG41";

        public const string Ig61 = "IG61";

        public const string Sg1 = "SG1";

        public const string Sg1B = "SG1B";

        public const string Sg1G = "SG1G";

        public const string Sg1G32 = "SG1G32";

        public const string Sg1X = "SG1x";

        public const string Vg32 = "VG32";

        public const string Vg33 = "VG33";

        public const string Vg34 = "VG34";

        public const string Vg34Eu = "VG34EU";

        public const string Vg34Fn = "VG34FN";

        public const string Vg34M = "VG34M";

        public const string Vg54Att = "VG54ATT";

        public const string Vg54Eu = "VG54EU";

        public const string Vg54Fn = "VG54FN";

        public const string Vg54Na = "VG54NA";

        public const string Vg54Nae = "VG54NAE";

        public const string Vg54Nah = "VG54NAH";

        public const string Vg55Eu = "VG55EU";

        public const string Vg55Fn = "VG55FN";

        public const string Vg55Na = "VG55NA";
    }
}
