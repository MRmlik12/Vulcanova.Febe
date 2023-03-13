using Microsoft.AspNetCore.Mvc;
using Vulcanova.Uonet.Api;
using Vulcanova.Uonet.Api.MessageBox;

namespace Vulcanova.Febe.Controllers.UnitApi;

[Route("febe/05LO/api/mobile/messagebox")]
public class MessageBoxController : Controller
{
    [HttpGet]
    public ApiResponse<MessageBoxPayload[]> GetMessageBoxes()
    {
        return ApiResponseFactory.Ok(new []
        {
            new MessageBoxPayload
            {
                GlobalKey = Guid.Parse("ff282773-d4d5-420b-96bc-6010d8eae968"),
                Id = 1,
                Name = "Kowalski Jan - U - (05LO)"
            }
        }, ApiResponseFactory.EnvelopeTypeIEnumerable);
    }
}