namespace _01_ComandosCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 18;
            double altura  = 1.60;

            //&& (ou) (||)
            if ((idade == 18) || (altura > 1.50))
            {
                if(altura > 1.50)
                    Console.WriteLine("Pode entrar");
            }

            else
            {
                Console.WriteLine("ANão pode entrar");
            }
        }
    }
}