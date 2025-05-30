using Samsara.Net.Cameras.Media;
using Samsara.Net.Core;

namespace Samsara.Net.Cameras;

public partial class CamerasClient
{
    private RawClient _client;

    internal CamerasClient(RawClient client)
    {
        _client = client;
        Media = new MediaClient(_client);
    }

    public MediaClient Media { get; }
}
