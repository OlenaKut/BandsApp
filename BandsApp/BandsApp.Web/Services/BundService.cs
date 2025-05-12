using BandsApp.Web.Models;

namespace BandsApp.Web.Services
{
    public class BundService
    {
        List<Band> bands = [
            new Band { Id = 1, Name = "Beatles", Description = "Pop and rock bands" },
            new Band { Id = 2, Name = "Depeche Mode", Description = "English electronic band" },
            new Band { Id = 3, Name = "ABBA", Description = "Swedish pop group" },
            ];
    }
}
