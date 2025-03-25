namespace JogodaForca.ConsoleApp
{
    internal class Program
    {

        //V03 - Verificação da entrada de dados do usuário
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

                int quantidadeErros = 0;
                bool jogadorEnforcou = false;
                bool jogadorAcertou = false;

                do
                {
                    string dicaDaPalavra = string.Join(" ", letrasEncontradas);

                    Console.Clear();
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Jogo da Forca");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Palavra secreta: " + dicaDaPalavra);
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine("Quantidade de erros: "+ quantidadeErros);
                    Console.WriteLine("---------------------------------");

                    Console.Write("Digite uma letra: ");
                    char chute = Console.ReadLine()[0]; // pega apenas um caracter que usuário digita

                    bool letraFoiEncontrada = false;

                    for (int contador = 0; contador < palavraSecreta.Length; contador++)
                    {
                     char letraAtual = palavraSecreta[contador];

                        if (chute == letraAtual)
                        {
                            letrasEncontradas[contador] = letraAtual;
                            letraFoiEncontrada = true;
                        }
                    }

                    if (letraFoiEncontrada == false)
                    {
                        quantidadeErros++;
                    }

                    dicaDaPalavra = string.Join(" ", letrasEncontradas);

                    jogadorAcertou = dicaDaPalavra == palavraSecreta;
                    jogadorEnforcou = quantidadeErros > 5; //6 tentativas o rapaz é enforcado

                    if(jogadorAcertou)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Você acertou a palavra secreta! A palavra era: " + palavraSecreta);
                        Console.WriteLine("---------------------------------");
                    }
                    else if (jogadorEnforcou)
                    {
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Que azar tente novamente! A palavra era: " + palavraSecreta);
                        Console.WriteLine("---------------------------------");
                    }

                } while (jogadorAcertou == false || jogadorEnforcou == false);// || = ou

                Console.ReadLine();

            }

        }
    }
}
