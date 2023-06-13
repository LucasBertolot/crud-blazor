namespace GameStore.Client.Models;

public class Game
{
    public int Id { get; set; }

    public required string Nome { get; set; }

    public required string Gênero { get; set; }

    public decimal Preço { get; set; }

    public DateTime Lançamento { get; set; }
}