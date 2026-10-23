using System.Globalization;
using System.Text.Json.Serialization;

namespace BlazorPokeApi.Models;

/// <summary>
/// Representa o retorno do endpoint https://pokeapi.co/api/v2/pokemon/{nome}
/// (apenas os campos usados pela aplicação).
/// </summary>
public class Pokemon
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>Altura em decímetros (padrão da PokéAPI).</summary>
    [JsonPropertyName("height")]
    public int Height { get; set; }

    /// <summary>Peso em hectogramas (padrão da PokéAPI).</summary>
    [JsonPropertyName("weight")]
    public int Weight { get; set; }

    [JsonPropertyName("sprites")]
    public Sprites? Sprites { get; set; }

    /// <summary>
    /// Imagem obrigatória do exercício: sprites.other["official-artwork"].front_default
    /// </summary>
    [JsonIgnore]
    public string? ImagemUrl => Sprites?.Other?.OfficialArtwork?.FrontDefault;

    [JsonIgnore]
    public string AlturaFormatada => Formatar(Height / 10.0) + " m";

    [JsonIgnore]
    public string PesoFormatado => Formatar(Weight / 10.0) + " kg";

    // Formata com vírgula decimal (padrão brasileiro), sem depender da cultura do navegador.
    private static string Formatar(double valor) =>
        valor.ToString("0.##", CultureInfo.InvariantCulture).Replace('.', ',');
}

public class Sprites
{
    [JsonPropertyName("other")]
    public OtherSprites? Other { get; set; }
}

public class OtherSprites
{
    [JsonPropertyName("official-artwork")]
    public OfficialArtwork? OfficialArtwork { get; set; }
}

public class OfficialArtwork
{
    [JsonPropertyName("front_default")]
    public string? FrontDefault { get; set; }
}
