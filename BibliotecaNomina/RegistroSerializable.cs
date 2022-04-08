using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaNomina
{
    [Serializable]
    public class RegistroSerializable
    {
        private string nombres;
        private string apellidos;
        private decimal salarioBruto;
        private int horasTrabajadas;
        private decimal salarioNeto;

        // El constructor sin parámetros establece los miembros
        // a los valores predeterminados
        public RegistroSerializable() : this("", "", 0.0M, 0, 0.0M)
        {

        } // Fin del constructor


        // El constructor sobrecargado, establece los miembros
        // a los valores de los parámetros
        public RegistroSerializable(string valorNombre, string valorApellidos, decimal valorSalarioBruto, int valorHorasTrabajadas, decimal valorSalarioNeto)
        {
            Nombres = valorNombre;
            Apellidos = valorApellidos;
            SalarioBruto = valorSalarioBruto;
            HorasTrabajadas = valorHorasTrabajadas;
            SalarioNeto = valorSalarioNeto;
        }// Fin del constructor

        // propiedades que obtienen y establecen las variables de clase
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public decimal SalarioBruto { get => salarioBruto; set => salarioBruto = value; }
        public int HorasTrabajadas { get => horasTrabajadas; set => horasTrabajadas = value; }
        public decimal SalarioNeto { get => salarioNeto; set => salarioNeto = value; }

    }
    // Fin de clase RegistroSerializable
}
