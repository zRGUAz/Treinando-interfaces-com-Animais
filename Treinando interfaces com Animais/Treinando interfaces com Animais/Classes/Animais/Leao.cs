using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinando_interfaces_com_Animais.Classes.Classificacoes;

namespace Treinando_interfaces_com_Animais.Classes.Animais
{
    public class Leao : Mamifero
    {
        public Leao()
        {
            Nome = "Nala";
            DataDeNascimento = new DateTime(2000, 06, 14);
            Sexo = 'F';
            Carnivoro = true;
            Peconhento = false;

            QtdDeMamas = 6;
            Pelos = true;
            CorDoPelo = "Amarelo alaranjado";

            //

            TextoAnimal();
            TextoMamifero();

            Amamentar();
            Movimentar();
            Comunicar();
            Alimentar();

            Console.Clear();
        }
    }
}
