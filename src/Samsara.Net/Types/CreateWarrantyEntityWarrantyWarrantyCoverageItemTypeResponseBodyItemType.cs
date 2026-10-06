using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<CreateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType>)
)]
[Serializable]
public readonly record struct CreateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType
    : IStringEnum
{
    public static readonly CreateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType Unknown =
        new(Values.Unknown);

    public static readonly CreateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType VmrsCode =
        new(Values.VmrsCode);

    public static readonly CreateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType ServiceTask =
        new(Values.ServiceTask);

    public CreateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType(string value)
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
    public static CreateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType FromCustom(
        string value
    )
    {
        return new CreateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType(value);
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
        CreateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType value
    ) => value.Value;

    public static explicit operator CreateWarrantyEntityWarrantyWarrantyCoverageItemTypeResponseBodyItemType(
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
