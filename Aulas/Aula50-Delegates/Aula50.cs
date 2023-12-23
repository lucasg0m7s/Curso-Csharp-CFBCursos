using System;

// Delegates é um objeto que pode fazer referencia a métodos de uma classe
delegate int Op(int n1 = 0, int n2 = 0);
class Mat{
    public static int soma(int n1, int n2)
    {
        return n1 + n2;
    }
    public static int dobro(int n, int n2)
    {
        return n * 2;
    }
    public static int mult(int n1, int n2){
        return n1 * n2;
    }
}
class Aula50{
    static void Main()
    {
        int res;

        Op d1 = new Op(Mat.soma);

        res = d1(10, 50);

        Console.WriteLine("Soma: {0}", res);

        d1 = new Op(Mat.mult);
        
        res = d1(10, 50);

        Console.WriteLine("multiplicação: {0}", res);

        d1 = new Op(Mat.dobro);

        res = d1(10);

        Console.WriteLine("dobro: {0}", res);
    }  
}