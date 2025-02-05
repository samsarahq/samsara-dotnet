using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net;

public record V1VisionStepResultsItem
{
    [JsonPropertyName("angleCheck")]
    public V1VisionStepResultsItemAngleCheck? AngleCheck { get; set; }

    [JsonPropertyName("barcode")]
    public IEnumerable<V1VisionStepResultsItemBarcodeItem>? Barcode { get; set; }

    [JsonPropertyName("booleanLogic")]
    public V1VisionStepResultsItemBooleanLogic? BooleanLogic { get; set; }

    [JsonPropertyName("caliper")]
    public V1VisionStepResultsItemCaliper? Caliper { get; set; }

    [JsonPropertyName("contour")]
    public V1VisionStepResultsItemContour? Contour { get; set; }

    [JsonPropertyName("distance")]
    public V1VisionStepResultsItemDistance? Distance { get; set; }

    [JsonPropertyName("expirationDate")]
    public V1VisionStepResultsItemExpirationDate? ExpirationDate { get; set; }

    [JsonPropertyName("findCopies")]
    public V1VisionStepResultsItemFindCopies? FindCopies { get; set; }

    [JsonPropertyName("findEdge")]
    public V1VisionStepResultsItemFindEdge? FindEdge { get; set; }

    [JsonPropertyName("findShapes")]
    public V1VisionStepResultsItemFindShapes? FindShapes { get; set; }

    [JsonPropertyName("fixture")]
    public V1VisionStepResultsItemFixture? Fixture { get; set; }

    [JsonPropertyName("labelMatch")]
    public V1VisionStepResultsItemLabelMatch? LabelMatch { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("presenceAbsence")]
    public V1VisionStepResultsItemPresenceAbsence? PresenceAbsence { get; set; }

    [JsonPropertyName("result")]
    public string? Result { get; set; }

    [JsonPropertyName("textMatch")]
    public V1VisionStepResultsItemTextMatch? TextMatch { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
