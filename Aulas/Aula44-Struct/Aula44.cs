using System;
// Uma estrutura é um tipo que permite o armazenamento de diferentes tipos de dados
// Membros da estrutura são acessados diretamentes
// Não pode ser herdada
// Posso usar construtores
// Pode ser instanciado
// Struct não é classe, é mais simples que uma

struct Carro{
    public string marca;
    public string modelo;
    public string cor;

    public Carro(string marca, string modelo, string cor){
        this.marca = marca;
        this.modelo = modelo;
        this.cor = cor;
    }

    public void info(){
        Console.WriteLine("Marca: {0}",this.marca);
        Console.WriteLine("Modelo: {0}",this.modelo);
        Console.WriteLine("Cor: {0}",this.cor);
    }
}
class Aula44{
    static void Main(){
        Carro c1 = new Carro("Honda", "HRV", "Prata");
        Carro c2 = new Carro("VW", "Golf", "Azul");

        c1.info();
        c2.info();
    }  
}