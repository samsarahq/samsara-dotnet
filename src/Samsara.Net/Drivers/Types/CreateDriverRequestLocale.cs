using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Drivers;

[JsonConverter(typeof(StringEnumSerializer<CreateDriverRequestLocale>))]
[Serializable]
public readonly record struct CreateDriverRequestLocale : IStringEnum
{
    public static readonly CreateDriverRequestLocale Us = new(Values.Us);

    public static readonly CreateDriverRequestLocale At = new(Values.At);

    public static readonly CreateDriverRequestLocale Be = new(Values.Be);

    public static readonly CreateDriverRequestLocale Ca = new(Values.Ca);

    public static readonly CreateDriverRequestLocale Gb = new(Values.Gb);

    public static readonly CreateDriverRequestLocale Fr = new(Values.Fr);

    public static readonly CreateDriverRequestLocale De = new(Values.De);

    public static readonly CreateDriverRequestLocale Ie = new(Values.Ie);

    public static readonly CreateDriverRequestLocale It = new(Values.It);

    public static readonly CreateDriverRequestLocale Lu = new(Values.Lu);

    public static readonly CreateDriverRequestLocale Mx = new(Values.Mx);

    public static readonly CreateDriverRequestLocale Nl = new(Values.Nl);

    public static readonly CreateDriverRequestLocale Es = new(Values.Es);

    public static readonly CreateDriverRequestLocale Ch = new(Values.Ch);

    public static readonly CreateDriverRequestLocale Pr = new(Values.Pr);

    public CreateDriverRequestLocale(string value)
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
    public static CreateDriverRequestLocale FromCustom(string value)
    {
        return new CreateDriverRequestLocale(value);
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

    public static bool operator ==(CreateDriverRequestLocale value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(CreateDriverRequestLocale value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(CreateDriverRequestLocale value) => value.Value;

    public static explicit operator CreateDriverRequestLocale(string value) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Us = "us";

        public const string At = "at";

        public const string Be = "be";

        public const string Ca = "ca";

        public const string Gb = "gb";

        public const string Fr = "fr";

        public const string De = "de";

        public const string Ie = "ie";

        public const string It = "it";

        public const string Lu = "lu";

        public const string Mx = "mx";

        public const string Nl = "nl";

        public const string Es = "es";

        public const string Ch = "ch";

        public const string Pr = "pr";
    }
}
