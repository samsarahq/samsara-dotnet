using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<FieldObjectPostRequestBodyType>))]
[Serializable]
public readonly record struct FieldObjectPostRequestBodyType : IStringEnum
{
    public static readonly FieldObjectPostRequestBodyType Photo = new(Values.Photo);

    public static readonly FieldObjectPostRequestBodyType String = new(Values.String);

    public static readonly FieldObjectPostRequestBodyType Number = new(Values.Number);

    public static readonly FieldObjectPostRequestBodyType MultipleChoice = new(
        Values.MultipleChoice
    );

    public static readonly FieldObjectPostRequestBodyType Signature = new(Values.Signature);

    public static readonly FieldObjectPostRequestBodyType DateTime = new(Values.DateTime);

    public static readonly FieldObjectPostRequestBodyType ScannedDocument = new(
        Values.ScannedDocument
    );

    public static readonly FieldObjectPostRequestBodyType Barcode = new(Values.Barcode);

    public FieldObjectPostRequestBodyType(string value)
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
    public static FieldObjectPostRequestBodyType FromCustom(string value)
    {
        return new FieldObjectPostRequestBodyType(value);
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

    public static bool operator ==(FieldObjectPostRequestBodyType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(FieldObjectPostRequestBodyType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(FieldObjectPostRequestBodyType value) => value.Value;

    public static explicit operator FieldObjectPostRequestBodyType(string value) => new(value);

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
