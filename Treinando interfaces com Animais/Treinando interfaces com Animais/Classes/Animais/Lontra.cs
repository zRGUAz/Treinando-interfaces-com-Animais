using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Classes.Classificacoes;
using Treinando_interfaces_com_Animais.Interfaces;

namespace Treinando_interfaces_com_Animais.Classes.Animais
{
    public class Lontra : Mamifero, IAquatico
    {
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }

        public Lontra()
        {
            Nome = "Vivian";
            DataDeNascimento = new DateTime(1999, 02, 17);
            Sexo = 'F';
            Carnivoro = true;
            Peconhento = false;

            QtdDeMamas = 6;
            Pelos = true;
            CorDoPelo = "Marrom";

            ViveEmTerra = true;
            Mergulho = true;
            AguaDoce = true;

            //

            TextoAnimal();
            TextoMamifero();

            Console.WriteLine("Consegue Viver na Terra: " + ViveEmTerra);
            Console.WriteLine("Consegue Mergulhar: " + Mergulho);
            Console.WriteLine("Vive em Agua Doce: " + AguaDoce);
            Thread.Sleep(1250);

            Console.WriteLine();

            Amamentar();
            Movimentar();
            Comunicar();
            Alimentar();

            Console.Clear();
        }
    }
}
