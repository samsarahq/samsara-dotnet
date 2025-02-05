using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Samsara.Net.Core;

namespace Samsara.Net.PreviewApIs;

[JsonConverter(typeof(EnumSerializer<PreviewApIsListUploadedMediaRequestInputsItem>))]
public enum PreviewApIsListUploadedMediaRequestInputsItem
{
    [EnumMember(Value = "dashcamRoadFacing")]
    DashcamRoadFacing,

    [EnumMember(Value = "dashcamDriverFacing")]
    DashcamDriverFacing,

    [EnumMember(Value = "analog")]
    Analog,
}
