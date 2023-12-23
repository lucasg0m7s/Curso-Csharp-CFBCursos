using System;

class Veiculo{ //Classe Base
    public int velMax;
    private bool ligado;
    public int rodas;
    public void ligar(){
        ligado = true;
    }

     public void desligar(){
        ligado = false;
    }

    public string getLigado(){
        if(ligado){
            return "sim";
        }else{
            return "não";
        }
    }
}

class Carro:Veiculo{ //Classe derivada
    public string nome;
    public string cor;
    public Carro(string nome, string cor){
        desligar();
        rodas = 4;
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class Aula34{
    static void Main(){
        Carro c1 = new Carro("Rapidão","Vermelho");

        Console.WriteLine("COR: {0}",c1.cor);
        Console.WriteLine("NOME: {0}",c1.nome);
        Console.WriteLine("RODAS: {0}",c1.rodas);
        Console.WriteLine("VEL.MAXIMA: {0}",c1.velMax);
        Console.WriteLine("LIGADO: {0}",c1.getLigado());
    }  
}