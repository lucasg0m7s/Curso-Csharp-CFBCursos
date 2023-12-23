using System;

class Area{
    public static float Quad(float bas, float alt){
        if(bas == 0 || alt == 0){
            throw new Exception("Base ou altura não podem ser igual a 0");
        }
        return bas * alt;
    }
}
class Aula53{
    static void Main()
    {
        float area = 0;

        try
        {
            area = Area.Quad(10f, 0f);
            Console.WriteLine("Area do quad: {0}", area);
        }
        catch(Exception ex)
        {
            Console.WriteLine("Ocorreu um problema.\nErro: {0}", ex.Message);
        }
        finally
        {
            Console.WriteLine("Fim do processo.");
        }
    }  
}