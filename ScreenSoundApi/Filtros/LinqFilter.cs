﻿
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
}
