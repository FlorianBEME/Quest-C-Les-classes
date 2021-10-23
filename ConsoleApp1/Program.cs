using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Character1 = new Character("Perso 1", 100,50,20);
            Character Character2 = new Character("Perso 2", 100, 50, 20);

            while (Character1.lifePoint == 0 || Character2.lifePoint == 0)
            {

                Character1.Attack(Character2.attack);
                if (Character1.IsAlive())
                {
                    Console.WriteLine(Character1.name + "est en vie");
                }
                else
                {
                    Console.WriteLine(Character1.name + "est mort");
                }


                Character2.Attack(Character1.attack);
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
