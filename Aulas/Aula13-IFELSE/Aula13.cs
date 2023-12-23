using System;

class Aula13{   
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
        if(res < 40){
            resultado="Reprovado";
        }else if(res >= 40 & res <=59){
            resultado = "Recuperação";
        }else{
            resultado = "Aprovado";
        }
        // OU //
        // if(res < 40){
        //     resultado="Reprovado";
        // }else if(res < 60){
        //     resultado = "Recuperação";
        // }else{
        //     resultado = "Aprovado";
        // }

        Console.WriteLine("Resultado: {0}\nA soma das suas notas foi: {1}", resultado, res);

     }
}