using Microsoft.AspNetCore.Mvc;
using Vulcanova.Uonet.Api;
using Vulcanova.Uonet.Api.Common.Models;
using Vulcanova.Uonet.Api.Exams;

namespace Vulcanova.Febe.Controllers.UnitApi;

[Route("febe/05LO/api/mobile/exam")]
public class ExamController : Controller
{
    [HttpGet("byPupil")]
    public ApiResponse<ExamPayload[]> GetExamsByPupil(
        [FromQuery] int unitId,
        [FromQuery] int pupilId,
        [FromQuery] DateTime lastSyncDate,
        [FromQuery] int pageSize,
        [FromQuery] int lastId = int.MinValue)
    {
        return ApiResponseFactory.Ok(new[]
        {
            new ExamPayload
            {
                Content = "Pętle w COBOLu",
                Creator = Data.Teachers.Tutor,
                DateCreated = DateTimeInfo.FromDateTime(new DateTime(2021, 9, 3)),
                DateModify = DateTimeInfo.FromDateTime(new DateTime(2021, 9, 3)),
                Deadline = DateTimeInfo.FromDateTime(new DateTime(2021, 10, 3)),
                Id = 1,
                Key = "c28e65d7-92fa-43eb-9b11-da3ba3333eb7",
                PupilId = 1,
                Subject = Data.Subjects.It,
                Type = "Sprawdzian"
            }
        }, ApiResponseFactory.EnvelopeTypeIEnumerable);
    }
}