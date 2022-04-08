using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BibliotecaNomina;

namespace CrearArchivo
{
    public partial class Crear : SueldoUIForm
    {


        //objeto para serializar Registros en formato binario
        private BinaryFormatter aplicadorFormato = new BinaryFormatter();
        //mantiene la conexión con el archivo
        private FileStream salida;


        //constructor sin parámetros
        public Crear()
        {
            InitializeComponent();
        }//fin constructor

        //manejador para el evento clic de BtnIntroducirDatos_Click
        private void bntSalir_Click(object sender, EventArgs e)
        {

            //determina si el archivo existe o no
            if (salida != null)
            {
                try
                {
                    //cierra el archivo
                    salida.Close();
                }//fin de try
                //notifica al usuario del error al cerrar el archivo
                catch (IOException)
                {
                    MessageBox.Show("No se puede cerrar el archivo", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//fin de catch
            }//fin de if

            Application.Exit();
        }

        private void BtnGuardarComo_Click(object sender, EventArgs e)
        {
            //crea un cuadro de diálogo que permite al usuario guardar el
            //archivo
            SaveFileDialog selectorArchivo = new SaveFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();
            //nombre del archivo en el que se van a guardar los datos
            string nombreArchivo;

            //permite al usuario crear el archivo
            selectorArchivo.CheckFileExists = false;

            //sale del manejador de eventos si el usuario hace clic en "Cancelar"
            if (resultado == DialogResult.Cancel)
                return;

            //obtiene el nombre del archivo especificado
            nombreArchivo = selectorArchivo.FileName;

            //muestra error si el usuario especificó un archivo inválido
            if (nombreArchivo == "" || nombreArchivo == null)
                MessageBox.Show("Nombre de archivo inválido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
           
            else
            {
                //guarda el archivo mediante el objeto FileStream, si el usuario especificó un archivo válido
                try
                {
                    //abre el archivo con acceso de escritura
                    salida = new FileStream(nombreArchivo, FileMode.OpenOrCreate,
                        FileAccess.Write);

                    //deshabilita el botón Guardar y habilita el botón Introducir
                    BtnGuardarComo.Enabled = false;
                    btnEntrar.Enabled = true;
                }//fin de try
                //maneja la excepción si hay problema al abrir el archivo
                catch (IOException)
                {
                    //notifica al usuario si el archivo no existe
                    MessageBox.Show("Error al abrir el archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//fin de catch
            }//fin de else
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            //almacena el arreglo string de valores de los controles TextBox a serializar
            string[] valores = ObtenerValoresControlesTexBox();

            //Registro que contiene los valores de los controles TextBox  a serializar
            RegistroSerializable registro = new RegistroSerializable();

            //determina si el campo del control TextBox de la cuenta está vacío
            if (valores[(int)IndicesTextBox.HORASTRABAJADAS] != "")
            {
                //almacena los valores de los controles TextBox en Registro y lo serializa
                try
                {
                    //obtiene el valor del número de cuenta del control TextBox
                    int Horastrabajos = Int32.Parse(
                        valores[(int)IndicesTextBox.HORASTRABAJADAS]);

                    //determina si numeroCuenta es válido
                    if (Horastrabajos> 0)
                    {
                        //almacena los campos de los controles TextBox en Registro
                        registro.Nombres = valores[(int)IndicesTextBox.NOMBRE];
                        registro.Apellidos = valores[(int)IndicesTextBox.APELLIDO];
                        registro.SalarioBruto = Decimal.Parse(valores[(int)IndicesTextBox.SALARIOBRUTO]);
                        registro.HorasTrabajadas = int.Parse(valores[(int)IndicesTextBox.HORASTRABAJADAS]);
                        registro.SalarioNeto = Decimal.Parse(valores[(int)IndicesTextBox.SALARIONETO]);

                        //escribe el registro al objeto FileStream (serializa el objeto)
                        aplicadorFormato.Serialize(salida, registro);
                    }//fin de if
                    else
                    {
                        //notifica al usuario si el número de cuenta es inválido
                        MessageBox.Show("Número de cuenta inválido", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }//fin del else
                }//fin de try
                //notifica al usuario si ocurre un error en la serialización
                catch (SerializationException)
                {
                    MessageBox.Show("Error al escribir en archivo", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//fin de catch
                //notifica al usuario si ocurre un error en relación con el formato de los parámetros
                catch (FormatException)
                {
                    MessageBox.Show("Formato inválido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }//fin de catch

                LimpiarControlesTextBox();

            }//fin de if
        }
    }
}
