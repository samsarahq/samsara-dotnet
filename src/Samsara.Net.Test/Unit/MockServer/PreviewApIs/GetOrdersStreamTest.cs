using System.Globalization;
using NUnit.Framework;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

[TestFixture]
public class GetOrdersStreamTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string mockResponse = """
            {
              "data": [
                {
                  "createdAtTime": "1983-09-13T11:27:33.000Z",
                  "customerProperties": [
                    {
                      "key": "purchaseOrderNumber",
                      "value": "PO-12345"
                    }
                  ],
                  "id": "018f7b62-7d55-7b9e-a92f-2a6b7ff10392",
                  "samsaraCustomerOrderName": "Order 12345",
                  "tasks": [
                    {
                      "createdAtTime": "1993-10-27T05:05:19.000Z",
                      "customerProperties": [
                        {
                          "key": "purchaseOrderNumber",
                          "value": "PO-12345"
                        }
                      ],
                      "dispatcherNotes": "Customer requires lift gate",
                      "driverNotes": "Use loading dock 4",
                      "hubId": "018f7b62-7d55-7b9e-a92f-2a6b7ff10392",
                      "id": "12345678",
                      "positionConstraintType": "unknown",
                      "quantities": [
                        {
                          "capacityId": "018f7b62-7d55-7b9e-a92f-2a6b7ff10392",
                          "id": "018f7b62-7d55-7b9e-a92f-2a6b7ff10392",
                          "label": "pallets",
                          "value": 0.8891437441477907
                        }
                      ],
                      "routeId": "12345678",
                      "serviceDurationSeconds": 2653587382275664400,
                      "serviceWindows": [
                        {
                          "endTime": "2003-04-07T16:38:08.000Z",
                          "id": "018f7b62-7d55-7b9e-a92f-2a6b7ff10392",
                          "startTime": "2005-03-11T20:28:08.000Z"
                        }
                      ],
                      "taskType": "unknown",
                      "updatedAtTime": "2006-02-24T15:47:24.000Z"
                    }
                  ],
                  "updatedAtTime": "1971-07-03T21:11:30.000Z"
                }
              ],
              "pagination": {
                "endCursor": "MjkY",
                "hasNextPage": true
              }
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/preview/fleet/orders/stream")
                    .WithParam("startTime", "2024-01-15T09:30:00.000Z")
                    .UsingGet()
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreviewApIs.GetOrdersStreamAsync(
            new GetOrdersStreamRequest
            {
                StartTime = DateTime.Parse(
                    "2024-01-15T09:30:00.000Z",
                    null,
                    DateTimeStyles.AdjustToUniversal
                ),
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
