using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    //Herencia
    public class Mamifero : Animal
    {
        public string TipoPelo { get; set; } // Propiedad TipoPelo para almacenar el tipo de pelo del mamífero

        // Constructor de la clase Mamifero
        public Mamifero(string nombre, string tipoPelo) : base(nombre)
        {
            TipoPelo = tipoPelo; // Asigna el tipo de pelo proporcionado al atributo TipoPelo
        }

        // Constructor sobrecargado que inicializa con dirección de movimiento
        public Mamifero(string nombre, string tipoPelo, string direccion) : base(nombre)
        {
            TipoPelo = tipoPelo; // Asigna el tipo de pelo proporcionado al atributo TipoPelo
            Moverse(direccion); // Llama al método Moverse para mover al mamífero en una dirección específica
        }

        // Método para que el mamífero amamante a sus crías
        public void Amamantar()
        {
            Console.WriteLine($"{Nombre} está amamantando a sus crías"); // Muestra un mensaje indicando que el mamífero está amamantando a sus crías
        }
    }
}
