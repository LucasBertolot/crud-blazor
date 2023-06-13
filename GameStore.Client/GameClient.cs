using GameStore.Client.Models;

namespace GameStore.Client;

public static class GameClient
{
        private static readonly List<Game> games = new() 
        {   

            new Game()
            {
                Id = 1,
                Nome = "Street Fighter II",
                Gênero = "Luta",
                Preço = 35.99M,
                Lançamento = new DateTime(1991, 2, 1)
            },
            new Game()
            {
                Id = 2,
                Nome = "Final Fantasy XIV",
                Gênero = "RPG",
                Preço = 150.99M,
                Lançamento = new DateTime(2010, 9, 30)
            },
            new Game()
            {
            Id = 3,
            Nome = "FIFA 23",
            Gênero = "Esportes",
            Preço = 35.99M,
            Lançamento = new DateTime(2022, 9, 27)
            }

        };

        public static Game[] GetGames()
        {
            return games.ToArray();
        }
}