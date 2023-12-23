using System;
// Interfaces só implementam metodos ou o prototipo dos metodos, não usamos propriedades campos
// Toda classe que usar interface precisa implementar seus metodos
// Uma classe pode herdar mais de uma interface
// Interface não pode ter construtor nem destrutor
// Não posso definir metodo operator
// ''   ''     ''      campos
// ''   ''     ''      definir membros static

public interface Veiculo{
    void ligar();
    void desligar();
    void info();
}

public interface Combate{
    void disparar();
}

class Carro:Veiculo,Combate{
    public bool ligado;
    private int municao;
    public Carro(){
        setMunicao(100);
    }
    public void setMunicao(int qtde){
        this.municao = qtde;
    }

    public void ligar(){
        this.ligado = true;
    }
    public void desligar(){
        this.ligado = false;
    }

    public void info(){}
    public void disparar(){}
}
class Aula43{
    static void Main(){
        Carro c1 = new Carro();
    }  
}