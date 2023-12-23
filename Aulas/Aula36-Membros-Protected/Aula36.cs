using System;

class Veiculo{ // Base
    public int velAtual;
    private int VelMax; // Só posso acessar com metodos da classe base e classes derivadas não tem acesso a membros private
    protected bool ligado; // Permite o acesso ao membro pela classe derivada mas não ao objeto
    public Veiculo(int velMax){
        velAtual = 0;
        this.VelMax = velMax;
        ligado = false;
    }
    public bool getLigado(){ // é usado para retornar no metodo MAIN, pois protected não pode ser acessado pelo objeto
        return ligado;
    }

    public int getVelMax(){
        return VelMax;
    }
}

class Carro:Veiculo{ //Classe derivada de veiculo
    public string Nome;
    public Carro(string nome, int vm):base(vm){
        this.Nome = nome;
        ligado = true;
    }
}

class Aula36{
    static void Main(){
        Carro carro = new Carro("Bonitão",120);

        Console.WriteLine("Nome: {0}", carro.Nome);
        Console.WriteLine("Vel.Maxima: {0}", carro.getVelMax());
        Console.WriteLine("Ligado: {0}", carro.getLigado());
    }  
}