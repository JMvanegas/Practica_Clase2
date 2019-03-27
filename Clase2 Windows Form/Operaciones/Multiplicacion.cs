using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Multiplicacion
    {
        private double m1, m2, Resultado;

        public double ResultadoM1
        {
            get { return Resultado; }
            set { Resultado = value; }
        }

        public double M2
        {
            get { return m2; }
            set { m2 = value; }
        }

        public double M1
        {
            get { return m1; }
            set { m1 = value; }
        }

        public Multiplicacion()
        {
            this.m1 = 0;
            this.m2 = 0;
        }

        public double CalcularM()
        {
            Resultado = M1 * M2;
            return Resultado;
        }
    }
}
