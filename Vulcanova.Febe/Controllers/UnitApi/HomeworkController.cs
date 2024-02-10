using Microsoft.AspNetCore.Mvc;
using Vulcanova.Uonet.Api;
using Vulcanova.Uonet.Api.Common.Models;
using Vulcanova.Uonet.Api.Homework;

namespace Vulcanova.Febe.Controllers.UnitApi;

[Route("febe/05LO/api/mobile/homework")]
public class HomeworkController
{
    [HttpGet("byPupil")]
    public ApiResponse<HomeworkPayload[]> GetHomeworkByPupil([FromQuery] GetHomeworkByPupilQuery query)
    {
        return ApiResponseFactory.Ok(new[]
        {
            new HomeworkPayload
            {
                AnswerDate = null,
                AnswerDeadline = DateTimeInfo.FromDateTime(new DateTime(2023, 7, 9, 1, 1, 1)),
                Attachments = new List<Attachment>
                    { new() { Link = "https://vulcanova.github.io/", Name = "Materiały.pdf" } },
                Content = "Lalka — rozprawka",
                Creator = Data.Teachers.Literature,
                Date = DateTimeInfo.FromDateTime(new DateTime(2023, 7, 9, 1, 1, 1)),
                DateCreated = DateTimeInfo.FromDateTime(new DateTime(2023, 7, 9, 1, 1, 1)),
                Deadline = DateTimeInfo.FromDateTime(new DateTime(2023, 7, 9, 1, 1, 1)),
                Id = 1,
                IdHomework = 1,
                IdPupil = 1,
                IsAnswerRequired = false,
                Key = Guid.Parse("23774dbf-e8c2-4a8d-9388-87f92f873aaa"),
                Subject = Data.Subjects.Literature
            }
        }, ApiResponseFactory.EnvelopeTypeIEnumerable);
    }
}