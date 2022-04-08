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

namespace LeerArchivo
{
    public partial class Leer : SueldoUIForm
    {
        //permitimos que lea un archivo serializado binario
        private BinaryFormatter lector = new BinaryFormatter();
        //mantiene la conexión con el archivo
        private FileStream entrada;



        public Leer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //crea un cuadro de diálogo que permite al usuario abrir el archivo
            OpenFileDialog selectorArchivo = new OpenFileDialog();
            DialogResult resultado = selectorArchivo.ShowDialog();
            //nombre del archivo que contiene los datos
            string nombreArchivo;

            //sale del manejador de eventos si el usuario hace clic en Cancelar
            if (resultado == DialogResult.Cancel)
                return;
            //obtiene el nombre de archivo especificado
            nombreArchivo = selectorArchivo.FileName;
            LimpiarControlesTextBox();

            //muestra error si el usuario especifica un archivo inválido
            if (nombreArchivo == "" || nombreArchivo == null)
            {
                MessageBox.Show("Nombre de archivo inválido", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //crea objeto FileStream para obtener acceso de lectura al archivo
                entrada = new FileStream(nombreArchivo, FileMode.Open,
                    FileAccess.Read);

                BtnAbrir.Enabled = false;//deshabilita el botón Abrir archivo
                btnSiguiente.Enabled = true;//habilita el botón Siguiente Registro

            }//fin de else


        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            
            try
            {
                //obtiene el siguiente Registro disponible en el archivo
                RegistroSerializable registro = (RegistroSerializable)lector.Deserialize(entrada);

                //almacena los valores del Registro en un aareglo string temporal
                string[] valores = new string[]
                {

                    registro.Nombres.ToString(),
                    registro.Apellidos.ToString(),
                    registro.HorasTrabajadas.ToString(),
                    registro.SalarioBruto.ToString(),
                    registro.SalarioNeto.ToString(),
                };

                //copia los valores del arreglo string a los valores de los controles TextBox
                EstablecerValoresControlesTextBox(valores);
            }//fin de try
            catch (SerializationException)
            {
                entrada.Close();//cierra FileStream si no hay registros en el archivo
                BtnAbrir.Enabled = true;//habilita el botón abrir archivo
                btnSiguiente.Enabled = false;//deshabilita el botón Siguiente Registro
                LimpiarControlesTextBox();

                //notifica al usuario si no hay registros en el archivo
                MessageBox.Show("No hay más registros en el archivo", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }//fin de catch
        }
    }
}
