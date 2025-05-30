namespace Samsara.Net.Core;

[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
internal class JsonAccessAttribute(JsonAccessType accessType) : global::System.Attribute
{
    internal JsonAccessType AccessType { get; init; } = accessType;
}

internal enum JsonAccessType
{
    ReadOnly,
    WriteOnly,
}
