using System;

namespace DoD_course
{
    class Program
    {
        static void Main(string[] args)
        {
            Character ch = new Character("Thor");

            Console.WriteLine($"Name: {ch.Name}");
            Console.WriteLine($"Character Length: {ch.SizeInCM} cm");
            Console.WriteLine("STR: " + ch.Attributes.Strength);
            Console.WriteLine("CON: " + ch.Attributes.Constituion);
            Console.WriteLine("INT: " + ch.Attributes.Intelligence);
            Console.WriteLine("WIS: " + ch.Attributes.Wisdom);
            Console.WriteLine("DEX: " + ch.Attributes.Dexterity);
            Console.WriteLine("CHA: " + ch.Attributes.Charisma);
            Console.WriteLine("SIZE: " + ch.Attributes.Size);
        }
    }
}
