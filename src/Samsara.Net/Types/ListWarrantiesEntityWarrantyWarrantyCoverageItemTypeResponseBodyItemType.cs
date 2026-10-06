using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<ListWarrantiesEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType>)
)]
[Serializable]
public readonly record struct ListWarrantiesEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType
    : IStringEnum
{
    public static readonly ListWarrantiesEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType Unknown =
        new(Values.Unknown);

    public static readonly ListWarrantiesEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType VmrsCode =
        new(Values.VmrsCode);

    public static readonly ListWarrantiesEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType ServiceTask =
        new(Values.ServiceTask);

    public ListWarrantiesEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType(string value)
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
    public static ListWarrantiesEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType FromCustom(
        string value
    )
    {
        return new ListWarrantiesEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType(value);
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
        ListWarrantiesEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListWarrantiesEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListWarrantiesEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType value
    ) => value.Value;

    public static explicit operator ListWarrantiesEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType(
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
