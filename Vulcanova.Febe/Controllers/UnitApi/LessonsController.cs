using Microsoft.AspNetCore.Mvc;
using Vulcanova.Uonet.Api;
using Vulcanova.Uonet.Api.Lessons;

namespace Vulcanova.Febe.Controllers.UnitApi;

[Route("febe/05LO/api/mobile/lesson")]
public class LessonsController
{
    [HttpGet("byPupil")]
    public ApiResponse<LessonPayload[]> GetLessonsByPupil([FromQuery] GetLessonsByPupilQuery query)
    {
        return ApiResponseFactory.Ok(Array.Empty<LessonPayload>(),
            ApiResponseFactory.EnvelopeTypeIEnumerable);
    }
}