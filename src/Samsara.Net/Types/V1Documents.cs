using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1Documents
{
    /// <summary>
    /// List of documents.
    /// </summary>
    [JsonPropertyName("driverDocuments")]
    public IEnumerable<V1Document>? DriverDocuments { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
