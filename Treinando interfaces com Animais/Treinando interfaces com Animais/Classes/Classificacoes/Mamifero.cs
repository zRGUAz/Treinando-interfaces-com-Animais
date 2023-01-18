using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando_interfaces_com_Animais.Classes.Classificacoes
{
    public class Mamifero : Animal
    {
        public int QtdDeMamas { get; set; }
        public bool Pelos { get; set; }
        public string CorDoPelo { get; set; }

        public void Amamentar()
        {
            Console.WriteLine(Nome + " esta amamentando seu filhote");
            Thread.Sleep(1500);
        }

        public void TextoMamifero()
        {
            Console.WriteLine("Quantidades de Mamas: " + QtdDeMamas);
            Console.WriteLine("Possui Pelos: " + Pelos);
            Console.WriteLine("Cor do Pelo: " + CorDoPelo);
            Thread.Sleep(2500);

            Console.WriteLine();
        }
    }
}
