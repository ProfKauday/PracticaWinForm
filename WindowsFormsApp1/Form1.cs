using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Creo una lista del objeto empleado para guardar los datos ingresados
        private List<Empleado> Empleados = new List<Empleado>();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void btnGuardar_Click(object sender, EventArgs e)
        {
            //Antes de guardar valida los datos. si estan bien los guarda en la lista Empleados
            if (Validar())
            {
                Empleados.Add(new Empleado(txtNombre.Text, txtApellido.Text, Int32.Parse(txtDni.Text)));
                //MessageBox.Show("El Dato se guardo correctamente");
                //Imprimo en el label cuantos datos v ingresando
                lblGuardar.Text = "Usted ha ingresado : " + (Empleados.Count) + " Datos";
                txtNombre.Clear();
                txtApellido.Clear();
                txtDni.Clear();
            }
            else
            {
                MessageBox.Show("Intente nuevamente");
               
            }
           

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        { //Limpia el formulario
            txtNombre.Clear();
            txtApellido.Clear();
            txtDni.Clear();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private bool Validar()
        {
            //valida los campos ingresados por el usuario
            bool datoValido;
            datoValido = true;  

            if (txtNombre.Text.Trim() == "")
            {
               //Utilizo el errorProvider (solo para que sepamos de su existencia)
                error1.SetError(txtNombre, "Nombre vacio");
                MessageBox.Show(error1.GetError(txtNombre));
                txtNombre.Focus();
                datoValido = false;

            }
            else
            {
                error1.Clear();
            }


            if (txtApellido.Text.Trim() == "")
            {
                MessageBox.Show("El Apellido esta vacío");
                txtApellido.Focus();
                datoValido = false;
            }


            //Valida el DNI si esta vacio o si el dato no es numerico
            if (txtDni.Text.Trim() == "" || !Int32.TryParse(txtDni.Text, out int result))
            {
                MessageBox.Show("El dato DNI es incorrecto o esta vacio");
                txtDni.Focus();
                datoValido = false;
            }
            return datoValido;
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            //Muestra en pantalla los datos ingresados
            if (Empleados.Count!=0)
            {     
                      foreach (Empleado Item in Empleados)

                      {
                
                        MessageBox.Show ("Dni ingresado: " + Item.Dni);
                        
                       }
            }
            else
            {
                MessageBox.Show("No hay datos para mostrar");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //en el load incializo lo necesario
            lblGuardar.Text = "";
        }
    }
}
