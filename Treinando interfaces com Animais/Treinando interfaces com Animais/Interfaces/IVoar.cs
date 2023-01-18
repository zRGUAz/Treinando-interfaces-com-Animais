using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinando_interfaces_com_Animais.Interfaces
{
    public interface IVoar
    {
        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public void Voar();
    }
}
