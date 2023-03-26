using Microsoft.AspNetCore.Mvc;
using Vulcanova.Uonet.Api;
using Vulcanova.Uonet.Api.LuckyNumber;

namespace Vulcanova.Febe.Controllers.UnitApi;

[Route("febe/05LO/api/mobile/lucky")]
public class LuckyNumberController
{
    [HttpGet]
    public ApiResponse<LuckyNumberPayload> GetLuckyNumber([FromQuery] GetLuckyNumberQuery query)
    {
        return ApiResponseFactory.Ok(new LuckyNumberPayload
        {
            Day = query.Day,
            Number = 11
        }, nameof(LuckyNumberPayload));
    }
}