using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1

{
    public class Empleado
    {
        private string nombre { get; set; }
        private string apellido { get; set; }
        private int dni { get; set; }

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public int Dni
        { 
            get { return this.dni; }
            set { this.dni = value; }
        }

        public Empleado (string pNombre, string pApellido, int pDni)
        {
            nombre = pNombre;
            apellido = pApellido;
            dni = pDni;

        }

    }
}