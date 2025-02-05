using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1DocumentConditionalFieldsItem
{
    /// <summary>
    /// Start index of the conditional fields set
    /// </summary>
    [JsonPropertyName("conditionalFieldIndexFirst")]
    public double? ConditionalFieldIndexFirst { get; set; }

    /// <summary>
    /// End index of the conditional fields set
    /// </summary>
    [JsonPropertyName("conditionalFieldIndexLast")]
    public double? ConditionalFieldIndexLast { get; set; }

    /// <summary>
    /// Index of the multiple choice field that triggers the conditional fields
    /// </summary>
    [JsonPropertyName("triggeringFieldIndex")]
    public double? TriggeringFieldIndex { get; set; }

    /// <summary>
    /// Multiple choice value that triggers the conditional fields
    /// </summary>
    [JsonPropertyName("triggeringFieldValue")]
    public string? TriggeringFieldValue { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
