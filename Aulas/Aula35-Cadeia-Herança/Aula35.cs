using System;
// O uso da cadeia de herança dispensa a criação de diversas variaveis com o mesmo nome,
// dessa forma tudo que for um veiculo terá atributos utilizados em todas as derivações dessa classe.

class Veiculo{ //Classe Base
    public int velMax;
    private bool ligado;
    private int rodas;

    public Veiculo(int rodas){
        this.rodas = rodas;
    }
    public void ligar(){
        ligado = true;
    }

     public void desligar(){
        ligado = false;
    }

    public string getLigado(){
        return (ligado?"sim":"não"); // Operador ternário
    }
    public int getRodas(){
        return rodas;
    }

    public void setRodas(int rodas){
        if(rodas <0){
            this.rodas = 0;
        }else if(rodas > 40){
            this.rodas = 40;
        }else{
            this.rodas = rodas; 
        }
    }
}

class Carro:Veiculo{ //Classe derivada
    public string nome;
    public string cor;
    public Carro(string nome, string cor):base(4){
        desligar();
        velMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}

class CarroCombate:Carro{
    public int municao;
    public CarroCombate():base("Carro de combate","Verde"){
        municao = 100;
        setRodas(6);
    }
}

class Aula35{
    static void Main(){
        Carro c1 = new Carro("Rapidão","Vermelho");
        CarroCombate cc1 = new CarroCombate();

        c1.ligar();

        Console.WriteLine("COR: {0}",c1.cor);
        Console.WriteLine("NOME: {0}",c1.nome);
        Console.WriteLine("RODAS: {0}",c1.getRodas());
        Console.WriteLine("VEL.MAXIMA: {0}",c1.velMax);
        Console.WriteLine("LIGADO: {0}",c1.getLigado());

        Console.WriteLine("-------------------------------");

        Console.WriteLine("COR: {0}",cc1.cor);
        Console.WriteLine("NOME: {0}",cc1.nome);
        Console.WriteLine("RODAS: {0}",cc1.getRodas());
        Console.WriteLine("VEL.MAXIMA: {0}",cc1.velMax);
        Console.WriteLine("LIGADO: {0}",cc1.getLigado());
        Console.WriteLine("Munição: {0}",cc1.municao);

    }  
}