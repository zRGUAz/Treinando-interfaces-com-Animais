using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Classes.Classificacoes;
using Treinando_interfaces_com_Animais.Interfaces;

namespace Treinando_interfaces_com_Animais.Classes.Animais
{
    public class Dragao_de_Komodo : Reptil, IOviparo
    {
        public void Botar()
        {
            Console.WriteLine("Dragões-de-Komodo conseguem botar ovos");
            Thread.Sleep(1000);
        }
        public void Chocar()
        {
            Console.WriteLine("Demora aproximadamente 20 dias para o ovo chocar");
            Thread.Sleep(1000);
        }

        public Dragao_de_Komodo()
        {
            Nome = "Ko";
            DataDeNascimento = new DateTime(1981, 03, 20);
            Sexo = 'F';
            Carnivoro = true;
            Peconhento = true;

            TemEscamas = true;
            TemCasco = false;

            //

            TextoAnimal();
            TextoReptil();

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
