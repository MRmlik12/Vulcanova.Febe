using Vulcanova.Uonet.Api;

namespace Vulcanova.Febe;

public static class ApiResponseFactory
{
    public static ApiResponse<TEnvelope> Ok<TEnvelope>(TEnvelope envelope, string envelopeType)
    {
        var now = DateTimeOffset.UtcNow;

        return new ApiResponse<TEnvelope>
        {
            Envelope = envelope,
            EnvelopeType = envelopeType,
            InResponseTo = null,
            RequestId = Guid.NewGuid().ToString(),
            Status = new Status
            {
                Code = 0,
                Message = "OK"
            },
            Timestamp = now.ToUnixTimeMilliseconds(),
            TimestampFormatted = now.ToString("yyyy-M-d HH:mm:ss")
        };
    }

    public const string EnvelopeTypeIEnumerable = "IEnumerable`1";
}