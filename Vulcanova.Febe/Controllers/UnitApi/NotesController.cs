using Microsoft.AspNetCore.Mvc;
using Vulcanova.Uonet.Api;
using Vulcanova.Uonet.Api.Common.Models;
using Vulcanova.Uonet.Api.Notes;

namespace Vulcanova.Febe.Controllers.UnitApi;

[Route("febe/05LO/api/mobile/note")]
public class NotesController
{
    [HttpGet("byPupil")]
    public ApiResponse<NotesPayload[]> GetNotesByPupil([FromQuery] GetNotesByPupilQuery query)
    {
        return ApiResponseFactory.Ok(new[]
        {
            new NotesPayload
            {
                Category = new Category
                {
                    DefaultPoints = null,
                    Id = 1,
                    Name = "Reprezentowanie szkoły",
                    Type = null
                },
                Content = "Reprezentowanie szkoły w COBOLowym hackathonie",
                Creator = Data.Teachers.Tutor,
                DateModify = DateTimeInfo.FromDateTime(new DateTime(2021, 9, 7)),
                DateValid = DateTimeInfo.FromDateTime(new DateTime(2021, 9, 7)),
                Id = 1,
                IdPupil = 1,
                Key = Guid.Parse("7ff5ad18-5e09-48ce-9703-3c179d479988"),
                Points = null,
                Positive = false
            }
        }, ApiResponseFactory.EnvelopeTypeIEnumerable);
    }
}