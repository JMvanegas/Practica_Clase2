using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Restas
    {
        private double r1, r2, Resultado;

        public double Resultado1
        {
            get { return Resultado; }
            set { Resultado = value; }
        }

        public double R2
        {
            get { return r2; }
            set { r2 = value; }
        }

        public double R1
        {
            get { return r1; }
            set { r1 = value; }
        }
    
        public Restas()
        {
            this.r1 = 0;
            this.r2 = 0;
        }

        public double CalcularR()
        {
            Resultado = R1 - R2;
            return Resultado;
        }
    }

}
