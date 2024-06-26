﻿using _1Persist;
using Model;
using Newtonsoft.Json;
using Repositories;


    Console.WriteLine("Iniciado a leitura dos dados do Json.");
    var listaRadar = ReadFile.GetData("C:\\Users\\adm\\Desktop\\dados_dos_radares.json");
List<Radar> radarLista = new List<Radar>(); //armazenar em nova lista
foreach (var jsonRadar in listaRadar)
{
    Radar radar = JsonConvert.DeserializeObject<Radar>(jsonRadar);
    if (radar != null)
    {
        radarLista.Add(radar);
    }
}
Console.WriteLine("Inserindo dados no SQL.");
    SQL.InsertDBRadar(radarLista);
    Console.WriteLine("Quantidade de Registros Lidos: " + radarLista.Count);

