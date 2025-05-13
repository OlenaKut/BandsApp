namespace BandsApp.Web.Models;

public class Band
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string ImageName { get; set; } = string.Empty;
    public string VideoUrl { get; set; } = string.Empty;

    public List<Album> Albums { get; set; } = new List<Album>();
}

