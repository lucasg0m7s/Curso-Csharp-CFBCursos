using System;

static public class Jogador{  
    // Classes static não permitem instanciação de objetos, 
    // não podem ter construtores
    // todos os membros de uma classe static precisam ser static
    // uma classe não static pode ter um membro static
    // Elementos static criam um espaço na memoria e aplicam mudanças para todo o sistema
    
    static public int energia;
    static public bool vivo;
    static public string nome;
    static public void iniciar(string n){
        energia = 100;
        vivo = true;
        nome = n;
    }
    
    static public void info(){
        Console.WriteLine("Nome jogador...: {0}",nome);
        Console.WriteLine("Energia jogador: {0}",energia);
        Console.WriteLine("Status jogador.: {0}\n",vivo);
    }
}

class Inimigo{
    static public bool alerta; //quando é criado atributos statics, significa que todos os objetos da classe usam esse mesmo atributo
    public string nome;
    public Inimigo(string n){
        alerta = false;
        nome = n;
    }
    public void info(){
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("----------------------------");

    }
}


class Aula31{
    static void Main(){
        // Classes static são chamadas através do nome da classe
        Jogador.iniciar("Bruno");
        Jogador.info();

        Inimigo i1 = new Inimigo("Doido");
        Inimigo i2 = new Inimigo("Maluco");
        Inimigo i3 = new Inimigo("Pirado");

        Inimigo.alerta = true; 

        i1.info();
        i2.info();
        i3.info();

    }  
}