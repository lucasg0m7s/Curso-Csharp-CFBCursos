using System;
using System.Collections.Generic;

// Com o dictionary podemos colecionar dados e relaciona-los a uma chave
class Aula55{
    static void Main()
    {
        Dictionary <int, string> veiculos = new Dictionary<int, string>();

        veiculos.Add(10, "Carro");
        veiculos.Add(5, "Avião");
        veiculos.Add(0, "Navio");
        veiculos.Add(20, "Moto");
        veiculos.Add(15, "Patinete");

        // veiculos.Clear(); Limpa os elementos

        Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);

        veiculos.Remove(20); // Remove um elemento

        int chave = 20;
        if(veiculos.ContainsKey(chave)){ // Verifica se contém a chave
            Console.WriteLine("A chave {0} esta na coleção", chave);
        }
        else{
            Console.WriteLine("A chave {0} não esta na coleção", chave);
        }

        veiculos[15] = "Bicicleta"; // Substitui um valor informando a chave

        string valor = "Bicicleta";
        if(veiculos.ContainsValue(valor)){ // Verifica se contém o valor
            Console.WriteLine("O valor '{0}' esta na coleção", valor);
        }
        else{
            Console.WriteLine("O valor '{0}' não esta na coleção", valor);
        }

        Dictionary <int, string>.ValueCollection valores = veiculos.Values;
        // Imprime os valores
        foreach(string v in valores){
            Console.WriteLine(v);
        }
        // Imprime as chaves
        foreach(KeyValuePair<int,string> v in veiculos){
            Console.WriteLine(v.Key);
        }

    }  
}