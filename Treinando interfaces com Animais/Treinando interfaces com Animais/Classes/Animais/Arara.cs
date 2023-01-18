using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Classes.Classificacoes;
using Treinando_interfaces_com_Animais.Interfaces;

namespace Treinando_interfaces_com_Animais.Classes.Animais
{
    public class Arara : Ave, IOviparo, IVoar
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
            Console.WriteLine("Araras conseguem botar ovos");
            Thread.Sleep(1000);
        }
        public void Chocar()
        {
            Console.WriteLine("Demora aproximadamente 20 dias para o ovo chocar");
            Thread.Sleep(1000);
        }

        public Arara()
        {
            Nome = "Rio";
            DataDeNascimento = new DateTime(1976, 08, 18);
            Sexo = 'M';
            Carnivoro = false;
            Peconhento = false;

            Rapina = false;
            CorPena = "Azul e Amarelo";

            AltitudeMaximaEmMetros = 622;
            VelocidadeDoVoo = 78;

            //

            TextoAnimal();
            TextoAve();

            Console.WriteLine($"Altitude Maxima de Voo: {AltitudeMaximaEmMetros} m");
            Console.WriteLine($"Velocidade do Voo: {VelocidadeDoVoo} Km/h");
            Thread.Sleep(1250);

            Console.WriteLine();

            Botar();
            Chocar();

            Console.WriteLine();

            Movimentar();
            Ciscar();
            Comunicar();
            Alimentar();
            Voar();

            Console.Clear();
        }

    }
}
