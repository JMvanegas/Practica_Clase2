using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Division
    {
        private double d1, d2, Resultado;

        public double ResultadoD1
        {
            get { return Resultado; }
            set { Resultado = value; }
        }

        public double D2
        {
            get { return d2; }
            set { d2 = value; }
        }

        public double D1
        {
            get { return d1; }
            set { d1 = value; }
        }

        public Division()
        {
            this.d1 = 0;
            this.d2 = 0;
        }

        public double CalcularD()
        {
            Resultado = D1 / D2;
            return Resultado;
        }
    }
}
