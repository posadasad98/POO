using POO;
using System;

class Program
{
    
    static void Main(string[] args)
    {
        // Creación de una instancia de Animal y llamada al método Moverse
        Animal animalGenerico = new Animal("Criatura");
        animalGenerico.Moverse(); //Clase Animal
        Console.WriteLine("---------------------------------------------------------");
        // Creación de una instancia de Mamifero y llamada a los métodos Moverse y Amamantar
        Mamifero mamiferoGenerico = new Mamifero("Mamífero", "corto");
        mamiferoGenerico.Moverse(); //Clase Animal
        mamiferoGenerico.Amamantar(); //Clase Mamifero
        Console.WriteLine("---------------------------------------------------------");
        // Creación de una instancia de Perro y llamada a los métodos Moverse, Amamantar y Ladrar
        Perro perro = new Perro("Bobby", "largo", "Labrador");
        perro.Moverse();//Clase animal
        perro.Amamantar(); // Heredado de Mamifero
        perro.Ladrar(); //Clase Perro
        perro.Moverse("a casa"); //Clase Animal
        Console.WriteLine("---------------------------------------------------------");
        Console.ReadLine();
    }
}
