using System;

class Aula14{   
    static void Main(){
        int nota1, nota2, nota3, nota4, res;
        res = nota1 = nota2 = nota3 = nota4 = 0;
        string resultado;

        Console.WriteLine("Digite a nota 1: ");
        nota1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 2: ");
        nota2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 3: ");
        nota3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 4: ");
        nota4 = int.Parse(Console.ReadLine());

        res = nota1 + nota2 + nota3 + nota4;
        // >= - Aprovado
        // 59 e 40 - Rec
        // <40 - Reprovado
        if(res >= 60){
            if(res >= 90){
                if(res >= 99){
                    resultado = "Aprovado com super Louvor";
                }else{
                    resultado = "Aprovado com Louvor";
                }
            }else{
                resultado = "Aprovado";
            }
        }else{
            if(res >= 40){
                resultado = "Recuperação";
            }else{
                resultado = "Reprovado";
            }
        }


        Console.WriteLine("Resultado: {0}\nA soma das suas notas foi: {1}", resultado, res);

     }
}