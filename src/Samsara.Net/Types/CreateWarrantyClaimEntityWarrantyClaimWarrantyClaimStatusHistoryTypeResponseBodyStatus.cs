using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus>)
)]
[Serializable]
public readonly record struct CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus
    : IStringEnum
{
    public static readonly CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Unknown =
        new(Values.Unknown);

    public static readonly CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Created =
        new(Values.Created);

    public static readonly CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Submitted =
        new(Values.Submitted);

    public static readonly CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus InReview =
        new(Values.InReview);

    public static readonly CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Approved =
        new(Values.Approved);

    public static readonly CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Rejected =
        new(Values.Rejected);

    public static readonly CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Resubmitted =
        new(Values.Resubmitted);

    public static readonly CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Reimbursed =
        new(Values.Reimbursed);

    public CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus(
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
    public static CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus FromCustom(
        string value
    )
    {
        return new CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus(
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
        CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus value
    ) => value.Value;

    public static explicit operator CreateWarrantyClaimEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus(
        string value
    ) => new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string Unknown = "unknown";

        public const string Created = "created";

        public const string Submitted = "submitted";

        public const string InReview = "inReview";

        public const string Approved = "approved";

        public const string Rejected = "rejected";

        public const string Resubmitted = "resubmitted";

        public const string Reimbursed = "reimbursed";
    }
}
