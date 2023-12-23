using System;

class Aula25{   
    static void Main(){
        int num = 50;
        dobrar2(num);
        Console.WriteLine(num);
    }  

    static void dobrar1(ref int valor){ // ref muda o valor da variavel
        valor*=2;
    }
    static void dobrar2(int valor){ // não muda valor da variavel apenas utiliza ela e retorna outro valor sem alterar essa variavel
        valor*=2;
    }
}