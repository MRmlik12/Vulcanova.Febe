using Microsoft.AspNetCore.Mvc;
using Vulcanova.Uonet.Api;
using Vulcanova.Uonet.Api.MessageBox;

namespace Vulcanova.Febe.Controllers.UnitApi;

[Route("febe/05LO/api/messagebox/addressbook")]
public class AddressbookController : Controller
{
    [HttpGet]
    public ApiResponse<AddressBookEntry[]> GetAddressbook([FromQuery] GetMessageBoxAddressBookQuery query)
    {
        return ApiResponseFactory.Ok(new[]
        {
            new AddressBookEntry
            {
                Name = "Problem Tomasz - P - (05LO)",
                GlobalKey = Guid.Parse("12697a6a-992c-4df7-9b4a-2add66b37947"),
                Group = "P"
            }
        }, ApiResponseFactory.EnvelopeTypeIEnumerable);
    }
}