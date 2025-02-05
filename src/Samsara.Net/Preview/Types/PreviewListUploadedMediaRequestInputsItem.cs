using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.Preview;

[JsonConverter(typeof(EnumSerializer<PreviewListUploadedMediaRequestInputsItem>))]
public enum PreviewListUploadedMediaRequestInputsItem
{
    [EnumMember(Value = "dashcamRoadFacing")]
    DashcamRoadFacing,

    [EnumMember(Value = "dashcamDriverFacing")]
    DashcamDriverFacing,

    [EnumMember(Value = "analog")]
    Analog,
}
