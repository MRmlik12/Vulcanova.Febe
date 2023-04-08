using Vulcanova.Uonet.Api.Common.Models;

namespace Vulcanova.Febe;

public static class Data
{
    public static class Subjects
    {
        public static Subject It = new()
        {
            Id = 1,
            Key = Guid.Parse("fb0ea14e-1570-49fc-aa2c-a470fe6a8fff"),
            Kod = "informatyka",
            Name = "Informatyka",
            Position = 1
        };
        
        public static Subject Literature = new()
        {
            Id = 2,
            Key = Guid.Parse("afff547e-8411-4268-a61d-73f2e490e169"),
            Kod = "j. polski",
            Name = "Język polski",
            Position = 2
        };
    }

    public static class Teachers
    {
        public static Teacher Tutor = new()
        {
            DisplayName = "Tomasz Problem",
            Id = 1,
            Name = "Tomasz",
            Surname = "Problem"
        };

        public static Teacher Literature = new()
        {
            DisplayName = "Izabela Łęcka",
            Id = 2,
            Name = "Izabela",
            Surname = "Łęcka"
        };
    }

    public static class Common
    {
        public static readonly ClassUnit Class = new()
        {
            DisplayName = "4XD",
            Id = 1,
            Key = "0a3aaa7d-d697-4c43-82ed-cc10936aa448",
            Symbol = "XD"
        };
    }
}