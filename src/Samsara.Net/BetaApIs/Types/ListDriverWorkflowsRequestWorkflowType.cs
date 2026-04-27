using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.BetaApIs;

[JsonConverter(typeof(StringEnumSerializer<ListDriverWorkflowsRequestWorkflowType>))]
[Serializable]
public readonly record struct ListDriverWorkflowsRequestWorkflowType : IStringEnum
{
    public static readonly ListDriverWorkflowsRequestWorkflowType StartOfDay = new(
        Values.StartOfDay
    );

    public static readonly ListDriverWorkflowsRequestWorkflowType EndOfDay = new(Values.EndOfDay);

    public static readonly ListDriverWorkflowsRequestWorkflowType AssetSelection = new(
        Values.AssetSelection
    );

    public static readonly ListDriverWorkflowsRequestWorkflowType LeaveAsset = new(
        Values.LeaveAsset
    );

    public static readonly ListDriverWorkflowsRequestWorkflowType RidershipSafetyCheck = new(
        Values.RidershipSafetyCheck
    );

    public static readonly ListDriverWorkflowsRequestWorkflowType StopArrival = new(
        Values.StopArrival
    );

    public ListDriverWorkflowsRequestWorkflowType(string value)
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
    public static ListDriverWorkflowsRequestWorkflowType FromCustom(string value)
    {
        return new ListDriverWorkflowsRequestWorkflowType(value);
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

    public static bool operator ==(ListDriverWorkflowsRequestWorkflowType value1, string value2) =>
        value1.Value.Equals(value2);

    public static bool operator !=(ListDriverWorkflowsRequestWorkflowType value1, string value2) =>
        !value1.Value.Equals(value2);

    public static explicit operator string(ListDriverWorkflowsRequestWorkflowType value) =>
        value.Value;

    public static explicit operator ListDriverWorkflowsRequestWorkflowType(string value) =>
        new(value);

    /// <summary>
    /// Constant strings for enum values
    /// </summary>
    [Serializable]
    public static class Values
    {
        public const string StartOfDay = "startOfDay";

        public const string EndOfDay = "endOfDay";

        public const string AssetSelection = "assetSelection";

        public const string LeaveAsset = "leaveAsset";

        public const string RidershipSafetyCheck = "ridershipSafetyCheck";

        public const string StopArrival = "stopArrival";
    }
}
