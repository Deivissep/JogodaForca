namespace JogodaForca.ConsoleApp
{
    internal class Program
    {

        //V02 - Exibir palavra ocula com traços
        static void Main(string[] args)
        {
            while (true)
            {

                string palavraSecreta = "MELANCIA";

                char[] letrasEncontradas = new char[palavraSecreta.Length];

                for (int caractere = 0; caractere < letrasEncontradas.Length; caractere++)
                {
                    //acessar o arry no indice 0
                    letrasEncontradas[caractere] = '_';
                }

                string dicaDaPalavra = string.Join(" ", letrasEncontradas);

                Console.Clear();
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Jogo da Forca");
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Palavra secreta: " + dicaDaPalavra);
                Console.WriteLine("---------------------------------");

                Console.Write("Digite uma letra: ");
                char chute = Console.ReadLine()[0]; // pega apenas um caracter que usuário digita

                Console.WriteLine("Você digitou a letra: " + chute);
                Console.ReadLine();

            }

        }
    }
}
