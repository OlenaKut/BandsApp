namespace BandsApp.Web.Models
{
    public class Album
    {
        public int AlbumId { get; set; }
        public string Title { get; set; } = string.Empty;
        public int ReleaseYear { get; set; }

        public int BandId { get; set; }

        public Band? Band { get; set; }
    }
}
