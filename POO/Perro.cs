using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    // Clase Perro que hereda de Mamifero
    public class Perro : Mamifero
    {
        public string Raza { get; set; } // Propiedad Raza para almacenar la raza del perro

        // Constructor de la clase Perro
        public Perro(string nombre, string tipoPelo, string raza) : base(nombre, tipoPelo)
        {
            Raza = raza; // Asigna la raza proporcionada al atributo Raza
        }

        // Constructor sobrecargado que inicializa con dirección 
        public Perro(string nombre, string tipoPelo, string raza, string direccion) : base(nombre, tipoPelo, direccion)
        {
            Raza = raza; // Asigna la raza proporcionada al atributo Raza
        }

        // Método para que el perro ladre
        public void Ladrar()
        {
            Console.WriteLine($"{Nombre} está ladrando"); // Muestra un mensaje indicando que el perro está ladrando
        }

        // Sobrecarga del método Moverse para que el perro se mueva corriendo
        public override void Moverse()
        {
            Console.WriteLine($"{Nombre}  está corriendo"); // Muestra un mensaje indicando que el perro se está moviendo corriendo
        }
    }
}
