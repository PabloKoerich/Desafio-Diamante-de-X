namespace Exercicio_Diamante_AdP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                #region Apresentação do Programa;
                // Apresentação do Programa;
                Console.WriteLine("Bem vindo ao Diamante de 'X' |\nDigite qualquer tecla para continuar!");
                Console.ReadKey();
                Console.Clear();
                #endregion


                #region Menu de entrada: 
                //Menu de entrada;
                int inputNumeroImpar;
                if (!GetInputInt("Insira um numero impar para a criação do diamante: ", out inputNumeroImpar) || inputNumeroImpar % 2 == 0)
                {
                    Console.WriteLine("Numero invalido, digite qualquer tecla para tentar novamente...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                Console.WriteLine($"O numero digitado foi de {inputNumeroImpar}, Aqui está seu desenho: \n");
                #endregion


                #region Linha superior:                
                // Linha Superior
                for (int qntX = 1; qntX < inputNumeroImpar; qntX += 2)
                {
                    int espaços = (inputNumeroImpar - qntX) / 2;
                    Console.Write(new string(' ', espaços));
                    Console.WriteLine(new string('X', qntX));

                }
                #endregion


                #region Linha central:
                // Linha Meio
                for (int i = 0; i < inputNumeroImpar; i++)
                {
                    Console.Write("X");
                }

                Console.WriteLine();

                for (int qntX = inputNumeroImpar - 2; qntX >= 1; qntX -= 2)
                {
                    int espaços = (inputNumeroImpar - qntX) / 2;
                    Console.Write(new string(' ', espaços));
                    Console.WriteLine(new string('X', qntX));
                }
                break;
            }
        }
        #endregion


        #region final:
        static bool GetInputInt(string mensagem, out int userInput)
        {
            Console.WriteLine(mensagem);
            return int.TryParse(Console.ReadLine(), out userInput);
            Console.ReadLine();
            

            Console.ReadLine();


        }
    }
}
#endregion 