namespace Diamante.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {

                Console.Clear();
                Console.Write("Informe um número ímpar: ");
                int tamanho = Convert.ToInt32(Console.ReadLine());

                if (tamanho % 2 == 0)
                {
                    Console.WriteLine("Número informado não é ímpar. \nAperte ENTER para continuar");
                    Console.ReadLine();
                    continue;
                }

                int meio = tamanho / 2;

                for (int i = 0; i <= meio; i++)
                {
                    string linha = $"{new string(' ', meio - i)}{new string('x', 2 * i + 1)}";
                    Console.WriteLine(linha);
                }

                for (int i = meio - 1; i >= 0; i--)
                {
                    string linha = $"{new string(' ', meio - i)}{new string('x', 2 * i + 1)}";
                    Console.WriteLine(linha);
                }

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
