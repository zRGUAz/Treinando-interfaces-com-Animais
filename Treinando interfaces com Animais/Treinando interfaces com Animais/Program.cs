using Treinando_interfaces_com_Animais.Classes.Animais;

namespace Treinando_interfaces_com_Animais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\t---------------------------------\n\t\tBem Vindos ao Zoo\t\n\t---------------------------------");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("\t--------------------\n\t\tLEÃO\t\n\t--------------------\n");
            Leao leao = new Leao();

            Console.WriteLine("\t----------------------\n\t\tCHACAL\t\n\t----------------------\n");
            Chacal chacal = new Chacal();

            Console.WriteLine("\t-----------------------\n\t\tMORCEGO\t\n\t-----------------------\n");
            Morcego morcego = new Morcego();

            Console.WriteLine("\t---------------------\n\t\tCISNE\t\n\t---------------------\n");
            Cisne cisne = new Cisne();

            Console.WriteLine("\t---------------------\n\t\tARARA\t\n\t---------------------\n");
            Arara arara = new Arara();

            Console.WriteLine("\t--------------------------------\n\t\tDRAGÃO-DE-KOMODO\t\n\t--------------------------------\n");
            Dragao_de_Komodo dragao_De_Komodo = new Dragao_de_Komodo();

            Console.WriteLine("\t----------------------\n\t\tLONTRA\t\n\t----------------------\n");
            Lontra lontra = new Lontra();

            Console.WriteLine("\t-----------------------\n\t\tPINGUIM\t\n\t-----------------------\n");
            Pinguim pinguim = new Pinguim();

            Console.WriteLine("\t----------------------\n\t\tCORUJA\t\n\t----------------------\n");
            Coruja coruja = new Coruja();

            Console.WriteLine("\t------------------------\n\t\tELEFANTE\t\n\t------------------------\n");
            Elefante elefante = new Elefante();

            Console.WriteLine("\t----------------------\n\t\tJACARE\t\n\t----------------------\n");
            Jacare jacare = new Jacare();

            Console.WriteLine("Obrigado pela companhia\n");
            Console.WriteLine("Volte sempre");



        }
    }
}