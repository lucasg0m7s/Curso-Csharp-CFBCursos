using System;

public class Jogador{ // boa pratica de programação = Nomes de classes começam com letra maiuscula 
    public int energia=100;
    public bool vivo=true;

    public string chute(){
        energia = energia - 10;
        return "Jogador executou chute e perdeu 10 pontos de energia";
    }
}

// se não usa nenhum modificador, automaticamente a classe é public 
class Aula28{
    static void Main(){
        Jogador j1 = new Jogador(); // operador new reserva um espaço na memoria para o objeto
        Jogador j2 = new Jogador(); 
        Jogador j3 = new Jogador(); 

        j1.energia = 50;
        Console.WriteLine("Energia do jogador 1: {0}", j1.energia);
        Console.WriteLine("Energia do jogador 2: {0}", j2.energia);
        Console.WriteLine(j1.chute());
        Console.WriteLine("Energia do jogador 1: {0}", j1.energia);
    }  
}