using System;
class Human
{
    // Properties for Human
    //Cree una clase Humana con cuatro campos públicos: Name (string) , Strength (int), Intelligence (int), Dexterity (int)
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    public int Health;
   /* Agrega un constructor que toma un valor para establecer el Nombre y establece los campos restantes con los 
   valores predeterminados
   Agregue un método constructor que tome una cadena para inicializar el Nombre, y que inicializará la Fuerza, 
   la Inteligencia y la Destreza a un valor predeterminado de 3, y la salud al valor predeterminado de 100.*/
     public Human(string name){
        Name = name;
        Strength = 3;
        Intelligence = 3;
        Dexterity = 3;
        Health = 100;
    }
    /* Agrega un constructor para asignar valores personalizados a todos los campos
    Creemos un constructor adicional que acepte 5 parámetros, para que podamos establecer valores personalizados para cada 
    campo.*/
    public Human(string name, int strength, int intelligence, int dexterity, int health){
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = health;
    }
    /*Construir método de ataque
    Ahora agregue un nuevo método llamado Ataque, que cuando se invoca, debería reducir la salud de un objeto Humano que 
    se pasa como parámetro. El daño realizado debe ser 3 * fuerza (3 puntos de daño al atacado, por cada 1 punto de fuerza 
    del atacante). Este método debería devolver la salud restante del objeto de destino.*/
    public int Attack(Human target)
    {
        int damage = 3 * Strength; // Cálculo del daño basado en la fuerza del atacante
        target.Health -= damage;   // Reducción de la salud del objetivo
        return target.Health;      // Devolución del estado restante del objetivo

    }
}


