using BandsApp.Web.Models;

namespace BandsApp.Web.Services;

public class BandService
{
    List<Band> bands = [
        new Band { Id = 1, Name = "Beatles", Description = "Pop and rock bands", ImageName = "theBeatles.jpg", VideoUrl = "https://www.youtube.com/embed/1LbtBBvjOWw?si=edXE2zNYuZX49R7k"},
        new Band { Id = 2, Name = "Depeche Mode", Description = "English electronic band", ImageName = "depecheMode.jpg", VideoUrl ="https://www.youtube.com/embed/u1xrNaTO1bI?si=dFwyXls2gm-Yagi7" },
        new Band { Id = 3, Name = "ABBA", Description = "Swedish pop group", ImageName = "abba.jpg", VideoUrl = "https://www.youtube.com/embed/xFrGuyw1V8s?si=_v2tMGwVXL6fQsOy" },
        ];

    public Band? GetBandById(int id)
    {
        return bands.SingleOrDefault(b => b.Id == id);
    }

    public Band[] GetAllBands() => bands
        .OrderBy(b => b.Name)
        .ToArray();


    List<Album> albums = new()
        {
            new Album { AlbumId = 1, Title = "The Beatles", ReleaseYear = 1968, BandId = 1 },
            new Album { AlbumId = 2, Title = "The Beatles", ReleaseYear = 1970,  BandId = 1 },
            new Album { AlbumId = 3, Title = "Yellow Submarine", ReleaseYear = 1969, BandId = 1 },

            new Album { AlbumId = 4, Title = "Violator", ReleaseYear = 1990, BandId = 2 },
            new Album { AlbumId = 5, Title = "Memento Mori", ReleaseYear = 2023,  BandId = 2 },
            new Album { AlbumId = 6, Title = "Ultra", ReleaseYear = 1997, BandId = 2 },


            new Album { AlbumId = 7, Title = "Voyage", ReleaseYear = 2021, BandId = 3 },
            new Album { AlbumId = 8, Title = "ABBA", ReleaseYear = 1975,  BandId = 3 },
            new Album { AlbumId = 9, Title = "Waterloo", ReleaseYear = 1974, BandId = 3 },
        };


    public Album[] GetAllAlbums() => albums
        .OrderBy(a => a.Title)
        .ToArray();

    public Album[] GetAlbumsByBandId(int bandId)
    {
        return albums
            .Where(a => a.BandId == bandId)
            .OrderBy(a => a.Title)
            .ToArray();
    }
}
