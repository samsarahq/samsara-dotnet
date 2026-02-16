using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FormsApprovalConfigObjectResponseBodyType>))]
[Serializable]
public readonly record struct FormsApprovalConfigObjectResponseBodyType : IStringEnum
{
    public static readonly FormsApprovalConfigObjectResponseBodyType SingleApproval = new(
        Values.SingleApproval
    );

    public FormsApprovalConfigObjectResponseBodyType(string value)
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
    public static FormsApprovalConfigObjectResponseBodyType FromCustom(string value)
    {
        return new FormsApprovalConfigObjectResponseBodyType(value);
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
        FormsApprovalConfigObjectResponseBodyType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        FormsApprovalConfigObjectResponseBodyType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(FormsApprovalConfigObjectResponseBodyType value) =>
        value.Value;

    public static explicit operator FormsApprovalConfigObjectResponseBodyType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string SingleApproval = "singleApproval";
    }
}
