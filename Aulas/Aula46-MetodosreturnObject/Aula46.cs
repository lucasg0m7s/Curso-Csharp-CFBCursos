using System;

class Galinha{
    private string nomeGalinha;
    private int numOvo;
    public Galinha(string nomeGalinha){
        this.nomeGalinha = nomeGalinha;
        numOvo = 0;
    }

    public Ovo botar(){
        numOvo++;
        return new Ovo(numOvo,nomeGalinha);
    }
}

class Ovo{
    private int numOvo;
    private string minhaGalinha;
    static int numOvogeral; // static signifca que todos os objetos vão usar essa mesma variavel
    public Ovo(int numOvo, string minhaGalinha){
        numOvogeral++;
        this.numOvo = numOvo;
        this.minhaGalinha = minhaGalinha;
        Console.WriteLine("Ovo criado: {0} - {1}",this.numOvo,this.minhaGalinha);
        Console.WriteLine("Número de ovos criados: {0}",numOvogeral);
    }
}

class Aula46{
    static void Main(){
        Galinha g1 = new Galinha("Beneditasgildimar");
        Galinha g2 = new Galinha("Felizbertaniazilda");
        Galinha g3 = new Galinha("Marisgertrudeszela");

        g1.botar();
        g1.botar();
        g1.botar();

        g2.botar();

        g3.botar();
        g3.botar();


    }  
}