using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<QualificationTypeResponseObjectResponseBodyEntityType>))]
[Serializable]
public readonly record struct QualificationTypeResponseObjectResponseBodyEntityType : IStringEnum
{
    public static readonly QualificationTypeResponseObjectResponseBodyEntityType Worker = new(
        Values.Worker
    );

    public static readonly QualificationTypeResponseObjectResponseBodyEntityType Asset = new(
        Values.Asset
    );

    public QualificationTypeResponseObjectResponseBodyEntityType(string value)
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
    public static QualificationTypeResponseObjectResponseBodyEntityType FromCustom(string value)
    {
        return new QualificationTypeResponseObjectResponseBodyEntityType(value);
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
        QualificationTypeResponseObjectResponseBodyEntityType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        QualificationTypeResponseObjectResponseBodyEntityType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        QualificationTypeResponseObjectResponseBodyEntityType value
    ) => value.Value;

    public static explicit operator QualificationTypeResponseObjectResponseBodyEntityType(
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
