using System;

class Aula18{   
    static void Main(){
        int[,] n=new int[3,5];      //0     1
        int[,] num = new int[2,2]{{10,20},{30,40}};
        /*                          0  1    0  1
                C  C  C  C  C
                0  1  2  3  4 
          L 0 = 10 20 30 40 50
          L 1 = 60 70 80 90 15
          L 2 = 25 35 45 55 65

           Primeiro linhas depois coluna
        */
        n[0,0] = 10;
        n[0,1] = 20;
        n[0,2] = 30;
        n[0,3] = 40;
        n[0,4] = 50;

        n[1,0] = 60;
        n[1,1] = 70;
        n[1,2] = 80;
        n[1,3] = 90;
        n[1,4] = 15;

        n[2,0] = 25;
        n[2,1] = 35;
        n[2,2] = 45;
        n[2,3] = 55;
        n[2,4] = 65;

        Console.WriteLine(num[0,0]);
        Console.WriteLine(num[0,1]);
        Console.WriteLine(num[1,0]);
        Console.WriteLine(num[1,1]);
     }
}