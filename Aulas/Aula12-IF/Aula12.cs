using System;

class Aula12{   
    static void Main(){
       
        //SE(EXPRESSÃO LOGICA){}
        // EXEMPLO DE EXPRESSÃO LOGICA: 10 > 5 = true
        // Operadores: > < >= <= ==(igualdade) !=(diferente)

        int nota1, nota2, nota3, nota4, res;
        res = nota1 = nota2 = nota3 = nota4 = 0;
        string resultado = "Reprovado";

        Console.WriteLine("Digite a nota 1: ");
        nota1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 2: ");
        nota2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 3: ");
        nota3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a nota 4: ");
        nota4 = int.Parse(Console.ReadLine());

        res = nota1 + nota2 + nota3 + nota4;

        if(res >= 60){
            resultado="Aprovado";
        }

        // Outra maneira de usar
        // if((nota1 + nota2 + nota3 + nota4) >= 60){
        //     resultado="Aprovado";
        // }

        Console.WriteLine("Resultado: {0}\nA soma das suas notas foi: {1}", resultado, res);
      }
}