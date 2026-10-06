using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<UpdateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType>)
)]
[Serializable]
public readonly record struct UpdateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType
    : IStringEnum
{
    public static readonly UpdateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType Unknown =
        new(Values.Unknown);

    public static readonly UpdateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType VmrsCode =
        new(Values.VmrsCode);

    public static readonly UpdateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType ServiceTask =
        new(Values.ServiceTask);

    public UpdateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType(string value)
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
    public static UpdateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType FromCustom(
        string value
    )
    {
        return new UpdateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType(value);
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
        UpdateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        UpdateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        UpdateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType value
    ) => value.Value;

    public static explicit operator UpdateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType(
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
