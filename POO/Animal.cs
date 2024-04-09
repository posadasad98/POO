using System;

// Abstracción
public class Animal
{
    public string Nombre { get; set; } // Propiedad Nombre para almacenar el nombre del animal

    // Constructor de la clase Animal
    public Animal(string nombre)
    {
        Nombre = nombre; // Asigna el nombre proporcionado al atributo Nombre
    }
    public Animal() { }

    // Método virtual para que el animal se mueva
    public virtual void Moverse()
    {
        Console.WriteLine($"{Nombre} se está moviendo"); // Muestra un mensaje indicando que el animal se está moviendo
    }

    // Sobrecarga del método Moverse para especificar una dirección
    public void Moverse(string direccion)
    {
        Console.WriteLine($"{Nombre} se está moviendo en dirección {direccion}"); // Muestra un mensaje indicando que el animal se está moviendo en una dirección específica
    }
}



