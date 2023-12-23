using System;

class Aula23{   
    static void Main(){
        int[] vetor1 = new int[5];
        int[] vetor2 = new int[5];
        int[] vetor3 = new int[5];
        int[,] matriz = new int[2,5]{{11,22,00,44,55},{66,77,88,99,00}};

        // CRIA NUMEROS ALEATORIOS 
        Random random = new Random();
        for(int i=0; i<vetor1.Length;i++){
            vetor1[i]=random.Next(50);
        }

        Console.WriteLine("Elementos do vetor1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }

        //public static int BinarySearch(array,valor); - SERVE PARA PESQUISAR ELEMENTOS NO VETOR

        Console.WriteLine("BinarySearch");
        int procurado=33; // VALOR QUE QUERO PESQUISAR
        int pos = Array.BinarySearch(vetor1, procurado); // Retorna posição do elemento procurado e caso não tenha retorna -1
        Console.WriteLine("Valor {0} está na prosição {1}", procurado, pos);
        Console.WriteLine("------------------------------------------------");

        //public static void Copy(Array_origem, Array_destino, qtde_elementos); - Copia elementos de um vetor pra outro
        Console.WriteLine("Copy");
        Array.Copy(vetor1,vetor2,vetor1.Length);
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("--------------------------------------------");

        //public void Copyto(Array-destino,a_partir_desta_pos);
        Console.WriteLine("CopyTo");
        vetor1.CopyTo(vetor3,0); // TODOS OS ELEMENTOS DO VETOR1 SERÃO COPIADOS NO VETOR 3
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }
        Console.WriteLine("--------------------------------------------");

         //public longe GetLongLenght(dimensão); - Retorna quantidade de elementos
        Console.WriteLine("GetLongLenght");
        long qtdeElementosVetor=vetor1.GetLongLength(0);
        Console.WriteLine("Quantidade de elementos {0}",qtdeElementosVetor);
        Console.WriteLine("-------------------------------------------");

        //public int GetLowerBound(dimensão); - Retorna menor posição
        Console.WriteLine("GetLowerBound");
        int MenorIndiceVetor=vetor1.GetLowerBound(0);
        int MenorIndiceMatriz_D1=matriz.GetLowerBound(1);
        Console.WriteLine("Menor Índice do vetor1 {0}",MenorIndiceVetor);
        Console.WriteLine("-------------------------------------------");

        //public int GetUpperBound - Retorna maior posição
        Console.WriteLine("GetUpperBound"); 
        int MaiorIndiceVetor=vetor1.GetUpperBound(0);
        int MaiorIndiceMatriz_D1=matriz.GetUpperBound(1);
        Console.WriteLine("Maior índice do vetor1 {0}",MaiorIndiceVetor);
        Console.WriteLine("-------------------------------------------");

        //public object GetValue(long índice); - Retorna valor do indice informado
        Console.WriteLine("GetValue");
        int valor0=Convert.ToInt32(vetor1.GetValue(3));
        int valor1=Convert.ToInt32(matriz.GetValue(1,3));
        Console.WriteLine("Valor da posição 3 do vetor1: {0}", valor0);
        Console.WriteLine("-------------------------------------------");

        //public static int IndexOf(array,valor); - Retorna posição do primeiro valor q encontrar
        Console.WriteLine("IndexOf");
        int indice1=Array.IndexOf(vetor1,3);
        Console.WriteLine("Indice do primeiro valor 3:{0}",indice1);
        Console.WriteLine("-------------------------------------------");

        //public static int LastIndexOf(array,valor): - Retorna posição do ultimo valor q encontrar
        Console.WriteLine("LastIndexOf");
        int indice2=Array.LastIndexOf(vetor1,3);
        Console.WriteLine("Indice do último valor 33:{0}",indice2);
        Console.WriteLine("-------------------------------------------");

        //public static void Reverse(array); - Inverte a ordem dos elementos
        Array.Reverse(vetor1);
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }   

        //public void SetValue(object valor, long pos);  - Atribui valores
        vetor2.SetValue(99,0);
        for(int i=0;i<vetor2.Length;i++){
            vetor2.SetValue(0,i);
        }
        Console.WriteLine("Vetor 2");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }

        //public static void Sort(array); - Ordenar os elementos em ordem crescente
        Array.Sort(vetor1);
        Array.Sort(vetor2);
        Array.Sort(vetor3);
        Console.WriteLine("Vetor1");
        foreach(int n in vetor1){
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor2");
        foreach(int n in vetor2){
            Console.WriteLine(n);
        }
        Console.WriteLine("\nVetor3");
        foreach(int n in vetor3){
            Console.WriteLine(n);
        }

    }
}