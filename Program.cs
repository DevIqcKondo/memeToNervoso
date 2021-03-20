using System;

namespace memeToNervoso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.Write("Digite seu nome: ");
            Console.ForegroundColor=ConsoleColor.White;
            string textoDigitado = Console.ReadLine();
            Console.ForegroundColor=ConsoleColor.Red;
            Console.Write("Olá, ");
            Console.Write(textoDigitado);
            Console.WriteLine("!");
            Console.WriteLine("Temos mais uma pergunta para você!");
            Console.WriteLine("Tecle ENTER para continuar.");
            Console.ReadKey();
            Console.Write("Então ");
            Console.Write(textoDigitado);
            Console.WriteLine(",  que você pensa sobre esse programa? ");
            Console.ForegroundColor=ConsoleColor.White;
            string meme = Console.ReadLine();
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("E sabe o que eu penso sobre você? Você é mui...");
            Console.WriteLine("NÃO PERA. To nervoso -_- ");
            Console.ResetColor();
        }
    }
}
