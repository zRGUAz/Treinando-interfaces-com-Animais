using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Classes.Classificacoes;
using Treinando_interfaces_com_Animais.Interfaces;

namespace Treinando_interfaces_com_Animais.Classes.Animais
{
    public class Ornitorrinco : Mamifero, IAquatico, IOviparo
    {
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }

        public void Botar()
        {
            Console.WriteLine("Ornitorrincos conseguem botar ovos");
            Thread.Sleep(1000);
        }
        public void Chocar()
        {
            Console.WriteLine("Demora aproximadamente 14 dias para o ovo chocar");
            Thread.Sleep(1000);
        }

        public Ornitorrinco()
        {
            Nome = "Perry";
            DataDeNascimento = new DateTime(2003, 09, 12);
            Sexo = 'M';
            Carnivoro = true;
            Peconhento = true;

            QtdDeMamas = 0;
            Pelos = true;
            CorDoPelo = "Marrom Escuro";

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

            Botar();
            Chocar();

            Console.WriteLine();

            Movimentar();
            Comunicar();
            Alimentar();

            Console.Clear();
        }
    }
}
