using NUnit.Framework;
using Samsara.Net;
using Samsara.Net.PreviewApIs;
using Samsara.Net.Test.Unit.MockServer;
using Samsara.Net.Test.Utils;

namespace Samsara.Net.Test.Unit.MockServer.PreviewApIs;

[TestFixture]
public class PostOrdersBatchTest : BaseMockServerTest
{
    [NUnit.Framework.Test]
    public async Task MockServerTest()
    {
        const string requestJson = """
            {
              "data": [
                {}
              ]
            }
            """;

        const string mockResponse = """
            {
              "requestId": "1f7f5081-9f8e-4b68-8b85-97dbe4b46d7e",
              "responses": [
                {
                  "data": {
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
                  },
                  "message": "data[0].tasks[0].taskType is invalid",
                  "status": 1792300152622576000
                }
              ]
            }
            """;

        Server
            .Given(
                WireMock
                    .RequestBuilders.Request.Create()
                    .WithPath("/preview/fleet/orders/batch")
                    .WithHeader("Content-Type", "application/json")
                    .UsingPost()
                    .WithBodyAsJson(requestJson)
            )
            .RespondWith(
                WireMock
                    .ResponseBuilders.Response.Create()
                    .WithStatusCode(200)
                    .WithBody(mockResponse)
            );

        var response = await Client.PreviewApIs.PostOrdersBatchAsync(
            new OrdersPostOrdersBatchRequestBody
            {
                Data = new List<FleetOrderBatchUpsertInputRequestBody>()
                {
                    new FleetOrderBatchUpsertInputRequestBody(),
                },
            }
        );
        JsonAssert.AreEqual(response, mockResponse);
    }
}
