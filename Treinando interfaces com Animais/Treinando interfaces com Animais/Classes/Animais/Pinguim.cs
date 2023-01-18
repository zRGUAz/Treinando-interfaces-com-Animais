using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Classes.Classificacoes;
using Treinando_interfaces_com_Animais.Interfaces;

namespace Treinando_interfaces_com_Animais.Classes.Animais
{
    public class Pinguim : Ave, IAquatico, IOviparo
    {
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }

        public void Botar()
        {
            Console.WriteLine("Pinguins conseguem botar ovos");
            Thread.Sleep(1000);
        }
        public void Chocar()
        {
            Console.WriteLine("Demora aproximadamente 27 dias para o ovo chocar");
            Thread.Sleep(1000);
        }

        public Pinguim()
        {
            Nome = "Cody";
            DataDeNascimento = new DateTime(1998, 11, 13);
            Sexo = 'M';
            Carnivoro = true;
            Peconhento = false;

            Rapina = false;
            CorPena = "Preto e Branca";

            ViveEmTerra = true;
            Mergulho = true;
            AguaDoce = true;

            //

            TextoAnimal();
            TextoAve();

            Console.WriteLine("Consegue Viver na Terra: " + ViveEmTerra);
            Console.WriteLine("Consegue Mergulhar: " + Mergulho);
            Console.WriteLine("Vive em Agua Doce: " + AguaDoce);
            Thread.Sleep(1250);

            Console.WriteLine();

            Botar();
            Chocar();

            Console.WriteLine();

            Movimentar();
            Ciscar();
            Comunicar();
            Alimentar();

            Console.Clear();
        }
    }
}
