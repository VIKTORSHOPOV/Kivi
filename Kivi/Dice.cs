using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kivi
{
    public class Dice
    {
        
        bool locked;
        int rolledValue;

        // Constructor
        public Dice(bool boolValue, int rollValue)
        {
            locked = boolValue;
            rolledValue = rollValue;
        }

        
        public bool Locked
        {
            get { return locked; }
            set { locked = value; }
        }

        
        public int RolledValue
        {
            get { return rolledValue; }
            set { rolledValue = value; }
        }
    }
}
