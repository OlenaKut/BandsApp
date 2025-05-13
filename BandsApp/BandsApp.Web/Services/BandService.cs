using BandsApp.Web.Models;

namespace BandsApp.Web.Services;

public class BandService
{
    List<Band> bands = [
        new Band { Id = 1, Name = "Beatles", Description = "Pop and rock bands" },
        new Band { Id = 2, Name = "Depeche Mode", Description = "English electronic band" },
        new Band { Id = 3, Name = "ABBA", Description = "Swedish pop group" },
        ];

    public Band? GetBandById(int id)
    {
        return bands.SingleOrDefault(b => b.Id == id);
    }

    public Band[] GetAllBands() => bands
        .OrderBy(b => b.Name)
        .ToArray();
}
