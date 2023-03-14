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
                Creator = new Teacher
                {
                    DisplayName = "Tomasz Problem",
                    Id = 1,
                    Name = "Tomasz",
                    Surname = "Problem"
                },
                DateCreated = DateTimeInfo.FromDateTime(new DateTime(2021, 9, 3)),
                DateModify = DateTimeInfo.FromDateTime(new DateTime(2021, 9, 3)),
                Deadline = DateTimeInfo.FromDateTime(new DateTime(2021, 10, 3)),
                Id = 1,
                Key = "c28e65d7-92fa-43eb-9b11-da3ba3333eb7",
                PupilId = 1,
                Subject = new Subject
                {
                    Id = 1,
                    Key = Guid.Parse("fb0ea14e-1570-49fc-aa2c-a470fe6a8fff"),
                    Kod = "informatyka",
                    Name = "Informatyka",
                    Position = 1
                },
                Type = "Sprawdzian"
            }
        }, ApiResponseFactory.EnvelopeTypeIEnumerable);
    }
}