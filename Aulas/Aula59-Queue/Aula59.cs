using System;
using System.Collections.Generic;

class Aula59{
    static void Main()
    {
        // string[] vs = {"Carro", "Moto", "Navio", "Aviao"};
        Queue<string> veiculos = new Queue<string>();

        veiculos.Enqueue("Carro"); // Adiciona no final da fila
        veiculos.Enqueue("Moto");
        veiculos.Enqueue("Navio");
        veiculos.Enqueue("Aviao");
        
        string v = "Patinete";
        if(veiculos.Contains(v))
        {
            Console.WriteLine("Veiculo " + v + " encontrado");
        }
        else
        {
            Console.WriteLine("Veiculo " + v + " não encontrado");
        }

        // veiculos.Clear();

        // Console.WriteLine("Primeiro Veiculo " + veiculos.Dequeue()); // Retorna o primeiro elemento e remove da fila
        
        // Console.WriteLine("Primeiro Veiculo " + veiculos.Dequeue()); // Retorna o primeiro elemento e remove da fila

        Console.WriteLine("Primeiro Veiculo " + veiculos.Peek()); // Apenas retorna o primeiro elemento sem remover

        // foreach(string ve in veiculos){
        //     Console.WriteLine("Veiculo: " + ve);
        // }

        Console.WriteLine("Tamanho fila: " + veiculos.Count);

        while(veiculos.Count > 0){
            Console.WriteLine(veiculos.Dequeue());
            Console.WriteLine("Tamanho fila: " + veiculos.Count);
        }
    }  
}