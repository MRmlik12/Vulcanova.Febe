using Microsoft.AspNetCore.Mvc;
using Vulcanova.Uonet.Api;
using Vulcanova.Uonet.Api.Auth;

namespace Vulcanova.Febe.Controllers;

[Route("febe/api/mobile/register")]
public class RegistrationController : Controller
{
    [HttpPost("new")]
    public ApiResponse<RegisterClientResponse> RegisterClient()
    {
        return ApiResponseFactory.Ok(
            new RegisterClientResponse
            {
                LoginId = 1234,
                RestURL = $"https://{Request.Host}/febe/",
                UserLogin = "jan.kowalski@example.com",
                UserName = "jan.kowalski@example.com"
            }, "AccountPayload");
    }

    [HttpGet("hebe")]
    [HttpGet("/febe/05LO/api/mobile/register/hebe")]
    public ApiResponse<AccountPayload[]> RegisterHebe()
    {
        return ApiResponseFactory.Ok(
            new []
            {
                new AccountPayload
                {
                    Capabilities = new [] {
                        AccountCapabilities.AddressBookPupil,
                        AccountCapabilities.Meetings,
                        AccountCapabilities.Regular,
                        AccountCapabilities.GradesAverageEnabled
                    },
                    ClassDisplay = "4XD",
                    ConstituentUnit = new ConstituentUnit
                    {
                        Address = "ul. Vulcanova 2, 00-000 Vulcanovo",
                        Id = 1,
                        Name = "V Liceum Ogólnokształcące",
                        Patron = "Aplikacja Vulcanova",
                        SchoolTopic = Guid.NewGuid(),
                        Short = "05LO"
                    },
                    Constraints = new Constraints
                    {
                        AbsenceDaysBefore = null,
                        AbsenceHoursBefore = null
                    },
                    Context = "TBD",
                    Educators = new []
                    {
                        new Educator
                        {
                            Id = "e-2137",
                            Initials = "TP",
                            LoginId = 2,
                            Name = "Tomasz",
                            Roles = new []
                            {
                                new Role
                                {
                                    Address = "Tomasz Problem [TP] - wychowawca 4XD (05LO)",
                                    AddressHash = "b474e57096fe977edb8de3ff5338955d840a02e0",
                                    ClassSymbol = "4XD (05LO)",
                                    ConstituentUnitSymbol = "05LO",
                                    Initials = "TP",
                                    Name = "Tomasz",
                                    RoleName = "Wychowawca",
                                    RoleOrder = 0,
                                    Surname = "Problem",
                                    UnitSymbol = null
                                }
                            }
                        }
                    },
                    FullSync = false,
                    InfoDisplay = "05LO – 4XD",
                    Journal = new Journal
                    {
                        Id = 1,
                        YearEnd = new YearEnd
                        {
                            DateDisplay = "31.08.2022",
                            Timestamp = 1661896800000
                        },
                        YearStart = new YearEnd
                        {
                            DateDisplay = "2021-09-01",
                            Timestamp = 1630447200000
                        },
                        PupilNumber = 33
                    },
                    Login = new Login
                    {
                        DisplayName = "Jan Kowalski",
                        FirstName = "Jan",
                        Id = 1234,
                        LoginRole = "Uczen",
                        SecondName = "",
                        Surname = "Kowalski",
                        Value = "jan.kowalski@example.com"
                    },
                    Partition = "febe-05LO",
                    Periods = new []
                    {
                        new Period 
                        {
                            Capabilities = Array.Empty<object>(),
                            Current = true,
                            End = new YearEnd 
                            {
                                DateDisplay = "23.01.2022",
                                Timestamp = 1642892400000
                            },
                            Id = 1,
                            Last = false,
                            Level = 4,
                            Number = 1,
                            Start = new YearEnd 
                            {
                                DateDisplay = "01.09.2021",
                                Timestamp = 1630447200000
                            }
                        },
                        new Period 
                        {
                            Capabilities = Array.Empty<object>(),
                            Current = false,
                            End = new YearEnd 
                            {
                                DateDisplay = "31.08.2022",
                                Timestamp = 1661896800000
                            },
                            Id = 2,
                            Last = true,
                            Level = 4,
                            Number = 2,
                            Start = new YearEnd 
                            {
                                DateDisplay = "24.01.2022",
                                Timestamp = 1642978800000
                            }
                        },
                        new Period 
                        {
                            Capabilities = Array.Empty<object>(),
                            Current = true,
                            End = new YearEnd 
                            {
                                DateDisplay = "23.01.2022",
                                Timestamp = 1642892400000
                            },
                            Id = 1,
                            Last = false,
                            Level = 4,
                            Number = 1,
                            Start = new YearEnd 
                            {
                                DateDisplay = "01.09.2021",
                                Timestamp = 1630447200000
                            }
                        },
                        new Period 
                        {
                            Capabilities = Array.Empty<object>(),
                            Current = false,
                            End = new YearEnd 
                            {
                                DateDisplay = "31.08.2022",
                                Timestamp = 1661896800000
                            },
                            Id = 2,
                            Last = true,
                            Level = 4,
                            Number = 2,
                            Start = new YearEnd 
                            {
                                DateDisplay = "24.01.2022",
                                Timestamp = 1642978800000
                            }
                        }
                    },
                    Policies = new Policies
                    {
                        AccessDeclaration = null,
                        Cookie = null,
                        InfoEnclosure = null,
                        Privacy = null
                    },
                    Pupil = new Pupil
                    {
                        FirstName = "Jan",
                        Id = 1,
                        LoginId = 1234,
                        LoginValue = "jan.kowalski@example.com",
                        SecondName = "",
                        Sex = true,
                        Surname = "Kowalski"
                    },
                    SenderEntry = new SenderEntry
                    {
                        Address = "Kowalski Jan  - uczeń 4XD (05LO)",
                        AddressHash = "bac078ae39750c0cb888f602da03bbcec88880ae",
                        Initials = "RP",
                        LoginId = 1234
                    },
                    State = 0,
                    TopLevelPartition = "febe",
                    Unit = new Unit
                    {
                        Address = "ul. Vulcanova 2, 00-000 Vulcanovo",
                        DisplayName = "V Liceum Ogólnokształcące",
                        Id = 1,
                        Name = "V Liceum Ogólnokształcące",
                        Patron = "Aplikacja Vulcanova",
                        RestUrl = new Uri($"https://{Request.Host}/febe/05LO/api"),
                        SchoolTopic = Guid.NewGuid(),
                        Short = "05LO",
                        Symbol = "05LO"
                    }
                }
            }, ApiResponseFactory.EnvelopeTypeIEnumerable);
    }
}