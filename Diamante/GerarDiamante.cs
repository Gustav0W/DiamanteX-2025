namespace Diamante.ConsoleApp
{
    public static class GerarDiamante
    {
        public static int ColetarValor(int valor = 0)
        {
            do {
                Console.Clear();
                Console.Write("Informe um número ímpar: ");
                if (!int.TryParse(Console.ReadLine(), out int tamanho))
                {
                    Console.WriteLine("Número INTEIRO inválido. \nAperte ENTER para tentar novamente");
                    Console.ReadLine();
                    continue;
                }

                if (tamanho % 2 == 0)
                {
                    Console.WriteLine("Número informado não é ímpar. \nAperte ENTER para continuar");
                    Console.ReadLine();
                    continue;
                }
                valor = tamanho;
                return valor;
            } while (true);

        }
        public static void MostrarDiamante(int tamanho)
        {
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
        }
    }
}
