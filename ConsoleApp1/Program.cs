using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Character Hero = new Character("Hero", 100,50,30);
            Character Méchant = new Character("Méchant", 100, 50, 20);

            while (Méchant.lifePoint > 0 && Hero.lifePoint > 0 )
            {
              
                if (Hero.IsAlive() && Méchant.IsAlive())
                {
                    Hero.Attack(Hero, Méchant);
                    Console.WriteLine("hero Attack");
                   
                }


                if(Méchant.IsAlive() == false)
                {
                    Console.WriteLine("Méchant mort");
                }



                if (Méchant.IsAlive() && Hero.IsAlive())
                {
                    Méchant.Attack(Méchant, Hero);
                    
                }


                if (Hero.IsAlive() && Méchant.IsAlive() == false)
                {
                    Console.WriteLine("hero Winners");
                }
                if (Méchant.IsAlive() && Hero.IsAlive() == false)
                {
                    Console.WriteLine("Méchant Winners");
                }



            }

        }
    }
}
