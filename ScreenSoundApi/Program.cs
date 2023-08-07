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

        var musicasPreferiasDoLucas = new MusicasPreferidas("Lucas");
        musicasPreferiasDoLucas.AdicionarMusicasFavoritas(musicas[30]);
        musicasPreferiasDoLucas.AdicionarMusicasFavoritas(musicas[7]);
        musicasPreferiasDoLucas.AdicionarMusicasFavoritas(musicas[10]);
        musicasPreferiasDoLucas.AdicionarMusicasFavoritas(musicas[777]);

        musicasPreferiasDoLucas.ExibirMusicasFavoritas();

        //var musicasPreferiasDaJasna = new MusicasPreferidas("Jasna");
        //musicasPreferiasDaJasna.AdicionarMusicasFavoritas(musicas[330]);
        //musicasPreferiasDaJasna.AdicionarMusicasFavoritas(musicas[27]);
        //musicasPreferiasDaJasna.AdicionarMusicasFavoritas(musicas[130]);
        //musicasPreferiasDaJasna.AdicionarMusicasFavoritas(musicas[33]);

        //musicasPreferiasDaJasna.ExibirMusicasFavoritas();

        musicasPreferiasDoLucas.GerarArquivoJson();

    }
    catch (Exception ex) {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
    
}  
