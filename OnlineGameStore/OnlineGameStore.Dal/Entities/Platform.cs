using System.ComponentModel.DataAnnotations;

namespace OnlineGameStore.Dal.Entities;

public class Platform
{
    public long Id { get; set; }
    public string Type { get; set; }

    public ICollection<GamePlatform> GamePlatforms { get; set; } = new List<GamePlatform>();
}
