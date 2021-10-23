using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Character1 = new Character();
            Character Character2 = new Character();

            Character1.lifePoint = 100;
            Character1.force = 50;
            Character1.name = "Perso 1";
            Character1.defense = 10;

            Character2.lifePoint = 100;
            Character2.force = 20;
            Character2.name = "Perso 2";
            Character2.defense = 10;


            while (Character1.lifePoint == 0 || Character2.lifePoint == 0)
            {
                Character1.Attack(Character2.force);
                if (Character1.IsAlive())
                {
                    Console.WriteLine(Character1.name + "est en vie");
                }
                else
                {
                    Console.WriteLine(Character1.name + "est mort");
                }


                Character2.Attack(Character1.force);
                if (Character2.IsAlive())
                {
                    Console.WriteLine(Character2.name + "est en vie");
                }
                else
                {
                    Console.WriteLine(Character1.name + "est mort");
                }


            }

        }
    }
}
