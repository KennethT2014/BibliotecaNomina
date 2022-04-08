using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BibliotecaNomina
{
    public partial class SueldoUIForm : Form
    {
        //número de controles TextBox en el formulario
        protected int CuentaTextBox = 5;

       
        public enum IndicesTextBox
        {
            NOMBRE,
            APELLIDO,
            SALARIOBRUTO,
            HORASTRABAJADAS,
            SALARIONETO
        }//fin de enum

        //constructor sin parámetros
        public SueldoUIForm()
        {
            InitializeComponent();
        }//fin del constructor

        public void LimpiarControlesTextBox()
        {
            //itera a través de cada Control en el formulario
            for (int i = 0; i < Controls.Count; i++)
            {
                Control miControl = Controls[i]; //obtiene el control

                //determina si el control es TextBox
                if (miControl is TextBox)
                {
                    //limpia la propiedad Text (establece cadena vacía)
                    miControl.Text = "";
                }//fin de if
            }//fin de for
        }//fin del método LimpiarControlesTextBox

        //Inicio del método para establecer valores y verificar la longitud de los TextBox
        public void EstablecerValoresControlesTextBox(string[] valores)
        {
            //determina si el arreglo string tiene la longitud correcta
            if (valores.Length != CuentaTextBox)
            {
                //lanza excepción si no tiene la longitud correcta
                throw (new ArgumentException("Debe haber " + (CuentaTextBox + 1) + " objetos string en el arreglo"));
            }//fin de if
            else
            {
                //establece el arreglo valores con los valores de los controles TextBox
                txtnombre.Text = valores[(int)IndicesTextBox.NOMBRE];
                txtapellido.Text = valores[(int)IndicesTextBox.APELLIDO];
                txtsalariobruto.Text = valores[(int)IndicesTextBox.SALARIOBRUTO];
                txthorastrabajadas.Text = valores[(int)IndicesTextBox.HORASTRABAJADAS];
                txtsalarioneto.Text = valores[(int)IndicesTextBox.SALARIONETO];
            }//fin del else
        }//fin del método EstablecerValoresControlesTextBox

        //devuelve los valores de los controles TextBox como un arreglo string
        public string[] ObtenerValoresControlesTexBox()
        {
            string[] valores = new string[CuentaTextBox];

            //Calcula el Salario Neto
            double SalarioBruto, SalarioNeto, HorasLaboradas;
            SalarioBruto = Convert.ToDouble(txtsalariobruto.Text);
            HorasLaboradas = Convert.ToDouble(txthorastrabajadas.Text);
            SalarioNeto = SalarioBruto * HorasLaboradas;
            txtsalarioneto.Text = SalarioNeto.ToString();

            //copia los campos de los controles TextBox al arreglo string
            valores[(int)IndicesTextBox.NOMBRE] = txtnombre.Text;
            valores[(int)IndicesTextBox.APELLIDO] = txtapellido.Text;
            valores[(int)IndicesTextBox.SALARIOBRUTO] = txtsalariobruto.Text;
            valores[(int)IndicesTextBox.HORASTRABAJADAS] = txthorastrabajadas.Text;
            valores[(int)IndicesTextBox.SALARIONETO] = txtsalarioneto.Text;

            return valores;
        }//fin del método ObtenerValoresControlesTexBox

        private void txtsalarioneto_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}

