using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Classes.Classificacoes;

namespace Treinando_interfaces_com_Animais.Classes.Animais
{
    public class Chacal : Mamifero
    {
        public Chacal()
        {
            Nome = "Chack";
            DataDeNascimento = new DateTime(2020, 11, 23);
            Sexo = 'M';
            Carnivoro = true;
            Peconhento = false;

            QtdDeMamas = 4;
            Pelos = true;
            CorDoPelo = "Preto e Dourado";

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
