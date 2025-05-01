namespace OnlineGameStore.Dal.Entities;

public class Genre
{
    public long Id { get; set; }

    public string Name { get; set; }

    public long? ParentGenreId { get; set; }

    public Genre? ParentGenre { get; set; }

    public ICollection<GameGenre> GameGenres { get; set; } = new List<GameGenre>();

}
