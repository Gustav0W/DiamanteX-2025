namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int tamanho = GerarDiamante.ColetarValor();
                GerarDiamante.MostrarDiamante(tamanho);

                Console.Write("\nDeseja continuar (S/N): ");
                string continuar = Console.ReadLine().ToUpper();
                if (continuar != "S")
                {
                    break;
                }

            }
        }
    }
}
