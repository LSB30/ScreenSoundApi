using ScreenSoundApi.Modelos;
using System.Text.Json;
using ScreenSoundApi.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Music>>(resposta)!;
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistaOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPeloGeneroMusical(musicas, "rock");
        LinqFilter.FiltrarMusicasDoArtista(musicas, "Lil Peep");
    }
    catch (Exception ex) {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}  
