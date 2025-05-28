using Samsara.Net.Core;
using Samsara.Net.Ifta.Csv;

namespace Samsara.Net.Ifta;

public partial class IftaClient
{
    private RawClient _client;

    internal IftaClient(RawClient client)
    {
        _client = client;
        Csv = new CsvClient(_client);
    }

    public CsvClient Csv { get; }
}
