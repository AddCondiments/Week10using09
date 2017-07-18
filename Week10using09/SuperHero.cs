using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week10using09
{
    /* I don't really thing you need my name but,   ...Matthew Watada
     * Date: July 13th, 2017
     * Desctiption: another class
     * Version 0.1 But it's a super-hero this time
     */
    public class SuperHero : SuperHuman, IHasKarma
    {
        // Private Instance variables
        private int _karma;
        // Public Properties
        public int Karma
        {
            get
            {
                return this._karma;
            }
            set
            {
                this._karma = value;
            }
        }

        // Constructors
        public SuperHero(string name, int karma)
            : base(name)
        {
            this.Karma = karma;
        }
        // Private Methods
        // Public Methods
    }
}