
using ScreenSoundApi.Modelos;


namespace ScreenSoundApi.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Music> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => 
        generos.Genero).Distinct().ToList();

        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"=> {genero}");
        }
    }

    public static void FiltrarArtistasPeloGeneroMusical(List<Music> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica =>
        musica.Genero!.Contains(genero))
            .Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine($"Exibindo os artista por gênero musical >>> {genero}");

        foreach(var artist in  artistasPorGeneroMusical)
        {
            Console.WriteLine($"=> {artist}");
        }
    }

    public static void FiltrarMusicasDoArtista(List<Music> musicas, string nomeDoArtista)
    {
        var musicasDoArtista = musicas.Where
            (musicas => musicas.Artista!.Equals(nomeDoArtista))
            .Select(musicas => musicas.Nome).Distinct().ToList();

        Console.WriteLine($"Tods as faixa de {nomeDoArtista}");
        foreach(var music in musicasDoArtista)
        {
            Console.WriteLine($"=> {music}");
        }
    }

    public static void FiltrarPeloIndex(List<Music> musicas, int index)
    {
        var musicasFiltradaPeloIndex = musicas.Where(music => music.Key.Equals(index))
            .Select(music => music).ToList();

        
        foreach (var music in musicasFiltradaPeloIndex)
        {
            Console.WriteLine($"=> {music.Nome} | Tonalidade: {music.Tonalidade}");
        }
    }
}
