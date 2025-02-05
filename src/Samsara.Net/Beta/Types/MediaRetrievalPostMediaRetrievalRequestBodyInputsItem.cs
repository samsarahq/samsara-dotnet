using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Beta;

[JsonConverter(typeof(EnumSerializer<MediaRetrievalPostMediaRetrievalRequestBodyInputsItem>))]
public enum MediaRetrievalPostMediaRetrievalRequestBodyInputsItem
{
    [EnumMember(Value = "dashcamRoadFacing")]
    DashcamRoadFacing,

    [EnumMember(Value = "dashcamDriverFacing")]
    DashcamDriverFacing,

    [EnumMember(Value = "analog")]
    Analog,
}
