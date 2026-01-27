using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormSubmissionRequestAssignedToRequestBodyType>))]
[Serializable]
public readonly record struct FormSubmissionRequestAssignedToRequestBodyType : IStringEnum
{
    public static readonly FormSubmissionRequestAssignedToRequestBodyType Driver = new(
        Values.Driver
    );

    public static readonly FormSubmissionRequestAssignedToRequestBodyType User = new(Values.User);

    public FormSubmissionRequestAssignedToRequestBodyType(string value)
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
    public static FormSubmissionRequestAssignedToRequestBodyType FromCustom(string value)
    {
        return new FormSubmissionRequestAssignedToRequestBodyType(value);
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
        FormSubmissionRequestAssignedToRequestBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormSubmissionRequestAssignedToRequestBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FormSubmissionRequestAssignedToRequestBodyType value) =>
        value.Value;

    public static explicit operator FormSubmissionRequestAssignedToRequestBodyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Driver = "driver";

        public const string User = "user";
    }
}
