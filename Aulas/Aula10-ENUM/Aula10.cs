using System;

class Aula10{

    enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sábado};
    static void Main(){
        // DiasSemana diasSemana = DiasSemana.Domingo;
        // DiasSemana diasSemana = (DiasSemana)0;
        int diasSemana = (int)DiasSemana.Sexta;
        
        Console.WriteLine(diasSemana);

      }
}