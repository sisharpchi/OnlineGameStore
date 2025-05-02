using System.ComponentModel.DataAnnotations;

namespace OnlineGameStore.Dal.Entities;

public class Game
{
    public long Id { get; set; }
    public string Name { get; set; }
    public string Key { get; set; }

    public string? Description { get; set; }

    public ICollection<GameGenre> GameGenres { get; set; }
    public ICollection<GamePlatform> GamePlatforms { get; set; }
}
