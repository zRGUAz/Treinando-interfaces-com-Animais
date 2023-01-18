using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Classes.Classificacoes;
using Treinando_interfaces_com_Animais.Interfaces;

namespace Treinando_interfaces_com_Animais.Classes.Animais
{
    public class Cisne : Ave, IAquatico, IOviparo, IVoar
    {
        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }

        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public void Voar()
        {
            Console.WriteLine(Nome + " voou para longe");
            Thread.Sleep(1500);
        }

        public void Botar()
        {
            Console.WriteLine("Cines conseguem botar ovos");
            Thread.Sleep(1000);
        }
        public void Chocar()
        {
            Console.WriteLine("Demora aproximadamente 19 dias para o ovo chocar");
            Thread.Sleep(1000);
        }

        public Cisne()
        {
            Nome = "Feioso";
            DataDeNascimento = new DateTime(1993, 11, 09);
            Sexo = 'M';
            Carnivoro = false;
            Peconhento = false;

            Rapina = false;
            CorPena = "Branca";

            ViveEmTerra = true;
            Mergulho = false;
            AguaDoce = true;

            AltitudeMaximaEmMetros = 429;
            VelocidadeDoVoo = 38;

            //

            TextoAnimal();
            TextoAve();

            Console.WriteLine("Consegue Viver na Terra: " + ViveEmTerra);
            Console.WriteLine("Consegue Mergulhar: " + Mergulho);
            Console.WriteLine("Vive em Agua Doce: " + AguaDoce);
            Thread.Sleep(1250);

            Console.WriteLine();

            Console.WriteLine($"Altitude Maxima de Voo: {AltitudeMaximaEmMetros} m");
            Console.WriteLine($"Velocidade do Voo: {VelocidadeDoVoo} Km/h");
            Thread.Sleep(1250);

            Console.WriteLine();

            Botar();
            Chocar();

            Console.WriteLine();

            Movimentar();
            Comunicar();
            Alimentar();
            Voar();

            Console.Clear();
        }

    }
}
