using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

[JsonConverter(typeof(StringEnumSerializer<EntityCreateWarrantyClaimTypeResponseBodyClaimStatus>))]
[Serializable]
public readonly record struct EntityCreateWarrantyClaimTypeResponseBodyClaimStatus : IStringEnum
{
    public static readonly EntityCreateWarrantyClaimTypeResponseBodyClaimStatus Unknown = new(
        Values.Unknown
    );

    public static readonly EntityCreateWarrantyClaimTypeResponseBodyClaimStatus Created = new(
        Values.Created
    );

    public static readonly EntityCreateWarrantyClaimTypeResponseBodyClaimStatus Submitted = new(
        Values.Submitted
    );

    public static readonly EntityCreateWarrantyClaimTypeResponseBodyClaimStatus InReview = new(
        Values.InReview
    );

    public static readonly EntityCreateWarrantyClaimTypeResponseBodyClaimStatus Approved = new(
        Values.Approved
    );

    public static readonly EntityCreateWarrantyClaimTypeResponseBodyClaimStatus Rejected = new(
        Values.Rejected
    );

    public static readonly EntityCreateWarrantyClaimTypeResponseBodyClaimStatus Resubmitted = new(
        Values.Resubmitted
    );

    public static readonly EntityCreateWarrantyClaimTypeResponseBodyClaimStatus Reimbursed = new(
        Values.Reimbursed
    );

    public EntityCreateWarrantyClaimTypeResponseBodyClaimStatus(string value)
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
    public static EntityCreateWarrantyClaimTypeResponseBodyClaimStatus FromCustom(string value)
    {
        return new EntityCreateWarrantyClaimTypeResponseBodyClaimStatus(value);
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
        EntityCreateWarrantyClaimTypeResponseBodyClaimStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityCreateWarrantyClaimTypeResponseBodyClaimStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityCreateWarrantyClaimTypeResponseBodyClaimStatus value
    ) => value.Value;

    public static explicit operator EntityCreateWarrantyClaimTypeResponseBodyClaimStatus(
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
