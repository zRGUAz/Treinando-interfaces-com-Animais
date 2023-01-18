using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando_interfaces_com_Animais.Classes.Classificacoes
{
    public class Ave : Animal
    {
        public bool Rapina { get; set; }
        public string CorPena { get; set; }

        public void Ciscar()
        {
            Console.WriteLine(Nome + " esta ciscando");
            Thread.Sleep(1500);
        }

        public void TextoAve()
        {
            Console.WriteLine("Ave de Rapina: " + Rapina);
            Console.WriteLine("Cor da Pena: " + CorPena);
            Thread.Sleep(2500);

            Console.WriteLine();
        }
    }
}
