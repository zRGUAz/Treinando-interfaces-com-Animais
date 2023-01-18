using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Classes.Classificacoes;

namespace Treinando_interfaces_com_Animais.Classes.Animais
{
    public class Elefante : Mamifero
    {
        public Elefante()
        {
            Nome = "Dumbo";
            DataDeNascimento = new DateTime(1986, 04, 15);
            Sexo = 'M';
            Carnivoro = false;
            Peconhento = false;

            QtdDeMamas = 2;
            Pelos = true;
            CorDoPelo = "Cinza";

            //

            TextoAnimal();
            TextoMamifero();

            Movimentar();
            Comunicar();
            Alimentar();

            Console.Clear();
        }
    }
}
