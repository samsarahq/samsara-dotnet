using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<CreateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType>)
)]
[Serializable]
public readonly record struct CreateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType
    : IStringEnum
{
    public static readonly CreateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType Unknown =
        new(Values.Unknown);

    public static readonly CreateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType VmrsCode =
        new(Values.VmrsCode);

    public static readonly CreateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType ServiceTask =
        new(Values.ServiceTask);

    public CreateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType(
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
    public static CreateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType FromCustom(
        string value
    )
    {
        return new CreateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType(
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
        CreateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType value
    ) => value.Value;

    public static explicit operator CreateWarrantyEntityWarrantyWarrantyCoverageItemInputTypeRequestBodyItemType(
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
