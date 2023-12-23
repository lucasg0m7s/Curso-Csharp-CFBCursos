using System;
using System.Collections.Generic;

class Aula58{
    static void Main()
    {
        List<string> carros = new List<string>();
        string[] carros2 = new string[10];

        carros.Add("Golf");
        carros.Add("HRV");
        carros.Add("Focus");
        carros.Add("Argo");
        carros.Add("HRV");

        // carros2.AddRange(carros);

        // carros.Clear(); // Limpa elementos

        if(carros.Contains("Gol")){
            Console.WriteLine("Esta na lista");
        }else{
            Console.WriteLine("Não encontrado");
        }

        carros.CopyTo(carros2, 2);

        carros.Insert(1, "Cruze");

        int pos = carros.LastIndexOf("HRV");

        // carros.Remove("Argo");

        // carros.RemoveAt(0);

        // carros.Reverse();

        carros.Sort();

        int tamanho = carros.Count;
        carros.Capacity = 15;
        int capa = carros.Capacity;

        Console.WriteLine("Tamanho: {0}", tamanho);
        Console.WriteLine("Capacidade: {0}", capa);


        foreach(string c in carros){
            Console.WriteLine("Carro: {0}", c);
        }

        string ca = "HRV";
        int pos1 = 0;
        pos1 = carros.IndexOf(ca);

        Console.WriteLine("Ultimo HRV esta na posição {0}", pos);
        Console.WriteLine("Primeiro Carro {0} esta na posição {1}", ca, pos1);
    }  
}