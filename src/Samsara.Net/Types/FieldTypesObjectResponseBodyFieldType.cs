using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FieldTypesObjectResponseBodyFieldType>))]
[Serializable]
public readonly record struct FieldTypesObjectResponseBodyFieldType : IStringEnum
{
    public static readonly FieldTypesObjectResponseBodyFieldType Photo = new(Values.Photo);

    public static readonly FieldTypesObjectResponseBodyFieldType String = new(Values.String);

    public static readonly FieldTypesObjectResponseBodyFieldType Number = new(Values.Number);

    public static readonly FieldTypesObjectResponseBodyFieldType MultipleChoice = new(
        Values.MultipleChoice
    );

    public static readonly FieldTypesObjectResponseBodyFieldType Signature = new(Values.Signature);

    public static readonly FieldTypesObjectResponseBodyFieldType DateTime = new(Values.DateTime);

    public static readonly FieldTypesObjectResponseBodyFieldType ScannedDocument = new(
        Values.ScannedDocument
    );

    public static readonly FieldTypesObjectResponseBodyFieldType Barcode = new(Values.Barcode);

    public FieldTypesObjectResponseBodyFieldType(string value)
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
    public static FieldTypesObjectResponseBodyFieldType FromCustom(string value)
    {
        return new FieldTypesObjectResponseBodyFieldType(value);
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

    public static bool operator ==(FieldTypesObjectResponseBodyFieldType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FieldTypesObjectResponseBodyFieldType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FieldTypesObjectResponseBodyFieldType value) =>
        value.Value;

    public static explicit operator FieldTypesObjectResponseBodyFieldType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Photo = "photo";

        public const string String = "string";

        public const string Number = "number";

        public const string MultipleChoice = "multipleChoice";

        public const string Signature = "signature";

        public const string DateTime = "dateTime";

        public const string ScannedDocument = "scannedDocument";

        public const string Barcode = "barcode";
    }
}
