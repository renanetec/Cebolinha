using System;

namespace cebolinha
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            string boasvindas = "Bem Vindo!";
            string explicação = "digite aqui:O rato roeu a roupa do rei de roma";
            //digite acima:O rato roeu a roupa do rei de roma
            //salve, e depois execute no terminal o comando "dotnet run"
            string mensagem = $@"{boasvindas}
            
            {explicação}.";

            string novaMensagem = mensagem.Replace("r", "l");

            Console.WriteLine(novaMensagem);
            Console.ResetColor();

        }
    }
}
