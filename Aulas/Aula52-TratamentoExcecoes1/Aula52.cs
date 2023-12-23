using System;

// Tratamento de exceções
// Toda exceção herda uma classe que é derivada da classe Exception
class Aula52{
    static void Main()
    {
        int n1, n2, res;
        res = n1 = n2 = 0;

        n1 = 10;
        n2 = 0;

        try
        {
            res = n1 / n2;
            Console.WriteLine("{0}/{1} = {2}", n1, n2, res);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Ocorreu um problema.\nErro: {0}\nExceção: {1}", ex.Message, ex.GetType());
        }
    }  
}