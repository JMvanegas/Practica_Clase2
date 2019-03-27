using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operaciones
{
    public class Operacion
    {
        private double v1, v2, Resultado;
        private string Datos;

        public double Resultado1
        {
            get { return Resultado; }
            set { Resultado = value; }
        }

        public double V2
        {
            get { return v2; }
            set { v2 = value; }
        }

        public double V1
        {
            get { return v1; }
            set { v1 = value; }
        }
        public Operacion()
        {
            this.v1 = 0;
            this.v2 = 0;
        }

        public double Calcular()
        {
            Resultado = V1 + V2;
            return Resultado;
        }
    }
}
