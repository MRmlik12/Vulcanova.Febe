using Microsoft.AspNetCore.Mvc;
using Vulcanova.Uonet.Api;
using Vulcanova.Uonet.Api.Common.Models;
using Vulcanova.Uonet.Api.MessageBox;

namespace Vulcanova.Febe.Controllers.UnitApi;

[Route("febe/05LO/api/mobile/messagebox/message")]
public class MessageController : Controller
{
    [HttpGet("byBox")]
    public ApiResponse<MessagePayload[]> GetMessagesByBox([FromQuery] GetMessagesByMessageBoxQuery query)
    {
        return ApiResponseFactory.Ok(new []
        {
            new MessagePayload
            {
                Attachments = new List<Attachment>(),
                Content = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Phasellus luctus eget mauris quis imperdiet. Sed sed ex felis. Proin suscipit erat non nisi maximus pretium. Praesent in enim in augue iaculis fringilla tempor nec nunc. Mauris erat sem, posuere eget tellus vitae, elementum faucibus nisi. Pellentesque pharetra porttitor sapien. Suspendisse iaculis lectus tellus, sed eleifend dolor euismod id. Curabitur scelerisque, augue a venenatis commodo, lectus leo vulputate sapien, vitae posuere turpis metus at mauris. Nullam faucibus eros leo, id cursus orci gravida sed. Donec et odio vitae sapien porttitor aliquam quis id ipsum. In egestas, nisl at dignissim sollicitudin, odio leo vehicula tellus, a tempor metus elit volutpat augue. ",
                DateRead = DateTimeInfo.FromDateTime(DateTime.UnixEpoch),
                DateSent = DateTimeInfo.FromDateTime(DateTime.UnixEpoch),
                GlobalKey = Guid.Parse("e6268239-d86f-4b05-8ecb-c1d8adc69092"),
                Id = Guid.Parse("45393c7f-5a3b-4d99-9356-6902c2a3bd0a"),
                Importance = 0,
                Receiver = new List<Correspondent>
                {
                    new()
                    {
                        Extras = null,
                        GlobalKey = Guid.Parse("ff282773-d4d5-420b-96bc-6010d8eae968"),
                        HasRead = null,
                        Name = "Kowalski Jan - U - (05LO)"
                    }
                },
                Sender = new Correspondent
                {
                    Extras = null,
                    GlobalKey = Guid.Parse("3a0ddb11-583a-4330-9f16-4a9dc9df7b1f"),
                    HasRead = null,
                    Name = "System"
                },
                Status = 1,
                Subject = "Lorem ipsum",
                ThreadKey = Guid.Parse("e6268239-d86f-4b05-8ecb-c1d8adc69092")
            }
        }, ApiResponseFactory.EnvelopeTypeIEnumerable);
    }
}