using System;

class Aula17{   
    static void Main(){
        // int n1,n2,n3,n4,n5;
        //Formas de declarar um Array(VETOR)
        int[] n=new int[5]; // 0-4
        //int[] num = new int[3]{55,77,99};
        int[] num={55,77,99,88};
        string[] veiculos = new string[3]; 
        //Tipo     nome       atribuição

        veiculos[0]= "Carro";
        veiculos[1] = "Avião";
        veiculos[2] = "ônibus";

        n[0] =11;
        n[1] = 22;
        n[2] = 33;
        n[3] = 44;
        n[4] = 55;

        Console.WriteLine(num[0]);
     }
}