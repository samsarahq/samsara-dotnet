using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<UpdateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType>)
)]
[Serializable]
public readonly record struct UpdateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType
    : IStringEnum
{
    public static readonly UpdateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType Unknown =
        new(Values.Unknown);

    public static readonly UpdateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType VmrsCode =
        new(Values.VmrsCode);

    public static readonly UpdateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType ServiceTask =
        new(Values.ServiceTask);

    public UpdateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType(
        string value
    )
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
    public static UpdateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType FromCustom(
        string value
    )
    {
        return new UpdateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType(
            value
        );
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
        UpdateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType value
    ) => value.Value;

    public static explicit operator UpdateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string VmrsCode = "vmrsCode";

        public const string ServiceTask = "serviceTask";
    }
}
