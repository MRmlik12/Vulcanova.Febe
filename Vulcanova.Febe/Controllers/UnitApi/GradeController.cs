using Microsoft.AspNetCore.Mvc;
using Vulcanova.Uonet.Api;
using Vulcanova.Uonet.Api.Common.Models;
using Vulcanova.Uonet.Api.Grades;

namespace Vulcanova.Febe.Controllers.UnitApi;

[Route("febe/05LO/api/mobile/grade")]
public class GradeController
{
    [HttpGet("byPupil")]
    public ApiResponse<GradePayload[]> GetGradesByPupil(
        [FromQuery] int unitId,
        [FromQuery] int pupilId,
        [FromQuery] int periodId,
        [FromQuery] DateTime lastSyncDate,
        [FromQuery] int pageSize,
        [FromQuery] int lastId = int.MinValue)
    {
        return ApiResponseFactory.Ok(new[]
        {
            new GradePayload
            {
                Column = new Column
                {
                    Category = new Category
                    {
                        Code = "akt",
                        Id = 1,
                        Name = "Aktywność"
                    },
                    Code = "a",
                    Color = 0,
                    Group = "1",
                    Id = 1,
                    Key = Guid.Parse("5e4f59ce-8e77-4a22-a584-e76812089b5f"),
                    Name = "Aktywność",
                    Number = 1,
                    PeriodId = 1,
                    Subject = Data.Subjects.Literature,
                    Weight = 1.0m
                },
                Comment = "",
                Content = "6",
                ContentRaw = "6",
                Creator = Data.Teachers.Literature,
                DateCreated = DateTimeInfo.FromDateTime(new DateTime(2021, 9, 7)),
                DateModify = null,
                Denominator = null,
                Id = 1,
                Key = Guid.Parse("5141cbef-d5da-42a1-a7e4-a116e299c878"),
                Modifier = null,
                Numerator = null,
                PupilId = 1,
                Value = 6.0m
            }
        }, ApiResponseFactory.EnvelopeTypeIEnumerable);
    }
}