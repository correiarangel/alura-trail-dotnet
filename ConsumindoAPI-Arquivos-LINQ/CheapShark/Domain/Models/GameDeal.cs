using System.Text.Json.Serialization;

namespace CheapShark.Domain.Models
{
    public class GameDeal
    {
        [JsonPropertyName("dealID")]
        public string DealId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("salePrice")]
        public string SalePrice { get; set; }

        [JsonPropertyName("normalPrice")]
        public string NormalPrice { get; set; }

        [JsonPropertyName("savings")]
        public string Savings { get; set; }

        [JsonPropertyName("metacriticScore")]
        public string MetacriticScore { get; set; }

        [JsonPropertyName("steamRatingText")]
        public string SteamRating { get; set; }

        [JsonPropertyName("steamRatingPercent")]
        public string SteamPercent { get; set; }

        [JsonPropertyName("dealRating")]
        public string DealRating { get; set; }

        [JsonPropertyName("thumb")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("steamAppID")]
        public string SteamId { get; set; }

        [JsonPropertyName("isOnSale")]
        public string IsOnSale { get; set; }

        public void ExibirNoConsole()
        {
            Console.WriteLine($"\n-----------------------------------");
            Console.WriteLine($"\n{'='} {Title} {'='}");
            Console.WriteLine($"Preço: ${SalePrice} (era ${NormalPrice})");
            Console.WriteLine($"Desconto: {Savings}%");
            Console.WriteLine($"Avaliação Steam: {SteamRating} ({SteamPercent}%)");
            Console.WriteLine($"Nota Metacritic: {MetacriticScore}");
            Console.WriteLine($"Deal Rating: {DealRating}");
            Console.WriteLine($"Link: https://store.steampowered.com/app/{SteamId}");
            Console.WriteLine($"-----------------------------------\n");
        }
    }
}