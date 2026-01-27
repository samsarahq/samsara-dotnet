using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<HosEldEventObjectResponseBodyMalfunctionDiagnosticCode>)
)]
[Serializable]
public readonly record struct HosEldEventObjectResponseBodyMalfunctionDiagnosticCode : IStringEnum
{
    public static readonly HosEldEventObjectResponseBodyMalfunctionDiagnosticCode P = new(Values.P);

    public static readonly HosEldEventObjectResponseBodyMalfunctionDiagnosticCode E = new(Values.E);

    public static readonly HosEldEventObjectResponseBodyMalfunctionDiagnosticCode T = new(Values.T);

    public static readonly HosEldEventObjectResponseBodyMalfunctionDiagnosticCode L = new(Values.L);

    public static readonly HosEldEventObjectResponseBodyMalfunctionDiagnosticCode R = new(Values.R);

    public static readonly HosEldEventObjectResponseBodyMalfunctionDiagnosticCode S = new(Values.S);

    public static readonly HosEldEventObjectResponseBodyMalfunctionDiagnosticCode O = new(Values.O);

    public static readonly HosEldEventObjectResponseBodyMalfunctionDiagnosticCode One = new(
        Values.One
    );

    public static readonly HosEldEventObjectResponseBodyMalfunctionDiagnosticCode Two = new(
        Values.Two
    );

    public static readonly HosEldEventObjectResponseBodyMalfunctionDiagnosticCode Three = new(
        Values.Three
    );

    public static readonly HosEldEventObjectResponseBodyMalfunctionDiagnosticCode Four = new(
        Values.Four
    );

    public static readonly HosEldEventObjectResponseBodyMalfunctionDiagnosticCode Five = new(
        Values.Five
    );

    public static readonly HosEldEventObjectResponseBodyMalfunctionDiagnosticCode Six = new(
        Values.Six
    );

    public HosEldEventObjectResponseBodyMalfunctionDiagnosticCode(string value)
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
    public static HosEldEventObjectResponseBodyMalfunctionDiagnosticCode FromCustom(string value)
    {
        return new HosEldEventObjectResponseBodyMalfunctionDiagnosticCode(value);
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
        HosEldEventObjectResponseBodyMalfunctionDiagnosticCode value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        HosEldEventObjectResponseBodyMalfunctionDiagnosticCode value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        HosEldEventObjectResponseBodyMalfunctionDiagnosticCode value
    ) => value.Value;

    public static explicit operator HosEldEventObjectResponseBodyMalfunctionDiagnosticCode(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string P = "P";

        public const string E = "E";

        public const string T = "T";

        public const string L = "L";

        public const string R = "R";

        public const string S = "S";

        public const string O = "O";

        public const string One = "1";

        public const string Two = "2";

        public const string Three = "3";

        public const string Four = "4";

        public const string Five = "5";

        public const string Six = "6";
    }
}
