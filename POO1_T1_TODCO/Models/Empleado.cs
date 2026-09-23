namespace POO1_T1_TODCO.Models
{
    public class Empleado
    {
        private string idEmpleado;
        private string nomapeEmpleado;
        private string categoriaEmpleado;
        private int nHijos;
        private string tipoContrato;

        public string IdEmpleado
        {
            get { return idEmpleado; }
            set { idEmpleado = value; }
        }

        public string NomapeEmpleado
        {
            get { return nomapeEmpleado; }
            set { nomapeEmpleado = value; }
        }

        public string CategoriaEmpleado
        {
            get { return categoriaEmpleado; }
            set { categoriaEmpleado = value; }
        }

        public int NHijos
        {
            get { return nHijos; }
            set { nHijos = value; }
        }

        public string TipoContrato
        {
            get { return tipoContrato; }
            set { tipoContrato = value; }
        }

        public double SueldoBasico()
        {
            if (CategoriaEmpleado == "E1")
                return 5500;
            else if (CategoriaEmpleado == "E2")
                return 2500;
            else if (CategoriaEmpleado == "E3")
                return 2200;
            else
                return 1700;
        }

        public double Escolaridad()
        {
            return NHijos * 108;
        }

        public virtual double Bonificacion()
        {
            if (TipoContrato == "Indefinido")
                return SueldoBasico() * 0.15;
            else
                return SueldoBasico() * 0.10;
        }

        public virtual double MontoAPagar()
        {
            return SueldoBasico() + Escolaridad() + Bonificacion();
        }
    }
}