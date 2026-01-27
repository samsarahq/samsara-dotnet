using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<QualificationOwnerRequestObjectRequestBodyEntityType>))]
[Serializable]
public readonly record struct QualificationOwnerRequestObjectRequestBodyEntityType : IStringEnum
{
    public static readonly QualificationOwnerRequestObjectRequestBodyEntityType Worker = new(
        Values.Worker
    );

    public static readonly QualificationOwnerRequestObjectRequestBodyEntityType Asset = new(
        Values.Asset
    );

    public QualificationOwnerRequestObjectRequestBodyEntityType(string value)
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
    public static QualificationOwnerRequestObjectRequestBodyEntityType FromCustom(string value)
    {
        return new QualificationOwnerRequestObjectRequestBodyEntityType(value);
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
        QualificationOwnerRequestObjectRequestBodyEntityType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        QualificationOwnerRequestObjectRequestBodyEntityType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        QualificationOwnerRequestObjectRequestBodyEntityType value
    ) => value.Value;

    public static explicit operator QualificationOwnerRequestObjectRequestBodyEntityType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Worker = "worker";

        public const string Asset = "asset";
    }
}
