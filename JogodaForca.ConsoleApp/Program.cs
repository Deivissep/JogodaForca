namespace JogodaForca.ConsoleApp
{
    internal class Program
    {

        //V01 - Estrutura basica e entrada do usuário
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("---------------------------------");

                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()[0]; // pega apenas um caracter que usuário digita

                Console.WriteLine("Você digitou a letra: " + chute);
                Console.ReadLine();

            }

        }
    }
}
