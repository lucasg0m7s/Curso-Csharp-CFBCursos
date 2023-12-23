using System;

// Passagem de argumentos na chamada do programa
class Aula51{
    static void Main(string[] args)
    {
        int res = 0;


        if(args.Length > 0)
        {
            Console.WriteLine("Qtde de argumentos: {0}", args.Length);
            for(int i = 0; i < args.Length; i++){
                res += Convert.ToInt32(args[i]);
            }
            Console.WriteLine("Soma: {0}", res);
        }
        else{
            Console.WriteLine("Não foram passados argumentos.");
        }
    }  
}