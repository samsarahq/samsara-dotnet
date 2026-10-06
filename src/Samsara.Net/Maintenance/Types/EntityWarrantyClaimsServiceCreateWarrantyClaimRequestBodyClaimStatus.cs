using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Maintenance;

[JsonConverter(
    typeof(StringEnumSerializer<EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus>)
)]
[Serializable]
public readonly record struct EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus
    : IStringEnum
{
    public static readonly EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus Unknown =
        new(Values.Unknown);

    public static readonly EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus Created =
        new(Values.Created);

    public static readonly EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus Submitted =
        new(Values.Submitted);

    public static readonly EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus InReview =
        new(Values.InReview);

    public static readonly EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus Approved =
        new(Values.Approved);

    public static readonly EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus Rejected =
        new(Values.Rejected);

    public static readonly EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus Resubmitted =
        new(Values.Resubmitted);

    public static readonly EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus Reimbursed =
        new(Values.Reimbursed);

    public EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus(string value)
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
    public static EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus FromCustom(
        string value
    )
    {
        return new EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus(value);
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
        EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus value1,
        string value2
    ) => value1.Value.Equals(value2);

    public static bool operator !=(
        EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus value1,
        string value2
    ) => !value1.Value.Equals(value2);

    public static explicit operator string(
        EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus value
    ) => value.Value;

    public static explicit operator EntityWarrantyClaimsServiceCreateWarrantyClaimRequestBodyClaimStatus(
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
