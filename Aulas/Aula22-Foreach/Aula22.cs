using System;

class Aula22{   
    static void Main(){
        int[] num = new int[5]{11,22,33,44,55};

        for(int i=0; i<num.Length; i++){
            num[i] = 0;
        }

        //LOOP FOREACH - UTILIZADO PARA LER E EXIBIR OS ELEMENTOS DE UMA COLEÇÃO(ARRAY)

        foreach(int n in num){
            Console.WriteLine(n); 
        }

        // PARA INICIALIZAR OS ELEMENTOS DO ARRAY O FOREACH NÃO SERVE
    }
}