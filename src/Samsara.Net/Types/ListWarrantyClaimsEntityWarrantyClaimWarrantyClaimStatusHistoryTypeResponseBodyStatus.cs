using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(
    typeof(StringEnumSerializer<ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus>)
)]
[Serializable]
public readonly record struct ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus
    : IStringEnum
{
    public static readonly ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Unknown =
        new(Values.Unknown);

    public static readonly ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Created =
        new(Values.Created);

    public static readonly ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Submitted =
        new(Values.Submitted);

    public static readonly ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus InReview =
        new(Values.InReview);

    public static readonly ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Approved =
        new(Values.Approved);

    public static readonly ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Rejected =
        new(Values.Rejected);

    public static readonly ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Resubmitted =
        new(Values.Resubmitted);

    public static readonly ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus Reimbursed =
        new(Values.Reimbursed);

    public ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus(
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
    public static ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus FromCustom(
        string value
    )
    {
        return new ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus(
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
        ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus value
    ) => value.Value;

    public static explicit operator ListWarrantyClaimsEntityWarrantyClaimWarrantyClaimStatusHistoryTypeResponseBodyStatus(
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
