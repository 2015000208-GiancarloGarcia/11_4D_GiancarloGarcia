internal class Program
{
    //Verificar si un numero es positivo
    //o negativo
    private static void Main(string[] args)
    {
        //Entradas
        Console.WriteLine("===NUMEROS POSITIVOS Y NEGATIVOS===");
        int num;
        Console.Write("Dame un numero entero: ");
        num=Convert.ToInt32(Console.ReadLine());
        //Procesos
        //Salidas
        if (num >= 0)
        {
            Console.WriteLine("Es un numero positivo");
        }
        else 
        {
            Console.WriteLine("Es un numero negativo");
        }
    }
}