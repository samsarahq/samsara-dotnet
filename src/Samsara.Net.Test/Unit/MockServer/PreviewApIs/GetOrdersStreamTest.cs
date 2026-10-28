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
                  "createdAtTime": "1990-08-31T23:49:19.000Z",
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
                      "createdAtTime": "1977-01-10T23:36:08.000Z",
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
                          "value": 0.23962707185822993
                        }
                      ],
                      "routeId": "12345678",
                      "serviceDurationSeconds": 1920015009061035500,
                      "serviceWindows": [
                        {
                          "endTime": "1975-07-07T21:36:20.000Z",
                          "id": "018f7b62-7d55-7b9e-a92f-2a6b7ff10392",
                          "startTime": "1975-02-20T04:43:33.000Z"
                        }
                      ],
                      "taskType": "unknown",
                      "updatedAtTime": "2014-02-20T05:13:14.000Z"
                    }
                  ],
                  "updatedAtTime": "2003-10-18T15:58:15.000Z"
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
