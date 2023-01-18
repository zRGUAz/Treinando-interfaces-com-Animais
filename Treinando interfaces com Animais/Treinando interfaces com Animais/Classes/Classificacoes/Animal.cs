using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando_interfaces_com_Animais.Classes.Classificacoes
{
    public class Animal
    {
        public string Nome { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public char Sexo { get; set; }
        public bool Carnivoro { get; set; }
        public bool Peconhento { get; set; }

        public int Idade()
        {
            DateTime dataHoje = DateTime.Now;
            TimeSpan diferenca = dataHoje.Subtract(DataDeNascimento);
            return diferenca.Days / 365;
        }

        public void Movimentar()
        {
            Console.WriteLine(Nome + " esta se movendo");
            Thread.Sleep(1500);
        }

        public void Comunicar()
        {
            Console.WriteLine(Nome + " tenta se comunicar com você");
            Thread.Sleep(1500);
        }

        public void Alimentar()
        {
            Console.WriteLine(Nome + " começou a comer");
            Thread.Sleep(1500);
        }

        public void TextoAnimal()
        {
            Console.WriteLine("Nome: " + Nome);
            int idade = Idade();
            Console.WriteLine($"Idade: {idade} anos");
            Console.WriteLine("Sexo: " + Sexo);
            Console.WriteLine("Carnivoro: " + Carnivoro);
            Console.WriteLine("Peçonhento: " + Peconhento);

            Console.WriteLine();
        }
    }
}
