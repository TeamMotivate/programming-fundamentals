using System;

namespace Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());
            int restHealt = maximumHealth - currentHealth;
            int restEnergy = maximumEnergy - currentEnergy;
            string currentHealthAsChar= new String('|', currentHealth);
            string restHealthAsChar = new String('.', restHealt);
            string currentEnergyAsChar= new String('|', currentEnergy);
            string restEnergyAsChar=new String('.', restEnergy);
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{currentHealthAsChar}{restHealthAsChar}|");
            Console.WriteLine($"Energy: |{currentEnergyAsChar}{restEnergyAsChar}|");
        }
    }
}
