using NUnit.Framework;
using Samsara.Net.BetaApis;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.BetaApis;

[TestFixture]
public class GetAssetsInputsTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "asset": {
                    "attributes": [
                      {
                        "dateValues": [
                          "dateValues",
                          "dateValues"
                        ],
                        "id": "id",
                        "name": "name",
                        "numberValues": [
                          1.1,
                          1.1
                        ],
                        "stringValues": [
                          "stringValues",
                          "stringValues"
                        ]
                      },
                      {
                        "dateValues": [
                          "dateValues",
                          "dateValues"
                        ],
                        "id": "id",
                        "name": "name",
                        "numberValues": [
                          1.1,
                          1.1
                        ],
                        "stringValues": [
                          "stringValues",
                          "stringValues"
                        ]
                      }
                    ],
                    "externalIds": {
                      "externalIds": "externalIds"
                    },
                    "id": "id",
                    "tags": [
                      {
                        "id": "id",
                        "name": "name",
                        "parentTagId": "parentTagId"
                      },
                      {
                        "id": "id",
                        "name": "name",
                        "parentTagId": "parentTagId"
                      }
                    ]
                  },
                  "auxInput": {
                    "name": "name"
                  },
                  "happenedAtTime": "happenedAtTime",
                  "units": "boolean",
                  "value": "value"
                },
                {
                  "asset": {
                    "attributes": [
                      {
                        "dateValues": [
                          "dateValues",
                          "dateValues"
                        ],
                        "id": "id",
                        "name": "name",
                        "numberValues": [
                          1.1,
                          1.1
                        ],
                        "stringValues": [
                          "stringValues",
                          "stringValues"
                        ]
                      },
                      {
                        "dateValues": [
                          "dateValues",
                          "dateValues"
                        ],
                        "id": "id",
                        "name": "name",
                        "numberValues": [
                          1.1,
                          1.1
                        ],
                        "stringValues": [
                          "stringValues",
                          "stringValues"
                        ]
                      }
                    ],
                    "externalIds": {
                      "externalIds": "externalIds"
                    },
                    "id": "id",
                    "tags": [
                      {
                        "id": "id",
                        "name": "name",
                        "parentTagId": "parentTagId"
                      },
                      {
                        "id": "id",
                        "name": "name",
                        "parentTagId": "parentTagId"
                      }
                    ]
                  },
                  "auxInput": {
                    "name": "name"
                  },
                  "happenedAtTime": "happenedAtTime",
                  "units": "boolean",
                  "value": "value"
                }
              ],
              "pagination": {
                "endCursor": "endCursor",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/assets/inputs/stream")
                    .WithParam("type", "auxInput1")
                    .WithParam("startTime", "startTime")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.BetaApis.GetAssetsInputsAsync(
            new GetAssetsInputsRequest
            {
                Type = GetAssetsInputsRequestType.AuxInput1,
                StartTime = "startTime",
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
