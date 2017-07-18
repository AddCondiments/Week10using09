using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week10using09
{
    public class SuperVillian : SuperHuman, IHasMalice
    {
        // Private Instance variables
        private int _malice;
        // Public Properties
        public int Malice
        {
            get
            {
                return this._malice;
            }
            set
            {
                this._malice = value;
            }
        }

        // Constructors
        public SuperVillian(string name, int malice)
            : base(name)
        {
            this.Malice = malice;
        }
        // Private Methods
        // Public Methods
    }
}