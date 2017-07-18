using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week10using09
{
    /*
 * Name: Matthew Watada
 * July 12th 2017
 * Description: This is the abstract class
 * Version: 0.2 Now with Power class (holpefully) which is prerequisite to the SuperHuman class
 */
    /// <summary>
    /// This is the Power class which will be used as a Data type
    /// </summary>
    public class Power
    {
        // PUBLIC PROPERTIES
        public string Name { get; set; }
        public int Rank { get; set; }

        // CONSTRUCTORS -----------------------------------

        /// <summary>
        /// This is the main constructor for the Power class.
        /// It takes two arguments - name (string) - rank (int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="rank"></param>
        public Power(string name, int rank)
        {
            this.Name = name;
            this.Rank = rank;
        }

        //Overload Methods, possibly may not work, we'll see

        public static bool operator >(Power lhs, Power rhs)
        {
            return (lhs.Rank > rhs.Rank);
        }

        public static bool operator <(Power lhs, Power rhs)
        {
            return (lhs.Rank < rhs.Rank);
        }
    }
}