using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Classes.Classificacoes;
using Treinando_interfaces_com_Animais.Interfaces;

namespace Treinando_interfaces_com_Animais.Classes.Animais
{
    public class Morcego : Mamifero, IOviparo, IVoar
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public void Voar()
        {
            Console.WriteLine(Nome + " voou para longe");
            Thread.Sleep(1500);
        }

        public void Botar()
        {
            Console.WriteLine("Morcegos conseguem botar ovos");
            Thread.Sleep(1000);
        }
        public void Chocar()
        {
            Console.WriteLine("Demora aproximadamente 1 mes para o ovo chocar");
            Thread.Sleep(1000);
        }

        public Morcego()
        {
            Nome = "Bruce";
            DataDeNascimento = new DateTime(2021, 12, 27);
            Sexo = 'M';
            Carnivoro = false;
            Peconhento = false;

            QtdDeMamas = 2;
            Pelos = true;
            CorDoPelo = "Preto";

            AltitudeMaximaEmMetros = 180;
            VelocidadeDoVoo = 160;

            //

            TextoAnimal();
            TextoMamifero();

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
