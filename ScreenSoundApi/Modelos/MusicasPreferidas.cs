

using System.Text.Json;

namespace ScreenSoundApi.Modelos;

internal class MusicasPreferidas
{
    public string? Nome { get; set; }
    public List<Music>? ListaDeMusicasFavoritas { get; }

    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new();
    }

    public void AdicionarMusicasFavoritas(Music musica)
    {
        ListaDeMusicasFavoritas?.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas são as Musicas Favoritas de {Nome}");

        foreach(var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"=> {musica.Nome} de {musica.Artista}");
        }

        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });

        string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";

        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo JSON foi criado com Sucesso! {Path.GetFullPath(nomeDoArquivo)}");
    }
}
