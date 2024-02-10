using System.Xml;
using Microsoft.AspNetCore.Mvc;
using Vulcanova.Uonet.Api;
using Vulcanova.Uonet.Api.Common.Models;
using Vulcanova.Uonet.Api.Schedule;

namespace Vulcanova.Febe.Controllers.UnitApi;

[Route("febe/05LO/api/mobile/schedule")]
public class ScheduleController
{
    [HttpGet("byPupil")]
    public ApiResponse<ScheduleEntryPayload[]> GetScheduleEntriesByPupil(
        [FromQuery] GetScheduleEntriesByPupilQuery query)
    {
        var dt = new DateTime(2023, 9, 16, 1,1,1);

        return ApiResponseFactory.Ok(
            Enumerable.Range(0, 700).SelectMany(p => Enumerable.Range(0, 7).Select(q => new ScheduleEntryPayload
            {
                Change = null,
                Clazz = new ClassUnit
                {
                    DisplayName = "4XD",
                    Id = 1,
                    Key = "0a3aaa7d-d697-4c43-82ed-cc10936aa448",
                    Symbol = "XD"
                },
                Date = DateTimeInfo.FromDateTime(dt.AddDays(p)),
                Distribution = null,
                Event = null,
                Id = p*10 + q,
                MergeChangeId = null,
                PupilAlias = null,
                Room = new Room
                {
                    Code = "33",
                    Id = 1
                },
                Subject = Data.Subjects.It,
                TeacherPrimary = Data.Teachers.Tutor,
                TeacherSecondary = null,
                TimeSlot = Data.Common.GetTimeSlot(q),
                Visible = true
            })).ToArray(), ApiResponseFactory.EnvelopeTypeIEnumerable);
    }
}