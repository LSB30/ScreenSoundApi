using ScreenSoundApi.Modelos;


namespace ScreenSoundApi.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistaOrdenados(List<Music> musicas)
    {
        var artistaOrdenados = musicas.OrderBy(music => music.Artista)
            .Select(music => music.Artista)
            .Distinct()
            .ToList();
        Console.WriteLine("Lista de artistas ordenados");
        foreach(var artista in artistaOrdenados)
        {

        Console.WriteLine($"=> {artista}");
        }

    }
}
