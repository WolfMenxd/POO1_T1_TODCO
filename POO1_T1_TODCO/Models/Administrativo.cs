namespace POO1_T1_TODCO.Models
{
    public class Administrativo : Empleado
    {
        private int añoIngreso;
        private bool postGrado;

        public int AñoIngreso
        {
            get { return añoIngreso; }
            set { añoIngreso = value; }
        }

        public bool PostGrado
        {
            get { return postGrado; }
            set { postGrado = value; }
        }

        public double Incentivo()
        {
            if (PostGrado == true)
                return 500;
            else
                return 0;
        }

        public override double Bonificacion()
        {
            int añosServicio = DateTime.Now.Year - AñoIngreso;

            if (añosServicio < 5)
                return 200;
            else if (añosServicio <= 10)
                return 450;
            else
                return 300;
        }

        public override double MontoAPagar()
        {
            return SueldoBasico() + Bonificacion() + Escolaridad() + Incentivo();
        }
    }
}