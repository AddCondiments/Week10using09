using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10using09
/*
 * Name: Matthew Watada
 * July 11th 2017
 * Description: This is the abstract class
 * Version: 0.4 
 * Now with a ToString, all I needed was a way to display it.
 */
{
    class Program
    {
        static void Main(string[] args)
        {
            SuperHuman superHuman = new SuperHuman("Super Dude");
            superHuman.AddPower("Spider Climbing", 50);
            superHuman.AddPower("Webcasting", 40);
            Console.WriteLine(superHuman.ToString());
            SuperVillian superVillian = new SuperVillian("Baddie McBaddington", 9001);
            superVillian.AddPower("Malevolent Stare", 420);
            superVillian.AddPower("Imminent Betrayal", 69);
            Console.WriteLine(superVillian.ToString());

            if (superVillian is IHasMalice)
            {
                Console.WriteLine("lolxd");
            }

            // No instanciated SuperHero type, and superHuman does not implement interfaces, so I used superVillian
        }
    }
}