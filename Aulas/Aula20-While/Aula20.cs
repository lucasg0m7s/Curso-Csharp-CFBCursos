using System;

class Aula20{   
    static void Main(){
        // LOOP WHILE - utilizado quanto não temos certeza da quantidade de vezes que vai repetir

        int[] num = new int[10];

        int i=0;
        while(i<num.Length){
            num[i] = 0;
            Console.WriteLine(num[i]);
            i++;
        }
        Console.WriteLine("Fim do loop");
     }
}