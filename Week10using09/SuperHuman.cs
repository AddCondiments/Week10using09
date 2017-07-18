using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week10using09
{
    /*
 * Name: Matthew Watada
 * July 11th 2017
 * Description: This is the abstract class
 * Version: 0.3 Now that I have the "Power" class that I was missing, I can work on this class
 * (finally)
 * Update: Code provided by Tom! I couldn't get the repository to for my updated solution to work iwth github, so I copied the code over for efficiency.
 * will go through later and rehash the comments as I would have done them.
 */
    /// <summary>
    /// This is the SuperHuman class.
    /// </summary>
    public class SuperHuman : Human
    {
        // PRIVATE INSTANCE VARIABLES
        private List<Power> _powers;

        // PUBLIC PROPERTIES
        public List<Power> Powers
        {
            get
            {
                return this._powers; // this returns a reference
            }
        }

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor for the SuperHuman class.
        /// It takes one parameter - name (string)
        /// </summary>
        /// <param name="name"></param>
        public SuperHuman(string name)
            : base(name)
        {
            this._initialize();
        }

        // PRIVATE METHODS

        /// <summary>
        /// This method initializes, instantiates and assigns values to class properties
        /// </summary>
        private void _initialize()
        {
            this._powers = new List<Power>(); // creates an empty list
        }

        /*Goes through all powers, if the loop gets to the highest value Powers.Count, and becomes
         * the same as the index counter, it returns a value to indicate to the user that no such power was found.
         */

        private int _findPowerIndex(string name)
        {
            int index = 0;
            foreach(Power power in this.Powers)
            {
                if(name.Equals(power.Name))
                {
                    break;
                }

                index++;

                if(this.Powers.Count == index)
                {
                    index = -1;
                }
            }

            return index;
        }

        // PUBLIC METHODS

        /// <summary>
        /// This method adds a power to the Power List.
        /// It takes two parameters - name (string) - rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public void AddPower(string name, int rank)
        {
            this.Powers.Add(new Power(name, rank));
        }

        /// <summary>
        /// This method displays each of the Powers stored in the Powers List
        /// </summary>
        public void DisplayPowers()
        {
            foreach (Power power in this.Powers)
            {
                Console.WriteLine("Power: " + power.Name + " Rank: " + power.Rank);
            }
        }

        /// <summary>
        /// The ToString method overrides the build-in Object.ToString method.
        /// It outputs a string that displays the superhuman's name and their powers.
        /// </summary>
        /// <returns></returns>
        // String Override Method
        public override string ToString()
        {
            string outputString = "";
            outputString += "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n";
            outputString += "Name: " + this.Name + "\n" + "";
            outputString += "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n";
            foreach (Power power in this.Powers)
            {
                outputString += "Power: " + power.Name + " Rank: " + power.Rank + "\n";
            }
            outputString += "-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-\n";
            return outputString;
        }

        public override void DisplaySkills()
        {
            Console.WriteLine("Not Implemented!");
        }
    }
}