using Microsoft.AspNetCore.Mvc;
using Vulcanova.Uonet.Api;
using Vulcanova.Uonet.Api.Common.Models;
using Vulcanova.Uonet.Api.Schedule;

namespace Vulcanova.Febe.Controllers.UnitApi;

[Route("febe/05LO/api/mobile/schedule/changes")]
public class ScheduleChangesController
{
    [HttpGet("byPupil")]
    public ApiResponse<ScheduleChangeEntryPayload[]> GetScheduleChangesEntriesByPupil()
    {
        return ApiResponseFactory.Ok(
            new[]
            {
                new ScheduleChangeEntryPayload
                {
                    Change = new Change
                    {
                        Id = 1,
                        IsMerge = false,
                        Separation = false,
                        Type = ChangeType.Exemption
                    },
                    ChangeDate = null,
                    Clazz = Data.Common.Class,
                    Distribution = null,
                    Event = null,
                    Id = 1,
                    LessonDate = DateTimeInfo.FromDateTime(new DateTime(2023, 9, 16, 1,1,1)),
                    Note = null,
                    Reason = null,
                    Room = null,
                    ScheduleId = 1,
                    Subject = null,
                    TeacherPrimary = null,
                    TeacherSecondary = null,
                    TimeSlot = null,
                    UnitId = 1
                },
                new ScheduleChangeEntryPayload
                {
                    Change = new Change
                    {
                        Id = 1,
                        IsMerge = false,
                        Separation = false,
                        Type = ChangeType.Substitution
                    },
                    ChangeDate = null,
                    Clazz = Data.Common.Class,
                    Distribution = null,
                    Event = null,
                    Id = 2,
                    LessonDate = DateTimeInfo.FromDateTime(new DateTime(2023, 9, 16, 1,1,1)),
                    Note = null,
                    Reason = null,
                    Room = null,
                    ScheduleId = 2,
                    Subject = Data.Subjects.Literature,
                    TeacherPrimary = Data.Teachers.Literature,
                    TeacherSecondary = null,
                    TimeSlot = null,
                    UnitId = 1
                }
            }, ApiResponseFactory.EnvelopeTypeIEnumerable);
    }
}