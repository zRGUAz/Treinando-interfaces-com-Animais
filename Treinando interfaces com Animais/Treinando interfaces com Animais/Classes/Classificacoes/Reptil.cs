using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando_interfaces_com_Animais.Classes.Classificacoes
{
    public class Reptil : Animal
    {
        public bool TemEscamas { get; set; }
        public bool TemCasco { get; set; }

        public void TextoReptil()
        {
            Console.WriteLine("Possui Escamas: " + TemEscamas);
            Console.WriteLine("Possui Casco: " + TemCasco);
            Thread.Sleep(2500);

            Console.WriteLine();
        }
    }
}
