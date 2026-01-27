using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FieldObjectResponseBodyType>))]
[Serializable]
public readonly record struct FieldObjectResponseBodyType : IStringEnum
{
    public static readonly FieldObjectResponseBodyType Photo = new(Values.Photo);

    public static readonly FieldObjectResponseBodyType String = new(Values.String);

    public static readonly FieldObjectResponseBodyType Number = new(Values.Number);

    public static readonly FieldObjectResponseBodyType MultipleChoice = new(Values.MultipleChoice);

    public static readonly FieldObjectResponseBodyType Signature = new(Values.Signature);

    public static readonly FieldObjectResponseBodyType DateTime = new(Values.DateTime);

    public static readonly FieldObjectResponseBodyType ScannedDocument = new(
        Values.ScannedDocument
    );

    public static readonly FieldObjectResponseBodyType Barcode = new(Values.Barcode);

    public FieldObjectResponseBodyType(string value)
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
    public static FieldObjectResponseBodyType FromCustom(string value)
    {
        return new FieldObjectResponseBodyType(value);
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

    public static bool operator ==(FieldObjectResponseBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FieldObjectResponseBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FieldObjectResponseBodyType value) => value.Value;

    public static explicit operator FieldObjectResponseBodyType(string value) => new(value);

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
