using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormTemplateResponseObjectResponseBodyFormCategory>))]
[Serializable]
public readonly record struct FormTemplateResponseObjectResponseBodyFormCategory : IStringEnum
{
    public static readonly FormTemplateResponseObjectResponseBodyFormCategory General = new(
        Values.General
    );

    public static readonly FormTemplateResponseObjectResponseBodyFormCategory Routing = new(
        Values.Routing
    );

    public static readonly FormTemplateResponseObjectResponseBodyFormCategory Fuel = new(
        Values.Fuel
    );

    public FormTemplateResponseObjectResponseBodyFormCategory(string value)
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
    public static FormTemplateResponseObjectResponseBodyFormCategory FromCustom(string value)
    {
        return new FormTemplateResponseObjectResponseBodyFormCategory(value);
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
        FormTemplateResponseObjectResponseBodyFormCategory value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormTemplateResponseObjectResponseBodyFormCategory value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        FormTemplateResponseObjectResponseBodyFormCategory value
    ) => value.Value;

    public static explicit operator FormTemplateResponseObjectResponseBodyFormCategory(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string General = "general";

        public const string Routing = "routing";

        public const string Fuel = "fuel";
    }
}
